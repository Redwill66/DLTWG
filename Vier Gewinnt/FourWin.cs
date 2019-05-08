using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    public partial class frmFourWin : Form
    {
        private static string DLTW = Properties.Settings.Default.ConnectionString;
        private int _rows;
        private int _row;
        private int _column;
        private int _columns;
        private const int CellSize = 70;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;
     
        public const int size = 8;

        Bitmap Empty = Properties.Resources.Leer;
        Bitmap Yellow = Properties.Resources.Gelb;
        Bitmap Red = Properties.Resources.Rot;
        //   private const int CellSize = 10;
        private static int depth = 6;
        // public static List<Figure> Figures = new List<Figure>();
       
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Button = "Button";
        private const string Yellows = "Yellow";
        private const string Reds = "Red";
        bool player = false;
        bool Gameover = false;
        bool Freepl = false;
        public frmFourWin()
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

        private void frmFourWin_Load(object sender, EventArgs e)
        {
            FourwinBuild build = new FourwinBuild();

            for (_column = 0; _column < 7; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 7; _row++)// Generiert die Zellen der Reihen
                {
                    if (_row < 6)
                    {
                       
                        PictureBox Pic = build.GenerateGrid();
                        Pic.Location = new Point( _column * CellSize,_row * CellSize);
                        Pic.BackgroundImage = Empty;
                        _grid[_column, _row, 0] = Free;
                        Pic.BackgroundImageLayout = ImageLayout.Zoom;
                        panMain.Controls.Add(Pic);
                    }
                    else if (_row == 6)
                    {
                        Button Bt = build.GenerateGrid2();
                        Bt.Click += Bt_Click;
                        _grid[_column, _row, 0] = Button;
                        Bt.Location = new Point( _column * CellSize,_row * CellSize);

                        panMain.Controls.Add(Bt);
                       
                    }
   
                }
                
                
            }



            // lstMember.Items.AddRange(startFunktion.Fore());




            NewplayerFunk newPF = new NewplayerFunk();

            lstplayerYellow.Items.AddRange(newPF.Fore());
            lstplayerRed.Items.AddRange(newPF.Fore2());

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            if (Gameover==false)
            {
                if (lstplayerYellow.Enabled== false && lstplayerRed.Enabled== false || Freepl == true)
                {

               
           
            FourwinBuild build = new FourwinBuild();
            int n = lstplayerYellow.SelectedIndex;
            int n2 = lstplayerRed.SelectedIndex;
            Button Bt = ((Button)sender);
            _rows = Bt.Location.Y / CellSize;
            _columns = Bt.Location.X / CellSize;
            if (player == true&&_grid[_columns, 0, 0] == Free )//Yellow Turn
            {
                player = false;
            }
            else if (player == false && _grid[_columns, 0, 0] == Free)
            {
                player = true;
            }

            foreach (Control Pic in panMain.Controls)// Kontrolliert jedes Panel in panMain
                {
                    _row = Pic.Top / CellSize;// Fängt Wegen Top oben an
                    _column = Pic.Left / CellSize;
                    if (_grid[_column, 0 , 0] == Free && _grid[_column, _row+1, 0] != Free && _column == _columns || _grid[_column, 0, 0] == Free && _grid[_column, _row+1, 0] == Button && _row < 6 && _column == _columns)
                    {
                    if (_grid[_column, _row, 0] != Reds && player == true)//Yellow Turn
                    {
                        Pic.BackgroundImage = Yellow;
                        _grid[_column, _row, 0] = Yellows;
                        Pic.BackgroundImageLayout = ImageLayout.Zoom;
                       
                        Bt.BackgroundImage = null;
                        _grid[_columns, _rows, 0] = Button;
                        Bt.BackgroundImageLayout = ImageLayout.Zoom;
                        if ( _row < _rows && _grid[_column, _row + 3, 0] == Yellows && _grid[_column, _row+1, 0] == Yellows&&_grid[_column, _row+2, 0] == Yellows && _grid[_column, _row, 0] == Yellows)
                        {
                            if (Freepl==false)
                            {

                           
                            object[] objCollection = new object[lstplayerYellow.Items.Count];
                            lstplayerYellow.Items.CopyTo(objCollection, 0);
                            lstplayerYellow.Items.Clear();
                            lstplayerYellow.Items.AddRange(build.ScoreFill(objCollection,n));
                            }
                            MessageBox.Show("Yellow Wins");
                                    Gameover = true;
                        }
                        else if (_column> 2&&_grid[_column - 1, _row, 0] == Yellows && _grid[_column - 2, _row, 0] == Yellows && _grid[_column - 3, _row, 0] == Yellows && _grid[_column , _row, 0] == Yellows  || _column > 1 && _grid[_column - 2, _row, 0] == Yellows && _grid[_column - 1, _row, 0] == Yellows && _grid[_column + 1, _row, 0] == Yellows && _grid[_column , _row, 0] == Yellows || _column > 0 && _grid[_column - 1, _row, 0] == Yellows && _grid[_column + 2, _row, 0] == Yellows && _grid[_column+1, _row, 0] == Yellows && _grid[_column , _row, 0] == Yellows || _grid[_column+3, _row, 0] == Yellows && _grid[_column+2, _row, 0] == Yellows && _grid[_column, _row, 0] == Yellows&& _grid[_column+1, _row , 0] == Yellows)
                        {
                            if (Freepl == false)
                            {
                                object[] objCollection = new object[lstplayerYellow.Items.Count];
                            lstplayerYellow.Items.CopyTo(objCollection, 0);
                            lstplayerYellow.Items.Clear();
                            lstplayerYellow.Items.AddRange(build.ScoreFill(objCollection, n));
                            }
                            MessageBox.Show("Yellow Wins");
                                    Gameover = true;
                                }
                        else if (_column > 2&& _grid[_column-3, _row+3, 0] == Yellows && _grid[_column-2, _row+2, 0] == Yellows && _grid[_column-1, _row+1, 0] == Yellows && _grid[_column, _row, 0] == Yellows || _row > 0 && _column > 1&&_grid[_column-1, _row+1, 0] == Yellows && _grid[_column-2, _row+2, 0] == Yellows && _grid[_column+1, _row-1, 0] == Yellows && _grid[_column, _row, 0] == Yellows || _row > 1 && _column > 0 && _grid[_column-1, _row+1, 0] == Yellows && _grid[_column+1, _row-1, 0] == Yellows && _grid[_column+2, _row-2, 0] == Yellows&& _grid[_column, _row, 0] == Yellows || _row > 2 && _grid[_column+3, _row-3, 0] == Yellows && _grid[_column+2, _row-2, 0] == Yellows && _grid[_column+1, _row-1, 0] == Yellows && _grid[_column , _row, 0] == Yellows)
                        {
                                if (Freepl == false)
                                {
                                    object[] objCollection = new object[lstplayerYellow.Items.Count];
                            lstplayerYellow.Items.CopyTo(objCollection, 0);
                            lstplayerYellow.Items.Clear();
                            lstplayerYellow.Items.AddRange(build.ScoreFill(objCollection, n));
                            }
                            MessageBox.Show("Yellow Wins");
                                    Gameover = true;
                                }
                        else if (_row>2&&_column>2&& _grid[_column-3, _row-3, 0] == Yellows && _grid[_column-2, _row-2, 0] == Yellows && _grid[_column-1, _row-1, 0] == Yellows && _grid[_column, _row, 0] == Yellows || _column>1&&_row>1&& _grid[_column-2, _row-2, 0] == Yellows && _grid[_column-1, _row-1, 0] == Yellows && _grid[_column+1, _row+1, 0] == Yellows && _grid[_column, _row, 0] == Yellows || _column>0&&_row>0&& _grid[_column-1, _row-1, 0] == Yellows && _grid[_column+2, _row+2, 0] == Yellows && _grid[_column+1, _row+1, 0] == Yellows && _grid[_column, _row, 0] == Yellows || _grid[_column+3, _row+3, 0] == Yellows && _grid[_column+2, _row+2, 0] == Yellows && _grid[_column+1, _row+1, 0] == Yellows && _grid[_column, _row, 0] == Yellows)
                        {
                                    if (Freepl == false)
                                    {
                                        object[] objCollection = new object[lstplayerYellow.Items.Count];
                            lstplayerYellow.Items.CopyTo(objCollection, 0);
                            lstplayerYellow.Items.Clear();
                            lstplayerYellow.Items.AddRange(build.ScoreFill(objCollection, n));
                            }
                            MessageBox.Show("Yellow Wins");
                                    Gameover = true;
                                }

                    }
                    else if (_grid[_column, _row, 0] != Yellows&& player == false)// Red Turn
                    {
                        Pic.BackgroundImage = Red;
                        _grid[_column, _row, 0] = Reds;
                        Pic.BackgroundImageLayout = ImageLayout.Zoom;
                        
                        Bt.BackgroundImage = null;
                        _grid[_columns, _rows, 0] = Button;
                        Bt.BackgroundImageLayout = ImageLayout.Zoom;
                        if (_row < _rows && _grid[_column, _row + 3, 0] == Reds && _grid[_column, _row + 1, 0] == Reds && _grid[_column, _row + 2, 0] == Reds && _grid[_column, _row, 0] == Reds)
                        {
                                        if (Freepl == false)
                                        {
                                            object[] objCollection = new object[lstplayerRed.Items.Count];
                            lstplayerRed.Items.CopyTo(objCollection, 0);
                            lstplayerRed.Items.Clear();
                            lstplayerRed.Items.AddRange(build.ScoreFill2(objCollection, n2));
                            }
                            MessageBox.Show("Red Wins");
                                    Gameover = true;
                                }
                        else if (_column > 2 && _grid[_column - 1, _row, 0] == Reds && _grid[_column - 2, _row, 0] == Reds && _grid[_column - 3, _row, 0] == Reds && _grid[_column, _row, 0] == Reds || _column > 1 && _grid[_column - 2, _row, 0] == Reds && _grid[_column - 1, _row, 0] == Reds && _grid[_column + 1, _row, 0] == Reds && _grid[_column, _row, 0] == Reds || _column > 0 && _grid[_column - 1, _row, 0] == Reds && _grid[_column + 2, _row, 0] == Reds && _grid[_column + 1, _row, 0] == Reds && _grid[_column, _row, 0] == Reds || _grid[_column + 3, _row, 0] == Reds && _grid[_column + 2, _row, 0] == Reds && _grid[_column, _row, 0] == Reds && _grid[_column + 1, _row, 0] == Reds)
                        {
                                            if (Freepl == false)
                                            {
                                                object[] objCollection = new object[lstplayerRed.Items.Count];
                            lstplayerRed.Items.CopyTo(objCollection, 0);
                            lstplayerRed.Items.Clear();
                            lstplayerRed.Items.AddRange(build.ScoreFill2(objCollection, n2));
                            }
                            MessageBox.Show("Red Wins");
                                    Gameover = true;
                                }
                        else if (_column > 2 && _grid[_column - 3, _row + 3, 0] == Reds && _grid[_column - 2, _row + 2, 0] == Reds && _grid[_column - 1, _row + 1, 0] == Reds && _grid[_column, _row, 0] == Reds || _row > 0 && _column > 1 && _grid[_column - 1, _row + 1, 0] == Reds && _grid[_column - 2, _row + 2, 0] == Reds && _grid[_column + 1, _row - 1, 0] == Reds && _grid[_column, _row, 0] == Reds || _row > 1 && _column > 0 && _grid[_column - 1, _row + 1, 0] == Reds && _grid[_column + 1, _row - 1, 0] == Reds && _grid[_column + 2, _row - 2, 0] == Reds && _grid[_column, _row, 0] == Reds || _row > 2 && _grid[_column + 3, _row - 3, 0] == Reds && _grid[_column + 2, _row - 2, 0] == Reds && _grid[_column + 1, _row - 1, 0] == Reds && _grid[_column, _row, 0] == Reds)
                        {
                                                if (Freepl == false)
                                                {
                                                    object[] objCollection = new object[lstplayerRed.Items.Count];
                            lstplayerRed.Items.CopyTo(objCollection, 0);
                            lstplayerRed.Items.Clear();
                            lstplayerRed.Items.AddRange(build.ScoreFill2(objCollection, n2));
                            }
                            MessageBox.Show("Red Wins");
                                    Gameover = true;
                                }
                        else if (_row > 2 && _column > 2 && _grid[_column - 3, _row - 3, 0] == Reds && _grid[_column - 2, _row - 2, 0] == Reds && _grid[_column - 1, _row - 1, 0] == Reds && _grid[_column, _row, 0] == Reds || _column > 1 && _row > 1 && _grid[_column - 2, _row - 2, 0] == Reds && _grid[_column - 1, _row - 1, 0] == Reds && _grid[_column + 1, _row + 1, 0] == Reds && _grid[_column, _row, 0] == Reds || _column > 0 && _row > 0 && _grid[_column - 1, _row - 1, 0] == Reds && _grid[_column + 2, _row + 2, 0] == Reds && _grid[_column + 1, _row + 1, 0] == Reds && _grid[_column, _row, 0] == Reds || _grid[_column + 3, _row + 3, 0] == Reds && _grid[_column + 2, _row + 2, 0] == Reds && _grid[_column + 1, _row + 1, 0] == Reds && _grid[_column, _row, 0] == Reds)
                        {
                                                    if (Freepl == false)
                                                    {
                                                        object[] objCollection = new object[lstplayerRed.Items.Count];
                            lstplayerRed.Items.CopyTo(objCollection, 0);
                            lstplayerRed.Items.Clear();
                            lstplayerRed.Items.AddRange(build.ScoreFill2(objCollection, n2));
                            }
                            MessageBox.Show("Red Wins");
                                    Gameover = true;
                                }
                    }
                }
                        else if (_grid[0, 0, 0] != Free && _grid[1, 0, 0] != Free && _grid[2, 0, 0] != Free && _grid[3, 0, 0] != Free && _grid[4, 0, 0] != Free && _grid[5, 0, 0] != Free && _grid[6, 0 , 0] != Free)
                        {
                            MessageBox.Show("Niemand Wins");
                            Gameover = true;
                            break;
                        }
                       
                        

            }


                }

            }
            else
            {
                lblGameover.Text = "Spiel ist vorbei";
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            NewplayerFunk startFunktion = new NewplayerFunk();

            lstplayerYellow.Items.Clear();
            lstplayerYellow.Items.AddRange(startFunktion.Fore3(txtboxsearch.Text));
        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            NewplayerFunk startFunktion = new NewplayerFunk();

            lstplayerRed.Items.Clear();
            lstplayerRed.Items.AddRange(startFunktion.Fore3(txtboxsearch2.Text));
        }

        private void btnrang_Click(object sender, EventArgs e)
        {
            frmRanglisteFourWin fnp = new frmRanglisteFourWin();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void lstplayerYellow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Freepl == false && lstplayerRed.Text != lstplayerYellow.Text)
            {
                lstplayerYellow.Enabled = false;
            }
           
        }

        private void lstplayerRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Freepl==false&& lstplayerRed.Text != lstplayerYellow.Text)
            {
                lstplayerRed.Enabled = false;
            }
           
            
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            if (Freepl == false)
            {
                Freepl = true;
            }
            else if (Freepl == true)
            {
                Freepl = false;
            }
           
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < 7; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 7; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmFourWin fnp = new frmFourWin();
            Hide();
            fnp.ShowDialog();
            Close();

            // lstMember.Items.AddRange(startFunktion.Fore());






        }
    }
}
