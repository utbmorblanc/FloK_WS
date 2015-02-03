using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FloKWS
{
    public class Global
    {
        //Ici on mettra les routines de connexion à la BDD
        //Identifiants de connexion
        public static string DBHost="88.162.236.181";
        public static string DBLogin="orblanc";
        public static string DBPassword="orblanc2015";
        public static string DBName = "orblanc";
        public static string Port = "8181";

        public static MySqlConnection InitMySqlConnection(string login, string password, string host, string db,string port, bool pooling)
        {
            MySqlConnection myConnection = null;
            if (pooling == true)
            {
                if (db == "")
                {
                    myConnection = new MySqlConnection(
                                      "User id=" + login + ";" +
                                      "Password=" + password + ";" +
                                      "Server=" + host + ";" +
                                      "Port=" + port + ";" +
                                      "Pooling=True");
                }
                else
                {
                    myConnection = new MySqlConnection(
                                        "User id=" + login + ";" +
                                        "Password=" + password + ";" +
                                        "Server=" + host + ";" +
                                        "Port=" + port + ";" +
                                        "Database=" + db + ";" +
                                        "Pooling=True");
                }
            }

            else
            {
                if (db == "")
                {
                    myConnection = new MySqlConnection(
                                      "User id=" + login + ";" +
                                      "Password=" + password + ";" +
                                      "Port=" + port + ";" +
                                      "Server=" + host + ";");

                }
                else
                {
                    myConnection = new MySqlConnection(
                                        "User id=" + login + ";" +
                                        "Password=" + password + ";" +
                                        "Port=" + port + ";" +
                                        "Server=" + host + ";" +
                                        "Database=" + db + ";");
                }
            }

            return myConnection;
        }

        // insertion des données en base via requetes parametrées
        public static Boolean insert_into_db(MySqlConnection myConnection, string table, List<string> listColumns, List<string> listValue)
        {
            bool returnValue = true;
            myConnection.Open();
            MySqlTransaction tran = myConnection.BeginTransaction();
           
            try
            {
                MySqlCommand Com = new MySqlCommand();

                System.Text.StringBuilder Query = new System.Text.StringBuilder();
                Query.Append("INSERT INTO " + table + "(");
                foreach (string column in listColumns)
                {
                    Query.Append(column + ",");
                }
                Query.Length--;  //j'enleve la derniere virgule
                Query.Append(") VALUES (");
                int i = 1;
                foreach (string value in listValue)
                {
                    Query.Append("@attribute" + i + ",");
                }
                Query.Length--;  //j'enleve la derniere virgule
                Query.Append(")");

                Com.CommandText = Query.ToString();
                Com.Transaction = tran;

                int j = 1;
                foreach (string value in listValue)
                {
                    Com.Parameters.AddWithValue("attribute" + j, value);
                    j++;
                }

                Com.Connection = myConnection;
                Com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                returnValue = false;
            }
            

            tran.Commit();
            myConnection.Close();

            return returnValue;
        }

        // function that updates db informations
        public static Boolean update_table(MySqlConnection myConnection, string table, string column, string value, string where)
        {
            bool returnValue = true;
            myConnection.Open();
            MySqlTransaction tran = myConnection.BeginTransaction();


            try
            {
                MySqlCommand Com = new MySqlCommand();

                System.Text.StringBuilder Query = new System.Text.StringBuilder();
                Query.Append("UPDATE " + table + " set " + column + "='" + value + "'");
                if (where != null)
                {
                    Query.Append("WHERE " + where);
                }

                Com.CommandText = Query.ToString();
                Com.Transaction = tran;

                Com.Connection = myConnection;
                Com.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                returnValue = false;
            }

            tran.Commit();
            myConnection.Close();

            return returnValue;
        }



    }
}