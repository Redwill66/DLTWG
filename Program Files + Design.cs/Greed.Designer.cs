namespace GameofLifedanielT
{
    partial class frmGreed
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
            this.btnback = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.lblgameover = new System.Windows.Forms.Label();
            this.lblscore2 = new System.Windows.Forms.Label();
            this.lblscore1 = new System.Windows.Forms.Label();
            this.lblplayer2 = new System.Windows.Forms.Label();
            this.lblplayer1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(675, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(56, 21);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panMain
            // 
            this.panMain.AutoSize = true;
            this.panMain.Location = new System.Drawing.Point(37, 83);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(200, 100);
            this.panMain.TabIndex = 2;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.Location = new System.Drawing.Point(349, 14);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(0, 13);
            this.lblgameover.TabIndex = 12;
            // 
            // lblscore2
            // 
            this.lblscore2.AutoSize = true;
            this.lblscore2.Location = new System.Drawing.Point(285, 41);
            this.lblscore2.Name = "lblscore2";
            this.lblscore2.Size = new System.Drawing.Size(0, 13);
            this.lblscore2.TabIndex = 11;
            // 
            // lblscore1
            // 
            this.lblscore1.AutoSize = true;
            this.lblscore1.Location = new System.Drawing.Point(43, 41);
            this.lblscore1.Name = "lblscore1";
            this.lblscore1.Size = new System.Drawing.Size(0, 13);
            this.lblscore1.TabIndex = 10;
            // 
            // lblplayer2
            // 
            this.lblplayer2.AutoSize = true;
            this.lblplayer2.Location = new System.Drawing.Point(282, 15);
            this.lblplayer2.Name = "lblplayer2";
            this.lblplayer2.Size = new System.Drawing.Size(45, 13);
            this.lblplayer2.TabIndex = 9;
            this.lblplayer2.Text = "Player 2";
            // 
            // lblplayer1
            // 
            this.lblplayer1.AutoSize = true;
            this.lblplayer1.Location = new System.Drawing.Point(43, 16);
            this.lblplayer1.Name = "lblplayer1";
            this.lblplayer1.Size = new System.Drawing.Size(45, 13);
            this.lblplayer1.TabIndex = 8;
            this.lblplayer1.Text = "Player 1";
            // 
            // frmGreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(743, 494);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.lblscore2);
            this.Controls.Add(this.lblscore1);
            this.Controls.Add(this.lblplayer2);
            this.Controls.Add(this.lblplayer1);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnback);
            this.Name = "frmGreed";
            this.Text = "Greed";
            this.Load += new System.EventHandler(this.frmGreed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.Label lblscore2;
        private System.Windows.Forms.Label lblscore1;
        private System.Windows.Forms.Label lblplayer2;
        private System.Windows.Forms.Label lblplayer1;
    }
}