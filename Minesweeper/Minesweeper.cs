using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    public partial class Minesweeper : Form
    {
        //Maximum Werte von panMain
        private const int MaxRows = 50;
        private const int MaxColumns = 50;
        private static int depth = 2; // Inhalt für der Zellen 
        private const int CellSize = 20;
        private int _row;
        private int _column;
        private int _rows;
        private int _columns;
        //Für den Feld Generator
        private int _inputRow;
        private int _inputColumn;      
        //Status der Cell in Depth 0
        private const string Dead = "Dead";
        private const string Bombs = "Bomb"; 
        private const string Start = "Start";
      
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
        int bomb = 0;
        bool Alive = true;

        MineFunk mine = new MineFunk();
        //In Depth 1 sind die Nachbaren gespeichert
        // In Depth 2 ist der Virus
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        public Minesweeper()
        {
            InitializeComponent();
        }
        private void btnsize_Click(object sender, EventArgs e)
        {
         
            if (int.TryParse(txtrow.Text, out _inputRow))//Entnimmt den Wert aus txtwidth und setzt ihn in _inputRow
            {


                if (int.TryParse(txtColumn.Text, out _inputColumn))//Entnimmt den Wert aus txtheight und setzt ihn in _inputColumn
                {
                    // Hier wird verhindert falls der User Höhere Werte Schreibt als das Maximum
                    if (_inputRow < 5)
                    {
                        _inputRow = 5;
                    }
                    if (_inputColumn < 5)
                    {
                        _inputColumn = 5;
                    }
                    if (_inputRow > 50)
                    {
                        _inputRow = 50;
                    }
                    if (_inputColumn > 50)
                    {
                        _inputColumn = 50;
                    }
                    panMain.Size = new Size(CellSize * _inputRow, CellSize * _inputColumn);// vergrössert oder verkleinert das Feld zu der Neuen Grösse
                                                                                           //   
                                                                                           // 
                    panMain.Visible = false;
                    for (_column = 0; _column < _inputColumn; _column++)// Generiert die Zellen der Spalten
                    {
                        for (_row = 0; _row < _inputRow; _row++)// Generiert die Zellen der Reihen
                        {
                            
                            PictureBox panel = mine.GenerateGrid(_row, _column, _inputRow, _inputColumn);
                            panel.Click += panel_Click;
                            panMain.Controls.Add(panel);
                           
                        }
                    }
                    panMain.Visible = true;
                }

            }

        }      
    
        Random random = new Random();
        private void panel_Click(object sender, EventArgs e)
        {
           
            if (Alive== true)
            {         
            MouseEventArgs me = (MouseEventArgs)e;

            PictureBox panel = ((PictureBox)sender);
            _row = panel.Location.Y / CellSize; //Position der Zelle in der Y achse
            _column = panel.Location.X / CellSize;
            int i = 0;
                if (me.Button == MouseButtons.Right)
                {


                    mine.Pict(panel, panel.BackgroundImage, panel.BackgroundImageLayout, _grid[_column, _row, 0], _row, _column);
                    points = mine.Pict2(panel, panel.BackgroundImage, panel.BackgroundImageLayout, _grid[_column, _row, 0], points,_row,_column);
                    if (points == bomb && bomb > 0)
                    {

                        MessageBox.Show("Du hast Gewonnen");
                    }
                }
                else if (me.Button == MouseButtons.Left)
                {                 
                    panel.Enabled = false;


                    bomb= mine.Bommms(panMain, panel, _inputRow, _inputColumn,   _row, _column);
                    mine.Neighbours(_inputColumn, _inputRow, _columns, _rows);


                    panel = mine.NumeberBomb(panel, panMain, _row,_column);
                    if (panel.BackgroundImage == null)
                    {
                        foreach (PictureBox thispanelss in panMain.Controls)
                        {
                            _rows = thispanelss.Location.Y / CellSize; //Position der Zelle in der Y achse
                            _columns = thispanelss.Location.X / CellSize;
                            mine.ZeroBomb2(panel, panMain, _row, _column, thispanelss, _rows, _columns, thispanelss.Enabled);
                        }

                    }

                }

            }  // throw new NotImplementedException();
        }
       
        private void btnback_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < _inputColumn; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < _inputRow; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();

        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            for (_column = 0; _column < _inputColumn; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < _inputRow; _row++)// Generiert die Zellen der Reihen
                {
                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            Minesweeper fnp = new Minesweeper();
            Hide();
            fnp.ShowDialog();
            Close();
           // Application.Restart();
        }

        private void txtrow_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtrow.Text, "[^0-9]"))
            //falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {
                MessageBox.Show(@"Bitte keine Buchstaben oder Zeichen");
                txtrow.Text = ""; //Macht das Feld wieder Leer
            }
        }

        private void txtColumn_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtColumn.Text, "[^0-9]"))
            //falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {
                MessageBox.Show(@"Bitte keine Buchstaben oder Zeichen");
                txtColumn.Text = ""; //Macht das Feld wieder Leer
            }
        }
    }
}
