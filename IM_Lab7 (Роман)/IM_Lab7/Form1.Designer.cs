
namespace IM_Lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.countPersons = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countСriminalСase = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadness = new System.Windows.Forms.NumericUpDown();
            this.qualy = new System.Windows.Forms.NumericUpDown();
            this.site = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeProc = new System.Windows.Forms.NumericUpDown();
            this.timeInvest = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countСriminalСase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInvest)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(236, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(594, 394);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(59, 364);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 40);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // countPersons
            // 
            this.countPersons.Location = new System.Drawing.Point(135, 10);
            this.countPersons.Margin = new System.Windows.Forms.Padding(2);
            this.countPersons.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countPersons.Name = "countPersons";
            this.countPersons.Size = new System.Drawing.Size(90, 20);
            this.countPersons.TabIndex = 2;
            this.countPersons.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Штат сотрудников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во дел";
            // 
            // countСriminalСase
            // 
            this.countСriminalСase.Location = new System.Drawing.Point(135, 42);
            this.countСriminalСase.Margin = new System.Windows.Forms.Padding(2);
            this.countСriminalСase.Name = "countСriminalСase";
            this.countСriminalСase.Size = new System.Drawing.Size(90, 20);
            this.countСriminalСase.TabIndex = 5;
            this.countСriminalСase.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Загруженность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Квалификация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Участок";
            // 
            // loadness
            // 
            this.loadness.DecimalPlaces = 2;
            this.loadness.Enabled = false;
            this.loadness.Location = new System.Drawing.Point(105, 75);
            this.loadness.Name = "loadness";
            this.loadness.Size = new System.Drawing.Size(120, 20);
            this.loadness.TabIndex = 9;
            // 
            // qualy
            // 
            this.qualy.DecimalPlaces = 2;
            this.qualy.Enabled = false;
            this.qualy.Location = new System.Drawing.Point(105, 104);
            this.qualy.Name = "qualy";
            this.qualy.Size = new System.Drawing.Size(120, 20);
            this.qualy.TabIndex = 10;
            // 
            // site
            // 
            this.site.Enabled = false;
            this.site.Location = new System.Drawing.Point(105, 134);
            this.site.Name = "site";
            this.site.Size = new System.Drawing.Size(120, 20);
            this.site.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Обработка заяв.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Время расслед.";
            // 
            // timeProc
            // 
            this.timeProc.DecimalPlaces = 2;
            this.timeProc.Enabled = false;
            this.timeProc.Location = new System.Drawing.Point(105, 163);
            this.timeProc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeProc.Name = "timeProc";
            this.timeProc.Size = new System.Drawing.Size(120, 20);
            this.timeProc.TabIndex = 14;
            // 
            // timeInvest
            // 
            this.timeInvest.DecimalPlaces = 2;
            this.timeInvest.Enabled = false;
            this.timeInvest.Location = new System.Drawing.Point(104, 189);
            this.timeInvest.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeInvest.Name = "timeInvest";
            this.timeInvest.Size = new System.Drawing.Size(120, 20);
            this.timeInvest.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 414);
            this.Controls.Add(this.timeInvest);
            this.Controls.Add(this.timeProc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.site);
            this.Controls.Add(this.qualy);
            this.Controls.Add(this.loadness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countСriminalСase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countPersons);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countСriminalСase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInvest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown countPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown countСriminalСase;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown loadness;
        private System.Windows.Forms.NumericUpDown qualy;
        private System.Windows.Forms.NumericUpDown site;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown timeProc;
        private System.Windows.Forms.NumericUpDown timeInvest;
    }
}

