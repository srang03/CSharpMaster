namespace Thread_Pool
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
            this.btn_sameThread = new System.Windows.Forms.Button();
            this.btn_backgroundThread = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sameThread
            // 
            this.btn_sameThread.Location = new System.Drawing.Point(21, 12);
            this.btn_sameThread.Name = "btn_sameThread";
            this.btn_sameThread.Size = new System.Drawing.Size(109, 97);
            this.btn_sameThread.TabIndex = 0;
            this.btn_sameThread.Text = "파일 복사 비동기 (동일 스레드)";
            this.btn_sameThread.UseVisualStyleBackColor = true;
            // 
            // btn_backgroundThread
            // 
            this.btn_backgroundThread.Location = new System.Drawing.Point(21, 129);
            this.btn_backgroundThread.Name = "btn_backgroundThread";
            this.btn_backgroundThread.Size = new System.Drawing.Size(109, 97);
            this.btn_backgroundThread.TabIndex = 0;
            this.btn_backgroundThread.Text = "파일 복사 비동기 (백그라운드 스레드)";
            this.btn_backgroundThread.UseVisualStyleBackColor = true;
            this.btn_backgroundThread.Click += new System.EventHandler(this.btn_backgroundThread_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(163, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(402, 38);
            this.progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(163, 129);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(402, 38);
            this.progressBar2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_backgroundThread);
            this.Controls.Add(this.btn_sameThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sameThread;
        private System.Windows.Forms.Button btn_backgroundThread;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

