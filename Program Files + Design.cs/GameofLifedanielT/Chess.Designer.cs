namespace GameofLifedanielT
{
    partial class frmChess
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
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnSize = new System.Windows.Forms.Button();
            this.lblwidth = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.cboumwandelung = new System.Windows.Forms.ComboBox();
            this.lblumwand = new System.Windows.Forms.Label();
            this.lblumwan2 = new System.Windows.Forms.Label();
            this.lblturn = new System.Windows.Forms.Label();
            this.btngiveup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(973, 78);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            // 
            // btnSize
            // 
            this.btnSize.Location = new System.Drawing.Point(973, 112);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(100, 29);
            this.btnSize.TabIndex = 2;
            this.btnSize.Text = "Spielfeldgrösse";
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // lblwidth
            // 
            this.lblwidth.AutoSize = true;
            this.lblwidth.Location = new System.Drawing.Point(1079, 81);
            this.lblwidth.Name = "lblwidth";
            this.lblwidth.Size = new System.Drawing.Size(40, 13);
            this.lblwidth.TabIndex = 4;
            this.lblwidth.Text = "Grösse";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1107, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panMain
            // 
            this.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(26, 55);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(701, 594);
            this.panMain.TabIndex = 9;
            // 
            // cboumwandelung
            // 
            this.cboumwandelung.FormattingEnabled = true;
            this.cboumwandelung.Items.AddRange(new object[] {
            "Queen",
            "Tower",
            "Bishop",
            "Knight"});
            this.cboumwandelung.Location = new System.Drawing.Point(973, 194);
            this.cboumwandelung.Name = "cboumwandelung";
            this.cboumwandelung.Size = new System.Drawing.Size(121, 21);
            this.cboumwandelung.TabIndex = 10;
            // 
            // lblumwand
            // 
            this.lblumwand.AutoSize = true;
            this.lblumwand.Location = new System.Drawing.Point(973, 175);
            this.lblumwand.Name = "lblumwand";
            this.lblumwand.Size = new System.Drawing.Size(49, 13);
            this.lblumwand.TabIndex = 11;
            this.lblumwand.Text = "Bauer in ";
            // 
            // lblumwan2
            // 
            this.lblumwan2.AutoSize = true;
            this.lblumwan2.Location = new System.Drawing.Point(973, 218);
            this.lblumwan2.Name = "lblumwan2";
            this.lblumwan2.Size = new System.Drawing.Size(63, 13);
            this.lblumwan2.TabIndex = 12;
            this.lblumwan2.Text = "Umwandeln";
            // 
            // lblturn
            // 
            this.lblturn.AutoSize = true;
            this.lblturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblturn.Location = new System.Drawing.Point(33, 21);
            this.lblturn.Name = "lblturn";
            this.lblturn.Size = new System.Drawing.Size(184, 31);
            this.lblturn.TabIndex = 13;
            this.lblturn.Text = "Weiss ist dran";
            // 
            // btngiveup
            // 
            this.btngiveup.Location = new System.Drawing.Point(976, 626);
            this.btngiveup.Name = "btngiveup";
            this.btngiveup.Size = new System.Drawing.Size(164, 23);
            this.btngiveup.TabIndex = 14;
            this.btngiveup.Text = "Aufgeben";
            this.btngiveup.UseVisualStyleBackColor = true;
            this.btngiveup.Click += new System.EventHandler(this.btngiveup_Click);
            // 
            // frmChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1199, 705);
            this.Controls.Add(this.btngiveup);
            this.Controls.Add(this.lblturn);
            this.Controls.Add(this.lblumwan2);
            this.Controls.Add(this.lblumwand);
            this.Controls.Add(this.cboumwandelung);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblwidth);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.txtSize);
            this.Name = "frmChess";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.frmChess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Label lblwidth;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.ComboBox cboumwandelung;
        private System.Windows.Forms.Label lblumwand;
        private System.Windows.Forms.Label lblumwan2;
        private System.Windows.Forms.Label lblturn;
        private System.Windows.Forms.Button btngiveup;
    }
}