using System;
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
        private int _rows;
        private int _row;
        private int _column;
        private int _columns;
       
        private const int CellSize = 20;
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
        bool Gene = false;
        int Lvl = 1;
        private void btnlvlone_Click(object sender, EventArgs e)
        {
            Lvl = 1;
            if (Gene == false)
            {
                Gene = true;
            
            Life = 3;
            Armor = 0;
            Bombs = 0;
            Keys = 0;
                sword = 0;
                Gold = 0;
                lstinve.Items.Add("Rüstungsdicke "+ Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                Rowsd = 0;
                Columnsd = 0;
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
       
        private void Labyrinth_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                            Bombs = lab.BomU(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.BomU(panMain, panel, _row, _column, Keys);


                        }
                        lab.Down(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield2(panMain, panel, _row, _column, Armor);
                        Bombs = lab.Bomm2(panMain, panel, _row, _column, Bombs);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        Keys = lab.Keyss2(panMain, panel, _row, _column, Keys);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);

                        if (Armor==0)
                        {
                            Life = lab.Poison2(panMain, panel, _row, _column, Life);
                        
                    }
                        else if (Armor > 0)
                        {
                            Armor = lab.PoisonSchie2(panMain, panel, _row, _column, Armor);
                      
                        }
                    
                    }
                    Rowsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                            lab.CreateWorld(panel, _row, _column, Lvl);
                            if (Lvl == 2&&leverover == false && _row == 6 && _column == 8)
                            {
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                        }
                       
                   
                      
                    }
                    if (Life== 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du";
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
                            Bombs = lab.BomU2(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.BomU2(panMain, panel, _row, _column, Keys);


                        }
                        lab.Up(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys);
                        Life = lab.Heals2(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                      
                        if (Armor == 0)
                        {
                            Life = lab.Poison(panMain, panel, _row, _column, Life);
                        }
                        else if (Armor > 0)
                        {
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                        }
                    }
                    Rowsd--;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                            lab.CreateWorld(panel, _row, _column, Lvl);
                            if (Lvl == 2&& leverover == false && _row == 6 && _column == 8)
                            {
                                _row = 6;
                                _column = 8;
                                Rowsd = _row;
                                Columnsd = _column;
                                lab.Starts(panel, _row, _column);
                                leverover = true;
                            }
                        }
                       
                     
                        
                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du";
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
                            Bombs = lab.BomU3(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.BomU3(panMain, panel, _row, _column, Keys);


                        }
                        lab.Left(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs, Keys);
                        Life = lab.Heals2(panMain, panel, _row, _column, Life, MaxLife);
                        Armor = lab.Schield(panMain, panel, _row, _column, Armor);
                       txttip.Text= lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        Bombs = lab.Bomm(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss(panMain, panel, _row, _column, Keys);
                      
                        if (Armor == 0)
                        {
                        Life = lab.Poison(panMain, panel, _row, _column, Life);

                    }
                        else if (Armor > 0)
                        {
                            Armor = lab.PoisonSchie(panMain, panel, _row, _column, Armor);
                      
                    }
                    }
                    Columnsd--;



                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                   
                       

                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du";
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
                            Bombs = lab.BomU4(panMain, panel, _row, _column, Bombs);


                        }
                        if (Keys > 0)
                        {
                            Keys = lab.BomU4(panMain, panel, _row, _column, Keys);


                        }
                        lab.Right(panMain, panel, _row, _column, Rowsd, Columnsd, Bombs,Keys);
                        Life = lab.Heals(panMain, panel, _row, _column, Life, MaxLife);
                        txttip.Text = lab.hinww(panMain, panel, _row, _column, Lvl);
                        leverover = lab.Endes(panMain, panel, _row, _column);
                        Gold = lab.Money1(panMain, panel, _row, _column, Gold);
                        Gold = lab.MaxLife(panMain, panel, _row, _column, MaxLife);
                        Armor = lab.Schield3(panMain, panel, _row, _column, Armor);
                        Bombs = lab.Bomm3(panMain, panel, _row, _column, Bombs);
                        Keys = lab.Keyss3(panMain, panel, _row, _column, Keys);
                       
                        if (Armor == 0)
                    {
                        Life = lab.Poison3(panMain, panel, _row, _column, Life);
                     
                        
                    }
                        else if (Armor > 0)
                        {
                            Armor = lab.PoisonSchie3(panMain, panel, _row, _column, Armor);
                        
                    }
                    }
                    Columnsd++;
                    lstinve.Items.Clear();
                    lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                    lstinve.Items.Add("Bomben " + Bombs.ToString());
                    lstinve.Items.Add("Schlüssel " + Keys.ToString());
                    lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                            lab.CreateWorld(panel, _row, _column, Lvl);
                        }
                     
                       
             
                    }
                    if (Life == 0)
                    {
                        Alive = false;
                        lblLife.Text = "Du";
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

                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                sword = 0;
                Gold = 0;
                lstinve.Items.Add("Rüstungsdicke " + Armor.ToString());
                lstinve.Items.Add("Bomben " + Bombs.ToString());
                lstinve.Items.Add("Schlüssel " + Keys.ToString());
                lstinve.Items.Add("Schleifsteine " + sword.ToString());
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
                Life = 3;
                Armor = 0;
                Bombs = 0;
                Keys = 0;
                Rowsd = 0;
                Columnsd = 0;
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

        private void trbzoom_Scroll(object sender, EventArgs e)
        {
            foreach (PictureBox panel in panMain.Controls)
            {
                int Zoom = trbzoom.Value;
                lab.change(panel, _row, _column, Zoom);
            }
        }
    }
}
