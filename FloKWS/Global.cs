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

        #region Dates
        //FONTIONS DATE

        public static string DateTimeToMySqlDate(DateTime date)
        {
            return "DATE('" + date.ToString("yyyy-MM-dd") + "')";
            //return date.ToString("yyyy-MM-dd") ;
        }

        public static string DateTimeToMySqlDateTime(DateTime date)
        {
            return "STR_TO_DATE('" + date.ToString("yyyy-MM-dd hh:mm:ss") + "','%Y-%m-%d %H:%i:%s')";
        }

        public static DateTime MySqlDateTimeToDateTime(string date)
        {
            // année, mois, jour => xxxx xx xx                    
            DateTime dt = new DateTime(int.Parse(date.Substring(0, 4)), int.Parse(date.Substring(5, 2)), int.Parse(date.Substring(8, 2)));
            return dt;
        }

        #endregion
        #region Position

        /// <summary>
        /// retourne le degrée de longitude nécessaire pour couvrir une distance de n km donnée pour une latitude donnée
        /// </summary>
        /// <param name="km"></param>
        /// <param name="latitude"></param>
        /// <returns></returns>
        public static double KmToLongitude(float km,double latitude){
            return (km / (111.320 * Math.Cos(latitude))); 
        }

        /// <summary>
        /// retourne le degrée de latitude nécessaire pour couvrir une distance de n km donnée
        /// </summary>
        /// <param name="km"></param>
        /// <returns></returns>
        public static double KmToLatitude(float km)
        {
            return (km / 111.132);
        }

        #endregion
        #region BD
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
                    i++;
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

        public static MySqlDataReader selectDataReader(MySqlConnection myConnection, string query)
        {
            myConnection.Open();

            try
            {
                MySqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandTimeout = 600;
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Query:" + query);
                return null;

            }
             finally
            {
                myConnection.Close();
            }
        }


        // return one value from db
        public static ResultSelectOneValue selectOneValue(MySqlConnection myConnection, string query)
        {
            string firstResult = string.Empty;
            myConnection.Open();

            try
            {
                MySqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandTimeout = 600;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object oVal = reader.GetValue(0);
                    firstResult = DBNull.Value.Equals(oVal) ? String.Empty : oVal.ToString();
                }
                reader.Close();
                ResultSelectOneValue ret = new ResultSelectOneValue(firstResult, false);
                return ret;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Query:" + query);
                ResultSelectOneValue ret = new ResultSelectOneValue(ex.Message.ToString(), true);
                return ret;

            }
            finally
            {
                myConnection.Close();
            }

        }
        #endregion

    }
}