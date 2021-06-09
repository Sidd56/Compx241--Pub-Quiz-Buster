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
            this.labelMap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSelectedCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountryStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBoxDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(344, 50);
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
            this.labelCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(204, 340);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(120, 20);
            this.labelCountryName.TabIndex = 1;
            this.labelCountryName.Text = "Country name";
            // 
            // trackBarCountryStat
            // 
            this.trackBarCountryStat.BackColor = System.Drawing.SystemColors.Info;
            this.trackBarCountryStat.Location = new System.Drawing.Point(138, 272);
            this.trackBarCountryStat.Maximum = 4;
            this.trackBarCountryStat.Name = "trackBarCountryStat";
            this.trackBarCountryStat.Size = new System.Drawing.Size(200, 45);
            this.trackBarCountryStat.TabIndex = 2;
            this.trackBarCountryStat.TabStop = false;
            this.trackBarCountryStat.Value = 4;
            this.trackBarCountryStat.Scroll += new System.EventHandler(this.trackBarCountryStat_Scroll);
            // 
            // lblStatType
            // 
            this.lblStatType.AutoSize = true;
            this.lblStatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatType.Location = new System.Drawing.Point(121, 320);
            this.lblStatType.Name = "lblStatType";
            this.lblStatType.Size = new System.Drawing.Size(77, 20);
            this.lblStatType.TabIndex = 3;
            this.lblStatType.Text = "StatType:";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLabel.Location = new System.Drawing.Point(204, 320);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(43, 20);
            this.statLabel.TabIndex = 4;
            this.statLabel.Text = "Stat";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Cornsilk;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelX.Location = new System.Drawing.Point(354, 55);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 20);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.Color.Cornsilk;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelY.Location = new System.Drawing.Point(354, 75);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 20);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y:";
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFlag.InitialImage")));
            this.pictureBoxFlag.Location = new System.Drawing.Point(1023, 13);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(319, 708);
            this.pictureBoxFlag.TabIndex = 7;
            this.pictureBoxFlag.TabStop = false;
            this.pictureBoxFlag.Visible = false;
            this.pictureBoxFlag.Click += new System.EventHandler(this.pictureBoxFlag_Click);
            this.pictureBoxFlag.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFlag_Paint);
            this.pictureBoxFlag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFlag_MouseClick);
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMap.Location = new System.Drawing.Point(616, 9);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(140, 37);
            this.labelMap.TabIndex = 8;
            this.labelMap.Text = "MAP OF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(14, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Change size of country according to statistic!";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(251, 530);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 41);
            this.buttonExit.TabIndex = 45;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelSelectedCountry
            // 
            this.labelSelectedCountry.AutoSize = true;
            this.labelSelectedCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSelectedCountry.Location = new System.Drawing.Point(63, 340);
            this.labelSelectedCountry.Name = "labelSelectedCountry";
            this.labelSelectedCountry.Size = new System.Drawing.Size(135, 20);
            this.labelSelectedCountry.TabIndex = 46;
            this.labelSelectedCountry.Text = "Selected Country:";
            // 
            // GeographyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.labelSelectedCountry);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMap);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.lblStatType);
            this.Controls.Add(this.trackBarCountryStat);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "GeographyGame";
            this.Text = "Geo Puzzle";
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
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSelectedCountry;
    }
}