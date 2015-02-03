using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FloKWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Business> GetBusinesses();

        [OperationContract]
        int ReturnResultAddition(int first, int second);
    }

    
    [DataContract]
    public class Business
    {
        //You can add any fields you would like to include
        bool isOpen = true;
        string name;
        string logoUri;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember] 
        public string LogoUri
        {
            get { return logoUri; }
            set { logoUri = value; }
        }

        [DataMember]
        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }
    }
}
