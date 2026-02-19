namespace WinFormsApp1
{
    partial class form_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            btn_Clear = new Button();
            lbl_dt = new Label();
            cB_dt = new ComboBox();
            btn_Start = new Button();
            nUD_weight = new NumericUpDown();
            lbl_weight = new Label();
            nUD_size = new NumericUpDown();
            lbl_size = new Label();
            nUD_speed = new NumericUpDown();
            lbl_speed = new Label();
            nUD_angle = new NumericUpDown();
            lbl_angle = new Label();
            nUD_height = new NumericUpDown();
            lbl_height = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_weight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_angle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_height).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Clear);
            panel1.Controls.Add(lbl_dt);
            panel1.Controls.Add(cB_dt);
            panel1.Controls.Add(btn_Start);
            panel1.Controls.Add(nUD_weight);
            panel1.Controls.Add(lbl_weight);
            panel1.Controls.Add(nUD_size);
            panel1.Controls.Add(lbl_size);
            panel1.Controls.Add(nUD_speed);
            panel1.Controls.Add(lbl_speed);
            panel1.Controls.Add(nUD_angle);
            panel1.Controls.Add(lbl_angle);
            panel1.Controls.Add(nUD_height);
            panel1.Controls.Add(lbl_height);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 116);
            panel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(491, 68);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 15;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // lbl_dt
            // 
            lbl_dt.AutoSize = true;
            lbl_dt.Location = new Point(248, 68);
            lbl_dt.Name = "lbl_dt";
            lbl_dt.Size = new Size(18, 15);
            lbl_dt.TabIndex = 14;
            lbl_dt.Text = "dt";
            // 
            // cB_dt
            // 
            cB_dt.FormattingEnabled = true;
            cB_dt.Location = new Point(315, 67);
            cB_dt.Name = "cB_dt";
            cB_dt.Size = new Size(121, 23);
            cB_dt.TabIndex = 13;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(491, 39);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 12;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // nUD_weight
            // 
            nUD_weight.DecimalPlaces = 1;
            nUD_weight.ImeMode = ImeMode.NoControl;
            nUD_weight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUD_weight.Location = new Point(316, 39);
            nUD_weight.Name = "nUD_weight";
            nUD_weight.Size = new Size(120, 23);
            nUD_weight.TabIndex = 9;
            nUD_weight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_weight
            // 
            lbl_weight.AutoSize = true;
            lbl_weight.Location = new Point(248, 39);
            lbl_weight.Name = "lbl_weight";
            lbl_weight.Size = new Size(45, 15);
            lbl_weight.TabIndex = 8;
            lbl_weight.Text = "Weight";
            // 
            // nUD_size
            // 
            nUD_size.DecimalPlaces = 2;
            nUD_size.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUD_size.Location = new Point(316, 10);
            nUD_size.Name = "nUD_size";
            nUD_size.Size = new Size(120, 23);
            nUD_size.TabIndex = 7;
            nUD_size.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // lbl_size
            // 
            lbl_size.AutoSize = true;
            lbl_size.Location = new Point(248, 10);
            lbl_size.Name = "lbl_size";
            lbl_size.Size = new Size(27, 15);
            lbl_size.TabIndex = 6;
            lbl_size.Text = "Size";
            // 
            // nUD_speed
            // 
            nUD_speed.DecimalPlaces = 1;
            nUD_speed.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUD_speed.Location = new Point(81, 68);
            nUD_speed.Name = "nUD_speed";
            nUD_speed.Size = new Size(120, 23);
            nUD_speed.TabIndex = 5;
            nUD_speed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lbl_speed
            // 
            lbl_speed.AutoSize = true;
            lbl_speed.Location = new Point(13, 68);
            lbl_speed.Name = "lbl_speed";
            lbl_speed.Size = new Size(39, 15);
            lbl_speed.TabIndex = 4;
            lbl_speed.Text = "Speed";
            // 
            // nUD_angle
            // 
            nUD_angle.DecimalPlaces = 1;
            nUD_angle.Location = new Point(81, 39);
            nUD_angle.Name = "nUD_angle";
            nUD_angle.Size = new Size(120, 23);
            nUD_angle.TabIndex = 3;
            nUD_angle.Value = new decimal(new int[] { 45, 0, 0, 0 });
            // 
            // lbl_angle
            // 
            lbl_angle.AutoSize = true;
            lbl_angle.Location = new Point(13, 39);
            lbl_angle.Name = "lbl_angle";
            lbl_angle.Size = new Size(38, 15);
            lbl_angle.TabIndex = 2;
            lbl_angle.Text = "Angle";
            // 
            // nUD_height
            // 
            nUD_height.Location = new Point(81, 10);
            nUD_height.Name = "nUD_height";
            nUD_height.Size = new Size(120, 23);
            nUD_height.TabIndex = 1;
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Location = new Point(13, 10);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new Size(43, 15);
            lbl_height.TabIndex = 0;
            lbl_height.Text = "Height";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(25, 143);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(763, 471);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // form_main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 626);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Name = "form_main";
            Text = "Lab01";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUD_weight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_angle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_height).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_Start;
        private NumericUpDown nUD_weight;
        private Label lbl_weight;
        private NumericUpDown nUD_size;
        private Label lbl_size;
        private NumericUpDown nUD_speed;
        private Label lbl_speed;
        private NumericUpDown nUD_angle;
        private Label lbl_angle;
        private NumericUpDown nUD_height;
        private Label lbl_height;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lbl_dt;
        private ComboBox cB_dt;
        private Button btn_Clear;
        private System.Windows.Forms.Timer timer1;
    }
}
