namespace project3her
{
    partial class Datavisualisatie2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDag = new System.Windows.Forms.ComboBox();
            this.comboDagdeel = new System.Windows.Forms.ComboBox();
            this.comboBoxBuurt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(254, 72);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Straatroof";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Fietsdiefstal";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxDag
            // 
            this.comboBoxDag.FormattingEnabled = true;
            this.comboBoxDag.Location = new System.Drawing.Point(559, 108);
            this.comboBoxDag.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDag.Name = "comboBoxDag";
            this.comboBoxDag.Size = new System.Drawing.Size(230, 21);
            this.comboBoxDag.TabIndex = 2;
            this.comboBoxDag.SelectedIndexChanged += new System.EventHandler(this.comboBoxJaar_SelectedIndexChanged);
            // 
            // comboDagdeel
            // 
            this.comboDagdeel.FormattingEnabled = true;
            this.comboDagdeel.Location = new System.Drawing.Point(560, 134);
            this.comboDagdeel.Name = "comboDagdeel";
            this.comboDagdeel.Size = new System.Drawing.Size(229, 21);
            this.comboDagdeel.TabIndex = 4;
            this.comboDagdeel.SelectedIndexChanged += new System.EventHandler(this.comboDagdeel_SelectedIndexChanged);
            // 
            // comboBoxBuurt
            // 
            this.comboBoxBuurt.FormattingEnabled = true;
            this.comboBoxBuurt.Location = new System.Drawing.Point(560, 161);
            this.comboBoxBuurt.Name = "comboBoxBuurt";
            this.comboBoxBuurt.Size = new System.Drawing.Size(229, 21);
            this.comboBoxBuurt.TabIndex = 5;
            this.comboBoxBuurt.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuurt_SelectedIndexChanged);
            // 
            // Datavisualisatie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxBuurt);
            this.Controls.Add(this.comboDagdeel);
            this.Controls.Add(this.comboBoxDag);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Name = "Datavisualisatie2";
            this.Text = "Datavisualisatie2";
            this.Load += new System.EventHandler(this.Datavisualisatie2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxDag;
        private System.Windows.Forms.ComboBox comboDagdeel;
        private System.Windows.Forms.ComboBox comboBoxBuurt;
    }
}