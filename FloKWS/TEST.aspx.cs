using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            date = date.AddDays(-2);
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
            myString.Append("   and   stat.longitude_station >= ").Append(minLong.ToString().Replace(",", "."));
            myString.Append(" HAVING ");
            myString.Append("         info.date_info >= ").Append(dateSQL);
            myString.Append(";");

            try
            {
                MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);

                List<List<string>> listDatas = Global.selectDataReader(myconnexion, myString.ToString());


                foreach (List<string> data in listDatas)
                {

                    int i = 1;

                    int id_station = int.Parse(data[i++]);
                    int height_station = int.Parse(string.IsNullOrEmpty(data[i]) ? "0" : data[i]); 
                    i++;
                    int km_size_station = int.Parse(string.IsNullOrEmpty(data[i]) ? "0" : data[i]);
                    i++;
                    string name_station = data[i++];
                    int address_number_station = int.Parse(string.IsNullOrEmpty(data[i]) ? "0" : data[i]);
                    i++;
                    string address_street_station = data[i++];
                    int address_cp_station = int.Parse(string.IsNullOrEmpty(data[i]) ? "0" : data[i]);
                    i++;
                    string addresse_city_station = data[i++];
                    double longitude_station = Convert.ToDouble(string.IsNullOrEmpty(data[i]) ? "0" : data[i]);
                    i++;
                    double latitude_station = Convert.ToDouble(string.IsNullOrEmpty(data[i]) ? "0" : data[i]);
                  


                    Station station = new Station(id_station, height_station, km_size_station, name_station, longitude_station, latitude_station, address_number_station, address_street_station, address_cp_station, addresse_city_station);
                    Stations.Add(station);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Query:" + myString);
                return null;

            }

            return Stations;


        }
        
    }
}