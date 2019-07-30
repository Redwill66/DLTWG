using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameofLifedanielT.Labyrinth;

namespace GameofLifedanielT
{
    public partial class frmMonster : Form
    {
        Bitmap Behemoth = Properties.Resources.Behemoth;
        public frmMonster()
        {
            InitializeComponent();
        }

        private void frmMonster_Load(object sender, EventArgs e)
        {
            if (BigMonster== "Behemoth")
            {
                picMonster.BackgroundImage = Behemoth;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
