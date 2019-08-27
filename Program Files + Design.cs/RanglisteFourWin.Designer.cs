namespace GameofLifedanielT
{
    partial class frmRanglisteFourWin
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
            this.lvwrangfourWin = new System.Windows.Forms.ListView();
            this.FourWin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playenr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblfourwin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(428, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lvwrangfourWin
            // 
            this.lvwrangfourWin.AllowColumnReorder = true;
            this.lvwrangfourWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwrangfourWin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FourWin,
            this.Names,
            this.Surname,
            this.Playenr});
            this.lvwrangfourWin.GridLines = true;
            this.lvwrangfourWin.Location = new System.Drawing.Point(34, 93);
            this.lvwrangfourWin.Name = "lvwrangfourWin";
            this.lvwrangfourWin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvwrangfourWin.Size = new System.Drawing.Size(322, 372);
            this.lvwrangfourWin.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvwrangfourWin.TabIndex = 1;
            this.lvwrangfourWin.UseCompatibleStateImageBehavior = false;
            this.lvwrangfourWin.View = System.Windows.Forms.View.Details;
            this.lvwrangfourWin.SelectedIndexChanged += new System.EventHandler(this.lvwrangfourWin_SelectedIndexChanged);
            // 
            // FourWin
            // 
            this.FourWin.Text = "Vier Gewinnt";
            this.FourWin.Width = 80;
            // 
            // Names
            // 
            this.Names.Text = "Vorname";
            this.Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Names.Width = 80;
            // 
            // Surname
            // 
            this.Surname.Text = "Nachname";
            this.Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Surname.Width = 80;
            // 
            // Playenr
            // 
            this.Playenr.Text = "Playernummer";
            this.Playenr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Playenr.Width = 80;
            // 
            // lblfourwin
            // 
            this.lblfourwin.AutoSize = true;
            this.lblfourwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblfourwin.Location = new System.Drawing.Point(42, 46);
            this.lblfourwin.Name = "lblfourwin";
            this.lblfourwin.Size = new System.Drawing.Size(290, 31);
            this.lblfourwin.TabIndex = 2;
            this.lblfourwin.Text = "Vier Gewinnt Rangliste";
            // 
            // frmRanglisteFourWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 477);
            this.Controls.Add(this.lblfourwin);
            this.Controls.Add(this.lvwrangfourWin);
            this.Controls.Add(this.btnback);
            this.Name = "frmRanglisteFourWin";
            this.Text = "RanglisteFourWin";
            this.Load += new System.EventHandler(this.frmRanglisteFourWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ListView lvwrangfourWin;
       
        private System.Windows.Forms.ColumnHeader FourWin;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Playenr;
        private System.Windows.Forms.Label lblfourwin;
    }
}