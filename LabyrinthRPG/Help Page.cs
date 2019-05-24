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
    public partial class frmHelp_Page : Form
    {
        public frmHelp_Page()
        {
            InitializeComponent();
        }
        Bitmap Gov = Properties.Resources.Governor;
        Bitmap Wap1 = Properties.Resources.Wappen1;
        Bitmap Gift = Properties.Resources.Gift_neu;
        Bitmap one = Properties.Resources._1;
        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void lstHelpLore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( lstHelpLore.Text== "Baron Denoixis")
            {
                picnpc.BackgroundImage = Gov;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Baron Denoixis Oxter";
                lblwappen.Text = "Haus Oxter";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
           else if (lstHelpLore.Text == "Gift")
            {
                picnpc.BackgroundImage = Gift;
                picwappen.BackgroundImage = one;
                lblName.Text = "Gift";
                lblwappen.Text = "Schaden";
                txtHelp.Text = " Gift, bleibt so wie es ist. Wenn ihr auf ein Gift Feld steht so wird euch ein Punkt Leben genommen, ausser ihr besitzt Rüstung, in disem Fall wird eure Rüstung beschädigt. Gift wird nur sichbar bei betreten, Meist nur in Grossen Räumen, sonst meist mit einem Hinweis darauf hingewiesen.(Vielleicht implementiere ich Gegengift) ";

            }
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            lstHelpLore.Items.Clear();
            lstHelpLore.Items.Add("Bewegen");
            lstHelpLore.Items.Add("Leben");
            lstHelpLore.Items.Add("Heiltränke");
            lstHelpLore.Items.Add("Rüstungdicke");
            lstHelpLore.Items.Add("Gift");
            lstHelpLore.Items.Add("Hinweise");
            lstHelpLore.Items.Add("Türen und Schlüssel");
            lstHelpLore.Items.Add("Bomben und Felsen");
            lstHelpLore.Items.Add("Gold");
            lstHelpLore.Items.Add("Max Leben");
            lstHelpLore.Items.Add("Dialoge");
            lstHelpLore.Items.Add("Kommentare");
            lstHelpLore.Items.Add("Schleifsteine");
            lstHelpLore.Items.Add("Dornenbüsche");
            lstHelpLore.Items.Add("Dornenwand");
            lstHelpLore.Items.Add("Lava");
            lstHelpLore.Items.Add("Handel");
            lstHelpLore.Items.Add("Tribut");
            lstHelpLore.Items.Add("Encounters");
            lstHelpLore.Items.Add("Bosse");
            lstHelpLore.Items.Add("Tokens");
            lstHelpLore.Items.Add("Priester Heilung");
            lstHelpLore.Items.Add("Cheats");
            lstHelpLore.Items.Add("Elektro Falle");
            lstHelpLore.Items.Add("Feuer");
            lstHelpLore.Items.Add("Eventbereiche");
            lstHelpLore.Items.Add("Kanalisations Wasser");
            lstHelpLore.Items.Add("Magie");
            lstHelpLore.Items.Add("Hebel");
        }

        private void btnLore_Click(object sender, EventArgs e)
        {
            lstHelpLore.Items.Clear();
            lstHelpLore.Items.Add("Ressos");
            lstHelpLore.Items.Add("Estor");
            lstHelpLore.Items.Add("Castrosa");         
            lstHelpLore.Items.Add("Langchester");
            lstHelpLore.Items.Add("Baron Denoixis");
            lstHelpLore.Items.Add("Ulsster");
            lstHelpLore.Items.Add("Vorlondin");
            lstHelpLore.Items.Add("Wencyra");
            lstHelpLore.Items.Add("The Zeal Order");
            lstHelpLore.Items.Add("Festor");
            lstHelpLore.Items.Add("Peskar");
            lstHelpLore.Items.Add("Dravon");
            lstHelpLore.Items.Add("Sahawreed");
            lstHelpLore.Items.Add("Saveyn");
            lstHelpLore.Items.Add("Ewige Passage");
            lstHelpLore.Items.Add("Orklas");
            lstHelpLore.Items.Add("Grimos");
            lstHelpLore.Items.Add("Fealen Empire");
            lstHelpLore.Items.Add("Zrosgen");
            lstHelpLore.Items.Add("Cresgen");

        }
    }
}
