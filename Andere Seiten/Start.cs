using GameofLifedanielTextend;
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
    public partial class frmstart : Form
    {
        public frmstart()
        {
            InitializeComponent();
        }

        private void btnGameoflifeO_Click(object sender, EventArgs e)
        {
            frmGameOfLife fnp = new frmGameOfLife();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnGameofLifeexperiment_Click(object sender, EventArgs e)
        {
            frmGameOfLifeex fnp = new frmGameOfLifeex();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnchess_Click(object sender, EventArgs e)
        {
            frmChess fnp = new frmChess();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnmine_Click(object sender, EventArgs e)
        {
            Minesweeper fnp = new Minesweeper();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnfourwin_Click(object sender, EventArgs e)
        {
            frmFourWin fnp = new frmFourWin();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnewplayer_Click(object sender, EventArgs e)
        {
            frmNewPlayer fnp = new frmNewPlayer();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnFourLeaderboard_Click(object sender, EventArgs e)
        {
            frmRanglisteFourWin fnp = new frmRanglisteFourWin();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnGreed_Click(object sender, EventArgs e)
        {
            // Erinnerung an Daniel Brett mit 10 Farben Farbe 1 gibt 10 Punkte bei Klick plus 10 punkt für jedes Feld das Angrenzt und die gleiche Farbe hat. Klick auf die 10 Farbe eliminiert die Farben. Klick auf Farbe 1 macht es zu Farbe 2
        }

        private void btnsnake_Click(object sender, EventArgs e)
        {
            frmSnake fnp = new frmSnake();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            Memory fnp = new Memory();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnlaba_Click(object sender, EventArgs e)
        {
            Labyrinth fnp = new Labyrinth();
            Hide();
            fnp.ShowDialog();
            Close();
        }
    }
}
