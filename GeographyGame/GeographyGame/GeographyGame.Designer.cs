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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeographyGame));
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.trackBarCountryStat = new System.Windows.Forms.TrackBar();
            this.lblStatType = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.lblFlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountryStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(172, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(790, 521);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBoxDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDisplay_MouseClick);
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
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(15, 214);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(15, 237);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y:";
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlag.InitialImage")));
            this.pictureBoxFlag.Location = new System.Drawing.Point(999, 12);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(405, 656);
            this.pictureBoxFlag.TabIndex = 7;
            this.pictureBoxFlag.TabStop = false;
            this.pictureBoxFlag.Click += new System.EventHandler(this.pictureBoxFlag_Click);
            this.pictureBoxFlag.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFlag_Paint);
            this.pictureBoxFlag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFlag_MouseClick);
            // 
            // lblFlag
            // 
            this.lblFlag.AutoSize = true;
            this.lblFlag.Location = new System.Drawing.Point(1236, 237);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(45, 13);
            this.lblFlag.TabIndex = 8;
            this.lblFlag.Text = "Flag of: ";
            // 
            // GeographyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 862);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.trackBarCountryStat);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "GeographyGame";
            this.Text = "GeographyGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountryStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.TrackBar trackBarCountryStat;
        private System.Windows.Forms.Label lblStatType;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Label lblFlag;
    }
}