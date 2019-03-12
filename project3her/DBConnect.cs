using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace project3her
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values -- make sure you adjust the info
        private void Initialize()
        {
            server = "localhost";
            database = "project3";
            uid = "project3";
            password = "project3";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //public bool updateDatabase() // still needed?
        //{
        //    OpenConnection();
        //    string script = File.ReadAllText(@"project3.sql");
        //    MySqlCommand cmd = new MySqlCommand(script, connection);
        //    cmd.ExecuteNonQuery();
        //    CloseConnection();
        //    return true;
        //}

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }


        //Current attempt at creating the list

        /*
         * Only works when update button is pressed (?)
         * Graph seems to stop working after update has been pressed, console does keep working tho.
         */

        /// <summary>
        /// Small class that stores variables that go into the query list
        /// </summary>

        // TODO FROM HERE
        public class CountTemp
        {
            public int Count { get; set; }
            public int TempGem { get; set; }
        }

        public List<CountTemp> DBselect(string passedQuery)
        {
            string query = passedQuery;

            //Create a list to store the result
            var list = new List<CountTemp>();

            //OPen connection
            if (this.OpenConnection())
            {
                //Create command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create datareader and execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list.Add(new CountTemp
                    {
                        Count = Convert.ToInt32(dataReader["Count(ID)"]),
                        TempGem = Convert.ToInt32(dataReader["Temperatuur"])

                    });
                    /*
                    foreach (var temp in list)
                    {
                        Console.WriteLine(string.Format("{0} {1}",
                            temp.Count,
                            temp.TempGem));
                    }*/// debug no longer needed 😎
                }

                //close datareader
                dataReader.Close();

                //close connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }

        }

        //Count statement
        //Another proof of concept, but this one is called in the testButton in the form.
        /// <summary>
        /// Takes a Select Count() query, returns an integer
        /// </summary>
        /// <param name="passedQuery">SELECT Count() query</param>
        /// <returns>int</returns>
        public int Count(string passedQuery)
        {
            //string query = "SELECT Count(*) FROM weer";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(passedQuery, connection);

                //ExecuteScalar will return one value
                //Count = int.Parse(cmd.ExecuteScalar() + "");
                var scholar = cmd.ExecuteScalar();
                Count = Convert.ToInt32(scholar);
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

    }
}