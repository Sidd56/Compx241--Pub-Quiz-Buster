namespace GeographyGame
{
    partial class GeographyMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeographyMenu));
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxContinent = new System.Windows.Forms.ComboBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(55, 137);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(240, 41);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Confirm Selection";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxContinent
            // 
            this.comboBoxContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContinent.FormattingEnabled = true;
            this.comboBoxContinent.Items.AddRange(new object[] {
            "South America",
            "Europe"});
            this.comboBoxContinent.Location = new System.Drawing.Point(56, 76);
            this.comboBoxContinent.Name = "comboBoxContinent";
            this.comboBoxContinent.Size = new System.Drawing.Size(240, 33);
            this.comboBoxContinent.TabIndex = 1;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLog.Location = new System.Drawing.Point(51, 44);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(245, 20);
            this.labelLog.TabIndex = 10;
            this.labelLog.Text = "Select continent to be quizzed on";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(312, 188);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 41);
            this.buttonExit.TabIndex = 44;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // GeographyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 241);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.comboBoxContinent);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(413, 280);
            this.Name = "GeographyMenu";
            this.Text = "Geography Menu";
            this.Load += new System.EventHandler(this.GeographyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxContinent;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonExit;
    }
}

