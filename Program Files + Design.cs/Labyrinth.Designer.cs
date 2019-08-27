namespace GameofLifedanielT
{
    partial class Labyrinth
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
            this.btnlvlone = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.lblLife = new System.Windows.Forms.Label();
            this.lbllifeCount = new System.Windows.Forms.Label();
            this.lblArmorCount = new System.Windows.Forms.Label();
            this.lblbombs = new System.Windows.Forms.Label();
            this.lblBombCount = new System.Windows.Forms.Label();
            this.lblkey = new System.Windows.Forms.Label();
            this.lblkeycount = new System.Windows.Forms.Label();
            this.txttip = new System.Windows.Forms.TextBox();
            this.lblMenge = new System.Windows.Forms.Label();
            this.btnlv2 = new System.Windows.Forms.Button();
            this.lstinve = new System.Windows.Forms.ListBox();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblsword = new System.Windows.Forms.Label();
            this.txtboxLife = new System.Windows.Forms.TextBox();
            this.btnlvl3 = new System.Windows.Forms.Button();
            this.btnlvl4 = new System.Windows.Forms.Button();
            this.btnlvl5 = new System.Windows.Forms.Button();
            this.btnlvl6 = new System.Windows.Forms.Button();
            this.btnlvl7 = new System.Windows.Forms.Button();
            this.btnlvl8 = new System.Windows.Forms.Button();
            this.btnlvl9 = new System.Windows.Forms.Button();
            this.btnlvl10 = new System.Windows.Forms.Button();
            this.lblgold = new System.Windows.Forms.Label();
            this.txtdialog = new System.Windows.Forms.TextBox();
            this.btnheal = new System.Windows.Forms.Button();
            this.panChap1 = new System.Windows.Forms.Panel();
            this.btncha1 = new System.Windows.Forms.Button();
            this.btncha2 = new System.Windows.Forms.Button();
            this.lblchapter = new System.Windows.Forms.Label();
            this.panunkown = new System.Windows.Forms.Panel();
            this.txtmana = new System.Windows.Forms.TextBox();
            this.btnschild = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLore = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblrespawn = new System.Windows.Forms.Label();
            this.btnlvl0 = new System.Windows.Forms.Button();
            this.picheart = new System.Windows.Forms.PictureBox();
            this.picSchi = new System.Windows.Forms.PictureBox();
            this.picnpc = new System.Windows.Forms.PictureBox();
            this.picchar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panChap1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picheart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnpc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picchar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1469, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 0;
            this.btnback.TabStop = false;
            this.btnback.Text = "Zurück";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnlvlone
            // 
            this.btnlvlone.Location = new System.Drawing.Point(3, 15);
            this.btnlvlone.Name = "btnlvlone";
            this.btnlvlone.Size = new System.Drawing.Size(75, 23);
            this.btnlvlone.TabIndex = 1;
            this.btnlvlone.TabStop = false;
            this.btnlvlone.Text = "Level1";
            this.btnlvlone.UseVisualStyleBackColor = true;
            this.btnlvlone.Click += new System.EventHandler(this.btnlvlone_Click);
            // 
            // panMain
            // 
            this.panMain.AutoScroll = true;
            this.panMain.AutoSize = true;
            this.panMain.Location = new System.Drawing.Point(26, 12);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(563, 883);
            this.panMain.TabIndex = 2;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblLife.Location = new System.Drawing.Point(952, 2);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(78, 31);
            this.lblLife.TabIndex = 3;
            this.lblLife.Text = "Lives";
            // 
            // lbllifeCount
            // 
            this.lbllifeCount.AutoSize = true;
            this.lbllifeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbllifeCount.Location = new System.Drawing.Point(1054, 645);
            this.lbllifeCount.Name = "lbllifeCount";
            this.lbllifeCount.Size = new System.Drawing.Size(0, 31);
            this.lbllifeCount.TabIndex = 4;
            this.lbllifeCount.Visible = false;
            // 
            // lblArmorCount
            // 
            this.lblArmorCount.AutoSize = true;
            this.lblArmorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblArmorCount.Location = new System.Drawing.Point(1287, 434);
            this.lblArmorCount.Name = "lblArmorCount";
            this.lblArmorCount.Size = new System.Drawing.Size(87, 31);
            this.lblArmorCount.TabIndex = 6;
            this.lblArmorCount.Text = "Armor";
            this.lblArmorCount.Visible = false;
            // 
            // lblbombs
            // 
            this.lblbombs.AutoSize = true;
            this.lblbombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblbombs.Location = new System.Drawing.Point(1043, 645);
            this.lblbombs.Name = "lblbombs";
            this.lblbombs.Size = new System.Drawing.Size(98, 31);
            this.lblbombs.TabIndex = 7;
            this.lblbombs.Text = "Bombs";
            this.lblbombs.Visible = false;
            // 
            // lblBombCount
            // 
            this.lblBombCount.AutoSize = true;
            this.lblBombCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblBombCount.Location = new System.Drawing.Point(1088, 329);
            this.lblBombCount.Name = "lblBombCount";
            this.lblBombCount.Size = new System.Drawing.Size(0, 31);
            this.lblBombCount.TabIndex = 8;
            this.lblBombCount.Visible = false;
            // 
            // lblkey
            // 
            this.lblkey.AutoSize = true;
            this.lblkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblkey.Location = new System.Drawing.Point(1138, 645);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(75, 31);
            this.lblkey.TabIndex = 9;
            this.lblkey.Text = "Keys";
            this.lblkey.Visible = false;
            // 
            // lblkeycount
            // 
            this.lblkeycount.AutoSize = true;
            this.lblkeycount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblkeycount.Location = new System.Drawing.Point(1087, 659);
            this.lblkeycount.Name = "lblkeycount";
            this.lblkeycount.Size = new System.Drawing.Size(0, 31);
            this.lblkeycount.TabIndex = 10;
            this.lblkeycount.Visible = false;
            // 
            // txttip
            // 
            this.txttip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttip.Location = new System.Drawing.Point(1204, 490);
            this.txttip.Multiline = true;
            this.txttip.Name = "txttip";
            this.txttip.ReadOnly = true;
            this.txttip.Size = new System.Drawing.Size(262, 182);
            this.txttip.TabIndex = 11;
            // 
            // lblMenge
            // 
            this.lblMenge.AutoSize = true;
            this.lblMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMenge.Location = new System.Drawing.Point(1017, 690);
            this.lblMenge.Name = "lblMenge";
            this.lblMenge.Size = new System.Drawing.Size(24, 25);
            this.lblMenge.TabIndex = 13;
            this.lblMenge.Text = "0";
            // 
            // btnlv2
            // 
            this.btnlv2.Location = new System.Drawing.Point(3, 44);
            this.btnlv2.Name = "btnlv2";
            this.btnlv2.Size = new System.Drawing.Size(75, 23);
            this.btnlv2.TabIndex = 15;
            this.btnlv2.TabStop = false;
            this.btnlv2.Text = "Level2";
            this.btnlv2.UseVisualStyleBackColor = true;
            this.btnlv2.Click += new System.EventHandler(this.btnlv2_Click);
            // 
            // lstinve
            // 
            this.lstinve.FormattingEnabled = true;
            this.lstinve.Location = new System.Drawing.Point(955, 490);
            this.lstinve.Name = "lstinve";
            this.lstinve.Size = new System.Drawing.Size(243, 186);
            this.lstinve.TabIndex = 16;
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.BackColor = System.Drawing.Color.Silver;
            this.lblArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.Location = new System.Drawing.Point(1033, 256);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(13, 13);
            this.lblArmor.TabIndex = 5;
            this.lblArmor.Text = "0";
            this.lblArmor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArmor.Click += new System.EventHandler(this.lblArmor_Click);
            // 
            // lblsword
            // 
            this.lblsword.AutoSize = true;
            this.lblsword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblsword.Location = new System.Drawing.Point(1094, 596);
            this.lblsword.Name = "lblsword";
            this.lblsword.Size = new System.Drawing.Size(91, 31);
            this.lblsword.TabIndex = 17;
            this.lblsword.Text = "Sword";
            this.lblsword.Visible = false;
            // 
            // txtboxLife
            // 
            this.txtboxLife.BackColor = System.Drawing.Color.Red;
            this.txtboxLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtboxLife.Location = new System.Drawing.Point(1036, 12);
            this.txtboxLife.Name = "txtboxLife";
            this.txtboxLife.ReadOnly = true;
            this.txtboxLife.Size = new System.Drawing.Size(20, 21);
            this.txtboxLife.TabIndex = 18;
            this.txtboxLife.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlvl3
            // 
            this.btnlvl3.Location = new System.Drawing.Point(3, 73);
            this.btnlvl3.Name = "btnlvl3";
            this.btnlvl3.Size = new System.Drawing.Size(75, 23);
            this.btnlvl3.TabIndex = 19;
            this.btnlvl3.TabStop = false;
            this.btnlvl3.Text = "Level3";
            this.btnlvl3.UseVisualStyleBackColor = true;
            this.btnlvl3.Click += new System.EventHandler(this.btnlvl3_Click);
            // 
            // btnlvl4
            // 
            this.btnlvl4.Location = new System.Drawing.Point(3, 102);
            this.btnlvl4.Name = "btnlvl4";
            this.btnlvl4.Size = new System.Drawing.Size(75, 23);
            this.btnlvl4.TabIndex = 20;
            this.btnlvl4.TabStop = false;
            this.btnlvl4.Text = "Level4";
            this.btnlvl4.UseVisualStyleBackColor = true;
            this.btnlvl4.Click += new System.EventHandler(this.btnlvl4_Click);
            // 
            // btnlvl5
            // 
            this.btnlvl5.Location = new System.Drawing.Point(3, 131);
            this.btnlvl5.Name = "btnlvl5";
            this.btnlvl5.Size = new System.Drawing.Size(75, 23);
            this.btnlvl5.TabIndex = 21;
            this.btnlvl5.TabStop = false;
            this.btnlvl5.Text = "Level5";
            this.btnlvl5.UseVisualStyleBackColor = true;
            this.btnlvl5.Click += new System.EventHandler(this.btnlvl5_Click);
            // 
            // btnlvl6
            // 
            this.btnlvl6.Location = new System.Drawing.Point(84, 15);
            this.btnlvl6.Name = "btnlvl6";
            this.btnlvl6.Size = new System.Drawing.Size(75, 23);
            this.btnlvl6.TabIndex = 22;
            this.btnlvl6.TabStop = false;
            this.btnlvl6.Text = "Level6";
            this.btnlvl6.UseVisualStyleBackColor = true;
            this.btnlvl6.Click += new System.EventHandler(this.btnlvl6_Click);
            // 
            // btnlvl7
            // 
            this.btnlvl7.Location = new System.Drawing.Point(84, 44);
            this.btnlvl7.Name = "btnlvl7";
            this.btnlvl7.Size = new System.Drawing.Size(75, 23);
            this.btnlvl7.TabIndex = 23;
            this.btnlvl7.TabStop = false;
            this.btnlvl7.Text = "Level7";
            this.btnlvl7.UseVisualStyleBackColor = true;
            this.btnlvl7.Click += new System.EventHandler(this.btnlvl7_Click);
            // 
            // btnlvl8
            // 
            this.btnlvl8.Location = new System.Drawing.Point(84, 73);
            this.btnlvl8.Name = "btnlvl8";
            this.btnlvl8.Size = new System.Drawing.Size(75, 23);
            this.btnlvl8.TabIndex = 24;
            this.btnlvl8.TabStop = false;
            this.btnlvl8.Text = "Level8";
            this.btnlvl8.UseVisualStyleBackColor = true;
            this.btnlvl8.Click += new System.EventHandler(this.btnlvl8_Click);
            // 
            // btnlvl9
            // 
            this.btnlvl9.Location = new System.Drawing.Point(84, 102);
            this.btnlvl9.Name = "btnlvl9";
            this.btnlvl9.Size = new System.Drawing.Size(75, 23);
            this.btnlvl9.TabIndex = 25;
            this.btnlvl9.TabStop = false;
            this.btnlvl9.Text = "Level9";
            this.btnlvl9.UseVisualStyleBackColor = true;
            this.btnlvl9.Click += new System.EventHandler(this.btnlvl9_Click);
            // 
            // btnlvl10
            // 
            this.btnlvl10.Location = new System.Drawing.Point(84, 131);
            this.btnlvl10.Name = "btnlvl10";
            this.btnlvl10.Size = new System.Drawing.Size(75, 23);
            this.btnlvl10.TabIndex = 26;
            this.btnlvl10.TabStop = false;
            this.btnlvl10.Text = "Level10";
            this.btnlvl10.UseVisualStyleBackColor = true;
            this.btnlvl10.Click += new System.EventHandler(this.btnlvl10_Click);
            // 
            // lblgold
            // 
            this.lblgold.AutoSize = true;
            this.lblgold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblgold.Location = new System.Drawing.Point(1277, 437);
            this.lblgold.Name = "lblgold";
            this.lblgold.Size = new System.Drawing.Size(57, 25);
            this.lblgold.TabIndex = 12;
            this.lblgold.Text = "Gold";
            this.lblgold.Visible = false;
            // 
            // txtdialog
            // 
            this.txtdialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdialog.Location = new System.Drawing.Point(955, 300);
            this.txtdialog.Multiline = true;
            this.txtdialog.Name = "txtdialog";
            this.txtdialog.ReadOnly = true;
            this.txtdialog.Size = new System.Drawing.Size(511, 184);
            this.txtdialog.TabIndex = 30;
            // 
            // btnheal
            // 
            this.btnheal.Location = new System.Drawing.Point(955, 713);
            this.btnheal.Name = "btnheal";
            this.btnheal.Size = new System.Drawing.Size(75, 56);
            this.btnheal.TabIndex = 31;
            this.btnheal.TabStop = false;
            this.btnheal.Text = "Heal Potion benutzen";
            this.btnheal.UseVisualStyleBackColor = true;
            this.btnheal.Click += new System.EventHandler(this.btnheal_Click);
            // 
            // panChap1
            // 
            this.panChap1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panChap1.Controls.Add(this.btncha1);
            this.panChap1.Controls.Add(this.btncha2);
            this.panChap1.Controls.Add(this.btnlvlone);
            this.panChap1.Controls.Add(this.btnlv2);
            this.panChap1.Controls.Add(this.btnlvl3);
            this.panChap1.Controls.Add(this.btnlvl4);
            this.panChap1.Controls.Add(this.btnlvl5);
            this.panChap1.Controls.Add(this.btnlvl6);
            this.panChap1.Controls.Add(this.btnlvl10);
            this.panChap1.Controls.Add(this.btnlvl7);
            this.panChap1.Controls.Add(this.btnlvl9);
            this.panChap1.Controls.Add(this.btnlvl8);
            this.panChap1.Location = new System.Drawing.Point(1282, 59);
            this.panChap1.Name = "panChap1";
            this.panChap1.Size = new System.Drawing.Size(169, 210);
            this.panChap1.TabIndex = 32;
            // 
            // btncha1
            // 
            this.btncha1.Location = new System.Drawing.Point(3, 184);
            this.btncha1.Name = "btncha1";
            this.btncha1.Size = new System.Drawing.Size(75, 23);
            this.btncha1.TabIndex = 28;
            this.btncha1.Text = "Chapter 1";
            this.btncha1.UseVisualStyleBackColor = true;
            // 
            // btncha2
            // 
            this.btncha2.Location = new System.Drawing.Point(84, 184);
            this.btncha2.Name = "btncha2";
            this.btncha2.Size = new System.Drawing.Size(75, 23);
            this.btncha2.TabIndex = 27;
            this.btncha2.Text = "Chapter 2";
            this.btncha2.UseVisualStyleBackColor = true;
            // 
            // lblchapter
            // 
            this.lblchapter.AutoSize = true;
            this.lblchapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchapter.Location = new System.Drawing.Point(1282, 42);
            this.lblchapter.Name = "lblchapter";
            this.lblchapter.Size = new System.Drawing.Size(92, 16);
            this.lblchapter.TabIndex = 33;
            this.lblchapter.Text = "Chapter one";
            this.lblchapter.Click += new System.EventHandler(this.lblchapter_Click);
            // 
            // panunkown
            // 
            this.panunkown.Location = new System.Drawing.Point(26, 901);
            this.panunkown.Name = "panunkown";
            this.panunkown.Size = new System.Drawing.Size(563, 66);
            this.panunkown.TabIndex = 34;
            // 
            // txtmana
            // 
            this.txtmana.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtmana.Location = new System.Drawing.Point(958, 246);
            this.txtmana.Multiline = true;
            this.txtmana.Name = "txtmana";
            this.txtmana.ReadOnly = true;
            this.txtmana.Size = new System.Drawing.Size(60, 31);
            this.txtmana.TabIndex = 35;
            this.txtmana.Text = "0/0";
            this.txtmana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnschild
            // 
            this.btnschild.Location = new System.Drawing.Point(1036, 713);
            this.btnschild.Name = "btnschild";
            this.btnschild.Size = new System.Drawing.Size(96, 56);
            this.btnschild.TabIndex = 36;
            this.btnschild.TabStop = false;
            this.btnschild.Text = "Rüstung Verstärker benutzen";
            this.btnschild.UseVisualStyleBackColor = true;
            this.btnschild.Click += new System.EventHandler(this.btnschild_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1138, 713);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 56);
            this.button2.TabIndex = 37;
            this.button2.TabStop = false;
            this.button2.Text = "Schleifstein benutzen (Noch nicht)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLore
            // 
            this.btnLore.Location = new System.Drawing.Point(1469, 42);
            this.btnLore.Name = "btnLore";
            this.btnLore.Size = new System.Drawing.Size(75, 23);
            this.btnLore.TabIndex = 38;
            this.btnLore.Text = "Hilfe/Lore";
            this.btnLore.UseVisualStyleBackColor = true;
            this.btnLore.Click += new System.EventHandler(this.btnLore_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Location = new System.Drawing.Point(1227, 713);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(247, 52);
            this.lblsearch.TabIndex = 39;
            this.lblsearch.Text = "Nach Gift suchen. Kosten 50 Gold. \r\nEntweder leertaste oder 0 auf Numberpad klick" +
    "en, \r\nkann auch verwendet werden ohne geld dann \r\ndeckt es aber nur Nachbar Feld" +
    "er auf";
            // 
            // lblrespawn
            // 
            this.lblrespawn.AutoSize = true;
            this.lblrespawn.BackColor = System.Drawing.Color.Red;
            this.lblrespawn.Location = new System.Drawing.Point(1090, 264);
            this.lblrespawn.Name = "lblrespawn";
            this.lblrespawn.Size = new System.Drawing.Size(13, 13);
            this.lblrespawn.TabIndex = 42;
            this.lblrespawn.Text = "0";
            // 
            // btnlvl0
            // 
            this.btnlvl0.Enabled = false;
            this.btnlvl0.Location = new System.Drawing.Point(1469, 74);
            this.btnlvl0.Name = "btnlvl0";
            this.btnlvl0.Size = new System.Drawing.Size(75, 23);
            this.btnlvl0.TabIndex = 43;
            this.btnlvl0.Text = "Testmap";
            this.btnlvl0.UseVisualStyleBackColor = true;
            this.btnlvl0.Visible = false;
            this.btnlvl0.Click += new System.EventHandler(this.btnlvl0_Click);
            // 
            // picheart
            // 
            this.picheart.BackgroundImage = global::GameofLifedanielT.Properties.Resources.Herz;
            this.picheart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picheart.Location = new System.Drawing.Point(1078, 243);
            this.picheart.Name = "picheart";
            this.picheart.Size = new System.Drawing.Size(63, 51);
            this.picheart.TabIndex = 41;
            this.picheart.TabStop = false;
            // 
            // picSchi
            // 
            this.picSchi.BackColor = System.Drawing.Color.Transparent;
            this.picSchi.BackgroundImage = global::GameofLifedanielT.Properties.Resources.Schield;
            this.picSchi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSchi.Location = new System.Drawing.Point(1022, 243);
            this.picSchi.Name = "picSchi";
            this.picSchi.Size = new System.Drawing.Size(50, 51);
            this.picSchi.TabIndex = 40;
            this.picSchi.TabStop = false;
            // 
            // picnpc
            // 
            this.picnpc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picnpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picnpc.Location = new System.Drawing.Point(1119, 59);
            this.picnpc.Name = "picnpc";
            this.picnpc.Size = new System.Drawing.Size(157, 181);
            this.picnpc.TabIndex = 29;
            this.picnpc.TabStop = false;
            // 
            // picchar
            // 
            this.picchar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picchar.Location = new System.Drawing.Point(955, 59);
            this.picchar.Name = "picchar";
            this.picchar.Size = new System.Drawing.Size(158, 181);
            this.picchar.TabIndex = 28;
            this.picchar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameofLifedanielT.Properties.Resources.Money;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(955, 682);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 33);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Labyrinth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2104, 903);
            this.Controls.Add(this.btnlvl0);
            this.Controls.Add(this.lblrespawn);
            this.Controls.Add(this.picheart);
            this.Controls.Add(this.lblArmor);
            this.Controls.Add(this.picSchi);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnLore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnschild);
            this.Controls.Add(this.txtmana);
            this.Controls.Add(this.panunkown);
            this.Controls.Add(this.lblchapter);
            this.Controls.Add(this.panChap1);
            this.Controls.Add(this.btnheal);
            this.Controls.Add(this.txtdialog);
            this.Controls.Add(this.picnpc);
            this.Controls.Add(this.picchar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtboxLife);
            this.Controls.Add(this.lblsword);
            this.Controls.Add(this.lblArmorCount);
            this.Controls.Add(this.lstinve);
            this.Controls.Add(this.lblMenge);
            this.Controls.Add(this.lblgold);
            this.Controls.Add(this.txttip);
            this.Controls.Add(this.lblkeycount);
            this.Controls.Add(this.lblkey);
            this.Controls.Add(this.lblBombCount);
            this.Controls.Add(this.lblbombs);
            this.Controls.Add(this.lbllifeCount);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.btnback);
            this.KeyPreview = true;
            this.Name = "Labyrinth";
            this.Text = "World of Wercevall";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Labyrinth_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Labyrinth_KeyPress);
            this.panChap1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picheart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnpc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picchar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnlvlone;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lbllifeCount;
        private System.Windows.Forms.Label lblArmorCount;
        private System.Windows.Forms.Label lblbombs;
        private System.Windows.Forms.Label lblBombCount;
        private System.Windows.Forms.Label lblkey;
        private System.Windows.Forms.Label lblkeycount;
        private System.Windows.Forms.TextBox txttip;
        private System.Windows.Forms.Label lblgold;
        private System.Windows.Forms.Label lblMenge;
        private System.Windows.Forms.Button btnlv2;
        private System.Windows.Forms.ListBox lstinve;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblsword;
        private System.Windows.Forms.TextBox txtboxLife;
        private System.Windows.Forms.Button btnlvl3;
        private System.Windows.Forms.Button btnlvl4;
        private System.Windows.Forms.Button btnlvl5;
        private System.Windows.Forms.Button btnlvl6;
        private System.Windows.Forms.Button btnlvl7;
        private System.Windows.Forms.Button btnlvl8;
        private System.Windows.Forms.Button btnlvl9;
        private System.Windows.Forms.Button btnlvl10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picchar;
        private System.Windows.Forms.PictureBox picnpc;
        private System.Windows.Forms.TextBox txtdialog;
        private System.Windows.Forms.Button btnheal;
        private System.Windows.Forms.Panel panChap1;
        private System.Windows.Forms.Label lblchapter;
        private System.Windows.Forms.Panel panunkown;
        private System.Windows.Forms.TextBox txtmana;
        private System.Windows.Forms.Button btnschild;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btncha1;
        private System.Windows.Forms.Button btncha2;
        private System.Windows.Forms.Button btnLore;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.PictureBox picSchi;
        private System.Windows.Forms.PictureBox picheart;
        private System.Windows.Forms.Label lblrespawn;
        private System.Windows.Forms.Button btnlvl0;
    }
}