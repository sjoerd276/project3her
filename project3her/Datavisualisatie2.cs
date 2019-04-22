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
    public partial class Datavisualisatie2 : Form
    {
        public Datavisualisatie2()
        {
            InitializeComponent();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void Datavisualisatie2_Load(object sender, EventArgs e)
        {
            string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal) AS count2 FROM dual";

            DataTable dt = GetData(query);

            chart1.DataSource = dt;
            chart1.Series["Straatroof"].YValueMembers = "count1";
            chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            
            chart1.Series["Straatroof"].IsValueShownAsLabel = true;
            chart1.Series["Fietsdiefstal"].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = " ";

            

            FillCB1();
            FillCB2();
            FillCB3();

            
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

        private void comboBoxJaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Aantal diefstallen en straatroven");
            chart1.Titles.Add(comboBoxDag.Text.ToString());
            chart1.Titles.Add(comboDagdeel.Text.ToString());
            chart1.Titles.Add(comboBoxBuurt.Text.ToString());

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal) AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")

            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }



            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }


            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }



            
            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }
        }

        private void comboDagdeel_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Aantal diefstallen en straatroven");
            chart1.Titles.Add(comboBoxDag.Text.ToString());
            chart1.Titles.Add(comboDagdeel.Text.ToString());
            chart1.Titles.Add(comboBoxBuurt.Text.ToString());

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal) AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")

            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND " +
                    "Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }



            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }


            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            
            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }
        }

        private void comboBoxBuurt_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Aantal diefstallen en straatroven");
            chart1.Titles.Add(comboBoxDag.Text.ToString());
            chart1.Titles.Add(comboDagdeel.Text.ToString());
            chart1.Titles.Add(comboBoxBuurt.Text.ToString());

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString()=="All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal) AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")

            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND " +
                    "Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }



            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
                
            }

            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            }


            if (comboBoxDag.Text.ToString() == "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() != "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Gemiddelde_dagdeel ='" + comboDagdeel.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() == "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "') AS count2 FROM dual";

                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }


            
            if (comboBoxDag.Text.ToString() != "All" && comboDagdeel.Text.ToString() == "All" && comboBoxBuurt.Text.ToString() != "All")
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxDag.Text.ToString() + "' AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count1,(SELECT COUNT(Voorval_nummer)FROM fietsdiefstal WHERE Begin_dagsoort ='" + comboBoxDag.Text.ToString() + "'AND Buurt LIKE'%" + comboBoxBuurt.Text.ToString() + "%') AS count2 FROM dual";
                DataTable dt = GetData(query);

                chart1.DataSource = dt;
                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";
            }

        }

        private void FillCB1()
        {
            comboBoxDag.Items.Insert(0, "All");
            comboBoxDag.Items.Insert(1, "MA");
            comboBoxDag.Items.Insert(2, "DI");
            comboBoxDag.Items.Insert(3, "WO");
            comboBoxDag.Items.Insert(4, "DO");
            comboBoxDag.Items.Insert(5, "VR");
            comboBoxDag.Items.Insert(6, "ZA");
            comboBoxDag.Items.Insert(7, "ZO");
            comboBoxDag.SelectedIndex = 0;
        }

        private void FillCB2()
        {
            comboDagdeel.Items.Insert(0, "All");
            comboDagdeel.Items.Insert(1, "00:00-05:59");
            comboDagdeel.Items.Insert(2, "06:00-11:59");
            comboDagdeel.Items.Insert(3, "12:00-17:59");
            comboDagdeel.Items.Insert(4, "18:00-23:59");
            comboDagdeel.SelectedIndex = 0;
        }

        private void FillCB3()
        {
            string server = "localhost";
            string database = "project3";
            string uid = "project3";
            string password = "project3";
            string constr = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCmd = new MySqlCommand();
            string sSql = "SELECT DISTINCT Buurten FROM populatie";
            sqlConn.ConnectionString = constr;
            sqlCmd.CommandText = sSql;
            sqlCmd.CommandType = CommandType.Text;
            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            MySqlDataReader reader = sqlCmd.ExecuteReader();
            List<string> results = new List<string>();

            while (reader.Read())
            {

                results.Add(reader["Buurten"].ToString());

            }
            foreach (var t in results)
            {
                comboBoxBuurt.Items.Add(t);
            }
            comboBoxBuurt.Items.Insert(0, "All");
            comboBoxBuurt.SelectedIndex = 0;

            reader.Close();
            sqlConn.Close();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
