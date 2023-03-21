namespace AwaitAsync._05_01_WhyUseCancellationToken
{
    partial class WhyUseCancellationTokenForm2
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_pb1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbl_pb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(610, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // lbl_pb1
            // 
            this.lbl_pb1.AutoSize = true;
            this.lbl_pb1.Location = new System.Drawing.Point(628, 71);
            this.lbl_pb1.Name = "lbl_pb1";
            this.lbl_pb1.Size = new System.Drawing.Size(11, 12);
            this.lbl_pb1.TabIndex = 1;
            this.lbl_pb1.Text = "0";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(11, 16);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(86, 30);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(103, 16);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(86, 30);
            this.btn_end.TabIndex = 2;
            this.btn_end.Text = "End";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 107);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(610, 23);
            this.progressBar2.TabIndex = 0;
            // 
            // lbl_pb2
            // 
            this.lbl_pb2.AutoSize = true;
            this.lbl_pb2.Location = new System.Drawing.Point(628, 113);
            this.lbl_pb2.Name = "lbl_pb2";
            this.lbl_pb2.Size = new System.Drawing.Size(11, 12);
            this.lbl_pb2.TabIndex = 1;
            this.lbl_pb2.Text = "0";
            // 
            // WhyUseCancellationTokenForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 154);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_pb2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.lbl_pb1);
            this.Controls.Add(this.progressBar1);
            this.Name = "WhyUseCancellationTokenForm2";
            this.Text = "WhyUseCancellationTokenForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhyUseCancellationTokenForm2_FormClosing);
            this.Load += new System.EventHandler(this.WhyUseCancellationTokenForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_pb1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbl_pb2;
    }
}