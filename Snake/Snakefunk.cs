using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class Snakefunk
    {
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        private static int depth = 2; // Inhalt für der Zellen 
        private const int CellSize = 20;

        bool alive = true;
        private int _rows;
  
        private int _columns;
        //Für den Feld Generator


        //Status der Cell in Depth 0
        private const string Free = "Free";
        private const string Wall = "Wall";
        private const string Snakehead = "Snakehead";
        private const string Body = "Snake";
        private const string Berrys = "Berry";
        private const string Play2 = "Play2";
        Bitmap Head = Properties.Resources.Head;
        Bitmap Bodys = Properties.Resources.Body;
        Bitmap Berry = Properties.Resources.Berry;
   
        //In Depth 1 sind die Nachbaren gespeichert
        // In Depth 2 ist der Virus
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        public PictureBox GenerateGrid(int _row, int _column)
        {
            Panel panMain = new Panel();
            panMain.Size = new Size(CellSize * 70, CellSize * 30);
            PictureBox panel = new PictureBox()
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,
                BackColor= Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle
                
            };

            _grid[_column, _row, 0] = Free;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Location = new Point(_column * CellSize,_row * CellSize );

            return panel;
        }
        public PictureBox GenerateGrid2(int _row, int _column)
        {
            Panel panMain = new Panel();
            panMain.Size = new Size(CellSize * 70, CellSize * 30);
            PictureBox panel = new PictureBox()
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,
                BackColor = Color.Brown,
                BorderStyle = BorderStyle.FixedSingle

            };

            _grid[_column, _row, 0] = Wall;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Location = new Point(_column * CellSize, _row * CellSize);

            return panel;
        }
        public PictureBox SnakeStart(PictureBox panel,int _row, int _column)
        {
            for (int r = 1; r < 29; r++)
            {
                for (int c = 1; c < 69; c++)// Generiert die Zellen der Spalten
                {
                    if (r== _row&& c==_column)
                    {
                        panel.BackgroundImage = Head;
                        _grid[_column, _row, 0] = Snakehead;
                    }
                }

                }

            return panel;
        }
        int Life=0;
     
        int CounLif;
        public PictureBox SnakeUp(Panel panMain, PictureBox panel, int _row, int _column, int _rows, int _columns)
        {
            if (alive== true)
            {

          

            CounLif = Life;
            
            if (CounLif > 0)
            {
              //  _columns == _column &&

                    if (_rows > 1 && _row >1 && _grid[_columns, _rows-1, 0] != Wall)
                    {
                    if (_rows >= _row)
                    {
                        

                           // if (_rows > i)
                           // {
                            if (_grid[_columns, _rows, 0] == Snakehead&& _rows < 29 )
                            {
                              
                                panel.BackgroundImage = Bodys;
                                _grid[_columns, _rows, 0] = Body;
                                _grid[_columns, _rows, 1] = CounLif.ToString();
                                _grid[_columns, _rows - 1, 0] = Snakehead;

                            }
                            else
                            {
                               // alive = false;
                            }
                            
                        //  if (_grid[_columns, _rows, 0] == Snakehead && _rows > 0)
                        //{
                        //  panel.BackgroundImage = Bodys;
                        //  _grid[_columns, _rows, 0] = Body;
                        //  _grid[_columns, _rows + 1, 0] = Snakehead;
                        //  break;

                    //}
                    }
                        
                   }
               // }
            }
            if (_grid[_columns, _rows, 0] == Snakehead)
            {

                panel.BackgroundImage = Head;
            }
            if (_grid[_columns, _rows , 0] == Body&&CounLif > 0 && panel.BackgroundImage == Bodys)
            {
                var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
                //  for (int i = 1; i < CounLif+1; i++)
                //  {
                //    if (_rows > i)
                //    {
              //  _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns - 1, _rows, 0] == Body || _grid[_columns, _rows + 1, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns, _rows - i, 0] == Snakehead
                if (_grid[_columns, _rows, 0] != Snakehead&& count>0)
                        {
                            
                            count = count - 1;
                    _grid[_columns, _rows, 1] = count.ToString();
                    // break;
                }
                     //   else if (i == CounLif)
                         else if (count == 0)
                {
                            panel.BackgroundImage = null;
                            _grid[_columns, _rows, 0] = Free;
                          //  break;
                        }
                 //   }
               // }
              
            }
            else if  (_rows == _row && _columns == _column && _grid[_columns, _rows - 1, 0] != Wall && Life == 0)
                
            {
                panel.BackgroundImage = null;
                _grid[_columns, _rows, 0] = Free;
            }
        
            if (_rows == _row - 1 && _columns == _column  )
                {
                    if (_grid[_columns, _rows, 0] == Berrys)
                    {

                        Life++;
                       
                        panel.BackgroundImage = Head;                     
                        _grid[_columns, _rows, 0] = Snakehead;
                    }
                    else if (_grid[_columns, _rows, 0] == Body)
                   
                    {

                        alive = false;
                        MessageBox.Show("Deine Schlange hat sich selbst gegessen.");
                    }
                    else if (_grid[_columns, _rows, 0] == Wall )

                    {

                        alive = false;
                        MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                    }
                    else if ( _grid[_columns, _rows, 0] == Free)
                    
                    {
                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }

                }



            }
            return panel;
        }
        public PictureBox Snakedown(PictureBox panel, int _row, int _column, int _rows, int _columns)
        {
            if (alive == true)
            {

                CounLif = Life;

                if (CounLif > 0)
                {

                    if (_rows < 30 && _row < 30 && _columns == _column && _grid[_columns, _rows + 1, 0] != Wall)
                    {
                        if (_rows <= _row)
                        {
                            if (_grid[_columns, _rows, 0] == Snakehead && _grid[_columns, _rows + 1, 0] == Berrys && _rows > 0)
                            {
                                Life++;
                            }
                            else if (_grid[_columns, _rows, 0] == Snakehead && _grid[_columns, _rows + 1, 0] == Body && _rows > 0)

                            {

                                alive = false;
                                MessageBox.Show("Deine Schlange hat sich selbst gegessen.");
                            }
                            else if (_row == 28 && _grid[_columns, _rows, 0] == Snakehead && _grid[_columns , _rows+1, 0] == Wall && _rows > 0)

                            {

                                alive = false;
                                MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                            }

                            if (_grid[_columns, _rows, 0] == Snakehead && _rows > 0)
                            {
                                panel.BackgroundImage = Bodys;
                                _grid[_columns, _rows, 1] = CounLif.ToString();
                                _grid[_columns, _rows, 0] = Body;
                                _grid[_columns, _rows + 1, 0] = Snakehead;

                                //   }
                            }


                        }

                    }
                    // }
                }
                if (_grid[_columns, _rows, 0] == Snakehead)
                {

                    panel.BackgroundImage = Head;
                }
                /*
                            var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
                            //  for (int i = 1; i < CounLif+1; i++)
                            //  {
                            //    if (_rows > i)
                            //    {
                            //  _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns - 1, _rows, 0] == Body || _grid[_columns, _rows + 1, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns, _rows - i, 0] == Snakehead
                            if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
                            {

                                count = count - 1;
                                _grid[_columns, _rows, 1] = count.ToString();
                                // break;
                            }
                            //   else if (i == CounLif)
                            else if (count == 0)
                            {
                                panel.BackgroundImage = null;
                                _grid[_columns, _rows, 0] = Free;

                    */
                if (_grid[_columns, _rows, 0] == Snakehead)
                {

                    panel.BackgroundImage = Head;
                }
                if (_grid[_columns, _rows, 0] == Body && CounLif > 0 && panel.BackgroundImage == Bodys)
                {
                    var count = Convert.ToInt32(_grid[_columns, _rows, 1]);



                    if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
                    {

                        count = count - 1;
                        _grid[_columns, _rows, 1] = count.ToString();
                    }
                    else if (count == 0)
                    {
                        panel.BackgroundImage = null;
                        _grid[_columns, _rows, 0] = Free;
                    }



                }
                else if (_rows == _row && _columns == _column && _grid[_columns, _rows + 1, 0] != Wall && Life == 0)

                {
                    panel.BackgroundImage = null;
                    _grid[_columns, _rows, 0] = Free;
                }
                else if (_grid[_columns, _rows+1, 0] == Wall && _rows == _row && _columns == _column && _grid[_columns, _rows, 0] == Snakehead && Life == 0)

                {
                    alive = false;
                    MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                }

                if (_rows == _row + 1 && _columns == _column && _grid[_columns, _rows, 0] != Wall && _grid[_columns, _rows, 0] != Snakehead)
                {
                    if (_grid[_columns, _rows, 0] == Berrys)
                    {

                        Life++;
                        _grid[_columns, _rows, 1] = Life.ToString();
                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }
                  
                    else
                    {

                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }

                }


            }
            return panel;
        }
        public PictureBox SnakeLeft(PictureBox panel, int _row, int _column, int _rows, int _columns)
        {
            if (alive == true)
            {

                CounLif = Life;

                if (CounLif > 0)
                {


                    if (_columns > 0 && _column > 0 && _rows == _row && _grid[_columns - 1, _rows, 0] != Wall)
                    {
                        if (_columns >= _column)
                        {


                            if (_grid[_columns, _rows, 0] == Snakehead && _columns > 0)
                            {
                                panel.BackgroundImage = Bodys;
                                _grid[_columns, _rows, 1] = CounLif.ToString();
                                _grid[_columns, _rows, 0] = Body;
                                _grid[_columns - 1, _rows, 0] = Snakehead;

                            }


                        }


                    }
                    // }
                }
                /*
                var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
                //  for (int i = 1; i < CounLif+1; i++)
                //  {
                //    if (_rows > i)
                //    {
                //  _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns - 1, _rows, 0] == Body || _grid[_columns, _rows + 1, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns, _rows - i, 0] == Snakehead
                if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
                {

                    count = count - 1;
                    _grid[_columns, _rows, 1] = count.ToString();
                    // break;
                }
                //   else if (i == CounLif)
                else if (count == 0)
                {
                    panel.BackgroundImage = null;
                    _grid[_columns, _rows, 0] = Free;

        */
                if (_grid[_columns, _rows, 0] == Snakehead)
                {

                    panel.BackgroundImage = Head;
                }
                if (_grid[_columns, _rows, 0] == Body && CounLif > 0 && panel.BackgroundImage == Bodys)
                {
                    var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
                    if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
                    {

                        count = count - 1;
                        _grid[_columns, _rows, 1] = count.ToString();
                        // break;
                    }
                    else if (count == 0)
                    {
                        panel.BackgroundImage = null;
                        _grid[_columns, _rows, 0] = Free;
                    }



                }
                else if (_rows == _row && _columns == _column && _grid[_columns - 1, _rows, 0] != Wall && Life == 0)

                {
                    panel.BackgroundImage = null;
                    _grid[_columns, _rows, 0] = Free;
                }

                if (_rows == _row && _columns == _column - 1 )
                {
                    if (_grid[_columns, _rows, 0] == Berrys)
                    {

                        Life++;
                        _grid[_columns, _rows, 1] = Life.ToString();
                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }
                    else if (_grid[_columns, _rows, 0] == Body)

                    {

                        alive = false;
                        MessageBox.Show("Deine Schlange hat sich selbst gegessen.");
                    }
                    else if (_grid[_columns, _rows, 0] == Wall)

                    {

                        alive = false;
                        MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                    }
                    else if (_grid[_columns, _rows, 0] == Free)
                 
                    {

                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }

                }



            }
            return panel;




           
        }
        public PictureBox Snakeright(PictureBox panel, int _row, int _column, int _rows, int _columns)
        {
            if (alive == true)
            {
                CounLif = Life;

                if (CounLif > 0)
                {

                    if (_columns < 70 && _column < 70 && _rows == _row )
                    {
                        if (_columns <= _column)
                        {
                            if (_grid[_columns, _rows, 0] == Snakehead && _grid[_columns + 1, _rows, 0] == Berrys && _columns > 0)
                            {
                                Life++;
                            }
                            else if (_grid[_columns, _rows, 0] == Snakehead && _grid[_columns+1, _rows , 0] == Body && _rows > 0)

                            {

                                alive = false;
                                MessageBox.Show("Deine Schlange hat sich selbst gegessen.");
                            }
                            else if (_columns == 68 && _grid[_columns , _rows, 0] == Snakehead && _grid[_columns + 1, _rows, 0] == Wall && _rows > 0)

                            {

                                alive = false;
                                MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                            }



                            //   if (_rows > i)
                            // {

                            if (_grid[_columns, _rows, 0] == Snakehead && _columns > 0)
                                {
                                    panel.BackgroundImage = Bodys;
                                    _grid[_columns, _rows, 1] = CounLif.ToString();
                                    _grid[_columns, _rows, 0] = Body;
                                    _grid[_columns + 1, _rows, 0] = Snakehead;
                                   
                                    //   }
                                }

                            
                        }

                    }
                    
                    // }
                }
                /*
               var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
               //  for (int i = 1; i < CounLif+1; i++)
               //  {
               //    if (_rows > i)
               //    {
               //  _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows + 1, 0] == Body || _grid[_columns - 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns + 1, _rows, 0] == Body && _grid[_columns - 1, _rows, 0] == Body || _grid[_columns, _rows + 1, 0] == Body && _grid[_columns, _rows - 1, 0] == Body || _grid[_columns, _rows - i, 0] == Snakehead
               if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
               {

                   count = count - 1;
                   _grid[_columns, _rows, 1] = count.ToString();
                   // break;
               }
               //   else if (i == CounLif)
               else if (count == 0)
               {
                   panel.BackgroundImage = null;
                   _grid[_columns, _rows, 0] = Free;

       */
                if (_grid[_columns, _rows, 0] == Snakehead)
                {

                    panel.BackgroundImage = Head;
                }
                if (_grid[_columns, _rows, 0] == Body && CounLif > 0 && panel.BackgroundImage == Bodys)
                {
                    var count = Convert.ToInt32(_grid[_columns, _rows, 1]);
                    if (_grid[_columns, _rows, 0] != Snakehead && count > 0)
                    {

                        count = count - 1;
                        _grid[_columns, _rows, 1] = count.ToString();
                        // break;
                    }
                    else if (count == 0)
                    {
                        panel.BackgroundImage = null;
                        _grid[_columns, _rows, 0] = Free;
                    }



                }
                else if (_rows == _row && _columns == _column && _grid[_columns + 1, _rows, 0] != Wall && Life == 0)

                {
                    panel.BackgroundImage = null;
                    _grid[_columns, _rows, 0] = Free;
                }
                else if (_grid[_columns+1, _rows , 0] == Wall && _rows == _row && _columns == _column && _grid[_columns, _rows, 0] == Snakehead && Life == 0)

                {
                    alive = false;
                    MessageBox.Show("Deine Schlange hat die Wand gebissen, und ist daran Gestorben");
                }

                if (_rows == _row && _columns == _column + 1 && _grid[_columns, _rows, 0] != Wall &&  _grid[_columns, _rows, 0] != Snakehead)
                {
                    if (_grid[_columns, _rows, 0] == Berrys)
                    {

                        Life++;
                        _grid[_columns, _rows, 1] = Life.ToString();
                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;
                    }
                   
                    else
                    {

                        panel.BackgroundImage = Head;
                        _grid[_columns, _rows, 0] = Snakehead;

                    }

                }




            }

            return panel;
        }
        Random random = new Random();
        int h =0;
        public void Beery(Panel panMain,  int _row, int _column, int _rowsd, int _columnsd)
        {
            if (alive == true)
            {

                int berrys = 0;
                foreach (PictureBox thispanel in panMain.Controls)
                {
                    _rows = thispanel.Location.Y / CellSize;
                    _columns = thispanel.Location.X / CellSize;

                    if (_grid[_columns, _rows, 0] == Wall)
                    {


                        continue;
                    }
                    else if (_grid[_columns, _rows, 0] == Berrys)
                    {
                        h = h - 1000;

                        continue;
                    }
                    else if (berrys < 1)
                    {
                        int R = random.Next(1, 29 * 69 * 2);
                        if (R + h > 29 * 69)
                        {
                            if (_grid[_columns, _rows, 0] == Free)
                            {

                                _grid[_columns, _rows, 0] = Berrys;
                                thispanel.BackgroundImage = Berry;
                                berrys++;


                                h = h - 29 * 3;

                            }


                        }
                        else
                        {
                            h = h + 29;
                        }
                    }





                }




            }
        
        }
        public bool Alive()
        {



            return alive;
        }
        }
}
