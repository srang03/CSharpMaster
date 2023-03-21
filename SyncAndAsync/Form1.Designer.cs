namespace SyncAndAsync
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
            this.btn_func1 = new System.Windows.Forms.Button();
            this.btn_func2 = new System.Windows.Forms.Button();
            this.btn_func3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_func1
            // 
            this.btn_func1.Location = new System.Drawing.Point(12, 12);
            this.btn_func1.Name = "btn_func1";
            this.btn_func1.Size = new System.Drawing.Size(119, 45);
            this.btn_func1.TabIndex = 0;
            this.btn_func1.Text = "기능 1";
            this.btn_func1.UseVisualStyleBackColor = true;
            this.btn_func1.Click += new System.EventHandler(this.btn_func_Click);
            // 
            // btn_func2
            // 
            this.btn_func2.Location = new System.Drawing.Point(12, 63);
            this.btn_func2.Name = "btn_func2";
            this.btn_func2.Size = new System.Drawing.Size(119, 45);
            this.btn_func2.TabIndex = 0;
            this.btn_func2.Text = "기능 2";
            this.btn_func2.UseVisualStyleBackColor = true;
            this.btn_func2.Click += new System.EventHandler(this.btn_func_Click);
            // 
            // btn_func3
            // 
            this.btn_func3.Location = new System.Drawing.Point(12, 114);
            this.btn_func3.Name = "btn_func3";
            this.btn_func3.Size = new System.Drawing.Size(119, 45);
            this.btn_func3.TabIndex = 0;
            this.btn_func3.Text = "기능 3";
            this.btn_func3.UseVisualStyleBackColor = true;
            this.btn_func3.Click += new System.EventHandler(this.btn_func_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(173, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 148);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 170);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_func3);
            this.Controls.Add(this.btn_func2);
            this.Controls.Add(this.btn_func1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_func1;
        private System.Windows.Forms.Button btn_func2;
        private System.Windows.Forms.Button btn_func3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

