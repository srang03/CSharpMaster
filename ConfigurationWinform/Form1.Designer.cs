namespace ConfigurationWinform
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(22, 12);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(312, 21);
            this.txt_input.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(340, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "button1";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(20, 36);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(38, 12);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "label1";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Bisque;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.SkyBlue;
            chartArea1.AxisY2.IsMarginVisible = false;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY2.LineWidth = 0;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(71, 102);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.EmptyPointStyle.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.LightGreen;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Whatsapp";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Khaki;
            series2.MarkerBorderWidth = 2;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Kakao";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series3.MarkerColor = System.Drawing.Color.White;
            series3.MarkerSize = 10;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Camera";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(653, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

