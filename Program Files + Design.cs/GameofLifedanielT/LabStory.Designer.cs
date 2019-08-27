namespace GameofLifedanielT
{
    partial class frmLabStory
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
            this.btnclose = new System.Windows.Forms.Button();
            this.picmap = new System.Windows.Forms.PictureBox();
            this.txtchapter = new System.Windows.Forms.TextBox();
            this.lblstory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1010, 612);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Back";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // picmap
            // 
            this.picmap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picmap.Location = new System.Drawing.Point(27, 40);
            this.picmap.Name = "picmap";
            this.picmap.Size = new System.Drawing.Size(791, 523);
            this.picmap.TabIndex = 1;
            this.picmap.TabStop = false;
            // 
            // txtchapter
            // 
            this.txtchapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchapter.Location = new System.Drawing.Point(824, 40);
            this.txtchapter.Multiline = true;
            this.txtchapter.Name = "txtchapter";
            this.txtchapter.Size = new System.Drawing.Size(261, 523);
            this.txtchapter.TabIndex = 2;
            // 
            // lblstory
            // 
            this.lblstory.AutoSize = true;
            this.lblstory.Location = new System.Drawing.Point(24, 577);
            this.lblstory.Name = "lblstory";
            this.lblstory.Size = new System.Drawing.Size(35, 13);
            this.lblstory.TabIndex = 3;
            this.lblstory.Text = "label1";
            // 
            // frmLabStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 647);
            this.Controls.Add(this.lblstory);
            this.Controls.Add(this.txtchapter);
            this.Controls.Add(this.picmap);
            this.Controls.Add(this.btnclose);
            this.Name = "frmLabStory";
            this.Text = "LabStory";
            this.Load += new System.EventHandler(this.frmLabStory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picmap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox picmap;
        private System.Windows.Forms.TextBox txtchapter;
        private System.Windows.Forms.Label lblstory;
    }
}