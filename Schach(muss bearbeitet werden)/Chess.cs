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
    public partial class frmChess : Form
    {
        private PictureBox parentBoardPictureBox = new PictureBox();
        private int _row;
        private int _column;
        private int _rows;
        
        private int _columns;
        private int _rowss;

        private int _columnss;
        private string Nameplay;
        private string NameBlock;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;
        public static readonly PictureBox[][] DrawnBoard = new PictureBox[size][];
        public const int size = 8;
        private int _inputhight;
        private int _inputwidth;
        private Image Save;
        private string Saved = "Empty";
         //   private const int CellSize = 10;
        private static int depth = 6;
       // public static List<Figure> Figures = new List<Figure>();
        private static readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Besetzt = "Busy";
        private const string Play = "Play";
        int l = 1;
        int r = 1;
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
        private bool Playing= true;
        public frmChess()
        {
            InitializeComponent();
           
        }
        private void btnSize_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out _inputwidth))//Entnimmt den Wert aus txtwidth und setzt ihn in _inputRow
            {


                if (int.TryParse(txtSize.Text, out _inputhight))//Entnimmt den Wert aus txtheight und setzt ihn in _inputColumn
                {
                    if (_inputwidth < 50)
                    {
                        _inputwidth = 50;
                      
                        _inputhight = 50;
                        lblturn.Text = "Feld zu Klein grösse auf 50 geändert, Weiss ist dran";
                    }
                    if (_inputwidth > 100)
                    {
                        _inputwidth = 100;
                        _inputhight = 100;
                        lblturn.Text = "Feld zu Gross grösse auf 100 geändert, Weiss ist dran";
                    }


                    panMain.Size = new Size(_inputhight * 8, _inputwidth * 8);
                    
                    for ( _column = 0; _column < 8; _column++)// Generiert die Zellen der Spalten
                    {
                        for ( _row = 0; _row < 8; _row++)// Generiert die Zellen der Reihen
                        {

                            GenerateGrid();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                        }
                        r++;
                    }

                    //  DrawBoard();
                    //  DrawLines();
                    // LoadAllFigures();
                   // lblturn.Text = "Weiss ist dran";
                }
            }
            #region Pic Defin

           
            foreach (PictureBox panel in panMain.Controls)
            {

                _row = panel.Top / _inputhight;// Fängt Wegen Top oben an
                _column = panel.Left / _inputwidth;
                if (_column==0 && _row==0 || _column == 7 && _row == 0)
                {
                   
                    panel.BackgroundImage = BlackTower;
                    panel.BackgroundImageLayout= ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;

                    //panel.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else if (_column == 1 && _row == 0 || _column == 6 && _row == 0)
                {
                    panel.BackgroundImage = BlackKnight;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 2 && _row == 0 || _column == 5 && _row == 0)
                {
                    panel.BackgroundImage = BlackBishop;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 3 && _row == 0 )
                {
                    panel.BackgroundImage = BlackQueen;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 4 && _row == 0)
                {
                    panel.BackgroundImage = BlackKing;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if( _row == 1 )
                {

                    panel.BackgroundImage = BlakePawn;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                    //panel.SizeMode = PictureBoxSizeMode.Zoom;

                }

                else if(_column == 0 && _row == 7 || _column == 7 && _row == 7)
                {

                    panel.BackgroundImage = WhiteTower;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                    //panel.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else if (_column == 1 && _row == 7 || _column == 6 && _row == 7)
                {
                    panel.BackgroundImage = WhiteKnight;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 2 && _row == 7 || _column == 5 && _row == 7)
                {
                    panel.BackgroundImage = WhiteBishop;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 3 && _row == 7)
                {
                    panel.BackgroundImage = WhiteQueen;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_column == 4 && _row == 7)
                {
                    panel.BackgroundImage = WhiteKing;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                }
                else if (_row == 6)
                {

                    panel.BackgroundImage = WhitePawn;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Besetzt;
                    //panel.SizeMode = PictureBoxSizeMode.Zoom;

                }
                else
                {
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    _grid[_column, _row, 0] = Free;
                }



            }
            #endregion
        }
        private void GenerateGrid()
        {
            
            PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = _inputhight,
                Width = _inputwidth,
               // SizeMode = PictureBoxSizeMode.StretchImage,
            BorderStyle = BorderStyle.FixedSingle
            };
            if (l%2==0 )
            {
                if (r % 2 == 0)
                {
                    panel.BackColor = Color.White;
                    
                    l++;
                }
                else
                {
                    panel.BackColor = Color.Black;
                    l++;
                }
                
                
            }
            else if (l % 2 == 1  )
            {
                if (r % 2 == 1)
                {
                   
                    panel.BackColor = Color.White;

                    l++;
                }
                else
                {
                    panel.BackColor = Color.Black;
                    l++;
                }
            }
            _grid[_column, _row, 0] = Free;
            //Definiert das die Zellen Tot sind am anfang
            panel.Click += panel_Click;


            panel.Location = new Point(_row * _inputhight, _column * _inputwidth);
            panMain.Controls.Add(panel);
        }
        bool WhiteKingmove = false;
        bool WhiteKingmover = false;
        bool WhiteKingmoveL = false;
        bool BlackKingmove = false;
        bool BlackKingmover = false;
        bool BlackKingmoveL = false;
        bool Turn = false;
         
        private void panel_Click(object sender, EventArgs e)
        {
            if (Playing == true)
            {


                PictureBox panel = ((PictureBox)sender);
                _row = panel.Top / _inputhight;// Fängt Wegen Top oben an
                _column = panel.Left / _inputwidth;
                Nameplay = panel.Name;

                #region Green Tile


                if (panel.BackgroundImage == null)
                {
                    if (panel.BackColor == Color.Green || panel.BackColor == Color.GreenYellow)
                    {

                        if (Turn == false && Save == WhitePawn && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteBishop && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKing && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKnight && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteTower && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = true;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Schwarz ist dran";

                        }
                        else if (panel.BackColor == Color.GreenYellow)
                        {

                            panel.BackgroundImage = Save;
                        }

                        if (Turn == true && Save == BlakePawn && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackBishop && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKing && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKnight && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackTower && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = false;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Weiss ist dran";
                        }



                        if (Save == WhiteKing && _row != 7 || Save == WhiteKing && _column != 4)
                        {
                            WhiteKingmove = true;
                        }
                        if (Save == BlackKing && _row != 0 || Save == BlackKing && _column != 4)
                        {
                            BlackKingmove = true;
                        }

                        Save = null;
                        _grid[_column, _row, 0] = Besetzt;
                        Saved = "Empty";

                        //int la = _rows;
                        //int ra = _columns;

                        foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                        {
                            _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                            _columns = thispanel.Left / _inputwidth;


                            if (thispanel.BackColor == Color.Green || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.GreenYellow)
                            {

                                //Kopiert erste Farbe
                                if (_rows % 2 == 0)
                                {
                                    if (_columns % 2 == 0)
                                    {
                                        thispanel.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        thispanel.BackColor = Color.Black;

                                    }
                                }
                                else if (_rows % 2 == 1)
                                {
                                    if (_columns % 2 == 1)
                                    {


                                        thispanel.BackColor = Color.White;



                                    }
                                    else
                                    {

                                        thispanel.BackColor = Color.Black;
                                    }


                                }
                            }
                            if (panel.BackgroundImage == WhitePawn && _row == 0)
                            {
                                panel.BackgroundImage = null;
                                if (cboumwandelung.SelectedText == "Queen")
                                {
                                    panel.BackgroundImage = WhiteQueen;
                                }
                                if (cboumwandelung.SelectedText == "Tower")
                                {
                                    panel.BackgroundImage = WhiteTower;
                                }
                                if (cboumwandelung.SelectedText == "Bishop")
                                {
                                    panel.BackgroundImage = WhiteBishop;
                                }
                                if (cboumwandelung.SelectedText == "Knight")
                                {
                                    panel.BackgroundImage = WhiteKnight;
                                }

                            }
                            if (panel.BackgroundImage == BlakePawn && _row == 7)
                            {
                                panel.BackgroundImage = null;
                                if (cboumwandelung.SelectedText == "Queen")
                                {
                                    panel.BackgroundImage = BlackQueen;
                                }
                                if (cboumwandelung.SelectedText == "Tower")
                                {
                                    panel.BackgroundImage = BlackTower;
                                }
                                if (cboumwandelung.SelectedText == "Bishop")
                                {
                                    panel.BackgroundImage = BlackBishop;
                                }
                                if (cboumwandelung.SelectedText == "Knight")
                                {
                                    panel.BackgroundImage = BlackKnight;
                                }

                            }

                        }
                    }
                    else if (panel.BackColor == Color.Blue)
                    {


                        if (Turn == false && Save == WhitePawn && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteBishop && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKing && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKnight && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteTower && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = true;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Schwarz ist dran";

                        }
                        else if (panel.BackColor == Color.GreenYellow)
                        {
                            panel.BackgroundImage = Save;

                        }

                        if (Turn == true && Save == BlakePawn && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackBishop && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKing && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKnight && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackTower && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = false;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Weiss ist dran";
                        }



                        Save = null;
                        _grid[_column, _row, 0] = Besetzt;
                        Saved = "Empty";

                        //int la = _rows;
                        //int ra = _columns;

                        foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                        {
                            _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                            _columns = thispanel.Left / _inputwidth;


                            if (thispanel.BackColor == Color.Green || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.Blue || panel.BackgroundImage == WhiteKing || panel.BackgroundImage == BlackKing)
                            {

                                if (_rows == 7 && _columns == 5 && _grid[5, 7, 0] == Free && _grid[6, 7, 0] == Besetzt && panel.BackgroundImage == WhiteKing)
                                {
                                    thispanel.BackgroundImage = WhiteTower;
                                    _grid[_columns, _rows, 0] = Besetzt;
                                    thispanel.BackColor = Color.White;
                                    WhiteKingmover = true;
                                }
                                if (_rows == 7 && _columns == 7 && thispanel.BackgroundImage == WhiteTower && _grid[6, 7, 0] == Besetzt && WhiteKingmover == true && panel.BackgroundImage == WhiteKing)
                                {
                                    thispanel.BackgroundImage = null;
                                    _grid[_columns, _rows, 0] = Free;
                                    WhiteKingmover = false;

                                }
                                if (_rows == 7 && _columns == 3 && _grid[3, 7, 0] == Free && _grid[2, 7, 0] == Besetzt && panel.BackgroundImage == WhiteKing)
                                {
                                    thispanel.BackgroundImage = WhiteTower;
                                    _grid[_columns, _rows, 0] = Besetzt;
                                    thispanel.BackColor = Color.White;

                                }
                                if (_rows == 7 && _columns == 0 && thispanel.BackgroundImage == WhiteTower && _grid[2, 7, 0] == Besetzt && WhiteKingmoveL != true & _column < 3 && panel.BackgroundImage == WhiteKing)
                                {
                                    thispanel.BackgroundImage = null;
                                    _grid[_columns, _rows, 0] = Free;
                                    WhiteKingmoveL = true;

                                }
                                //Black
                                if (_rows == 0 && _columns == 5 && _grid[5, 0, 0] == Free && _grid[6, 0, 0] == Besetzt && panel.BackgroundImage == BlackKing)
                                {
                                    thispanel.BackgroundImage = BlackTower;
                                    _grid[_columns, _rows, 0] = Besetzt;
                                    thispanel.BackColor = Color.Black;
                                    BlackKingmover = true;
                                }
                                if (_rows == 0 && _columns == 7 && thispanel.BackgroundImage == BlackTower && _grid[6, 0, 0] == Besetzt && BlackKingmover == true && panel.BackgroundImage == BlackKing)
                                {
                                    thispanel.BackgroundImage = null;
                                    _grid[_columns, _rows, 0] = Free;
                                    WhiteKingmover = false;

                                }
                                if (_rows == 0 && _columns == 3 && _grid[3, 0, 0] == Free && _grid[2, 0, 0] == Besetzt && panel.BackgroundImage == BlackKing)
                                {
                                    thispanel.BackgroundImage = BlackTower;
                                    _grid[_columns, _rows, 0] = Besetzt;
                                    thispanel.BackColor = Color.Black;

                                }
                                if (_rows == 0 && _columns == 0 && thispanel.BackgroundImage == BlackTower && _grid[2, 0, 0] == Besetzt && BlackKingmoveL != true & _column < 3 && panel.BackgroundImage == BlackKing)
                                {
                                    thispanel.BackgroundImage = null;
                                    _grid[_columns, _rows, 0] = Free;
                                    BlackKingmoveL = true;

                                }



                                //Kopiert erste Farbe
                                else if (_rows % 2 == 0)
                                {
                                    if (_columns % 2 == 0)
                                    {
                                        thispanel.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        thispanel.BackColor = Color.Black;

                                    }
                                }
                                else if (_rows % 2 == 1)
                                {
                                    if (_columns % 2 == 1)
                                    {


                                        thispanel.BackColor = Color.White;



                                    }
                                    else
                                    {

                                        thispanel.BackColor = Color.Black;
                                    }


                                }
                            }
                        }
                    }

                }
                #endregion

                #region Enemy Tile


                else if (panel.BackgroundImage != null && Saved == "Full")
                {
                    if (panel.BackColor == Color.Red)
                    {
                        panel.BackgroundImage = null;
                        if (Turn == false && Save == WhitePawn && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteBishop && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKing && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteKnight && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteTower && panel.BackColor != Color.GreenYellow || Turn == false && Save == WhiteQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = true;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Schwarz ist dran";

                        }
                        else if (panel.BackColor == Color.GreenYellow)
                        {

                            panel.BackgroundImage = Save;
                        }

                        if (Turn == true && Save == BlakePawn && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackBishop && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKing && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackKnight && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackTower && panel.BackColor != Color.GreenYellow || Turn == true && Save == BlackQueen && panel.BackColor != Color.GreenYellow)
                        {

                            Turn = false;
                            panel.BackgroundImage = Save;
                            lblturn.Text = "Weiss ist dran";

                        }
                        _grid[_column, _row, 0] = Besetzt;
                        Save = null;
                        Saved = "Empty";

                        //int la = _rows;
                        //int ra = _columns;

                        foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                        {
                            _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                            _columns = thispanel.Left / _inputwidth;



                            if (thispanel.BackColor == Color.Green || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.GreenYellow)
                            {

                                //Kopiert erste Farbe
                                if (_rows % 2 == 0)
                                {
                                    if (_columns % 2 == 0)
                                    {
                                        thispanel.BackColor = Color.White;
                                    }
                                    else
                                    {
                                        thispanel.BackColor = Color.Black;

                                    }
                                }
                                else if (_rows % 2 == 1)
                                {
                                    if (_columns % 2 == 1)
                                    {


                                        thispanel.BackColor = Color.White;



                                    }
                                    else
                                    {

                                        thispanel.BackColor = Color.Black;
                                    }


                                }
                            }
                        }
                    }
                }
                #endregion
                else if (Saved == "Empty")
                {

                    {



                        _grid[_column, _row, 0] = Free;
                        //White
                        //Pawn
                        #region White Pawn


                        if (panel.BackgroundImage == WhitePawn && Turn == false)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                NameBlock = thispanel.Name;
                                if (_row - 2 == _rows && _column == _columns && _row == 6 && thispanel.BackgroundImage == null || _row - 1 == _rows && _column == _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {

                                    if (_grid[_columns, _rows + 1, 0] == Free && _row == 6 || _column == _columns && _row == _rows)
                                    {
                                        thispanel.BackColor = Color.Green;

                                        Save = panel.BackgroundImage;


                                    }

                                    else if (_row != 6)
                                    {
                                        thispanel.BackColor = Color.Green;

                                        Save = panel.BackgroundImage;

                                    }
                                    if (_column == _columns && _row == _rows)
                                    {

                                        thispanel.BackColor = Color.GreenYellow;

                                        Save = panel.BackgroundImage;


                                    }


                                }

                                if (_row - 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null)
                                {
                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                    {
                                        thispanel.BackColor = Color.Red;
                                        panel.BackColor = Color.GreenYellow;

                                        Save = panel.BackgroundImage;
                                    }
                                }

                            }
                        }
                        #endregion
                        #region WhiteTower


                        if (panel.BackgroundImage == WhiteTower && Turn == false)
                        {





                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                NameBlock = thispanel.Name;
                                int pl = 0;
                                #region White Tower Move
                                if (_column == _columns && thispanel.BackgroundImage == null || _row == _rows && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    if (_rows < _row && _column == _columns)
                                    {
                                        for (int l = 0; l <= _row - _rows; l++)
                                        {


                                            if (_grid[_columns, _rows + l, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _row + 1 - _rows && l == _row - _rows)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                }
                                            }
                                            else
                                            {


                                            }

                                        }
                                    }
                                    else if (_rows > _row && _column == _columns)
                                    {
                                        for (int s = 0; s < _rows - _row; s++)
                                        {
                                            if (_grid[_columns, _rows - s, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _rows - _row && s + 1 == _rows - _row)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (_grid[_columns, _rows - s, 0] == Besetzt)
                                            {

                                                break;
                                            }

                                        }
                                    }
                                    if (_column == _columns && _row == _rows)
                                    {

                                        thispanel.BackColor = Color.Green;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;


                                    }
                                    else if (_rows == _row && _column < _columns)
                                    {
                                        for (int s = 0; s < _columns - _column; s++)
                                        {
                                            if (_grid[_columns - s, _rows, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _columns - _column && s + 1 == _columns - _column)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (_grid[_columns - s, _rows, 0] == Besetzt)
                                            {

                                                break;
                                            }


                                            //  }
                                        }
                                    }
                                    else if (_rows == _row && _column > _columns)
                                    {
                                        for (int l = 0; l <= _column - _columns; l++)
                                        {



                                            if (_grid[_columns + l, _rows, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _column + 1 - _columns && l == _column - _columns)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else
                                            {


                                            }


                                        }
                                    }


                                }
                                #endregion
                                #region White Tower Kill
                                if (_column == _columns && thispanel.BackgroundImage != null || _row == _rows && thispanel.BackgroundImage != null)
                                {
                                    if (_rows < _row && _column == _columns)
                                    {
                                        for (int l = 0; l <= _row - _rows; l++)
                                        {
                                            //       for (int p = 1; p < _row; p++)
                                            // {

                                            // _grid[_column, _row - p, 0] == Besetzt &&

                                            // && _grid[_columns, _rows + l + 1, 0] == Free
                                            if (_grid[_columns, _rows + l, 0] == Besetzt)
                                            {
                                                pl++;



                                            }
                                            if (pl == 1 && l == _row - _rows)
                                            {
                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                {
                                                    if (thispanel.BackgroundImage == BlackKing)
                                                    {
                                                        thispanel.BackColor = Color.Chocolate;
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }


                                                }
                                            }
                                            else if (pl > 1)

                                            {
                                                break;
                                            }



                                            //  }
                                        }
                                    }
                                    else if (_rows > _row && _column == _columns)
                                    {
                                        for (int s = 0; s < _rows - _row; s++)
                                        {
                                            if (_grid[_columns, _rows - s, 0] == Besetzt)
                                            {
                                                pl++;


                                            }
                                            if (pl == 1 && s + 1 == _rows - _row)
                                            {
                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                {
                                                    if (thispanel.BackgroundImage == BlackKing)
                                                    {
                                                        thispanel.BackColor = Color.Chocolate;
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }

                                                }
                                            }
                                            else if (pl > 1)
                                            {
                                                break;
                                            }


                                        }
                                    }
                                    else if (_rows == _row && _column == _columns)
                                    {
                                        if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                        {
                                            if (thispanel.BackgroundImage == BlackKing)
                                            {
                                                thispanel.BackColor = Color.Chocolate;
                                            }
                                            else
                                            {
                                                thispanel.BackColor = Color.Red;
                                                Save = panel.BackgroundImage;
                                            }
                                        }
                                    }
                                    else if (_rows == _row && _column < _columns)
                                    {
                                        for (int s = 0; s < _columns - _column; s++)
                                        {
                                            if (_grid[_columns - s, _rows, 0] == Besetzt && _grid[_columns - s - 1, _rows, 0] == Free)
                                            {


                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                {
                                                    if (thispanel.BackgroundImage == BlackKing)
                                                    {
                                                        thispanel.BackColor = Color.Chocolate;
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                break;
                                            }




                                        }
                                    }

                                    else if (_rows == _row && _column > _columns)
                                    {
                                        for (int l = 0; l <= _column - _columns; l++)
                                        {
                                            //       for (int p = 1; p < _row; p++)
                                            // {

                                            // _grid[_column, _row - p, 0] == Besetzt &&


                                            if (_grid[_columns + l, _rows, 0] == Besetzt && _grid[_columns + l + 1, _rows, 0] == Free)
                                            {


                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                {
                                                    if (thispanel.BackgroundImage == BlackKing)
                                                    {
                                                        thispanel.BackColor = Color.Chocolate;
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                break;
                                            }
                                            //  }
                                        }
                                    }




                                }
                            }
                        }
                        #endregion
                        #endregion
                        #region White Bishop


                        if (panel.BackgroundImage == WhiteBishop && Turn == false)
                        {




                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                NameBlock = thispanel.Name;
                                int pl = 0;
                                #region White Bishop Move


                                if (_row != _rows && _column < _columns && thispanel.BackgroundImage == null || _row != _rows && _column > _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    #region White Bishop White


                                    if (thispanel.BackColor == Color.White)
                                    {
                                        if (_rows % 2 == 0)
                                        {
                                            if (_columns % 2 == 0)
                                            {

                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {

                                                            //up right
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }

                                                }

                                            }
                                        }
                                        else if (_rows % 2 == 1)
                                        {
                                            if (_columns % 2 == 1)
                                            {
                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }


                                                }
                                            }
                                        }
                                    }
                                    #endregion
                                    #region White Bishop Black


                                    else if (thispanel.BackColor == Color.Black)
                                    {
                                        if (_rows % 2 == 1)
                                        {
                                            if (_columns % 2 == 0)
                                            {

                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }


                                                }
                                            }
                                        }
                                        else if (_rows % 2 == 0)
                                        {
                                            if (_columns % 2 == 1)
                                            {
                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {

                                                            //up right
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                            }
                                        }
                                    }


                                    #endregion
                                }

                                #endregion



                                if (_row != _rows && _column < _columns && thispanel.BackgroundImage != null || _row != _rows && _column > _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)

                                {
                                    #region White Bishop White 2
                                    //  if (panel.BackColor == Color.White|| panel.BackColor == Color.Green)
                                    //    {
                                    if (_rows % 2 == 0)
                                    {
                                        if (_columns % 2 == 0)
                                        {

                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {

                                                        //up right
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }


                                            }
                                        }

                                    }
                                    else if (_rows % 2 == 1)
                                    {
                                        if (_columns % 2 == 1)
                                        {
                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }

                                            }
                                        }


                                    }
                                    //}
                                    #endregion
                                    #region White Bishop Black2


                                    //  else if (panel.BackColor == Color.Black || panel.BackColor == Color.Green)
                                    //   {
                                    if (_rows % 2 == 1)
                                    {
                                        if (_columns % 2 == 0)
                                        {

                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }


                                            }
                                        }
                                    }
                                    else if (_rows % 2 == 0)
                                    {
                                        if (_columns % 2 == 1)
                                        {
                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {

                                                        //up right
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    //  }



                                    #endregion
                                }


                            }
                        }


                        #endregion
                        #region WhiteKing


                        if (panel.BackgroundImage == WhiteKing && Turn == false)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                NameBlock = thispanel.Name;
                                int Que = 0;
                                int Bish = 0;
                                int Paw = 0;
                                int King = 0;
                                int Tow = 0;
                                int Kgh = 0;
                                int Blo = 0;
                                int SBlo = 0;
                                if (_row - 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column == _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    foreach (PictureBox thispanels in panMain.Controls)
                                    {
                                        _rowss = thispanels.Top / _inputhight;// Fängt Wegen Top oben an
                                        _columnss = thispanels.Left / _inputwidth;
                                        NameBlock = thispanel.Name;
                                        if (thispanels.BackgroundImage == BlackQueen && _columns == _columnss||thispanels.BackgroundImage == BlackQueen && _rows == _rowss || thispanels.BackgroundImage == BlackQueen && _rows + _columns == _columnss + _rowss || thispanels.BackgroundImage == BlackQueen && _rowss == _rows - _columns + _columnss)
                                        {
                                            Que = Que + 1;
                                            Blo = 0;
                                            SBlo = 0;
                                        }
                                        if (thispanels.BackgroundImage == BlackTower && _columns == _columnss || thispanels.BackgroundImage == BlackTower && _rows == _rowss)
                                        {
                                            Tow = Tow + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == BlakePawn && _columns+1 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == BlakePawn && _columns -1 == _columnss && _rows - 1 == _rowss)
                                        {
                                            Paw = Paw + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == BlackKing && _columns - 1 == _columnss && _rows  == _rowss || thispanels.BackgroundImage == BlackKing && _columns + 1 == _columnss && _rows  == _rowss || thispanels.BackgroundImage == BlackKing && _columns == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == BlackKing && _columns -1 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == BlackKing && _columns + 1 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == BlackKing && _columns + 1 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == BlackKing && _columns - 1 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == BlackKing && _columns == _columnss && _rows - 1 == _rowss)
                                        {
                                            King = King + 1;
                                            Blo = 0;
                                        }
                                        if ( thispanels.BackgroundImage == BlackKnight && _columns - 1 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns + 1 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns - 2 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns - 2 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns + 2 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns + 2 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns - 1 == _columnss && _rows - 2 == _rowss || thispanels.BackgroundImage == BlackKnight && _columns + 1 == _columnss && _rows - 2 == _rowss )
                                        {
                                            Kgh = Kgh + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == BlackBishop && _rowss == _rows - _columns + _columnss || thispanels.BackgroundImage == BlackBishop && _rows + _columns == _columnss + _rowss)
                                        {
                                            Bish = Bish + 1;
                                            SBlo = 0;

                                        }
                                        if (thispanels.BackgroundImage != WhiteKing && thispanels.BackgroundImage != null && thispanels.BackgroundImage != BlackQueen && _columns == _columnss  && _rowss < _row && thispanels.BackgroundImage != BlackTower||thispanels.BackgroundImage != null && thispanels.BackgroundImage != BlackQueen && _column > _columnss && _rowss == _rows && thispanels.BackgroundImage != BlackTower)
                                        {
                                            Blo = Blo + 1;
                                            Que = 0;
                                            Tow= 0;
                                        }
                                        if (thispanels.BackgroundImage != null && thispanels.BackgroundImage != BlackQueen && _rows + _columns == _columnss + _rowss  && _rowss < _row && thispanels.BackgroundImage != BlackBishop|| thispanels.BackgroundImage != null && thispanels.BackgroundImage != BlackQueen && _rowss == _rows - _columns + _columnss && _rowss < _row && thispanels.BackgroundImage != BlackBishop)
                                        {
                                            SBlo = SBlo + 1;

                                        }
                                        if (King == 0 && Kgh == 0 && Paw ==0&&Bish == 0 && Que == 0 && Tow == 0 && _rows + _columns == _columnss + _rowss || King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _rowss == _rows - _columns + _columnss || King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _rowss == _rows || SBlo >= 1 && Blo >= 1 && _rowss == _rows|| King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _columnss == _columns || SBlo >= 1 &&Blo >= 1 && _columnss == _columns)
                                        {
                                            thispanel.BackColor = Color.Green;
                                            Save = panel.BackgroundImage;
                                        }else
                                        if (King >= 1 && _columns -1== _columnss && _rows == _rowss || King >= 1 && _columns+1 == _columnss && _rows == _rowss || King >= 1 && _columns-1 == _columnss && _rows + 1 == _rowss || King >= 1 && _columns+1 == _columnss && _rows + 1 == _rowss || King >= 1 && _columns == _columnss && _rows + 1 == _rowss || King >= 1 && _columns  == _columnss && _rows - 1 == _rowss || King >= 1 && _columns + 1 == _columnss && _rows - 1 == _rowss || King >= 1 && _columns - 1 == _columnss && _rows - 1 == _rowss||Kgh >= 1 && _columns - 2 == _columnss && _rows + 1 == _rowss || Kgh >= 1 && _columns - 2 == _columnss && _rows - 1 == _rowss || Kgh >= 1 && _columns + 2 == _columnss && _rows + 1 == _rowss || Kgh >= 1 && _columns + 2 == _columnss && _rows - 1 == _rowss || Kgh >= 1 && _columns + 1 == _columnss && _rows - 2 == _rowss || Kgh >= 1 && _columns - 1 == _columnss && _rows - 2 == _rowss || Kgh >= 1 && _columns + 1 == _columnss && _rows + 2 == _rowss || Kgh >= 1 && _columns - 1 == _columnss && _rows + 2 == _rowss || Paw >= 1 && _columns +1== _columnss && _rows - 1 == _rowss || Paw >= 1 && _columns -1== _columnss && _rows - 1 == _rowss || Blo == 0 && SBlo == 0 && Que >= 1 && _rows + _columns == _columnss + _rowss || Blo == 0 && SBlo == 0 && Que >= 1 && _rowss == _rows - _columns + _columnss || Blo == 0 && Que >= 1 && _columns == _columnss || Blo == 0 && Tow >= 1 && _columns == _columnss||Blo == 0 && Que >= 1 && _rows == _rowss || Blo == 0 && Tow >= 1 && _rows == _rowss || SBlo == 0 && Blo == 0 && Bish >= 1 && _rowss == _rows - _columns + _columnss || SBlo == 0 && Blo == 0 && Bish >= 1 && _rows + _columns == _columnss + _rowss)
                                        {
                                            if (_rows % 2 == 0)
                                            {
                                                if (_columns % 2 == 0)
                                                {
                                                    thispanel.BackColor = Color.White;
                                                }
                                                else
                                                {
                                                    thispanel.BackColor = Color.Black;

                                                }
                                            }
                                            else if (_rows % 2 == 1)
                                            {
                                                if (_columns % 2 == 1)
                                                {


                                                    thispanel.BackColor = Color.White;



                                                }
                                                else
                                                {

                                                    thispanel.BackColor = Color.Black;
                                                }


                                            }
                                            // thispanels.BackColor = Color.Pink;
                                        }


                                    }

                                    panel.BackColor = Color.GreenYellow;
                                    Save = panel.BackgroundImage;
                                }
                                if (_row - 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column == _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                    {
                                        thispanel.BackColor = Color.Red;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                                if (_row == 7 && _column == 4 && WhiteKingmove == false)
                                {
                                    if (_rows == 7 && _columns == 6 && _grid[5, 7, 0] == Free && _grid[6, 7, 0] == Free && _grid[7, 7, 0] == Besetzt || _rows == 7 && _columns == 2 && _grid[3, 7, 0] == Free && _grid[1, 7, 0] == Free && _grid[2, 7, 0] == Free && _grid[0, 7, 0] == Besetzt)
                                    {
                                        thispanel.BackColor = Color.Blue;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;
                                    }
                                }

                            }
                            


                        }
                        #endregion
                        #region WhiteKight


                        if (panel.BackgroundImage == WhiteKnight && Turn == false)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                if (_row - 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage == null || _row + 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row - 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row - 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    thispanel.BackColor = Color.Green;
                                    panel.BackColor = Color.GreenYellow;
                                    Save = panel.BackgroundImage;
                                }
                                if (_row - 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage != null || _row + 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row - 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row - 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                    {
                                        if (thispanel.BackgroundImage == BlackKing)
                                        {
                                            thispanel.BackColor = Color.Chocolate;
                                        }
                                        else
                                        {
                                            thispanel.BackColor = Color.Red;
                                            Save = panel.BackgroundImage;
                                        }

                                    }
                                }
                            }
                        }
                        #endregion
                        #region WhiteQueen


                        if (panel.BackgroundImage == WhiteQueen && Turn == false)
                        {


                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                int pl = 0;


                                #region White Queen Move


                                if (_column <= _columns && thispanel.BackgroundImage == null || _column >= _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {

                                    if (_rows == _row - _column + _columns || _row + _column == _columns + _rows || _column == _columns && thispanel.BackgroundImage == null || _row == _rows && thispanel.BackgroundImage == null)
                                    {
                                        #region White Queen Move Tower
                                        if (_rows < _row && _column == _columns)
                                        {
                                            for (int l = 0; l <= _row - _rows; l++)
                                            {
                                                //       for (int p = 1; p < _row; p++)
                                                // {

                                                // _grid[_column, _row - p, 0] == Besetzt &&


                                                if (_grid[_columns, _rows + l, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else
                                                {


                                                }

                                                //  }
                                            }
                                        }
                                        else if (_rows > _row && _column == _columns)
                                        {
                                            for (int s = 0; s < _rows - _row; s++)
                                            {
                                                if (_grid[_columns, _rows - s, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _rows - _row && s + 1 == _rows - _row)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else if (_grid[_columns, _rows - s, 0] == Besetzt)
                                                {

                                                    break;
                                                }

                                            }
                                        }

                                        else if (_rows == _row && _column < _columns)
                                        {
                                            for (int s = 0; s < _columns - _column; s++)
                                            {
                                                if (_grid[_columns - s, _rows, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _columns - _column && s + 1 == _columns - _column)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else if (_grid[_columns - s, _rows, 0] == Besetzt)
                                                {

                                                    break;
                                                }


                                                //  }
                                            }
                                        }
                                        else if (_rows == _row && _column > _columns)
                                        {
                                            for (int l = 0; l <= _column - _columns; l++)
                                            {
                                                //       for (int p = 1; p < _row; p++)
                                                // {

                                                // _grid[_column, _row - p, 0] == Besetzt &&


                                                if (_grid[_columns + l, _rows, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _column + 1 - _columns && l == _column - _columns)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else
                                                {


                                                }

                                                //  }
                                            }
                                        }
                                        #endregion



                                        else
                                        {
                                            #region White Queen White Bishop
                                            if (thispanel.BackColor == Color.White)
                                            {
                                                if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }

                                                        }

                                                    }
                                                }
                                                else if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }


                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            #region White Queen Black Bishop


                                            if (thispanel.BackColor == Color.Black)
                                            {
                                                if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }


                                                        }
                                                    }
                                                }
                                                else if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion

                                        }

                                    }

                                }
                                #endregion


                                #region White Queen Kill
                                if (_column <= _columns && thispanel.BackgroundImage != null || _column >= _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    #region White Queen Kill Tower
                                    if (_rows == _row - _column + _columns || _row + _column == _columns + _rows || _column == _columns && thispanel.BackgroundImage != null || _row == _rows && thispanel.BackgroundImage != null)
                                    {
                                        if (_rows < _row && _column == _columns)
                                        {
                                            for (int l = 0; l <= _row - _rows; l++)
                                            {
                                                //       for (int p = 1; p < _row; p++)
                                                // {

                                                // _grid[_column, _row - p, 0] == Besetzt &&

                                                // && _grid[_columns, _rows + l + 1, 0] == Free
                                                if (_grid[_columns, _rows + l, 0] == Besetzt)
                                                {
                                                    pl++;



                                                }
                                                if (pl == 1 && l == _row - _rows)
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;

                                                    }
                                                }
                                                else if (pl > 1)

                                                {
                                                    break;
                                                }



                                                //  }
                                            }
                                        }
                                        else if (_rows > _row && _column == _columns)
                                        {
                                            for (int s = 0; s < _rows - _row; s++)
                                            {
                                                if (_grid[_columns, _rows - s, 0] == Besetzt)
                                                {
                                                    pl++;


                                                }
                                                if (pl == 1 && s + 1 == _rows - _row)
                                                {
                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;

                                                    }
                                                }
                                                else if (pl > 1)
                                                {
                                                    break;
                                                }


                                            }
                                        }
                                        else if (_rows == _row && _column == _columns)
                                        {
                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                            {
                                                thispanel.BackColor = Color.Red;
                                                Save = panel.BackgroundImage;
                                            }
                                        }
                                        else if (_rows == _row && _column < _columns)
                                        {
                                            for (int s = 0; s < _columns - _column; s++)
                                            {
                                                if (_grid[_columns - s, _rows, 0] == Besetzt && _grid[_columns - s - 1, _rows, 0] == Free)
                                                {


                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }

                                                }
                                                else
                                                {
                                                    break;
                                                }




                                            }
                                        }

                                        else if (_rows == _row && _column > _columns)
                                        {
                                            for (int l = 0; l <= _column - _columns; l++)
                                            {


                                                if (_grid[_columns + l, _rows, 0] == Besetzt && _grid[_columns + l + 1, _rows, 0] == Free)
                                                {


                                                    if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }

                                                }
                                                else
                                                {
                                                    break;
                                                }

                                            }
                                            #endregion
                                        }
                                        else
                                        {
                                            #region White Queen White Bishop2


                                            if (panel.BackColor == Color.White || panel.BackColor == Color.Green)
                                            {
                                                if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }


                                                        }
                                                    }
                                                }
                                                else if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }

                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            #region White Queen Black 2


                                            if (panel.BackColor == Color.Black || panel.BackColor == Color.Green)
                                            {
                                                if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }


                                                        }
                                                    }
                                                }
                                                else if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _row - _rows)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            pl++;

                                                                        }
                                                                        if (pl == 1 && l == _rows - _row)
                                                                        {
                                                                            if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                            {
                                                                                thispanel.BackColor = Color.Red;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (pl > 1)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (thispanel.BackgroundImage != WhiteBishop && thispanel.BackgroundImage != WhiteKing && thispanel.BackgroundImage != WhiteKnight && thispanel.BackgroundImage != WhitePawn && thispanel.BackgroundImage != WhiteQueen && thispanel.BackgroundImage != WhiteTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion

                                        }
                                    }

                                }
                                #endregion

                            }
                        }
                        #endregion
                        //Black
                        #region Black Pawn


                        if (panel.BackgroundImage == BlakePawn && Turn == true)
                        {




                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                if (_row + 2 == _rows && _column == _columns && _row == 1 || _row + 1 == _rows && _column == _columns || _column == _columns && _row == _rows)
                                {

                                    if (_grid[_columns, _rows - 1, 0] == Free && _row == 1 && _grid[_columns, _rows, 0] != Besetzt || _column == _columns && _row == _rows)
                                    {
                                        thispanel.BackColor = Color.Green;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;
                                    }
                                    else if (_row != 1)
                                    {
                                        thispanel.BackColor = Color.Green;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                                if (_row + 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null)
                                {
                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                    {
                                        thispanel.BackColor = Color.Red;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                            }
                        }
                        #endregion
                        #region Black Tower


                        if (panel.BackgroundImage == BlackTower && Turn == true)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                NameBlock = thispanel.Name;
                                int pl = 0;
                                #region Black Tower Move


                                if (_column == _columns && thispanel.BackgroundImage == null || _row == _rows && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    if (_rows < _row && _column == _columns)
                                    {
                                        for (int l = 0; l <= _row - _rows; l++)
                                        {


                                            if (_grid[_columns, _rows + l, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _row + 1 - _rows && l == _row - _rows)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else
                                            {


                                            }

                                        }
                                    }
                                    else if (_rows > _row && _column == _columns)
                                    {
                                        for (int s = 0; s < _rows - _row; s++)
                                        {
                                            if (_grid[_columns, _rows - s, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _rows - _row && s + 1 == _rows - _row)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (_grid[_columns, _rows - s, 0] == Besetzt)
                                            {

                                                break;
                                            }

                                        }
                                    }
                                    else if (_rows == _row && _column == _columns)
                                    {
                                        thispanel.BackColor = Color.Green;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;
                                    }
                                    else if (_rows == _row && _column < _columns)
                                    {
                                        for (int s = 0; s < _columns - _column; s++)
                                        {
                                            if (_grid[_columns - s, _rows, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _columns - _column && s + 1 == _columns - _column)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (_grid[_columns - s, _rows, 0] == Besetzt)
                                            {

                                                break;
                                            }


                                            //  }
                                        }
                                    }
                                    else if (_rows == _row && _column > _columns)
                                    {
                                        for (int l = 0; l <= _column - _columns; l++)
                                        {



                                            if (_grid[_columns + l, _rows, 0] == Free)
                                            {
                                                pl++;
                                                if (pl == _column + 1 - _columns && l == _column - _columns)
                                                {

                                                    thispanel.BackColor = Color.Green;
                                                    panel.BackColor = Color.GreenYellow;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else
                                            {


                                            }


                                        }
                                    }


                                }
                                #endregion
                                #region Black Tower Kill


                                if (_column == _columns && thispanel.BackgroundImage != null || _row == _rows && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    if (_rows < _row && _column == _columns)
                                    {
                                        for (int l = 0; l <= _row - _rows; l++)
                                        {
                                            //       for (int p = 1; p < _row; p++)
                                            // {

                                            // _grid[_column, _row - p, 0] == Besetzt &&

                                            // && _grid[_columns, _rows + l + 1, 0] == Free
                                            if (_grid[_columns, _rows + l, 0] == Besetzt)
                                            {
                                                pl++;



                                            }
                                            if (pl == 1 && l == _row - _rows)
                                            {
                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                {
                                                    thispanel.BackColor = Color.Red;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (pl > 1)

                                            {
                                                break;
                                            }



                                            //  }
                                        }
                                    }
                                    else if (_rows > _row && _column == _columns)
                                    {
                                        for (int s = 0; s < _rows - _row; s++)
                                        {
                                            if (_grid[_columns, _rows - s, 0] == Besetzt)
                                            {
                                                pl++;


                                            }
                                            if (pl == 1 && s + 1 == _rows - _row)
                                            {
                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                {
                                                    thispanel.BackColor = Color.Red;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (pl > 1)
                                            {
                                                break;
                                            }


                                        }
                                    }
                                    else if (_rows == _row && _column == _columns)
                                    {
                                        if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                        {
                                            thispanel.BackColor = Color.Red;
                                            Save = panel.BackgroundImage;
                                        }
                                    }
                                    else if (_rows == _row && _column < _columns)
                                    {
                                        for (int s = 0; s < _columns - _column; s++)
                                        {
                                            if (_grid[_columns - s, _rows, 0] == Besetzt && _grid[_columns - s - 1, _rows, 0] == Free)
                                            {


                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                {
                                                    thispanel.BackColor = Color.Red;
                                                    Save = panel.BackgroundImage;
                                                }

                                            }
                                            else
                                            {
                                                break;
                                            }




                                        }
                                    }

                                    else if (_rows == _row && _column > _columns)
                                    {
                                        for (int l = 0; l <= _column - _columns; l++)
                                        {
                                            //       for (int p = 1; p < _row; p++)
                                            // {

                                            // _grid[_column, _row - p, 0] == Besetzt &&


                                            if (_grid[_columns + l, _rows, 0] == Besetzt && _grid[_columns + l + 1, _rows, 0] == Free)
                                            {


                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                {
                                                    thispanel.BackColor = Color.Red;
                                                    Save = panel.BackgroundImage;
                                                }

                                            }
                                            else
                                            {
                                                break;
                                            }
                                            //  }
                                        }
                                    }



                                }
                            }
                        }
                        #endregion
                        #endregion
                        #region Black Bishop


                        if (panel.BackgroundImage == BlackBishop && Turn == true)
                        {




                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                int pl = 0;

                                if (_row != _rows && _column < _columns && thispanel.BackgroundImage == null || _row != _rows && _column > _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    #region Black Bishop White


                                    if (thispanel.BackColor == Color.White)
                                    {
                                        if (_rows % 2 == 0)
                                        {
                                            if (_columns % 2 == 0)
                                            {

                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {

                                                            //up right
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }

                                                }

                                            }
                                        }
                                        else if (_rows % 2 == 1)
                                        {
                                            if (_columns % 2 == 1)
                                            {
                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }


                                                }
                                            }
                                        }
                                    }
                                    #endregion
                                    #region Black Bishop Black


                                    if (thispanel.BackColor == Color.Black)
                                    {
                                        if (_rows % 2 == 1)
                                        {
                                            if (_columns % 2 == 0)
                                            {

                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }


                                                }
                                            }
                                        }
                                        else if (_rows % 2 == 0)
                                        {
                                            if (_columns % 2 == 1)
                                            {
                                                if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                {
                                                    if (_column > _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {

                                                            //up right
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else if (_column < _columns)
                                                    {
                                                        if (_row > _rows)
                                                        {
                                                            for (int l = 0; l <= _row - _rows; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                        else if (_row < _rows)
                                                        {
                                                            for (int l = 0; l <= _rows - _row; l++)
                                                            {
                                                                if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                {
                                                                    pl++;
                                                                    if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                    {
                                                                        thispanel.BackColor = Color.Green;
                                                                        panel.BackColor = Color.GreenYellow;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                                else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                {
                                                                    break;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                            }
                                        }




                                    }


                                    #endregion
                                }

                                if (_row != _rows && _column < _columns && thispanel.BackgroundImage != null || _row != _rows && _column > _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    #region Black Bishop White2


                                    //          if (panel.BackColor == Color.White || panel.BackColor == Color.Green)
                                    //        {
                                    if (_rows % 2 == 0)
                                    {
                                        if (_columns % 2 == 0)
                                        {

                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {

                                                        //up right
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }


                                            }
                                        }

                                    }
                                    else if (_rows % 2 == 1)
                                    {
                                        if (_columns % 2 == 1)
                                        {
                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }

                                            }
                                        }


                                    }
                                    //           }
                                    #endregion
                                    #region Black Bishop Black 2


                                    //   else if (panel.BackColor == Color.Black || panel.BackColor == Color.Green)
                                    //  {
                                    if (_rows % 2 == 1)
                                    {
                                        if (_columns % 2 == 0)
                                        {

                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }


                                            }
                                        }
                                    }
                                    else if (_rows % 2 == 0)
                                    {
                                        if (_columns % 2 == 1)
                                        {
                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                            {
                                                if (_column > _columns)
                                                {
                                                    if (_row > _rows)
                                                    {

                                                        //up right
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else if (_column < _columns)
                                                {
                                                    if (_row > _rows)
                                                    {
                                                        for (int l = 0; l <= _row - _rows; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _row - _rows)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                    else if (_row < _rows)
                                                    {
                                                        for (int l = 0; l <= _rows - _row; l++)
                                                        {
                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                            {
                                                                pl++;

                                                            }
                                                            if (pl == 1 && l == _rows - _row)
                                                            {
                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                {
                                                                    thispanel.BackColor = Color.Red;
                                                                    Save = panel.BackgroundImage;
                                                                }
                                                            }
                                                            else if (pl > 1)
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                    {
                                                        thispanel.BackColor = Color.Red;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                            }
                                            //     }
                                        }
                                    }

                                    #endregion


                                }
                            }
                        }
                        #endregion
                        #region BlackKing


                        if (panel.BackgroundImage == BlackKing && Turn == true)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                int Que = 0;
                                int Bish = 0;
                                int Paw = 0;
                                int Tow = 0;
                                int Kgh = 0;
                                int Blo = 0;
                                int SBlo = 0;
                                int King = 0;
                                if (_row - 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column == _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    foreach (PictureBox thispanels in panMain.Controls)
                                    {
                                        _rowss = thispanels.Top / _inputhight;// Fängt Wegen Top oben an
                                        _columnss = thispanels.Left / _inputwidth;
                                        NameBlock = thispanel.Name;
                                        if (thispanels.BackgroundImage == WhiteQueen && _columns == _columnss || thispanels.BackgroundImage == WhiteQueen && _rows == _rowss  || thispanels.BackgroundImage == WhiteQueen && _rows + _columns == _columnss + _rowss || thispanels.BackgroundImage == WhiteQueen && _rowss == _rows - _columns + _columnss)
                                        {
                                            Que = Que + 1;
                                           Blo = 0;
                                            SBlo = 0;
                                        }
                                        if (thispanels.BackgroundImage == WhiteTower && _columns == _columnss || thispanels.BackgroundImage == WhiteTower && _rows == _rowss)
                                        {
                                            Tow = Tow + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == WhitePawn && _columns + 1 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == WhitePawn && _columns - 1 == _columnss && _rows + 1 == _rowss)
                                        {
                                            Paw = Paw + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == WhiteKnight && _columns - 1 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns + 1 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns - 2 == _columnss && _rows + 2 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns - 2 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns + 2 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns + 2 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns - 1 == _columnss && _rows - 2 == _rowss || thispanels.BackgroundImage == WhiteKnight && _columns + 1 == _columnss && _rows - 2 == _rowss)
                                        {
                                            Kgh = Kgh + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage == WhiteBishop && _rowss == _rows - _columns + _columnss || thispanels.BackgroundImage == WhiteBishop && _rows + _columns == _columnss + _rowss)
                                        {
                                            Bish = Bish + 1;
                                            SBlo = 0;

                                        }
                                        if (thispanels.BackgroundImage == WhiteKing && _columns - 1 == _columnss && _rows == _rowss || thispanels.BackgroundImage == WhiteKing && _columns + 1 == _columnss && _rows == _rowss || thispanels.BackgroundImage == WhiteKing && _columns == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == WhiteKing && _columns - 1 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == WhiteKing && _columns + 1 == _columnss && _rows + 1 == _rowss || thispanels.BackgroundImage == WhiteKing && _columns + 1 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == WhiteKing && _columns - 1 == _columnss && _rows - 1 == _rowss || thispanels.BackgroundImage == WhiteKing && _columns == _columnss && _rows - 1 == _rowss)
                                        {
                                            King = King + 1;
                                            Blo = 0;
                                        }
                                        if (thispanels.BackgroundImage != BlackKing && thispanels.BackgroundImage != null && thispanels.BackgroundImage != WhiteQueen && _columns == _columnss && Que >= 1 && _rowss > _row && thispanels.BackgroundImage != WhiteTower || thispanels.BackgroundImage != null && thispanels.BackgroundImage != WhiteQueen && _column > _columnss && Que == 1 && _rowss == _rows && thispanels.BackgroundImage != WhiteTower)
                                        {
                                            Blo = Blo + 1;

                                        }
                                        if (thispanels.BackgroundImage != null && thispanels.BackgroundImage != WhiteQueen && _rows + _columns == _columnss + _rowss && Que >= 1 && _rowss < _row && thispanels.BackgroundImage != WhiteBishop || thispanels.BackgroundImage != null && thispanels.BackgroundImage != WhiteQueen && _rowss == _rows - _columns + _columnss && Que >= 1 && _rowss < _row && thispanels.BackgroundImage != WhiteBishop)
                                        {
                                            SBlo = SBlo + 1;

                                        }
                                        if (King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _rows + _columns == _columnss + _rowss || King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _rowss == _rows - _columns + _columnss || King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _rowss == _rows || SBlo >= 1 && Blo >= 1 && _rowss == _rows || King == 0 && Kgh == 0 && Paw == 0 && Bish == 0 && Que == 0 && Tow == 0 && _columnss == _columns || SBlo >= 1 && Blo >= 1 && _columnss == _columns)
                                        {
                                            thispanel.BackColor = Color.Green;
                                            Save = panel.BackgroundImage;
                                        }
                                        else
                                         if (King >= 1 && _columns - 1 == _columnss && _rows == _rowss || King >= 1 && _columns + 1 == _columnss && _rows == _rowss || King >= 1 && _columns - 1 == _columnss && _rows + 1 == _rowss || King >= 1 && _columns + 1 == _columnss && _rows + 1 == _rowss || King >= 1 && _columns == _columnss && _rows + 1 == _rowss || King >= 1 && _columns == _columnss && _rows - 1 == _rowss || King >= 1 && _columns + 1 == _columnss && _rows - 1 == _rowss || King >= 1 && _columns - 1 == _columnss && _rows - 1 == _rowss || Kgh >= 1 && _columns - 2 == _columnss && _rows + 1 == _rowss || Kgh >= 1 && _columns - 2 == _columnss && _rows - 1 == _rowss || Kgh >= 1 && _columns + 2 == _columnss && _rows + 1 == _rowss || Kgh >= 1 && _columns + 2 == _columnss && _rows - 1 == _rowss || Kgh >= 1 && _columns + 1 == _columnss && _rows - 2 == _rowss || Kgh >= 1 && _columns - 1 == _columnss && _rows - 2 == _rowss || Kgh >= 1 && _columns + 1 == _columnss && _rows + 2 == _rowss || Kgh >= 1 && _columns - 1 == _columnss && _rows + 2 == _rowss || Paw >= 1 && _columns + 1 == _columnss && _rows + 1 == _rowss || Paw >= 1 && _columns - 1 == _columnss && _rows + 1 == _rowss || Blo == 0 && SBlo == 0 && Que >= 1 && _rows + _columns == _columnss + _rowss || Blo == 0 && SBlo == 0 && Que >= 1 && _rowss == _rows - _columns + _columnss || Blo == 0 && Que >= 1 && _columns == _columnss || Blo == 0 && Tow >= 1 && _columns == _columnss || Blo == 0 && Que >= 1 && _rows == _rowss || Blo == 0 && Tow >= 1 && _rows == _rowss || SBlo == 0 && Blo == 0 && Bish >= 1 && _rowss == _rows - _columns + _columnss || SBlo == 0 && Blo == 0 && Bish >= 1 && _rows + _columns == _columnss + _rowss)
                                        {
                                            if (_rows % 2 == 0)
                                            {
                                                if (_columns % 2 == 0)
                                                {
                                                    thispanel.BackColor = Color.White;
                                                }
                                                else
                                                {
                                                    thispanel.BackColor = Color.Black;

                                                }
                                            }
                                            else if (_rows % 2 == 1)
                                            {
                                                if (_columns % 2 == 1)
                                                {


                                                    thispanel.BackColor = Color.White;



                                                }
                                                else
                                                {

                                                    thispanel.BackColor = Color.Black;
                                                }


                                            }
                                            // thispanels.BackColor = Color.Pink;
                                        }


                                    }

                                    panel.BackColor = Color.GreenYellow;
                                    Save = panel.BackgroundImage;
                                }
                                if (_row - 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column == _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                    {
                                        thispanel.BackColor = Color.Red;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                                if (_row == 0 && _column == 4 && BlackKingmove == false)
                                {
                                    if (_rows == 0 && _columns == 6 && _grid[5, 0, 0] == Free && _grid[6, 0, 0] == Free && _grid[7, 0, 0] == Besetzt || _rows == 0 && _columns == 2 && _grid[3, 0, 0] == Free && _grid[1, 0, 0] == Free && _grid[2, 0, 0] == Free && _grid[0, 0, 0] == Besetzt)
                                    {
                                        thispanel.BackColor = Color.Blue;
                                        panel.BackColor = Color.GreenYellow;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                            }
                        }
                        #endregion
                        #region Blackknight


                        if (panel.BackgroundImage == BlackKnight && Turn == true)
                        {



                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                if (_row - 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage == null || _row - 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage == null || _row + 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage == null || _row + 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row + 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _row - 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage == null || _row - 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {
                                    thispanel.BackColor = Color.Green;
                                    panel.BackColor = Color.GreenYellow;
                                    Save = panel.BackgroundImage;
                                }
                                if (_row - 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage != null || _row - 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column - 2 == _columns && thispanel.BackgroundImage != null || _row + 1 == _rows && _column + 2 == _columns && thispanel.BackgroundImage != null || _row + 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row + 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _row - 2 == _rows && _column + 1 == _columns && thispanel.BackgroundImage != null || _row - 2 == _rows && _column - 1 == _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {
                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                    {
                                        thispanel.BackColor = Color.Red;
                                        Save = panel.BackgroundImage;
                                    }
                                }
                            }
                        }
                        #endregion
                        #region BlackQueen


                        if (panel.BackgroundImage == BlackQueen && Turn == true)
                        {

                            foreach (PictureBox thispanel in panMain.Controls)//füllt jede einzelne Zelle
                            {
                                _rows = thispanel.Top / _inputhight;// Fängt Wegen Top oben an
                                _columns = thispanel.Left / _inputwidth;
                                int pl = 0;
                                #region Black Queen Move 
                                if (_column <= _columns && thispanel.BackgroundImage == null || _column >= _columns && thispanel.BackgroundImage == null || _column == _columns && _row == _rows)
                                {

                                    if (_rows == _row - _column + _columns || _row + _column == _columns + _rows || _column == _columns && thispanel.BackgroundImage == null || _row == _rows && thispanel.BackgroundImage == null)
                                    {



                                        #region Black Queen Tower


                                        if (_rows < _row && _column == _columns)
                                        {
                                            for (int l = 0; l <= _row - _rows; l++)
                                            {
                                                //       for (int p = 1; p < _row; p++)
                                                // {

                                                // _grid[_column, _row - p, 0] == Besetzt &&


                                                if (_grid[_columns, _rows + l, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _row + 1 - _rows && l == _row - _rows)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else
                                                {


                                                }

                                                //  }
                                            }
                                        }
                                        else if (_rows > _row && _column == _columns)
                                        {
                                            for (int s = 0; s < _rows - _row; s++)
                                            {
                                                if (_grid[_columns, _rows - s, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _rows - _row && s + 1 == _rows - _row)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else if (_grid[_columns, _rows - s, 0] == Besetzt)
                                                {

                                                    break;
                                                }

                                            }
                                        }
                                        else if (_rows == _row && _column == _columns)
                                        {
                                            thispanel.BackColor = Color.Green;
                                            panel.BackColor = Color.GreenYellow;
                                            Save = panel.BackgroundImage;
                                        }
                                        else if (_rows == _row && _column < _columns)
                                        {
                                            for (int s = 0; s < _columns - _column; s++)
                                            {
                                                if (_grid[_columns - s, _rows, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _columns - _column && s + 1 == _columns - _column)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else if (_grid[_columns - s, _rows, 0] == Besetzt)
                                                {

                                                    break;
                                                }


                                                //  }
                                            }
                                        }
                                        else if (_rows == _row && _column > _columns)
                                        {
                                            for (int l = 0; l <= _column - _columns; l++)
                                            {
                                                //       for (int p = 1; p < _row; p++)
                                                // {

                                                // _grid[_column, _row - p, 0] == Besetzt &&


                                                if (_grid[_columns + l, _rows, 0] == Free)
                                                {
                                                    pl++;
                                                    if (pl == _column + 1 - _columns && l == _column - _columns)
                                                    {

                                                        thispanel.BackColor = Color.Green;
                                                        panel.BackColor = Color.GreenYellow;
                                                        Save = panel.BackgroundImage;
                                                    }
                                                }
                                                else
                                                {


                                                }

                                                //  }
                                            }
                                        }
                                        #endregion
                                        else
                                        {
                                            #region Black Queen White Bishop

                                            if (thispanel.BackColor == Color.White)
                                            {
                                                if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }

                                                        }

                                                    }
                                                }
                                                else if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }


                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                            #region Black Queen Black


                                            if (thispanel.BackColor == Color.Black)
                                            {
                                                if (_rows % 2 == 1)
                                                {
                                                    if (_columns % 2 == 0)
                                                    {

                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }


                                                        }
                                                    }
                                                }
                                                else if (_rows % 2 == 0)
                                                {
                                                    if (_columns % 2 == 1)
                                                    {
                                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                        {
                                                            if (_column > _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {

                                                                    //up right
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns + l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else if (_column < _columns)
                                                            {
                                                                if (_row > _rows)
                                                                {
                                                                    for (int l = 0; l <= _row - _rows; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows + l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _row + 1 - _rows && l == _row - _rows)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                                else if (_row < _rows)
                                                                {
                                                                    for (int l = 0; l <= _rows - _row; l++)
                                                                    {
                                                                        if (_grid[_columns - l, _rows - l, 0] == Free)
                                                                        {
                                                                            pl++;
                                                                            if (pl == _rows + 1 - _row && l == _rows - _row)
                                                                            {
                                                                                thispanel.BackColor = Color.Green;
                                                                                panel.BackColor = Color.GreenYellow;
                                                                                Save = panel.BackgroundImage;
                                                                            }
                                                                        }
                                                                        else if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                        {
                                                                            break;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            else
                                                            {
                                                                thispanel.BackColor = Color.Green;
                                                                panel.BackColor = Color.GreenYellow;
                                                                Save = panel.BackgroundImage;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            #endregion
                                        }

                                    }
                                }
                                #endregion
                                #region Black Queen Kill


                                if (_column <= _columns && thispanel.BackgroundImage != null || _column >= _columns && thispanel.BackgroundImage != null || _column == _columns && _row == _rows)
                                {

                                    if (_rows == _row - _column + _columns || _row + _column == _columns + _rows || _column == _columns && thispanel.BackgroundImage != null || _row == _rows && thispanel.BackgroundImage != null)
                                    {
                                        #region White Queen Kill Tower
                                        if (_rows == _row - _column + _columns || _row + _column == _columns + _rows || _column == _columns && thispanel.BackgroundImage != null || _row == _rows && thispanel.BackgroundImage != null)
                                        {
                                            if (_rows < _row && _column == _columns)
                                            {
                                                for (int l = 0; l <= _row - _rows; l++)
                                                {
                                                    //       for (int p = 1; p < _row; p++)
                                                    // {

                                                    // _grid[_column, _row - p, 0] == Besetzt &&

                                                    // && _grid[_columns, _rows + l + 1, 0] == Free
                                                    if (_grid[_columns, _rows + l, 0] == Besetzt)
                                                    {
                                                        pl++;



                                                    }
                                                    if (pl == 1 && l == _row - _rows)
                                                    {
                                                        if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                        {
                                                            thispanel.BackColor = Color.Red;
                                                            Save = panel.BackgroundImage;
                                                        }
                                                    }
                                                    else if (pl > 1)

                                                    {
                                                        break;
                                                    }



                                                    //  }
                                                }
                                            }
                                            else if (_rows > _row && _column == _columns)
                                            {
                                                for (int s = 0; s < _rows - _row; s++)
                                                {
                                                    if (_grid[_columns, _rows - s, 0] == Besetzt)
                                                    {
                                                        pl++;


                                                    }
                                                    if (pl == 1 && s + 1 == _rows - _row)
                                                    {
                                                        if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                        {
                                                            thispanel.BackColor = Color.Red;
                                                            Save = panel.BackgroundImage;
                                                        }
                                                    }
                                                    else if (pl > 1)
                                                    {
                                                        break;
                                                    }


                                                }
                                            }
                                            else if (_rows == _row && _column == _columns)
                                            {
                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                {
                                                    thispanel.BackColor = Color.Red;
                                                    Save = panel.BackgroundImage;
                                                }
                                            }
                                            else if (_rows == _row && _column < _columns)
                                            {
                                                for (int s = 0; s < _columns - _column; s++)
                                                {
                                                    if (_grid[_columns - s, _rows, 0] == Besetzt && _grid[_columns - s - 1, _rows, 0] == Free)
                                                    {


                                                        if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                        {
                                                            thispanel.BackColor = Color.Red;
                                                            Save = panel.BackgroundImage;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }




                                                }
                                            }

                                            else if (_rows == _row && _column > _columns)
                                            {
                                                for (int l = 0; l <= _column - _columns; l++)
                                                {


                                                    if (_grid[_columns + l, _rows, 0] == Besetzt && _grid[_columns + l + 1, _rows, 0] == Free)
                                                    {


                                                        if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                        {
                                                            thispanel.BackColor = Color.Red;
                                                            Save = panel.BackgroundImage;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }

                                                }
                                                #endregion
                                            }
                                            else
                                            {
                                                #region Black Queen White Bishop2


                                                if (panel.BackColor == Color.White || panel.BackColor == Color.Green)
                                                {
                                                    if (_rows % 2 == 0)
                                                    {
                                                        if (_columns % 2 == 0)
                                                        {

                                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                            {
                                                                if (_column > _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {

                                                                        //up right
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else if (_column < _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                    {
                                                                        thispanel.BackColor = Color.Red;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }


                                                            }
                                                        }
                                                    }
                                                    else if (_rows % 2 == 1)
                                                    {
                                                        if (_columns % 2 == 1)
                                                        {
                                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                            {
                                                                if (_column > _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else if (_column < _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                    {
                                                                        thispanel.BackColor = Color.Red;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }

                                                            }
                                                        }
                                                    }
                                                }
                                                #endregion
                                                #region White Queen Black 2


                                                if (panel.BackColor == Color.Black || panel.BackColor == Color.Green)
                                                {
                                                    if (_rows % 2 == 1)
                                                    {
                                                        if (_columns % 2 == 0)
                                                        {

                                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                            {
                                                                if (_column > _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else if (_column < _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                    {
                                                                        thispanel.BackColor = Color.Red;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }


                                                            }
                                                        }
                                                    }
                                                    else if (_rows % 2 == 0)
                                                    {
                                                        if (_columns % 2 == 1)
                                                        {
                                                            if (_rows == _row - _column + _columns || _row + _column == _columns + _rows)
                                                            {
                                                                if (_column > _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {

                                                                        //up right
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns + l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else if (_column < _columns)
                                                                {
                                                                    if (_row > _rows)
                                                                    {
                                                                        for (int l = 0; l <= _row - _rows; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows + l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _row - _rows)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (_row < _rows)
                                                                    {
                                                                        for (int l = 0; l <= _rows - _row; l++)
                                                                        {
                                                                            if (_grid[_columns - l, _rows - l, 0] == Besetzt)
                                                                            {
                                                                                pl++;

                                                                            }
                                                                            if (pl == 1 && l == _rows - _row)
                                                                            {
                                                                                if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                                {
                                                                                    thispanel.BackColor = Color.Red;
                                                                                    Save = panel.BackgroundImage;
                                                                                }
                                                                            }
                                                                            else if (pl > 1)
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (thispanel.BackgroundImage != BlackBishop && thispanel.BackgroundImage != BlackKing && thispanel.BackgroundImage != BlackKnight && thispanel.BackgroundImage != BlakePawn && thispanel.BackgroundImage != BlackQueen && thispanel.BackgroundImage != BlackTower)
                                                                    {
                                                                        thispanel.BackColor = Color.Red;
                                                                        Save = panel.BackgroundImage;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                #endregion
                                            }

                                        }

                                    }
                                }
                                #endregion
                            }
                        }
                        #endregion
                        //

                        if (Save != null)
                        {
                            panel.BackgroundImage = null;
                            Saved = "Full";
                        }





                    }
                }
            }
            else {
                lblturn.Text = "Spiel ist Vorbei";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmChess_Load(object sender, EventArgs e)
        {

        }

        private void btngiveup_Click(object sender, EventArgs e)
        {
            if (Turn==false)
            {
                lblturn.Text = "Black Wins";
                Playing = false;
            }
            else
            {
                lblturn.Text = "White Wins";
                Playing = false;
            }

        }
    }

}