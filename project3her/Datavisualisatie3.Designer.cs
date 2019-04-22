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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menubutton = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.ratiotext = new System.Windows.Forms.TextBox();
            this.misdadengepleegd = new System.Windows.Forms.Label();
            this.voorelkeinwoner = new System.Windows.Forms.Label();
            this.jaarfilter = new System.Windows.Forms.ComboBox();
            this.Filters = new System.Windows.Forms.Label();
            this.buurtfilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubutton
            // 
            this.menubutton.BackColor = System.Drawing.SystemColors.Control;
            this.menubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubutton.Location = new System.Drawing.Point(50, 15);
            this.menubutton.Margin = new System.Windows.Forms.Padding(4);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(150, 50);
            this.menubutton.TabIndex = 0;
            this.menubutton.Text = "Menu";
            this.menubutton.UseVisualStyleBackColor = false;
            this.menubutton.Click += new System.EventHandler(this.menu_Click);
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.DataSource = this.chart3.Annotations;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(280, 15);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Misdaden";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Populatie";
            this.chart3.Series.Add(series1);
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(760, 525);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Aantal misdaden tegenover populatie";
            title1.Text = "Aantal misdaden tegenover populatie";
            this.chart3.Titles.Add(title1);
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterpanel.Controls.Add(this.ratiotext);
            this.filterpanel.Controls.Add(this.misdadengepleegd);
            this.filterpanel.Controls.Add(this.voorelkeinwoner);
            this.filterpanel.Controls.Add(this.jaarfilter);
            this.filterpanel.Controls.Add(this.Filters);
            this.filterpanel.Controls.Add(this.buurtfilter);
            this.filterpanel.Controls.Add(this.menubutton);
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(250, 555);
            this.filterpanel.TabIndex = 3;
            // 
            // ratiotext
            // 
            this.ratiotext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ratiotext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratiotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratiotext.Location = new System.Drawing.Point(32, 420);
            this.ratiotext.Name = "ratiotext";
            this.ratiotext.Size = new System.Drawing.Size(189, 38);
            this.ratiotext.TabIndex = 6;
            // 
            // misdadengepleegd
            // 
            this.misdadengepleegd.AutoSize = true;
            this.misdadengepleegd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misdadengepleegd.Location = new System.Drawing.Point(45, 480);
            this.misdadengepleegd.Name = "misdadengepleegd";
            this.misdadengepleegd.Size = new System.Drawing.Size(157, 20);
            this.misdadengepleegd.TabIndex = 5;
            this.misdadengepleegd.Text = "misdaden gepleegd.";
            this.misdadengepleegd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // voorelkeinwoner
            // 
            this.voorelkeinwoner.AutoSize = true;
            this.voorelkeinwoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorelkeinwoner.Location = new System.Drawing.Point(28, 380);
            this.voorelkeinwoner.Name = "voorelkeinwoner";
            this.voorelkeinwoner.Size = new System.Drawing.Size(193, 20);
            this.voorelkeinwoner.TabIndex = 4;
            this.voorelkeinwoner.Text = "Voor elke inwoner zijn er";
            this.voorelkeinwoner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // jaarfilter
            // 
            this.jaarfilter.FormattingEnabled = true;
            this.jaarfilter.Items.AddRange(new object[] {
            "2011",
            "2012"});
            this.jaarfilter.Location = new System.Drawing.Point(50, 230);
            this.jaarfilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jaarfilter.Name = "jaarfilter";
            this.jaarfilter.Size = new System.Drawing.Size(150, 24);
            this.jaarfilter.TabIndex = 3;
            this.jaarfilter.Text = "2011";
            this.jaarfilter.SelectedIndexChanged += new System.EventHandler(this.Jaarfilter_SelectedIndexChanged);
            // 
            // Filters
            // 
            this.Filters.AutoSize = true;
            this.Filters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.Location = new System.Drawing.Point(97, 150);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(56, 20);
            this.Filters.TabIndex = 2;
            this.Filters.Text = "Filters";
            this.Filters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buurtfilter
            // 
            this.buurtfilter.FormattingEnabled = true;
            this.buurtfilter.Items.AddRange(new object[] {
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
            this.buurtfilter.Location = new System.Drawing.Point(50, 180);
            this.buurtfilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buurtfilter.Name = "buurtfilter";
            this.buurtfilter.Size = new System.Drawing.Size(150, 24);
            this.buurtfilter.TabIndex = 1;
            this.buurtfilter.Text = "Alle Buurten";
            this.buurtfilter.SelectedIndexChanged += new System.EventHandler(this.Buurtfilter_SelectedIndexChanged);
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
            this.filterpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.ComboBox buurtfilter;
        private System.Windows.Forms.Label Filters;
        private System.Windows.Forms.ComboBox jaarfilter;
        private System.Windows.Forms.Label voorelkeinwoner;
        private System.Windows.Forms.Label misdadengepleegd;
        private System.Windows.Forms.TextBox ratiotext;
    }
}