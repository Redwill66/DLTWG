using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GameofLifedanielT.frmHelp_Page;
namespace GameofLifedanielT
{
    public partial class frmHelpMap : Form
    {
        public frmHelpMap()
        {
            InitializeComponent();
        }
        Bitmap Worldmap = Properties.Resources.Worldmap;
        Bitmap Grimos = Properties.Resources.Grimos;

        private void frmHelpMap_Load(object sender, EventArgs e)
        {
            if (Mapss == "Ressos")
            {
                picMap.BackgroundImage = Worldmap;
            }
            if (Mapss == "Grimos")
            {
                picMap.BackgroundImage = Grimos;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
