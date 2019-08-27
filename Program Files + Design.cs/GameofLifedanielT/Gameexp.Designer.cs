namespace GameofLifedanielTextend
{
    
    partial class frmGameOfLifeex
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
            this.btnrun = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnmanuel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnfill = new System.Windows.Forms.Button();
            this.btnkill = new System.Windows.Forms.Button();
            this.btnsize = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.txtwidth = new System.Windows.Forms.TextBox();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnrestart = new System.Windows.Forms.Button();
            this.labgen = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Label();
            this.btnzuruck = new System.Windows.Forms.Button();
            this.btnKross = new System.Windows.Forms.Button();
            this.btnresult = new System.Windows.Forms.Button();
            this.lblred = new System.Windows.Forms.Label();
            this.lblblue = new System.Windows.Forms.Label();
            this.lblwinner = new System.Windows.Forms.Label();
            this.btncorss2 = new System.Windows.Forms.Button();
            this.btncolorchange = new System.Windows.Forms.Button();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblpurple = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.btnWallfall = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnrun
            // 
            this.btnrun.Enabled = false;
            this.btnrun.Location = new System.Drawing.Point(1020, 192);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(135, 44);
            this.btnrun.TabIndex = 0;
            this.btnrun.Text = "Run";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click_1);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(1020, 242);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(135, 44);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnmanuel
            // 
            this.btnmanuel.Enabled = false;
            this.btnmanuel.Location = new System.Drawing.Point(1188, 182);
            this.btnmanuel.Name = "btnmanuel";
            this.btnmanuel.Size = new System.Drawing.Size(111, 44);
            this.btnmanuel.TabIndex = 9;
            this.btnmanuel.Text = "Manuel";
            this.btnmanuel.UseVisualStyleBackColor = true;
            this.btnmanuel.Click += new System.EventHandler(this.btnmanuel_Click);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Enabled = false;
            this.btnclear.Location = new System.Drawing.Point(1188, 232);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 44);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnfill
            // 
            this.btnfill.Enabled = false;
            this.btnfill.Location = new System.Drawing.Point(1020, 292);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(135, 44);
            this.btnfill.TabIndex = 10;
            this.btnfill.Text = "Fill";
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click_1);
            // 
            // btnkill
            // 
            this.btnkill.Enabled = false;
            this.btnkill.Location = new System.Drawing.Point(1188, 282);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(111, 44);
            this.btnkill.TabIndex = 12;
            this.btnkill.Text = "Kill";
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click_1);
            // 
            // btnsize
            // 
            this.btnsize.Location = new System.Drawing.Point(1020, 140);
            this.btnsize.Name = "btnsize";
            this.btnsize.Size = new System.Drawing.Size(135, 46);
            this.btnsize.TabIndex = 3;
            this.btnsize.Text = "Size";
            this.btnsize.UseVisualStyleBackColor = true;
            this.btnsize.Click += new System.EventHandler(this.btnsize_Click_1);
            // 
            // panMain
            // 
            this.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(12, 12);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(701, 594);
            this.panMain.TabIndex = 8;
            // 
            // txtwidth
            // 
            this.txtwidth.Location = new System.Drawing.Point(1020, 99);
            this.txtwidth.Name = "txtwidth";
            this.txtwidth.Size = new System.Drawing.Size(172, 20);
            this.txtwidth.TabIndex = 4;
            this.txtwidth.TextChanged += new System.EventHandler(this.txtwidth_TextChanged_1);
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(1020, 72);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(172, 20);
            this.txtheight.TabIndex = 5;
            this.txtheight.TextChanged += new System.EventHandler(this.txtheight_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1206, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "MaxColumns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1206, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MaxRows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1020, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bitte geben sie in den beiden Textboxen nur Zahlen ein";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(1188, 130);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(111, 46);
            this.btnrestart.TabIndex = 13;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // labgen
            // 
            this.labgen.AutoSize = true;
            this.labgen.Location = new System.Drawing.Point(1082, 124);
            this.labgen.Name = "labgen";
            this.labgen.Size = new System.Drawing.Size(13, 13);
            this.labgen.TabIndex = 14;
            this.labgen.Text = "0";
            // 
            // Generation
            // 
            this.Generation.AutoSize = true;
            this.Generation.Location = new System.Drawing.Point(1017, 122);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(59, 13);
            this.Generation.TabIndex = 15;
            this.Generation.Text = "Generation";
            this.Generation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnzuruck
            // 
            this.btnzuruck.Location = new System.Drawing.Point(1292, 33);
            this.btnzuruck.Name = "btnzuruck";
            this.btnzuruck.Size = new System.Drawing.Size(75, 23);
            this.btnzuruck.TabIndex = 16;
            this.btnzuruck.Text = "Zurück";
            this.btnzuruck.UseVisualStyleBackColor = true;
            this.btnzuruck.Click += new System.EventHandler(this.btnzuruck_Click);
            // 
            // btnKross
            // 
            this.btnKross.Enabled = false;
            this.btnKross.Location = new System.Drawing.Point(1188, 383);
            this.btnKross.Name = "btnKross";
            this.btnKross.Size = new System.Drawing.Size(111, 44);
            this.btnKross.TabIndex = 17;
            this.btnKross.Text = "Cross after Run";
            this.btnKross.UseVisualStyleBackColor = true;
            this.btnKross.Click += new System.EventHandler(this.btnKross_Click);
            // 
            // btnresult
            // 
            this.btnresult.Location = new System.Drawing.Point(1020, 343);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(135, 33);
            this.btnresult.TabIndex = 18;
            this.btnresult.Text = "Results";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // lblred
            // 
            this.lblred.AutoSize = true;
            this.lblred.Location = new System.Drawing.Point(1027, 409);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(0, 13);
            this.lblred.TabIndex = 19;
            // 
            // lblblue
            // 
            this.lblblue.AutoSize = true;
            this.lblblue.Location = new System.Drawing.Point(1096, 409);
            this.lblblue.Name = "lblblue";
            this.lblblue.Size = new System.Drawing.Size(0, 13);
            this.lblblue.TabIndex = 20;
            // 
            // lblwinner
            // 
            this.lblwinner.AutoSize = true;
            this.lblwinner.Location = new System.Drawing.Point(1026, 383);
            this.lblwinner.Name = "lblwinner";
            this.lblwinner.Size = new System.Drawing.Size(0, 13);
            this.lblwinner.TabIndex = 21;
            // 
            // btncorss2
            // 
            this.btncorss2.Enabled = false;
            this.btncorss2.Location = new System.Drawing.Point(1188, 332);
            this.btncorss2.Name = "btncorss2";
            this.btncorss2.Size = new System.Drawing.Size(111, 44);
            this.btncorss2.TabIndex = 22;
            this.btncorss2.Text = "Cross before Run";
            this.btncorss2.UseVisualStyleBackColor = true;
            this.btncorss2.Click += new System.EventHandler(this.btncorss2_Click);
            // 
            // btncolorchange
            // 
            this.btncolorchange.Location = new System.Drawing.Point(1188, 433);
            this.btncolorchange.Name = "btncolorchange";
            this.btncolorchange.Size = new System.Drawing.Size(111, 44);
            this.btncolorchange.TabIndex = 23;
            this.btncolorchange.Text = "andere Spieler";
            this.btncolorchange.UseVisualStyleBackColor = true;
            this.btncolorchange.Click += new System.EventHandler(this.btncolorchange_Click);
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(1020, 446);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(0, 13);
            this.lblYellow.TabIndex = 24;
            // 
            // lblpurple
            // 
            this.lblpurple.AutoSize = true;
            this.lblpurple.Location = new System.Drawing.Point(1114, 445);
            this.lblpurple.Name = "lblpurple";
            this.lblpurple.Size = new System.Drawing.Size(0, 13);
            this.lblpurple.TabIndex = 25;
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(1027, 56);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(133, 13);
            this.lblmax.TabIndex = 26;
            this.lblmax.Text = "61 ist Empfohlen Max is 99";
            // 
            // btnWallfall
            // 
            this.btnWallfall.Location = new System.Drawing.Point(1188, 483);
            this.btnWallfall.Name = "btnWallfall";
            this.btnWallfall.Size = new System.Drawing.Size(111, 39);
            this.btnWallfall.TabIndex = 27;
            this.btnWallfall.Text = "Walls Fall";
            this.btnWallfall.UseVisualStyleBackColor = true;
            this.btnWallfall.Click += new System.EventHandler(this.btnWallfall_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmGameOfLifeex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1379, 618);
            this.Controls.Add(this.btnWallfall);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblpurple);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.btncolorchange);
            this.Controls.Add(this.btncorss2);
            this.Controls.Add(this.lblwinner);
            this.Controls.Add(this.lblblue);
            this.Controls.Add(this.lblred);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnKross);
            this.Controls.Add(this.btnzuruck);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.labgen);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.btnkill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfill);
            this.Controls.Add(this.btnmanuel);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtwidth);
            this.Controls.Add(this.btnsize);
            this.Controls.Add(this.btnrun);
            this.Name = "frmGameOfLifeex";
            this.Text = "GameOfLife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnmanuel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnfill;
        private System.Windows.Forms.Button btnkill;
        private System.Windows.Forms.Button btnsize;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.TextBox txtwidth;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Label labgen;
        private System.Windows.Forms.Label Generation;
        private System.Windows.Forms.Button btnzuruck;
        private System.Windows.Forms.Button btnKross;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.Label lblblue;
        private System.Windows.Forms.Label lblwinner;
        private System.Windows.Forms.Button btncorss2;
        private System.Windows.Forms.Button btncolorchange;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblpurple;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Button btnWallfall;
        private System.Windows.Forms.Timer timer2;
    }
}

