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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.deelvraag3 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.Button();
            this.buurtfilter = new System.Windows.Forms.ComboBox();
            this.jaarfilter = new System.Windows.Forms.ComboBox();
            this.inwonerlabel = new System.Windows.Forms.Label();
            this.misdadenlabel = new System.Windows.Forms.Label();
            this.filterlabel3 = new System.Windows.Forms.Label();
            this.ratiolabel = new System.Windows.Forms.Label();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.ratiolabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart3
            // 
            chartArea8.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea8);
            this.chart3.DataSource = this.chart3.Annotations;
            legend8.Name = "Legend1";
            this.chart3.Legends.Add(legend8);
            this.chart3.Location = new System.Drawing.Point(280, 55);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Misdaden";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "Populatie";
            this.chart3.Series.Add(series15);
            this.chart3.Series.Add(series16);
            this.chart3.Size = new System.Drawing.Size(760, 485);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // deelvraag3
            // 
            this.deelvraag3.AutoSize = true;
            this.deelvraag3.Location = new System.Drawing.Point(330, 20);
            this.deelvraag3.Name = "deelvraag3";
            this.deelvraag3.Size = new System.Drawing.Size(660, 17);
            this.deelvraag3.TabIndex = 4;
            this.deelvraag3.Text = "Wat is het verband tussen de totale populatie van een buurt en het totale aantal " +
    "misdaden in die buurt?";
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
            "Nieuw Crooswijk",
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
            "s Gravenland",
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
            // inwonerlabel
            // 
            this.inwonerlabel.AutoSize = true;
            this.inwonerlabel.Location = new System.Drawing.Point(43, 380);
            this.inwonerlabel.Name = "inwonerlabel";
            this.inwonerlabel.Size = new System.Drawing.Size(163, 17);
            this.inwonerlabel.TabIndex = 7;
            this.inwonerlabel.Text = "Voor elke inwoner zijn er";
            // 
            // misdadenlabel
            // 
            this.misdadenlabel.AutoSize = true;
            this.misdadenlabel.Location = new System.Drawing.Point(57, 480);
            this.misdadenlabel.Name = "misdadenlabel";
            this.misdadenlabel.Size = new System.Drawing.Size(136, 17);
            this.misdadenlabel.TabIndex = 8;
            this.misdadenlabel.Text = "misdaden gepleegd.";
            // 
            // filterlabel3
            // 
            this.filterlabel3.AutoSize = true;
            this.filterlabel3.Location = new System.Drawing.Point(102, 150);
            this.filterlabel3.Name = "filterlabel3";
            this.filterlabel3.Size = new System.Drawing.Size(46, 17);
            this.filterlabel3.TabIndex = 9;
            this.filterlabel3.Text = "Filters";
            // 
            // ratiolabel
            // 
            this.ratiolabel.AutoSize = true;
            this.ratiolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratiolabel.Location = new System.Drawing.Point(67, 417);
            this.ratiolabel.Name = "ratiolabel";
            this.ratiolabel.Size = new System.Drawing.Size(0, 38);
            this.ratiolabel.TabIndex = 10;
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterpanel.Controls.Add(this.ratiolabel2);
            this.filterpanel.Controls.Add(this.ratiolabel);
            this.filterpanel.Controls.Add(this.filterlabel3);
            this.filterpanel.Controls.Add(this.misdadenlabel);
            this.filterpanel.Controls.Add(this.inwonerlabel);
            this.filterpanel.Controls.Add(this.jaarfilter);
            this.filterpanel.Controls.Add(this.buurtfilter);
            this.filterpanel.Controls.Add(this.menubutton);
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(250, 555);
            this.filterpanel.TabIndex = 3;
            // 
            // ratiolabel2
            // 
            this.ratiolabel2.AutoSize = true;
            this.ratiolabel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ratiolabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratiolabel2.Location = new System.Drawing.Point(60, 420);
            this.ratiolabel2.Name = "ratiolabel2";
            this.ratiolabel2.Size = new System.Drawing.Size(80, 38);
            this.ratiolabel2.TabIndex = 11;
            this.ratiolabel2.Text = "ratio";
            // 
            // Datavisualisatie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deelvraag3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.filterpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Datavisualisatie3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datavisualisatie3";
            this.Load += new System.EventHandler(this.Datavisualisatie3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.filterpanel.ResumeLayout(false);
            this.filterpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label deelvraag3;
        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.ComboBox buurtfilter;
        private System.Windows.Forms.ComboBox jaarfilter;
        private System.Windows.Forms.Label inwonerlabel;
        private System.Windows.Forms.Label misdadenlabel;
        private System.Windows.Forms.Label filterlabel3;
        private System.Windows.Forms.Label ratiolabel;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.Label ratiolabel2;
    }
}