namespace AwaitAsync
{
    partial class SyncAndAsyncFunctionForm
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
            this.btnfunc3 = new System.Windows.Forms.Button();
            this.lbl_func1 = new System.Windows.Forms.Label();
            this.lbl_func2 = new System.Windows.Forms.Label();
            this.lbl_func3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_func1
            // 
            this.btn_func1.Location = new System.Drawing.Point(12, 12);
            this.btn_func1.Name = "btn_func1";
            this.btn_func1.Size = new System.Drawing.Size(84, 35);
            this.btn_func1.TabIndex = 0;
            this.btn_func1.Text = "기능 1";
            this.btn_func1.UseVisualStyleBackColor = true;
            this.btn_func1.Click += new System.EventHandler(this.btn_func1_Click);
            // 
            // btn_func2
            // 
            this.btn_func2.Location = new System.Drawing.Point(12, 53);
            this.btn_func2.Name = "btn_func2";
            this.btn_func2.Size = new System.Drawing.Size(84, 35);
            this.btn_func2.TabIndex = 0;
            this.btn_func2.Text = "기능 2";
            this.btn_func2.UseVisualStyleBackColor = true;
            this.btn_func2.Click += new System.EventHandler(this.btn_func2_Click);
            // 
            // btnfunc3
            // 
            this.btnfunc3.Location = new System.Drawing.Point(12, 94);
            this.btnfunc3.Name = "btnfunc3";
            this.btnfunc3.Size = new System.Drawing.Size(84, 35);
            this.btnfunc3.TabIndex = 0;
            this.btnfunc3.Text = "기능 3";
            this.btnfunc3.UseVisualStyleBackColor = true;
            this.btnfunc3.Click += new System.EventHandler(this.btnfunc3_Click);
            // 
            // lbl_func1
            // 
            this.lbl_func1.AutoSize = true;
            this.lbl_func1.Location = new System.Drawing.Point(102, 23);
            this.lbl_func1.Name = "lbl_func1";
            this.lbl_func1.Size = new System.Drawing.Size(11, 12);
            this.lbl_func1.TabIndex = 1;
            this.lbl_func1.Text = "0";
            // 
            // lbl_func2
            // 
            this.lbl_func2.AutoSize = true;
            this.lbl_func2.Location = new System.Drawing.Point(102, 64);
            this.lbl_func2.Name = "lbl_func2";
            this.lbl_func2.Size = new System.Drawing.Size(11, 12);
            this.lbl_func2.TabIndex = 1;
            this.lbl_func2.Text = "0";
            // 
            // lbl_func3
            // 
            this.lbl_func3.AutoSize = true;
            this.lbl_func3.Location = new System.Drawing.Point(102, 105);
            this.lbl_func3.Name = "lbl_func3";
            this.lbl_func3.Size = new System.Drawing.Size(11, 12);
            this.lbl_func3.TabIndex = 1;
            this.lbl_func3.Text = "0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(323, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 124);
            this.listBox1.TabIndex = 2;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(233, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(84, 35);
            this.btn_all.TabIndex = 0;
            this.btn_all.Text = "모든 기능";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 154);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_func3);
            this.Controls.Add(this.lbl_func2);
            this.Controls.Add(this.lbl_func1);
            this.Controls.Add(this.btnfunc3);
            this.Controls.Add(this.btn_func2);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_func1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_func1;
        private System.Windows.Forms.Button btn_func2;
        private System.Windows.Forms.Button btnfunc3;
        private System.Windows.Forms.Label lbl_func1;
        private System.Windows.Forms.Label lbl_func2;
        private System.Windows.Forms.Label lbl_func3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_all;
    }
}

