namespace ExampleMVC.View
{
    partial class UserView
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_result = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(33, 28);
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(436, 21);
            this.txb_result.TabIndex = 0;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(475, 28);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 1;
            this.btn_set.Text = "Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(31, 64);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(38, 12);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "label1";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.txb_result);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(689, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label lbl_result;
    }
}
