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
        public List<Station> GetAllStations()
        {
            List<Station> Stations = new List<Station>();
            return Stations;
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

    }
}
