namespace AsyncAwait
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_Dance = new System.Windows.Forms.Button();
            this.btn_Listening = new System.Windows.Forms.Button();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Control;
            this.btn_play.Location = new System.Drawing.Point(30, 12);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(92, 51);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_Dance
            // 
            this.btn_Dance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Dance.Location = new System.Drawing.Point(30, 89);
            this.btn_Dance.Name = "btn_Dance";
            this.btn_Dance.Size = new System.Drawing.Size(92, 51);
            this.btn_Dance.TabIndex = 0;
            this.btn_Dance.Text = "Dance";
            this.btn_Dance.UseVisualStyleBackColor = false;
            this.btn_Dance.Click += new System.EventHandler(this.btn_Dance_Click);
            // 
            // btn_Listening
            // 
            this.btn_Listening.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Listening.Location = new System.Drawing.Point(30, 168);
            this.btn_Listening.Name = "btn_Listening";
            this.btn_Listening.Size = new System.Drawing.Size(92, 51);
            this.btn_Listening.TabIndex = 0;
            this.btn_Listening.Text = "Listening";
            this.btn_Listening.UseVisualStyleBackColor = false;
            this.btn_Listening.Click += new System.EventHandler(this.btn_Listening_Click);
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 12;
            this.lbx_list.Location = new System.Drawing.Point(145, 12);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(559, 208);
            this.lbx_list.TabIndex = 1;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(612, 235);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 44);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 291);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.btn_Listening);
            this.Controls.Add(this.btn_Dance);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_Dance;
        private System.Windows.Forms.Button btn_Listening;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.Button btn_clear;
    }
}

