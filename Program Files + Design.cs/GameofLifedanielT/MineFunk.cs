using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class MineFunk
    {
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        private static int depth = 2; // Inhalt für der Zellen 
        private const int CellSize = 20;
      
        private int _rows;
       
        private int _columns;
        //Für den Feld Generator
       

        //Status der Cell in Depth 0
        private const string Dead = "Dead";
        private const string Bombs = "Bomb";
        private const string Unbewohnt = "Unbewohnt";
        private const string BB = "BB";
        private const string Start = "Start";
        private const string Wall = "Wall";
        private const string Play = "Play";
        private const string Play2 = "Play2";
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
        int points = 0;
        bool first = false;
        Image Save = null;
        //In Depth 1 sind die Nachbaren gespeichert
        // In Depth 2 ist der Virus
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        public PictureBox GenerateGrid(int _row, int _column, int _inputRow, int _inputColumn)
        {
            Panel panMain = new Panel();
            panMain.Size = new Size(CellSize * _inputRow, CellSize * _inputColumn);
            PictureBox panel = new PictureBox()
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,
                BorderStyle = BorderStyle.FixedSingle
            };

                    _grid[_column, _row, 0] = Dead;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Location = new Point(_row * CellSize, _column * CellSize);
            
            return panel;
        }
       
        public PictureBox Pict(PictureBox panel, Image back,ImageLayout es,string Bombss, int Rowss, int Columnss)
        {
            if (Alive == true)
            {

                if (panel.BackgroundImage == back && back == null || _grid[Columnss, Rowss, 0] == Bombs)//|| Bombss == Bombs
                {
                    if (Bombss == Bombs)
                    {
                        points++;

                    }

                    panel.BackgroundImage = Flag;
                    Save = panel.BackgroundImage;

                    // panel.BackgroundImageLayout = ImageLayout.Zoom;

                }
                else if (panel.BackgroundImage == Flag)
                {
                    if (Bombss == Bombs)
                    {
                        points--;

                    }

                    panel.BackgroundImage = Question;
                    Save = panel.BackgroundImage;
                    // panel.BackgroundImageLayout = ImageLayout.Zoom;

                }
                else if (panel.BackgroundImage == Question)
                {


                    panel.BackgroundImage = null;
                    Save = panel.BackgroundImage;
                }
            }
            // panel.BackgroundImageLayout = ImageLayout.Zoom;
            return panel;
        }
            
        
       
        public int Pict2(PictureBox panel, Image back, ImageLayout es, string Bombss, int pointss, int Rowss, int Columnss)
        {
            if (Alive == true)
            {
                if (panel.BackgroundImage == back && back == Flag)
                {
                    if (_grid[Columnss, Rowss, 0] == Bombs)
                    {
                        pointss++;

                    }
                    else if (_grid[Columnss, Rowss, 0] != Bombs)
                    {

                    }

                }
                else if (panel.BackgroundImage == back && back == Question)
                {
                    if (_grid[Columnss, Rowss, 0] == Bombs)
                    {
                        pointss--;
                    }

                }
            }
            return pointss;
        }
        int bomb = 0;
        bool Alive = true;
        int i = 0;
        Random random = new Random();
        public int Bommms(Panel panMain, PictureBox panel, int _inputRows, int _inputColumns,int _rowsd, int _columnsd)
        {
            foreach (PictureBox thispanel in panMain.Controls)
            {
                _rows = thispanel.Location.Y / CellSize;
                _columns = thispanel.Location.X / CellSize;

                if (first == false)
                {

            
                    _grid[_columnsd, _rowsd, 0] = Start;
                    thispanel.BackgroundImage = null;
                    first = true;
                }




                if (bomb <= _inputRows * _inputColumns / 4)
                {
                    int R = random.Next(1, _inputRows * _inputColumns * 2);
                    if (R + i > _inputRows * _inputColumns)
                    {
                        if ( _rows == _rowsd && _columns == _columnsd)
                        {

                            _grid[_columnsd, _rowsd, 0] = Start;
                            //  panel.BackgroundImage = Question;
                            thispanel.BackgroundImage = null;
                            bomb--;


                        }
                        else
                        {
                            bomb++;
                        //  thispanel.BackgroundImage = Bomb;

                            _grid[_columns, _rows, 0] = Bombs;

                            thispanel.BackgroundImageLayout = ImageLayout.Zoom;
                            i = i - _inputRows * 3;
                        }
                        
                      
                        if (_rows > 0 && _grid[_columns, _rows - 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _grid[_columns, _rows + 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _rows > 0 && _grid[_columns + 1, _rows - 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _grid[_columns + 1, _rows + 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _grid[_columns + 1, _rows, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _columns > 0 && _grid[_columns - 1, _rows + 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _columns > 0 && _rows > 0 && _grid[_columns - 1, _rows - 1, 0] == Start && _grid[_columns, _rows, 0] == Bombs || _columns > 0 && _grid[_columns - 1, _rows, 0] == Start && _grid[_columns, _rows, 0] == Bombs)
                        {
                            _grid[_columns, _rows, 0] = Dead;
                            thispanel.BackgroundImage = null;

                            bomb--;
                        

                    }

                    }
                   
                    else
                    {
                        i = i + _inputRows;
                    }

                }
                else
                {
                   
                    thispanel.BackgroundImageLayout = ImageLayout.Zoom;
               
            }
            }
            return bomb;
          //  return  _grid[_columnss, _rowss, 0];




        }
        public void  Neighbours(int iColumn, int iRow, int _columnss,int _rowss)
        {
            for (_columnss = 0; _columnss < iColumn; _columnss++) // Zählt die Reihen
            {
                for (_rowss = 0; _rowss < iRow; _rowss++) // Hier die  Spalte
                {
                    var count = 0;
                    // Auch definiert als Nachbar

                    for (var i = _columnss - 1; i < _columnss + 2; i++) // Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= iColumn) // Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue; // Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _rowss - 1; j < _rowss + 2; j++) // Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= iRow)
                            // Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue; // Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[i, j, 0] == Bombs)
                            // Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                       
                                count++; // fügt einen Nachbaren hinzu
                            }
                        }
                        _grid[_columnss, _rowss, 1] = count.ToString();
                    }

                    // Sendet den Count Wert zum Depth 1
                }
            }


           

        }
       
       
        public PictureBox NumeberBomb(PictureBox panel, Panel panMain , int _rowt, int _columnt)
        {
            if (Alive == true)
            {
                foreach (PictureBox thispanelss in panMain.Controls)
                {
                    _rows = thispanelss.Location.Y / CellSize; //Position der Zelle in der Y achse
                    _columns = thispanelss.Location.X / CellSize;
                    var counts = Convert.ToInt32(_grid[_columns, _rows, 1]);
                    var count = Convert.ToInt32(_grid[_columnt, _rowt, 1]);

                    if (count == 1 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = one;
                    }
                    else if (count == 2 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Two;
                    }
                    else if (count == 3 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Three;
                    }
                    else if (count == 4 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Four;
                    }
                    else if (count == 5 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Five;
                    }
                    else if (count == 6 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Sechs;
                    }
                    else if (count == 7 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Sieben;
                    }
                    else if (count == 8 && _grid[_columnt, _rowt, 0] != Bombs)
                    {
                        panel.BackgroundImage = Acht;
                    }
                    else if (_grid[_columnt, _rowt, 0] == Bombs)
                    {
                        panel.BackgroundImage = Bomb;

                        Alive = false;

                    }



                }
                if (Alive == false)
                {
                    MessageBox.Show("Du hast Verloren," + " du hattest " + points + " Richtig");

                }
            }
            return panel;
        }
        public PictureBox ZeroBomb2(PictureBox panel, Panel panMain, int _rowt, int _columnt,PictureBox thispanelss,int _rowts, int _columnts,bool Trues)
        {
            if (Alive == true)
            {
                var counts = Convert.ToInt32(_grid[_columnts, _rowts, 1]);
                var count = Convert.ToInt32(_grid[_columnt, _rowt, 1]);


                if (counts == 0 && _grid[_columnt, _rowt, 0] != Bombs && _grid[_columnt, _rowt, 0] == _grid[_columnts, _rowts, 0])
                {
                    panel.BackColor = Color.LightGreen;
                    if (thispanelss.BackColor != Color.LightGreen && thispanelss.Enabled == Trues && _rowt + 1 == _rowts && _columnt + 1 > _columnts && _columnt - 1 < _columnts || thispanelss.BackColor != Color.LightGreen && thispanelss.Enabled == Trues && _rowt - 1 == _rowts && _columnt + 1 > _columnts && _columnt - 1 < _columnts || thispanelss.BackColor != Color.LightGreen && thispanelss.Enabled == Trues && _columnt - 1 == _columnts && _rowt + 1 > _rowts && _rowt - 1 < _rowts || thispanelss.BackColor != Color.LightGreen && thispanelss.Enabled == Trues && _columnt + 1 == _columnts && _rowt + 1 > _rowts && _rowt - 1 < _rowts)
                    {
                        thispanelss.BackColor = Color.LawnGreen;
                    }


                }
            }
                return thispanelss;

            }



        }


    
}
