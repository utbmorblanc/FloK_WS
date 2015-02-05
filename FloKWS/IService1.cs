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
        // ici on met seulement la signature des fonctions

        [OperationContract]
        List<Station> GetNearestStations(double myLatitude, double myLongitude, float km);

        [OperationContract]
        List<Station> GetAllStations();

        [OperationContract]
        int GetDistance(double myLatitude, double myLongitude,double stationLatitude, double stationLongitude);

        [OperationContract]
        bool isLoginInDB(string login);


        [OperationContract]
        bool isUserInDB(string login, string password);

        [OperationContract]
        bool CreateUser(string login, string mail, string pwd);
    }

    // et on défini les classes
    #region station

    [DataContract]
    public class Station
    {
        //contructeurs
        public Station()
        {

        }

        public Station( int id_station,                 int height_station,         int km_size_station,        string name_station,
                        double longitude_station,       double latitude_station,    int address_number_station,
                        string address_street_station,  int address_cp_station,     string addresse_city_station)
        {
            this.id_station = id_station;
            this.height_station = height_station;
            this.km_size_station = km_size_station;
            this.name_station = name_station;
            this.longitude_station = longitude_station;
            this.latitude_station = latitude_station;
            this.address_number_station = address_number_station;
            this.address_street_station = address_street_station;
            this.address_cp_station = address_cp_station;
            this.addresse_city_station = addresse_city_station;
        }


        [DataMember]
        public int id_station { get; set; }
        [DataMember]
<<<<<<< HEAD
        int height_station { get; set; }
        [DataMember]
        int km_size_station { get; set; }
        
        // name + location
        [DataMember]
        string name_station { get; set; }
        [DataMember]
        double longitude_station { get; set; }
=======
        public int height_station { get; set; }
        [DataMember]
        public int km_size_station { get; set; }
        
        // name + location
        [DataMember]
        public string name_station { get; set; }
        [DataMember]
        public double longitude_station { get; set; }
>>>>>>> 030a2c2dc37cc6aa5a39c6d0c42869e86aba28b4
        [DataMember]
        public double latitude_station { get; set; }

        //adresse
        [DataMember]
<<<<<<< HEAD
        int address_number_station { get; set; }
        [DataMember]
        string address_street_station { get; set; }
        [DataMember]
        int address_cp_station { get; set; }
        [DataMember]
        string addresse_city_station { get; set; }
=======
        public int address_number_station { get; set; }
        [DataMember]
        public string address_street_station { get; set; }
        [DataMember]
        public int address_cp_station { get; set; }
        [DataMember]
        public string addresse_city_station { get; set; }
>>>>>>> 030a2c2dc37cc6aa5a39c6d0c42869e86aba28b4
    }

    #endregion

    #region user
    [DataContract]
    public class User
    {
        [DataMember]
        public int id_user { get; set; }
        [DataMember]
        public int id_language_language { get; set; }

        [DataMember]
        public string email_user { get; set; }
        [DataMember]
        public string login_user { get; set; }
        [DataMember]
        public string password_user { get; set; }
        [DataMember]
        public double last_longitude_user { get; set; }
        [DataMember]
        public double last_latitude_user { get; set; }
        [DataMember]
        public string last_city_user { get; set; }
    }

    #endregion

    #region alarms
    [DataContract]
    public class Alarm
    {
        [DataMember]
        public int id_alarm { get; set; }
        [DataMember]
        public int id_user_user { get; set; }

        [DataMember]
        public int snow_quality_alarm { get; set; }
        [DataMember]
        public int snow_quantity_alarm { get; set; }
        [DataMember]
        public int wind_alarm { get; set; }
        [DataMember]
        public int weather_alarm { get; set; }
        [DataMember]
        public double longitude_alarm { get; set; }
        [DataMember]
        public double latitude_alarm { get; set; }
        [DataMember]
        public int range_alarm { get; set; }
        [DataMember]
        public string status_alarm { get; set; }
        [DataMember]
        public int hour_alarm { get; set; }
        [DataMember]
        public int minute_alarm { get; set; }
        
    }

    #endregion

    #region Information
    [DataContract]
    public class Information
    {
        [DataMember]
        public int id_information { get; set; }
        [DataMember]
        public int id_user_user { get; set; }
        [DataMember]
        public int id_station_station { get; set; }

        [DataMember]
        public int snow_quality_info { get; set; }
        [DataMember]
        public int snow_quantity_info { get; set; }
        [DataMember]
        public int wind_info { get; set; }
        [DataMember]
        public int weather_info { get; set; }
        [DataMember]
        public double longitude_info { get; set; }
        [DataMember]
        public double latitude_info { get; set; }
    }

    #endregion

    #region Language
    [DataContract]
    public class Language
    {
        [DataMember]
        public int id_language { get; set; }
        [DataMember]
        public string name_language { get; set; }
    }

    #endregion

    #region Region
    [DataContract]
    public class Region
    {
        [DataMember]
        public int id_region { get; set; }
        [DataMember]
        public int id_country_country { get; set; }
        [DataMember]
        public string name_region { get; set; }
    }
    #endregion

    #region Country
    [DataContract]
    public class Country
    {
        [DataMember]
        public int id_country { get; set; }
        [DataMember]
        public string name_country { get; set; }
    }
    #endregion
}
