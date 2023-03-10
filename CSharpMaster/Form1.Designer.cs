namespace CSharpMaster
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
            this.btn_fileStream = new System.Windows.Forms.Button();
            this.btn_binaryStream = new System.Windows.Forms.Button();
            this.btn_streamWritera = new System.Windows.Forms.Button();
            this.btn_serialize = new System.Windows.Forms.Button();
            this.btn_onlyFileStream = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_binaryStreamReview = new System.Windows.Forms.Button();
            this.btn_streamWriter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fileStream
            // 
            this.btn_fileStream.Location = new System.Drawing.Point(12, 28);
            this.btn_fileStream.Name = "btn_fileStream";
            this.btn_fileStream.Size = new System.Drawing.Size(128, 42);
            this.btn_fileStream.TabIndex = 0;
            this.btn_fileStream.Text = "FileStream";
            this.btn_fileStream.UseVisualStyleBackColor = true;
            this.btn_fileStream.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_binaryStream
            // 
            this.btn_binaryStream.Location = new System.Drawing.Point(146, 28);
            this.btn_binaryStream.Name = "btn_binaryStream";
            this.btn_binaryStream.Size = new System.Drawing.Size(128, 42);
            this.btn_binaryStream.TabIndex = 0;
            this.btn_binaryStream.Text = "BinaryStream";
            this.btn_binaryStream.UseVisualStyleBackColor = true;
            this.btn_binaryStream.Click += new System.EventHandler(this.btn_binaryStream_Click);
            // 
            // btn_streamWritera
            // 
            this.btn_streamWritera.Location = new System.Drawing.Point(280, 28);
            this.btn_streamWritera.Name = "btn_streamWritera";
            this.btn_streamWritera.Size = new System.Drawing.Size(128, 42);
            this.btn_streamWritera.TabIndex = 0;
            this.btn_streamWritera.Text = "StreamWriter";
            this.btn_streamWritera.UseVisualStyleBackColor = true;
            this.btn_streamWritera.Click += new System.EventHandler(this.btn_streamWritera_Click);
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(414, 28);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(128, 42);
            this.btn_serialize.TabIndex = 0;
            this.btn_serialize.Text = "Serialize";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.btn_serialize_Click);
            // 
            // btn_onlyFileStream
            // 
            this.btn_onlyFileStream.Location = new System.Drawing.Point(14, 124);
            this.btn_onlyFileStream.Name = "btn_onlyFileStream";
            this.btn_onlyFileStream.Size = new System.Drawing.Size(128, 42);
            this.btn_onlyFileStream.TabIndex = 0;
            this.btn_onlyFileStream.Text = "OnlyFileStream";
            this.btn_onlyFileStream.UseVisualStyleBackColor = true;
            this.btn_onlyFileStream.Click += new System.EventHandler(this.btn_onlyFileStream_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "FileStream";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Review";
            // 
            // btn_binaryStreamReview
            // 
            this.btn_binaryStreamReview.Location = new System.Drawing.Point(146, 124);
            this.btn_binaryStreamReview.Name = "btn_binaryStreamReview";
            this.btn_binaryStreamReview.Size = new System.Drawing.Size(128, 42);
            this.btn_binaryStreamReview.TabIndex = 0;
            this.btn_binaryStreamReview.Text = "BinaryStream";
            this.btn_binaryStreamReview.UseVisualStyleBackColor = true;
            this.btn_binaryStreamReview.Click += new System.EventHandler(this.btn_binaryStreamReview_Click);
            // 
            // btn_streamWriter
            // 
            this.btn_streamWriter.Location = new System.Drawing.Point(280, 124);
            this.btn_streamWriter.Name = "btn_streamWriter";
            this.btn_streamWriter.Size = new System.Drawing.Size(128, 42);
            this.btn_streamWriter.TabIndex = 0;
            this.btn_streamWriter.Text = "StreamWriter";
            this.btn_streamWriter.UseVisualStyleBackColor = true;
            this.btn_streamWriter.Click += new System.EventHandler(this.btn_streamWriter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_streamWriter);
            this.Controls.Add(this.btn_binaryStreamReview);
            this.Controls.Add(this.btn_onlyFileStream);
            this.Controls.Add(this.btn_serialize);
            this.Controls.Add(this.btn_streamWritera);
            this.Controls.Add(this.btn_binaryStream);
            this.Controls.Add(this.btn_fileStream);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fileStream;
        private System.Windows.Forms.Button btn_binaryStream;
        private System.Windows.Forms.Button btn_streamWritera;
        private System.Windows.Forms.Button btn_serialize;
        private System.Windows.Forms.Button btn_onlyFileStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_binaryStreamReview;
        private System.Windows.Forms.Button btn_streamWriter;
    }
}

