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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxDag = new System.Windows.Forms.ComboBox();
            this.comboDagdeel = new System.Windows.Forms.ComboBox();
            this.comboBoxBuurt = new System.Windows.Forms.ComboBox();
            this.filterpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ratiotext = new System.Windows.Forms.TextBox();
            this.menubutton = new System.Windows.Forms.Button();
            this.deelvraag3 = new System.Windows.Forms.Label();
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
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Straatroof";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Fietsdiefstal";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(760, 485);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // comboBoxDag
            // 
            this.comboBoxDag.FormattingEnabled = true;
            this.comboBoxDag.Location = new System.Drawing.Point(51, 180);
            this.comboBoxDag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDag.Name = "comboBoxDag";
            this.comboBoxDag.Size = new System.Drawing.Size(151, 24);
            this.comboBoxDag.TabIndex = 2;
            this.comboBoxDag.SelectedIndexChanged += new System.EventHandler(this.comboBoxJaar_SelectedIndexChanged);
            // 
            // comboDagdeel
            // 
            this.comboDagdeel.FormattingEnabled = true;
            this.comboDagdeel.Location = new System.Drawing.Point(51, 230);
            this.comboDagdeel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDagdeel.Name = "comboDagdeel";
            this.comboDagdeel.Size = new System.Drawing.Size(151, 24);
            this.comboDagdeel.TabIndex = 4;
            this.comboDagdeel.SelectedIndexChanged += new System.EventHandler(this.comboDagdeel_SelectedIndexChanged);
            // 
            // comboBoxBuurt
            // 
            this.comboBoxBuurt.FormattingEnabled = true;
            this.comboBoxBuurt.Location = new System.Drawing.Point(51, 281);
            this.comboBoxBuurt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBuurt.Name = "comboBoxBuurt";
            this.comboBoxBuurt.Size = new System.Drawing.Size(151, 24);
            this.comboBoxBuurt.TabIndex = 5;
            this.comboBoxBuurt.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuurt_SelectedIndexChanged);
            // 
            // filterpanel
            // 
            this.filterpanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filterpanel.Controls.Add(this.label1);
            this.filterpanel.Controls.Add(this.label3);
            this.filterpanel.Controls.Add(this.label4);
            this.filterpanel.Controls.Add(this.label2);
            this.filterpanel.Controls.Add(this.ratiotext);
            this.filterpanel.Controls.Add(this.menubutton);
            this.filterpanel.Location = new System.Drawing.Point(0, 0);
            this.filterpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterpanel.Name = "filterpanel";
            this.filterpanel.Size = new System.Drawing.Size(251, 555);
            this.filterpanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buurt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dagdeel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filters";
            // 
            // ratiotext
            // 
            this.ratiotext.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ratiotext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ratiotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratiotext.Location = new System.Drawing.Point(32, 420);
            this.ratiotext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratiotext.Name = "ratiotext";
            this.ratiotext.Size = new System.Drawing.Size(189, 38);
            this.ratiotext.TabIndex = 6;
            // 
            // menubutton
            // 
            this.menubutton.BackColor = System.Drawing.SystemColors.Control;
            this.menubutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubutton.Location = new System.Drawing.Point(51, 15);
            this.menubutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(149, 50);
            this.menubutton.TabIndex = 0;
            this.menubutton.Text = "Menu";
            this.menubutton.UseVisualStyleBackColor = false;
            this.menubutton.Click += new System.EventHandler(this.menu_Click);
            // 
            // deelvraag3
            // 
            this.deelvraag3.AutoSize = true;
            this.deelvraag3.Location = new System.Drawing.Point(428, 15);
            this.deelvraag3.Name = "deelvraag3";
            this.deelvraag3.Size = new System.Drawing.Size(450, 17);
            this.deelvraag3.TabIndex = 7;
            this.deelvraag3.Text = "Wat is het verschil tussen het aantal fietsendiefstallen en straatroven?";
            // 
            // Datavisualisatie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deelvraag3);
            this.Controls.Add(this.comboBoxBuurt);
            this.Controls.Add(this.comboDagdeel);
            this.Controls.Add(this.comboBoxDag);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.filterpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Datavisualisatie2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datavisualisatie2";
            this.Load += new System.EventHandler(this.Datavisualisatie2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.filterpanel.ResumeLayout(false);
            this.filterpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBoxDag;
        private System.Windows.Forms.ComboBox comboDagdeel;
        private System.Windows.Forms.ComboBox comboBoxBuurt;
        private System.Windows.Forms.Panel filterpanel;
        private System.Windows.Forms.TextBox ratiotext;
        private System.Windows.Forms.Button menubutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deelvraag3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}