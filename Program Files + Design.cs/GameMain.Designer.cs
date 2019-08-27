namespace GameofLifedanielT
{
    partial class frmGameOfLife
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOfLife));
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
            this.Labeldesc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnrestart = new System.Windows.Forms.Button();
            this.grpbtn = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnreturn = new System.Windows.Forms.Button();
            this.grpbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrun
            // 
            this.btnrun.Enabled = false;
            this.btnrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.Location = new System.Drawing.Point(6, 162);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(126, 44);
            this.btnrun.TabIndex = 0;
            this.btnrun.Text = "Run";
            this.toolTip1.SetToolTip(this.btnrun, "Die Lebenzyklen beginnen");
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click_1);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(180, 162);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(126, 44);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.toolTip1.SetToolTip(this.btnstop, "Die Lebenszyklen weden angehalten");
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnmanuel
            // 
            this.btnmanuel.Enabled = false;
            this.btnmanuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanuel.Location = new System.Drawing.Point(6, 212);
            this.btnmanuel.Name = "btnmanuel";
            this.btnmanuel.Size = new System.Drawing.Size(126, 44);
            this.btnmanuel.TabIndex = 9;
            this.btnmanuel.Text = "Manuel";
            this.toolTip1.SetToolTip(this.btnmanuel, "Geht über eine Lebenzykle");
            this.btnmanuel.UseVisualStyleBackColor = true;
            this.btnmanuel.Click += new System.EventHandler(this.btnmanuel_Click);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Enabled = false;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(180, 212);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 44);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnclear, "Setzt alle Felder auf Unbewohnt");
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnfill
            // 
            this.btnfill.Enabled = false;
            this.btnfill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfill.Location = new System.Drawing.Point(6, 262);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(126, 44);
            this.btnfill.TabIndex = 10;
            this.btnfill.Text = "Fill";
            this.toolTip1.SetToolTip(this.btnfill, "Setzt alle Felder auf Lebend");
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click_1);
            // 
            // btnkill
            // 
            this.btnkill.Enabled = false;
            this.btnkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkill.Location = new System.Drawing.Point(180, 262);
            this.btnkill.Name = "btnkill";
            this.btnkill.Size = new System.Drawing.Size(126, 44);
            this.btnkill.TabIndex = 12;
            this.btnkill.Text = "Kill";
            this.toolTip1.SetToolTip(this.btnkill, "Töted alle lebene Zellen");
            this.btnkill.UseVisualStyleBackColor = true;
            this.btnkill.Click += new System.EventHandler(this.btnkill_Click_1);
            // 
            // btnsize
            // 
            this.btnsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsize.Location = new System.Drawing.Point(6, 112);
            this.btnsize.Name = "btnsize";
            this.btnsize.Size = new System.Drawing.Size(126, 44);
            this.btnsize.TabIndex = 3;
            this.btnsize.Text = "Size";
            this.toolTip1.SetToolTip(this.btnsize, "Started den Generierungprozess dess Spielfelds");
            this.btnsize.UseVisualStyleBackColor = true;
            this.btnsize.Click += new System.EventHandler(this.btnsize_Click_1);
            // 
            // panMain
            // 
            this.panMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Location = new System.Drawing.Point(22, 22);
            this.panMain.Name = "panMain";
            this.panMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panMain.Size = new System.Drawing.Size(512, 363);
            this.panMain.TabIndex = 8;
            // 
            // txtwidth
            // 
            this.txtwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.txtwidth, "");
            this.txtwidth.Location = new System.Drawing.Point(68, 54);
            this.txtwidth.Name = "txtwidth";
            this.helpProvider1.SetShowHelp(this.txtwidth, true);
            this.txtwidth.Size = new System.Drawing.Size(165, 20);
            this.txtwidth.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtwidth, "Setzte deine Anzahl von Reihen die du willst , Max ist 50 und Min ist 3");
            this.txtwidth.TextChanged += new System.EventHandler(this.txtwidth_TextChanged_1);
            // 
            // txtheight
            // 
            this.txtheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtheight.Location = new System.Drawing.Point(68, 86);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(165, 20);
            this.txtheight.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtheight, "Setzte deine Anzahl von Spalten die du willst , Max ist 50 und Min ist 3");
            this.txtheight.TextChanged += new System.EventHandler(this.txtheight_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rows";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Labeldesc
            // 
            this.Labeldesc.AutoSize = true;
            this.Labeldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeldesc.Location = new System.Drawing.Point(3, 16);
            this.Labeldesc.Name = "Labeldesc";
            this.Labeldesc.Size = new System.Drawing.Size(306, 26);
            this.Labeldesc.TabIndex = 11;
            this.Labeldesc.Text = "Bitte geben sie in den beiden Texboxen nur Zahlen ein und\r\nkeine Zahl über dem Ma" +
    "ximum, das Maximum beträgt 50 mal 50";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnrestart
            // 
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.Location = new System.Drawing.Point(180, 112);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(126, 44);
            this.btnrestart.TabIndex = 13;
            this.btnrestart.Text = "Restart";
            this.toolTip1.SetToolTip(this.btnrestart, "Restarted das Form");
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // grpbtn
            // 
            this.grpbtn.AutoSize = true;
            this.grpbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpbtn.Controls.Add(this.btnrestart);
            this.grpbtn.Controls.Add(this.btnkill);
            this.grpbtn.Controls.Add(this.Labeldesc);
            this.grpbtn.Controls.Add(this.btnfill);
            this.grpbtn.Controls.Add(this.btnmanuel);
            this.grpbtn.Controls.Add(this.btnclear);
            this.grpbtn.Controls.Add(this.btnstop);
            this.grpbtn.Controls.Add(this.label2);
            this.grpbtn.Controls.Add(this.label1);
            this.grpbtn.Controls.Add(this.txtheight);
            this.grpbtn.Controls.Add(this.txtwidth);
            this.grpbtn.Controls.Add(this.btnsize);
            this.grpbtn.Controls.Add(this.btnrun);
            this.grpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbtn.Location = new System.Drawing.Point(551, 22);
            this.grpbtn.Name = "grpbtn";
            this.helpProvider1.SetShowHelp(this.grpbtn, false);
            this.grpbtn.Size = new System.Drawing.Size(315, 363);
            this.grpbtn.TabIndex = 14;
            this.grpbtn.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(901, 22);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(75, 23);
            this.btnreturn.TabIndex = 15;
            this.btnreturn.Text = "Zurück";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // frmGameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(985, 404);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.grpbtn);
            this.Controls.Add(this.panMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameOfLife";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 20);
            this.Text = "GameOfLife";
            this.Load += new System.EventHandler(this.GameOfLife_Load);
            this.grpbtn.ResumeLayout(false);
            this.grpbtn.PerformLayout();
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
        private System.Windows.Forms.Label Labeldesc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.GroupBox grpbtn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnreturn;
    }
}

