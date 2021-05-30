namespace Pub_Busters___Musical_Bingo
{
    partial class Music_Menu
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.comboBoxDecades = new System.Windows.Forms.ComboBox();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.labelSelectDecade = new System.Windows.Forms.Label();
            this.labelDownload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStartGame.Location = new System.Drawing.Point(66, 96);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(240, 41);
            this.buttonStartGame.TabIndex = 32;
            this.buttonStartGame.Text = "Confirm Selection";
            this.buttonStartGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // comboBoxDecades
            // 
            this.comboBoxDecades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDecades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDecades.FormattingEnabled = true;
            this.comboBoxDecades.Items.AddRange(new object[] {
            "1960-1969",
            "1970-1979",
            "1980-1989",
            "1990-1999",
            "2000-2009",
            "2010-2019",
            "2020-2021"});
            this.comboBoxDecades.Location = new System.Drawing.Point(66, 46);
            this.comboBoxDecades.Name = "comboBoxDecades";
            this.comboBoxDecades.Size = new System.Drawing.Size(240, 33);
            this.comboBoxDecades.TabIndex = 33;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoading.Location = new System.Drawing.Point(66, 156);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(240, 41);
            this.progressBarLoading.TabIndex = 40;
            // 
            // labelSelectDecade
            // 
            this.labelSelectDecade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectDecade.AutoSize = true;
            this.labelSelectDecade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectDecade.Location = new System.Drawing.Point(44, 23);
            this.labelSelectDecade.Name = "labelSelectDecade";
            this.labelSelectDecade.Size = new System.Drawing.Size(301, 20);
            this.labelSelectDecade.TabIndex = 41;
            this.labelSelectDecade.Text = "Select decade of songs to be quizzed on ";
            // 
            // labelDownload
            // 
            this.labelDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDownload.AutoSize = true;
            this.labelDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDownload.Location = new System.Drawing.Point(62, 200);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(247, 20);
            this.labelDownload.TabIndex = 42;
            this.labelDownload.Text = "Downloading songs, please wait...";
            this.labelDownload.Visible = false;
            // 
            // Music_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.labelSelectDecade);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.comboBoxDecades);
            this.Controls.Add(this.buttonStartGame);
            this.MinimumSize = new System.Drawing.Size(413, 280);
            this.Name = "Music_Menu";
            this.Text = "Pub Quiz Busters - Music Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Music_Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.ComboBox comboBoxDecades;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label labelSelectDecade;
        private System.Windows.Forms.Label labelDownload;
    }
}