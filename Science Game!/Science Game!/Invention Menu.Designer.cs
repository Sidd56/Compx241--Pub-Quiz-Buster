namespace Science_Game_
{
    partial class Science_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Science_Game));
            this.labelDownload = new System.Windows.Forms.Label();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDownload.Location = new System.Drawing.Point(12, 212);
            this.labelDownload.MinimumSize = new System.Drawing.Size(385, 20);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(385, 20);
            this.labelDownload.TabIndex = 44;
            this.labelDownload.Text = "Downloading pictures to program folder, please wait...";
            this.labelDownload.Visible = false;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(65, 159);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(240, 41);
            this.progressBarLoading.TabIndex = 43;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(311, 159);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 41);
            this.buttonExit.TabIndex = 46;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStartGame.Location = new System.Drawing.Point(65, 86);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(240, 41);
            this.buttonStartGame.TabIndex = 45;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Press start to be quizzed on inventions/inventors!";
            // 
            // Science_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.progressBarLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(413, 280);
            this.Name = "Science_Game";
            this.Text = "Sci and Tech Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label label1;
    }
}