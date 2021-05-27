namespace GeographyGame
{
    partial class GeographyGame
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.trackBarCountryStat = new System.Windows.Forms.TrackBar();
            this.lblStatType = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountryStat)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(172, 37);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(728, 429);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBoxDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Location = new System.Drawing.Point(12, 37);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(46, 13);
            this.labelCountryName.TabIndex = 1;
            this.labelCountryName.Text = "Country:";
            // 
            // trackBarCountryStat
            // 
            this.trackBarCountryStat.Location = new System.Drawing.Point(12, 83);
            this.trackBarCountryStat.Maximum = 4;
            this.trackBarCountryStat.Name = "trackBarCountryStat";
            this.trackBarCountryStat.Size = new System.Drawing.Size(139, 45);
            this.trackBarCountryStat.TabIndex = 2;
            this.trackBarCountryStat.TabStop = false;
            this.trackBarCountryStat.Value = 4;
            this.trackBarCountryStat.Scroll += new System.EventHandler(this.trackBarCountryStat_Scroll);
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Location = new System.Drawing.Point(12, 67);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Size = new System.Drawing.Size(35, 13);
            this.lblStatType.TabIndex = 3;
            this.lblStatType.Text = "label1";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Location = new System.Drawing.Point(66, 67);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(35, 13);
            this.statLabel.TabIndex = 4;
            this.statLabel.Text = "label1";
            // 
            // GeographyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 545);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.trackBarCountryStat);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "GeographyGame";
            this.Text = "GeographyGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountryStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.TrackBar trackBarCountryStat;
        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.Label statLabel;
    }
}