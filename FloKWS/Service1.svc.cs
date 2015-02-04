using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

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
            date.AddDays(-2);
            String dateSQL = Global.DateTimeToMySqlDateTime(date);

            // interval des latitudes et longitude pour la recherche
            maxLat = myLatitude + latitudeRadius;
            minLat = myLatitude - latitudeRadius;
            maxLong = myLongitude + longitudeRadius;
            minLong = myLongitude + longitudeRadius;

            //***************   SQL PART    **************/
            StringBuilder myString = new StringBuilder();

            // TOTEST 
            myString.Append("SELECT   ");
            myString.Append(" id_station, height_station, km_size_station, name_station, address_number_station, address_street_station, address_cp_station, address_city_station, id_region_region, longitude_station,latitude_station ");
            myString.Append(" FROM orblanc.station stat");
            myString.Append(" inner join orblanc.information info ");
            myString.Append("   on stat.id_station = info.id_station_station ");
            myString.Append(" WHERE ");
            myString.Append("         stat.latitude_station =< ").Append(maxLat);
            myString.Append("   and   stat.latitude_station >= ").Append(minLat);
            myString.Append("   and   stat.longitude_station =< ").Append(maxLong);
            myString.Append("   and   stat.longitude_station >= ").Append(minLong);
            myString.Append(" HAVING ");
            myString.Append("         info.date_info >= ").Append("'"+dateSQL+"'");
            myString.Append(";");


            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            MySqlDataReader reader = Global.selectDataReader(myconnexion, myString.ToString());

            while (reader.Read())
            {
                object oVal = reader. .GetValue(0);
                firstResult = DBNull.Value.Equals(oVal) ? String.Empty : oVal.ToString();
            }

            return Stations;
        }

        public List<Station> GetAllStations()
        {
            List<Station> Stations = new List<Station>();
            return Stations;
        }

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

        public bool isUserInDB(string login, string password)
        {
            StringBuilder myString = new StringBuilder();
            myString.Append("SELECT id_user FROM orblanc.user where login_user=");
            myString.Append("'"+login+"'");
            myString.Append(" and password_user=");
            myString.Append("'" + password + "';");

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


        public bool CreateUser(String login, String mail, String pwd)
        {
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            List<string> listColumns = new List<String>();
            List<string> listValue   = new List<String>();
          
            listColumns.Add("login_user");
            listValue.Add(login);

            listColumns.Add("password_user");
            listValue.Add(pwd);

            listColumns.Add("email_user");
            listValue.Add(mail);

            return Global.insert_into_db(myconnexion,"user", listColumns, listValue);
        }
    }
}
