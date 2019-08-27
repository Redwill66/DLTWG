namespace GameofLifedanielT
{
    partial class frmNewPlayer
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtplayerNr = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPlayerNr = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblsucsess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(276, 22);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtname.Location = new System.Drawing.Point(28, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(172, 38);
            this.txtname.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblname.Location = new System.Drawing.Point(206, 62);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(123, 31);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Vorname";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtSurname.Location = new System.Drawing.Point(28, 105);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(172, 38);
            this.txtSurname.TabIndex = 3;
            // 
            // txtplayerNr
            // 
            this.txtplayerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtplayerNr.Location = new System.Drawing.Point(28, 149);
            this.txtplayerNr.Name = "txtplayerNr";
            this.txtplayerNr.Size = new System.Drawing.Size(172, 38);
            this.txtplayerNr.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblSurname.Location = new System.Drawing.Point(206, 112);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(145, 31);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Nachname";
            // 
            // lblPlayerNr
            // 
            this.lblPlayerNr.AutoSize = true;
            this.lblPlayerNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPlayerNr.Location = new System.Drawing.Point(206, 156);
            this.lblPlayerNr.Name = "lblPlayerNr";
            this.lblPlayerNr.Size = new System.Drawing.Size(120, 31);
            this.lblPlayerNr.TabIndex = 6;
            this.lblPlayerNr.Text = "PlayerNr";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(265, 287);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblsucsess
            // 
            this.lblsucsess.AutoSize = true;
            this.lblsucsess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblsucsess.Location = new System.Drawing.Point(22, 233);
            this.lblsucsess.Name = "lblsucsess";
            this.lblsucsess.Size = new System.Drawing.Size(0, 31);
            this.lblsucsess.TabIndex = 8;
            // 
            // frmNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 322);
            this.Controls.Add(this.lblsucsess);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblPlayerNr);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtplayerNr);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnback);
            this.Name = "frmNewPlayer";
            this.Text = "NewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtplayerNr;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPlayerNr;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblsucsess;
    }
}