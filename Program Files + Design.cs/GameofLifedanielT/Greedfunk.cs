using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class Greedfunk
    {
        private int _row;
        private int _column;

        private const int CellSize = 35;
        private const int MaxRows = 20;
        private const int MaxColumns = 20;

        public const int size = 8;
        private static int depth = 2;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Empty = "Empty";
        public PictureBox GenerateGrid()
        {


            PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,

                BorderStyle = BorderStyle.FixedSingle

            };

            _grid[_column, _row, 0] = Empty;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.Location = new Point(_row * CellSize, _column * CellSize);
            return panel;
        }
    }
}
