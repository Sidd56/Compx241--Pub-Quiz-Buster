namespace Youtube_MP3_Downloader
{
    partial class Form1
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
            this.textBoxYoutubeUrl = new System.Windows.Forms.TextBox();
            this.Youtube = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxLoading = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxYoutubeUrl
            // 
            this.textBoxYoutubeUrl.Location = new System.Drawing.Point(60, 77);
            this.textBoxYoutubeUrl.Name = "textBoxYoutubeUrl";
            this.textBoxYoutubeUrl.Size = new System.Drawing.Size(434, 20);
            this.textBoxYoutubeUrl.TabIndex = 0;
            // 
            // Youtube
            // 
            this.Youtube.AutoSize = true;
            this.Youtube.Location = new System.Drawing.Point(60, 51);
            this.Youtube.Name = "Youtube";
            this.Youtube.Size = new System.Drawing.Size(63, 13);
            this.Youtube.TabIndex = 1;
            this.Youtube.Text = "Youtube Url";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(60, 119);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(223, 48);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxLoading
            // 
            this.textBoxLoading.Location = new System.Drawing.Point(394, 44);
            this.textBoxLoading.Name = "textBoxLoading";
            this.textBoxLoading.ReadOnly = true;
            this.textBoxLoading.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoading.TabIndex = 3;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(289, 119);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(205, 48);
            this.buttonDone.TabIndex = 4;
            this.buttonDone.Text = "Done (Delete)";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 213);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxLoading);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.Youtube);
            this.Controls.Add(this.textBoxYoutubeUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYoutubeUrl;
        private System.Windows.Forms.Label Youtube;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxLoading;
        private System.Windows.Forms.Button buttonDone;
    }
}

