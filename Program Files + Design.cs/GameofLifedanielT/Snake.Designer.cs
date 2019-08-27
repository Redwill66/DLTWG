namespace GameofLifedanielT
{
    partial class frmSnake
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
            this.components = new System.ComponentModel.Container();
            this.panMain = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.tmrsnake = new System.Windows.Forms.Timer(this.components);
            this.Btncreate = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.lblSnake = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.AutoSize = true;
            this.panMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panMain.Location = new System.Drawing.Point(28, 57);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(0, 0);
            this.panMain.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1355, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tmrsnake
            // 
            this.tmrsnake.Tick += new System.EventHandler(this.tmrsnake_Tick);
            // 
            // Btncreate
            // 
            this.Btncreate.Location = new System.Drawing.Point(1179, 12);
            this.Btncreate.Name = "Btncreate";
            this.Btncreate.Size = new System.Drawing.Size(75, 23);
            this.Btncreate.TabIndex = 4;
            this.Btncreate.Text = "Create Field";
            this.Btncreate.UseVisualStyleBackColor = true;
            this.Btncreate.Click += new System.EventHandler(this.Btncreate_Click);
            // 
            // btndown
            // 
            this.btndown.Enabled = false;
            this.btndown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btndown.Location = new System.Drawing.Point(537, 712);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(97, 32);
            this.btndown.TabIndex = 5;
            this.btndown.Text = "↓";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnup
            // 
            this.btnup.Enabled = false;
            this.btnup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnup.Location = new System.Drawing.Point(537, 674);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(97, 32);
            this.btnup.TabIndex = 6;
            this.btnup.Text = "↑";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btnleft
            // 
            this.btnleft.Enabled = false;
            this.btnleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnleft.Location = new System.Drawing.Point(434, 712);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(97, 32);
            this.btnleft.TabIndex = 7;
            this.btnleft.Text = "←";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnright
            // 
            this.btnright.Enabled = false;
            this.btnright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnright.Location = new System.Drawing.Point(640, 712);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(97, 32);
            this.btnright.TabIndex = 8;
            this.btnright.Text = "→";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // lblSnake
            // 
            this.lblSnake.AutoSize = true;
            this.lblSnake.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblSnake.Location = new System.Drawing.Point(326, 12);
            this.lblSnake.Name = "lblSnake";
            this.lblSnake.Size = new System.Drawing.Size(0, 31);
            this.lblSnake.TabIndex = 9;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(1274, 12);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 756);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblSnake);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.Btncreate);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panMain);
            this.Name = "frmSnake";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Timer tmrsnake;
        private System.Windows.Forms.Button Btncreate;
        private System.Windows.Forms.Button btndown;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Label lblSnake;
        private System.Windows.Forms.Button btnreset;
    }
}