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
        Bitmap World2 = Properties.Resources.World2;
        Bitmap Worldmap3 = Properties.Resources.Worldmap3;

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
            if (Levelstory == 2)
            {
                picmap.BackgroundImage = World2;
                txtchapter.Text = "Es enstand ein Vertrag bei der sich die Länder nicht gegenseitig angreifen dürfen, jedoch schon etwa nach Hundert Jahrem brach der Zealestrische Orden den Vertrag, er griff Orklas an und eroberte dessen Hauptstadt, bis heute ist die Stadt in ihren Händen, Orklas der zwar keinen Helden oder grosse Armee hatte, Unterstützte die grossen Reiche mit Nahrung und anderen Waren, während dessen die Anderen Länder kämpften. Zwar sahen es die Anderen Länder nicht gern, dass der Orden einen Kleinen Krieg geführt hatte, aber sie konnten sich nicht einigen wer sie anführen sollte, Orklas behielt nur ein kleines Stück des Landes auf dem Kontinent und beugte sich der Herrschaft des Ordens, bis zum heutigen Tag sind sie dessen Versallen, wenn auch nicht gerne. Heutzutage hunger ein grosser Teil der Bevölkerung weil sie denn Orden sehr viel Nahrung als Tribut geben müssen.";
                lblstory.Text = "Oben Rechts is The Zeal Order, auf der Östlichen Insel plus auf der Östlichen Spitze von Ressos liegt Orklas ";
            }
            if (Levelstory == 3)
            {
                picmap.BackgroundImage = Worldmap3;
                txtchapter.Text = "Wencyra kehrt nach dem Krieg gegen das Fealen Empire zurück nach Dravon, Stadt der Magier und Magiefähigen, wer der Magiefähig war ging meist nach Dravos, um sie zu meistern, talentierte bekamen sogar den Titel Magier, während Genies zu Erzmagiern wurden. Sie kamen von allen Ländern, bis auf den Regionen des Zelestrischen Orden; dort war jegliche Magie verpönt, einzig Heilungsmagie war gestattet, der Grund gegen den Magier Rassismus stammte von etwa 200 Jahren vor den Krieg gegen das Empire; die Magier sahen sich damals als überlegen an, sich einen Staatsputsch. Ihr einziges Problem war, man hatte dem Putsch erahnt, der Aufstand wurde kurze Hand niedergeschlagen und alle Magie, bis auf Heilungsmagie verboten. Dravos hielt sich im Krieg mehrheitlich neutral, die Schüler der jeweiligen waren es, die in den Krieg zogen, so auch Wencyra. Sie kehrte nach Vorlondin zurück und führte diese als Heldin an. ";
                lblstory.Text = "Dravos liegt auf einer Vulkan Insel im südwesten von Ressos ";
            }
        }
    }
}
