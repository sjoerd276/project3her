﻿namespace project3her
{
    partial class Datavisualisatie1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.filterlabel3 = new System.Windows.Forms.Label();
            this.menubutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.filterpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(280, 55);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Fietsdiefstal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Totaal misdaden";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(760, 485);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(50, 230);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hoeveel procent van de totale misdaden per buurt zijn fietsendiefstallen?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterpanel.Controls.Add(this.filterlabel3);
            this.filterpanel.Controls.Add(this.menubutton);
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(250, 555);
            this.filterpanel.TabIndex = 7;
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
            // Datavisualisatie1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.filterpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Datavisualisatie1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datavisualisatie1";
            this.Load += new System.EventHandler(this.Datavisualisatie1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.filterpanel.ResumeLayout(false);
            this.filterpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.Label filterlabel3;
        private System.Windows.Forms.Button menubutton;
    }
}