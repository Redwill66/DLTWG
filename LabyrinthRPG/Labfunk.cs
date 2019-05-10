using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class Labfunk
    {
       
        private const int CellSize = 25;
        private const int MaxRows = 40;
        private const int MaxColumns = 40;
        Bitmap Secret = Properties.Resources.PlayerFig;
        Bitmap Tree = Properties.Resources.Baum1;
        Bitmap grassy = Properties.Resources.Grass0;
        Bitmap Watery = Properties.Resources.Water;
        Bitmap Dornen = Properties.Resources.DornenBush;
        Bitmap Dwalls = Properties.Resources.Dornenwall;
        Bitmap Fischer = Properties.Resources.Fischer;
        Bitmap Soldat = Properties.Resources.Soldat;
        public const int size = 8;


        //   private const int CellSize = 10;
        private static int depth = 4;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Gras = "Gras";
        private const string Wald = "Wald";
        private const string Wall = "Wand";
        private const string Gift = "Gift";
        private const string OTur = "OTur";
        private const string VTur = "VTur";
        private const string Wass = "Wass";
        private const string Keys = "Keys";
        private const string Heal = "Heal";
        private const string Schi = "Schi";
        private const string Haus = "Haus";
        private const string Bomb = "Bomb";
        private const string Rock = "Rock";
        private const string Hinw = "Hinw";
        private const string Star = "Star";
        private const string Ende = "Ende";
        private const string Player = "Player";
        private const string Money = "Money";
        private const string BigMoney = "BigMoney";
        private const string Pers = "Pers";
        private const string Swor = "Swor";
        private const string Kome = "Kome";
        private const string Dorn = "Dorn";
        private const string Dwal = "Dwal";
        private const string Ship = "Ship";
        private const string Cave = "Cave";
        private const string Lmax = "Lmax";
        private const string Bode = "Bode";
        private const string Lava = "Lava";
        private const string Steg = "Steg";
        public PictureBox GenerateGrid(int _row, int _column)
        {
            Panel panMain = new Panel();
            panMain.Size = new Size(CellSize * 40, CellSize * 40);

            PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan"+ _row + _column,
                Height = CellSize,
                Width = CellSize,

                BorderStyle = BorderStyle.FixedSingle

            };
          
            panel.BackColor = Color.LightGreen;
            _grid[_column, _row, 0] = Gras;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.SizeMode = PictureBoxSizeMode.Zoom;
            panel.Location = new Point(_row * CellSize, _column * CellSize);
            return panel;
        }
        int Loot=1;
        int p = 0;
        int c = 0;
       
       
        public PictureBox CreateWorld(PictureBox panel,int _rows, int _columns, int Level)
        {
            if (Level==1)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps();
                   _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                if (_rows == 9 && _columns == 31 || _rows == 12 && _columns == 29 || _rows == 24 && _columns == 21 || _rows == 16 && _columns == 20 || _rows == 28 && _columns == 12 || _rows == 35 && _columns == 5 || _rows ==14 && _columns == 7 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Red;
                }
                if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkGoldenrod;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Orange;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkGreen;
                }
                if (_grid[_columns, _rows, 0] == Wass)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Turquoise;
                }
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.LightGray;
                }
                if (_grid[_columns, _rows, 0] == Star)
                {
                    panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.DeepPink;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkSlateGray;
                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    panel.BackColor = Color.LightGreen;
                    //   panel.BackColor = Color.SaddleBrown;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.OrangeRed;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightSkyBlue;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.LightGreen;
                    //   panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.PaleVioletRed;
                }
                p = 0;
                c = 0;
            }
            if (Level == 2)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps2();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                if (_rows == 16 && _columns == 30 || _rows == 27 && _columns == 27 || _rows == 37 && _columns == 15 || _rows == 28 && _columns == 4 || _rows == 14 && _columns == 8 || _rows == 1 && _columns == 13)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 37 && _columns == 38 || _rows == 36 && _columns == 38)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal && _rows != 14 && _columns != 25)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.Red;
                }
                else if (_grid[_columns, _rows, 0] == Heal && _rows == 14 && _columns == 25)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.DarkGoldenrod;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi && _rows != 13 && _columns != 25)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.Orange;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                else if (_grid[_columns, _rows, 0] == Schi && _rows == 13 && _columns == 25)
                {
                    panel.BackColor = Color.SandyBrown;
                }
               
                if (_grid[_columns, _rows, 0] == Wald && _rows < 16 && _columns < 12)
                {
                   // panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.DarkGreen;
                }
                else if (_grid[_columns, _rows, 0] == Wald && _rows >= 16 && _columns >= 12)

                {
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Wass && _rows < 17 )
                {
                   // panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.Turquoise;
                }
                else if (_grid[_columns, _rows, 0] == Wass && _rows >= 17 )

                {
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.LightGray;
                }
                if (_grid[_columns, _rows, 0] == Star)
                {
                   // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                   // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                     panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkSlateGray;
                    //panel.BackColor = Color.LightSlateGray;
                }
                if (_grid[_columns, _rows, 0] == Haus && _rows<16 && _columns < 12)
                {
                  //  panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.SaddleBrown;
                }
                else if (_grid[_columns, _rows, 0] == Haus && _rows >= 16 && _columns >= 12)
               
                {
                    panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Bomb)
                {
                   panel.BackColor = Color.LightGreen;
                  //    panel.BackColor = Color.OrangeRed;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                   // panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.LightSkyBlue;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Pers && _rows < 16 && _columns < 12)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Pers && _rows == 14 && _columns == 22)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.SandyBrown;
                }

                else if (_grid[_columns, _rows, 0] == Pers && _rows >= 16 && _columns >= 12)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                }
            if (_grid[_columns, _rows, 0] == Swor)
                {
                     panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Orchid;
                }
                if (_grid[_columns, _rows, 0] == Kome)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.LightGray;
                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                    panel.BackColor = Color.LightGreen;
                 //   panel.BackColor = Color.ForestGreen;
                }
                if (_grid[_columns, _rows, 0] == Dwal)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.DarkOliveGreen;
                }
                if (_grid[_columns, _rows, 0] == Ship)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Cave)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkSlateGray;
                }
                if (_grid[_columns, _rows, 0] == Lava)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.IndianRed;
                }
                if (_grid[_columns, _rows, 0] == Lmax)
                {
                     panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //  panel.BackColor = Color.PaleVioletRed;
                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                     panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Steg)
                {
                    panel.BackColor = Color.SandyBrown;

                }
                p = 0;
                c = 0;
            }








            return panel;
        }
        public void Colors(PictureBox panel, int _rows, int _columns,int lvl)
        {

            

            if (_grid[_columns, _rows, 0] == Wall)
            {
                panel.BackColor = Color.Brown;
               
            }
            if (_grid[_columns, _rows, 0] == Heal && panel.BackColor != Color.Red)
            {
                if (lvl ==2 && _columns==38&& _rows==35|| lvl == 2 && _columns == 36 && _rows == 25 || lvl == 2 && _columns == 21 && _rows == 17)
                {
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 2 && _columns == 25 && _rows == 14)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
               
            }
            if (_grid[_columns, _rows, 0] == Keys && panel.BackColor != Color.DarkGoldenrod)
            {
                if (lvl == 2 && _columns == 25 && _rows == 26 )
                {
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 2 && _columns == 25 && _rows == 13)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
            
                //_grid[_columns, _rows, 2] = Loot.ToString();
            }
            if (_grid[_columns, _rows, 0] == Schi && panel.BackColor != Color.Orange)
            {
                if (lvl == 2 && _columns == 38 && _rows == 38|| lvl == 2 && _columns == 37 && _rows == 38)
                {
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
              
              
                //_grid[_columns, _rows, 2] = Loot.ToString();
            }
            if (_grid[_columns, _rows, 0] == Wald)
            {
                panel.BackColor = Color.DarkGreen;
                panel.BackgroundImage = Tree;
            }
            if (_grid[_columns, _rows, 0] == Wass)
            {
                panel.Image = Watery;
                panel.BackColor = Color.Turquoise;
            }
            if (_grid[_columns, _rows, 0] == Hinw)
            {
                panel.BackColor = Color.LightGray;
            }
            if (_grid[_columns, _rows, 0] == Star)
            {
                panel.BackColor = Color.Yellow;
            }
            if (_grid[_columns, _rows, 0] == Ende)
            {
               
                panel.BackColor = Color.DeepPink;
            }
            if (_grid[_columns, _rows, 0] == Gift && panel.BackColor != Color.Purple)
            {
                if (lvl == 2 && _columns > 21 && _rows > 16 )
                {
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
              
               
            }
            if (_grid[_columns, _rows, 0] == Rock)
            {
                
                panel.BackColor = Color.LightSlateGray;
            }
            if (_grid[_columns, _rows, 0] == Haus)
            {
                panel.BackColor = Color.SaddleBrown;
            }
            if (_grid[_columns, _rows, 0] == Bomb && panel.BackColor != Color.OrangeRed)
            {
                if (lvl == 2 && _columns == 37 && _rows == 35)
                {
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
               
              
               // _grid[_columns, _rows, 2] = Loot.ToString();
            }
            if (_grid[_columns, _rows, 0] == OTur)
            {
                panel.BackColor = Color.LightSkyBlue;
            }
            if (_grid[_columns, _rows, 0] == VTur)
            {
                panel.BackColor = Color.DarkBlue;
            }
            if (_grid[_columns, _rows, 0] == Pers)
            {
                if (lvl == 2 && _columns == 13 && _rows == 21 )
                {
                    panel.BackgroundImage = Fischer;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 2 && _columns == 10 && _rows == 5 || lvl == 2 && _columns == 10 && _rows == 8 || lvl == 2 && _columns == 7 && _rows == 14)
                   
                {
                    panel.BackgroundImage = Soldat;
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackColor = Color.LightGray;
                }
                // panel.BackColor = Color.LightGreen;
               
            }
          
            if (_grid[_columns, _rows, 0] == Swor && panel.BackColor != Color.Orchid)
            {
                if (lvl == 2 && _columns == 35 && _rows == 16 || lvl == 2 && _columns == 36 && _rows == 35|| lvl == 2 && _columns == 35 && _rows == 35)
                {
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
              
               
            }
            if (_grid[_columns, _rows, 0] == Kome)
            {
               // panel.BackColor = Color.LightGreen;
                 panel.BackColor = Color.LightGray;
            }
            if (_grid[_columns, _rows, 0] == Dorn)
            {
                //panel.BackColor = Color.LightGreen;
                  panel.BackColor = Color.ForestGreen;
                panel.BackgroundImage = Dornen;
            }
            if (_grid[_columns, _rows, 0] == Dwal)
            {
                //panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkOliveGreen;
                panel.BackgroundImage = Dwalls;
            }
            if (_grid[_columns, _rows, 0] == Ship)
            {
               
                panel.BackColor = Color.Brown;
            }
            if (_grid[_columns, _rows, 0] == Cave)
            {
               // panel.BackColor = Color.LightGreen;
                 panel.BackColor = Color.DarkSlateGray;
            }
            if (_grid[_columns, _rows, 0] == Lava)
            {
               // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.IndianRed;
            }
            if (_grid[_columns, _rows, 0] == Lmax && panel.BackColor != Color.PaleVioletRed)
            {
                if (lvl == 2 && _columns == 35 && _rows == 38 )
                {
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
             
                // panel.BackColor = Color.PaleVioletRed;
            }
            if (_grid[_columns, _rows, 0] == Bode)
            {
              //  panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkGray;
            }
        
            if (_grid[_columns, _rows, 0] == Steg)
            {
                panel.BackColor = Color.SandyBrown;

            }
            if (_grid[_columns, _rows, 0] == Gras)
            {
                panel.BackColor = Color.LightGreen;
                panel.BackgroundImage = grassy;
            }

          



        }
        public PictureBox Starts(PictureBox panel, int _rows, int _columns)
        {
            if (_grid[_columns, _rows, 0] == Star || panel.BackColor == Color.Yellow )
            {
                panel.Image = Secret;
             //   panel.BackgroundImage = Secret;
                _grid[_columns, _rows, 1] = Player;
            }



            return panel;
        }
      
        int empty = 0;
        public PictureBox Down(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss,int schleif,int lvl)
        {
           if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == VTur && Keysss == 0 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Haus || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Rock && Bombs == 0 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Wall || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Wass || _grid[_column, _row , 1] == Player && _grid[_column, _row+1, 0] == Wald)
             {
                if (_grid[_column, _row+1, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row+1, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Cave || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Ship || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Dwal && schleif == 0)
            {
                if (_grid[_column, _row + 1, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                p++;
            }
            if (_row > 0 && _column > 0&& _row < 39 && _column < 39)
            {
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! P bearbeiten
            
            if (_grid[_column+1, _row + 1, 1] == Player || _grid[_column-1, _row + 1, 1] == Player || _grid[_column+1, _row - 1, 1] == Player || _grid[_column-1, _row - 1, 1] == Player || _grid[_column, _row-1, 1] == Player || _grid[_column, _row+1, 1] == Player || _grid[_column-1, _row, 1] == Player || _grid[_column, _row, 1] == Player|| _grid[_column+1, _row, 1] == Player)
            {

                Colors(panel, _row,  _column, lvl);
            }
            }


            // _row < _rows && _column == _columns &&
            if (_row>0&&_row == Rowsd-p+1  )
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null  || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null || _grid[_column, _row-1, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {/*
                    if (_grid[_column, _row, 0] == Rock)
                    {
                        _grid[_column, _row, 0] = Gras;
                        panel.BackColor = Color.LightGreen;
                        Bombs--;
                    }
                    if (_grid[_column, _row, 0] == VTur)
                    {
                        _grid[_column, _row, 0] = OTur;
                        panel.BackColor = Color.LightSkyBlue;
                        Keysss--;
                    }*/
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;



                }
              else  if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
              //  if (ers == true && _grid[_column, _row + 1, 0] == Gras)
              //  {
                //    p++;
                  //  ers = false;
               // }




            }
           else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Lmax || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Ende || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Star || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bomb || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Keys || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == OTur || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Schi || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Heal || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Hinw || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gift || _row > 0 && _row == Rowsd- p && _grid[_column, _row-1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Steg || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Lava || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bode || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Dorn || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Kome || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Swor || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Pers)
            {
                panel.Image = null;
            }
            //if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] != Wald)
           // {
             //   p++;
           // }








            return panel;
        }
        public PictureBox Up(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl)
        {
           
            if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur && Keysss == 0 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock && Bombs == 0 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Wall || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Haus || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Wass || _row < 39 && _grid[_column, _row+1, 1] == Player && _grid[_column, _row , 0] == Wald)
            {
                if (_grid[_column, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Cave || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Ship || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal && schleif == 0 )
            {
                if (_grid[_column, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                p--;
            }
            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl);
                }
            }

            //&& _grid[_column, _row, 0] != Wald
            // _row < _rows && _column == _columns &&
            if (_row > 0 && _row == Rowsd-p - 1 )
            {


                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null || _grid[_column, _row+1, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {
                    /*  if (_grid[_column, _row, 0] == Rock)
                      {
                          _grid[_column, _row, 0] = Gras;
                          panel.BackColor = Color.LightGreen;
                          Bombs--;
                      }
                      if (_grid[_column, _row, 0] == VTur)
                      {
                          _grid[_column, _row, 0] = OTur;
                          panel.BackColor = Color.LightSkyBlue;
                          Keysss--;
                      }*/
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;


                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }



            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Lmax || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Ende || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Star || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bomb || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Keys || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == OTur || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Schi || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Heal || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Hinw || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gift || _row > 0 && _row == Rowsd-p && _grid[_column, _row , 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Steg || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Lava || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bode || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Dorn || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Kome || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Swor || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Pers)
            {
                panel.Image = null;
            }






            return panel;
        }
        public PictureBox Left(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl)
        {
            if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && Keysss == 0 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && Bombs == 0 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Haus || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Wall || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Wass || _column < 39&& _grid[_column+1, _row, 1] == Player && _grid[_column, _row, 0] == Wald)
            {
                if (_grid[_column, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Cave || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Ship || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && schleif == 0 )
            {
                if (_grid[_column, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                c--;
            }
            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl);
                }
            }


            // _row < _rows && _column == _columns &&
            if (_column > 0 && _column == Columnsd - c - 1 )
            {


                if ( _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null||_grid[_column+1, _row , 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {/*
                    if (_grid[_column, _row, 0] == Rock)
                    {
                        _grid[_column, _row, 0] = Gras;
                        panel.BackColor = Color.LightGreen;
                        Bombs--;
                    }
                    if (_grid[_column, _row, 0] == VTur)
                    {
                        _grid[_column, _row, 0] = OTur;
                        panel.BackColor = Color.LightSkyBlue;
                        Keysss--;
                    }*/
                    _grid[_column+1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;


                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 ||_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }



            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Lmax || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Ende || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Star || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bomb || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Keys || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == OTur || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Schi || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Heal || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Hinw || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Gift||_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column-1, _row , 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Steg || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Lava || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bode || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Dorn || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Kome || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Swor || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Pers)
            {
                panel.Image = null;
            }
           






            return panel;
        }
        public PictureBox Right(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl)
        {
        
            if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == VTur && Keysss == 0 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Rock && Bombs == 0 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Haus || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wall || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wass||_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wald)
            {
                if (_grid[_column+1, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column + 1, _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Cave || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Ship || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Dwal && schleif == 0)
            {
                if (_grid[_column + 1, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                c++;
            }
            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl);
                }
            }

            //    Rowsd - p + 1
            // _row < _rows && _column == _columns &&
            if (_column > 0 && _column == Columnsd - c + 1 )
            {


                if ( _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {
                    /*
                    if (_grid[_column, _row, 0] == Rock)
                    {
                        _grid[_column, _row, 0] = Gras;
                        panel.BackColor = Color.LightGreen;
                        Bombs--;
                    }
                    if (_grid[_column, _row, 0] == VTur)
                    {
                        _grid[_column, _row, 0] = OTur;
                        panel.BackColor = Color.LightSkyBlue;
                        Keysss--;
                    }*/
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;


                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }



            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Lmax || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Ende || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Star || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bomb || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Keys || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == OTur || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Schi || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Heal || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Hinw || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gift||_column > 0 && _column == Columnsd - c && _grid[_column-1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Steg || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Lava || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bode || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Dorn || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Kome || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Swor || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Pers)
            {
                panel.Image = null;
            }






            return panel;
        }
      //  int poi = 1;//!!!!
        //int poi2 = 1;
       // int poi3 = 1;
       // int poi4 = 1;
        public int  Poison(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player&& _grid[_column, _row, 0] == Gift  && panel.Image == Secret)
            {
              //  poi++;
               // poi2++;
               // poi3++;
                panel.BackColor = Color.Purple;
                panel.BackgroundImage = null;
                Life--;
            }
            return Life;
        }
        // problem rauf Links runter 2 mal gift aber Tod
        public int Dorne(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == Secret)
            {
                //  poi++;
                // poi2++;
                // poi3++;
                panel.BackColor = Color.ForestGreen;
                panel.BackgroundImage = null;
                Life--;
            }
            return Life;
        }
        public Image Npc(Panel panMain, PictureBox panel, int _row, int _column ,PictureBox npc)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == Secret)
            {
                npc.BackgroundImage = panel.BackgroundImage;

            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] != Pers && panel.Image == Secret)
         
            {
                npc.BackgroundImage = null;
            }
            return npc.BackgroundImage;
        }
        public int Lavama(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == Secret)
            {
                //  poi++;
                // poi2++;
                // poi3++;
                panel.BackColor = Color.IndianRed;
                panel.BackgroundImage = null;
                Life=Life-2;
            }
            return Life;
        }


        public int PoisonSchie(Panel panMain, PictureBox panel, int _row, int _column, int Armor)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == Secret)
            {
                panel.BackColor = Color.Purple;
                panel.BackgroundImage = null;
            //    poi++;
              //  poi3++;
                Armor--;
            }
            return Armor;
        }
     
        int healss = 0;
        public int Heals(Panel panMain, PictureBox panel, int _row, int _column, int Life, int MaxLife)
        {
            
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Heal&& healss==0 && panel.Image == Secret)
            {
                healss++;
                DialogResult dialogResult = MessageBox.Show("Du hast eine Ruhige Lichtung gefunden, willst du Rasten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du füllst dich voller Leben(Leben auf Max)");
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    Life = MaxLife;
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                }
              
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Heal && healss == 1)
            {
                healss--;
            }
           
            return Life;
        }       

        public int Schield(Panel panMain, PictureBox panel, int _row, int _column, int Armor)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Schi&& count==1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Kiste mit Handwerksmaterialen gefunden, willst du deine Rüstung damit verstärken", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du verstärkst deine Rüstung(+1 zu Armor))");
                   
                    panel.BackColor = Color.Orange;
                    panel.BackgroundImage = null;

                    Armor = Armor + count;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Orange;
                    panel.BackgroundImage = null;
                }
             
                
            }
            return Armor;
        }
     
        public int Bomm(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine nicht gezündete Bombe gefunden, willst du sie mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst eine Bombe(+1 zu Bomb))");

                    panel.BackColor = Color.OrangeRed;
                    panel.BackgroundImage = null;
                    Bombs = Bombs + count;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.OrangeRed;
                    panel.BackgroundImage = null;
                }


            }
         
            return Bombs;
        }
       
        public int Keyss(Panel panMain, PictureBox panel, int _row, int _column, int Key)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Keys && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Tasche mit einem Schlüssel gefunden, willst du ihn mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst einen Schlüssek(+1 zu Keys))");

                    Key = Key + count;
                    panel.BackColor = Color.DarkGoldenrod;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.DarkGoldenrod;
                    panel.BackgroundImage = null;
                }


            }
           
            return Key;
        }
        public int Schliefff(Panel panMain, PictureBox panel, int _row, int _column, int schleiffs)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Swor && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast einen Schleifstein gefunden, willst du ihn mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst einen Schleifstein(+1 zu Schleifsteine))");

                    schleiffs = schleiffs + count;
                    panel.BackColor = Color.Orchid;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Orchid;
                    panel.BackgroundImage = null;
                }


            }

            return schleiffs;
        }

        string tip;
        public string hinww(Panel panMain, PictureBox panel, int _row, int _column,int Level)
        {
           
            var count = Convert.ToInt32(_grid[_column, _row, 2]);

            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw&& Level==1)
            {
                if (_row==38&& _column==2 && count==1)
                {
                    MessageBox.Show("Weiter gehen nur auf eigene Gefahr");
                    tip= "Weiter gehen nur auf eigene Gefahr";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 2 && _column == 2 && count == 1 || _row == 3 && _column == 2 && count == 1)
                {
                    MessageBox.Show("2 ist der Sicherste Weg");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "2 ist der Sicherste Weg";
                }
                if (_row == 19 && _column == 19 && count == 1)
                {
                    MessageBox.Show("Geh Kurz aber nicht zu Lang, das Ende wartet am falschen Weg.");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Geh Kurz aber nicht zu Lang, das Ende wartet am falschen Weg.";
                }
                if (_row == 12 && _column == 13 && count == 1|| _row == 13 && _column == 13 && count == 1||_row == 14 && _column == 13 && count == 1)
                {
                    MessageBox.Show("Der Letzte der kommt steht im Mittelpunkt, er geht daher ihnen aus dem Weg.");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Der Letzte der kommt steht im Mittelpunkt, er geht daher ihnen aus dem Weg.";
                }
                if (_row == 1 && _column == 22 && count == 1)
                {
                    MessageBox.Show("Je schneller desto gefährlicher");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Je schneller desto gefährlicher";
                }


            }
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 2)
            {
                if (_row == 34 && _column == 2 && count == 1)
                {
                    MessageBox.Show("Erinnerung Dornen Büsche kannst du zwar sehen, bei durchqueren greiffen sie Leben direkt an");
                    tip = "Erinnerung Dornen Büsche kannst du zwar sehen, bei durchqueren greiffen sie Leben direkt an";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 29 && _column == 14 && count == 1)
                {
                    MessageBox.Show("Mit Schleifsteine kannst du deine Waffe genug Schärfen um Pflanzliche Blockaden zu zerstören");
                    tip = "Mit Schleifsteine kannst du deine Waffe genug Schärfen um Pflanzliche Blockaden zu zerstören";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 31 && _column == 32 && count == 1|| _row == 32 && _column == 32 && count == 1)
                {
                    MessageBox.Show("Lava dieses Vulkanes verursacht den Zweifachen schaden am Leben, Also verlierst du 2 Leben pro Feld das du überquerst ");
                    tip = "Lava dieses Vulkanes verursacht den Zweifachen schaden am Leben, Also verlierst du 2 Leben pro Feld das du überquerst";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 21 && _column == 35 && count == 1 )
                {
                    MessageBox.Show("Vetraue nicht darauf das sich ein Weg Lohnt auch wenn es Beute gibt. Suche am besten Alternativen ");
                    tip = "Vetraue nicht darauf das sich ein Weg Lohnt auch wenn es Beute gibt. Suche am besten Alternativen ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 23 && _column == 3 && count == 1)
                {
                    MessageBox.Show("Erkunden lohnt sich ");
                    tip = "Erkunden lohnt sich";
                    _grid[_column, _row, 2] = empty.ToString();
                }


            }
            return tip;

            // return Key;
        }
        string Dialog;
        public string Person(Panel panMain, PictureBox panel, int _row, int _column, int Level)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);

            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 2)
            {
                if (_row == 21 && _column == 13 && count == 1)
                {
                    
                    Dialog = "Was du suchst den Weg zu der Leopold, dann must du den Wald durchqueren und danach einen Weg durch den Vulkan finden.";
                   
                    _grid[_column, _row, 2] = empty.ToString();
                }


                Kommen = Dialog;
            }
            else
            {
                 Dialog= Kommen;
            }
            return Dialog;

            // return Key;
        }
        string Kommen;
        public string Kommentar(Panel panMain, PictureBox panel, int _row, int _column, int Level, string Dialog)
        {
           

               var count = Convert.ToInt32(_grid[_column, _row, 2]);

            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 2)
            {
                if (_row == 6 && _column == 13 && count == 1|| _row == 7 && _column == 13 && count == 1)
                {
                    Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Will ich wirklich wieder in diese Richtung gehen";
                   
                    _grid[_column, _row, 2] = empty.ToString();
                }



                Dialog = Kommen;
            }
            else
            {
                Kommen = Dialog;
            }
            return Kommen;

            // return Key;
        }
        bool ende;
        public bool Endes(Panel panMain, PictureBox panel, int _row, int _column)
        {
           
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast das Ende des Levels gefunden, Level beenden?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   // MessageBox.Show("Du erhälst einen Schlüssek(+1 zu Keys))");

                    ende = false;

                   // MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
                }
                else if (dialogResult == DialogResult.No)
                {
                    ende = true;

                  //  MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
                }
             




            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] != Ende)
            {
                ende = true;
            }
            return ende;
        }
        public int BomU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row>0)
            {

          
            if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Rock)
            {
                _grid[_column, _row, 0] = Gras;
                panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = null;
                    Bombs--;
            }
               
              
            }
            return Bombs;

        }
        public int KeyU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row > 0)
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;

        }
        public int SworU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row > 0)
            {
               


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = null;
                    Bombs--;
                  
                }

            }
            return Bombs;

        }
        public int BomU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row < 39)
            {
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
             
              
            }
            return Bombs;
        }
        public int KeyU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row < 39)
            {
              
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row < 39)
            {


                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        public int BomU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column < 39)
            {
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
              
              
            }
            return Bombs;
        }
        public int KeyU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column < 39)
            {
             
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column < 39)
            {
             

                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        public int BomU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column > 0)
            {

                if (_grid[_column-1, _row, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
             
               
            }
            return Bombs;
        }
        public int KeyU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column > 0)
            {

             
                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column > 0)
            {

               

                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        public int Money1(Panel panMain, PictureBox panel, int _row, int _column, int Moneys)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == Money && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Säcklein Gold gefunden, willst du es Mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+200 zu Gold))");

                   // panel.BackColor = Color.Orange;

                    Moneys = Moneys + 200;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                  //  panel.BackColor = Color.Orange;
                }


            }
            return Moneys;
        }
        public int Money2(Panel panMain, PictureBox panel, int _row, int _column, int Moneys)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == BigMoney && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Truhe Gold gefunden, willst du sie Looten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+500 zu Gold))");

                   // panel.BackColor = Color.Orange;

                    Moneys = Moneys + 500;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }


            }
            return Moneys;
        }
        public int Money3(Panel panMain, PictureBox panel, int _row, int _column, int Moneys)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == Money && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Säcklein Gold gefunden, willst du es Mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+200 zu Gold))");

                    //    panel.BackColor = Color.Orange;

                    Moneys = Moneys + 200;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //panel.BackColor = Color.Orange;
                }


            }
            return Moneys;
        }
        public int MaxLife(Panel panMain, PictureBox panel, int _row, int _column, int Max)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du findest Ambrosia, möchtest du davon essen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du fühlst dich voller Leben(Max Leben +1))");

                    //    panel.BackColor = Color.Orange;

                    Max = Max + 1;
                    panel.BackColor = Color.PaleVioletRed;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //panel.BackColor = Color.Orange;
                }


            }
            return Max;
        }



    }
}
