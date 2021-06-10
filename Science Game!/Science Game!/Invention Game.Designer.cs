
namespace Science_Game_
{
    partial class Inventions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventions));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxInventionPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxInventorPic = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonScrollUp = new System.Windows.Forms.Button();
            this.buttonScrollDown = new System.Windows.Forms.Button();
            this.labelInventionName = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventionPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(89, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Guess the inventor to the invention! Correctly guess 3 to win!";
            // 
            // pictureBoxInventionPic
            // 
            this.pictureBoxInventionPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxInventionPic.Location = new System.Drawing.Point(363, 178);
            this.pictureBoxInventionPic.Name = "pictureBoxInventionPic";
            this.pictureBoxInventionPic.Size = new System.Drawing.Size(348, 352);
            this.pictureBoxInventionPic.TabIndex = 26;
            this.pictureBoxInventionPic.TabStop = false;
            // 
            // pictureBoxInventorPic
            // 
            this.pictureBoxInventorPic.Location = new System.Drawing.Point(111, 86);
            this.pictureBoxInventorPic.Name = "pictureBoxInventorPic";
            this.pictureBoxInventorPic.Size = new System.Drawing.Size(236, 568);
            this.pictureBoxInventorPic.TabIndex = 25;
            this.pictureBoxInventorPic.TabStop = false;
            this.pictureBoxInventorPic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxInventorPic_MouseClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(671, 613);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(73, 41);
            this.buttonExit.TabIndex = 47;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStartGame.Location = new System.Drawing.Point(424, 536);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(240, 41);
            this.buttonStartGame.TabIndex = 48;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonScrollUp
            // 
            this.buttonScrollUp.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonScrollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonScrollUp.Location = new System.Drawing.Point(20, 86);
            this.buttonScrollUp.Name = "buttonScrollUp";
            this.buttonScrollUp.Size = new System.Drawing.Size(85, 75);
            this.buttonScrollUp.TabIndex = 51;
            this.buttonScrollUp.Text = "Up";
            this.buttonScrollUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonScrollUp.UseVisualStyleBackColor = false;
            this.buttonScrollUp.Click += new System.EventHandler(this.buttonScrollUp_Click);
            // 
            // buttonScrollDown
            // 
            this.buttonScrollDown.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonScrollDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonScrollDown.Location = new System.Drawing.Point(25, 579);
            this.buttonScrollDown.Name = "buttonScrollDown";
            this.buttonScrollDown.Size = new System.Drawing.Size(80, 75);
            this.buttonScrollDown.TabIndex = 52;
            this.buttonScrollDown.Text = "Down";
            this.buttonScrollDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonScrollDown.UseVisualStyleBackColor = false;
            this.buttonScrollDown.Click += new System.EventHandler(this.buttonScrollDown_Click);
            // 
            // labelInventionName
            // 
            this.labelInventionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInventionName.AutoSize = true;
            this.labelInventionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventionName.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelInventionName.Location = new System.Drawing.Point(359, 151);
            this.labelInventionName.Name = "labelInventionName";
            this.labelInventionName.Size = new System.Drawing.Size(101, 24);
            this.labelInventionName.TabIndex = 53;
            this.labelInventionName.Text = "Invention:";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelResult.Location = new System.Drawing.Point(107, 59);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 24);
            this.labelResult.TabIndex = 54;
            this.labelResult.Text = "Result";
            this.labelResult.Visible = false;
            // 
            // labelCorrect
            // 
            this.labelCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrect.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelCorrect.Location = new System.Drawing.Point(359, 86);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(162, 24);
            this.labelCorrect.TabIndex = 55;
            this.labelCorrect.Text = "Correct Count: 0";
            // 
            // Inventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 666);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInventionName);
            this.Controls.Add(this.buttonScrollDown);
            this.Controls.Add(this.buttonScrollUp);
            this.Controls.Add(this.pictureBoxInventorPic);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxInventionPic);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(772, 705);
            this.Name = "Inventions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventions!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventions_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventionPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInventorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxInventorPic;
        private System.Windows.Forms.PictureBox pictureBoxInventionPic;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonScrollUp;
        private System.Windows.Forms.Button buttonScrollDown;
        private System.Windows.Forms.Label labelInventionName;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelCorrect;
    }
}

