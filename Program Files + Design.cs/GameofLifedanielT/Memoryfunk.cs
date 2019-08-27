using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class Memoryfunk
    {
        private static string DLTW = Properties.Settings.Default.ConnectionString;
      
        private int _row;
        private int _column;
       
        private const int CellSize = 90;
        private const int MaxRows = 20;
        private const int MaxColumns = 20;

        public const int size = 8;
        int em = 0;
        int Gelb = 0;
        int Rot = 0;
        int wp = 0;
        int wt = 0;
        int wb = 0;
        int wk = 0;
        int wq = 0;
        int Wkn = 0;
        int bp = 0;
        int bk = 0;
        int BQ = 0;
        int BB = 0;
        int Bt = 0;
        int Bkn = 0;
        int bo = 0;
        int Fla = 0;
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        int sixs = 0;
        int seves = 0;
        int eights = 0;
        int Heads = 0;
        int bodi = 0;
        int Ber = 0;
        int Hauss = 0;
        int Trees = 0;
        int clock = 0;
        int se = 0;
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
        Bitmap Body = Properties.Resources.Body;
        Bitmap Berry = Properties.Resources.Berry;
        Bitmap House = Properties.Resources.Haus;
        Bitmap Tree = Properties.Resources.Baum;
        Bitmap Timeclock = Properties.Resources.Sanduhr;
        Bitmap Pyra = Properties.Resources.Secret;
        //   private const int CellSize = 10;
        private static int depth = 2;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string emt = "em";
        private const string Leer = "Leer";
        private const string Yel = "Gelb";
        private const string Ret = "Red";
        private const string WhiteP = "WhitP";
        private const string WhiteT = "WhiteT";
        private const string WhiteB = "WhiteB";
        private const string WhiteK = "WhiteK";
        private const string WhiteQ = "WhiteQ";
        private const string WhiteKn = "WhiteKn";
        private const string BlackP = "BlackP";
        private const string BlackK = "BlackK";
        private const string BlackQ = "BlackQ";
        private const string BlackB = "BlackB";
        private const string BlackT = "BlackT";
        private const string BlackKn = "BlackKn";
        private const string Flagg = "Flagg";
        private const string Bombs = "Bomb";
        private const string oe = "oe";
        private const string tw = "tw";
        private const string th = "th";
        private const string fo = "fo";
        private const string fi = "fi";
        private const string sec = "sec";
        private const string si = "si";
        private const string ac = "ac";
        private const string he = "Head";
        private const string bod = "bod";
        private const string berr = "berr";
        private const string Hausss = "Hausss";
        private const string ba = "ba";
        private const string sand = "sand";
        private const string secr = "secr";
    
        Random rand = new Random();
        public PictureBox GenerateGrid()
        {  
        

        PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,

                BorderStyle = BorderStyle.FixedSingle

            };

            _grid[_column, _row, 0] = emt;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Location = new Point(_row * CellSize, _column * CellSize);
            return panel;
        }
       
     
       
        int num;
        public void  Mixing(Panel panMain, PictureBox panel ,int _rows, int _columns)
        {
            int whi = 0; 

            while (whi<1)
            {

           
            num = rand.Next(0, 800);

                if (num < 200)

                {

                    if (num<100)

                    {
                        if (num < 50)
                        {
                            if (num < 25 && em <= 1)

                            {
                               // panel.BackgroundImage = Empty;
                                _grid[_columns, _rows, 0] = Leer;
                                em++;
                                whi++;
                            }
                            else if (num > 25 && Gelb <= 1)
                            {
                                _grid[_columns, _rows, 0] = Yel;
                                Gelb++;
                                whi++;
                            }
                        }
                        else if (num > 50)
                        {
                            if (num < 75 && Rot <= 1)

                            {
                                _grid[_columns, _rows, 0] = Ret;
                                //panel.BackgroundImage = Red;
                                Rot++;
                                whi++;
                            }
                            else if (num > 75 && wp <= 1)
                            {
                               // panel.BackgroundImage = WhitePawn;
                                _grid[_columns, _rows, 0] = WhiteP;
                                wp++;
                                whi++;
                            }
                        }
                    }
                    else if (num > 100)
                    {
                        if (num < 150)
                        {
                            if (num < 125 && wt <= 1)

                            {
                                //panel.BackgroundImage = WhiteTower;
                                _grid[_columns, _rows, 0] = WhiteT;
                                wt++;
                                whi++;
                            }
                            else if (num > 125 && wb <= 1)
                            {
                                //panel.BackgroundImage = WhiteBishop;
                                _grid[_columns, _rows, 0] = WhiteB;
                                wb++;
                                whi++;
                            }
                        }
                        else if (num > 150)
                        {
                            if (num < 175 && wk <= 1)

                            {
                                _grid[_columns, _rows, 0] = WhiteK;
                               // panel.BackgroundImage = WhiteKing;
                                wk++;
                                whi++;
                            }
                            else if (num > 175 && wq <= 1)
                            {
                                _grid[_columns, _rows, 0] = WhiteQ;
                              //  panel.BackgroundImage = WhiteQueen;
                                wq++;
                                whi++;
                            }
                        }
                    }
                }
                else if (num > 200 && num< 400)
                {
                    if (num < 300)

                    {
                        if (num < 250)
                        {
                            if (num < 225 && Wkn <= 1)

                            {
                                _grid[_columns, _rows, 0] = WhiteKn;
                             //   panel.BackgroundImage = WhiteKnight;
                                Wkn++;
                                whi++;
                            }
                            else if (num > 225 && bp <= 1)
                            {
                                _grid[_columns, _rows, 0] = BlackP;
                               // panel.BackgroundImage = BlakePawn;
                                bp++;
                                whi++;
                            }
                        }
                        else if (num > 250)
                        {
                            if (num < 275 && bk <= 1)

                            {
                                _grid[_columns, _rows, 0] = BlackK;
                               // panel.BackgroundImage = BlackKing;
                                bk++;
                                whi++;
                            }
                            else if (num > 275 && BQ <= 1)
                            {
                                _grid[_columns, _rows, 0] = BlackQ;
                             //   panel.BackgroundImage = BlackQueen;
                                BQ++;
                                whi++;
                            }
                        }
                    }
                    else if (num > 300)
                    {
                        if (num < 350)
                        {
                            if (num < 325 && BB <= 1)

                            {
                                _grid[_columns, _rows, 0] = BlackB;
                               // panel.BackgroundImage = BlackBishop;
                                BB++;
                                whi++;
                            }
                            else if (num > 325 && Bt <= 1)
                            {
                                _grid[_columns, _rows, 0] = BlackT;
                             //   panel.BackgroundImage = BlackTower;
                                Bt++;
                                whi++;
                            }
                        }
                        else if (num > 350)
                        {
                            if (num < 375 && Bkn <= 1)

                            {
                                _grid[_columns, _rows, 0] = BlackKn;
                            //    panel.BackgroundImage = BlackKnight;
                                Bkn++;
                                whi++;
                            }
                            else if (num > 375 && bo <= 1)
                            {
                                _grid[_columns, _rows, 0] = Bombs;
                                //panel.BackgroundImage = Bomb;
                                bo++;
                                whi++;
                            }
                        }
                    }
                }
                else if (num > 400 && num < 600)
                {
                    if (num < 500)

                    {
                        if (num < 450)
                        {
                            if (num < 425 && Fla <= 1)

                            {
                                _grid[_columns, _rows, 0] = Flagg;
                               // panel.BackgroundImage = Flag;
                                Fla++;
                                whi++;
                            }
                            else if (num > 425 && ones <= 1)
                            {
                                _grid[_columns, _rows, 0] = oe;
                              //  panel.BackgroundImage = one;
                                ones++;
                                whi++;
                            }
                        }
                        else if (num > 450)
                        {
                            if (num < 475 && twos <= 1)

                            {
                                _grid[_columns, _rows, 0] = tw;
                               // panel.BackgroundImage = Two;
                                twos++;
                                whi++;
                            }
                            else if (num > 475 && threes <= 1)
                            {
                                _grid[_columns, _rows, 0] = th;
                             //   panel.BackgroundImage = Three;
                                threes++;
                                whi++;
                            }
                        }
                    }
                    else if (num > 500)
                    {
                        if (num < 550)
                        {
                            if (num < 525 && fours <= 1)

                            {
                                _grid[_columns, _rows, 0] = fo;
                              //  panel.BackgroundImage = Four;
                                fours++;
                                whi++;
                            }
                            else if (num > 525 && fives <= 1)
                            {
                                _grid[_columns, _rows, 0] = fi;
                            //    panel.BackgroundImage = Five;
                                fives++;
                                whi++;
                            }
                        }
                        else if (num > 550)
                        {
                            if (num < 575 && sixs <= 1)

                            {
                                _grid[_columns, _rows, 0] = sec;
                               // panel.BackgroundImage = Sechs;
                                sixs++;
                                whi++;
                            }
                            else if (num > 575 && seves <= 1)
                            {
                                _grid[_columns, _rows, 0] = si;
                               // panel.BackgroundImage = Sieben;
                                seves++;
                                whi++;
                            }
                        }
                    }
                }
                else if (num > 600 && num < 900)
                {
                    if (num < 700)

                    {
                        if (num < 650)
                        {
                            if (num < 625 && eights <= 1)

                            {
                                _grid[_columns, _rows, 0] = ac;
                              //  panel.BackgroundImage = Acht;
                                eights++;
                                whi++;
                            }
                            else if (num > 625 && Heads <= 1)
                            {
                                _grid[_columns, _rows, 0] = he;
                              //  panel.BackgroundImage = Head;
                                Heads++;
                                whi++;
                            }
                        }
                        else if (num > 650)
                        {
                            if (num < 675 && bodi <= 1)

                            {
                                _grid[_columns, _rows, 0] = bod;
                              //  panel.BackgroundImage = Body;
                                bodi++;
                                whi++;
                            }
                            else if (num > 675 && Ber <= 1)
                            {
                                _grid[_columns, _rows, 0] = berr;
                               // panel.BackgroundImage = Berry;
                                Ber++;
                                whi++;
                            }
                        }
                    }
                    else if (num > 700)
                    {
                        if (num < 750)
                        {
                            if (num < 725 && Hauss <= 1)

                            {
                                _grid[_columns, _rows, 0] = Hausss;
                             //   panel.BackgroundImage = House;
                                Hauss++;
                                whi++;
                            }
                            else if (num > 725 && Trees <= 1)
                            {
                                _grid[_columns, _rows, 0] = ba;
                            //    panel.BackgroundImage = Tree;
                                Trees++;
                                whi++;
                            }
                        }
                        else if (num > 750)
                        {
                            if (num < 775 && clock <= 1)

                            {
                                _grid[_columns, _rows, 0] = sand;
                               // panel.BackgroundImage = Timeclock;
                                clock++;
                                whi++;
                            }
                            else if (num > 775 && se <= 1)
                            {
                                _grid[_columns, _rows, 0] = secr;
                               // panel.BackgroundImage = Pyra;
                                se++;
                                whi++;
                            }
                        }
                    }
                }
            }

            // return panel;
        }
        // int _rows, int _columns

        public PictureBox Opening(Panel panMain, PictureBox panel,int Rows, int Columns)
        {
            //  PictureBox thispanel = new PictureBox();
            // Rows = thispanel.Location.Y / CellSize; //Position der Zelle in der Y achse
            //  Columns = thispanel.Location.X / CellSize; //Position der Zelle in der X achse
          //  _grid[Columns, Rows, 0] == _grid[_columns, _rows, 0] &&
            if ( _grid[Columns, Rows, 0] ==Leer)
            {
               // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Empty;
            }
            else if (_grid[Columns, Rows, 0] == Yel)
            {
                panel.BackgroundImage = Yellow;
            }
            else if(_grid[Columns, Rows, 0] == Ret)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Red;
            }
            else if (_grid[Columns, Rows, 0] == WhiteP)
            {
                panel.BackgroundImage = WhitePawn;
            }
            else if (_grid[Columns, Rows, 0] == WhiteT)
            {
                panel.BackgroundImage = WhiteTower;
            }
            else if (_grid[Columns, Rows, 0] == WhiteB)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = WhiteBishop;
            }
            else if (_grid[Columns, Rows, 0] == WhiteK)
            {
                panel.BackgroundImage = WhiteKing;
            }
            else if (_grid[Columns, Rows, 0] == WhiteQ)
            {
                panel.BackgroundImage = WhiteQueen;
            }
            else if (_grid[Columns, Rows, 0] == WhiteKn)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = WhiteKnight;
            }
            else if (_grid[Columns, Rows, 0] == BlackP)
            {
                panel.BackgroundImage = BlakePawn;
            }
            else if (_grid[Columns, Rows, 0] == BlackK)
            {
                panel.BackgroundImage = BlackKing;
            }
            else if (_grid[Columns, Rows, 0] == BlackQ)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = BlackQueen;
            }
            else if (_grid[Columns, Rows, 0] == BlackB)
            {
                panel.BackgroundImage = BlackBishop;
            }
            else if (_grid[Columns, Rows, 0] == BlackT)
            {
                panel.BackgroundImage = BlackTower;
            }
            else if (_grid[Columns, Rows, 0] == BlackKn)
            {
                panel.BackgroundImage = BlackKnight;
            }
            else if (_grid[Columns, Rows, 0] == Flagg)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Flag;
            }
            else if (_grid[Columns, Rows, 0] == Bombs)
            {
                panel.BackgroundImage = Bomb;
            }
            else if (_grid[Columns, Rows, 0] == oe)
            {
                panel.BackgroundImage = one;
            }
            else if (_grid[Columns, Rows, 0] == tw)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Two;
            }
            else if (_grid[Columns, Rows, 0] == th)
            {
                panel.BackgroundImage = Three;
            }
            else if (_grid[Columns, Rows, 0] == fo)
            {
                panel.BackgroundImage = Four;
            }
            else if (_grid[Columns, Rows, 0] == fi)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Five;
            }
            else if (_grid[Columns, Rows, 0] == sec)
            {
                panel.BackgroundImage = Sechs;
            }
            else if (_grid[Columns, Rows, 0] == si)
            {
                panel.BackgroundImage = Sieben;
            }
            else if (_grid[Columns, Rows, 0] == ac)
            {
                panel.BackgroundImage = Acht;
            }
            else if (_grid[Columns, Rows, 0] == he)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Head;
            }
            else if (_grid[Columns, Rows, 0] == bod)
            {
                panel.BackgroundImage = Body;
            }
            else if (_grid[Columns, Rows, 0] == berr)
            {
                panel.BackgroundImage = Berry;
            }
            else if (_grid[Columns, Rows, 0] == Hausss )
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = House;
            }
            else if (_grid[Columns, Rows, 0] == ba)
            {
                // thispanel.BackgroundImage = Empty;
                panel.BackgroundImage = Tree;
            }
            else if (_grid[Columns, Rows, 0] == sand)
            {
                panel.BackgroundImage = Timeclock;
            }
            else if (_grid[Columns, Rows, 0] == secr)
            {
                panel.BackgroundImage = Pyra;
            }


            return panel;
        
        
 
    }
}

}
