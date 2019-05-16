﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
  
    public partial class Labyrinth : Form
    {
        Bitmap Secret = Properties.Resources.Secret;
        Bitmap Bandit = Properties.Resources.Dieb;
        private int _row;
        private int _column;
       
       
        private const int CellSize = 23;
        private const int MaxRows = 40;
        private const int MaxColumns = 40;

        public const int size = 8;


        //   private const int CellSize = 10;
        private static int depth = 6;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Button = "Button";
        private const string Play = "Play";
        Labfunk lab = new Labfunk();
        bool Alive = true;
        public Labyrinth()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }
        PictureBox panel = new PictureBox();
        int MaxLife = 3;
        int Life = 3;
        int Armor = 0;
        int Bombs = 0;
        int sword = 0;
        int Keys = 0;
        int Gold = 0;
        int Tokens = 0;
        bool Gene = false;
        int Lvl = 1;
        private void btnlvlone_Click(object sender, EventArgs e)
        {
            Lvl = 1;
            if (Gene == false)
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                    Gene = true;
                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                Tokens = 0;
                MaxLife = 3;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString()+" / "+MaxLife.ToString();
                sword = 0;
                Gold = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsdicke "+ Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lblkeycount.Text = Keys.ToString();
                lblMenge.Text = Gold.ToString();
                lblsword.Text = sword.ToString();
                panMain.Size = new Size(CellSize * 40, CellSize * 40);
            for (_column = 0; _column < 40; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 40; _row++)// Generiert die Zellen der Reihen
                {
                     panel =lab.GenerateGrid(_row, _column);

                    panel.Click += panel_Click;
                    panMain.Controls.Add(panel);
                }
            }
            foreach (PictureBox panel in panMain.Controls)
            {
                _row = panel.Location.Y / CellSize;
                _column = panel.Location.X / CellSize;
                lab.CreateWorld(panel, _row, _column, Lvl);
            }
            }
            else
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                Tokens = 0;
                MaxLife = 3;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                sword = 0;
                Gold = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
                Alive = true;
                first = true;
            }
        }
        int Rowsd = 0;
        int Columnsd = 0;
        bool first = true;
        private void panel_Click(object sender, EventArgs e)
        {
            if (first==true)
            {

          
            MouseEventArgs me = (MouseEventArgs)e;

            PictureBox panel = ((PictureBox)sender);
            _row = panel.Location.Y / CellSize; 
            _column = panel.Location.X / CellSize;
                if (panel.BackColor== Color.Yellow)
                {
                    Rowsd = _row;
                    Columnsd = _column;
                    lab.Starts(panel, _row, _column);
                    first = false;
                }
         
            }
        }
        bool leverover = true;
        bool trade = false;
        int item = 0;
        int Bitem = 0;
        bool Btrade = true;
        int encounte = 0;
        bool Fight = false;
        bool Payheal = false;
        bool cheat = false;
        private void Labyrinth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Btrade = true;
            if (Alive== true)
            {

           
            if (e.KeyChar == 's')
            {
                
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                      
                        if (Bombs > 0)
                        {
                            item = 3;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                            Bombs = lab.BomU(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU(panMain, panel, _row, _column, Keys);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }
                        if (Tokens > 0)
                        {
                            item = 4;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Gold = Gold + Tokens* 150;
                                Tokens =0;
                             
                                trade = false;
                            }
                           // sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }

                        lab.Down(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl,Gold,Tokens);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc);
                        if (cheat== true)
                        {
                            MaxLife = 3;
                            Life = 3;
                            Armor = 0;
                            sword = 0;
                            Bombs = 0;
                            Gold = Gold + 500;
                            cheat = false;
                        }
                        if (encounte>0)
                        {
                            if (encounte==1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column,Fight, sword, Armor,encounte);
                                if (Fight == true)
                                {
                                    if (sword>0 &&Armor>0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life--;
                                    encounte = 0;
                                }
                            }

                        }
                        if (Gold >= 100&& Btrade == true)
                        {

                            Bitem = lab.Buying(panMain, panel, _row, _column, trade);
                            if (Bitem ==1)
                            {
                                sword++;
                                Gold = Gold - 200;
                                Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 2)
                            {
                                Armor++;
                                Gold = Gold - 250;

                                Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 3)
                            {
                                Keys++;
                                Gold = Gold - 1000;

                                Btrade = false;
                                Bitem = 0;
                            }
                            Payheal = lab.Paheal(panMain, panel, _row, _column, Payheal);
                            if (Payheal == true)
                            {
                                Life= MaxLife;
                                Gold = Gold - 100;
                                Payheal = false;
                            }
                            Gold = lab.goldTri1(panMain, panel, _row, _column, Gold);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                          //  sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }
                        if (Bombs > 0)
                        {
                            item = 3;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                          //  Bombs = lab.BomU(panMain, panel, _row, _column, Bombs);


                        }
                        if (Armor==0)
                        {
                            Life = lab.Poison(panMain, panel, _row, _column, Life);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                         
                        }
                        else if (Armor > 0)
                        {
                            item = 1;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Armor--;
                                Gold = Gold + 150;
                                trade = false;
                            } 
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();

                        }
                    
                    }
                    Rowsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblsword.Text = sword.ToString();
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                          
                            if (Lvl == 2&&leverover == false && _row == 6 && _column == 8)
                            {
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                       
                   
                      
                    }
                    if (Life== 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du bist Tod";
                        lblArmor.Text = "bist";
                        lblbombs.Text = "Tod";
                        lblkey.Text = "";
                        lblArmorCount.Text = "";
                        lblBombCount.Text = "";
                        lbllifeCount.Text = "";
                        lblkeycount.Text = "";
                        lblMenge.Text = "";
                        lblsword.Text = "";
                    }
                
            }
            else if (e.KeyChar == 'w')
            {
                
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        if (Bombs > 0)
                        {
                            item = 3;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                            Bombs = lab.BomU2(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU2(panMain, panel, _row, _column, Keys);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                               trade = lab.Trading(panMain, panel, _row, _column, trade,item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            sword = lab.SworU2(panMain, panel, _row, _column, sword);


                        }
                        if (Tokens > 0)
                        {
                            item = 4;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Gold = Gold + Tokens * 150;
                                Tokens = 0;

                                trade = false;
                            }
                            // sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }

                        lab.Up(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc);
                        if (cheat == true)
                        {
                            MaxLife = 3;
                            Life = 3;
                            Armor = 0;
                            sword = 0;
                            Bombs = 0;
                            Gold = Gold + 500;
                            cheat = false;
                        }
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight,sword,Armor, encounte);
                                if (Fight == true)
                                {
                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life--;
                                    encounte = 0;
                                }
                            }

                        }
                        if (Gold >= 100 && Btrade == true)
                        {
                            Bitem = lab.Buying(panMain, panel, _row, _column, trade);
                            if (Bitem == 1)
                            {
                                sword++;
                                Gold = Gold - 200;
                                 Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 2)
                            {
                                Armor++;
                                Gold = Gold - 250;
                                 Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 3)
                            {
                                Keys++;
                                Gold = Gold - 1000;

                                Btrade = false;
                                Bitem = 0;
                            }
                            Payheal = lab.Paheal(panMain, panel, _row, _column, Payheal);
                            if (Payheal == true)
                            {
                                Life = MaxLife;
                                Gold = Gold - 100;
                                Payheal = false;
                            }
                            Gold = lab.goldTri1(panMain, panel, _row, _column, Gold);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            //sword = lab.SworU2(panMain, panel, _row, _column, sword);


                        }
                        if (Bombs > 0)
                        {
                            item = 3;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                          //  Bombs = lab.BomU2(panMain, panel, _row, _column, Bombs);


                        }
                        if (Armor == 0)
                        {
                            Life = lab.Poison(panMain, panel, _row, _column, Life);

                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                           
                        }
                        else if (Armor > 0)
                        {
                            item = 1;
                               trade = lab.Trading(panMain, panel, _row, _column, trade,item);
                            if (trade == true)
                            {
                                Armor--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                        }
                    }
                    Rowsd--;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblsword.Text = sword.ToString();
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                          
                            if (Lvl == 2&& leverover == false && _row == 6 && _column == 8)
                            {
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                       
                     
                        
                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du bist Tod";
                        lblArmor.Text = "bist";
                        lblbombs.Text = "Tod";
                        lblkey.Text = "";
                        lblArmorCount.Text = "";
                        lblBombCount.Text = "";
                        lbllifeCount.Text = "";
                        lblkeycount.Text = "";
                        lblMenge.Text = "";
                        lblsword.Text = "";
                    }
                }
            else if (e.KeyChar == 'a')
            {
                
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        if (Bombs > 0)
                        {
                            item = 3;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                            Bombs = lab.BomU3(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU3(panMain, panel, _row, _column, Keys);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            sword = lab.SworU3(panMain, panel, _row, _column, sword);


                        }
                        if (Tokens > 0)
                        {
                            item = 4;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Gold = Gold + Tokens * 150;
                                Tokens = 0;

                                trade = false;
                            }
                            // sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }

                        lab.Left(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                       txttip.Text= lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc);
                        if (cheat == true)
                        {
                            MaxLife = 3;
                            Life = 3;
                            Armor = 0;
                            sword = 0;
                            Bombs = 0;
                            Gold = Gold + 500;
                            cheat = false;
                        }
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte);
                                if (Fight == true)
                                {
                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life--;
                                    encounte = 0;
                                }
                            }

                        }
                        if (Gold >= 100 && Btrade == true)
                        {
                            Bitem = lab.Buying(panMain, panel, _row, _column, trade);
                            if (Bitem == 1)
                            {
                                sword++;
                                Gold = Gold - 200;
                                 Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 2)
                            {
                                Armor++;
                                Gold = Gold - 250;
                                Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 3)
                            {
                                Keys++;
                                Gold = Gold - 1000;

                                Btrade = false;
                                Bitem = 0;
                            }
                            Payheal = lab.Paheal(panMain, panel, _row, _column, Payheal);
                            if (Payheal == true)
                            {
                                Life = MaxLife;
                                Gold = Gold - 100;
                                Payheal = false;
                            }
                            Gold = lab.goldTri1(panMain, panel, _row, _column, Gold);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            // sword = lab.SworU3(panMain, panel, _row, _column, sword);


                        }
                        if (Bombs > 0)
                        {
                            item = 3;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                          //  Bombs = lab.BomU3(panMain, panel, _row, _column, Bombs);


                        }
                        if (Armor == 0)
                        {
                        Life = lab.Poison(panMain, panel, _row, _column, Life);
                          
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();

                        }
                        else if (Armor > 0)
                        {
                            item = 1;
                               trade = lab.Trading(panMain, panel, _row, _column, trade,item);
                            if (trade == true)
                            {
                                Armor--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();

                        }
                    }
                    Columnsd--;



                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblsword.Text = sword.ToString();
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Lvl == 2 && leverover == false && _row == 6 && _column == 8)
                            {
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                           
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                   
                       

                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du bist Tod";
                        lblArmor.Text = "bist";
                        lblbombs.Text = "Tod";
                        lblkey.Text = "";
                        lblArmorCount.Text = "";
                        lblBombCount.Text = "";
                        lbllifeCount.Text = "";
                        lblkeycount.Text = "";
                        lblMenge.Text = "";
                        lblsword.Text = "";
                    }
                }
             else if (e.KeyChar == 'd')
            {
               
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        if (Bombs > 0)
                        {
                            item = 3;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                            Bombs = lab.BomU4(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU4(panMain, panel, _row, _column, Keys);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                               trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                            sword = lab.SworU4(panMain, panel, _row, _column, sword);


                        }
                        if (Tokens > 0)
                        {
                            item = 4;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Gold = Gold + Tokens * 150;
                                Tokens = 0;

                                trade = false;
                            }
                            // sword = lab.SworU(panMain, panel, _row, _column, sword);


                        }

                        lab.Right(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs,Keys, sword,Lvl, Gold, Tokens);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc);
                        if (cheat == true)
                        {
                            MaxLife = 3;
                            Life = 3;
                            Armor = 0;
                            sword = 0;
                            Bombs = 0;
                            Gold = Gold + 500;
                            cheat = false;
                        }
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte);
                                if (Fight == true)
                                {
                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;
                                        Tokens++;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life--;
                                    encounte = 0;
                                }
                            }

                        }
                        if (Gold >= 100 && Btrade == true)
                        {
                            Bitem = lab.Buying(panMain, panel, _row, _column, trade);
                            if (Bitem == 1)
                            {
                                sword++;
                                Gold = Gold - 200;
                                Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 2)
                            {
                                Armor++;
                                Gold = Gold - 250;
                                Btrade = false;
                                Bitem = 0;
                            }
                            else if (Bitem == 3)
                            {
                                Keys++;
                                Gold = Gold - 1000;

                                Btrade = false;
                                Bitem = 0;
                            }
                            Payheal = lab.Paheal(panMain, panel, _row, _column, Payheal);
                            if (Payheal == true)
                            {
                                Life = MaxLife;
                                Gold = Gold - 100;
                                Payheal = false;
                            }

                            Gold = lab.goldTri1(panMain, panel, _row, _column, Gold);


                        }
                        if (sword > 0)
                        {
                            item = 2;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                sword--;
                                Gold = Gold + 100;
                                trade = false;
                            }
                           // sword = lab.SworU4(panMain, panel, _row, _column, sword);


                        }
                        if (Bombs > 0)
                        {
                            item = 3;
                            trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            if (trade == true)
                            {
                                Bombs--;
                                Gold = Gold + 200;
                                trade = false;
                            }
                          //  Bombs = lab.BomU4(panMain, panel, _row, _column, Bombs);


                        }
                        if (Armor == 0)
                    {
                        Life = lab.Poison(panMain, panel, _row, _column, Life);
                          
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                        }
                        else if (Armor > 0)
                        {
                            item = 1;
                               trade = lab.Trading(panMain, panel, _row, _column, trade,item);
                            if (trade == true)
                            {
                                Armor--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                        }
                    }
                    Columnsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lblArmorCount.Text = Armor.ToString();
                    lblBombCount.Text = Bombs.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblsword.Text = sword.ToString();
                    if (leverover== false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Lvl == 2 && leverover == false&& _row == 6 &&_column == 8)
                            {

                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;

                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                     
                       
             
                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du bist Tod";
                        lblArmor.Text = "bist";
                        lblbombs.Text = "Tod";
                        lblkey.Text = "";
                        lblArmorCount.Text = "";
                        lblBombCount.Text = "";
                        lbllifeCount.Text = "";
                        lblkeycount.Text = "";
                        lblMenge.Text = "";
                        lblsword.Text = "";
                    }
                }

            }
            else if (Alive == false&& Life != 0)
          
            {

                MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
            }
        }

        private void Labyrinth_Load(object sender, EventArgs e)
        {
            
        }

        private void lblArmor_Click(object sender, EventArgs e)
        {

        }

        private void btnlv2_Click(object sender, EventArgs e)
        {
            Lvl = 2;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor =1;
                MaxLife = 4;
                Bombs = 0;
                Keys = 0;
                sword = 0;
                Gold = 0;
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lblkeycount.Text = Keys.ToString();
                lblMenge.Text = Gold.ToString();
                lblsword.Text = sword.ToString();
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                panMain.Size = new Size(CellSize * 40, CellSize * 40);
                for (_column = 0; _column < 40; _column++)// Generiert die Zellen der Spalten
                {
                    for (_row = 0; _row < 40; _row++)// Generiert die Zellen der Reihen
                    {
                        panel = lab.GenerateGrid(_row, _column);

                        panel.Click += panel_Click;
                        panMain.Controls.Add(panel);
                    }
                }
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
            }
            else
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 1;
                MaxLife = 4;
                Tokens = 0;
                Bombs = 0;
                sword = 0;
                Gold = 0;
                Keys = 0;
                Rowsd = 0;
                Columnsd = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
                Alive = true;
                first = true;
            }
        }

        private void lblsword_Click(object sender, EventArgs e)
        {

        }

        private void btnlvl3_Click(object sender, EventArgs e)
        {
            Lvl = 3;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 1;
                MaxLife = 4;
                Bombs = 1;
                Keys = 0;
                sword = 1;
                Gold = 3000;
                Tokens = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lblkeycount.Text = Keys.ToString();
                lblMenge.Text = Gold.ToString();
                lblsword.Text = sword.ToString();
                panMain.Size = new Size(CellSize * 40, CellSize * 40);
                for (_column = 0; _column < 40; _column++)// Generiert die Zellen der Spalten
                {
                    for (_row = 0; _row < 40; _row++)// Generiert die Zellen der Reihen
                    {
                        panel = lab.GenerateGrid(_row, _column);

                        panel.Click += panel_Click;
                        panMain.Controls.Add(panel);
                    }
                }
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
            }
            else
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 1;
                MaxLife = 4;
                Bombs = 0;
                Gold = 500;
                sword = 0;
                Keys = 0;
                Rowsd = 0;
                Columnsd = 0;
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
                Alive = true;
                first = true;
            }
        }
    }
}
