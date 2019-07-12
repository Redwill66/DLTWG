using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameofLifedanielT.Labfunk;
namespace GameofLifedanielT
{
  
    public partial class Labyrinth : Form

    {
        //Die Bilder für die Encounter werden hier geladen
        #region Bilder

     
        Bitmap Secret = Properties.Resources.Secret;
        Bitmap Bandit = Properties.Resources.Dieb;
        Bitmap BanditC = Properties.Resources.BanditChef;
        Bitmap Soldat = Properties.Resources.Soldat;
        Bitmap EGua = Properties.Resources.Elite_Guard;
        Bitmap Gua = Properties.Resources.Guard_Captain;
        Bitmap Gob = Properties.Resources.Goblin;
        Bitmap Gok = Properties.Resources.Goblin_King;
        Bitmap Dark = Properties.Resources.Dark_Knight;
        #endregion
        // Dies sind die Daten von Grid 
        private int _row;
        private int _column;            
        private const int CellSize = 22;
        private const int MaxRows = 40;
        private const int MaxColumns = 40;
        private static int depth = 6;
        public const int size = 8;
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        //Dieses Static dient dazu das der Spiel ein wenig backstory bekommt, es speichert Level das ausgewählt ist
        public static int Levelstory;
       
        //Die Meisten Funktion sind in LabFunk
        Labfunk lab = new Labfunk();
        //Dient dazu welches Bild für den Avatar benutzt wird
        LabAvatarFunk labAv = new LabAvatarFunk();
        // Nur wenn der Spieler Alive ist kann er etwas machen.
        bool Alive = true;

        public Labyrinth()
        {
            InitializeComponent();
        
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < 40; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 40; _row++)// Generiert die Zellen der Reihen
                {

                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        PictureBox panel = new PictureBox();
        //Die meisten Stats des Charakters
        int MaxLife = 3;
        int Life = 3;
        int Respawn = 3;
        int Armor = 0;
        int Armormat = 0;
        int Bombs = 0;
        int sword = 0;
        int Keys = 0;
        int Gold = 0;
        int Tokens = 0;
        int Potions = 0;
        int Mana = 0;
        int Spellpower = 0;
        bool Gene = false;
        int Lvl = 1;
        private void btnlvlone_Click(object sender, EventArgs e)
        {
            #region Level 1

         
            Lvl = 1;
            Levelstory = Lvl;
            DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story zu Vorgeschichte hören", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmLabStory fnp = new frmLabStory();
                fnp.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
              
            }
      
        btnlvlone.Enabled = false;
            btnlvlone.Enabled = true;
            //Lvl = 1;
            if (Gene == false)
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                    Gene = true;
                txtdialog.Text = "Du machst langsam auf, du hörst dass zwitschern von Vögel, du steht langsam auf, du fragst dich.'Wo bin ich?' Natürlich antwortet dir niemand. Danach fragst du dich 'Wer bin ich?', da natürlich auch keiner auf diese frage Antwortet entscheidest du dich nach einer Zivilisation zu suchen";
                // Die Stats die du am anfang vom Level bekommst
                Life = 3;
                Armor = 0;
                Armormat = 0;
                Bombs = 0;
                Keys = 0;
                Potions = 1;
                Respawn = 3;
                Tokens = 0;
                MaxLife = 3;
                Mana = 0;
                Spellpower = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString()+" / "+MaxLife.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                sword = 0;
                Gold = 100;
                lblrespawn.Text = Respawn.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial "+ Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lblArmor.Text = Armor.ToString();
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
                // Die Stats die du beim neustart vom Level bekommst
                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                Armormat = 0;
                Potions = 1;
                Tokens = 0;
                MaxLife = 3;
                Respawn = 3;
                Mana = 0;
                Spellpower = 0;
                txtdialog.Text = "Du machst langsam auf, du hörst dass zwitschern von Vögel, du steht langsam auf, du fragst dich.'Wo bin ich?' Natürlich antwortet dir niemand. Danach fragst du dich 'Wer bin ich?', da natürlich auch keiner auf diese frage Antwortet entscheidest du dich nach einer Zivilisation zu suchen";

                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                sword = 0;
                Gold = 100;
                lblrespawn.Text = Respawn.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Clear();
                lblArmor.Text = Armor.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
                Alive = true;
                first = true;
            }
            #endregion
        }
        int Rowsd = 0;
        int Columnsd = 0;
        bool first = true;
        private void panel_Click(object sender, EventArgs e)
        {
            #region Start

     
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
            #endregion
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
        bool wait;
        private void Labyrinth_KeyPress(object sender, KeyPressEventArgs e)
        {
         
            Btrade = true;
            if (Alive== true)
            {
                if (e.KeyChar == 's' || e.KeyChar == '2')
                {

                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        #region Use Item

                      
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
                            Bombs = lab.BomU(panMain, panel, _row, _column, Bombs,Lvl);
                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU(panMain, panel, _row, _column, Keys);
                        }
                        if (Mana > 0)
                        {
                            Mana = lab.ManU(panMain, panel, _row, _column, Mana, Lvl);
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
                                Gold = Gold + Tokens * 150;
                                Tokens = 0;
                                trade = false;
                            }
                        }
                        #endregion
                        #region Funktions

                        
                        lab.Down(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens,Mana);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armormat  = lab.Schield(panMain, panel, _row, _column, Armormat);
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
                        Potions = lab.Potions(panMain, panel, _row, _column, Potions);
                        Spellpower = lab.Magic(panMain, panel, _row, _column, Spellpower);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        lab.Event(panMain, panel, _row, _column, Lvl);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc, Lvl);
                        #endregion
                        #region Cheats

                       
                        if (cheat == true)
                        {
                            MaxLife = 3;
                            Life = 3;
                            Armor = 0;
                            sword = 0;
                            Armormat = 0;
                            Bombs = 0;
                            Gold = Gold + 500;
                            cheat = false;
                        }
                        #endregion
                        #region Encounters

                       
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
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
                            else if (encounte == 2)
                            {
                                picnpc.BackgroundImage = BanditC;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else if (sword > 1 && Armor > 0)
                                    {
                                        sword = sword - 2;
                                        Armor--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 3)
                            {
                                picnpc.BackgroundImage = Soldat;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {

                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 4)
                            {
                                picnpc.BackgroundImage = Gua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    if (sword > 1 && Armor > 1)
                                    {
                                        sword = sword - 2;
                                        Armor = Armor - 2;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 2;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 5)
                            {
                                picnpc.BackgroundImage = EGua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (sword > 0 && Armor > 1)
                                    {
                                        sword = sword - 1;
                                        Armor = Armor - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 6)
                            {
                                picnpc.BackgroundImage = Gob;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (sword > 0)
                                    {
                                        sword = sword - 1;

                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {

                                    encounte = 0;
                                }
                            }
                            else if (encounte == 7)
                            {
                                picnpc.BackgroundImage = Gok;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 2 && Armor > 1)
                                    {
                                        sword = sword - 3;
                                        Armor = Armor - 2;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 4;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 8)
                            {
                                picnpc.BackgroundImage = Dark;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs >= 99)
                                    {
                                        Bombs = 0;

                                         Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword >= 99 && Armor >= 99)
                                    {
                                        sword = 0;
                                            Armor = 0;
                                          Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = 0;
                                       

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = 0;
                                    encounte = 0;
                                }
                            }

                        }
                        #endregion
                        #region Trade and Damage

                       
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
                                Armormat++;
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
                        }
                        if (Armor == 0)
                        {
                            if ( Armormat > 0)
                            {
                                item = 1;
                                trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            }
                            if (trade == true && Armormat>0)
                            {
                                Armormat--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Life = lab.Poison(panMain, panel, _row, _column, Life);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
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
                            Life = lab.Electro(panMain, panel, _row, _column, Life, Armor);
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Armor = lab.FireA(panMain, panel, _row, _column, Armor);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();

                        }

                    }
                    #endregion
                    #region UI update

                   
                    Rowsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lstinve.Items.Add("Heiltränke " + Potions.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblArmor.Text = Armor.ToString();
                    lblsword.Text = sword.ToString();
                    txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                    picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                    #endregion
                    #region Level Over

                  


                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;

                            if (Lvl == 2 && leverover == false && _row == 6 && _column == 8)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn =3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 4 && leverover == false && _row == 19 && _column == 38)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 19;
                                _column = 38;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 5 && leverover == false && _row == 3 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 6 && leverover == false && _row == 1 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 1;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 7 && leverover == false && _row == 3 && _column == 7)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 7;
                                Rowsd = _row;
                                Columnsd = _column;
                              lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                            lab.Starts(panel, _row, _column);
                        }
                        


                    }
                    #endregion
                    #region Dead and Respawn

                  
                    if (Life <= 0)
                    { 
                         foreach (PictureBox panel in panMain.Controls)
                            {
                                _row = panel.Location.Y / CellSize;
                                _column = panel.Location.X / CellSize;
                                if (Respawn == 0)
                                {
                                    Alive = false;
                                    lblLife.Text = "Du bist Tod";

                                    lblbombs.Text = "Tod";
                                    lblkey.Text = "";
                                    lblArmorCount.Text = "";
                                    lblBombCount.Text = "";
                                    lbllifeCount.Text = "";
                                    lblkeycount.Text = "";
                                    lblMenge.Text = "";
                                    lblsword.Text = "";
                                    break;
                                }
                                else
                                {
                                  //  Respawn--;
                                  
                                    lab.Death(panMain, panel, _row, _column, Lvl);                            
                                        lab.Respawn(panMain, panel, _row, _column, Lvl);
                                  
                                Life = MaxLife;



                            }
                        }
                        if (Lvl == 1)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 12;
                            _column = 9;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                     else   if (Lvl==2)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 6;
                            _column = 8;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 3)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 28;
                            _column = 2;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 4)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 19;
                            _column = 38;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 5)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 6)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 1;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 7)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 7;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }


                    }
                    #endregion

                }

                else if (e.KeyChar == ' ' || e.KeyChar == '0')
                {
                    #region Search

                  

                    if (Gold >= 50)
                        {
                            DialogResult dialogResult = MessageBox.Show("Willst du den Boden nach gift untersuchen", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                                wait = true;
                            foreach (PictureBox panel in panMain.Controls)
                            {
                                _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                                _column = panel.Location.X / CellSize;
                                lab.Wait(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens,wait);
                            }
                            Gold = Gold - 50;
                            lblMenge.Text = Gold.ToString();
                            wait = false;
                            }
                        else if (dialogResult == DialogResult.No)
                        {
                                wait = false;
                            foreach (PictureBox panel in panMain.Controls)
                            {
                                _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                                _column = panel.Location.X / CellSize;
                                lab.Wait(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens, wait);
                            }
                           // lab.Wait(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens, wait);
                        }


                        }
                        else
                        {
                            wait = false;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                            _column = panel.Location.X / CellSize;
                            lab.Wait(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens, wait);
                        }
                    }

                    #endregion
                }
                else if (e.KeyChar == 'w' || e.KeyChar == '5')
                {

                    foreach (PictureBox panel in panMain.Controls)
                    {
                      

                       
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        #region Use Item
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
                            Bombs = lab.BomU2(panMain, panel, _row, _column, Bombs, Lvl);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU2(panMain, panel, _row, _column, Keys);


                        }
                        if (Mana > 0)
                        {
                            Mana = lab.ManU2(panMain, panel, _row, _column, Mana, Lvl);
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
                        }
                        #endregion
                        #region Funktiones

                      
                        lab.Up(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens,Mana);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armormat = lab.Schield(panMain, panel, _row, _column, Armormat);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        lab.Event(panMain, panel, _row, _column, Lvl);
                        Potions = lab.Potions(panMain, panel, _row, _column, Potions);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Spellpower = lab.Magic(panMain, panel, _row, _column, Spellpower);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc, Lvl);
                        #endregion
                        #region Cheats

                       
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
                        #endregion
                        #region Encounters

                   
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
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
                            else if (encounte == 2)
                            {
                                picnpc.BackgroundImage = BanditC;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else if (sword > 1 && Armor > 0)
                                    {
                                        sword = sword - 2;
                                        Armor--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 3)
                            {
                                picnpc.BackgroundImage = Soldat;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {

                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 4)
                            {
                                picnpc.BackgroundImage = Gua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 1 && Armor > 1)
                                    {
                                        sword = sword - 2;
                                        Armor = Armor - 2;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 2;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 5)
                            {
                                picnpc.BackgroundImage = EGua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0 && Armor > 1)
                                    {
                                        sword = sword - 1;
                                        Armor = Armor - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 6)
                            {
                                picnpc.BackgroundImage = Gob;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0)
                                    {
                                        sword = sword - 1;

                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {

                                    encounte = 0;
                                }
                            }
                            else if (encounte == 7)
                            {
                                picnpc.BackgroundImage = Gok;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 2 && Armor > 1)
                                    {
                                        sword = sword - 3;
                                        Armor = Armor - 2;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 4;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 8)
                            {
                                picnpc.BackgroundImage = Dark;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs >= 99)
                                    {
                                        Bombs = 0;

                                         Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword >= 99 && Armor >= 99)
                                    {
                                        sword =0;
                                        Armor = 0;
                                       

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = 0;
                                       

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = 0;
                                    encounte = 0;
                                }
                            }
                        }
                        #endregion
                        #region Trade and Damage

                       
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
                                Armormat++;
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
                            if (Armormat > 0)
                            {
                                item = 1;
                                trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            }
                            if (trade == true && Armormat > 0)
                            {
                                Armormat--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Life = lab.Poison(panMain, panel, _row, _column, Life);

                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
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
                            Armor = lab.FireA(panMain, panel, _row, _column, Armor);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
                            Life = lab.Electro(panMain, panel, _row, _column, Life, Armor);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                        }
                    }
                    #endregion
                    #region UI Update

                  
                    Rowsd--;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lstinve.Items.Add("Heiltränke " + Potions.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblArmor.Text = Armor.ToString();
                    lblsword.Text = sword.ToString();
                    txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                    picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                    #endregion
                    #region Level Over

               
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;

                            if (Lvl == 2 && leverover == false && _row == 6 && _column == 8)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }

                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                lblrespawn.Text = Respawn.ToString();
                                Respawn = 3;
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 4 && leverover == false && _row == 19 && _column == 38)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 19;
                                _column = 38;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 5 && leverover == false && _row == 3 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 6 && leverover == false && _row == 1 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 1;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 7 && leverover == false && _row == 3 && _column == 7)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 7;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                            lab.Starts(panel, _row, _column);
                        }
                      
                          
                           
                           



                    }
                    #endregion
                    #region Dead and Respawn

                
                    if (Life <= 0)
                    { 
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Respawn == 0)
                            {
                                Alive = false;
                                lblLife.Text = "Du bist Tod";

                                lblbombs.Text = "Tod";
                                lblkey.Text = "";
                                lblArmorCount.Text = "";
                                lblBombCount.Text = "";
                                lbllifeCount.Text = "";
                                lblkeycount.Text = "";
                                lblMenge.Text = "";
                                lblsword.Text = "";
                                break;
                            }
                            else
                            {
                                //  Respawn--;

                                lab.Death(panMain, panel, _row, _column, Lvl);
                                lab.Respawn(panMain, panel, _row, _column, Lvl);

                                Life = MaxLife;



                            }
                        }
                        if (Lvl == 1)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 12;
                            _column = 9;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 2)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 6;
                            _column = 8;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 3)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 28;
                            _column = 2;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 4)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 19;
                            _column = 38;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 5)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 6)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 1;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 7)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 7;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }


                    }
                    #endregion
                }
                else if (e.KeyChar == 'a' || e.KeyChar == '1')
                {

                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        #region Use Item

                 
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
                            Bombs = lab.BomU3(panMain, panel, _row, _column, Bombs, Lvl);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU3(panMain, panel, _row, _column, Keys);


                        }
                        if (Mana > 0)
                        {
                            Mana = lab.ManU3(panMain, panel, _row, _column, Mana, Lvl);
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
                        #endregion
                        #region Funktions

                      
                        lab.Left(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens,Mana);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armormat = lab.Schield(panMain, panel, _row, _column, Armormat);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        Spellpower = lab.Magic(panMain, panel, _row, _column, Spellpower);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        lab.Event(panMain, panel, _row, _column, Lvl);
                        Potions = lab.Potions(panMain, panel, _row, _column, Potions);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc, Lvl);
                        #endregion
                        #region Cheats

                   
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
                        #endregion
                        #region Encounters
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
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
                            else if (encounte == 2)
                            {
                                picnpc.BackgroundImage = BanditC;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else if (sword > 1 && Armor > 0)
                                    {
                                        sword = sword - 2;
                                        Armor--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 3)
                            {
                                picnpc.BackgroundImage = Soldat;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {

                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 4)
                            {
                                picnpc.BackgroundImage = Gua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 1 && Armor > 1)
                                    {
                                        sword = sword - 2;
                                        Armor = Armor - 2;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 2;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 5)
                            {
                                picnpc.BackgroundImage = EGua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0 && Armor > 1)
                                    {
                                        sword = sword - 1;
                                        Armor = Armor - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 6)
                            {
                                picnpc.BackgroundImage = Gob;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0)
                                    {
                                        sword = sword - 1;

                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {

                                    encounte = 0;
                                }
                            }
                            else if (encounte == 7)
                            {
                                picnpc.BackgroundImage = Gok;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 2 && Armor > 1)
                                    {
                                        sword = sword - 3;
                                        Armor = Armor - 2;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 4;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 8)
                            {
                                picnpc.BackgroundImage = Dark;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs >= 99)
                                    {
                                        Bombs=0;
                                       

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword >= 99 && Armor >= 99)
                                    {
                                        sword = 0;
                                        Armor = 0;                                   
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = 0;
                                        

                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = 0;
                                    encounte = 0;
                                }
                            }

                        }
                        #endregion
                        #region Trade and Damage

                      
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
                                Armormat++;
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
                            if (Armormat > 0)
                            {
                                item = 1;
                                trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            }
                            if (trade == true && Armormat > 0)
                            {
                                Armormat--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Life = lab.Poison(panMain, panel, _row, _column, Life);

                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
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
                            Armor = lab.FireA(panMain, panel, _row, _column, Armor);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.Electro(panMain, panel, _row, _column, Life, Armor);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();

                        }
                    }
                    #endregion
                    #region UI Update

                
                    Columnsd--;



                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lstinve.Items.Add("Heiltränke " + Potions.ToString());
                    lblBombCount.Text = Bombs.ToString();
                    lblArmorCount.Text = Armor.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblArmor.Text = Armor.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblsword.Text = sword.ToString();
                    txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                    picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                    #endregion
                    #region Level Over

                  
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Lvl == 2 && leverover == false && _row == 6 && _column == 8)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;

                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 4 && leverover == false && _row == 19 && _column == 38)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 19;
                                _column = 38;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 5 && leverover == false && _row == 3 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 6 && leverover == false && _row == 1 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 1;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 7 && leverover == false && _row == 3 && _column == 7)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 7;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }

                            lab.CreateWorld(panel, _row, _column, Lvl);
                            lab.Starts(panel, _row, _column);
                        }
                      


                    }
                    #endregion
                    #region Dead and Respawn

                 
                    if (Life <= 0)
                    { 
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Respawn == 0)
                            {
                                Alive = false;
                                lblLife.Text = "Du bist Tod";

                                lblbombs.Text = "Tod";
                                lblkey.Text = "";
                                lblArmorCount.Text = "";
                                lblBombCount.Text = "";
                                lbllifeCount.Text = "";
                                lblkeycount.Text = "";
                                lblMenge.Text = "";
                                lblsword.Text = "";
                                break;
                            }
                            else
                            {
                                //  Respawn--;

                                lab.Death(panMain, panel, _row, _column, Lvl);
                                lab.Respawn(panMain, panel, _row, _column, Lvl);

                                Life = MaxLife;



                            }
                        }
                        if (Lvl == 1)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 12;
                            _column = 9;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 2)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 6;
                            _column = 8;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 3)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 28;
                            _column = 2;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 4)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 19;
                            _column = 38;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 5)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 6)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 1;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 7)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 7;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }


                    }
                    #endregion
                }
                else if (e.KeyChar == 'd' || e.KeyChar == '3')
                {

                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        #region Use Item

                
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
                            Bombs = lab.BomU4(panMain, panel, _row, _column, Bombs, Lvl);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.KeyU4(panMain, panel, _row, _column, Keys);


                        }
                        if (Mana > 0)
                        {
                            Mana = lab.ManU4(panMain, panel, _row, _column, Mana, Lvl);
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
                        #endregion
                        #region Funktions

                      
                        lab.Right(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys, sword, Lvl, Gold, Tokens,Mana);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        MaxLife = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        Armormat = lab.Schield(panMain, panel, _row, _column, Armormat);
                        txtdialog.Text = lab.Person(panMain, panel, _row, _column, Lvl);
                        encounte = lab.Encounter(panMain, panel, _row, _column);
                        txtdialog.Text = lab.Kommentar(panMain, panel, _row, _column, Lvl, txtdialog.Text);
                        sword = lab.Schliefff(panMain, panel, _row, _column, sword);
                        lab.Event(panMain, panel, _row, _column, Lvl);
                        Spellpower = lab.Magic(panMain, panel, _row, _column, Spellpower);
                        cheat = lab.Cheats(panMain, panel, _row, _column, cheat);
                        Potions = lab.Potions(panMain, panel, _row, _column, Potions);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money2(panMain, panel, _row, _column, Gold);
                        picnpc.BackgroundImage = lab.Npc(panMain, panel, _row, _column, picnpc, Lvl);
                        #endregion
                        #region Cheats

                        
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
                        #endregion
                        #region Encounters                    
                        if (encounte > 0)
                        {
                            if (encounte == 1)
                            {
                                picnpc.BackgroundImage = Bandit;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
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
                            else if (encounte == 2)
                            {
                                picnpc.BackgroundImage = BanditC;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else if (sword > 1 && Armor > 0)
                                    {
                                        sword = sword - 2;
                                        Armor--;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 2000;
                                        Tokens = Tokens + 2;
                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 3)
                            {
                                picnpc.BackgroundImage = Soldat;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {

                                    if (sword > 0 && Armor > 0)
                                    {
                                        sword--;
                                        Armor--;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 200;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 4)
                            {
                                picnpc.BackgroundImage = Gua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 1 && Armor > 1)
                                    {
                                        sword = sword - 2;
                                        Armor = Armor - 2;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 3;
                                        Gold = Gold + 1000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 2;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 5)
                            {
                                picnpc.BackgroundImage = EGua;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0 && Armor > 1)
                                    {
                                        sword = sword - 1;
                                        Armor = Armor - 2;
                                        Gold = Gold + 400;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 400;
                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = Life - 1;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 6)
                            {
                                picnpc.BackgroundImage = Gob;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {


                                    if (sword > 0)
                                    {
                                        sword = sword - 1;

                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 2;
                                        Gold = Gold + 100;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {

                                    encounte = 0;
                                }
                            }
                            else if (encounte == 7)
                            {
                                picnpc.BackgroundImage = Gok;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs > 1)
                                    {
                                        Bombs--;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword > 2 && Armor > 1)
                                    {
                                        sword = sword - 3;
                                        Armor = Armor - 2;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = Life - 4;
                                        Gold = Gold + 3000;

                                        Fight = false;
                                        encounte = 0;
                                    }


                                }
                                else
                                {
                                    Life = Life - 3;
                                    encounte = 0;
                                }
                            }
                            else if (encounte == 8)
                            {
                                picnpc.BackgroundImage = Dark;
                                Fight = lab.Fight(panMain, panel, _row, _column, Fight, sword, Armor, encounte, Bombs);
                                if (Fight == true)
                                {
                                    if (Bombs >= 99)
                                    {
                                        Bombs=0;
                                       

                                        Fight = false;
                                        encounte = 0;
                                    }

                                    if (sword >= 99 && Armor >= 99)
                                    {
                                        sword = 0;
                                        Armor = 0;
                                     

                                        Fight = false;
                                        encounte = 0;
                                    }
                                    else
                                    {
                                        Life = 0;                                      
                                        Fight = false;
                                        encounte = 0;
                                    }
                                }
                                else
                                {
                                    Life = 0;
                                    encounte = 0;
                                }
                            }

                        }
                        #endregion
                        #region Trade and Damage

                       
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
                                Armormat++;
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
                            if (Armormat > 0)
                            {
                                item = 1;
                                trade = lab.Trading(panMain, panel, _row, _column, trade, item);
                            }
                            if (trade == true && Armormat > 0)
                            {
                                Armormat--;
                                Gold = Gold + 150;
                                trade = false;
                            }
                            Life = lab.Poison(panMain, panel, _row, _column, Life);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
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
                            Life = lab.Electro(panMain, panel, _row, _column, Life, Armor);
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                            Life = lab.Lavama(panMain, panel, _row, _column, Life);
                            Life = lab.Dorne(panMain, panel, _row, _column, Life);
                            Armor = lab.FireA(panMain, panel, _row, _column, Armor);
                            Life = lab.FireL(panMain, panel, _row, _column, Life);
                            txtboxLife.Width = (30 * Life);
                            txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                        }
                    }
                    #endregion
                    #region UI Update

                 
                    Columnsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
                    lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                    lstinve.Items.Add("Heiltränke " + Potions.ToString());
                    lblArmorCount.Text = Armor.ToString();
                    lblBombCount.Text = Bombs.ToString();
                    lbllifeCount.Text = Life.ToString();
                    lblkeycount.Text = Keys.ToString();
                    lblMenge.Text = Gold.ToString();
                    lblArmor.Text = Armor.ToString();
                    lblsword.Text = sword.ToString();
                    txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                    picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                    #endregion
                    #region Level Over

                 
                    if (leverover == false)
                    {
                        Lvl++;
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Lvl == 2 && leverover == false && _row == 6 && _column == 8)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;

                            }
                            else if (Lvl == 3 && leverover == false && _row == 28 && _column == 2)
                            {
                                Levelstory = Lvl;
                                DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    frmLabStory fnp = new frmLabStory();
                                    fnp.ShowDialog();
                                }
                                else if (dialogResult == DialogResult.No)
                                {

                                }
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 28;
                                _column = 2;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 4 && leverover == false && _row == 19 && _column == 38)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 19;
                                _column = 38;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 5 && leverover == false && _row == 3 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 6 && leverover == false && _row == 1 && _column == 4)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 1;
                                _column = 4;
                                Rowsd = _row;
                                Columnsd = _column;
                               lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            else if (Lvl == 7 && leverover == false && _row == 3 && _column == 7)
                            {
                                Respawn = 3;
                                lblrespawn.Text = Respawn.ToString();
                                _row = 3;
                                _column = 7;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                                ende = true;
                            }
                            lab.CreateWorld(panel, _row, _column, Lvl);
                            lab.Starts(panel, _row, _column);

                        }
                       
                    }
                    #endregion
                    #region Dead and Respawn

             
                    if (Life <= 0)
                    { 
                        foreach (PictureBox panel in panMain.Controls)
                        {
                            _row = panel.Location.Y / CellSize;
                            _column = panel.Location.X / CellSize;
                            if (Respawn == 0)
                            {
                                Alive = false;
                                lblLife.Text = "Du bist Tod";

                                lblbombs.Text = "Tod";
                                lblkey.Text = "";
                                lblArmorCount.Text = "";
                                lblBombCount.Text = "";
                                lbllifeCount.Text = "";
                                lblkeycount.Text = "";
                                lblMenge.Text = "";
                                lblsword.Text = "";
                                break;
                            }
                            else
                            {
                                //  Respawn--;

                                lab.Death(panMain, panel, _row, _column, Lvl);
                                lab.Respawn(panMain, panel, _row, _column, Lvl);

                                Life = MaxLife;



                            }
                        }
                        if (Lvl == 1)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 12;
                            _column = 9;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 2)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 6;
                            _column = 8;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 3)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 28;
                            _column = 2;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 4)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 19;
                            _column = 38;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 5)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 6)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 1;
                            _column = 4;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }
                        else if (Lvl == 7)
                        {
                            Respawn--;
                            lblrespawn.Text = Respawn.ToString();
                            _row = 3;
                            _column = 7;
                            Rowsd = _row;
                            Columnsd = _column;
                            lab.Starts(panel, _row, _column);
                        }


                    }
                }
                #endregion

            }
            else if (Alive == false&& Life != 0)
          
            {

                MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
            }
        }

        private void Labyrinth_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnlv2_Click(object sender, EventArgs e)
        {
            #region Level 2

          
            btnlv2.Enabled = false;
            btnlv2.Enabled = true;
            Lvl = 2;
            Levelstory = Lvl;
            DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmLabStory fnp = new frmLabStory();
                fnp.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor =1;
                Armormat = 0;
                MaxLife = 4;
                Bombs = 0;
                Keys = 0;
                Respawn = 3;
                Potions = 1;
                sword = 0;
                Gold = 500;
                Tokens = 0;
                Mana = 0;
                lblrespawn.Text = Respawn.ToString();
                Spellpower = 0;
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lblkeycount.Text = Keys.ToString();
                lblArmor.Text = Armor.ToString();
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
                Respawn = 3;
                sword = 0;
                Armormat = 0;
                Potions = 1;
                Gold = 500;
                Keys = 0;
                Rowsd = 0;
                Columnsd = 0;
                Mana = 0;
                lblrespawn.Text = Respawn.ToString();
                Spellpower = 0;
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lblArmor.Text = Armor.ToString();
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize;
                    _column = panel.Location.X / CellSize;
                    lab.CreateWorld(panel, _row, _column, Lvl);
                }
                Alive = true;
                first = true;
            }
            #endregion
        }

     

        private void btnlvl3_Click(object sender, EventArgs e)
        {
            #region Level 3

           
            btnlvl3.Enabled = false;
            btnlvl3.Enabled = true;
            Lvl = 3;

         
            Levelstory = Lvl;
            DialogResult dialogResult = MessageBox.Show("Willst du ein Wenig Story hören", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                frmLabStory fnp = new frmLabStory();
                fnp.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 2;
                MaxLife = 4;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 0;
                Potions = 1;
                sword = 1;
                Gold = 2500;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
                Armor = 2;
                MaxLife = 4;
                Bombs = 1;
                Gold = 2500;
                sword = 1;
                Respawn = 3;
                Keys = 0;
                Armormat = 0;
                Potions = 1;
                Rowsd = 0;
                lblrespawn.Text = Respawn.ToString();
                Columnsd = 0;
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
            #endregion
        }

        private void btnheal_Click(object sender, EventArgs e)
        {
            #region Potion Heal

            
            if (Potions >0)
            {
                Life = Life + 3;
                Potions--;
                if (Life> MaxLife)
                {
                    Life = MaxLife;
                }
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lblArmorCount.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lbllifeCount.Text = Life.ToString();
                lblkeycount.Text = Keys.ToString();
                lblMenge.Text = Gold.ToString();
                lblsword.Text = sword.ToString();
                lblArmor.Text = Armor.ToString();
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
            }
            else
            {

            }
            #endregion
        }

        private void btnlvl4_Click(object sender, EventArgs e)
        {
            #region Level 4

        
            btnlvl4.Enabled = false;
            btnlvl4.Enabled = true;
            Lvl = 4;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 4;
                MaxLife = 4;
                Bombs = 0;
                Keys = 0;
                Armormat = 0;
                Respawn = 3;
                Potions = 2;
                sword = 3;
                Gold = 4000;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
                Armor = 4;
                MaxLife = 4;
                Bombs = 0;
                Gold = 4000;
                sword = 3;
                Respawn = 3;
                Keys = 0;
                Potions = 2;
                Armormat = 0;
                lblrespawn.Text = Respawn.ToString();
                Rowsd = 0;
                Columnsd = 0;
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
            #endregion
        }

        private void btnlvl5_Click(object sender, EventArgs e)
        {
            #region Level 5

         
            btnlvl5.Enabled = false;
            btnlvl5.Enabled = true;
            Lvl = 5;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 4;
                Armor = 3;
                MaxLife = 4;
                Bombs = 0;
                Keys = 0;
                Respawn = 3;
                Armormat = 0;
                Potions = 1;
                sword = 2;
                Gold = 4500;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                Spellpower = 0;
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblArmor.Text = Armor.ToString();
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
                Armor = 3;
                MaxLife = 4;
                Bombs = 0;
                Armormat = 0;
                Gold = 4500;
                sword = 2;
                Respawn = 3;
                Keys = 0;
                Potions = 1;
                Rowsd = 0;
                Columnsd = 0;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
            #endregion
        }

        private void btnLore_Click(object sender, EventArgs e)
        {
            frmHelp_Page fnp = new frmHelp_Page();

            fnp.ShowDialog();
        }

        private void lblArmor_Click(object sender, EventArgs e)
        {

        }

        private void btnschild_Click(object sender, EventArgs e)
        {
            #region Armor

       
            if (Armormat > 0)
            {
                Armor++;
                Armormat--;
               
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lblArmor.Text = Armor.ToString();
                lblBombCount.Text = Bombs.ToString();
                lbllifeCount.Text = Life.ToString();
                lblkeycount.Text = Keys.ToString();
                lblMenge.Text = Gold.ToString();
                lblsword.Text = sword.ToString();
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
            }
            else
            {

            }
            #endregion
        }

        private void btnlvl6_Click(object sender, EventArgs e)
        {
            #region Level 6

        
            btnlvl6.Enabled = false;
            btnlvl6.Enabled = true;
            Lvl = 6;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                Spellpower = 0;
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblArmor.Text = Armor.ToString();
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
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                Rowsd = 0;
                Columnsd = 0;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
            #endregion
        }
        int Test = 0;
        private void lblchapter_Click(object sender, EventArgs e)
        {
            Test++;
            if (Test==5)
            {
                btnlvl0.Enabled=true;
                btnlvl0.Visible = true;
                Test = 0;
            }
            else
            {
                btnlvl0.Enabled = false;
                btnlvl0.Visible = false;
            }
        }

        private void btnlvl0_Click(object sender, EventArgs e)
        {
            #region Test Level 0

          
            btnlvl0.Enabled = false;
            btnlvl0.Enabled = true;
            Lvl = 0;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                Spellpower = 0;
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblArmor.Text = Armor.ToString();
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
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                Rowsd = 0;
                Columnsd = 0;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
  #endregion
        }

        private void btnlvl7_Click(object sender, EventArgs e)
        {
            #region Level 7


            btnlvl7.Enabled = false;
            btnlvl7.Enabled = true;
            Lvl = 7;
            if (Gene == false)
            {
                Gene = true;
                foreach (PictureBox panel in panMain.Controls)
                {
                    panel.BackColor = Color.LightGreen;
                }
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                lblArmor.Text = Armor.ToString();
                txtmana.Text = Mana.ToString() + "  /   " + Spellpower.ToString();
                Spellpower = 0;
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                txtboxLife.Width = (30 * Life);
                txtboxLife.Text = Life.ToString() + " / " + MaxLife.ToString();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
                lbllifeCount.Text = Life.ToString();
                lblArmorCount.Text = Armor.ToString();
                lblArmor.Text = Armor.ToString();
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
                Life = 5;
                Armor = 4;
                MaxLife = 5;
                Bombs = 1;
                Keys = 0;
                Respawn = 3;
                Armormat = 1;
                Potions = 2;
                sword = 4;
                Gold = 5500;
                Rowsd = 0;
                Columnsd = 0;
                lblrespawn.Text = Respawn.ToString();
                Mana = 0;
                Spellpower = 0;
                lblArmor.Text = Armor.ToString();
                picchar.BackgroundImage = labAv.Avatar(picchar, Armor, sword);
                Tokens = 0;
                lstinve.Items.Clear();
                lstinve.Items.Add("Rüstungsverstärkmaterial " + Armormat.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
                lstinve.Items.Add("Bandit Tokens " + Tokens.ToString());
                lstinve.Items.Add("Heiltränke " + Potions.ToString());
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
            #endregion

        }
    }
}
