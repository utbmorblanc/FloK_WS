using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FloKWS
{
    public partial class TEST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
        //    List<string> listColumns = new List<String>();
        //    List<string> listValue = new List<String>();

        //    listColumns.Add("login_user");
        //    listValue.Add("login");

        //    listColumns.Add("password_user");
        //    listValue.Add("unpassw");

        //    listColumns.Add("email_user");
        //    listValue.Add("plop@abnaha.de");

        //    Global.insert_into_db(myconnexion, "user", listColumns, listValue);

        //}


        protected void Button1_Click(object sender, EventArgs e)
        {
            
            float km = 200;
            double latitude = 45.642938;
            double longitude = 6.062307;
            List<Station> list = this.GetNearestStations(latitude, longitude, km);

          

        }

        public List<Station> GetNearestStations(double myLatitude, double myLongitude, float km)
        {
            List<Station> Stations = new List<Station>();
            double maxLat, minLat, maxLong, minLong;

            // conversion du nb de km a chercher autour en degrés
            double longitudeRadius = Global.KmToLongitude(km, myLatitude);
            double latitudeRadius = Global.KmToLatitude(km);
            DateTime date = DateTime.Now;
            date.AddDays(-2);
            String dateSQL = Global.DateTimeToMySqlDateTime(date);

            // interval des latitudes et longitude pour la recherche
            maxLat = myLatitude + latitudeRadius;
            minLat = myLatitude - latitudeRadius;
            maxLong = myLongitude + longitudeRadius;
            minLong = myLongitude - longitudeRadius;

            //***************   SQL PART    **************/
            StringBuilder myString = new StringBuilder();


            myString.Append("SELECT  distinct ");
            myString.Append(" info.date_info,id_station, height_station, km_size_station, name_station, address_number_station, address_street_station, address_cp_station, address_city_station, id_region_region, longitude_station,latitude_station ");
            myString.Append(" FROM orblanc.station stat");
            myString.Append(" inner join orblanc.information info ");
            myString.Append("   on stat.id_station = info.id_station_station ");
            myString.Append(" WHERE ");
            myString.Append("         stat.latitude_station <= ").Append(maxLat.ToString().Replace(",", "."));
            myString.Append("   and   stat.latitude_station >= ").Append(minLat.ToString().Replace(",", "."));
            myString.Append("   and   stat.longitude_station <= ").Append(maxLong.ToString().Replace(",", "."));
            myString.Append("   and   stat.longitude_station >= ").Append(minLong.ToString().Replace(",","."));
            myString.Append(" HAVING ");
            myString.Append("         info.date_info >= ").Append(dateSQL);
            myString.Append(";");


            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            MySqlDataReader reader = Global.selectDataReader(myconnexion, myString.ToString());

         
            while (reader.Read())
            {
                int i = 0;
                int id_station = reader.GetInt32(i++);
                int height_station = reader.GetInt32(i++);
                int km_size_station = reader.GetInt32(i++);
                string name_station = reader.GetString(i++);
                double longitude_station = reader.GetDouble(i++);
                double latitude_station = reader.GetDouble(i++);
                int address_number_station = reader.GetInt32(i++);
                string address_street_station = reader.GetString(i++);
                int address_cp_station = reader.GetInt32(i++);
                string addresse_city_station = reader.GetString(i++);

                Station station = new Station(id_station, height_station, km_size_station, name_station, longitude_station, latitude_station, address_number_station, address_street_station, address_cp_station, addresse_city_station);

                Stations.Add(station);

            }

            return Stations;
        }
    }
}