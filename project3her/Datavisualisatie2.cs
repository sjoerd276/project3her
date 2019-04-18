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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void Datavisualisatie2_Load(object sender, EventArgs e)
        {
            string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011) AS count1,(SELECT COUNT(Voorval_nummer)FROM bikebike_theft) AS count2 FROM dual";


            

            DataTable dt = GetData(query);

            chart1.DataSource = dt;


            chart1.Series["Straatroof"].YValueMembers = "count1";
            chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

            chart1.Titles.Add("Diefstal");

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
            if(comboBoxJaar != null)
            {
                chart1.Series["Straatroof"].Points.Clear();
                chart1.Series["Fietsdiefstal"].Points.Clear();


                string Filter = ((string)comboBoxJaar.SelectedItem);
                

                string query = "SELECT(SELECT COUNT(Voorval_nr)FROM straatroof_2011 WHERE dagsoort ='" + comboBoxJaar.Text.ToString() + "') AS count1,(SELECT COUNT(Voorval_nummer)FROM bikebike_theft WHERE Begin_dagsoort ='" + comboBoxJaar.Text.ToString() + "') AS count2 FROM dual";


                DataTable dt = GetData(query);

                chart1.DataSource = dt;


                chart1.Series["Straatroof"].YValueMembers = "count1";
                chart1.Series["Fietsdiefstal"].YValueMembers = "count2";

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
