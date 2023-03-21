namespace AwaitAsync._05_WhyUseCancellationToken
{
    partial class WhyUseCancellationTokenForm
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lbl_progress1 = new System.Windows.Forms.Label();
            this.lbl_progress2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(623, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 46);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(93, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 46);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 138);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(623, 23);
            this.progressBar2.TabIndex = 0;
            // 
            // lbl_progress1
            // 
            this.lbl_progress1.AutoSize = true;
            this.lbl_progress1.Location = new System.Drawing.Point(12, 102);
            this.lbl_progress1.Name = "lbl_progress1";
            this.lbl_progress1.Size = new System.Drawing.Size(38, 12);
            this.lbl_progress1.TabIndex = 2;
            this.lbl_progress1.Text = "label1";
            // 
            // lbl_progress2
            // 
            this.lbl_progress2.AutoSize = true;
            this.lbl_progress2.Location = new System.Drawing.Point(12, 164);
            this.lbl_progress2.Name = "lbl_progress2";
            this.lbl_progress2.Size = new System.Drawing.Size(38, 12);
            this.lbl_progress2.TabIndex = 2;
            this.lbl_progress2.Text = "label1";
            // 
            // WhyUseCancellationTokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 192);
            this.Controls.Add(this.lbl_progress2);
            this.Controls.Add(this.lbl_progress1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Name = "WhyUseCancellationTokenForm";
            this.Text = "WhyUseCancellationTokenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lbl_progress1;
        private System.Windows.Forms.Label lbl_progress2;
    }
}