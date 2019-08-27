using GameofLifedanielT;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameofLifedanielTextend
{
    public partial class frmGameOfLifeex : Form
    {
        public frmGameOfLifeex()
        {
            InitializeComponent();

        }

        //Maximum Werte von panMain
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        private static int depth = 6; // Inhalt für der Zellen 
        private const int CellSize = 10;
        // Aus irgend einem Grund hat CellSpace mein feld geteilt und dann gab es statt 1 feld 4 Felder deshalb habe ich es entfernt

        //Für den GenerateGrid
        private int _row;
        private int _column;
        //Für den Feld Generator
        private int _inputRow;
        private int _inputColumn;
        private int _gen = 0;
        //Status der Cell in Depth 0
        private const string Dead = "Dead";
        private const string Unbewohnt = "Unbewohnt";
        private const string Alive = "Alive";
        private const string Virus = "Virus";
        private const string Wall = "Wall";
        private const string Play = "Play";
        private const string Play2 = "Play2";
        
        //In Depth 1 sind die Nachbaren gespeichert
        // In Depth 2 ist der Virus
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];

        /// <summary>
        /// GenerateGrid() dient zur Generation des einzelnen Felder des panMain
        /// </summary>
        private void GenerateGrid()
        {
          
            Panel panel = new Panel()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,
                BackColor = Color.LightGreen,
                BorderStyle = BorderStyle.FixedSingle
            };

            _grid[_column, _row, 0] = Dead;//Definiert das die Zellen Tot sind am anfang
            panel.Click += panel_Click;


            panel.Location = new Point(_row * CellSize, _column * CellSize);
            panMain.Controls.Add(panel);
        }

        /// <summary>
        ///  Hier wird definiert was passiert wenn man auf ein Panel klickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            Panel thispanel = ((Panel)sender);
            _row = thispanel.Location.Y / CellSize; //Position der Zelle in der Y achse
            _column = thispanel.Location.X / CellSize; //Position der Zelle in der X achse
            //falls die Zelle Weiss oder LightGray ist wird sie durch anklicken Blau
            if (Cange == false)
            {
                if (me.Button == MouseButtons.Right)
                {
                    if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.DarkGoldenrod || thispanel.BackColor == Color.Purple || thispanel.BackColor == Color.Pink)
                    {
                        thispanel.BackColor = Color.Red;
                        _grid[_column, _row, 0] = Virus;
                    }
                    else if (thispanel.BackColor == Color.Red)
                    {
                        thispanel.BackColor = Color.DarkGray;
                        _grid[_column, _row, 0] = Dead;
                    }
                }
                if (me.Button == MouseButtons.Left)
                {
                    if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.DarkGoldenrod || thispanel.BackColor == Color.Purple || thispanel.BackColor == Color.Pink)
                    {
                        thispanel.BackColor = Color.Blue;
                        _grid[_column, _row, 0] = Alive;
                    }
                    else if (thispanel.BackColor == Color.Blue)
                    {
                        thispanel.BackColor = Color.LightGray;
                        _grid[_column, _row, 0] = Dead;
                    }
                }
                if (me.Button == MouseButtons.Middle)
                {
                    if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.DarkGoldenrod || thispanel.BackColor == Color.Purple || thispanel.BackColor == Color.Pink)
                    {
                        thispanel.BackColor = Color.Brown;
                        _grid[_column, _row, 0] = Wall;
                    }
                    //  else if (thispanel.BackColor == Color.Brown)
                    // {
                    //   thispanel.BackColor = Color.LightBlue;
                    //  _grid[_column, _row, 0] = River;
                    //    }
                    else if (thispanel.BackColor == Color.Brown)
                    {
                        thispanel.BackColor = Color.LightGreen;
                        _grid[_column, _row, 0] = Unbewohnt;
                    }


                }
            }
            else if(Cange== true)
                {
                    if (me.Button == MouseButtons.Right)
                    {
                        if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.Purple || thispanel.BackColor == Color.Pink)
                        {
                            thispanel.BackColor = Color.DarkGoldenrod;
                            _grid[_column, _row, 0] = Play;
                        }
                        else if (thispanel.BackColor == Color.DarkGoldenrod)
                        {
                            thispanel.BackColor = Color.Yellow;
                            _grid[_column, _row, 0] = Dead;
                        }
                    }
                    if (me.Button == MouseButtons.Left)
                    {
                        if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.DarkGoldenrod || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.Pink)
                        {
                            thispanel.BackColor = Color.Purple;
                            _grid[_column, _row, 0] = Play2;
                        }
                        else if (thispanel.BackColor == Color.Purple)
                        {
                            thispanel.BackColor = Color.Pink;
                            _grid[_column, _row, 0] = Dead;
                        }
                    }
                    if (me.Button == MouseButtons.Middle)
                    {
                        if (thispanel.BackColor == Color.LightGreen || thispanel.BackColor == Color.LightGray || thispanel.BackColor == Color.Red || thispanel.BackColor == Color.DarkGray || thispanel.BackColor == Color.Blue || thispanel.BackColor == Color.Yellow || thispanel.BackColor == Color.DarkGoldenrod || thispanel.BackColor == Color.Purple || thispanel.BackColor == Color.Pink)
                        {
                            thispanel.BackColor = Color.Brown;
                            _grid[_column, _row, 0] = Wall;
                        }
                        //  else if (thispanel.BackColor == Color.Brown)
                        // {
                        //   thispanel.BackColor = Color.LightBlue;
                        //  _grid[_column, _row, 0] = River;
                        //    }
                        else if (thispanel.BackColor == Color.Brown)
                        {
                            thispanel.BackColor = Color.LightGreen;
                            _grid[_column, _row, 0] = Unbewohnt;
                        }

                    }

                

            }
        }




        /// <summary>
        /// Neighbours zählt und schaut wer Nacbar der jeweiligen Zelle ist.
        /// </summary>
        public void Neighbours()
        {
            for (_row = 0; _row < _inputRow; _row++) // Zählt die Reihen
            {
                for (_column = 0; _column < _inputColumn; _column++)// Hier die  Spalte
                {
                    var count = 0;// Auch definiert als Nachbar

                    for (var i = _row - 1; i < _row + 2; i++)// Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= _inputRow)// Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue;// Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _column - 1; j < _column + 2; j++)// Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= _inputColumn)// Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue;// Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[j, i, 0] == Alive)// Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                                count++;// fügt einen Nachbaren hinzu
                            }
                        }
                    }
                    _grid[_column, _row, 1] = count.ToString();// Sendet den Count Wert zum Depth 1
                }
            }
        }
        public void Neighbours2()
        {
            for (_row = 0; _row < _inputRow; _row++) // Zählt die Reihen
            {
                for (_column = 0; _column < _inputColumn; _column++)// Hier die  Spalte
                {
                    var v = 0;// Auch definiert als Nachbar

                    for (var i = _row - 1; i < _row + 2; i++)// Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= _inputRow)// Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue;// Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _column - 1; j < _column + 2; j++)// Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= _inputColumn)// Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue;// Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[j, i, 0] == Virus)// Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                                v++;// fügt einen Nachbaren hinzu
                            }
                        }
                    }
                    _grid[_column, _row, 2] = v.ToString();// Sendet den Count Wert zum Depth 1
                }
            }
        }
        public void Neighbours3()
        {
            for (_row = 0; _row < _inputRow; _row++) // Zählt die Reihen
            {
                for (_column = 0; _column < _inputColumn; _column++)// Hier die  Spalte
                {
                    var count = 0;// Auch definiert als Nachbar

                    for (var i = _row - 1; i < _row + 2; i++)// Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= _inputRow)// Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue;// Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _column - 1; j < _column + 2; j++)// Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= _inputColumn)// Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue;// Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[j, i, 0] == Play)// Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                                count++;// fügt einen Nachbaren hinzu
                            }
                        }
                    }
                    _grid[_column, _row, 4] = count.ToString();// Sendet den Count Wert zum Depth 1
                }
            }
        }
        public void Neighbours4()
        {
            for (_row = 0; _row < _inputRow; _row++) // Zählt die Reihen
            {
                for (_column = 0; _column < _inputColumn; _column++)// Hier die  Spalte
                {
                    var v = 0;// Auch definiert als Nachbar

                    for (var i = _row - 1; i < _row + 2; i++)// Hier werden die Reihen nach Nachbaren geprüft
                    {
                        if (i < 0 || i >= _inputRow)// Wenn die Nachbarzelle Rechts oder Links der Grenze ist
                        {
                            continue;// Falls ausgeführt geht zurück zu das letzte For
                        }
                        for (var j = _column - 1; j < _column + 2; j++)// Hier werden die Spalten nach Nachbaren geprüft
                        {
                            if (j < 0 || j >= _inputColumn)// Wenn die Nachbarzelle oberhalb  oder Unterhalb der Grenze ist
                            {
                                continue;// Falls ausgeführt geht zurück zu das letzte For
                            }
                            if (_grid[j, i, 0] == Play2)// Wenn die Nachbarzelle am leben ist so geht es hier durch zu count++
                            {
                                v++;// fügt einen Nachbaren hinzu
                            }
                        }
                    }
                    _grid[_column, _row, 5] = v.ToString();// Sendet den Count Wert zum Depth 1
                }
            }
        }
        /// <summary>
        /// Jede Generation wird hier geupdated
        /// </summary>
        public void UpdateGrid()
        {
            foreach (Control thispanel in panMain.Controls)// Kontrolliert jedes Panel in panMain
            {
                _row = thispanel.Top / CellSize;// Fängt Wegen Top oben an
                _column = thispanel.Left / CellSize;// Und hier wird definiert das es Links anfängt, also fängt es Links oben an
                var count = Convert.ToInt32(_grid[_column, _row, 1]);// entnimmt die Anzahl der Nachbaren
                var v = Convert.ToInt32(_grid[_column, _row, 2]);// entnimmt die Anzahl der Nahcbaren
                if (thispanel.BackColor == Color.Blue)// Weil es sich selber auch als Nachbar definiert wird hier das eigene Feld überprüft, falls man Blau ist wird ein Nachbar entfernt
                {
                    count = count - 1;
                }

                if (_grid[_column, _row, 0] == Alive)// Falls die Zelle am Leben ist wird hier überprüft wie viele Nachbaren er hat
                {
                    if (v >= 3 && count < 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                    {
                        _grid[_column, _row, 0] = Dead;

                        thispanel.BackColor = Color.LightGray;
                    }
                    else if (v < 3)
                    {
                        if (count < 2 || count > 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                        {
                            _grid[_column, _row, 0] = Dead;

                            thispanel.BackColor = Color.LightGray;
                        }
                        else// Sonst wird sie Leben
                        {
                            _grid[_column, _row, 0] = Alive;
                            thispanel.BackColor = Color.Blue;
                        }
                    }

                }
                else //Ausserdem falls die Zelle Tod oder unbewohnt ist und sie hat drei Lebende Nachbaren so wird auch sie Lebendig
                {
                    if (count == 3 && _grid[_column, _row, 0] == Dead || count == 3 && _grid[_column, _row, 0] == Unbewohnt)
                    {
                        _grid[_column, _row, 0] = Alive;
                        thispanel.BackColor = Color.Blue;
                    }
                }
            }
        }
        public void UpdateGrid2()
        {
            foreach (Control thispanel in panMain.Controls)// Kontrolliert jedes Panel in panMain
            {
                _row = thispanel.Top / CellSize;// Fängt Wegen Top oben an
                _column = thispanel.Left / CellSize;// Und hier wird definiert das es Links anfängt, also fängt es Links oben an
                var v = Convert.ToInt32(_grid[_column, _row, 2]);// entnimmt die Anzahl der Nahcbaren

                if (thispanel.BackColor == Color.Red)// Weil es sich selber auch als Nachbar definiert wird hier das eigene Feld überprüft, falls man Blau ist wird ein Nachbar entfernt
                {
                    v = v - 1;
                }
                if (_grid[_column, _row, 0] == Virus)// Falls die Zelle am Leben ist wird hier überprüft wie viele Nachbaren er hat
                {
                    if (v < 2 || v > 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                    {
                        _grid[_column, _row, 0] = Dead;

                        thispanel.BackColor = Color.DarkGray;
                    }
                    else// Sonst wird sie Leben
                    {
                        _grid[_column, _row, 0] = Virus;
                        thispanel.BackColor = Color.Red;
                    }
                }
                else //Ausserdem falls die Zelle Tod oder unbewohnt ist und sie hat drei Lebende Nachbaren so wird auch sie Lebendig
                {
                    if (v == 3 && _grid[_column, _row, 0] == Dead || v == 3 && _grid[_column, _row, 0] == Unbewohnt)
                    {
                        _grid[_column, _row, 0] = Virus;
                        thispanel.BackColor = Color.Red;
                    }
                }

            }
        }
        public void UpdateGrid3()
        {
            foreach (Control thispanel in panMain.Controls)// Kontrolliert jedes Panel in panMain
            {
                _row = thispanel.Top / CellSize;// Fängt Wegen Top oben an
                _column = thispanel.Left / CellSize;// Und hier wird definiert das es Links anfängt, also fängt es Links oben an
                var count = Convert.ToInt32(_grid[_column, _row, 4]);// entnimmt die Anzahl der Nachbaren
                var v = Convert.ToInt32(_grid[_column, _row, 5]);// entnimmt die Anzahl der Nahcbaren
                if (thispanel.BackColor == Color.DarkGoldenrod)// Weil es sich selber auch als Nachbar definiert wird hier das eigene Feld überprüft, falls man Blau ist wird ein Nachbar entfernt
                {
                    count = count - 1;
                }

                if (_grid[_column, _row, 0] == Play)// Falls die Zelle am Leben ist wird hier überprüft wie viele Nachbaren er hat
                {
                    if (v >= 3 && count < 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                    {
                        _grid[_column, _row, 0] = Dead;

                        thispanel.BackColor = Color.Yellow;
                    }
                    else if (v < 3)
                    {
                        if (count < 2 || count > 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                        {
                            _grid[_column, _row, 0] = Dead;

                            thispanel.BackColor = Color.Yellow;
                        }
                        else// Sonst wird sie Leben
                        {
                            _grid[_column, _row, 0] = Play;
                            thispanel.BackColor = Color.DarkGoldenrod;
                        }
                    }

                }
                else //Ausserdem falls die Zelle Tod oder unbewohnt ist und sie hat drei Lebende Nachbaren so wird auch sie Lebendig
                {
                    if (count == 3 && _grid[_column, _row, 0] == Dead || count == 3 && _grid[_column, _row, 0] == Unbewohnt)
                    {
                        _grid[_column, _row, 0] = Play;
                        thispanel.BackColor = Color.DarkGoldenrod;
                    }
                }
            }
        }
        public void UpdateGrid4()
        {
            foreach (Control thispanel in panMain.Controls)// Kontrolliert jedes Panel in panMain
            {
                _row = thispanel.Top / CellSize;// Fängt Wegen Top oben an
                _column = thispanel.Left / CellSize;// Und hier wird definiert das es Links anfängt, also fängt es Links oben an
                var v = Convert.ToInt32(_grid[_column, _row, 5]);// entnimmt die Anzahl der Nahcbaren

                if (thispanel.BackColor == Color.Purple)// Weil es sich selber auch als Nachbar definiert wird hier das eigene Feld überprüft, falls man Blau ist wird ein Nachbar entfernt
                {
                    v = v - 1;
                }
                if (_grid[_column, _row, 0] == Play2)// Falls die Zelle am Leben ist wird hier überprüft wie viele Nachbaren er hat
                {
                    if (v < 2 || v > 3)// Bei Weniger als 2 oder mehr als 3 wird die Zelle Sterben
                    {
                        _grid[_column, _row, 0] = Dead;

                        thispanel.BackColor = Color.Pink;
                    }
                    else// Sonst wird sie Leben
                    {
                        _grid[_column, _row, 0] = Play2;
                        thispanel.BackColor = Color.Purple;
                    }
                }
                else //Ausserdem falls die Zelle Tod oder unbewohnt ist und sie hat drei Lebende Nachbaren so wird auch sie Lebendig
                {
                    if (v == 3 && _grid[_column, _row, 0] == Dead || v == 3 && _grid[_column, _row, 0] == Unbewohnt)
                    {
                        _grid[_column, _row, 0] = Play2;
                        thispanel.BackColor = Color.Purple;
                    }
                }

            }
        }
        /// <summary>
        ///  Übergang Station wenn eine Neue Generation gebildet wird
        /// </summary>
        public void NächsteGen()
        {
            Neighbours();
            Neighbours2();
            if (Cange== true)
            {
                Neighbours3();
                Neighbours4();
            }
            UpdateGrid();


            UpdateGrid2();
            if (Cange == true)
            {
                UpdateGrid3();


                UpdateGrid4();
            }
                _gen = _gen + 1;
            if (walls== true)
            {
                Wallsfall();
                walls = false;
            }
        }

        /// <summary>
        /// Stoppt den Timer und das Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /// <summary>
        /// Startet den Timer und das Program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrun_Click_1(object sender, EventArgs e)
        {
            btncorss2.Enabled = false;
            btnKross.Enabled = true;
            timer1.Start();
            _gen = _gen + 1;
        }



        /// <summary>
        /// Nach jedem Tick wird der Timer Gestoppt, die Neue Generation gebildet und wieder Fortgesetzt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            labgen.Text = _gen.ToString("");
            NächsteGen();

            timer1.Start();
        }


        /// <summary>
        /// Alternative zum Timer & Run, ist gedacht denn Process in einzelnen Schritten zu sehen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnmanuel_Click(object sender, EventArgs e)
        {


            NächsteGen();
            labgen.Text = _gen.ToString("");
        }
        /// <summary>
        /// dieser Knopf war zuerst als Test gedacht, aber jetzt bleibt er doch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclear_Click(object sender, EventArgs e)
        {
            _gen = 0;
            labgen.Text = _gen.ToString("");
            // Er reinigt das Ganze feld und setzt alle Felder auf Unbewohnt
            timer1.Stop();// Ausserdem stoppt btnclear auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls)//reinigt jede einzelne Zelle
            {
                for (int i = 0; i < _inputRow; i++)//Geht durch die Reihen
                {
                    for (int j = 0; j < _inputColumn; j++)//Geht durch die Spalten
                    {
                        _grid[j, i, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;

                    }
                }
            }
        }
        /// <summary>
        /// Dieser Knopf ist das gegenteil von btnclear, er füllt alle Felder mit Leben, war auch nur als Testknopf gedacht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnfill_Click_1(object sender, EventArgs e)
        {
            _gen = 0;
            labgen.Text = _gen.ToString("");
            timer1.Stop();// Ausserdem stoppt btnfill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {
                for (int i = 0; i < _inputRow; i++)//Geht durch die Reihen
                {
                    for (int j = 0; j < _inputColumn; j++)//Geht durch die Spalten
                    {

                        _grid[j, i, 0] = Alive;
                        thispanel.BackColor = Color.Blue;


                    }
                }
            }

        }
        /// <summary>
        /// Dieser Knopf Eliminiert das Restliche Leben aber man sieht immernoch die Stellen an dem Zellen gestorben sind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnkill_Click_1(object sender, EventArgs e)
        {

            timer1.Stop();// Ausserdem stoppt btnkill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {
                for (int i = 0; i < _inputRow; i++)//Geht durch die Reihen
                {
                    for (int j = 0; j < _inputColumn; j++)//Geht durch die Spalten
                    {
                        if (thispanel.BackColor == Color.Blue )
                        {
                            _grid[j, i, 0] = Dead;
                            thispanel.BackColor = Color.LightGray;
                        }
                        else if (thispanel.BackColor == Color.Red)
                        {
                            _grid[j, i, 0] = Dead;
                            thispanel.BackColor = Color.DarkGray;

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
        /// Dieser Knopf ermöglicht die Veräderung der Grösse des Spielfeldes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnsize_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
            
            btnsize.Enabled = false;
            if (int.TryParse(txtwidth.Text, out _inputRow))//Entnimmt den Wert aus txtwidth und setzt ihn in _inputRow
            {


                if (int.TryParse(txtheight.Text, out _inputColumn))//Entnimmt den Wert aus txtheight und setzt ihn in _inputColumn
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
                    if (_inputRow > MaxRows)
                    {
                        _inputRow = MaxRows;
                    }
                    if (_inputColumn > MaxColumns)
                    {
                        _inputColumn = MaxColumns;
                    }
                    panMain.Size = new Size(CellSize * _inputRow, CellSize * _inputColumn);// vergrössert oder verkleinert das Feld zu der Neuen Grösse
                                                                                           //   
                                                                                           // 
                    panMain.Visible = false;
                    for (_column = 0; _column < _inputColumn; _column++)// Generiert die Zellen der Spalten
                    {
                        for (_row = 0; _row < _inputRow; _row++)// Generiert die Zellen der Reihen
                        {

                            GenerateGrid();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                        }
                    }
                    panMain.Visible = true;
                    //aktiviert alle Knöpfe
                    btnrun.Enabled = true;
                    btnstop.Enabled = true;
                    btnmanuel.Enabled = true;
                    btnclear.Enabled = true;
                    btnfill.Enabled = true;
                    btnkill.Enabled = true;
                    btncorss2.Enabled = true;
                }


            }

        }
        /// <summary>
        /// Knopf ist dafür da das man die Applikation nicht immer runterfahren muss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrestart_Click(object sender, EventArgs e)
        {// Es öffnet nicht sich selber nochmal sondern die gleich benannte Exe, diese Läuft um einiges schneller.
            for (_column = 0; _column < _inputColumn; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < _inputRow; _row++)// Generiert die Zellen der Reihen
                {

                    panMain.Dispose();//Geht rüber zu GenerateGrid um die Zelle zu Generieren
                }

            }
            frmGameOfLifeex fnp = new frmGameOfLifeex();
            Hide();
            fnp.ShowDialog();
            Close();
        }


        //Die Zwei Folgenden Methoden konnte ich leider nur mit Hilfe herausfinden
        /// <summary>
        /// //Hier wird dafür gesorgt das man für das generieren des Feldes nur Zahlen verwenden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtwidth_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtwidth.Text, "[^0-9]"))//falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {

                txtwidth.Text = "";//Macht das Feld wieder Leer

            }
        }

        /// <summary>
        /// //Hier wird auch dafür gesorgt das man für das generieren des Feldes nur Zahlen verwenden kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtheight_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtheight.Text, "[^0-9]"))//falls keine Zahl geschrieben wird so wird das Feld Leer gemacht
            {

                txtheight.Text = "";//Macht das Feld wieder Leer
            }
        }

        private void btnzuruck_Click(object sender, EventArgs e)
        {
           // foreach (Control panel in panMain.Controls)
           // {
               
              //  panMain.Controls.Clear();
                //panel.Dispose();
           // }
           
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

        private void btnKross_Click(object sender, EventArgs e)
        {
            _gen = 0;
            labgen.Text = _gen.ToString("");
            timer1.Stop();// Ausserdem stoppt btnfill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss
            int r = 0;
            int c = 0;
            int d = 0;

            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {
                if (_row> _column)
                {
                    if (r == _row / 2 || c == _column / 2)
                    {
                        _grid[r, c, 0] = Wall;
                        thispanel.BackColor = Color.Brown;
                        r++;
                        if (r == _column + 1)
                        {
                            c++;
                            r = 0;
                        }
                        d++;
                    }
                    else if (r < _row / 2 + 1 || r > _row / 2)
                    {
                        _grid[r, c, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;

                        if (_row > _column)
                        {
                            if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else if (_row < _column)
                        {
                            if (r < _row)
                            {
                                r++;
                            }
                            else if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else
                        {
                            if (r < _row)
                            {
                                r++;
                            }

                            else
                            {
                                c++;
                                r = 0;
                            }
                        }


                    }
                }
                else if (_column> _row)
                {
                    if (r == _column / 2 || c == _row / 2)
                    {
                        _grid[r, c, 0] = Wall;
                        thispanel.BackColor = Color.Brown;
                        r++;
                        if (r == _column + 1)
                        {
                            c++;
                            r = 0;
                        }
                        d++;
                    }
                    else if (r < _row / 2 + 1 || r > _row / 2)
                    {
                        _grid[r, c, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;

                        if (_row > _column)
                        {
                            if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else if (_row < _column)
                        {
                            if (r < _row)
                            {
                                r++;
                            }
                            else if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else
                        {
                            if (r < _row)
                            {
                                r++;
                            }

                            else
                            {
                                c++;
                                r = 0;
                            }
                        }


                    }

                }
                else
                {
                    if (r == _row / 2 || c == _column / 2)
                    {
                        _grid[r, c, 0] = Wall;
                        thispanel.BackColor = Color.Brown;
                        r++;
                        if (r == _column + 1)
                        {
                            c++;
                            r = 0;
                        }
                        d++;
                    }
                    else if (r < _row / 2 + 1 || r > _row / 2)
                    {
                        _grid[r, c, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;

                        if (_row > _column)
                        {
                            if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else if (_row < _column)
                        {
                            if (r < _row)
                            {
                                r++;
                            }
                            else if (r < _column)
                            {
                                r++;
                            }
                            else
                            {
                                c++;
                                r = 0;
                            }

                        }
                        else
                        {
                            if (r < _row)
                            {
                                r++;
                            }

                            else
                            {
                                c++;
                                r = 0;
                            }
                        }


                    }
                

            }




            }

        }
        private void btncorss2_Click(object sender, EventArgs e)
        {
            _gen = 0;
            labgen.Text = _gen.ToString("");
            timer1.Stop();// Ausserdem stoppt btnfill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss
            int r = 0;
            int c = 0;
            int d = 0;
            
            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {

                if (r == _row / 2 || c == _column / 2)
                {
                    _grid[r, c, 0] = Wall;
                    thispanel.BackColor = Color.Brown;
                    r++;
                    if (r == _row)
                    {
                        c++;
                        r = 0;
                    }
                    d++;
                }
                else if (r < _row / 2 + 1 || r > _row / 2)
                {
                    _grid[r, c, 0] = Unbewohnt;
                    thispanel.BackColor = Color.LightGreen;
                    if (r < _row - 1)
                    {
                        r++;
                    }
                    else
                    {
                        c++;
                        r = 0;
                    }

                }

            }

        }
        private void btnresult_Click(object sender, EventArgs e)
        {

            labgen.Text = _gen.ToString("");
            timer1.Stop();// Ausserdem stoppt btnfill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss
            int r = 0;
            int b = 0;
            int y = 0;
            int p = 0;
            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {
                if (Cange == false)
                {
                    if (thispanel.BackColor == Color.Red)
                    {
                        r = r + 2;

                    }
                    else if (thispanel.BackColor == Color.DarkGray)
                    {
                        r = r + 1;

                    }
                    else if (thispanel.BackColor == Color.Blue)
                    {
                        b = b + 2;

                    }
                    else if (thispanel.BackColor == Color.LightGray)
                    {
                        b = b + 1;

                    }
                    else
                    {

                    }
                }

                else if (Cange == true)
                {
                    if (thispanel.BackColor == Color.Red)
                    {
                        r = r + 2;

                    }
                    else if (thispanel.BackColor == Color.DarkGray)
                    {
                        r = r + 1;

                    }
                    else if (thispanel.BackColor == Color.Blue)
                    {
                        b = b + 2;

                    }
                    else if (thispanel.BackColor == Color.LightGray)
                    {
                        b = b + 1;

                    }
                    if (thispanel.BackColor == Color.DarkGoldenrod)
                    {
                        y = y + 2;

                    }
                    else if (thispanel.BackColor == Color.Yellow)
                    {
                        y = y + 1;

                    }
                    if (thispanel.BackColor == Color.Purple)
                    {
                        p = p + 2;

                    }
                    else if (thispanel.BackColor == Color.Pink)
                    {
                        p = p + 1;

                    }

                }
                if (Cange== false)
                {
                    lblblue.Text = b.ToString()+" blue";
                    lblred.Text = r.ToString()+" red";
                    if (r < b)
                    {
                        lblwinner.Text = "Blue Winns";
                    }
                    else if (r > b)
                    {
                        lblwinner.Text = "Red Winns";
                    }
                    else if (r == b)
                    {
                        lblwinner.Text = "Gleichstand";
                    }

                }
                else
                {
                    lblblue.Text = b.ToString()+" blue";
                    lblred.Text = r.ToString()+" red";
                    lblYellow.Text = y.ToString()+" yellow";
                    lblpurple.Text = p.ToString()+" purple";

                    if (r> b && r> y&& r> p)
                    {
                        lblwinner.Text = "Red Winns";
                    }
                    else if (b > r && b > y && b > p)
                    {
                        lblwinner.Text = "Blue Winns";
                    }
                    else if (y > r && y > b && y > p)
                    {
                        lblwinner.Text = "Yellow Winns";
                    }
                    else if (p > r && p > y && p > b)
                    {
                        lblwinner.Text = "Purple Winns";
                    }
                    else
                    {
                        lblwinner.Text = "Gleichstand";
                    }

                }


                } 

            }
        bool Cange = false;
        private void btncolorchange_Click(object sender, EventArgs e)
        {
            if (Cange== true)
            {
                btncolorchange.BackColor = Color.LightPink;
                Cange = false;
                
            }
            else
            {
                btncolorchange.BackColor = Color.LightGreen;
                Cange = true;
            }

            
        }
        public void Wallsfall()
        {
            int r = 0;
            int c = 0;
            foreach (Control thispanel in panMain.Controls)//füllt jede einzelne Zelle
            {


                if (thispanel.BackColor == Color.Brown)
                {
                    if (c < _inputColumn-1)
                    {
                        _grid[c, r, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;
                        c++;
                    }
                    else if (c == _inputColumn-1)
                    {
                        _grid[c, r, 0] = Unbewohnt;
                        thispanel.BackColor = Color.LightGreen;
                        r++;
                        c = 0;
                    }




                }
                else
                {
                    if (c < _inputColumn-1)
                    {
                        c++;
                    }
                    else if (c == _inputColumn-1)
                    {
                        r++;
                        c = 0;
                    }



                }


                }

        }
        bool walls = false;
        private void btnWallfall_Click(object sender, EventArgs e)
        {

            if (walls == true)
            {
               
                walls = false;

            }
            else
            {
              
                walls = true;
            }
           // Ausserdem stoppt btnkill auch denn Timer damit man nicht zusätzlich noch auf Stop klicken muss

           

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            const double factor = 0.95;
            double interval = 1000;
            interval *= factor; // Same as: interval = interval * factor;
            timer2.Interval = (int)interval;

        }
    }
}
