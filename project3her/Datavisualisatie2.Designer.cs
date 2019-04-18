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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxJaar = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboDagdeel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(339, 89);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Straatroof";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Fietsdiefstal";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(400, 369);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxJaar
            // 
            this.comboBoxJaar.FormattingEnabled = true;
            this.comboBoxJaar.Items.AddRange(new object[] {
            "MA",
            "DI",
            "WO",
            "DO",
            "VR",
            "ZA",
            "ZO",
            "All"});
            this.comboBoxJaar.Location = new System.Drawing.Point(889, 119);
            this.comboBoxJaar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxJaar.Name = "comboBoxJaar";
            this.comboBoxJaar.Size = new System.Drawing.Size(108, 24);
            this.comboBoxJaar.TabIndex = 2;
            this.comboBoxJaar.SelectedIndexChanged += new System.EventHandler(this.comboBoxJaar_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(987, 245);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 18);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboDagdeel
            // 
            this.comboDagdeel.FormattingEnabled = true;
            this.comboDagdeel.Location = new System.Drawing.Point(889, 165);
            this.comboDagdeel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDagdeel.Name = "comboDagdeel";
            this.comboDagdeel.Size = new System.Drawing.Size(160, 24);
            this.comboDagdeel.TabIndex = 4;
            this.comboDagdeel.SelectedIndexChanged += new System.EventHandler(this.comboDagdeel_SelectedIndexChanged);
            // 
            // Datavisualisatie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboDagdeel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxJaar);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Datavisualisatie2";
            this.Text = "Datavisualisatie2";
            this.Load += new System.EventHandler(this.Datavisualisatie2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxJaar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboDagdeel;
    }
}