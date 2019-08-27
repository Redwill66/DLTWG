namespace GameofLifedanielT
{
    partial class Minesweeper
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
            this.txtrow = new System.Windows.Forms.TextBox();
            this.btnsize = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.lblcolum = new System.Windows.Forms.Label();
            this.lblrow = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtrow
            // 
            this.txtrow.Location = new System.Drawing.Point(1034, 136);
            this.txtrow.Name = "txtrow";
            this.txtrow.Size = new System.Drawing.Size(100, 20);
            this.txtrow.TabIndex = 0;
            this.txtrow.TextChanged += new System.EventHandler(this.txtrow_TextChanged);
            // 
            // btnsize
            // 
            this.btnsize.Location = new System.Drawing.Point(1034, 162);
            this.btnsize.Name = "btnsize";
            this.btnsize.Size = new System.Drawing.Size(75, 23);
            this.btnsize.TabIndex = 1;
            this.btnsize.Text = "Size";
            this.btnsize.UseVisualStyleBackColor = true;
            this.btnsize.Click += new System.EventHandler(this.btnsize_Click);
            // 
            // panMain
            // 
            this.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(25, 28);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(463, 481);
            this.panMain.TabIndex = 9;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(1034, 110);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(100, 20);
            this.txtColumn.TabIndex = 10;
            this.txtColumn.TextChanged += new System.EventHandler(this.txtColumn_TextChanged);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1106, 14);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 11;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblcolum
            // 
            this.lblcolum.AutoSize = true;
            this.lblcolum.Location = new System.Drawing.Point(1141, 110);
            this.lblcolum.Name = "lblcolum";
            this.lblcolum.Size = new System.Drawing.Size(43, 13);
            this.lblcolum.TabIndex = 12;
            this.lblcolum.Text = "Spalten";
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.Location = new System.Drawing.Point(1141, 139);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(41, 13);
            this.lblrow.TabIndex = 13;
            this.lblrow.Text = "Reihen";
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(1106, 43);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "Restart";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1195, 572);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblrow);
            this.Controls.Add(this.lblcolum);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnsize);
            this.Controls.Add(this.txtrow);
            this.Name = "Minesweeper";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrow;
        private System.Windows.Forms.Button btnsize;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblcolum;
        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Button btnreset;
    }
}