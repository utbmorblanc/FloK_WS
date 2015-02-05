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


        public bool CreateInfo(int id, int snowQuality, int snowQuantity, int wind, int weather, int idUser, int idStation, double longitude, double latitude)
        {
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            List<string> listColumns = new List<String>();
            List<string> listValue = new List<String>();

            listColumns.Add("snow_quality_info");
            listValue.Add(id.ToString());

            listColumns.Add("snow_quantity_info");
            listValue.Add(snowQuality.ToString());

            listColumns.Add("wind_info");
            listValue.Add(snowQuantity.ToString());

            listColumns.Add("weather_info");
            listValue.Add(wind.ToString());

            listColumns.Add("id_user_user");
            listValue.Add(weather.ToString());

            listColumns.Add("id_station_station");
            listValue.Add(idUser.ToString());

            listColumns.Add("date_info");
            listValue.Add(idStation.ToString());

            listColumns.Add("longitude_info");
            listValue.Add(longitude.ToString());

            listColumns.Add("latitude_info");
            listValue.Add(latitude.ToString());



            return Global.insert_into_db(myconnexion, "user", listColumns, listValue);
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
            //bool ok = this.CreateInfo(int id, int snowQuality, int snowQuantity, int wind, int weather, int idUser, int idStation, double longitude, double latitude);



        }




    }  
}