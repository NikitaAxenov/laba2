namespace fly1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.height = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.forHeight = new System.Windows.Forms.NumericUpDown();
            this.forAngle = new System.Windows.Forms.NumericUpDown();
            this.forSpeed = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.time = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.forHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(42, 28);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(64, 20);
            this.height.TabIndex = 0;
            this.height.Text = "Height";
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angle.Location = new System.Drawing.Point(42, 80);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(56, 20);
            this.angle.TabIndex = 1;
            this.angle.Text = "Angle";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed.Location = new System.Drawing.Point(42, 128);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(58, 19);
            this.speed.TabIndex = 2;
            this.speed.Text = "Speed";
            // 
            // forHeight
            // 
            this.forHeight.Location = new System.Drawing.Point(153, 29);
            this.forHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forHeight.Name = "forHeight";
            this.forHeight.Size = new System.Drawing.Size(120, 22);
            this.forHeight.TabIndex = 3;
            this.forHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forAngle
            // 
            this.forAngle.Location = new System.Drawing.Point(153, 78);
            this.forAngle.Name = "forAngle";
            this.forAngle.Size = new System.Drawing.Size(120, 22);
            this.forAngle.TabIndex = 4;
            // 
            // forSpeed
            // 
            this.forSpeed.Location = new System.Drawing.Point(153, 128);
            this.forSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forSpeed.Name = "forSpeed";
            this.forSpeed.Size = new System.Drawing.Size(120, 22);
            this.forSpeed.TabIndex = 5;
            this.forSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(42, 200);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "Launch";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart
            // 
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(306, 28);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(785, 413);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(108, 295);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(87, 31);
            this.time.TabIndex = 8;
            this.time.Text = "00:00";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(194, 200);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(194, 243);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 10;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 516);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.time);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.forSpeed);
            this.Controls.Add(this.forAngle);
            this.Controls.Add(this.forHeight);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.height);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.forHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.NumericUpDown forHeight;
        private System.Windows.Forms.NumericUpDown forAngle;
        private System.Windows.Forms.NumericUpDown forSpeed;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
    }
}

