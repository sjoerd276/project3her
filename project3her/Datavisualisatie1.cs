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
    public partial class Datavisualisatie1 : Form
    {
        // =======================================
        // 
        // Automatically generated functions, 
        // some of them are filled in
        // 
        // =======================================

        public Datavisualisatie1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Menu button
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        // =======================================
        //
        // Non-automatic generated functions
        // Be able to connect to DB and
        // do things with the Chart in these functions
        // 
        // =======================================

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

        private void clearChart()
        {
            chart1.Series["Totaal misdaden"].Points.Clear();
            chart1.Series["Fietsdiefstal"].Points.Clear();
            chart1.Titles.Clear();
        }

        private void fillChart(string query, string chartTitle = "Datavisualization")
        {
            DataTable dt = GetData(query);

            chart1.DataSource = dt;

            chart1.Series["Totaal misdaden"].YValueMembers = "count1";
            chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            chart1.Titles.Add(chartTitle);
        }

        private int sqlToInt(string query)
        {
            DataTable dt = GetData(query);
            int integer = 1;
            return integer;
        }

        private void fillCombobox1() // What kind of values?
        {
            comboBox1.Items.Insert(0, "Waarden");
            comboBox1.Items.Insert(1, "Percentages");
            comboBoxDag.SelectedIndex = 0;
        }

        private void fillCombobox2() // Buurten - selector
        {
            // =======================================
            //
            // Make an apart database connection, 
            // because this doesn't use DataTable, 
            // like GetData() does
            //
            // =======================================

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
                comboBox2.Items.Add(t);
            }
            comboBox2.Items.Insert(0, "All");
            comboBox2.SelectedIndex = 0;

            reader.Close();
            sqlConn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Type waarden choser
        {
            if (comboBox1.Text.ToString() == "Waarden")
            {
                clearChart();
                // fillChart("some query", "some name");
            }

            if (comboBox1.Text.ToString() == "Percentages")
            {
                clearChart();
                // fillChart("some query", "some name");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Buurt choser
        {

        }

        // =======================================
        //
        // End of functions
        // Now make the order of things happening
        //
        // Initial load:
        // Just load the total data into the chart and fill combobox "Buurten"
        // The rest happens when user does something
        // Also just leave not used functions here
        //
        // =======================================

        private void Datavisualisatie1_Load(object sender, EventArgs e)
        {
            fillChart("SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) + (SELECT COUNT(Voorval_nummer)FROM bikebike_theft) AS count1, (SELECT COUNT(Voorval_nummer)FROM bikebike_theft) AS count2", "Diefstal");
            fillCombobox1();
            fillCombobox2();
        }


        // =======================================
        //
        // END OF PROGRAM
        //
        // =======================================







        // =======================================
        //
        // The rest does nothing right now! 
        // Documentation here, so we are able to find stuff back.
        //
        // =======================================

        private void chart1_Click(object sender, EventArgs e) { } // "THE" CHART
        private void label1_Click(object sender, EventArgs e) { } // Label "Type waarden" (just a label)
        private void label2_Click(object sender, EventArgs e) { } // Label "Buurt" (just a label)
    }
}
