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
    public partial class frmSnake : Form
    {
      
        private int _row;
        private int _column;
      
        private const int CellSize = 20;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        public const int size = 8;

        Bitmap Head = Properties.Resources.Head;
        Bitmap Body = Properties.Resources.Body;
        Bitmap Berry = Properties.Resources.Berry;
        //   private const int CellSize = 10;
        private static int depth = 6;
        // public static List<Figure> Figures = new List<Figure>();
        bool alive = true ;
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Wall = "Wall";
        private const string Snakehead = "Snakehead";
        private const string Snakes = "Snake";
        private const string Berrys = "Berry";
      
        Snakefunk sine = new Snakefunk();
        public frmSnake()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < 70; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 30; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }

            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {

          

        }

       

        private void Btncreate_Click(object sender, EventArgs e)
        {
            panMain.Size = new Size(CellSize * 70, CellSize * 30);
            for (_row = 0; _row < 30; _row++)// Generiert die Zellen der Reihen
            {

                for (_column = 0; _column < 70; _column++)// Generiert die Zellen der Spalten
            {

                    if (_column ==0 || _column == 69|| _row == 0 || _row == 29)
                    {
                        PictureBox panels = sine.GenerateGrid2(_row, _column);
                        //panels.Click += panel_Click;
                        panMain.Controls.Add(panels);
                    }
                    else
                    {
                        PictureBox panel = sine.GenerateGrid(_row, _column);
                        panel.Click += panel_Click;
                        panMain.Controls.Add(panel);
                    }



                   
                   



                }


            }
           
        }
        bool start = false;
        int richtung = 0;
        int Rowsd = 0;
        int Columnsd = 0;

        bool first = true;
        private void panel_Click(object sender, EventArgs e)
        {
            if (first == true)
            {
                MouseEventArgs me = (MouseEventArgs)e;

            PictureBox panel = ((PictureBox)sender);
            _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
            _column = panel.Location.X / CellSize;
            Rowsd = _row;
            Columnsd = _column;
            
                panel = sine.SnakeStart(panel, _row, _column);
                first = false;
            }
            btnup.Enabled = true;
            btndown.Enabled = true;
            btnleft.Enabled = true;
            btnright.Enabled = true;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            btnup.Enabled = false;
            btndown.Enabled = false;
            btnleft.Enabled = true;
            btnright.Enabled = true;
            if (start == false)
            {
                tmrsnake.Start();
                start = true;
            }
          
            richtung = 1;
            if (Rowsd  > 0)
            {

          
           // PictureBox panel = new PictureBox();
           //  PictureBox panel = ((PictureBox)sender);

            foreach (PictureBox panel in panMain.Controls)
            {
                 
                    _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                _column = panel.Location.X / CellSize;
                 sine.SnakeUp(panMain, panel, Rowsd, Columnsd,_row,_column);
               
            }
                if (Rowsd != 1)
                {
                    Rowsd--;
                }    
          
            }
        }

        private void btnright_Click(object sender, EventArgs e)
        {
            btnup.Enabled = true;
            btndown.Enabled = true;
            btnleft.Enabled = false;
            btnright.Enabled = false;
            if (start == false)
            {
                tmrsnake.Start();
                start = true;
            }
            richtung = 3;

            if (Columnsd+1 < 70)
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                    _column = panel.Location.X / CellSize;
                    sine.Snakeright(panel, Rowsd, Columnsd, _row, _column);

                }
                Columnsd++;
            }
        }

        private void btndown_Click(object sender, EventArgs e)
        {
            btnup.Enabled = false;
            btndown.Enabled = false;
            btnleft.Enabled = true;
            btnright.Enabled = true;
            if (start == false)
            {
                tmrsnake.Start();
                start = true;
            }
            richtung = 2;
            if (Rowsd+1 < 30)
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                    _column = panel.Location.X / CellSize;
                    sine.Snakedown(panel, Rowsd, Columnsd, _row, _column);

                }
                Rowsd++;
            }
        }

        private void btnleft_Click(object sender, EventArgs e)
        {
            btnup.Enabled = true;
            btndown.Enabled = true;
            btnleft.Enabled = false;
            btnright.Enabled = false;
            if (start == false)
            {
               tmrsnake.Start();
                start = true;
            }
            richtung = 4;
            if (Columnsd  > 0)
            {
                foreach (PictureBox panel in panMain.Controls)
                {
                    _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                    _column = panel.Location.X / CellSize;
                    sine.SnakeLeft(panel, Rowsd, Columnsd, _row, _column);

                }
                if (Columnsd != 1)
                {
                    Columnsd--;
                }
               
            }
        }

        int Berrytick = 0;
        private void tmrsnake_Tick(object sender, EventArgs e)
        {
            if (alive== true)
            {
                alive=sine.Alive();
                if (alive== false)
                {
                    tmrsnake.Stop();
                    lblSnake.Text = "Snake ist Gestorben, Spiel ist vorbei";
                }
            }
            Berrytick++;
            if (Berrytick==5)
            {
               
                  
                    sine.Beery(panMain,  Rowsd, Columnsd, _row, _column);
                
               
                Berrytick = 0;
            }

            if (richtung == 1)
            {
                if (Rowsd > 0)
                {


                    // PictureBox panel = new PictureBox();
                    //  PictureBox panel = ((PictureBox)sender);

                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        sine.SnakeUp(panMain,panel, Rowsd, Columnsd, _row, _column);

                    }
                    if (Rowsd != 1)
                    {
                        Rowsd--;
                    }
                  
                }
            }
            else if (richtung == 2)
            {
                if (Rowsd + 1 < 30)
                {
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        sine.Snakedown(panel, Rowsd, Columnsd, _row, _column);

                    }
                    Rowsd++;
                }
            }
            else if (richtung == 3)
            {
                if (Columnsd + 1 < 70)
                {
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        sine.Snakeright(panel, Rowsd, Columnsd, _row, _column);

                    }
                    Columnsd++;
                }
            }
            else if (richtung == 4)
            {
                if (Columnsd > 0)
                {
                    foreach (PictureBox panel in panMain.Controls)
                    {
                        _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
                        _column = panel.Location.X / CellSize;
                        sine.SnakeLeft(panel, Rowsd, Columnsd, _row, _column);

                    }
                    if (Columnsd != 1)
                    {
                        Columnsd--;
                    }
                  
                }
            }
          
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < 70; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 30; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmSnake fnp = new frmSnake();
            Hide();
            fnp.ShowDialog();
            Close();
        }
    }
}
