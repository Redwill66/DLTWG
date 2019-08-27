namespace GameofLifedanielT
{
    partial class frmHelp_Page
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
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btnLore = new System.Windows.Forms.Button();
            this.lstHelpLore = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblwappen = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.picwappen = new System.Windows.Forms.PictureBox();
            this.picnpc = new System.Windows.Forms.PictureBox();
            this.btnnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picwappen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnpc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(193, 164);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(509, 311);
            this.txtHelp.TabIndex = 15;
            // 
            // btnhelp
            // 
            this.btnhelp.Location = new System.Drawing.Point(25, 30);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(75, 23);
            this.btnhelp.TabIndex = 16;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btnLore
            // 
            this.btnLore.Location = new System.Drawing.Point(117, 30);
            this.btnLore.Name = "btnLore";
            this.btnLore.Size = new System.Drawing.Size(75, 23);
            this.btnLore.TabIndex = 17;
            this.btnLore.Text = "Lore";
            this.btnLore.UseVisualStyleBackColor = true;
            this.btnLore.Click += new System.EventHandler(this.btnLore_Click);
            // 
            // lstHelpLore
            // 
            this.lstHelpLore.FormattingEnabled = true;
            this.lstHelpLore.Location = new System.Drawing.Point(25, 72);
            this.lstHelpLore.Name = "lstHelpLore";
            this.lstHelpLore.Size = new System.Drawing.Size(162, 407);
            this.lstHelpLore.TabIndex = 18;
            this.lstHelpLore.SelectedIndexChanged += new System.EventHandler(this.lstHelpLore_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(251, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 21;
            // 
            // lblwappen
            // 
            this.lblwappen.AutoSize = true;
            this.lblwappen.Location = new System.Drawing.Point(445, 143);
            this.lblwappen.Name = "lblwappen";
            this.lblwappen.Size = new System.Drawing.Size(0, 13);
            this.lblwappen.TabIndex = 22;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(661, 505);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // picwappen
            // 
            this.picwappen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picwappen.Location = new System.Drawing.Point(496, 12);
            this.picwappen.Name = "picwappen";
            this.picwappen.Size = new System.Drawing.Size(159, 126);
            this.picwappen.TabIndex = 20;
            this.picwappen.TabStop = false;
            // 
            // picnpc
            // 
            this.picnpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picnpc.Location = new System.Drawing.Point(263, 10);
            this.picnpc.Name = "picnpc";
            this.picnpc.Size = new System.Drawing.Size(155, 128);
            this.picnpc.TabIndex = 19;
            this.picnpc.TabStop = false;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(661, 115);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(43, 23);
            this.btnnext.TabIndex = 24;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // frmHelp_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 540);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblwappen);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picwappen);
            this.Controls.Add(this.picnpc);
            this.Controls.Add(this.lstHelpLore);
            this.Controls.Add(this.btnLore);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.txtHelp);
            this.Name = "frmHelp_Page";
            this.Text = "Help_Page";
            ((System.ComponentModel.ISupportInitialize)(this.picwappen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btnLore;
        private System.Windows.Forms.ListBox lstHelpLore;
        private System.Windows.Forms.PictureBox picnpc;
        private System.Windows.Forms.PictureBox picwappen;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblwappen;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
    }
}