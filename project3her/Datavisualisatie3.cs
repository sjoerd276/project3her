using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace project3her
{
    public partial class Datavisualisatie3 : Form
    {
        public Datavisualisatie3()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }
        private void Datavisualisatie3_Load(object sender, EventArgs e)
        {
            string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal) AS count1,(SELECT SUM(aantal2011)FROM populatie) AS count2 FROM dual";

            DataTable dt = GetData(query);

            chart3.DataSource = dt;


            chart3.Series["Misdaden"].YValueMembers = "count1";
            chart3.Series["Populatie"].YValueMembers = "count2";
            chart3.Series["Misdaden"].IsValueShownAsLabel = true;
            chart3.Series["Populatie"].IsValueShownAsLabel = true;

            chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
            chart3.Titles.Add("Alle Buurten");
            chart3.Titles.Add("2011");
            ratiolabel2.Text = "";
            //Ratio(query);
        }
        private static DataTable GetData(string query)
        {
            string server = "localhost";
            string database = "project3";
            string uid = "project3";
            string password = "project3";
            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void Buurtfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buurtfilter != null && buurtfilter.Text.ToString() != "Alle buurten" && jaarfilter.Text.ToString() == "2011")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)buurtfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2011)FROM populatie WHERE Buurten = '" + buurtfilter.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add(buurtfilter.Text.ToString());
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter != null && buurtfilter.Text.ToString() != "Alle buurten" && jaarfilter.Text.ToString() == "2012")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)buurtfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2012)FROM populatie WHERE Buurten = '" + buurtfilter.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add(buurtfilter.Text.ToString());
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter.Text.ToString() == "Alle Buurten" && jaarfilter.Text.ToString() == "2011")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)jaarfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2011)FROM populatie) AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add("Alle buurten");
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter.Text.ToString() == "Alle Buurten" && jaarfilter.Text.ToString() == "2012")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)jaarfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2012)FROM populatie) AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add("Alle buurten");
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }

        }

        private void Jaarfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buurtfilter != null && buurtfilter.Text.ToString() != "Alle buurten" && jaarfilter.Text.ToString() == "2011")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)buurtfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2011)FROM populatie WHERE Buurten = '" + buurtfilter.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add(buurtfilter.Text.ToString());
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter != null && buurtfilter.Text.ToString() != "Alle buurten" && jaarfilter.Text.ToString() == "2012")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)buurtfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt = '" + buurtfilter.Text.ToString() + "' AND Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2012)FROM populatie WHERE Buurten = '" + buurtfilter.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add(buurtfilter.Text.ToString());
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter.Text.ToString() == "Alle Buurten" && jaarfilter.Text.ToString() == "2011")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)jaarfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2011)FROM populatie) AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add("Alle buurten");
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
            if (buurtfilter.Text.ToString() == "Alle Buurten" && jaarfilter.Text.ToString() == "2012")
            {
                chart3.Series["Misdaden"].Points.Clear();
                chart3.Series["Populatie"].Points.Clear();

                string Filter = ((string)jaarfilter.SelectedItem);

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Jaar = '" + jaarfilter.Text.ToString() + "') + (SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_jaar = '" + jaarfilter.Text.ToString() + "') AS count1,(SELECT SUM(aantal2012)FROM populatie) AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart3.DataSource = dt;

                chart3.Series["Misdaden"].YValueMembers = "count1";
                chart3.Series["Populatie"].YValueMembers = "count2";


                chart3.Titles.Clear();
                chart3.Titles.Add("Aantal misdaden tegenover populatie per buurt");
                chart3.Titles.Add("Alle buurten");
                chart3.Titles.Add(jaarfilter.Text.ToString());
            }
        }

        //private void Ratio(string ratio)
        //{
        //    string server = "localhost";
        //    string database = "project3";
        //    string uid = "project3";
        //    string password = "project3";
        //    string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        //    MySqlConnection sqlConn = new MySqlConnection();
        //    MySqlCommand sqlCmd = new MySqlCommand();
        //    sqlConn.ConnectionString = constr;
        //    sqlCmd.CommandText = ratio;
        //    sqlCmd.CommandType = CommandType.Text;
        //    sqlConn.Open();
        //    sqlCmd.Connection = sqlConn;
        //    MySqlDataReader reader = sqlCmd.ExecuteReader();

        //    double pop = double.Parse("count2");
        //    double mis = double.Parse("count1");
        //    double result = pop / mis;
        //    ratiolabel2.Text = result.ToString();

        //    reader.Close();
        //    sqlConn.Close();

        //}
    }
}
