namespace _01_AsyncAwait
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
            this.btn_walking = new System.Windows.Forms.Button();
            this.lbl_walking = new System.Windows.Forms.Label();
            this.btn_phone = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.btn_talking = new System.Windows.Forms.Button();
            this.lbl_talking = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_walking
            // 
            this.btn_walking.Location = new System.Drawing.Point(12, 12);
            this.btn_walking.Name = "btn_walking";
            this.btn_walking.Size = new System.Drawing.Size(93, 52);
            this.btn_walking.TabIndex = 0;
            this.btn_walking.Text = "Walking";
            this.btn_walking.UseVisualStyleBackColor = true;
            this.btn_walking.Click += new System.EventHandler(this.btn_run1);
            // 
            // lbl_walking
            // 
            this.lbl_walking.AutoSize = true;
            this.lbl_walking.Location = new System.Drawing.Point(111, 32);
            this.lbl_walking.Name = "lbl_walking";
            this.lbl_walking.Size = new System.Drawing.Size(38, 12);
            this.lbl_walking.TabIndex = 1;
            this.lbl_walking.Text = "label1";
            // 
            // btn_phone
            // 
            this.btn_phone.Location = new System.Drawing.Point(12, 70);
            this.btn_phone.Name = "btn_phone";
            this.btn_phone.Size = new System.Drawing.Size(93, 52);
            this.btn_phone.TabIndex = 0;
            this.btn_phone.Text = "Phone";
            this.btn_phone.UseVisualStyleBackColor = true;
            this.btn_phone.Click += new System.EventHandler(this.btn_run2);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(111, 90);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(38, 12);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "label1";
            // 
            // btn_talking
            // 
            this.btn_talking.Location = new System.Drawing.Point(12, 128);
            this.btn_talking.Name = "btn_talking";
            this.btn_talking.Size = new System.Drawing.Size(93, 52);
            this.btn_talking.TabIndex = 0;
            this.btn_talking.Text = "Talking";
            this.btn_talking.UseVisualStyleBackColor = true;
            this.btn_talking.Click += new System.EventHandler(this.btn_run3);
            // 
            // lbl_talking
            // 
            this.lbl_talking.AutoSize = true;
            this.lbl_talking.Location = new System.Drawing.Point(111, 148);
            this.lbl_talking.Name = "lbl_talking";
            this.lbl_talking.Size = new System.Drawing.Size(38, 12);
            this.lbl_talking.TabIndex = 1;
            this.lbl_talking.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(268, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 172);
            this.listBox1.TabIndex = 2;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(169, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(93, 52);
            this.btn_all.TabIndex = 0;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 198);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_talking);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_walking);
            this.Controls.Add(this.btn_talking);
            this.Controls.Add(this.btn_phone);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_walking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_walking;
        private System.Windows.Forms.Label lbl_walking;
        private System.Windows.Forms.Button btn_phone;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Button btn_talking;
        private System.Windows.Forms.Label lbl_talking;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_all;
    }
}

