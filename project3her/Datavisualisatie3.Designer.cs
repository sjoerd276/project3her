namespace project3her
{
    partial class Datavisualisatie3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menubutton = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.jaarfilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubutton
            // 
            this.menubutton.Location = new System.Drawing.Point(25, 15);
            this.menubutton.Margin = new System.Windows.Forms.Padding(4);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(150, 50);
            this.menubutton.TabIndex = 0;
            this.menubutton.Text = "Menu";
            this.menubutton.UseVisualStyleBackColor = true;
            this.menubutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.DataSource = this.chart3.Annotations;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(294, 15);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Straatroof";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Fietsdiefstal";
            this.chart3.Series.Add(series1);
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(760, 526);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart1";
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterpanel.Controls.Add(this.jaarfilter);
            this.filterpanel.Controls.Add(this.menubutton);
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(200, 555);
            this.filterpanel.TabIndex = 3;
            // 
            // jaarfilter
            // 
            this.jaarfilter.FormattingEnabled = true;
            this.jaarfilter.Items.AddRange(new object[] {
            "Alle Buurten",
            "Afrikaanderwijk",
            "Agniesebuurt",
            "Bedrijvenpark Noord_West",
            "Bergpolder",
            "Beverwaard",
            "Blijdorp",
            "Blijdorpsepolder",
            "Bloemhof",
            "Bospolder",
            "Botlek",
            "Carnisse",
            "Charlois Zuidrand",
            "Cool",
            "Cs Kwartier",
            "De Esch",
            "Delfshaven",
            "Dijkzigt",
            "Eemhaven",
            "Europoort",
            "Feijenoord",
            "Groot IJsselmonde",
            "Heijplaat",
            "Het Lage Land",
            "Hillegersberg Noord",
            "Hillegersberg Zuid",
            "Hillesluis",
            "Hoogvliet Noord",
            "Hoogvliet Zuid",
            "Katendrecht",
            "Kleinpolder",
            "Kop van Zuid",
            "Kop van Zuid - Entrepot",
            "Kralingen West",
            "Kralingen Oost",
            "Kralingse Bos",
            "Kralingseveer",
            "Landzicht",
            "Liskwartier",
            "Lombardijen",
            "Middelland",
            "Molenlaankwartier",
            "Nesselande",
            "Nieuwe Crooswijk",
            "Nieuw Mathenesse",
            "Nieuwe Werk",
            "Nieuwe Westen",
            "Noord Kethel",
            "Noordereiland",
            "Ommoord",
            "Oosterflank",
            "Oud Charlois",
            "Oud Crooswijk",
            "Oud IJsselmonde",
            "Oud Mathenesse",
            "Oude Noorden",
            "Oude Westen",
            "Overschie",
            "Pendrecht",
            "Pernis",
            "Prinsenland",
            "Provenierswijk",
            "Rijnpoort",
            "Rozenburg",
            "Rubroek",
            "\'s Gravenland",
            "Schiebroek",
            "Schiemond",
            "Schieveen",
            "Spaanse Polder",
            "Spangen",
            "Stadsdriehoek",
            "Strand en Duin",
            "Struisenburg",
            "Tarwewijk",
            "Terbregge",
            "Tussendijken",
            "Vreewijk",
            "Waalhaven",
            "Waalhaven Zuid",
            "Wielewaal",
            "Witte Dorp",
            "Zestienhoven",
            "Zevenkamp",
            "Zuiderpark",
            "Zuidplein",
            "Zuidwijk"});
            this.jaarfilter.Location = new System.Drawing.Point(25, 175);
            this.jaarfilter.Name = "jaarfilter";
            this.jaarfilter.Size = new System.Drawing.Size(150, 24);
            this.jaarfilter.TabIndex = 1;
            // 
            // Datavisualisatie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.filterpanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Datavisualisatie3";
            this.Text = "Datavisualisatie3";
            this.Load += new System.EventHandler(this.Datavisualisatie3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.filterpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.ComboBox jaarfilter;
    }
}