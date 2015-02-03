using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FloKWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {

        MySqlConnection cnx


        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        public List<Business> GetBusinesses()
        {
            var Businesses = new List<Business>();
            Businesses.Add(new Business() { IsOpen = true, LogoUri = "http://www.christianjvella.com/logosample1.png", Name = "Wine & Dine" });
            Businesses.Add(new Business() { IsOpen = true, LogoUri = "http://www.christianjvella.com/logosample2.png", Name = "Wine Bar" });
            Businesses.Add(new Business() { IsOpen = false, LogoUri = "http://www.christianjvella.com/logosample3.png", Name = "Restaurant" });
            Businesses.Add(new Business() { IsOpen = true, LogoUri = "http://www.christianjvella.com/logosample4.png", Name = "Sports Bar" });
            Businesses.Add(new Business() { IsOpen = false, LogoUri = "http://www.christianjvella.com/logosample5.png", Name = "Cinema" });
            return Businesses;
        }


        public int ReturnResultAddition(int first, int second)
        {
            return first + second;
        }
    }
}
