using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName, Global.Port, false);
            List<string> listColumns = new List<String>();
            List<string> listValue = new List<String>();

            listColumns.Add("login_user");
            listValue.Add("login");

            listColumns.Add("password_user");
            listValue.Add("unpassw");

            listColumns.Add("email_user");
            listValue.Add("plop@abnaha.de");

            Global.insert_into_db(myconnexion, "user", listColumns, listValue);

        }
    }
}