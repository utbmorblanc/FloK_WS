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
            MySqlConnection myconnexion = Global.InitMySqlConnection(Global.DBLogin, Global.DBPassword, Global.DBHost, Global.DBName,Global.Port, false);
            List<string> myList= new List<string>();
            myList.Add("name_language");
            List<string> myListValues= new List<string>();
            myListValues.Add("Anglais");

            bool result=Global.insert_into_db(myconnexion, "language", myList, myListValues);
            Console.WriteLine(result.ToString());

        }
    }
}