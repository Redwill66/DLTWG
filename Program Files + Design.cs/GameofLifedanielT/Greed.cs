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
    public partial class frmGreed : Form
    {
        public frmGreed()
        {
            InitializeComponent();
        }
        private int _rows;
        private int _row;
        private int _column;
        private int _columns;
        private const int CellSize = 35;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;
        Greedfunk Greedy = new Greedfunk();
        private void btnback_Click(object sender, EventArgs e)
        {
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void frmGreed_Load(object sender, EventArgs e)
        {
            for (_column = 0; _column < 15; _column++)// Generiert die Zellen der Spalten
            {
                for (_row = 0; _row < 15; _row++)// Generiert die Zellen der Reihen
                {

                    PictureBox Pic = Greedy.GenerateGrid();
                    Pic.Location = new Point(_column * CellSize, _row * CellSize);
                   // Pic.Click += Pic_Click;
                    // Pic.BackgroundImage = Empty;
                    // _grid[_column, _row, 0] = Free;
                    // Pic.BackgroundImageLayout = ImageLayout.Zoom;
                    panMain.Controls.Add(Pic);

                }
            }
        }

        private void panMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
