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
    public partial class frmLabStory : Form
    {
        public frmLabStory()
        {
            InitializeComponent();
        }
        Bitmap Worldmap = Properties.Resources.Worldmap;

        private void btnclose_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void frmLabStory_Load(object sender, EventArgs e)
        {
            if (Levelstory==1)
            {
                picmap.BackgroundImage = Worldmap;
                txtchapter.Text = "Vor fünf Tausend Jahren erhob sich ein Reich, das Ziel dieses Reiches war die komplette Herrschaft über Welt, die Welt wurde zu Glück von so einem Schicksal verschont, fünf Helden stiegen aus der Bevölkerung der verschiedenen Reiche, sie vereinten sie, was die Könige deren Reiche nicht erreichen konnten. Mit vereinter drängten sie das Fealen Empire zurück. Die Entscheide Schlacht wurde bei der Ewigen Passage geschlagen, die Brücke die Ressos und Grimos verbanden. Daraufhin wurden die 5 Helden als vom Himmel geschickt gefeiert.Castrosa aus Estor, Saveyn aus Sahawreed, Festor aus dem Zealestrischen Orden, Wencyra aus Vorlondin, Cresgen der Kronprinz vom Fealen Empire.Cresgen’s Vater verstarb in der Schlacht, Cresgen wurde folglich zum König, sein erster Befehl war mit den restlichen Truppen zurück auf Grimos zu gehen.";
                lblstory.Text = "Die Map zeigt Ressos mit einen Kleinen Teil von Grimos(Oben Links)";
            }
            
        }
    }
}
