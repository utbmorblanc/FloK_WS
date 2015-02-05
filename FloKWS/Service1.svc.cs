using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using CryptoMD5Sample;
//using Microsoft.Maps.MapControl.WPF;
//using Microsoft.Maps.MapControl.WPF.Design;
//using Microsoft.Maps;

namespace FloKWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {


        /// <summary>
        /// retourne une liste des stations proches dans l'ordre avec des informations récentes
        /// </summary>
        /// <param name="myLatitude"></param>
        /// <param name="myLongitude"></param>
        /// <param name="km"></param>
        /// <returns></returns>
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
            myString.Append(" info.date_info,id_station, height_station, km_size_station, name_station, address_number_station, address_street_station, address_cp_station, address_city_station, longitude_station,latitude_station ");
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

        public List<Station> GetAllStations()
        {
            List<Station> Stations = new List<Station>();
            return Stations;
        }

        //public int GetDistance(double myLatitude, double myLongitude, double stationLatitude, double stationLongitude)
        //{
        //    //GeoCoordinate positionDépart
        //    return 0;
        //}

        /// <summary>
        /// retourne true si login existant
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public bool isLoginInDB(string login)
        {
            StringBuilder myString = new StringBuilder();
            myString.Append("SELECT id_user FROM orblanc.user where login_user=");
            myString.Append("'" + login + "'");
            myString.Append(";");

            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            ResultSelectOneValue result = Global.selectOneValue(myconnexion, myString.ToString());

            if (String.IsNullOrEmpty(result.result))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isUserInDB(string login, string password){
      
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = CryptoMD5.GetMd5Hash(md5Hash, password);
             
                StringBuilder myString = new StringBuilder();
                myString.Append("SELECT id_user FROM orblanc.user where login_user=");
                myString.Append("'"+login+"'");
                myString.Append(" and password_user=");
                myString.Append("'" + hash + "';");

                MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
                ResultSelectOneValue result = Global.selectOneValue(myconnexion,myString.ToString());

                if (String.IsNullOrEmpty(result.result))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        public  bool CreateUser(string login, string mail, string pwd)
        {
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            List<string> listColumns = new List<String>();
            List<string> listValue   = new List<String>();
          
            listColumns.Add("login_user");
            listValue.Add(login);
            using (MD5 md5Hash = MD5.Create())
            {
                listColumns.Add("password_user");
                listValue.Add(CryptoMD5.GetMd5Hash(md5Hash,pwd));
            }
            listColumns.Add("email_user");
            listValue.Add(mail);

            return Global.insert_into_db(myconnexion,"user", listColumns, listValue);
        }


        public bool CreateInfo(int snowQuality, int snowQuantity, int wind, int weather, int idUser, int idStation, string date, double longitude, double latitude)
        {
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            List<string> listColumns = new List<String>();
            List<string> listValue = new List<String>();

            listColumns.Add("snow_quality_info");
            listValue.Add(snowQuality.ToString());

            listColumns.Add("snow_quantity_info");
            listValue.Add(snowQuantity.ToString());

            listColumns.Add("wind_info");
            listValue.Add(wind.ToString());

            listColumns.Add("weather_info");
            listValue.Add(weather.ToString());

            listColumns.Add("id_user_user");
            listValue.Add(idUser.ToString());

            listColumns.Add("id_station_station");
            listValue.Add(idStation.ToString());

            listColumns.Add("date_info");
            listValue.Add(date);

            string test = longitude.ToString();

            listColumns.Add("longitude_info");
            listValue.Add(longitude.ToString().Replace(",", "."));

            listColumns.Add("latitude_info");
            listValue.Add(latitude.ToString().Replace(",", "."));



            return Global.insert_into_db(myconnexion, "information", listColumns, listValue);
        }



    }
}
