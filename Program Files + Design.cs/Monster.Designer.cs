namespace GameofLifedanielT
{
    partial class frmMonster
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
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // picMonster
            // 
            this.picMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMonster.Location = new System.Drawing.Point(34, 34);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(540, 495);
            this.picMonster.TabIndex = 0;
            this.picMonster.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(664, 506);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 569);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.picMonster);
            this.Name = "frmMonster";
            this.Text = "Monster";
            this.Load += new System.EventHandler(this.frmMonster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.Button btnclose;
    }
}