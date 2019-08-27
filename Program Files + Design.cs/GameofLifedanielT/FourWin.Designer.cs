namespace GameofLifedanielT
{
    partial class frmFourWin
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
            this.txtboxsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtboxsearch2 = new System.Windows.Forms.TextBox();
            this.btnsearch2 = new System.Windows.Forms.Button();
            this.lblplayeryellow = new System.Windows.Forms.Label();
            this.lblplayerred = new System.Windows.Forms.Label();
            this.lstplayerYellow = new System.Windows.Forms.ListBox();
            this.lstplayerRed = new System.Windows.Forms.ListBox();
            this.btnrang = new System.Windows.Forms.Button();
            this.btnFree = new System.Windows.Forms.Button();
            this.lblGameover = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(957, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panMain
            // 
            this.panMain.AutoSize = true;
            this.panMain.Location = new System.Drawing.Point(225, 109);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(536, 492);
            this.panMain.TabIndex = 1;
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Location = new System.Drawing.Point(27, 72);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.Size = new System.Drawing.Size(120, 20);
            this.txtboxsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(155, 72);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Suchen";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtboxsearch2
            // 
            this.txtboxsearch2.Location = new System.Drawing.Point(804, 76);
            this.txtboxsearch2.Name = "txtboxsearch2";
            this.txtboxsearch2.Size = new System.Drawing.Size(121, 20);
            this.txtboxsearch2.TabIndex = 6;
            // 
            // btnsearch2
            // 
            this.btnsearch2.Location = new System.Drawing.Point(723, 72);
            this.btnsearch2.Name = "btnsearch2";
            this.btnsearch2.Size = new System.Drawing.Size(75, 23);
            this.btnsearch2.TabIndex = 7;
            this.btnsearch2.Text = "Suchen";
            this.btnsearch2.UseVisualStyleBackColor = true;
            this.btnsearch2.Click += new System.EventHandler(this.btnsearch2_Click);
            // 
            // lblplayeryellow
            // 
            this.lblplayeryellow.AutoSize = true;
            this.lblplayeryellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblplayeryellow.Location = new System.Drawing.Point(22, 38);
            this.lblplayeryellow.Name = "lblplayeryellow";
            this.lblplayeryellow.Size = new System.Drawing.Size(155, 31);
            this.lblplayeryellow.TabIndex = 8;
            this.lblplayeryellow.Text = "Player Gelb";
            // 
            // lblplayerred
            // 
            this.lblplayerred.AutoSize = true;
            this.lblplayerred.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblplayerred.Location = new System.Drawing.Point(784, 27);
            this.lblplayerred.Name = "lblplayerred";
            this.lblplayerred.Size = new System.Drawing.Size(141, 31);
            this.lblplayerred.TabIndex = 9;
            this.lblplayerred.Text = "Player Rot";
            // 
            // lstplayerYellow
            // 
            this.lstplayerYellow.FormattingEnabled = true;
            this.lstplayerYellow.Location = new System.Drawing.Point(27, 110);
            this.lstplayerYellow.Name = "lstplayerYellow";
            this.lstplayerYellow.Size = new System.Drawing.Size(120, 329);
            this.lstplayerYellow.TabIndex = 10;
            this.lstplayerYellow.SelectedIndexChanged += new System.EventHandler(this.lstplayerYellow_SelectedIndexChanged);
            // 
            // lstplayerRed
            // 
            this.lstplayerRed.FormattingEnabled = true;
            this.lstplayerRed.Location = new System.Drawing.Point(805, 110);
            this.lstplayerRed.Name = "lstplayerRed";
            this.lstplayerRed.Size = new System.Drawing.Size(120, 329);
            this.lstplayerRed.TabIndex = 11;
            this.lstplayerRed.SelectedIndexChanged += new System.EventHandler(this.lstplayerRed_SelectedIndexChanged);
            // 
            // btnrang
            // 
            this.btnrang.Location = new System.Drawing.Point(957, 41);
            this.btnrang.Name = "btnrang";
            this.btnrang.Size = new System.Drawing.Size(75, 23);
            this.btnrang.TabIndex = 12;
            this.btnrang.Text = "Rangliste";
            this.btnrang.UseVisualStyleBackColor = true;
            this.btnrang.Click += new System.EventHandler(this.btnrang_Click);
            // 
            // btnFree
            // 
            this.btnFree.Location = new System.Drawing.Point(957, 70);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(75, 23);
            this.btnFree.TabIndex = 13;
            this.btnFree.Text = "Freeplay";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // lblGameover
            // 
            this.lblGameover.AutoSize = true;
            this.lblGameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblGameover.Location = new System.Drawing.Point(371, 27);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(0, 31);
            this.lblGameover.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(957, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmFourWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 639);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblGameover);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.btnrang);
            this.Controls.Add(this.lstplayerRed);
            this.Controls.Add(this.lstplayerYellow);
            this.Controls.Add(this.lblplayerred);
            this.Controls.Add(this.lblplayeryellow);
            this.Controls.Add(this.btnsearch2);
            this.Controls.Add(this.txtboxsearch2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnback);
            this.Name = "frmFourWin";
            this.Text = "FourWin";
            this.Load += new System.EventHandler(this.frmFourWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.TextBox txtboxsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtboxsearch2;
        private System.Windows.Forms.Button btnsearch2;
        private System.Windows.Forms.Label lblplayeryellow;
        private System.Windows.Forms.Label lblplayerred;
        private System.Windows.Forms.ListBox lstplayerYellow;
        private System.Windows.Forms.ListBox lstplayerRed;
        private System.Windows.Forms.Button btnrang;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Label lblGameover;
        private System.Windows.Forms.Button btnReset;
    }
}