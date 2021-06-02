namespace Main_Menu___Game_Selection
{
    partial class Main_Menu
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonScience = new System.Windows.Forms.Button();
            this.buttonGeography = new System.Windows.Forms.Button();
            this.buttonPlayMusicalBingo = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(715, 269);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 44);
            this.buttonExit.TabIndex = 49;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonScience
            // 
            this.buttonScience.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScience.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScience.Location = new System.Drawing.Point(451, 243);
            this.buttonScience.Name = "buttonScience";
            this.buttonScience.Size = new System.Drawing.Size(259, 67);
            this.buttonScience.TabIndex = 48;
            this.buttonScience.Text = "Play Science + Tech";
            this.buttonScience.UseVisualStyleBackColor = false;
            this.buttonScience.Click += new System.EventHandler(this.buttonScience_Click);
            // 
            // buttonGeography
            // 
            this.buttonGeography.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGeography.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonGeography.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeography.Location = new System.Drawing.Point(451, 30);
            this.buttonGeography.Name = "buttonGeography";
            this.buttonGeography.Size = new System.Drawing.Size(259, 67);
            this.buttonGeography.TabIndex = 47;
            this.buttonGeography.Text = "Play Geography Game";
            this.buttonGeography.UseVisualStyleBackColor = false;
            this.buttonGeography.Click += new System.EventHandler(this.buttonGeography_Click);
            // 
            // buttonPlayMusicalBingo
            // 
            this.buttonPlayMusicalBingo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayMusicalBingo.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonPlayMusicalBingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayMusicalBingo.Location = new System.Drawing.Point(451, 136);
            this.buttonPlayMusicalBingo.Name = "buttonPlayMusicalBingo";
            this.buttonPlayMusicalBingo.Size = new System.Drawing.Size(259, 67);
            this.buttonPlayMusicalBingo.TabIndex = 46;
            this.buttonPlayMusicalBingo.Text = "Play Musical Bingo";
            this.buttonPlayMusicalBingo.UseVisualStyleBackColor = false;
            this.buttonPlayMusicalBingo.Click += new System.EventHandler(this.buttonPlayMusicalBingo_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.BackgroundImage = global::Main_Menu___Game_Selection.Properties.Resources.Pub_Quiz_Buster_Logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(337, 327);
            this.pictureBoxLogo.TabIndex = 45;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonScience);
            this.Controls.Add(this.buttonGeography);
            this.Controls.Add(this.buttonPlayMusicalBingo);
            this.Controls.Add(this.pictureBoxLogo);
            this.MinimumSize = new System.Drawing.Size(816, 364);
            this.Name = "Main_Menu";
            this.Text = "Pub Quiz Buster - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonScience;
        private System.Windows.Forms.Button buttonGeography;
        private System.Windows.Forms.Button buttonPlayMusicalBingo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

