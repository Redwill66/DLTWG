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
    public partial class Memory : Form
    {
        private static string DLTW = Properties.Settings.Default.ConnectionString;
        private int _rows;
        private int _row;
        private int _column;
        private int _columns;
        private const int CellSize = 90;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        public const int size = 8;

        Bitmap Empty = Properties.Resources.Leer;
        Bitmap Yellow = Properties.Resources.Gelb;
        Bitmap Red = Properties.Resources.Rot;
        Bitmap WhitePawn = Properties.Resources.White_Pawn;
        Bitmap WhiteTower = Properties.Resources.White_Tower;
        Bitmap WhiteBishop = Properties.Resources.White_Bishop;
        Bitmap WhiteKing = Properties.Resources.White_King;
        Bitmap WhiteQueen = Properties.Resources.White_Queen;
        Bitmap WhiteKnight = Properties.Resources.White_Knight;
        Bitmap BlakePawn = Properties.Resources.Black_Pawn;
        Bitmap BlackKing = Properties.Resources.Black_King;
        Bitmap BlackQueen = Properties.Resources.Black_Queen;
        Bitmap BlackBishop = Properties.Resources.Black_Bishop;
        Bitmap BlackTower = Properties.Resources.Black_Tower;
        Bitmap BlackKnight = Properties.Resources.Black_Knight;
        Bitmap Flag = Properties.Resources.Flag;
        Bitmap Question = Properties.Resources.Question;
        Bitmap Bomb = Properties.Resources.Bomb;
        Bitmap one = Properties.Resources._1;
        Bitmap Two = Properties.Resources._2;
        Bitmap Three = Properties.Resources._3;
        Bitmap Four = Properties.Resources._4;
        Bitmap Five = Properties.Resources._5;
        Bitmap Sechs = Properties.Resources._6;
        Bitmap Sieben = Properties.Resources._7;
        Bitmap Acht = Properties.Resources._8;
        Bitmap Head = Properties.Resources.Head;

        Bitmap Berry = Properties.Resources.Berry;
        Bitmap House = Properties.Resources.Haus;
        Bitmap Tree = Properties.Resources.Baum;
        Bitmap Timeclock = Properties.Resources.Sanduhr;
        Bitmap Pyra = Properties.Resources.Secret;
        //   private const int CellSize = 10;
        private static int depth = 6;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Button = "Button";
        private const string Yellows = "Yellow";
        private const string Reds = "Red";
        bool player = false;
      
        Memoryfunk MemoBuild = new Memoryfunk();
        public Memory()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < 8; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 8; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void Memory_Load(object sender, EventArgs e)
        {
           

            for (_column = 0; _column < 8; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 8; _row++)// Generiert die Zellen der Reihen
                {
                   
                        PictureBox Pic = MemoBuild.GenerateGrid();
                        Pic.Location = new Point(_column * CellSize, _row * CellSize);
                    Pic.Click += Pic_Click;
                    // Pic.BackgroundImage = Empty;
                    // _grid[_column, _row, 0] = Free;
                    // Pic.BackgroundImageLayout = ImageLayout.Zoom;
                    panMain.Controls.Add(Pic);
                    
                }
            }
        }
        int sc1 = 0;
        int sc2 = 0;
        bool first= true;
       
        int test = 0;
        int Freefield = 64;
        PictureBox panel = new PictureBox();
        private void Pic_Click(object sender, EventArgs e)
        {
            if (Freefield!= 0)
            {

           
            MouseEventArgs me = (MouseEventArgs)e;

            PictureBox thispanel = ((PictureBox)sender);
            _row = thispanel.Location.Y / CellSize; //Position der Zelle in der Y achse
           _column = thispanel.Location.X / CellSize; //Position der Zelle in der X achse
            if (first== true &&thispanel.BackgroundImage== null)
            {
                //  PictureBox panel = thispanel;
                //  Rows = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                //  Columns = panel.Location.X / CellSize; //Position der Zelle in der X achse
                //Rows, Columns,
               panel = MemoBuild.Opening(panMain, thispanel, _row, _column);
                test++;
                first = false;
            }
            else if (first == false && thispanel.BackgroundImage == null)
            
            {
                //Rows, Columns,

               thispanel=  MemoBuild.Opening(panMain, thispanel, _row, _column);
                //panel.BackgroundImage = thispanel.BackgroundImage;
                first = true;
                test++;
            }
            if (test == 2)
            {
               
                    if (panel.BackgroundImage == thispanel.BackgroundImage)
                    {
                        test = 0;
                    //  MessageBox.Show("hallo");
                    if (player==false)
                    {
                        sc1++;
                        lblscore1.Text = sc1.ToString();
                            Freefield = Freefield - 2;
                       // player = true;
                    }
                    else if (player == true)
                    {
                        sc2++;

                        lblscore2.Text = sc2.ToString();
                            Freefield = Freefield - 2;
                        //    player = false;
                    }
                  
                }
                    else if (panel.BackgroundImage != thispanel.BackgroundImage )

                    { 
                        MessageBox.Show("Keine Übereinstimmung");
                        panel.BackgroundImage = null;
                 
                        thispanel.BackgroundImage = null;
                    if (player == false)
                    {
                       
                        player = true;
                    }
                    else if (player == true)
                    {
                       
                        player = false;
                    }
                    test = 0;
                    }
                
            }


            }
            else
            {
                if (sc1> sc2)
                {
                    lblgameover.Text = "Spiel vorbei, Spieler 1 hat gewonnen";
                }
                else if (sc1 < sc2)
                {
                    lblgameover.Text = "Spiel vorbei, Spieler 2 hat gewonnen";
                }
                else
                {
                    lblgameover.Text = "Spiel vorbei, Es ist unentschieden"; 
                }
              
                //lblgameover.Text = "Spiel vorbei";
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            foreach (PictureBox panel in panMain.Controls)
            {
                _rows = panel.Location.Y / CellSize;
                _columns = panel.Location.X / CellSize;
                // panel.BackgroundImage = Question;
                panel.BackColor = Color.Aqua;
                MemoBuild.Mixing(panMain,panel, _rows, _columns);
            }
            
        }

      
    }
}
