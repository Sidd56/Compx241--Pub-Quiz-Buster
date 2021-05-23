namespace Pub_Busters___Musical_Bingo
{
    partial class Musical_Bingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musical_Bingo));
            this.labelBingoTitle = new System.Windows.Forms.Label();
            this.radioButtonArtistNames = new System.Windows.Forms.RadioButton();
            this.radioButtonSongNames = new System.Windows.Forms.RadioButton();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.pictureBoxBoard = new System.Windows.Forms.PictureBox();
            this.buttonHint = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBingoTitle
            // 
            this.labelBingoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBingoTitle.AutoSize = true;
            this.labelBingoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBingoTitle.Location = new System.Drawing.Point(12, 9);
            this.labelBingoTitle.Name = "labelBingoTitle";
            this.labelBingoTitle.Size = new System.Drawing.Size(386, 55);
            this.labelBingoTitle.TabIndex = 38;
            this.labelBingoTitle.Text = "B    I    N    G    O";
            // 
            // radioButtonArtistNames
            // 
            this.radioButtonArtistNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonArtistNames.AutoSize = true;
            this.radioButtonArtistNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonArtistNames.Location = new System.Drawing.Point(50, 486);
            this.radioButtonArtistNames.Name = "radioButtonArtistNames";
            this.radioButtonArtistNames.Size = new System.Drawing.Size(154, 24);
            this.radioButtonArtistNames.TabIndex = 37;
            this.radioButtonArtistNames.TabStop = true;
            this.radioButtonArtistNames.Text = "Quiz Artist Names";
            this.radioButtonArtistNames.UseVisualStyleBackColor = true;
            // 
            // radioButtonSongNames
            // 
            this.radioButtonSongNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonSongNames.AutoSize = true;
            this.radioButtonSongNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSongNames.Location = new System.Drawing.Point(243, 486);
            this.radioButtonSongNames.Name = "radioButtonSongNames";
            this.radioButtonSongNames.Size = new System.Drawing.Size(155, 24);
            this.radioButtonSongNames.TabIndex = 36;
            this.radioButtonSongNames.TabStop = true;
            this.radioButtonSongNames.Text = "Quiz Song Names";
            this.radioButtonSongNames.UseVisualStyleBackColor = true;
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.Enabled = false;
            this.buttonSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSkip.Location = new System.Drawing.Point(497, 439);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(240, 41);
            this.buttonSkip.TabIndex = 33;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStartGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartGame.Location = new System.Drawing.Point(87, 516);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(240, 41);
            this.buttonStartGame.TabIndex = 31;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // pictureBoxBoard
            // 
            this.pictureBoxBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBoard.Location = new System.Drawing.Point(22, 78);
            this.pictureBoxBoard.MinimumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxBoard.Name = "pictureBoxBoard";
            this.pictureBoxBoard.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoard.TabIndex = 30;
            this.pictureBoxBoard.TabStop = false;
            this.pictureBoxBoard.SizeChanged += new System.EventHandler(this.pictureBoxBoard_SizeChanged);
            this.pictureBoxBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBoard_MouseClick);
            // 
            // buttonHint
            // 
            this.buttonHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHint.Enabled = false;
            this.buttonHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHint.Location = new System.Drawing.Point(497, 392);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(240, 41);
            this.buttonHint.TabIndex = 41;
            this.buttonHint.Text = "Hint";
            this.buttonHint.UseVisualStyleBackColor = true;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMessage.Location = new System.Drawing.Point(428, 111);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(82, 20);
            this.labelMessage.TabIndex = 42;
            this.labelMessage.Text = "[Message]";
            this.labelMessage.Visible = false;
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(432, 147);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(356, 224);
            this.musicPlayer.TabIndex = 43;
            // 
            // Musical_Bingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonHint);
            this.Controls.Add(this.labelBingoTitle);
            this.Controls.Add(this.radioButtonArtistNames);
            this.Controls.Add(this.radioButtonSongNames);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.pictureBoxBoard);
            this.MinimumSize = new System.Drawing.Size(816, 615);
            this.Name = "Musical_Bingo";
            this.Text = "Pub Quiz Busters - Musical Bingo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Musical_Bingo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBingoTitle;
        private System.Windows.Forms.RadioButton radioButtonArtistNames;
        private System.Windows.Forms.RadioButton radioButtonSongNames;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.PictureBox pictureBoxBoard;
        private System.Windows.Forms.Button buttonHint;
        private System.Windows.Forms.Label labelMessage;
        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
    }
}

