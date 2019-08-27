using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    public partial class frmGameOfLife : Form
    {
      
        public frmGameOfLife()
        {
            InitializeComponent();
            

        }


        #region

        
        Font ButtonFont = new Font("Arial", 10F);
        Pen ButtonBorderColor = new Pen(Color.Black);
        Brush ButtonTextColor = new SolidBrush(Color.Black);
        public Panel Panel;
        //Maximum Werte von panMain
        private const int MaxColumn = 50;
        private const int MaxRows = 50;

        private static readonly int Depth = 2; // Inhalt für der Zellen 
        private const int CellSize = 10;
        // Aus irgend einem Grund hat CellSpace mein feld geteilt und dann gab es statt 1 feld 4 Felder deshalb habe ich es entfernt

        //Für den GenerateGrid
        private int _columns;
        private int _rows;
        //Für den Feld Generator
        private int _inputColumns;
        private int _inputRows;

        //Status der Cell in Depth 0
        private const string Dead = "Dead";
        private const string Unbewohnt = "Unbewohnt";
        private const string Alive = "Alive";

        //In Depth 1 sind die Nachbaren gespeichert
   
        private readonly string[,,] _grid = new string[MaxRows, MaxColumn, Depth];

       

        #endregion

        #region 
        /// <summary>
        ///     Dieser Knopf ermöglicht die Veräderung der Grösse des Spielfeldes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsize_Click_1(object sender, EventArgs e)
        { 
            if (int.TryParse(txtwidth.Text, out _inputColumns))
                //Entnimmt den Wert aus txtwidth und setzt ihn in _inputColumns
            {
                if (int.TryParse(txtheight.Text, out _inputRows))
                    //Entnimmt den Wert aus txtheight und setzt ihn in _inputRows
                {
                    // Hier wird verhindert falls der User Höhere Werte Schreibt als das Maximum
                    if (_inputColumns > MaxColumn || _inputRows > MaxRows)

                    {
                        MessageBox.Show(@"Wert war zu Hoch, er wird auf den Maximal Wert reduziert");
                        if (_inputColumns > MaxColumn)

                        {
                            _inputColumns = MaxColumn;
                        }
                        if (_inputRows > MaxRows)
                        {
                            _inputRows = MaxRows;
                        }
                    }

                    if (_inputColumns <= 2 || _inputRows <= 2)
                    {
                        MessageBox.Show(@"Wert war zu Niedrig, der Wert wird auf 3 Erhöht");
                        if (_inputColumns <= 2)
                        {
                            _inputColumns = 3;
                        }
                        if (_inputRows <= 2)
                        {
                            _inputRows = 3;
                        }
                    }
                    panMain.Size = new Size(CellSize*_inputRows, CellSize*_inputColumns);

                   
                    for (_rows = 0; _rows < _inputRows; _rows++) // Generiert die Zellen der Spalten
                        {
                            for (_columns = 0; _columns < _inputColumns; _columns++) // Generiert die Zellen der Reihen
                            {


                            GenerateGrid();


                        }
                        }
             



                    // vergrössert oder verkleinert das Feld zu der Neuen Grösse




                    //Geht rüber zu GenerateGrid um die Zelle zu Generieren



                    //aktiviert alle Knöpfe
                    btnrun.Enabled = true;
                    btnstop.Enabled = true;
                    btnmanuel.Enabled = true;
                    btnclear.Enabled = true;
                    btnfill.Enabled = true;
                    btnkill.Enabled = true;
                    txtwidth.Enabled = false;
                    txtheight.Enabled = false;
                    btnsize.Enabled = false;
                    Labeldesc.Text = @"Wenn du eine Andere Grösse willst drücke auf Restart.";
                }
            }
        }

        /// <summary>
        ///     GenerateGrid() dient zur Generation des einzelnen Felder des panMain
        /// </summary>
        private void GenerateGrid()
        {
           
            Panel panel = new Panel()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _rows + _columns,
                Height = CellSize,
                Width = CellSize,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            _grid[_columns, _rows, 0] = Dead;//Definiert das die Zellen Tot sind am anfang
            panel.Click += panel_Click;


            panel.Location = new Point(_rows * CellSize, _columns * CellSize);
            panMain.Controls.Add(panel);
           
            /*
          Bitmap ControlImage = new Bitmap(CellSize* _inputRows* CellSize, CellSize*_inputColumns * CellSize);
            using (g = Graphics.FromImage(ControlImage))
            {
                g.Clear(Color.White);
                for (_rows = 0; _rows < 500; _rows += CellSize) // Generiert die Zellen der Spalten
                        
                            for (_columns = 0; _columns <500; _columns +=CellSize) // Generiert die Zellen der Reihen
                            {
                       
                      g.DrawRectangle(ButtonBorderColor, _rows, _columns, CellSize, CellSize);
                      // string ButtonLabel = ((CellSize * _inputRows * _inputColumns / CellSize) * (_columns / CellSize) + _rows / CellSize).ToString();
                    //    SizeF ButtonLabelSize = g.MeasureString(ButtonLabel, ButtonFont);
                     //   g.DrawString(ButtonLabel, ButtonFont, ButtonTextColor, _rows + (CellSize / 2) - (ButtonLabelSize.Width / 2), _columns + (CellSize / 2) - (ButtonLabelSize.Height / 2));

                    }
            }
            pictureBox1.Image = ControlImage;
            //_grid[_rows, _columns, 0] = Unbewohnt;
           
 /* 
              Panel = new Panel
                {
                    Name = "thispanel" + _columns + _rows,
                    Height = CellSize,
                    Width = CellSize,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle
                };

                //Panel sind die Informationen der Einzelenen Panels definiert.



                //Definiert das die Zellen Tot sind am anfang
                Panel.Click += panel_Click;
            _grid[_rows, _columns, 0] = Unbewohnt;
                Panel.Location = new Point(_rows*CellSize, _columns*CellSize);


                panMain.Controls.Add(Panel);

               */


        }
        private void panel_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            Panel thispanel = ((Panel)sender);
            _rows = thispanel.Location.Y / CellSize; //Position der Zelle in der Y achse
            _columns = thispanel.Location.X / CellSize; //Position der Zelle in der X achse
            //falls die Zelle Weiss oder LightGray ist wird sie durch anklicken Blau
            if (me.Button == MouseButtons.Right)
            {
                if (thispanel.BackColor == Color.White ||  thispanel.BackColor == Color.Blue)
                {
               
                    thispanel.BackColor = Color.LightGray;
                    _grid[_columns, _rows, 0] = Dead;
                }
            }
            if (me.Button == MouseButtons.Left)
            {
                if (thispanel.BackColor == Color.White || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Red)
                {
                    thispanel.BackColor = Color.Blue;
                    _grid[_columns, _rows, 0] = Alive;
                }
                else if (thispanel.BackColor == Color.Blue)
                {
                    thispanel.BackColor = Color.LightGray;
                    _grid[_columns, _rows, 0] = Dead;
                }
            }
        }
        
        

      

        /// <summary>
        ///     Neighbours zählt und schaut wer Nacbar der jeweiligen Zelle ist.
        /// </summary>
        public void Neighbours()
        {
            for (_columns = 0; _columns < _inputColumns; _columns++) // Zählt die Reihen
            {
                for (_rows = 0; _rows < _inputRows; _rows++) // Hier die  Spalte
                {
                    var count = 0; // Auch definiert als Nachbar

                    for (var i = _columns - 1; i < _columns + 2; i++) // Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= _inputColumns) // Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue; // Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _rows - 1; j < _rows + 2; j++) // Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= _inputRows)
                                // Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue; // Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[j, i, 0] == Alive)
                                // Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                                count++; // fügt einen Nachbaren hinzu
                            }
                        }
                    }
                    _grid[_rows, _columns, 1] = count.ToString(); // Sendet den Count Wert zum Depth 1
                }
            }
        }

        /// <summary>
        ///     Jede Generation wird hier geupdated
        /// </summary>
        public void UpdateGrid()
        {
            foreach (Control thispanel in panMain.Controls) // Kontrolliert jedes Panel in panMain
            {
                _columns = thispanel.Top/CellSize; // Fängt Wegen Top oben an
                _rows = thispanel.Left/CellSize;
                    // Und hier wird definiert das es Links anfängt, also fängt es Links oben an
                var count = Convert.ToInt32(_grid[_rows, _columns, 1]); // entnimmt die Anzahl der Nahcbaren

                if (thispanel.BackColor == Color.Blue)
                    // Weil es sich selber auch als Nachbar definiert wird hier das eigene Feld überprüft, falls man Blau ist wird ein Nachbar entfernt
                {
                    count = count - 1;
                }
                if (_grid[_rows, _columns, 0] == Alive)
                    // Falls die Zelle am Leben ist wird hier überprüft wie viele Nachbaren er hat
                {
                    if (count < 2 || count > 3) // Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                    {
                        _grid[_rows, _columns, 0] = Dead;

                        thispanel.BackColor = Color.LightGray;
                    }
                    else // Sonst wird sie Leben
                    {
                        _grid[_rows, _columns, 0] = Alive;
                        thispanel.BackColor = Color.Blue;
                    }
                }
                else
                //Ausserdem falls die Zelle Tod oder unbewohnt ist und sie hat drei Lebende Nachbaren so wird auch sie Lebendig
                {
                    if (count == 3 && _grid[_rows, _columns, 0] == Dead ||
                        count == 3 && _grid[_rows, _columns, 0] == Unbewohnt)
                    {
                        _grid[_rows, _columns, 0] = Alive;
                        thispanel.BackColor = Color.Blue;
                    }
                }
            }
        }

        /// <summary>
        ///     Übergang Station wenn eine Neue Generation gebildet wird
        /// </summary>
        public void NächsteGen()
        {
            Neighbours();

            UpdateGrid();
        }

        #endregion

        #region

        /// <summary>
        ///     Stoppt den Timer und das Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /// <summary>
        ///     Startet den Timer und das Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrun_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }


        /// <summary>
        ///     Nach jedem Tick wird der Timer Gestoppt, die Neue Generation gebildet und wieder Fortgesetzt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();

            NächsteGen();

            timer1.Start();
        }


        /// <summary>
        ///     Alternative zum Timer & Run, ist gedacht denn Process in einzelnen Schritten zu sehen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnmanuel_Click(object sender, EventArgs e)
        {
            NächsteGen();
        }

        /// <summary>
        ///     dieser Knopf war zuerst als Test gedacht, aber jetzt bleibt er doch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Er reinigt das Ganze feld und setzt alle Felder auf Unbewohnt
            timer1.Stop();
                // Ausserdem stoppt btnclear auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls) //reinigt jede einzelne Zelle
            {
                for (var i = 0; i < _inputColumns; i++) //Geht durch die Reihen
                {
                    for (var j = 0; j < _inputRows; j++) //Geht durch die Spalten
                    {
                        _grid[j, i, 0] = Unbewohnt;
                        thispanel.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        ///     Dieser Knopf ist das gegenteil von btnclear, er füllt alle Felder mit Leben, war auch nur als Testknopf gedacht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnfill_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
                // Ausserdem stoppt btnfill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls) //füllt jede einzelne Zelle
            {
                for (var i = 0; i < _inputColumns; i++) //Geht durch die Reihen
                {
                    for (var j = 0; j < _inputRows; j++) //Geht durch die Spalten
                    {
                        _grid[j, i, 0] = Alive;
                        thispanel.BackColor = Color.Blue;
                    }
                }
            }
        }

        /// <summary>
        ///     Dieser Knopf Eliminiert das Restliche Leben aber man sieht immernoch die Stellen an dem Zellen gestorben sind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnkill_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
                // Ausserdem stoppt btnkill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls) //füllt jede einzelne Zelle
            {
                for (var i = 0; i < _inputColumns; i++) //Geht durch die Reihen
                {
                    for (var j = 0; j < _inputRows; j++) //Geht durch die Spalten
                    {
                        if (thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.Red)
                        {
                            _grid[j, i, 0] = Dead;
                            thispanel.BackColor = Color.LightGray;
                        }
                        else
                        {
                            _grid[j, i, 0] = Dead;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Knopf ist dafür da das man die Applikation nicht immer runterfahren muss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrestart_Click(object sender, EventArgs e)
        {
            for (_columns = 0; _columns < _inputColumns; _columns++)// Generiert die Zellen der Spalten
            {
                for (_rows = 0; _rows < _inputRows; _rows++)// Generiert die Zellen der Reihen
                {

                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            // Es öffnet nicht sich selber nochmal sondern die gleich benannte Exe, diese Läuft um einiges schneller.
            frmGameOfLife fnp = new frmGameOfLife();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        #endregion

        #region

        //Die Zwei Folgenden Methoden konnte ich leider nur mit Hilfe herausfinden
        /// <summary>
        ///     //Hier wird dafür gesorgt das man für das generieren des Feldes nur Zahlen verwenden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtwidth_TextChanged_1(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtwidth.Text, "[^0-9]"))
                //falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {
                MessageBox.Show(@"Bitte keine Buchstaben oder Zeichen");
                txtwidth.Text = ""; //Macht das Feld wieder Leer
            }
        }

        /// <summary>
        ///     //Hier wird auch dafür gesorgt das man für das generieren des Feldes nur Zahlen verwenden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// 
        private void txtheight_TextChanged_1(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtheight.Text, "[^0-9]"))
                //falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {
                MessageBox.Show(@"Bitte keine Buchstaben oder Zeichen");
                txtheight.Text = ""; //Macht das Feld wieder Leer
            }
        }

        #endregion

        private void timer2_Tick(object sender, EventArgs e)
        {
    
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void GameOfLife_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            for (_columns = 0; _columns < _inputColumns; _columns++)// Generiert die Zellen der Spalten
            {
                for (_rows = 0; _rows < _inputRows; _rows++)// Generiert die Zellen der Reihen
                {

                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }
    }
}