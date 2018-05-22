namespace BetterGameOf21ThomasA
{
    partial class frmBetterGameOf21
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
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mniGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picCom1 = new System.Windows.Forms.PictureBox();
            this.picCom2 = new System.Windows.Forms.PictureBox();
            this.picCom3 = new System.Windows.Forms.PictureBox();
            this.picPly1 = new System.Windows.Forms.PictureBox();
            this.picPly2 = new System.Windows.Forms.PictureBox();
            this.picPly3 = new System.Windows.Forms.PictureBox();
            this.lblHitPrompt = new System.Windows.Forms.Label();
            this.btnStay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly3)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = global::BetterGameOf21ThomasA.Properties.Resources.Blackjack_Background;
            this.picBackground.Location = new System.Drawing.Point(0, 27);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(1282, 616);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Emoji", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(581, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGame});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1281, 24);
            this.mnuMainMenu.TabIndex = 2;
            // 
            // mniGame
            // 
            this.mniGame.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mniGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniGame.Name = "mniGame";
            this.mniGame.Size = new System.Drawing.Size(50, 20);
            this.mniGame.Text = "Game";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // picCom1
            // 
            this.picCom1.Location = new System.Drawing.Point(324, 94);
            this.picCom1.Name = "picCom1";
            this.picCom1.Size = new System.Drawing.Size(107, 164);
            this.picCom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCom1.TabIndex = 3;
            this.picCom1.TabStop = false;
            this.picCom1.Visible = false;
            // 
            // picCom2
            // 
            this.picCom2.Location = new System.Drawing.Point(509, 94);
            this.picCom2.Name = "picCom2";
            this.picCom2.Size = new System.Drawing.Size(107, 164);
            this.picCom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCom2.TabIndex = 4;
            this.picCom2.TabStop = false;
            this.picCom2.Visible = false;
            // 
            // picCom3
            // 
            this.picCom3.Location = new System.Drawing.Point(693, 94);
            this.picCom3.Name = "picCom3";
            this.picCom3.Size = new System.Drawing.Size(107, 164);
            this.picCom3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCom3.TabIndex = 5;
            this.picCom3.TabStop = false;
            this.picCom3.Visible = false;
            // 
            // picPly1
            // 
            this.picPly1.Location = new System.Drawing.Point(324, 358);
            this.picPly1.Name = "picPly1";
            this.picPly1.Size = new System.Drawing.Size(107, 164);
            this.picPly1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPly1.TabIndex = 6;
            this.picPly1.TabStop = false;
            this.picPly1.Visible = false;
            // 
            // picPly2
            // 
            this.picPly2.Location = new System.Drawing.Point(509, 358);
            this.picPly2.Name = "picPly2";
            this.picPly2.Size = new System.Drawing.Size(107, 164);
            this.picPly2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPly2.TabIndex = 7;
            this.picPly2.TabStop = false;
            this.picPly2.Visible = false;
            // 
            // picPly3
            // 
            this.picPly3.Location = new System.Drawing.Point(693, 358);
            this.picPly3.Name = "picPly3";
            this.picPly3.Size = new System.Drawing.Size(107, 164);
            this.picPly3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPly3.TabIndex = 8;
            this.picPly3.TabStop = false;
            this.picPly3.Visible = false;
            this.picPly3.Click += new System.EventHandler(this.picPly3_Click);
            // 
            // lblHitPrompt
            // 
            this.lblHitPrompt.AutoSize = true;
            this.lblHitPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitPrompt.Location = new System.Drawing.Point(716, 537);
            this.lblHitPrompt.Name = "lblHitPrompt";
            this.lblHitPrompt.Size = new System.Drawing.Size(245, 24);
            this.lblHitPrompt.TabIndex = 9;
            this.lblHitPrompt.Text = "Hit blue card for a third card!";
            this.lblHitPrompt.Visible = false;
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(926, 428);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(85, 32);
            this.btnStay.TabIndex = 10;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Visible = false;
            // 
            // frmBetterGameOf21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 643);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.lblHitPrompt);
            this.Controls.Add(this.picPly3);
            this.Controls.Add(this.picPly2);
            this.Controls.Add(this.picPly1);
            this.Controls.Add(this.picCom3);
            this.Controls.Add(this.picCom2);
            this.Controls.Add(this.picCom1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmBetterGameOf21";
            this.Text = "A Better Game Of 21 By Thomas Aubin";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPly3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mniGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.PictureBox picCom1;
        private System.Windows.Forms.PictureBox picCom2;
        private System.Windows.Forms.PictureBox picCom3;
        private System.Windows.Forms.PictureBox picPly1;
        private System.Windows.Forms.PictureBox picPly2;
        private System.Windows.Forms.PictureBox picPly3;
        private System.Windows.Forms.Label lblHitPrompt;
        private System.Windows.Forms.Button btnStay;
    }
}

