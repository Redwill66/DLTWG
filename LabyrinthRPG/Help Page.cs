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
        Bitmap BanditChef = Properties.Resources.BanditChef;
        Bitmap Dieb = Properties.Resources.Dieb;
        Bitmap Gov = Properties.Resources.Governor;
        Bitmap Wap1 = Properties.Resources.Wappen1;
        Bitmap Gift = Properties.Resources.Gift_neu;
        Bitmap one = Properties.Resources._1;
        Bitmap Cast = Properties.Resources.Castrosa;
        Bitmap Altar = Properties.Resources.Altar;
        Bitmap CastH = Properties.Resources.Head_Castrosa;
        Bitmap player = Properties.Resources.PlayerFig;
        Bitmap Gras = Properties.Resources.Rasen2;
        Bitmap Heart = Properties.Resources.Herz;
        Bitmap Schield = Properties.Resources.Schield;
        Bitmap Question = Properties.Resources.Question;
        Bitmap ITur = Properties.Resources.ITur;
        Bitmap Boulder = Properties.Resources.Boulder;
        Bitmap Bomb = Properties.Resources.Bomb;
        Bitmap Money = Properties.Resources.Money;
        Bitmap Buerger = Properties.Resources.Buerger;
        Bitmap PlayerA1c = Properties.Resources.PlayerA1c;
        Bitmap PlayerA10 = Properties.Resources.PlayerA10;
        Bitmap Festor = Properties.Resources.Festor;
        Bitmap Wencyra = Properties.Resources.Wencyra;
        Bitmap DornenBush = Properties.Resources.DornenBush;
        Bitmap Dornenwall = Properties.Resources.Dornenwall;
        Bitmap LavaFinal = Properties.Resources.LavaFinal;
        Bitmap zwei = Properties.Resources._2;
        Bitmap Cresgen = Properties.Resources.Cresgen;
        Bitmap Saveyn = Properties.Resources.Saveyn;
        Bitmap Head_Festor = Properties.Resources.Head_Festor;
        Bitmap Castrosadorf = Properties.Resources.Castrosadorf;
        Bitmap EstorKing = Properties.Resources.EstorKing;
        Bitmap WappenEstor = Properties.Resources.WappenEstor;
        Bitmap Armorkaeufer = Properties.Resources.Armorkaeufer;
        Bitmap Schmied = Properties.Resources.Schmied;
        Bitmap Zollpirat = Properties.Resources.Zollpirat;
        Bitmap Gua = Properties.Resources.Guard_Captain;
        Bitmap Pries = Properties.Resources.Priester;
        Bitmap HSave = Properties.Resources.Head_Saveyn;
        Bitmap Electro = Properties.Resources.Electro;
        Bitmap Fire = Properties.Resources.Fire;
        Bitmap Longchester = Properties.Resources.Longchester;
        Bitmap Nangasto = Properties.Resources.Nangasto;
        Bitmap WappenGrenor = Properties.Resources.WappenGrenor;
        Bitmap Gostasso = Properties.Resources.Gostasso;
        Bitmap König_Ories = Properties.Resources.König_Ories;
        Bitmap Sewer = Properties.Resources.Sewer;
        Bitmap Hebel1 = Properties.Resources.Hebel1;
        Bitmap Hebel2 = Properties.Resources.Hebel2;
        public static string Mapss;
        private void btnback_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
        }

        private void lstHelpLore_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Lore

            #region Ressos

          
            //Lore 
            if (lstHelpLore.Text == "Ressos")
            {
                Mapss = "Ressos";
               

                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Ressos";
                lblwappen.Text = "einer der vier Kontinente";
                txtHelp.Text = "Ressos, Heimat von vielen Völkern, von Menschen zu Elfen bis zu Goblins usw. Ressos gilt als Kontinent mit den meisten verschiedenen Kultur, früher regierten mehrere Elfen Fürsten das Land, diese wurden jedoch durch den Menschen mehrheitlich verdrängt. Der Mensch verband Ressos mit Grimos mit der Grossen Brücke die Ewigen Passage. Selten waren sich die Völker von Ressos einig, meist endeten viele Situtionen in Krieg, die Elfen zogen sich grossen Teil nach Peskar oder wie sie es nennen Paranthil zurück. Zwar kann man sie auch ausserhalb sehen, meist jedoch nur in geringer Zahl. Der Kontinent selber wird durch ein Gebirg in Westen und Osten unterteilt, so wurde sie auch gleich zur natürlichen Grenze der Reiche. Heute gibt es 7 Reiche die ein Teil von Ressos besitzen: Das Fealen Empire, sie besitzen zwar nur einen kleinen Teil aber dieser ist doch sehr Bedeutend. Sahawreed, das Gebirge verhindert das viele Wolken nach Sahawreed kommen, daher hat sich eine Wüste gebildet. Der Zeal Order. Magiehasser und Religonstaat. Estor, Reich wo Geld alles ist. Vorlondin, sie besitzen ein Bündniss mit den Elfen und würden sie in falle einer Invasion helfen. Peskar, Heimat der Elfen. Orklas, Söldnerstaat verlor sehr viel Land und seine Hauptstadt an den Orden.";
                frmHelpMap fnp = new frmHelpMap();
                fnp.ShowDialog();
            }
            #region Estor

          
            if (lstHelpLore.Text == "Estor")
            {
                picnpc.BackgroundImage = EstorKing;
                picwappen.BackgroundImage = WappenEstor;
                lblName.Text = "König von Estor";
                lblwappen.Text = "Land der Fürsten und des Geldes";
                txtHelp.Text = "Estor das Land das vom Geld gelenkt wird. Bei dessen König handelt es sich normalerweise um die reichste Person von Estor(dazu mehr bei Gostasso und Ulsster Kapiteln), Handel liegt allen Bewohner im Blut, es gab nichts, dass sie mehr Interessierte ausser etwas. Castrosa, ihr auftreten bewegt die sonst nur Geld gierigen Bewohner von Estor und verhinderte den beinahe beitritt, von Estor auf die Seite von dem Empire. Nach dem Krieg galt sie in Estor als Göttliche. Daher interessiert die Bevölkerung heutzutage nicht nur Geld, jedoch ist Geld immer noch ein grosser Fokus. Gesetzlich ist das Land ziemlich frei, man muss bedenken, der Reichere hat immer mehr zu sagen als alle andere. Erstaunlicherweise aber führen sie Selten bis gar keinen Krieg, sie sehen diesen als eine Verschwendung von Geld.";
            }
            else if (lstHelpLore.Text == "Castrosa")
            {
                picnpc.BackgroundImage = Cast;
                picwappen.BackgroundImage = CastH;
                lblName.Text = "Castrosa Roscar";
                lblwappen.Text = "Teil einer Bauersfamilie";
                txtHelp.Text = "Castrosa wuchs im kleinen Dorf Seikos auf (Seikos ist östlichste Dorf von Estor), ihr Vater war alter Soldat im Ruhestand, ihr Dorf war eines der ersten Opfer des Empires, damals wusste niemand das Vorhaben des verrückten Kaisers, zwar griff das Empire das Dorf nicht direkt an, aber es heuerte unzählige Piraten an, um die Wirtschaft der Länder zu schwächen; Ziel war der Kollaps der Armeen aufgrund weniger bis keine Versorgung durch Dörfer. Castrosas Vater verstarb beim Angriff, jedoch fand seine Tochter dessen Speer und wehrte mit der Miliz des Dorfes, die Piraten ab; nach dem Angriff nahm sie den Speer und ihr Vaters Gold und schloss sich der Armee an. Dort erfuhr sie mehr von ihrem Vater, er war ein ziemlich berühmter Soldat gewesen, alle sahen auf zu ihr und sie entschloss sich, den Erwartungen zu entsprechen.";
            }
            else if (lstHelpLore.Text == "Baron Denoixis")
            {
                picnpc.BackgroundImage = Gov;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Baron Denoixis Oxter";
                lblwappen.Text = "Haus Oxter";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Longchester")
            {
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Nangasto")
            {
                picnpc.BackgroundImage = Nangasto;
                picwappen.BackgroundImage = WappenGrenor;
                lblName.Text = "Festung der Bucht";
                lblwappen.Text = "In besitzt von Haus Grenor";
                txtHelp.Text = "Haus Grenor ist besitzt Nangasto erst seit den ende des Krieges vor Tausend Jahren, sie besassen als einzige Familie eine gewissen Tropfen von Ehre, sie waren es die Castrosa direkt unterstützten, jedoch ist von dieser Ehre heute nichts mehr vorhanden. Haus Grenor schuldet Haus Oxter sehr viel Geld, daher sind sie wie Marionetten zu Haus Oxter. Es gibt auch gerüchte, dass der Erbe des Hauses verschwunden ist, wohin jedoch weiss niemand.";

            }
            else if (lstHelpLore.Text == "Gostasso")
            {
                picnpc.BackgroundImage = EstorKing;
                picwappen.BackgroundImage = Gostasso;
                lblName.Text = "Haupstadt von Estor";
                lblwappen.Text = "Sitz von Ulsster Regno";
                txtHelp.Text = " Sitz des König, jedoch ist seine Macht sehr beschränkt, so herrscht er eigentlich nur in Zeiten des Krieges. Man könnte meinen der König wäre die reichtse Person von Estor, jedoch ist er das schon lange nicht mehr. Gostasso ist die Südlichste Stadt von Estor und auch dessen grösste. Sie ist Sitz des Goldrates, und etwa Vier Militärakademien. Dadurch das die Stadt nicht an der Grenze ist und auch keine Mehr verbindung hat, schadet dem Handel der Stadt sehr. Daher sind die meisten der Bewohner teil des Mittelstande, doch aufgrund des Standort, da er weit von der Grenzen fort ist und nicht von der See eine Invasion erleiden kann. Ist er der Perfekte platz für die Regierung.  ";

            }
            else if (lstHelpLore.Text == "Ulsster")
            {
                picnpc.BackgroundImage = EstorKing;
                picwappen.BackgroundImage = WappenEstor;
                lblName.Text = "König Ulsster Regno";
                lblwappen.Text = "Wappen von Estor";
                txtHelp.Text = " Ulsster, der wahrscheinlich schwächste König von Estor. Er hat so gut wie jede macht verloren die er hatte and Goldrat verloren, er bestimmt nicht mal mehr gesetze. Grund des Macht verlustes ist die Taten der früheren König. Die Ironie ist, die früheren König setzten Geld ein um das Land zu stärken, jedoch gilt in Estor die Reichen bestimmen die Regeln. Symbolisch ist er immer noch der Anführer, aber in wahrheit besitzt der Goldrat alle Macht. Mancher vermutet, dass eines Tagen der König gestürtzt wird, ob dies mit Ulsster passieren wird wer weiss.";

            }
            #endregion
            #region Vorlondin

        
            else if (lstHelpLore.Text == "Vorlondin")
            {// Bearbeiten
                //Land
                picnpc.BackgroundImage = König_Ories;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "König von Vorlondin";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Wezan")
            {// Bearbeiten
                //Stadt
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Vosgon")
            {// Bearbeiten
                //Hauptstadt
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Ories")
            {// Bearbeiten
                //König
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            #endregion
            #region Dravos


            else if (lstHelpLore.Text == "Darvos")
            {// Bearbeiten
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Feuergorn")
            {// Bearbeiten
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Stadt der Zauberer")
            {// Bearbeiten
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Magierränge")
            {// Bearbeiten
                picnpc.BackgroundImage = Longchester;
                picwappen.BackgroundImage = Wap1;
                lblName.Text = "Hafen des Handels";
                lblwappen.Text = "In besitzt von Haus Oxter";
                txtHelp.Text = "Beherrscht von Haus Oxter, Longchester wird auch als einer der Grössten von Estor angesehen, wer in Estor handeln will und mit dem Schiff kommt der wird in Longchester halt machen. Jedoch sollte man auch viel Verlust erleiden können, denn Tribut oder Zölle machen es den Händler schwer gewinn zu machen, sollte man es jedoch trotzdem schaffen so wird der Ruf eines Händlers in den Himmel schiessen. Die Reichen von Estor sind Geizig, sie zu überzeugen etwas zu kaufen gleicht einer Heldentat. ";

            }
            else if (lstHelpLore.Text == "Wencyra")
            {// Bearbeiten
                picnpc.BackgroundImage = Wencyra;
                picwappen.BackgroundImage = null;
                lblName.Text = "Erzmagierin Wencyra";
                lblwappen.Text = "Familie Unbekannt, stammt aber aus Vorlondin";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            #endregion
            #region The Zeal Order

    
            else if (lstHelpLore.Text == "The Zeal Order")
            {// Bearbeiten
                picnpc.BackgroundImage = Festor;
                picwappen.BackgroundImage = Head_Festor;
                lblName.Text = "Festor der Dritte";
                lblwappen.Text = "Dreissigster Ordens Anführer";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";
            }
            else if (lstHelpLore.Text == "Festor")
            {// Bearbeiten
                picnpc.BackgroundImage = Festor;
                picwappen.BackgroundImage = Head_Festor;
                lblName.Text = "Festor der Dritte";
                lblwappen.Text = "Dreissigster Ordens Anführer";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";
            }
            else if (lstHelpLore.Text == "Holy King")
            {// Bearbeiten
                picnpc.BackgroundImage = Festor;
                picwappen.BackgroundImage = Head_Festor;
                lblName.Text = "Festor der Dritte";
                lblwappen.Text = "Dreissigster Ordens Anführer";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";
            }
            else if (lstHelpLore.Text == "Orklas vs Zeal Order")
            {// Bearbeiten
                picnpc.BackgroundImage = Festor;
                picwappen.BackgroundImage = Head_Festor;
                lblName.Text = "Festor der Dritte";
                lblwappen.Text = "Dreissigster Ordens Anführer";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";
            }
            else if (lstHelpLore.Text == "Magieputsch")
            {// Bearbeiten
                picnpc.BackgroundImage = Festor;
                picwappen.BackgroundImage = Head_Festor;
                lblName.Text = "Festor der Dritte";
                lblwappen.Text = "Dreissigster Ordens Anführer";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";
            }
            #endregion
            #region Orklas
            else if (lstHelpLore.Text == "Orklas")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            #endregion
            #region Peskar
            else if (lstHelpLore.Text == "Peskar")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Die Elfen Reiche")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Zusammenleben")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            #endregion
            #region Sahawreed
            else if (lstHelpLore.Text == "Sahawreed")
            {
                picnpc.BackgroundImage = Saveyn;
                picwappen.BackgroundImage = HSave;
                lblName.Text = "Saveyn Ohmras";
                lblwappen.Text = "Sohn des Wüstenteufels(Berühmter General von Sahawreed)";
                txtHelp.Text = "Saveyn stammt von einer sehr speziellen Familie, sein Vater wurde der Wüstenteufel gennant, dieser hielt die Angriffe des Empires für mehre Monate auf, während Saveyn hilfe von den anderen Länder holte, geht man jedoch noch weiter zurück, so ist der Grossvater von Saveyn der bekannteste Bandit von Sahawreed. Saveyn's Grossvater und Vater wurden schlussendlich überzeugt der Armee beizutreten um bei der Verteidigung zu helfen. Man merkt Saveyn an das er aus einer Wilden Familie stammt, so haltet er nichts von Gerechtigkeit wo der Reiche gewinnt. Man könnte ihn mit einen Robin Hood vergleichen. Als er Cresgen in der Wüste von Sahawreed traff da wüsste er sofort das er Handeln muss, man könnte sagen ohne ihn wären die Helden nie zusammen gekommen. Nach dem Krieg wollte Saveyn nur noch ein einfaches Leben haben, ob er Nachkommen oder eine Frau hatte ist Unbekannt, denn fünf Jahre nach dem Krieg war er spurlos verschwunden";

            }

            else if (lstHelpLore.Text == "Saveyn")
            {
                picnpc.BackgroundImage = Saveyn;
                picwappen.BackgroundImage = HSave;
                lblName.Text = "Saveyn Ohmras";
                lblwappen.Text = "Sohn des Wüstenteufels(Berühmter General von Sahawreed)";
                txtHelp.Text = "Saveyn stammt von einer sehr speziellen Familie, sein Vater wurde der Wüstenteufel gennant, dieser hielt die Angriffe des Empires für mehre Monate auf, während Saveyn hilfe von den anderen Länder holte, geht man jedoch noch weiter zurück, so ist der Grossvater von Saveyn der bekannteste Bandit von Sahawreed. Saveyn's Grossvater und Vater wurden schlussendlich überzeugt der Armee beizutreten um bei der Verteidigung zu helfen. Man merkt Saveyn an das er aus einer Wilden Familie stammt, so haltet er nichts von Gerechtigkeit wo der Reiche gewinnt. Man könnte ihn mit einen Robin Hood vergleichen. Als er Cresgen in der Wüste von Sahawreed traff da wüsste er sofort das er Handeln muss, man könnte sagen ohne ihn wären die Helden nie zusammen gekommen. Nach dem Krieg wollte Saveyn nur noch ein einfaches Leben haben, ob er Nachkommen oder eine Frau hatte ist Unbekannt, denn fünf Jahre nach dem Krieg war er spurlos verschwunden";

            }
            else if (lstHelpLore.Text == "Wüstenteufels")
            {
                picnpc.BackgroundImage = Saveyn;
                picwappen.BackgroundImage = HSave;
                lblName.Text = "Saveyn Ohmras";
                lblwappen.Text = "Sohn des Wüstenteufels(Berühmter General von Sahawreed)";
                txtHelp.Text = "Saveyn stammt von einer sehr speziellen Familie, sein Vater wurde der Wüstenteufel gennant, dieser hielt die Angriffe des Empires für mehre Monate auf, während Saveyn hilfe von den anderen Länder holte, geht man jedoch noch weiter zurück, so ist der Grossvater von Saveyn der bekannteste Bandit von Sahawreed. Saveyn's Grossvater und Vater wurden schlussendlich überzeugt der Armee beizutreten um bei der Verteidigung zu helfen. Man merkt Saveyn an das er aus einer Wilden Familie stammt, so haltet er nichts von Gerechtigkeit wo der Reiche gewinnt. Man könnte ihn mit einen Robin Hood vergleichen. Als er Cresgen in der Wüste von Sahawreed traff da wüsste er sofort das er Handeln muss, man könnte sagen ohne ihn wären die Helden nie zusammen gekommen. Nach dem Krieg wollte Saveyn nur noch ein einfaches Leben haben, ob er Nachkommen oder eine Frau hatte ist Unbekannt, denn fünf Jahre nach dem Krieg war er spurlos verschwunden";

            }
            #endregion
            #endregion
            #region Grimos
            if (lstHelpLore.Text == "Grimos")
            {
                Mapss = "Grimos";


                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Grimos";
                lblwappen.Text = "einer der vier Kontinente";
                txtHelp.Text = "Nicht viel ist von Grimos bekannt. Jedenfalls nicht für die Öffentlichkeit, Grimos kann man in drei Territoriumen unterteilen. Die Grajin Wüste, den Finsterjungle und das Urakk Gebirge. Zwei von drei dieser Territoriumen kontrolliert das Empire, dass Dritte wird von den Zwergen von Trestan bewohnt. Wäre das Gebirge nicht da so hätte das Empire wohl alle Gebiete von Grimos. Früher gabe es noch weitere Reiche auf Grimos, diese wurden jedoch alle Untertanten von dem Empire. Die Wüste war und ist die Heimat von Wüstenzentauren, diese gehen jedoch selten ins Militär von Grimos. Die Zentauren können unabhängig vom Empire Leben, da das Empire nicht extrem viel mit der Wüste anfangen kann. Dies ist jedoch nur einer der Rassen die neben den Menschen von Grimos leben.  ";
                frmHelpMap fnp = new frmHelpMap();
                fnp.ShowDialog();
            }

            #region Trestan
            else if (lstHelpLore.Text == "Trestan")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Ewige Passage")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            #endregion
            #region Fealen Empire

           
            else if (lstHelpLore.Text == "Grimos")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Fealen Empire")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Zrosgen")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }
            else if (lstHelpLore.Text == "Cresgen")
            {// Bearbeiten
                picnpc.BackgroundImage = Cresgen;
                picwappen.BackgroundImage = null;
                lblName.Text = "Prinz Cresgen";
                lblwappen.Text = "Sohn des Verückten Kaisers Zrosgen";
                txtHelp.Text = "Baron von Longchester, Denoixis herrst mit Harter Hand über seine Bevölkerung, wer im nicht gefällt der Verwindet auf Mysteriöse Weise. Einer der Fünf Barone von Estor. Besitzt den erfolgreichsten Hafen von Estor.";

            }

            #endregion
            #endregion
            #region Vekran
            if (lstHelpLore.Text == "Vekran")
            {
                Mapss = "Ressos";


                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Ressos";
                lblwappen.Text = "einer der vier Kontinente";
                txtHelp.Text = "Ressos, Heimat von vielen Völkern, von Menschen zu Elfen bis zu Goblins usw. Ressos gilt als Kontinent mit den meisten verschiedenen Kultur, früher regierten mehrere Elfen Fürsten das Land, diese wurden jedoch durch den Menschen mehrheitlich verdrängt. Der Mensch verband Ressos mit Grimos mit der Grossen Brücke die Ewigen Passage. Selten waren sich die Völker von Ressos einig, meist endeten viele Situtionen in Krieg, die Elfen zogen sich grossen Teil nach Peskar oder wie sie es nennen Paranthil zurück. Zwar kann man sie auch ausserhalb sehen, meist jedoch nur in geringer Zahl. Der Kontinent selber wird durch ein Gebirg in Westen und Osten unterteilt, so wurde sie auch gleich zur natürlichen Grenze der Reiche. Heute gibt es 7 Reiche die ein Teil von Ressos besitzen: Das Fealen Empire, sie besitzen zwar nur einen kleinen Teil aber dieser ist doch sehr Bedeutend. Sahawreed, das Gebirge verhindert das viele Wolken nach Sahawreed kommen, daher hat sich eine Wüste gebildet. Der Zeal Order. Magiehasser und Religonstaat. Estor, Reich wo Geld alles ist. Vorlondin, sie besitzen ein Bündniss mit den Elfen und würden sie in falle einer Invasion helfen. Peskar, Heimat der Elfen. Orklas, Söldnerstaat verlor sehr viel Land und seine Hauptstadt an den Orden.";
                frmHelpMap fnp = new frmHelpMap();
                fnp.ShowDialog();
            }
            #endregion
            #region Kruzo Archipel
            if (lstHelpLore.Text == "Kruzo Archipel")
            {
                Mapss = "Ressos";


                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Ressos";
                lblwappen.Text = "einer der vier Kontinente";
                txtHelp.Text = "Ressos, Heimat von vielen Völkern, von Menschen zu Elfen bis zu Goblins usw. Ressos gilt als Kontinent mit den meisten verschiedenen Kultur, früher regierten mehrere Elfen Fürsten das Land, diese wurden jedoch durch den Menschen mehrheitlich verdrängt. Der Mensch verband Ressos mit Grimos mit der Grossen Brücke die Ewigen Passage. Selten waren sich die Völker von Ressos einig, meist endeten viele Situtionen in Krieg, die Elfen zogen sich grossen Teil nach Peskar oder wie sie es nennen Paranthil zurück. Zwar kann man sie auch ausserhalb sehen, meist jedoch nur in geringer Zahl. Der Kontinent selber wird durch ein Gebirg in Westen und Osten unterteilt, so wurde sie auch gleich zur natürlichen Grenze der Reiche. Heute gibt es 7 Reiche die ein Teil von Ressos besitzen: Das Fealen Empire, sie besitzen zwar nur einen kleinen Teil aber dieser ist doch sehr Bedeutend. Sahawreed, das Gebirge verhindert das viele Wolken nach Sahawreed kommen, daher hat sich eine Wüste gebildet. Der Zeal Order. Magiehasser und Religonstaat. Estor, Reich wo Geld alles ist. Vorlondin, sie besitzen ein Bündniss mit den Elfen und würden sie in falle einer Invasion helfen. Peskar, Heimat der Elfen. Orklas, Söldnerstaat verlor sehr viel Land und seine Hauptstadt an den Orden.";
                frmHelpMap fnp = new frmHelpMap();
                fnp.ShowDialog();
            }
            #endregion
            #region Anderes

            #endregion
            #endregion
            #region Tipps


            //Hilfe
            else if (lstHelpLore.Text == "Gift")
            {
                picnpc.BackgroundImage = Gift;
                picwappen.BackgroundImage = one;
                lblName.Text = "Gift";
                lblwappen.Text = "Schaden";
                txtHelp.Text = " Gift, bleibt so wie es ist. Wenn ihr auf ein Gift Feld steht so wird euch ein Punkt Leben genommen, ausser ihr besitzt Rüstung, in disem Fall wird eure Rüstung beschädigt. Gift wird nur sichbar bei betreten, Meist nur in Grossen Räumen, sonst meist mit einem Hinweis darauf hingewiesen.(Vielleicht implementiere ich Gegengift) ";

            }
            else if (lstHelpLore.Text == "Bewegen")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = Gras;
                lblName.Text = "Spieler";
                lblwappen.Text = "Beispiel von bewegbaren Feld(Feld kann bei Zoom nicht mehr schön aussehen) ";
                txtHelp.Text = "Für den Spieler gibt es Zwei Wege seine Figur zu bewegen, zu einen kann er mit WASD oder mit dem Numberpad(5123), nicht jedes Feld ist begehbar, manche brauchen eine Schlüssel oder etwas anderes.";

            }
            else if (lstHelpLore.Text == "Heiltränke")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = Heart;
                lblName.Text = "Spieler";
                lblwappen.Text = "Kein Bild von Healtränke verfügbar";
                txtHelp.Text = "Einer der Items auf die der Spieler stossen kann, sie dienen dazu bei benutzung 3 Punkte Leben zu heilen.";

            }
            else if (lstHelpLore.Text == "Rüstungmaterial und Rüstung")
            {
                picnpc.BackgroundImage = PlayerA10;
                picwappen.BackgroundImage = Schield;
                lblName.Text = "Spieler";
                lblwappen.Text = "Bild von Rüstungs anzeige";
                txtHelp.Text = "Der Spieler kann auf jeder Map meist Materialen finden mit der er seine Rüsung verstärken kann, Rüstung schützt leider jedoch nich gegen alle Schadensquellen, manche quellen greifen den Spieler direkt an, auch gibt es Damage Felder die nur Schaden machen wenn der spiel Rüstung besitzt, jedoch ist Rüstung von nöten wenn du gegen Bosse und ander Encounter antrittst. Das Bild des Spieler kann sich verändern je nachdem wie viel Rüstung er trägt. Rüstung selber findest du nicht, du findest Material, das du zu Rüstung verarbeiten kannst.";

            }
            else if (lstHelpLore.Text == "Hinweise")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = Question;
                lblName.Text = "Spieler";
                lblwappen.Text = "Hinweisfelder sind Grau ohne etwas drin";
                txtHelp.Text = "Hinweise Felder dienen dazu dir den Spieler auf etwas aufmerksam zu machen sei es Hinweise zu neuen Fallen oder Rätsel wie du die Fallen ohne Schaden überwinden kannst, diese zu ignorieren kann meist nicht gut.";

            }
            else if (lstHelpLore.Text == "Türen und Schlüssel")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = ITur;
                lblName.Text = "Spieler";
                lblwappen.Text = "So sehen die Türen im Spiel nicht aus";
                txtHelp.Text = "Türen sind einer der vielen Blockaden die es im spiel gibt, die Schlüssel die du auf denn Karten findest; dienen dazu diese zu öffnen. Der Sinn der Türe ist, dass der Spieler nicht direkt zu ziel läuft. ";

            }
            else if (lstHelpLore.Text == "Bomben und Felsen")
            {
                picnpc.BackgroundImage = Bomb;
                picwappen.BackgroundImage = Boulder;
                lblName.Text = "Bomben";
                lblwappen.Text = "Der Steinharte Felsen";
                txtHelp.Text = "Wie Türen bilden Felsen eine Barriere, während Türen aber meisrt geöffnet werden müssen, so sind die Felsen meist abkürzungen oder zusätzliche Gebiete mit Loot. Bomben haben aber noch andere gebräuche, dazu aber später.";

            }
            else if (lstHelpLore.Text == "Gold")
            {
                picnpc.BackgroundImage = Money;
                picwappen.BackgroundImage = Money;
                lblName.Text = "Money, Money , Money";
                lblwappen.Text = "We want Money";
                txtHelp.Text = "Gold ist die allgemeine währung der Kontinente, das Gold dient dazu, dem Spieler denn Kauf von Rüstung, Schleifsteine und anderes ermöglichen,Gold wir auch dazu verwendet, an gewissen Schranken durch zu kommen so wird in der Stadt beim durchgang durch das Tor ein Tribut verlangt(meist 100 Gold per durchreise.)";

            }
            else if (lstHelpLore.Text == "Max Leben")
            {
                picnpc.BackgroundImage = Heart;
                picwappen.BackgroundImage = Heart;
                lblName.Text = "Leben ist";
                lblwappen.Text = "Leben";
                txtHelp.Text = "Einer der Wichtigsten Stats des Spiel, denn sobald das leben eines Spieler auf 0 ist, dann ist er Tod. Game Over!! In manchen Maps gibt es Felder die es Spieler ermöglichen, ein Höheres maximale Leben zu besitzen. Max Leben definiert was dein Lebensmaximum ist.";

            }
            else if (lstHelpLore.Text == "Dialoge")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = Buerger;
                lblName.Text = "Du";
                lblwappen.Text = "Der Andere";
                txtHelp.Text = "Leider nicht Dialoge im wahrlichen sinn, so sind hier Dialoge einfach Texte die ein Npc zu dir sagt, Zuhören lohnt sich, du kennst die Umgebung nicht sie schon.";

            }
            else if (lstHelpLore.Text == "Kommentare")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = player;
                lblName.Text = "Du";
                lblwappen.Text = "Auch du";
                txtHelp.Text = "Kommentare sind Texte die du als Charakter selber sagts. Sonst sind sie genau das Gleiche wie Dialoge";
            }
            else if (lstHelpLore.Text == "Schleifsteine")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = PlayerA1c;
                lblName.Text = "Du ohne Schleifsteine";
                lblwappen.Text = "Du mit drei oder mehr";
                txtHelp.Text = "Wie Rüstung ist auch deine Waffenschärfe wichtig, Schleifsteine werden für Hindernisse und Encounter gebraucht.";
            }
            else if (lstHelpLore.Text == "Leben")
            {
                picnpc.BackgroundImage = Heart;
                picwappen.BackgroundImage = Heart;
                lblName.Text = "Lebe dein Leben";
                lblwappen.Text = "Das Leben ist ach so kurz";
                txtHelp.Text = "Du startest meist mit 3 Leben, geht es auf null dann bist du Tod";
            }
            else if (lstHelpLore.Text == "Dornenbüsche")
            {
                picnpc.BackgroundImage = DornenBush;
                picwappen.BackgroundImage = one;
                lblName.Text = "Der Dornenbush, vorsicht er sticht";
                lblwappen.Text = "Oh nein, du blutest";
                txtHelp.Text = "Gegen Dornen kannst du leider im moment nicht viel machen. Dornenbüsche machen direkten Schaden, heist keine Rüstung schützt dich; Ja auch die Plattenrüstung!!. Dornenbüsche veruhrsachen 1 Punkt Schaden zum Lebensbalken. Im gegensatz zu Gift, kann der Spieler sie schon sehen wenn der daneben steht.";
            }
            else if (lstHelpLore.Text == "Dornenwand")
            {
                picnpc.BackgroundImage = Dornenwall;
                picwappen.BackgroundImage = PlayerA1c;
                lblName.Text = "Die Dornenwand ist ein Hinderniss";
                lblwappen.Text = "Solange du keinen Schleifstein hast";
                txtHelp.Text = "Dornenwände sind wie Felsen und Türen, durchgehen geht nur mit einem Item, in diesem Fall der Sagenumwobene Schleifstein, ne du kannst auch einen normal Schleifstein brauchen.";
            }
            else if (lstHelpLore.Text == "Lava")
            {
                picnpc.BackgroundImage = LavaFinal;
                picwappen.BackgroundImage = zwei;
                lblName.Text = "Autsch ist das Heiss.";
                lblwappen.Text = "Du bist in einem Vulkan du Idiot";
                txtHelp.Text = "Lava, ähnlich wie Dornenbüsche, veruhrsachen direkten Schaden; im Fall von Lava sind das zwei Punkte auf Leben. Und nein du gehts nicht in Lava swimmen(hmm gegrillter Spieler)ehm ich meine du würde direkt sterben. Du läufst im Prinzip auf bruch stück die nicht Lava sind. Der Schaden sind die Giftigen dämpfe der Lave(Schwefel usw.).";
            }
            else if (lstHelpLore.Text == "Handel")
            {
                picnpc.BackgroundImage = Schmied;
                picwappen.BackgroundImage = Armorkaeufer;
                lblName.Text = "Ich will dein Geld";
                lblwappen.Text = "Oder deine Austrüstung";
                txtHelp.Text = "Händler, Schmied, Diebe Usw. Viele Personen bieten dir für Geld Materialien an, die dananch an anderen Orten verwenden kannst. Auch das Gegenteilige ist vorhanden, Händler die dir Ausrüstung anbieten für Geld, bedenke einfach Geld ist nicht unendlich, auch wenn ich dir Viel gebe.";
            }
            else if (lstHelpLore.Text == "Tribut")
            {
                picnpc.BackgroundImage = Zollpirat;
                picwappen.BackgroundImage = Money;
                lblName.Text = "Für Geld lasse ich dich durch";
                lblwappen.Text = "Geht doch";
                txtHelp.Text = "An manchen Stellen wird man Geld verlangen, damit du durchgehen kannst und zwar jedes mal. Sei also sicher das du nicht nochmal durchgehen musst, manchmal ist nur eine Abkürzung. Ist es aber Pflicht durchzugehen, so gibt es auch andere Lösungen aus diesen Maps, diese könnten aber ein Wenig Kostspielig sein.";
            }
            else if (lstHelpLore.Text == "Encounters")
            {
                picnpc.BackgroundImage = player ;
                picwappen.BackgroundImage = Dieb;
                lblName.Text = "Erstes Kampf System";
                lblwappen.Text = "Fight!!!!!!";
                txtHelp.Text = "Bei Encounter handelt es sich um das erste Kampfsystem das ich entwickelt habe, genau genommn ist es kein Kampfsystem, es fragt den Spieler ob er sich wehren möchte, es gibt drei Wege wie diese Kämpfe ausgehen können. 1 Der Spieler Flieht, manchmal entkommt er ohnne Wunde oder er bekommt eine kleine Fleich Wunde(meist 1 Leben ausser bei Bossen),2 der Spieler Kämpft jedoch besitzt dieser nicht ausreichend Ausrüstung, folglich erleidet er höheren schaden, aber er bekommt den Loot, 3 Er hat genug Ausrüstung, dann wird die Ausrüstung geschwächt und er bekommt den Loot. ";
            }
            else if (lstHelpLore.Text == "Bosse")
            {
                picnpc.BackgroundImage = player;
                picwappen.BackgroundImage = BanditChef;
                lblName.Text = "Ah der Held";
                lblwappen.Text = "Ich erzähle dir jetzt meinen Bössen Plan";
                txtHelp.Text = " Bosse sind meist Stärker als andere Gegner, logisch oder dafür geben sie dir meist Grosse Belohnungen. Schau aber gut das du Stärke ausrüstung hast, sonst veruhrsachen sie sehr viel Schaden, Tipp die meisten Bosse sind Schwach gegen Bomben.";
            }
            else if (lstHelpLore.Text == "Tokens")
            {
                picnpc.BackgroundImage = Dieb;
                picwappen.BackgroundImage = Gua;
                lblName.Text = "Sie haben";
                lblwappen.Text = "Was sie wollen";
                txtHelp.Text = "Bei manchen Karten wird es dem Spieler möglich sein, beim töten von Banditen Tokens zu bekommen, diese können bei Wachhauptmänner verkauft werden, oder an gewissen Orten Benutzt werden um durchzugehen. Verkaufen geht meist nur auf Maps die überhaupt Banditen haben.";
            }
            else if (lstHelpLore.Text == "Priester Heilung")
            {
                picnpc.BackgroundImage = Pries;
                picwappen.BackgroundImage = Heart;
                lblName.Text = "Sie heilen dich";
                lblwappen.Text = "aber nicht Gratis";
                txtHelp.Text = "Das Priester Heilungsfeld besitzt die gleiche Wirkung wie das Normale Heilungsfeld, kostet jedoch bei der Benutzung 100 Gold.";
            }
            else if (lstHelpLore.Text == "Cheats")
            {
                picnpc.BackgroundImage = Money;
                picwappen.BackgroundImage = Heart;
                lblName.Text = "Sei nicht gierig";
                lblwappen.Text = "es kostet was";
                txtHelp.Text = "Auf gewissen Maps gibt es Cheat Felder, diese dienen dazu falls man nicht weiterkommen kann, weil man aus irgendwelchen Grund kein Gold hat. Warnung bei benutzen dieser Felder verlierst du Max Leben und deine Rüstung und Schleifsteine";
            }
            else if (lstHelpLore.Text == "Elektro Falle")
            {
                picnpc.BackgroundImage = Schield;
                picwappen.BackgroundImage = Electro;
                lblName.Text = "Hast du Rüstung";
                lblwappen.Text = "Autsch";
                txtHelp.Text = "Erstmal bla bla Logik, in diesem Spiel bekommst du nur schaden durch Electro Fallen wenn du Rüstung besitzt, hast du keine Rüstung dann bekommst du keinen Schaden. Sie nehmen dir jedes mal 2 Lebenspunkte, dafür kannst du sie sehen.";
            }
            else if (lstHelpLore.Text == "Feuer")
            {
                picnpc.BackgroundImage = Heart;
                picwappen.BackgroundImage = Fire;
                lblName.Text = "Heisss heiss heiss";
                lblwappen.Text = "das ist Heisss";
                txtHelp.Text = "Feuer dient mehrheitlich nur zur dekoration, jedoch solltest du reinlaufen, ja dann bekommst du Schaden. Entweder Rüstung oder Leben jeweils 1 Punkt";
            }
            else if (lstHelpLore.Text == "Eventbereiche")
            {
                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Eventuell später mehr";
                lblwappen.Text = "wer weis";
                txtHelp.Text = "Events ist ein feature das noch nicht viel vertreten ist, wahrscheinlich wird es in zukunft mehr geben. Es gibt jedoch ein auf Level 4, dieses bewegt die Wachen.";
            }
            else if (lstHelpLore.Text == "Kanalisations Wasser")
            {
                picnpc.BackgroundImage = Heart;
                picwappen.BackgroundImage = Sewer;
                lblName.Text = "Was!!!";
                lblwappen.Text = "Du willst darin schwimmen";
                txtHelp.Text = "Kurz und klar du nimmst schaden wenn du drin schwimmst. Also schwimm nicht drin.";
            }
            else if (lstHelpLore.Text == "Magie")
            {
                picnpc.BackgroundImage = null;
                picwappen.BackgroundImage = null;
                lblName.Text = "Simsalabim";
                lblwappen.Text = "Hokuspokus";
                txtHelp.Text = "Mana ladet sich nur bei beendigung der Map auf. Normalerweise:)";
            }
            else if (lstHelpLore.Text == "Hebel")
            {
                picnpc.BackgroundImage = Hebel1;
                picwappen.BackgroundImage = Hebel2;
                lblName.Text = "Auf";
                lblwappen.Text = "Zu";
                txtHelp.Text = "Hebel dienen zur öffnung bestimmter Türen.";
            }
            else if (lstHelpLore.Text == "Respawn")
            {
                picnpc.BackgroundImage = Heart;
                picwappen.BackgroundImage = player;
                lblName.Text = "Weil ich Nett bin";
                lblwappen.Text = "Lebst du wieder";
                txtHelp.Text = "Gleich wie Mana regeneriert sich Respawn bei Level abschluss. Du kannst immer nur 3 Mal Respawnen.";
            }
            #endregion
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            #region Tipps

         
            lstHelpLore.Items.Clear();
            lstHelpLore.Items.Add("Bewegen");//
            lstHelpLore.Items.Add("Leben");//
            lstHelpLore.Items.Add("Heiltränke");//
            lstHelpLore.Items.Add("Rüstungmaterial und Rüstung");//
            lstHelpLore.Items.Add("Gift");//
            lstHelpLore.Items.Add("Hinweise");//
            lstHelpLore.Items.Add("Türen und Schlüssel");//
            lstHelpLore.Items.Add("Bomben und Felsen");//
            lstHelpLore.Items.Add("Gold");//
            lstHelpLore.Items.Add("Max Leben");//
            lstHelpLore.Items.Add("Dialoge");//
            lstHelpLore.Items.Add("Kommentare");//
            lstHelpLore.Items.Add("Schleifsteine");//
            lstHelpLore.Items.Add("Dornenbüsche");//
            lstHelpLore.Items.Add("Dornenwand");//
            lstHelpLore.Items.Add("Lava");//
            lstHelpLore.Items.Add("Handel");//
            lstHelpLore.Items.Add("Tribut");//
            lstHelpLore.Items.Add("Encounters");//
            lstHelpLore.Items.Add("Bosse");//
            lstHelpLore.Items.Add("Tokens");//
            lstHelpLore.Items.Add("Priester Heilung");//
            lstHelpLore.Items.Add("Cheats");//
            lstHelpLore.Items.Add("Elektro Falle");//
            lstHelpLore.Items.Add("Feuer");//
            lstHelpLore.Items.Add("Eventbereiche");//
            lstHelpLore.Items.Add("Kanalisations Wasser");//
            lstHelpLore.Items.Add("Magie");//
            lstHelpLore.Items.Add("Hebel");//
            lstHelpLore.Items.Add("Respawn");//
            #endregion
        }

        private void btnLore_Click(object sender, EventArgs e)
        {
            #region Lore

         
            lstHelpLore.Items.Clear();
            lstHelpLore.Items.Add("Ressos");//
            lstHelpLore.Items.Add("Estor");//
            lstHelpLore.Items.Add("Castrosa");       //       
            lstHelpLore.Items.Add("Baron Denoixis");//
            lstHelpLore.Items.Add("Longchester");//
            lstHelpLore.Items.Add("Nangasto");  // Festung im Süden Langchester Fertig
            lstHelpLore.Items.Add("Gostasso");//Hauptstadt von Estor Fertig
            lstHelpLore.Items.Add("Ulsster"); //König von Estor Fertig         
            lstHelpLore.Items.Add("Vorlondin");
            lstHelpLore.Items.Add("Wezan");
            lstHelpLore.Items.Add("Vosgon");
            lstHelpLore.Items.Add("Ories");
            lstHelpLore.Items.Add("Wencyra");
            lstHelpLore.Items.Add("Dravon");
            lstHelpLore.Items.Add("Feuergorn");// Name der Insel von Dravon
            lstHelpLore.Items.Add("Stadt der Zauberer");
            lstHelpLore.Items.Add("Magierränge");
            lstHelpLore.Items.Add("The Zeal Order");
            lstHelpLore.Items.Add("Festor");
            lstHelpLore.Items.Add("Holy King");
            lstHelpLore.Items.Add("Orklas vs Zeal Order");
            lstHelpLore.Items.Add("Magieputsch");
            lstHelpLore.Items.Add("Orklas");
            lstHelpLore.Items.Add("Peskar");
            lstHelpLore.Items.Add("Die Elfen Reiche");
            lstHelpLore.Items.Add("Zusammenleben");
            lstHelpLore.Items.Add("Sahawreed");
            lstHelpLore.Items.Add("Saveyn");//
            lstHelpLore.Items.Add("Trestan");
            lstHelpLore.Items.Add("Ewige Passage");           
            lstHelpLore.Items.Add("Grimos");//
            lstHelpLore.Items.Add("Fealen Empire");
            lstHelpLore.Items.Add("Zrosgen"); 
            lstHelpLore.Items.Add("Cresgen");
            lstHelpLore.Items.Add("Vekran");
            lstHelpLore.Items.Add("Kruzo Archipel");
            #endregion
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (lstHelpLore.Text == "Castrosa")
            {
                if (picwappen.BackgroundImage == CastH)
                {
                    picwappen.BackgroundImage = Castrosadorf;
                    lblwappen.Text = "Östliches Dorf von Estor";
                }
                else if (picwappen.BackgroundImage == Castrosadorf)
                {
                    picwappen.BackgroundImage = Altar;
                    lblwappen.Text = "Heiliggeschrieben nach dem Sieg über das Empire";
                }
                else if (picwappen.BackgroundImage == Altar)
                {
                    picwappen.BackgroundImage = CastH;
                    lblwappen.Text = "Teil einer Bauersfamilie";
                }
            }
        }
    }
}
