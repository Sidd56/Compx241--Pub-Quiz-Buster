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
            this.labelSelectRange = new System.Windows.Forms.Label();
            this.labelDownload = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radioButtonYearRange = new System.Windows.Forms.RadioButton();
            this.radioButtonDecade = new System.Windows.Forms.RadioButton();
            this.textBoxStartYear = new System.Windows.Forms.TextBox();
            this.textBoxEndYear = new System.Windows.Forms.TextBox();
            this.labelStartYear = new System.Windows.Forms.Label();
            this.labelEndYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStartGame.Location = new System.Drawing.Point(66, 109);
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
            this.comboBoxDecades.Location = new System.Drawing.Point(66, 70);
            this.comboBoxDecades.Name = "comboBoxDecades";
            this.comboBoxDecades.Size = new System.Drawing.Size(240, 33);
            this.comboBoxDecades.TabIndex = 33;
            this.comboBoxDecades.Visible = false;
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
            // labelSelectRange
            // 
            this.labelSelectRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectRange.AutoSize = true;
            this.labelSelectRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectRange.Location = new System.Drawing.Point(44, 9);
            this.labelSelectRange.Name = "labelSelectRange";
            this.labelSelectRange.Size = new System.Drawing.Size(289, 20);
            this.labelSelectRange.TabIndex = 41;
            this.labelSelectRange.Text = "Select range of songs to be quizzed on ";
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
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(312, 188);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 41);
            this.buttonExit.TabIndex = 43;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonYearRange
            // 
            this.radioButtonYearRange.AutoSize = true;
            this.radioButtonYearRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYearRange.Location = new System.Drawing.Point(48, 40);
            this.radioButtonYearRange.Name = "radioButtonYearRange";
            this.radioButtonYearRange.Size = new System.Drawing.Size(158, 24);
            this.radioButtonYearRange.TabIndex = 44;
            this.radioButtonYearRange.TabStop = true;
            this.radioButtonYearRange.Text = "Quiz by year range";
            this.radioButtonYearRange.UseVisualStyleBackColor = true;
            this.radioButtonYearRange.CheckedChanged += new System.EventHandler(this.radioButtonYearRange_CheckedChanged);
            // 
            // radioButtonDecade
            // 
            this.radioButtonDecade.AutoSize = true;
            this.radioButtonDecade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDecade.Location = new System.Drawing.Point(236, 40);
            this.radioButtonDecade.Name = "radioButtonDecade";
            this.radioButtonDecade.Size = new System.Drawing.Size(136, 24);
            this.radioButtonDecade.TabIndex = 45;
            this.radioButtonDecade.TabStop = true;
            this.radioButtonDecade.Text = "Quiz by decade";
            this.radioButtonDecade.UseVisualStyleBackColor = true;
            this.radioButtonDecade.CheckedChanged += new System.EventHandler(this.radioButtonDecade_CheckedChanged);
            // 
            // textBoxStartYear
            // 
            this.textBoxStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartYear.Location = new System.Drawing.Point(66, 70);
            this.textBoxStartYear.Name = "textBoxStartYear";
            this.textBoxStartYear.Size = new System.Drawing.Size(100, 31);
            this.textBoxStartYear.TabIndex = 46;
            this.textBoxStartYear.Visible = false;
            // 
            // textBoxEndYear
            // 
            this.textBoxEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndYear.Location = new System.Drawing.Point(251, 70);
            this.textBoxEndYear.Name = "textBoxEndYear";
            this.textBoxEndYear.Size = new System.Drawing.Size(100, 31);
            this.textBoxEndYear.TabIndex = 47;
            this.textBoxEndYear.Visible = false;
            // 
            // labelStartYear
            // 
            this.labelStartYear.AutoSize = true;
            this.labelStartYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartYear.Location = new System.Drawing.Point(12, 77);
            this.labelStartYear.Name = "labelStartYear";
            this.labelStartYear.Size = new System.Drawing.Size(48, 20);
            this.labelStartYear.TabIndex = 48;
            this.labelStartYear.Text = "Start:";
            this.labelStartYear.Visible = false;
            // 
            // labelEndYear
            // 
            this.labelEndYear.AutoSize = true;
            this.labelEndYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndYear.Location = new System.Drawing.Point(203, 77);
            this.labelEndYear.Name = "labelEndYear";
            this.labelEndYear.Size = new System.Drawing.Size(42, 20);
            this.labelEndYear.TabIndex = 49;
            this.labelEndYear.Text = "End:";
            this.labelEndYear.Visible = false;
            // 
            // Music_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.labelEndYear);
            this.Controls.Add(this.labelStartYear);
            this.Controls.Add(this.textBoxEndYear);
            this.Controls.Add(this.textBoxStartYear);
            this.Controls.Add(this.radioButtonDecade);
            this.Controls.Add(this.radioButtonYearRange);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.labelSelectRange);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.comboBoxDecades);
            this.Controls.Add(this.buttonStartGame);
            this.MinimumSize = new System.Drawing.Size(413, 280);
            this.Name = "Music_Menu";
            this.Text = "Pub Quiz Buster - Music Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Music_Menu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.ComboBox comboBoxDecades;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label labelSelectRange;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonYearRange;
        private System.Windows.Forms.RadioButton radioButtonDecade;
        private System.Windows.Forms.TextBox textBoxStartYear;
        private System.Windows.Forms.TextBox textBoxEndYear;
        private System.Windows.Forms.Label labelStartYear;
        private System.Windows.Forms.Label labelEndYear;
    }
}