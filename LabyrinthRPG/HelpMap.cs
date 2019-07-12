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
        private void frmHelpMap_Load(object sender, EventArgs e)
        {
            if (Mapss == "Ressos")
            {
                picMap.BackgroundImage = Worldmap;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }
    }
}
