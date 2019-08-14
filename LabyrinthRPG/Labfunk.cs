using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class Labfunk
    {
       
        private const int CellSize = 22;
        private const int MaxRows = 40;
        private const int MaxColumns = 40;
        public const int size = 8;
        private static int depth = 5;
        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        #region Pictures
        Bitmap Secret = Properties.Resources.PlayerFig;
        Bitmap Tree = Properties.Resources.Baum1;
        Bitmap grassy = Properties.Resources.Rasen2;
        Bitmap Watery = Properties.Resources.WaterFinal;
        Bitmap Dornen = Properties.Resources.DornenBush;
        Bitmap Dwalls = Properties.Resources.Dornenwall;
        Bitmap Fischer = Properties.Resources.Fischer;
        Bitmap Soldat = Properties.Resources.Soldat;
        Bitmap Schmied = Properties.Resources.Schmied;
        Bitmap Holzer = Properties.Resources.Holzer;
        Bitmap Farmer = Properties.Resources.Farmer;
        Bitmap Priester = Properties.Resources.Priester;
        Bitmap Captain = Properties.Resources.Captain;
        Bitmap Zpirat = Properties.Resources.Zollpirat;
        Bitmap Lavas= Properties.Resources.LavaFinal;
        Bitmap Giftig = Properties.Resources.Gift_neu;
        Bitmap Boden = Properties.Resources.Cavebode;
        Bitmap Cavewall = Properties.Resources.Cave;
        Bitmap Stegs = Properties.Resources.Step;
        Bitmap Schiffs = Properties.Resources.Schiff;
        Bitmap Dachs = Properties.Resources.Dach;
        Bitmap Street = Properties.Resources.Strasse;
        Bitmap Port = Properties.Resources.Hafen;
        Bitmap Gasses = Properties.Resources.Gasse;
        Bitmap Burg = Properties.Resources.Burgmauer;
        Bitmap Krich = Properties.Resources.Kirchenmauer;
        Bitmap Oven = Properties.Resources.Oven;
        Bitmap Hauswa = Properties.Resources.Hauswand;
        Bitmap Plaza = Properties.Resources.Plaza;
        Bitmap Iture = Properties.Resources.ITur;
        Bitmap Bench = Properties.Resources.Bank;
        Bitmap Altar = Properties.Resources.Altar;
        Bitmap Bushs = Properties.Resources.Bush;
        Bitmap Matros = Properties.Resources.Matrose;
        Bitmap Schmied2 = Properties.Resources.Schmied2;
        Bitmap SchKa = Properties.Resources.Schleifkaeufer;
        Bitmap ArmKa = Properties.Resources.Armorkaeufer;
        Bitmap Bomka = Properties.Resources.Bombenkaeufer;
        Bitmap Guardk = Properties.Resources.Guard_Captain;
        Bitmap Hmoney = Properties.Resources.Handelmoney;
        Bitmap BanCa = Properties.Resources.BanditChef;
        Bitmap DiebH = Properties.Resources.Diebheandler;
        Bitmap Mann = Properties.Resources.Buerger;
        Bitmap Frau = Properties.Resources.Buegerin;
        Bitmap Teppic = Properties.Resources.Teppich;
        Bitmap Wand2 = Properties.Resources.Hauswand2;
        Bitmap Stairs = Properties.Resources.Treppe;
        Bitmap Gov = Properties.Resources.Governor;
        Bitmap Stuhl = Properties.Resources.Stuhl;
        Bitmap Sewer = Properties.Resources.Sewer;
        Bitmap Boulder = Properties.Resources.Boulder;
        Bitmap Gitter = Properties.Resources.Gitter;
        Bitmap Bedbody = Properties.Resources.Bedbody;
        Bitmap Bedhead = Properties.Resources.Bedhead;
        Bitmap Hebel1 = Properties.Resources.Hebel1;
        Bitmap Hebel2 = Properties.Resources.Hebel2;
        Bitmap Burn = Properties.Resources.Fire;
        Bitmap Electros = Properties.Resources.Electro;
        Bitmap Bettler1 = Properties.Resources.Bettler1;
        Bitmap Bettler2 = Properties.Resources.Bettler2;
        Bitmap Bettlerin = Properties.Resources.Bettlerin;
        Bitmap Bandit = Properties.Resources.Dieb;
        Bitmap Bombe = Properties.Resources.Bomb;
        Bitmap Healspot = Properties.Resources.Healspot;
        Bitmap Felds = Properties.Resources.Feld;
        Bitmap Fwegs = Properties.Resources.Fweg;
        Bitmap Palisade = Properties.Resources.Palisade;
        Bitmap Pali3 = Properties.Resources.Pali3;
        Bitmap Pli2 = Properties.Resources.Pli2;
        Bitmap Magic_Schield = Properties.Resources.Magic_Schield;
        Bitmap Haus2 = Properties.Resources.Haus2;
        Bitmap Wind1 = Properties.Resources.Wind1;
        Bitmap Wind2 = Properties.Resources.Wind2;
        Bitmap Wind3 = Properties.Resources.Wind3;
        Bitmap Wind4 = Properties.Resources.Wind4;
        Bitmap Müller = Properties.Resources.Müller;
        Bitmap Farmer2 = Properties.Resources.Farmer2;
        Bitmap Söldner2 = Properties.Resources.Söldner2;
        Bitmap Wanderer = Properties.Resources.Wanderer;
        Bitmap sahawreed = Properties.Resources.sahawreed;
        Bitmap Wirt = Properties.Resources.Wirt;
        Bitmap Bri1 = Properties.Resources.Bri1;
        Bitmap Bri2 = Properties.Resources.Bri2;
        Bitmap Brid4 = Properties.Resources.Brid4;
        Bitmap Berge = Properties.Resources.Berge;
        Bitmap Tower = Properties.Resources.WatchTower;
        Bitmap MTurm = Properties.Resources.MagieTurm;
        Bitmap Farmerin = Properties.Resources.Farmerin;
        Bitmap Druide = Properties.Resources.Druide;
        Bitmap Ross = Properties.Resources.Ross;
        Bitmap Söldner = Properties.Resources.Söldner;
        Bitmap Mage = Properties.Resources.Mage;
        Bitmap Treedoor = Properties.Resources.Treedoor;
        Bitmap Truhe = Properties.Resources.Truhe;
        Bitmap SackmitSchleifstein = Properties.Resources.SackmitSchleifstein;
        Bitmap Palitor3 = Properties.Resources.Palitor3;
        Bitmap Palitor4 = Properties.Resources.Palitor4;
        Bitmap Palitor5 = Properties.Resources.Palitor5;
        Bitmap Palitor6 = Properties.Resources.Palitor6;
        Bitmap Question = Properties.Resources.Question;
        Bitmap really = Properties.Resources.really;
        Bitmap Brunnen = Properties.Resources.Brunnen;
        Bitmap Wache = Properties.Resources.Wache;
        Bitmap VEliteGuard = Properties.Resources.VEliteGuard;
        Bitmap Vorlondin_Priest = Properties.Resources.Vorlondin_Priest;
        Bitmap Vorlondin_Captain = Properties.Resources.Vorlondin_Captain;
        Bitmap Lehrling = Properties.Resources.Lehrling;
        Bitmap Zwerg = Properties.Resources.Zwerg;
        Bitmap Elf = Properties.Resources.Elf;
        Bitmap Elfwar = Properties.Resources.Elfwar;
        Bitmap Bogenschütze = Properties.Resources.Bogenschütze;
        Bitmap Isekai = Properties.Resources.Isekai;
        Bitmap Sahawreedmagier = Properties.Resources.Sahawreedmagier;
        Bitmap Adel = Properties.Resources.Adel;
        Bitmap Elfin = Properties.Resources.Elfin;
        Bitmap Bogen2 = Properties.Resources.Bogen2;
        Bitmap Zaun = Properties.Resources.Zaun;
        Bitmap Zaun2 = Properties.Resources.Zaun2;
        Bitmap Palitor1 = Properties.Resources.Palitor1;
        Bitmap Palitor2 = Properties.Resources.Palitor2;
        Bitmap Caveclosedoor = Properties.Resources.Caveclosedoor;
        Bitmap Caveopendoor = Properties.Resources.Caveopendoor;
        Bitmap Lagertür = Properties.Resources.Lagertür;
        Bitmap Elfwache = Properties.Resources.Elfwache;
        Bitmap ZwergW2 = Properties.Resources.ZwergW2;
        Bitmap Direwolf = Properties.Resources.Direwolf;
        Bitmap Miner = Properties.Resources.Miner;
        Bitmap Orklaswache = Properties.Resources.Orklaswache;
        Bitmap ElfElite = Properties.Resources.ElfElite;
        Bitmap Elfhealer = Properties.Resources.Elfhealer;
        Bitmap RunenPriester = Properties.Resources.RunenPriester;
        Bitmap Dravoswache = Properties.Resources.Dravoswache;
        #endregion          
        // Grid 0
        #region Grid 0        
        private const string Gras = "Gras";
        private const string Wald = "Wald";
        private const string Wall = "Wand";
        private const string Gift = "Gift";
        private const string OTur = "OTur";
        private const string VTur = "VTur";
        private const string Wass = "Wass";
        private const string Keys = "Keys";
        private const string Heal = "Heal";
        private const string Schi = "Schi";
        private const string Haus = "Haus";
        private const string Bomb = "Bomb";
        private const string Rock = "Rock";
        private const string Hinw = "Hinw";
        private const string Star = "Star";
        private const string Ende = "Ende";    
        private const string Pers = "Pers";
        private const string Swor = "Swor";
        private const string Kome = "Kome";
        private const string Dorn = "Dorn";
        private const string Dwal = "Dwal";
        private const string Ship = "Ship";
        private const string Cave = "Cave";
        private const string Lmax = "Lmax";
        private const string Bode = "Bode";
        private const string Lava = "Lava";
        private const string Steg = "Steg";
        private const string Bush = "Bush";
        private const string Stra = "Stra";
        private const string Stha = "Stha";
        private const string Tga1 = "Tga1";
        private const string Tga2 = "Tga2";      
        private const string Ofen = "Ofen";
        private const string Gass = "Gass";
        private const string ITur = "ITur";
        private const string TrAK = "TrAK";
        private const string TrSK = "TrSK";
        private const string TrKK = "TrKK";
        private const string TrSS = "TrSS";
        private const string TrSA = "TrSA";
        private const string TrSB = "TrSB";
        private const string Coin = "Coin";
        private const string Cwal = "Cwal";
        private const string Bto1 = "Bto1";
        private const string Vill = "Vill";
        private const string Bto2 = "Bto2";
        private const string Bank = "Bank";
        private const string Plas = "Plas";
        private const string Blck = "Blck";
        private const string Alta = "Alta";
        private const string PHea = "PHea";
        private const string Chea = "Chea";
        private const string GuaK = "GuaK";
        private const string Dach = "Dach";
        private const string Stmk = "Stmk";
        private const string Mobl = "Mobl";
        private const string Bedh = "Bedh";
        private const string Bedb = "Bedb";
        private const string Fire = "Fire";
        private const string Tepp = "Tepp";
        private const string ETur = "ETur";
        private const string Mayo = "Mayo";
        private const string Etra = "Etra";
        private const string Trep = "Trep";
        private const string Leve = "Leve";
        private const string Gitt = "Gitt";
        private const string Sewe = "Sewe";
        private const string Mboo = "Mboo";
        private const string LTur = "LTur";
        private const string Feld = "Feld";
        private const string Muhl = "Muhl";
        private const string Moun = "Moun";
        private const string Masd = "Masd";
        private const string Pali = "Pali";
        private const string Fweg = "Fweg";
        private const string TgaL = "TgaL";
        private const string Towe = "Towe";
        private const string Brid = "Brid";
        private const string Fenc = "Fenc";
        private const string WHea = "WHea";
        private const string TrBK = "TrBK";
        private const string Tga3 = "Tga3";
        private const string QHau = "QHau";
        private const string QuTu = "QuTu";
        private const string QueT = "QueT";
        private const string QueA = "QueA";
        private const string QueW = "QueW";
        private const string QueB = "QueB";
        private const string Brun = "Brun";
        private const string Fahn = "Fahn";
        private const string TrPK = "TrPK";
        private const string Farr = "Farr";
        private const string Gold = "Gold";
        private const string MaHe = "MaHe";
        private const string Fake = "Fake";
        private const string Che2 = "Che2";
        // private const string Farr = "Farr";
        #endregion
        // Grid 1
        private const string Player = "Player";
        // Grid 2 = Loot

        // Grid 3
        private const string Money = "Money";
        private const string BigMoney = "BigMoney";
        private const string LargeMoney = "LargeMoney";
        private const string Potion = "Potion";
        private const string Arrow = "Arrow";
        // Grid 4
        #region Grid Enemy   
        private const string Band = "Band";
        private const string BanC = "BanC";// in 0 und Vier
        private const string Guar = "Guar";
        private const string GuaE = "GuaE";
        private const string Gobl = "Gobl";
        private const string Gobk = "Gobk";
        private const string Dark = "Dark";
        private const string Wolf = "Wolf";
        private const string Bear = "Bear";
        private const string Assa = "Assa";
        private const string BandL = "BandL";
        private const string Behe = "Behe";
        private const string DWolf = "DWolf";
        private const string Bos1 = "Bos1";
        private const string Bos2 = "Bos2";
        private const string Bos3 = "Bos3";
        private const string Bos4 = "Bos4";
        private const string Bos5 = "Bos5";
        #endregion
        public PictureBox GenerateGrid(int _row, int _column)
        {
            #region Create World          
            Panel panMain = new Panel();
            panMain.Size = new Size(CellSize * 40, CellSize * 40);
            PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan"+ _row + _column,
                Height = CellSize,
                Width = CellSize,

                BorderStyle = BorderStyle.FixedSingle

            };          
            panel.BackColor = Color.LightGreen;
            _grid[_column, _row, 0] = Gras;
            panel.BackgroundImageLayout = ImageLayout.Zoom;
            panel.SizeMode = PictureBoxSizeMode.Zoom;
            panel.Location = new Point(_row * CellSize, _column * CellSize);
            return panel;
            #endregion
        }
        int Loot=1;
        int p = 0;
        int c = 0;        
        public PictureBox CreateWorld(PictureBox panel,int _rows, int _columns, int Level)
        {
            #region Level one
                    
            if (Level==1)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps();
                   _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
               _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;
                if (_rows == 9 && _columns == 31 || _rows == 12 && _columns == 29 || _rows == 24 && _columns == 21 || _rows == 16 && _columns == 20 || _rows == 28 && _columns == 12 || _rows == 35 && _columns == 5 || _rows ==14 && _columns == 7 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
             else   if (_rows == 26 && _columns == 19 || _rows == 12 && _columns == 31 || _rows == 16 && _columns == 11 || _rows == 19 && _columns == 3)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Potion;
                }
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                else if (_grid[_columns, _rows, 0] == Heal)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Red;
                }
                else if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkGoldenrod;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                else if (_grid[_columns, _rows, 0] == Schi)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Orange;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                else if (_grid[_columns, _rows, 0] == Wald)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkGreen;
                }
                else if (_grid[_columns, _rows, 0] == Wass)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Turquoise;
                }
                else if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Star)
                {
                    panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                else if (_grid[_columns, _rows, 0] == Ende)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.DeepPink;
                }
                else if (_grid[_columns, _rows, 0] == Gift)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Purple;
                }
                else if (_grid[_columns, _rows, 0] == Rock)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkSlateGray;
                }
                else if (_grid[_columns, _rows, 0] == Haus)
                {
                    panel.BackColor = Color.LightGreen;
                    //   panel.BackColor = Color.SaddleBrown;
                }
                else if (_grid[_columns, _rows, 0] == Bomb)
                {
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.OrangeRed;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                else if (_grid[_columns, _rows, 0] == OTur)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightSkyBlue;
                }
                else if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.LightGreen;
                    //   panel.BackColor = Color.DarkBlue;
                }
                else if (_grid[_columns, _rows, 0] == Lmax)
                {
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.PaleVioletRed;
                }
                else if (_grid[_columns, _rows, 0] == Dwal)
                {
                    panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.DarkOliveGreen;
                }
                else if (_grid[_columns, _rows, 0] == Swor)
                {
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Orchid;
                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                   // panel.BackColor = Color.Peru;
                      panel.BackColor = Color.LightGreen;

                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level two
     
            if (Level == 2)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps2();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
  
                if (_rows == 16 && _columns == 30 || _rows == 27 && _columns == 27 || _rows == 37 && _columns == 15 || _rows == 28 && _columns == 4 || _rows == 14 && _columns == 8 || _rows == 1 && _columns == 13)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                else if (_rows == 37 && _columns == 38 || _rows == 36 && _columns == 38)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
                else if (_rows == 31 && _columns == 37 || _rows == 1 && _columns == 10 || _rows == 20 && _columns == 2)  {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Potion;
                }
                panel.BackgroundImage = null;
                panel.Image = null;
                panel.BackColor = Color.LightGreen;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                 if (_grid[_columns, _rows, 0] == Heal && _rows != 14 && _columns != 25)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.Red;
                }
                 if (_grid[_columns, _rows, 0] == Heal && _rows == 14 && _columns == 25)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                 if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.DarkGoldenrod;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                 if (_grid[_columns, _rows, 0] == Schi && _rows != 13 && _columns != 25)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.Orange;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                 if (_grid[_columns, _rows, 0] == Schi && _rows == 13 && _columns == 25)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                 if (_grid[_columns, _rows, 0] == Wald && _rows < 16 && _columns < 12)
                {
                   // panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.DarkGreen;
                }
                 if (_grid[_columns, _rows, 0] == Wald && _rows >= 16 && _columns >= 12)

                {
                    panel.BackColor = Color.LightGreen;
                }
                 if (_grid[_columns, _rows, 0] == Wass && _rows < 17 )
                {
                   // panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.SteelBlue;
                }
                 if (_grid[_columns, _rows, 0] == Wass && _rows >= 17 )

                {
                    panel.BackColor = Color.LightGreen;
                }
                 if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.LightGray;
                }
                 if (_grid[_columns, _rows, 0] == Star)
                {
                   // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                 if (_grid[_columns, _rows, 0] == Ende)
                {
                   // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                }
                 if (_grid[_columns, _rows, 0] == Gift)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.Purple;
                }
                 if (_grid[_columns, _rows, 0] == Rock)
                {
                     panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkSlateGray;
                    //panel.BackColor = Color.LightSlateGray;
                }
                 if (_grid[_columns, _rows, 0] == Haus && _rows<16 && _columns < 12)
                {
                  //  panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.SaddleBrown;
                }
                 if (_grid[_columns, _rows, 0] == Haus && _rows >= 16 && _columns >= 12)               
                {
                    panel.BackColor = Color.LightGreen;
                }
                 if (_grid[_columns, _rows, 0] == Bomb)
                {
                   panel.BackColor = Color.LightGreen;
                  //    panel.BackColor = Color.OrangeRed;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                 if (_grid[_columns, _rows, 0] == OTur)
                {
                   // panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.LightSkyBlue;
                }
                 if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.DarkBlue;
                }
                 if (_grid[_columns, _rows, 0] == Pers && _rows < 16 && _columns < 12)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;
                }
                 if (_grid[_columns, _rows, 0] == Pers && _rows == 14 && _columns == 22)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.SandyBrown;
                }

                 if (_grid[_columns, _rows, 0] == Pers && _rows >= 16 && _columns >= 12)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                }
                 if (_grid[_columns, _rows, 0] == Swor)
                {
                     panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Orchid;
                }
                 if (_grid[_columns, _rows, 0] == Kome)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.LightGray;
                }
                 if (_grid[_columns, _rows, 0] == Dorn)
                {
                    panel.BackColor = Color.LightGreen;
                 //   panel.BackColor = Color.ForestGreen;
                }
                 if (_grid[_columns, _rows, 0] == Dwal)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.DarkOliveGreen;
                }              
                if (_grid[_columns, _rows, 0] == Ship)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Brown;
                }
                 if (_grid[_columns, _rows, 0] == Cave)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkSlateGray;
                }
                 if (_grid[_columns, _rows, 0] == Lava)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.IndianRed;
                }
                 if (_grid[_columns, _rows, 0] == Lmax)
                {
                     panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //  panel.BackColor = Color.PaleVioletRed;
                }
                 if (_grid[_columns, _rows, 0] == Bode)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.DarkGray;
                }
                 if (_grid[_columns, _rows, 0] == Gras)
                {
                     panel.BackColor = Color.LightGreen;
                }
                 if (_grid[_columns, _rows, 0] == Steg)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                     panel.BackColor = Color.Peru;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Cwal)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level three       
            if (Level == 3)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps3();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;

                if (_rows == 36 && _columns == 38 || _rows == 13 && _columns == 36 || _rows == 35 && _columns == 3 || _rows == 9 && _columns == 8 || _rows == 7 && _columns == 17 || _rows == 15 && _columns == 22 || _rows == 19 && _columns == 16 || _rows == 29 && _columns == 23)
                  {
                      _grid[_columns, _rows, 2] = Loot.ToString();
                      _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 2 && _columns == 21 || _rows == 29 && _columns == 34 || _rows == 15 && _columns == 20 || _rows == 32 && _columns == 16 || _rows == 11 && _columns == 16 || _rows == 37 && _columns == 8 || _rows == 21 && _columns == 3)  {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Band;
                }
                if (_rows == 2 && _columns == 23)     {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = BanC;
                }            

                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal && _rows == 29 && _columns == 5)
                {
                    panel.BackColor = Color.SandyBrown;
                }
                 if (_grid[_columns, _rows, 0] == Brun)
                {
                    panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Turquoise;
                }

                if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.SaddleBrown;              
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi )
                {
                    panel.BackColor = Color.SaddleBrown;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }             
                if (_grid[_columns, _rows, 0] == Bush )
                {
                    panel.BackColor = Color.DarkGreen;
                }              
                if (_grid[_columns, _rows, 0] == Wass)
                {
                    panel.BackColor = Color.SteelBlue;
                }               
                if (_grid[_columns, _rows, 0] == Hinw && _rows == 31&& _columns==4)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.SandyBrown;
                    //   panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGray;
                }
              
                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                }              
                if (_grid[_columns, _rows, 0] == Haus )
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SaddleBrown;
                }
               
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    panel.BackColor = Color.SaddleBrown;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightSkyBlue;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.DarkBlue;
                    //   panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Pers  && _rows == 6 && _columns == 24)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                     panel.BackColor = Color.SaddleBrown;                  
                    //  panel.BackColor = Color.LightGray;
                }
               else if (_grid[_columns, _rows, 0] == Pers && _rows == 29 && _columns == 2 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
              
                    panel.BackColor = Color.SandyBrown;
                    //  panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Pers && _rows == 2 && _columns == 33)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.DarkRed;
                    panel.BackgroundImage = Dachs;
                    //  panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Pers && _rows == 21 && _columns == 26)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.FloralWhite;
                    //  panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Pers && _rows == 33 && _columns == 4)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.SlateGray;
                    //  panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Pers && _rows != 29 && _columns != 3 && _rows != 2 && _columns != 33)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGray;
                }               
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    panel.BackColor = Color.SaddleBrown;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Orchid;
                }                       
                if (_grid[_columns, _rows, 0] == Ship)
                {             
                    panel.BackColor = Color.Brown;
                }              
                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    panel.BackColor = Color.SaddleBrown;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //  panel.BackColor = Color.PaleVioletRed;
                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    panel.BackColor = Color.SaddleBrown;
                    //panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Steg)
                {
                   // panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;

                }
                if (_grid[_columns, _rows, 0] == Stra)
                {
                 //   panel.BackgroundImage = Street;
                    panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    //panel.BackgroundImage = Gasses;
                    panel.BackColor = Color.DimGray;

                }
                if (_grid[_columns, _rows, 0] == Stha)
                {
                  //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;

                }
                if (_grid[_columns, _rows, 0] == Tga1)
                {
                    panel.BackColor = Color.DarkSlateBlue;

                }
                if (_grid[_columns, _rows, 0] == Tga2)
                {
                    panel.BackColor = Color.DarkSlateBlue;

                }
                if (_grid[_columns, _rows, 0] == Guar)
                {
                    panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == Ofen)
                {
                    panel.BackColor = Color.SlateGray;

                }
                if (_grid[_columns, _rows, 0] == ITur)
                {
                    panel.BackColor = Color.CadetBlue;

                }
                if (_grid[_columns, _rows, 0] == GuaK || _grid[_columns, _rows, 0] == Blck || _grid[_columns, _rows, 0] == TrAK ||_grid[_columns, _rows, 0] == TrSK|| _grid[_columns, _rows, 0] == TrSB||_grid[_columns, _rows, 0] == TrSS||_grid[_columns, _rows, 0] == TrSA)
                {
                    panel.BackColor = Color.LightGray;
                }
                if (_grid[_columns, _rows, 0] == TrKK)
                {
                    panel.BackColor = Color.SaddleBrown;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.LightGray;
                }
                if (_grid[_columns, _rows, 0] == Coin)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.SaddleBrown;
                  //  panel.BackColor = Color.Gold;

                }
                if (_grid[_columns, _rows, 0] == Cwal)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;

                }
                if (_grid[_columns, _rows, 0] == Vill)
                {
                    panel.BackColor = Color.DarkRed;

                }
                if (_grid[_columns, _rows, 0] == Bto1|| _grid[_columns, _rows, 0] == Bto2)
                {
                    panel.BackColor = Color.DarkBlue;

                }
                if (_grid[_columns, _rows, 0] == Bank)
                {
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;
                   // panel.BackColor = Color.SaddleBrown;
                }
                if (_grid[_columns, _rows, 0] == Stmk)
                {
                    panel.BackgroundImage = Krich;
                    panel.BackColor = Color.SlateGray;

                }
                if (_grid[_columns, _rows, 0] == Alta)
                {
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;
                   // panel.BackColor = Color.Silver;

                }
                if (_grid[_columns, _rows, 0] == PHea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;
                   // panel.BackColor = Color.Red;

                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                    panel.BackColor = Color.FloralWhite;

                }
                if (_grid[_columns, _rows, 0] == Chea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGray;
                    //panel.BackColor = Color.OliveDrab;

                }             
                if (_grid[_columns, _rows, 0] == Dach)
                {
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;

                }            
                if (_grid[_columns, _rows, 0] == GuaK)
                {
                    panel.BackColor = Color.LightGreen;

                }                               
                if (_grid[_columns, _rows, 0] == BanC)
                {
                    panel.BackColor = Color.SaddleBrown;

                }           
                p = 0;
                c = 0;
            }
            #endregion
            #region Level four           
            if (Level == 4)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps4();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;

                if (_rows == 19 && _columns == 24)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   
                }
                
                                if (_rows == 36 && _columns == 30 || _rows == 25 && _columns == 15 || _rows == 24 && _columns == 15 || _rows == 25 && _columns == 12 || _rows == 24 && _columns == 12 || _rows == 12 && _columns == 16 || _rows == 33 && _columns == 7 || _rows == 27 && _columns == 7 || _rows == 18 && _columns == 7 || _rows == 15 && _columns == 7 || _rows == 21 && _columns == 2)
                {
                                    _grid[_columns, _rows, 2] = Loot.ToString();
                                    _grid[_columns, _rows, 3] = Money;
                                }                           
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal )
                {
                    panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Red;
                }            
                if (_grid[_columns, _rows, 0] == Keys)
                {
                    panel.BackColor = Color.Beige;
                    //    panel.BackColor = Color.LightGreen;
                    //   panel.BackColor = Color.DarkGoldenrod;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.Orange;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Beige;
                    //  panel.BackColor = Color.DarkGreen;
                }
                if (_grid[_columns, _rows, 0] == Wass && _columns < 7)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.SteelBlue;

                }
                else if (_grid[_columns, _rows, 0] == Wass && _columns >= 7)

                {
                    panel.BackColor = Color.Beige;
                }
                                                          
                if (_grid[_columns, _rows, 0] == Hinw && _rows == 31 && _columns == 4)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Beige;
                  //  panel.BackColor = Color.SandyBrown;
                    //   panel.BackColor = Color.LightGray;
                }
             
                else if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Beige;
                   // panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Beige;
                 //   panel.BackColor = Color.LightGray;
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                    //    panel.BackColor = Color.OrangeRed;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Beige;
                 //   panel.BackColor = Color.LightSkyBlue;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                    panel.BackColor = Color.Beige;
                   // panel.BackColor = Color.DarkBlue;
                    //   panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Pers )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Beige;

                    //  panel.BackColor = Color.LightGray;
                }
           
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Orchid;
                }                         
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    panel.BackColor = Color.Beige;
                    //panel.BackColor = Color.DarkGray;
                }                                                          
                if (_grid[_columns, _rows, 0] == Stha)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;

                }                                                          
                if (_grid[_columns, _rows, 0] == Coin)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.SaddleBrown;
                    //  panel.BackColor = Color.Gold;

                }
                if (_grid[_columns, _rows, 0] == Cwal&& _columns < 7|| _grid[_columns, _rows, 0] == Cwal && _columns == 38 || _grid[_columns, _rows, 0] == Cwal && _rows == 1 || _grid[_columns, _rows, 0] == Cwal && _rows == 38)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;

                }
                else if (_grid[_columns, _rows, 0] == Cwal && _columns >= 7)

                {
                    panel.BackColor = Color.Beige;
                }                             
                if (_grid[_columns, _rows, 0] == Plas)
                {
                    //  panel.BackColor = Color.FloralWhite;
                    panel.BackColor = Color.Beige;
                }           
                if (_grid[_columns, _rows, 0] == GuaK)
                {
                  //  panel.BackColor = Color.LightGray;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Mobl)
                {
                   // panel.BackColor = Color.SaddleBrown;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedh)
                {
                  //  panel.BackColor = Color.WhiteSmoke;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedb)
                {
                    //panel.BackColor = Color.CornflowerBlue;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Fire)
                {
                 //   panel.BackColor = Color.DarkOrange;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                    //   panel.BackColor = Color.Khaki;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Trep)
                {
                   // panel.BackColor = Color.RosyBrown;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Tepp)
                {
                   // panel.BackColor = Color.MistyRose;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Mayo)
                {
                   // panel.BackColor = Color.SlateGray;
                    panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == ETur)
                {
                   // panel.BackColor = Color.SteelBlue;
                    panel.BackColor = Color.Beige;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level five

          
            if (Level == 5)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps5();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;
                if (_rows == 19 && _columns == 24)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_rows == 14 && _columns == 38 || _rows == 37 && _columns == 34 || _rows == 16 && _columns == 32 || _rows == 21 && _columns == 26 || _rows == 4 && _columns == 28 || _rows == 2 && _columns == 28 || _rows == 37 && _columns == 16 || _rows == 33 && _columns == 12 || _rows == 15 && _columns == 14 || _rows == 13 && _columns == 14 || _rows == 8 && _columns == 12 || _rows == 24 && _columns == 12 || _rows == 24 && _columns == 5 || _rows == 1 && _columns == 2)  {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 14 && _columns == 28 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
                if (_rows == 37 && _columns == 5 || _rows == 34 && _columns == 10 || _rows == 34 && _columns == 7 || _rows == 32 && _columns == 9 || _rows == 32 && _columns == 6 || _rows == 30 && _columns == 10 || _rows == 30 && _columns == 5)   {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Gobl;
                }
                if (_rows == 37 && _columns == 8)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Gobk;
                }
                if (_rows == 8 && _columns == 33 || _rows == 5 && _columns == 33)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = GuaE;
                }

                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal)
                {
                  //  panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Red;
                    panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Keys)
                {
                 //   panel.BackColor = Color.Beige;
                    //    panel.BackColor = Color.LightGreen;
                      // panel.BackColor = Color.DarkGoldenrod;
                    panel.BackColor = Color.DimGray;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    //  panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.Beige;
                    //  panel.BackColor = Color.Orange;
                      panel.BackColor = Color.DimGray;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }           
                if (_grid[_columns, _rows, 0] == Wass && _columns < 7)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.SteelBlue;

                }
                else if (_grid[_columns, _rows, 0] == Wass && _columns >= 7)

                {
                    panel.BackColor = Color.Beige;
                }

                // panel.BackColor = Color.LightGreen;



                if (_grid[_columns, _rows, 0] == Hinw && _rows == 31 && _columns == 4)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Beige;
                    //  panel.BackColor = Color.SandyBrown;
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.LightGray;

                }

                else if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.DimGray;
                   // panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Beige;
                    panel.BackColor = Color.DimGray;
                    //   panel.BackColor = Color.LightGray;
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    // panel.BackColor = Color.LightGreen;
                  //  panel.BackColor = Color.DeepPink;
                    panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                   // panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                      //  panel.BackColor = Color.OrangeRed;
                    panel.BackColor = Color.DimGray;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.Beige;
                   //    panel.BackColor = Color.LightSkyBlue;
                    panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                  //  panel.BackColor = Color.Beige;
                     //panel.BackColor = Color.DarkBlue;
                    panel.BackColor = Color.DimGray;
                    //   panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Pers)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   // panel.BackColor = Color.Beige;

                  //   panel.BackColor = Color.LightGray;
                    panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                  //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   // panel.BackColor = Color.Orchid;
                    panel.BackColor = Color.DimGray;
                }           
                if (_grid[_columns, _rows, 0] == Bode)
                {
                 //   panel.BackColor = Color.Beige;
                    panel.BackColor = Color.DimGray;
                    //panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Stha && _columns< 5)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                    //  panel.BackColor = Color.DimGray;

                }
              else  if (_grid[_columns, _rows, 0] == Stha && _columns > 4)
                {
                    //  panel.BackgroundImage = Port;
                    //panel.BackColor = Color.SlateGray;
                      panel.BackColor = Color.DimGray;

                }                            
                if (_grid[_columns, _rows, 0] == Cwal && _columns<5 )    {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;

                }
                else if (_grid[_columns, _rows, 0] == Cwal && _columns >= 5)

                {
               //     panel.BackColor = Color.DarkSlateGray;
                    panel.BackColor = Color.DimGray;
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                    //  panel.BackColor = Color.FloralWhite;
                    panel.BackColor = Color.Beige;
                }                          
                if (_grid[_columns, _rows, 0] == Mobl)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.SaddleBrown;
                  //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedh)
                {
                    //  panel.BackColor = Color.WhiteSmoke;
                    panel.BackColor = Color.DimGray;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedb)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.CornflowerBlue;
                   // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Fire)
                {
                    panel.BackColor = Color.DimGray;
                   // panel.BackColor = Color.Firebrick;
                    //panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                    panel.BackColor = Color.DimGray;
                   // panel.BackColor = Color.Khaki;
                   // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Trep)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.RosyBrown;
                 //   panel.BackColor = Color.Beige;
                }
                
              
                if (_grid[_columns, _rows, 0] == LTur)
                {
                    panel.BackColor = Color.DimGray;
                   // panel.BackColor = Color.SteelBlue;
                  //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Steg)
                {
                    // panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.SandyBrown;

                }
                if (_grid[_columns, _rows, 0] == Sewe && _columns < 5)
                {
                    // panel.BackgroundImage = Stegs;
                   // panel.BackColor = Color.DimGray;
                    panel.BackColor = Color.Lime;

                }
              else  if (_grid[_columns, _rows, 0] == Sewe && _columns >= 5)
                {
                    // panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.Lime;

                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                  //  panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.DarkSlateGray;
                    panel.BackColor = Color.DimGray;
                }
            
                if (_grid[_columns, _rows, 0] == TrSK)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == TrAK)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == Tga1)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.DarkSlateBlue;

                }
                if (_grid[_columns, _rows, 0] == Gitt)
                {
                    panel.BackColor = Color.DimGray;
                  //  panel.BackColor = Color.Silver;

                }
                if (_grid[_columns, _rows, 0] == PHea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackgroundImage = Dachs;
                    //  panel.BackColor = Color.DarkRed;
                    panel.BackColor = Color.DimGray;
                   // panel.BackColor = Color.Red;

                }
                if (_grid[_columns, _rows, 0] == Leve)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                 //   panel.BackColor = Color.Snow;
                    panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Mboo)
                {
                  //  panel.BackColor = Color.Teal;
                    panel.BackColor = Color.DimGray;

                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level six

            if (Level == 6)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps6();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;
                     

                      if (_rows == 36 && _columns == 35 || _rows == 30 && _columns == 31 || _rows == 30 && _columns == 27 || _rows == 7 && _columns == 34 || _rows == 19 && _columns == 23 || _rows == 9 && _columns == 15) {
                          _grid[_columns, _rows, 2] = Loot.ToString();
                          _grid[_columns, _rows, 3] = Money;
                      }
                      if (_rows == 15 && _columns == 25 || _rows == 22 && _columns == 31)
                      {
                          _grid[_columns, _rows, 2] = Loot.ToString();
                          _grid[_columns, _rows, 3] = BigMoney;
                } 
                    
                      if (_rows == 27 && _columns == 20 || _rows == 16 && _columns == 10 || _rows == 14 && _columns == 10 || _rows == 15 && _columns == 4 || _rows == 6 && _columns == 30 || _rows == 6 && _columns == 28 || _rows == 4 && _columns == 30 || _rows == 4 && _columns == 28 || _rows == 5 && _columns == 30 || _rows == 5 && _columns == 28 || _rows == 5 && _columns == 25 || _rows == 5 && _columns == 23 || _rows == 3 && _columns == 30 || _rows == 3 && _columns == 28 || _rows == 3 && _columns == 25 || _rows == 3 && _columns == 23)
                      {
                          _grid[_columns, _rows, 2] = Loot.ToString();
                          _grid[_columns, _rows, 4] = Guar;
                }  
                      if (_rows == 13 && _columns == 7 || _rows == 16 && _columns == 5)
                      {
                          _grid[_columns, _rows, 2] = Loot.ToString();
                          _grid[_columns, _rows, 4] = GuaE;
                      }
                      
                       if (_rows == 13 && _columns == 5)
                       {
                           _grid[_columns, _rows, 2] = Loot.ToString();
                           _grid[_columns, _rows, 4] = GuaK;
                       }               

                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal)
                {
                    //  panel.BackColor = Color.Beige;
                     panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Red;           
                }
      
                if (_grid[_columns, _rows, 0] == Schi)
                {
                  
                    //  panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Beige;
                      panel.BackColor = Color.Orange;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    if (_rows< 12&& _columns<16)
                    {
                        panel.BackColor = Color.DarkGreen;

                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                 
                }
                if (_grid[_columns, _rows, 0] == Wass && _columns < 3)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.SteelBlue;

                }
                else if (_grid[_columns, _rows, 0] == Wass && _columns >= 7)

                {
                  //  panel.BackColor = Color.SteelBlue;
                    panel.BackColor = Color.LightGreen;
                }
                // panel.BackColor = Color.LightGreen;
                if (_grid[_columns, _rows, 0] == Hinw )
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                    }                                    
                }
         
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        if (_rows == 6 && _columns == 3)
                        {
                            _grid[_columns, _rows, 2] = Loot.ToString();
                            //panel.BackColor = Color.Beige;
                            // panel.BackColor = Color.LightGreen;
                            panel.BackColor = Color.SlateGray;
                        }
                        else
                        {
                            _grid[_columns, _rows, 2] = Loot.ToString();
                            //panel.BackColor = Color.Beige;
                            // panel.BackColor = Color.LightGreen;
                            panel.BackColor = Color.LightGray;
                        }                     
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                    }
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                     panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.DeepPink;
                   // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                  //  panel.BackColor = Color.OrangeRed;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
      
                    //panel.BackColor = Color.Beige;
                   //  panel.BackColor = Color.LightSkyBlue;
                    panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Pers)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.LightGray;
                        _grid[_columns, _rows, 2] = Loot.ToString();
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                    }
                                
                    // panel.BackColor = Color.Beige;                               
                }              
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Orchid;
                    panel.BackColor = Color.LightGreen;
                }


                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                  //   panel.BackColor = Color.PaleVioletRed;
                }             
                if (_grid[_columns, _rows, 0] == Stha )
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                    //  panel.BackColor = Color.DimGray;

                }
  
                if (_grid[_columns, _rows, 0] == Cwal&& _rows < 11 && _columns < 17)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;

                }
                else if (_grid[_columns, _rows, 0] == Cwal && _rows >= 12 && _columns >= 17)

                {
                    //     panel.BackColor = Color.DarkSlateGray;
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    //  panel.BackColor = Color.LightGreen;
                   panel.BackColor = Color.LightGreen;
                     // panel.BackColor = Color.Purple;
                }
               
             
                else if (_grid[_columns, _rows, 0] == Sewe)
                {
                    // panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.LightGreen;
                      //panel.BackColor = Color.Lime;

                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                      panel.BackColor = Color.LightGreen;
                     //panel.BackColor = Color.DarkSlateGray;
                   // panel.BackColor = Color.LightGreen;
                }

              
                
                if (_grid[_columns, _rows, 0] == Tga1)
                {
                    //panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.DarkSlateBlue;

                }
              
                if (_grid[_columns, _rows, 0] == PHea)
                {
                    if (_rows < 12 && _columns < 16)
                    { _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        panel.BackColor = Color.DarkRed;
                        //panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        //panel.BackColor = Color.DarkRed;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;

                    }


                }
              
                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    //  panel.BackColor = Color.Teal;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                    // panel.BackColor = Color.Wheat;
                   panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    // panel.BackColor = Color.Tan;
                    panel.BackColor = Color.LightGreen;

                }              
                if (_grid[_columns, _rows, 0] == Muhl)
                {
                   //   panel.BackColor = Color.Brown;
                   panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Masd)
                {
                    // panel.BackColor = Color.DarkViolet;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                     // panel.BackColor = Color.Peru;
                      panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;
                }              
                if (_grid[_columns, _rows, 0] == Stra)
                {
                    if (_rows < 11 && _columns < 17)
                    {
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                        //   panel.BackgroundImage = Street;
                     

                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.DimGray;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                 

                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.SaddleBrown;
                        //panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        //panel.BackColor = Color.Brown;
                        panel.BackColor = Color.LightGreen;
                    }
                  
                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.ForestGreen;
                }
                if (_grid[_columns, _rows, 0] == Dwal)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkOliveGreen;
                }
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    panel.BackColor = Color.LightGreen;
                  //    panel.BackColor = Color.DarkGreen;
                }
               
                if (_grid[_columns, _rows, 0] == Ship)
                {
                   // panel.BackgroundImage = Schiffs;
                    panel.BackColor = Color.Brown;
                }

                p = 0;
                c = 0;
            }
            #endregion
            #region Level Seven

            if (Level == 7)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps7();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;

                #region Encounter

          
                if (_rows == 19 && _columns == 37 || _rows == 1 && _columns == 29 || _rows == 11 && _columns == 28 || _rows == 27 && _columns == 23 || _rows == 38 && _columns == 14 || _rows == 28 && _columns== 9  || _rows == 29 && _columns == 7 || _rows == 11 && _columns == 14 || _rows == 11 && _columns == 5)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 35 && _columns == 23 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
               
                if (_rows == 36 && _columns == 36 || _rows == 35 && _columns == 36 || _rows == 29 && _columns == 36 || _rows == 28 && _columns == 36 || _rows == 32 && _columns == 20 || _rows == 33 && _columns == 9 || _rows == 31 && _columns == 9 || _rows == 33 && _columns == 14 || _rows == 31 && _columns == 14 || _rows == 35 && _columns == 6 || _rows == 30 && _columns == 3 || _rows == 29 && _columns == 4 || _rows == 28 && _columns == 6 || _rows == 27 && _columns == 7 || _rows == 27 && _columns == 3 || _rows == 25 && _columns == 4 || _rows == 25 && _columns == 2 || _rows == 3 && _columns == 27 || _rows == 3 && _columns == 21)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Guar;
                } 
                if (_rows == 30 && _columns == 6 || _rows == 30 && _columns == 36 || _rows == 34 && _columns == 36)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = GuaE;
                }

                if (_rows == 3 && _columns == 3 || _rows == 32 && _columns == 4 || _rows == 31 && _columns == 36 || _rows == 33 && _columns == 36)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = GuaK;
                }
                if (_rows == 24 && _columns == 18 || _rows == 17 && _columns == 25 || _rows == 7 && _columns == 27 || _rows == 6 && _columns == 19)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Gobl;
                }
                if (_rows == 32 && _columns == 38 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Dark;
                }
                #endregion
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal)
                {
                    //  panel.BackColor = Color.Beige;
                    panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Red;           
                }

                if (_grid[_columns, _rows, 0] == Schi)
                {
                    // panel.BackColor = Color.Beige;
                   // panel.BackColor = Color.Orange;
                   panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                      //  panel.BackColor = Color.DarkGreen;

                    }
                    else
                    {
                       // panel.BackColor = Color.DarkGreen;
                          panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Wass)
                {
                    if (_columns==1|| _rows< 6)
                    {
                        panel.BackColor = Color.SteelBlue;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                   // panel.BackgroundImage = Burg;
                   
                }             
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                      //  panel.BackColor = Color.LightGray;
                        panel.BackColor = Color.LightGreen;
                    }
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                       
                            _grid[_columns, _rows, 2] = Loot.ToString();
                            //panel.BackColor = Color.Beige;
                            // panel.BackColor = Color.LightGreen;
                            panel.BackColor = Color.LightGray;
                       
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                       // panel.BackColor = Color.LightGray;
                    }
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.DeepPink;
                    // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                     // panel.BackColor = Color.OrangeRed;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {

                    //panel.BackColor = Color.Beige;
                  //    panel.BackColor = Color.LightSkyBlue;
                    panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Pers)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.LightGreen;
                        //  panel.BackColor = Color.LightGray;
                        _grid[_columns, _rows, 2] = Loot.ToString();
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                      //  panel.BackColor = Color.LightGray;
                    }                
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                  //   panel.BackColor = Color.Orchid;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //   panel.BackColor = Color.PaleVioletRed;
                }            
                if (_grid[_columns, _rows, 0] == Cwal )
                {
                    if (_rows < 7 && _columns < 8)
                    {
                        //panel.BackgroundImage = Burg;
                        panel.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                }            
                if (_grid[_columns, _rows, 0] == LTur)
                {
                     panel.BackColor = Color.LightGreen;
                 //   panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Purple;
                }
                else if (_grid[_columns, _rows, 0] == Sewe)
                {
                    // panel.BackgroundImage = Stegs;
                //    panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Lime;
                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkSlateGray;
                   //  panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Tga1)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        //panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.DarkSlateBlue;
                    }
                    else
                    {
                        //  panel.BackColor = Color.LightGreen;
                    }
                }

                if (_grid[_columns, _rows, 0] == PHea)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        //panel.BackColor = Color.DarkRed;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                      //  panel.BackColor = Color.DarkRed;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                }
                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }                   
                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                  //   panel.BackColor = Color.Wheat;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    if (_rows < 9 && _columns < 8)
                    {
                        panel.BackColor = Color.Tan;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                 
                }                               
                if (_grid[_columns, _rows, 0] == Masd)
                {
                   // panel.BackColor = Color.DarkViolet;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                    if (_rows < 9 && _columns < 8)
                    {
                        panel.BackColor = Color.Peru;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                  

                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Stra)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                       // panel.BackColor = Color.LightGray;
                    }
                    //   panel.BackgroundImage = Street;


                }              
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        //panel.BackColor = Color.SaddleBrown;                       
                          panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                       // panel.BackColor = Color.SaddleBrown;
                        //panel.BackColor = Color.Brown;
                       panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.ForestGreen;
                }
                if (_grid[_columns, _rows, 0] == Dwal)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkOliveGreen;
                }
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    if (_rows < 9 && _columns < 10)
                    {
                        panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;

                    }                   
                }
                if (_grid[_columns, _rows, 0] == Moun)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                    //panel.BackColor = Color.FloralWhite;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                    //  panel.BackColor = Color.Khaki;
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Towe)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.MediumSpringGreen;
                }
                if (_grid[_columns, _rows, 0] == Brid)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.Chocolate;
                }
                if (_grid[_columns, _rows, 0] == TgaL)
                {
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.MediumVioletRed;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level Eight

            if (Level == 8)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps8();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;
               
                #region Encounter
                if (_rows == 38 && _columns == 38 || _rows == 31 && _columns == 27 || _rows == 10 && _columns == 27 || _rows == 1 && _columns == 27 || _rows == 19 && _columns == 24 || _rows == 6 && _columns == 22 || _rows == 28 && _columns == 18 || _rows == 20 && _columns == 18 || _rows == 12 && _columns == 19 || _rows == 8 && _columns == 19 || _rows == 33 && _columns == 15 || _rows == 15 && _columns == 12 || _rows == 27 && _columns == 9 || _rows == 28 && _columns == 7 || _rows == 27 && _columns == 2||_rows == 16 && _columns == 2 || _rows == 8 && _columns == 2 )    {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 4 && _columns == 38)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
                if (_rows == 1 && _columns == 2)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Arrow;
                }

                if (_rows == 20 && _columns == 16 || _rows == 19 && _columns == 10 || _rows == 13 && _columns == 10 || _rows == 10 && _columns == 9 || _rows == 7 && _columns == 9 || _rows == 23 && _columns == 8 || _rows == 21 && _columns == 8 || _rows == 15 && _columns == 7 || _rows == 17 && _columns == 6 || _rows == 10 && _columns == 6 || _rows == 21 && _columns == 4 || _rows == 15 && _columns == 4 || _rows == 7 && _columns == 4)    {
                   _grid[_columns, _rows, 2] = Loot.ToString();
                   _grid[_columns, _rows, 4] = Wolf;
                } 
              
               if (_rows == 24 && _columns == 12 || _rows == 1 && _columns == 4 || _rows == 4 && _columns == 6 || _rows == 4 && _columns == 8)
               {
                   _grid[_columns, _rows, 2] = Loot.ToString();
                   _grid[_columns, _rows, 4] = Bear;
               }
              
               if (_rows == 4 && _columns == 29 || _rows == 22 && _columns == 35 || _rows == 31 && _columns == 23 || _rows == 18 && _columns == 30)
                {
                   _grid[_columns, _rows, 2] = Loot.ToString();
                   _grid[_columns, _rows, 4] = Assa;
                } 
               if (_rows == 6 && _columns == 18 || _rows == 6 && _columns == 15 || _rows == 5 && _columns == 19 || _rows == 5 && _columns == 14 || _rows == 4 && _columns == 18 || _rows == 4 && _columns == 16 || _rows == 4 && _columns == 15 || _rows == 2 && _columns == 19 || _rows == 2 && _columns == 14)
                {
                   _grid[_columns, _rows, 2] = Loot.ToString();
                   _grid[_columns, _rows, 4] = Band;
                } 
               
               if (_rows == 2 && _columns == 16)
               {
                   _grid[_columns, _rows, 2] = Loot.ToString();
                   _grid[_columns, _rows, 4] = BandL;
               }  
                #endregion

                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Brun)
                {
                  //  panel.BackColor = Color.SteelBlue;
                     panel.BackColor = Color.LightGreen;
                 
                }
                if (_grid[_columns, _rows, 0] == TrAK || _grid[_columns, _rows, 0] == TrSK || _grid[_columns, _rows, 0] == TrBK)
                {
                   // panel.BackColor = Color.LightGray;
                    panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Vill)
                {
                   // panel.BackColor = Color.DarkRed;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Steg)
                {
                 //   panel.BackColor = Color.SandyBrown;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    // panel.BackColor = Color.Beige;
                     //panel.BackColor = Color.Orange;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Bto1 || _grid[_columns, _rows, 0] == Bto2)
                {
                 //   panel.BackColor = Color.DarkBlue;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == ETur)
                {
                    // panel.BackColor = Color.SteelBlue;
                   panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == GuaK)
                {
                    //panel.BackColor = Color.LightSalmon;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Coin)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   // panel.BackColor = Color.SaddleBrown;
                  //    panel.BackColor = Color.Gold;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        // panel.BackColor = Color.DarkGreen;
                        panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                       //  panel.BackColor = Color.DarkGreen;
                        panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == PHea|| _grid[_columns, _rows, 0] == WHea)
                {                
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                       // panel.BackColor = Color.DarkRed;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;                 
                }
                if (_grid[_columns, _rows, 0] == Fire)
                {
                    panel.BackColor = Color.LightGreen;
                  //  panel.BackColor = Color.DarkOrange;
                   // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Wass)
                {
                    if (_columns <=2 )
                    {
                        panel.BackColor = Color.SteelBlue;
                    }
                    else
                    {
                       // panel.BackColor = Color.SteelBlue;
                        panel.BackColor = Color.LightGreen;
                    }
                    // panel.BackgroundImage = Burg;

                }
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    if (_columns <=3)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                         // panel.BackColor = Color.LightGray;
                        panel.BackColor = Color.LightGreen;
                    }
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    if (_columns <= 3)
                    {

                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackColor = Color.Beige;
                       //  panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;


                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGreen;
                      //   panel.BackColor = Color.LightGray;
                    }
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    panel.BackColor = Color.LightGreen;
                     // panel.BackColor = Color.DeepPink;
                    // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                       panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.OrangeRed;
                   // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    //panel.BackColor = Color.Beige;
                    //    panel.BackColor = Color.LightSkyBlue;
                    panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Pers)
                {
                    if (_columns <= 3)
                    {
                       // panel.BackColor = Color.LightGreen;
                         panel.BackColor = Color.LightGray;
                        _grid[_columns, _rows, 2] = Loot.ToString();
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                       panel.BackColor = Color.LightGreen;
                      //    panel.BackColor = Color.LightGray;
                    }
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   //   panel.BackColor = Color.Orchid;
                    panel.BackColor = Color.LightGreen;
                }


                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   //   panel.BackColor = Color.PaleVioletRed;
                }
            
                if (_grid[_columns, _rows, 0] == Cwal)
                {
                    if (_rows < 7 && _columns < 8)
                    {
                        panel.BackColor = Color.LightGreen;
                        //panel.BackgroundImage = Burg;
                       // panel.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                       // panel.BackColor = Color.DarkSlateGray;
                        panel.BackColor = Color.LightGreen;
                    }
                }

                if (_grid[_columns, _rows, 0] == LTur)
                {
                    panel.BackColor = Color.LightGreen;
                   //    panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {                  
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.Purple;
                }            
                if (_grid[_columns, _rows, 0] == Rock)
                {
                  //  panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.DarkSlateGray;
                     panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Muhl)
                {
                   //    panel.BackColor = Color.Brown;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Tga3)
                {
                   
                        panel.BackColor = Color.LightGreen;
                      //  panel.BackColor = Color.DarkSlateBlue;
                  
                }

                if (_grid[_columns, _rows, 0] == PHea)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                      //  panel.BackColor = Color.DarkRed;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        // panel.BackColor = Color.DarkRed;
                       panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;

                    }
                }

                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        //  panel.BackColor = Color.Teal;
                        //  panel.BackColor = Color.LightGray;
                        panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                       // panel.BackColor = Color.Teal;
                        panel.BackColor = Color.LightGreen;
                    }            
                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                   //    panel.BackColor = Color.Wheat;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    if (_columns <= 3)
                    {
                        panel.BackColor = Color.Tan;
                    }
                    else
                    {
                      //  panel.BackColor = Color.Tan;
                       panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Masd)
                {
                    // panel.BackColor = Color.DarkViolet;
                    panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                    if (_rows < 9 && _columns < 8)
                    {
                        panel.BackColor = Color.LightGreen;
                       // panel.BackColor = Color.Peru;
                    }
                    else
                    {
                       // panel.BackColor = Color.Peru;
                        panel.BackColor = Color.LightGreen;
                    }


                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;

                }

                if (_grid[_columns, _rows, 0] == Stra)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        panel.BackColor = Color.LightGreen;
                      //  panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                       // panel.BackColor = Color.LightGray;
                        panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.LightGray;
                    }
                    //   panel.BackgroundImage = Street;


                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        //   panel.BackColor = Color.DimGray;
                        panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                       // panel.BackColor = Color.DimGray;
                        panel.BackColor = Color.LightGreen;
                    }


                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                       // panel.BackColor = Color.SaddleBrown;                       
                        panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                       //  panel.BackColor = Color.SaddleBrown;
                        //panel.BackColor = Color.Brown;
                        panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                   panel.BackColor = Color.LightGreen;
                   //   panel.BackColor = Color.ForestGreen;
                }
                if (_grid[_columns, _rows, 0] == Dwal)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.DarkOliveGreen;
                }
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                       // panel.BackColor = Color.DarkGreen;
                           panel.BackColor = Color.LightGreen;

                    }
                }
                if (_grid[_columns, _rows, 0] == Moun)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DimGray;
                      //  panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.LightGreen;
                    }
                        //
                       
                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                   // panel.BackColor = Color.FloralWhite;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                   //  panel.BackColor = Color.Khaki;
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Towe)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.MediumSpringGreen;
                }
                if (_grid[_columns, _rows, 0] == Brid)
                {
                    panel.BackColor = Color.LightGreen;
                   //  panel.BackColor = Color.Chocolate;
                }
                if (_grid[_columns, _rows, 0] == TgaL)
                {
                    panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.MediumVioletRed;
                }
                if (_grid[_columns, _rows, 0] == Fenc)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.LightSteelBlue;
                }
                if (_grid[_columns, _rows, 0] == QHau)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.Silver;
                }
                if (_grid[_columns, _rows, 0] == QueT || _grid[_columns, _rows, 0] == QueW || _grid[_columns, _rows, 0] == QueA|| _grid[_columns, _rows, 0] == QueB)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                     panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.Ivory;
                }
                if (_grid[_columns, _rows, 0] == QuTu)
                {
                     panel.BackColor = Color.LightGreen;
                   // panel.BackColor = Color.RoyalBlue;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level Nine
            if (Level == 9)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps9();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;

                #region Encounter
                
                if (_rows == 27 && _columns == 37 || _rows == 24 && _columns == 37 || _rows == 13 && _columns == 34 || _rows == 20 && _columns == 31 || _rows == 20 && _columns == 22 || _rows == 1 && _columns == 21 || _rows == 18 && _columns == 11 || _rows == 15 && _columns == 11 || _rows == 34 && _columns == 11 || _rows == 6 && _columns == 4 || _rows == 36 && _columns == 1 )       {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 11 && _columns == 16)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }
                if (_rows == 27 && _columns == 15)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = LargeMoney;
                }
          
                if (_rows == 18 && _columns == 36 || _rows == 23 && _columns == 35 || _rows == 11 && _columns == 35 || _rows == 20 && _columns == 33 || _rows == 15 && _columns == 31 || _rows == 17 && _columns == 22 || _rows == 17 && _columns == 19 || _rows == 22 && _columns == 14 || _rows == 13 && _columns == 14 || _rows == 16 && _columns == 11 || _rows == 8 && _columns == 11) {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Wolf;
                }

                if (_rows == 27 && _columns == 17 || _rows == 19 && _columns == 2 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bear;
                }

                if (_rows == 38 && _columns == 9 || _rows == 5 && _columns == 14 || _rows == 5 && _columns == 34 || _rows == 32 && _columns == 26)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Assa;
                }
                if (_rows == 35 && _columns == 6 || _rows == 14 && _columns == 16 || _rows == 22 && _columns == 19 || _rows == 16 && _columns == 35)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Gobl;
                }

                if (_rows == 2 && _columns == 34)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = DWolf;
                }
                if (_rows == 37 && _columns == 6)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Behe;
                }      /**/
                #endregion

                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Brun)
                {
                      panel.BackColor = Color.SteelBlue;
                    //panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == TrAK || _grid[_columns, _rows, 0] == TrSK || _grid[_columns, _rows, 0] == TrBK || _grid[_columns, _rows, 0] == TrPK)
                {
                    panel.BackColor = Color.LightGray;
                   // panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Stha)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;

                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.Orange;
                   // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
             
                
               
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                         panel.BackColor = Color.DarkGreen;
                       // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                          panel.BackColor = Color.DarkGreen;
                       // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == PHea || _grid[_columns, _rows, 0] == WHea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackgroundImage = Dachs;
                     panel.BackColor = Color.DarkRed;
                   // panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Red;                 
                }
              
                if (_grid[_columns, _rows, 0] == Wass)
                {
                    if (_columns <= 2)
                    {
                        panel.BackColor = Color.SteelBlue;
                    }
                    else
                    {
                         panel.BackColor = Color.SteelBlue;
                       // panel.BackColor = Color.LightGreen;
                    }
                    // panel.BackgroundImage = Burg;

                }
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    if (_columns <= 3)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                         panel.BackColor = Color.LightGray;
                       // panel.BackColor = Color.LightGreen;
                    }
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    if (_columns <= 3)
                    {

                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackColor = Color.Beige;
                        //  panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;


                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();

                        //panel.BackColor = Color.LightGreen;
                           panel.BackColor = Color.LightGray;
                    }
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                   // panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.DeepPink;
                    // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                  //  panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.OrangeRed;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    //panel.BackColor = Color.Beige;
                        panel.BackColor = Color.LightSkyBlue;
                    //panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Pers)
                {
                    if (_columns <= 3)
                    {
                        // panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                        _grid[_columns, _rows, 2] = Loot.ToString();
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                      //  panel.BackColor = Color.LightGreen;
                            panel.BackColor = Color.LightGray;
                    }
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                      panel.BackColor = Color.Orchid;
                   // panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    //panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                       panel.BackColor = Color.PaleVioletRed;
                }

                if (_grid[_columns, _rows, 0] == Cwal)
                {
                    if (_rows < 7 && _columns < 8)
                    {
                        //panel.BackColor = Color.LightGreen;
                        //panel.BackgroundImage = Burg;
                         panel.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                         panel.BackColor = Color.DarkSlateGray;
                       // panel.BackColor = Color.LightGreen;
                    }
                }

                if (_grid[_columns, _rows, 0] == LTur)
                {
                   // panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Fahn)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Crimson;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Farr)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Sienna;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                  //  panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                    //  panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.DarkSlateGray;
                 //   panel.BackColor = Color.LightGreen;
                }

              
               

                if (_grid[_columns, _rows, 0] == PHea)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                          panel.BackColor = Color.DarkRed;
                      //  panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                         panel.BackColor = Color.DarkRed;
                       // panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;

                    }
                }

                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                          panel.BackColor = Color.Teal;
                        //  panel.BackColor = Color.LightGray;
                       // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                         panel.BackColor = Color.Teal;
                       // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                        panel.BackColor = Color.Wheat;
                   // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    if (_columns <= 3)
                    {
                        panel.BackColor = Color.Tan;
                    }
                    else
                    {
                          panel.BackColor = Color.Tan;
                      //  panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Masd)
                {
                     panel.BackColor = Color.DarkViolet;
                   // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                    if (_rows < 9 && _columns < 8)
                    {
                      //  panel.BackColor = Color.LightGreen;
                         panel.BackColor = Color.Peru;
                    }
                    else
                    {
                         panel.BackColor = Color.Peru;
                       // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;

                }

                if (_grid[_columns, _rows, 0] == Stra)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                       // panel.BackColor = Color.LightGreen;
                          panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        // panel.BackColor = Color.LightGray;
                       // panel.BackColor = Color.LightGreen;
                         panel.BackColor = Color.LightGray;
                    }
                    //   panel.BackgroundImage = Street;


                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                           panel.BackColor = Color.DimGray;
                       // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                         panel.BackColor = Color.DimGray;
                       // panel.BackColor = Color.LightGreen;
                    }


                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                         panel.BackColor = Color.SaddleBrown;                       
                       // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                         panel.BackColor = Color.SaddleBrown;
                        //panel.BackColor = Color.Brown;
                        //panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                   // panel.BackColor = Color.LightGreen;
                       panel.BackColor = Color.ForestGreen;
                }
               
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                         panel.BackColor = Color.DarkGreen;
                       // panel.BackColor = Color.LightGreen;

                    }
                }
                if (_grid[_columns, _rows, 0] == Moun)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DimGray;
                        //  panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.DimGray;
                       // panel.BackColor = Color.LightGreen;
                    }
                    //

                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                   // panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                     panel.BackColor = Color.FloralWhite;
                   // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                      panel.BackColor = Color.Khaki;
                    // panel.BackColor = Color.Beige;
                   // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Towe)
                {
                   // panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.MediumSpringGreen;
                }
                if (_grid[_columns, _rows, 0] == Brid)
                {
                  //  panel.BackColor = Color.LightGreen;
                      panel.BackColor = Color.Chocolate;
                }
               
                if (_grid[_columns, _rows, 0] == Fenc)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightSteelBlue;
                }
                if (_grid[_columns, _rows, 0] == QHau)
                {
                 //   panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.Silver;
                }
                if (_grid[_columns, _rows, 0] == QueT || _grid[_columns, _rows, 0] == QueW || _grid[_columns, _rows, 0] == QueA || _grid[_columns, _rows, 0] == QueB)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                   // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Ivory;
                }
                if (_grid[_columns, _rows, 0] == QuTu)
                {
                   // panel.BackColor = Color.LightGreen;
                     panel.BackColor = Color.RoyalBlue;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Level Ten
            if (Level == 10)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Maps10();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;

                #region Encounter

                if (_rows == 35 && _columns == 38 || _rows == 30 && _columns == 33 || _rows == 35 && _columns == 33 || _rows == 35 && _columns == 29 || _rows == 38 && _columns == 12 || _rows == 15 && _columns == 38 || _rows == 20 && _columns == 28 || _rows == 2 && _columns == 31 || _rows == 1 && _columns == 27 || _rows == 5 && _columns == 16 || _rows == 8 && _columns == 3)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = Money;
                }
                if (_rows == 20 && _columns == 38 || _rows == 12 && _columns == 23 || _rows == 12 && _columns == 19 || _rows == 19 && _columns == 1)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 3] = BigMoney;
                }               
                
                if (_rows == 18 && _columns == 37 || _rows == 14 && _columns == 32 || _rows == 19 && _columns == 15 || _rows == 10 && _columns == 13 || _rows == 17 && _columns == 7 )      {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Gobl;
                }     
                if (_rows == 2 && _columns == 10 || _rows == 4 && _columns == 32 )
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Assa;
                }            
                if (_rows == 14 && _columns == 3)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bos5;
                }
                if (_rows == 6 && _columns == 13)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bos4;
                }
                if (_rows == 10 && _columns == 13)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bos3;
                }
                if (_rows == 14 && _columns == 13)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bos2;
                }
                if (_rows == 17 && _columns == 16)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    _grid[_columns, _rows, 4] = Bos1;
                }
                #endregion
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Brun)
                {
                    panel.BackColor = Color.SteelBlue;
                    //panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == TrAK || _grid[_columns, _rows, 0] == TrSK || _grid[_columns, _rows, 0] == TrBK || _grid[_columns, _rows, 0] == TrPK)
                {
                    panel.BackColor = Color.LightGray;
                    // panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Stha)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;

                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.Orange;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Bush)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.DarkGreen;
                        // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.DarkGreen;
                        // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == PHea || _grid[_columns, _rows, 0] == WHea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;
                    // panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Red;                 
                }

                if (_grid[_columns, _rows, 0] == Wass)
                {
                    if (_columns <= 2)
                    {
                        panel.BackColor = Color.SteelBlue;
                    }
                    else
                    {
                        panel.BackColor = Color.SteelBlue;
                        // panel.BackColor = Color.LightGreen;
                    }
                    // panel.BackgroundImage = Burg;

                }
                if (_grid[_columns, _rows, 0] == Hinw)
                {
                    if (_columns <= 3)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        panel.BackColor = Color.LightGray;
                        // panel.BackColor = Color.LightGreen;
                    }
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    if (_columns <= 3)
                    {

                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackColor = Color.Beige;
                        //  panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;


                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();

                        //panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                    }
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                    // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.OrangeRed;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    //panel.BackColor = Color.Beige;
                    panel.BackColor = Color.LightSkyBlue;
                    //panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Pers)
                {
                    if (_columns <= 3)
                    {
                        // panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                        _grid[_columns, _rows, 2] = Loot.ToString();
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //  panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                    }
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Orchid;
                    // panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    //panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.PaleVioletRed;
                }

                if (_grid[_columns, _rows, 0] == Cwal)
                {
                    if (_rows < 7 && _columns < 8)
                    {
                        //panel.BackColor = Color.LightGreen;
                        //panel.BackgroundImage = Burg;
                        panel.BackColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        panel.BackColor = Color.DarkSlateGray;
                        // panel.BackColor = Color.LightGreen;
                    }
                }

                if (_grid[_columns, _rows, 0] == LTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Fahn)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Crimson;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Farr)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Sienna;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkSlateGray;
                    //   panel.BackColor = Color.LightGreen;
                }




                if (_grid[_columns, _rows, 0] == PHea)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        panel.BackColor = Color.DarkRed;
                        //  panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;
                    }
                    else
                    {
                        _grid[_columns, _rows, 2] = Loot.ToString();
                        //panel.BackgroundImage = Dachs;
                        panel.BackColor = Color.DarkRed;
                        // panel.BackColor = Color.LightGreen;
                        // panel.BackColor = Color.Red;

                    }
                }

                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        panel.BackColor = Color.Teal;
                        //  panel.BackColor = Color.LightGray;
                        // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.Teal;
                        // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                    panel.BackColor = Color.Wheat;
                    // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    if (_columns <= 3)
                    {
                        panel.BackColor = Color.Tan;
                    }
                    else
                    {
                        panel.BackColor = Color.Tan;
                        //  panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Masd)
                {
                    panel.BackColor = Color.DarkViolet;
                    // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                    if (_rows < 9 && _columns < 8)
                    {
                        //  panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.Peru;
                    }
                    else
                    {
                        panel.BackColor = Color.Peru;
                        // panel.BackColor = Color.LightGreen;
                    }
                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;

                }

                if (_grid[_columns, _rows, 0] == Stra)
                {
                    if (_rows < 6 && _columns < 8)
                    {
                        // panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                    }
                    else
                    {
                        // panel.BackColor = Color.LightGray;
                        // panel.BackColor = Color.LightGreen;
                        panel.BackColor = Color.LightGray;
                    }
                    //   panel.BackgroundImage = Street;


                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.DimGray;
                        // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.DimGray;
                        // panel.BackColor = Color.LightGreen;
                    }


                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    if (_rows < 12 && _columns < 16)
                    {
                        panel.BackColor = Color.SaddleBrown;
                        // panel.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.SaddleBrown;
                        //panel.BackColor = Color.Brown;
                        //panel.BackColor = Color.LightGreen;
                    }

                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.ForestGreen;
                }

                if (_grid[_columns, _rows, 0] == Wald)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.DarkGreen;
                        // panel.BackColor = Color.LightGreen;

                    }
                }
                if (_grid[_columns, _rows, 0] == Moun)
                {
                    if (_rows >= 29 && _columns <= 3)
                    {
                        panel.BackColor = Color.DimGray;
                        //  panel.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        panel.BackColor = Color.DimGray;
                        // panel.BackColor = Color.LightGreen;
                    }
                    //

                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkGray;
                }
                if (_grid[_columns, _rows, 0] == Plas)
                {
                    panel.BackColor = Color.FloralWhite;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                    panel.BackColor = Color.Khaki;
                    // panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Towe)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.MediumSpringGreen;
                }
                if (_grid[_columns, _rows, 0] == Brid)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Chocolate;
                }

                if (_grid[_columns, _rows, 0] == Fenc)
                {
                    panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightSteelBlue;
                }
                if (_grid[_columns, _rows, 0] == QHau)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Silver;
                }
                if (_grid[_columns, _rows, 0] == QueT || _grid[_columns, _rows, 0] == QueW || _grid[_columns, _rows, 0] == QueA || _grid[_columns, _rows, 0] == QueB)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Ivory;
                }
                if (_grid[_columns, _rows, 0] == QuTu)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.RoyalBlue;
                }
                if (_grid[_columns, _rows, 0] == Gold)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Gold;
                }
                if (_grid[_columns, _rows, 0] == Fake)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Indigo;
                }
                if (_grid[_columns, _rows, 0] == Che2)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SeaShell;
                }
                if (_grid[_columns, _rows, 0] == MaHe)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.MediumTurquoise;
                }
                if (_grid[_columns, _rows, 0] == Coin)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Gold;
                }
                if (_grid[_columns, _rows, 0] == Vill)
                {
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.MediumSeaGreen;
                }
                if (_grid[_columns, _rows, 0] == Lava)
                {
                    //panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.IndianRed;
                }
                if (_grid[_columns, _rows, 0] == Fire)
                {
                    panel.BackColor = Color.DarkOrange;
                  //  panel.BackColor = Color.Beige;
                }
                p = 0;
                c = 0;
            }
            #endregion
            #region Testlvl


            else if (Level == 0)
            {
                Lvlfunk map = new Lvlfunk();
                string[,] Mapone = map.Testmap();
                _grid[_columns, _rows, 0] = Mapone[_rows, _columns];
                _grid[_columns, _rows, 1] = null;
                _grid[_columns, _rows, 2] = null;
                _grid[_columns, _rows, 3] = null;
                _grid[_columns, _rows, 4] = null;           
                panel.BackgroundImage = null;
                panel.Image = null;
                if (_grid[_columns, _rows, 0] == Wall)
                {
                    panel.BackColor = Color.Brown;
                }
                if (_grid[_columns, _rows, 0] == Heal)
                {
                    //  panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Red;
                    // panel.BackColor = Color.LightGreen;
                }


                if (_grid[_columns, _rows, 0] == Keys)
                {
                    //   panel.BackColor = Color.Beige;
                    //    panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkGoldenrod;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == Schi)
                {
                    //  panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Beige;
                    panel.BackColor = Color.Orange;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }


                if (_grid[_columns, _rows, 0] == Bush)
                {
                    // panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkGreen;
                }
                if (_grid[_columns, _rows, 0] == Wass && _columns < 7)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.SteelBlue;

                }
                else if (_grid[_columns, _rows, 0] == Wass && _columns >= 7)

                {
                    panel.BackColor = Color.SteelBlue;
                    //panel.BackColor = Color.LightGreen;
                }

                // panel.BackColor = Color.LightGreen;



                if (_grid[_columns, _rows, 0] == Hinw && _rows == 31 && _columns == 4)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Beige;
                    //  panel.BackColor = Color.SandyBrown;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;

                }

                else if (_grid[_columns, _rows, 0] == Hinw)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;
                }
                else if (_grid[_columns, _rows, 0] == Kome)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackColor = Color.Beige;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;
                }

                if (_grid[_columns, _rows, 0] == Star)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Yellow;
                }
                if (_grid[_columns, _rows, 0] == Ende)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DeepPink;
                    // panel.BackColor = Color.DimGray;
                }
                if (_grid[_columns, _rows, 0] == Bomb)
                {
                    // panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.OrangeRed;
                    // panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                }
                if (_grid[_columns, _rows, 0] == OTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    //panel.BackColor = Color.Beige;
                    panel.BackColor = Color.LightSkyBlue;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == VTur)
                {
                    //  panel.BackColor = Color.Beige;
                    //panel.BackColor = Color.DarkBlue;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkBlue;
                }
                if (_grid[_columns, _rows, 0] == Pers)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    // panel.BackColor = Color.Beige;

                    panel.BackColor = Color.LightGray;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Swor)
                {
                    //  panel.BackColor = Color.Beige;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Orchid;
                    //panel.BackColor = Color.LightGreen;
                }


                if (_grid[_columns, _rows, 0] == Lmax)
                {
                    // panel.BackColor = Color.SaddleBrown;
                    //panel.BackColor = Color.LightGreen;
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.PaleVioletRed;
                }
                if (_grid[_columns, _rows, 0] == Bode)
                {
                    //   panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkGray;
                }




                if (_grid[_columns, _rows, 0] == Stha && _columns < 5)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                    //  panel.BackColor = Color.DimGray;

                }
                else if (_grid[_columns, _rows, 0] == Stha && _columns > 4)
                {
                    //  panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                    // panel.BackColor = Color.LightGreen;

                }

                if (_grid[_columns, _rows, 0] == Guar)
                {
                    panel.BackColor = Color.LightGray;

                }



                if (_grid[_columns, _rows, 0] == Coin)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //  panel.BackColor = Color.Beige;
                    //   panel.BackColor = Color.SaddleBrown;
                    panel.BackColor = Color.Gold;

                }
                if (_grid[_columns, _rows, 0] == Cwal && _columns < 5)
                {
                    //panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;

                }
                else if (_grid[_columns, _rows, 0] == Cwal && _columns >= 5)

                {
                    panel.BackColor = Color.DarkSlateGray;
                    // panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Beige;
                }




                if (_grid[_columns, _rows, 0] == Plas)
                {
                    panel.BackColor = Color.FloralWhite;
                    //panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Chea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.LightGray;
                    //panel.BackColor = Color.OliveDrab;

                }
                if (_grid[_columns, _rows, 0] == GuaK)
                {
                    panel.BackColor = Color.LightGray;
                    // panel.BackColor = Color.LightGreen;
                }
                if (_grid[_columns, _rows, 0] == Mobl)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SaddleBrown;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedh)
                {
                    panel.BackColor = Color.WhiteSmoke;
                    //panel.BackColor = Color.LightGreen;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Bedb)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.CornflowerBlue;
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Fire)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Firebrick;
                    //panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Etra)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Khaki;
                    // panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Trep)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.RosyBrown;
                    //   panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == LTur)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SteelBlue;
                    //  panel.BackColor = Color.Beige;
                }
                if (_grid[_columns, _rows, 0] == Gift)
                {
                    //  panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Purple;
                }
                if (_grid[_columns, _rows, 0] == Steg)
                {
                    // panel.BackgroundImage = Stegs;
                    //                    panel.BackColor = Color.LightGreen;

                    panel.BackColor = Color.SandyBrown;

                }
                if (_grid[_columns, _rows, 0] == Sewe && _columns < 5)
                {
                    // panel.BackgroundImage = Stegs;
                    // panel.BackColor = Color.DimGray;
                    panel.BackColor = Color.Lime;

                }
                else if (_grid[_columns, _rows, 0] == Sewe && _columns >= 5)
                {
                    // panel.BackgroundImage = Stegs;
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Lime;

                }
                if (_grid[_columns, _rows, 0] == Rock)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkSlateGray;
                    // panel.BackColor = Color.LightGreen;
                }

                if (_grid[_columns, _rows, 0] == TrSK)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == TrAK)
                {
                    //panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == Tga1)
                {
                    //panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkSlateBlue;

                }
                if (_grid[_columns, _rows, 0] == Gitt)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.Silver;

                }
                if (_grid[_columns, _rows, 0] == PHea)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    //panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;
                    //panel.BackColor = Color.LightGreen;
                    // panel.BackColor = Color.Red;

                }
                if (_grid[_columns, _rows, 0] == Leve)
                {
                    _grid[_columns, _rows, 2] = Loot.ToString();
                    panel.BackColor = Color.Snow;
                    //panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Mboo)
                {
                    panel.BackColor = Color.Teal;
                    // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Feld)
                {
                    panel.BackColor = Color.Wheat;
                    // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Fweg)
                {
                    panel.BackColor = Color.Tan;
                    //panel.BackColor = Color.LightGreen;

                }
               
                if (_grid[_columns, _rows, 0] == Muhl)
                {
                    panel.BackColor = Color.Brown;
                    //  panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Masd)
                {
                    panel.BackColor = Color.DarkViolet;
                    // panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Pali)
                {
                    panel.BackColor = Color.Peru;
                    //   panel.BackColor = Color.LightGreen;

                }
                if (_grid[_columns, _rows, 0] == Gras)
                {
                    panel.BackColor = Color.LightGreen;

                }

                if (_grid[_columns, _rows, 0] == Stra)
                {
                    //   panel.BackgroundImage = Street;
                    panel.BackColor = Color.LightGray;

                }
                if (_grid[_columns, _rows, 0] == Gass)
                {
                    //panel.BackgroundImage = Gasses;
                    panel.BackColor = Color.DimGray;

                }
                if (_grid[_columns, _rows, 0] == Haus)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.SaddleBrown;
                }
                if (_grid[_columns, _rows, 0] == Dorn)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.ForestGreen;
                }
                if (_grid[_columns, _rows, 0] == Dwal)
                {
                    // panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkOliveGreen;
                }
                if (_grid[_columns, _rows, 0] == Wald)
                {
                    //  panel.BackColor = Color.LightGreen;
                    panel.BackColor = Color.DarkGreen;
                }
                if (_grid[_columns, _rows, 0] == Dach)
                {
                    //panel.BackgroundImage = Street;
                    panel.BackColor = Color.DarkRed;

                }
                if (_grid[_columns, _rows, 0] == Ship)
                {
                    // panel.BackgroundImage = Schiffs;
                    panel.BackColor = Color.Brown;
                }

                p = 0;
                c = 0;
            }
            #endregion
           
            return panel;
        }
        public void Colors(PictureBox panel, int _rows, int _columns,int lvl, bool wait)
        {
            #region Colorunlock

            #region Rand       
            if (_grid[_columns, _rows, 0] == Wall)
            {
                panel.BackColor = Color.Brown;

            }
            #endregion
            #region Heal


            else if (_grid[_columns, _rows, 0] == Heal && panel.BackColor != Color.LightPink)
            {
                if (lvl == 7 && _columns == 14 && _rows == 14 || lvl == 2 && _columns == 38 && _rows == 35 || lvl == 2 && _columns == 36 && _rows == 25 || lvl == 2 && _columns == 21 && _rows == 17)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4 && _columns == 15 && _rows == 21 || lvl == 4 && _columns == 9 && _rows == 2 || lvl == 4 && _columns == 24 && _rows == 3 || lvl == 2 && _columns == 25 && _rows == 14 || lvl == 3 && _columns == 5 && _rows == 29)
                {
                    panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;
                }
                else if (lvl == 7 && _columns == 23 && _rows == 37 || lvl == 4 && _columns == 30 && _rows == 25)
                {
                    panel.BackgroundImage = Plaza;
                    panel.BackColor = Color.FloralWhite;
                }
                else if (lvl == 5)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }

            }
            #endregion
            #region Keys

         
            else if (_grid[_columns, _rows, 0] == Keys && panel.BackColor != Color.DarkGoldenrod)
            {
                if (lvl == 2 && _columns == 25 && _rows == 26)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4 && _columns == 28 && _rows == 2)
                {
                    panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;
                }
                else if (lvl == 5)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
            }
            #endregion
            #region Armor

          
            else if (_grid[_columns, _rows, 0] == Schi && panel.BackColor != Color.Orange)
            {
                if (lvl == 2 && _columns == 38 && _rows == 38 || lvl == 2 && _columns == 37 && _rows == 38)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                   
                }
                else if (lvl == 5 && _columns == 29 && _rows == 6 || lvl == 5 && _columns == 28 && _rows == 6 || lvl == 2 && _columns == 25 && _rows == 13)
                {
                    panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;
                }
                else if (lvl == 7 && _columns > 25 || lvl == 3 && _columns == 10 && _rows == 33 || lvl == 3 && _columns == 10 && _rows == 34)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4)
                {
                    panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;
                }
                else if (lvl == 5 && _columns == 18 && _rows == 34)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                } else if (lvl == 7 && _rows > 33 || lvl == 6 && _rows < 14)
                {
                    panel.BackgroundImage = Street;
                    panel.BackColor = Color.LightGray;
                }

                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
            }
            #endregion                               
            #region Fest
            else if (_grid[_columns, _rows, 0] == Wald)
            {
                panel.BackColor = Color.DarkGreen;
                panel.BackgroundImage = Tree;
            }
            else if (_grid[_columns, _rows, 0] == Brun)
            {
                panel.BackColor = Color.SteelBlue;
                panel.BackgroundImage = Brunnen;
            }
            else if (_grid[_columns, _rows, 0] == Wass)
            {
                panel.Image = Watery;
                panel.BackColor = Color.SteelBlue;
            }
            else if (_grid[_columns, _rows, 0] == Ship)
            {
                panel.BackgroundImage = Schiffs;
                panel.BackColor = Color.Brown;
            }
            else if (_grid[_columns, _rows, 0] == Cave)
            {
                panel.BackgroundImage = Cavewall;
                // panel.BackColor = Color.LightGreen;

                panel.BackColor = Color.DarkSlateGray;
            }
            else if (_grid[_columns, _rows, 0] == Cwal && lvl == 6)
            {
                if (_columns == 13 && _rows == 1 || _columns == 7 && _rows == 27)
                {
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;

                }
                else
                {
                    panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;
                }

            }
            else if (_grid[_columns, _rows, 0] == Cwal && lvl == 7)
            {
                if (_columns == 10 && _rows == 25)
                {
                    panel.BackgroundImage = Dachs;
                    panel.BackColor = Color.DarkRed;

                }
                else
                {
                    panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;
                }

            }
            else if (_grid[_columns, _rows, 0] == Cwal && lvl != 4)
            {
                panel.BackgroundImage = Burg;
                panel.BackColor = Color.DarkSlateGray;

            }
            else if (_grid[_columns, _rows, 0] == Cwal && lvl == 4)
            {
                if (_rows <= 25 && _rows >= 15 && _columns >= 21 && _columns <= 28 || _rows < 15 && _columns >= 21)
                {
                    panel.BackgroundImage = Wand2;
                    panel.BackColor = Color.RosyBrown;
                }
                else
                {
                    panel.BackgroundImage = Burg;
                    panel.BackColor = Color.DarkSlateGray;
                }


            }
            else if (_grid[_columns, _rows, 0] == Bush)
            {
                panel.BackgroundImage = Bushs;
                panel.BackColor = Color.DarkGreen;

            }
            else if (_grid[_columns, _rows, 0] == Gitt)
            {
                panel.BackgroundImage = Gitter;
                panel.BackColor = Color.Silver;

            }
            else if (_grid[_columns, _rows, 0] == Moun)
            {
                panel.BackgroundImage = Berge;
                panel.BackColor = Color.DimGray;
            }
            else if (_grid[_columns, _rows, 0] == Fenc)
            {
                if (lvl == 8&& _rows<=8)
                {
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = Zaun;
                }
                else if (lvl == 8 && _rows >= 13 && _rows <= 24)
                {
                    panel.BackgroundImage = Zaun2;
                    panel.BackColor = Color.ForestGreen;
                }
                else
                {
                    panel.BackgroundImage = Zaun;
                    panel.BackColor = Color.LightGray;
                }
                              
            }
            #endregion
            #region End and Start


            else if (_grid[_columns, _rows, 0] == Star)
            {
                panel.BackColor = Color.Yellow;
            }
            else if (_grid[_columns, _rows, 0] == Ende)
            {

                panel.BackColor = Color.DeepPink;
            }
            #endregion
            #region Gift


            else if (_grid[_columns, _rows, 0] == Gift && panel.BackColor != Color.Purple)
            {
                if (wait == true)
                {
                    panel.BackgroundImage = Giftig;
                    panel.BackColor = Color.Purple;
                }
                else if (lvl == 7 && _rows > 8 && _rows < 16 || lvl == 2 && _columns > 21 && _rows > 16)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 5)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }


            }
            #endregion
            #region Blockade
            else if (_grid[_columns, _rows, 0] == Rock)
            {
                panel.BackgroundImage = Boulder;
                panel.BackColor = Color.LightSlateGray;
            }
            else if (_grid[_columns, _rows, 0] == Dwal)
            {
                //panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkOliveGreen;
                panel.BackgroundImage = Dwalls;
            }
            #endregion
            #region Buildings

           
            else if (_grid[_columns, _rows, 0] == Haus)
            {
                if (lvl == 6|| lvl == 7)
                {
                    if (_columns == 21 && _rows == 36)
                    {
                        panel.Image = MTurm;
                        panel.BackColor = Color.Tan;
                    }
                    else
                    {
                        panel.Image = Haus2;
                        panel.BackColor = Color.Tan;
                    }
                   
                }
                else
                {
                    panel.Image = Hauswa;
                    panel.BackColor = Color.SaddleBrown;
                }
            }
            else if (_grid[_columns, _rows, 0] == Towe)
            {
                panel.BackgroundImage = Tower;
                panel.BackColor = Color.Moccasin;
            }
            #endregion
            #region Bomb           
            else if (_grid[_columns, _rows, 0] == Bomb && panel.BackColor != Color.OrangeRed)
            {
                if (lvl == 2 && _columns == 37 && _rows == 35)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 3 && _columns == 14 && _rows == 33 || lvl == 3 && _columns == 14 && _rows == 34)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4 || lvl == 5 && _columns == 29 && _rows == 12)
                {
                    panel.BackgroundImage = Stegs;
                    panel.BackColor = Color.SandyBrown;
                }
                else if (lvl == 5 && _columns == 18 && _rows == 35 || lvl == 5 && _columns == 18 && _rows == 29)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }
                // _grid[_columns, _rows, 2] = Loot.ToString();
            }
            #endregion
            #region Tür        
            else if (_grid[_columns, _rows, 0] == OTur)
            {
                if (lvl==1 && _rows<26)
                {
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = Treedoor;
                }
                else if (lvl == 1 && _rows > 26|| lvl == 2 || lvl == 3)
                {
                    if (lvl == 1 && _rows == 33|| lvl == 2 && _rows == 6)
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Palitor4;
                    }
                    else if (lvl == 1 && _rows == 34|| lvl == 2 && _rows == 7)                  
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Palitor3;

                    }
                    else if ( lvl == 2 && _columns == 5)
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Palitor2;

                    }
                    else if (lvl == 2 && _columns == 6)
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Palitor1;

                    }
                    else if (lvl == 2 && _rows == 36)
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Caveopendoor;
                    }
                    else if (lvl == 3 && _rows == 32)
                    {
                        panel.BackColor = Color.OliveDrab;
                        panel.BackgroundImage = Lagertür;
                    }
                }
                else
                {
                    panel.BackColor = Color.LightSkyBlue;
                }
               
            }
            else if (_grid[_columns, _rows, 0] == VTur)
            {
                if (lvl == 2 && _rows == 36)
                {
                    panel.BackColor = Color.DarkBlue;
                    panel.BackgroundImage = Caveclosedoor;
                }
                else if (lvl == 3 && _rows == 32)
                {
                    panel.BackColor = Color.DarkBlue;
                    panel.BackgroundImage = Lagertür;
                }
                else
                {
                    panel.BackColor = Color.DarkBlue;
                }
               
            }
            else if (_grid[_columns, _rows, 0] == ITur)
            {
                panel.BackgroundImage = Iture;
                panel.BackColor = Color.SaddleBrown;

            }
            else if (_grid[_columns, _rows, 0] == ETur)
            {
                panel.BackgroundImage = Iture;
                panel.BackColor = Color.SlateGray;

            }
            else if (_grid[_columns, _rows, 0] == LTur)
            {
                panel.BackColor = Color.SteelBlue;

            }

            #endregion
            #region Personen


            else if (_grid[_columns, _rows, 0] == Pers)
            {
                if (lvl == 10 && _columns == 3 && _rows == 5 || lvl == 7 && _columns == 7 && _rows == 37 || lvl == 6 && _columns == 17 && _rows == 27 || lvl == 2 && _columns == 13 && _rows == 21)
                {
                    panel.BackgroundImage = Fischer;
                    panel.BackColor = Color.DarkGray;
                }
                else if ( lvl == 9 && _columns == 1 && _rows == 30 || lvl == 8 && _columns == 7 && _rows == 31 || lvl == 6 && _columns == 14 && _rows == 30)
                {//
                    panel.BackgroundImage = Müller;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 7 && _rows == 6 || lvl == 9 && _columns == 7 && _rows == 4 || lvl == 8 && _columns == 12 && _rows == 34 || lvl == 7 && _columns == 2 && _rows == 11)
                {//
                    panel.BackgroundImage = Farmerin;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 25 && _rows == 20 || lvl == 9 && _columns == 2 && _rows == 27 || lvl == 7 && _columns == 15 && _rows == 13)
                {
                    panel.BackgroundImage = Druide;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 38 && _rows == 3 || lvl == 9 && _columns == 31 && _rows == 36 || lvl == 8 && _columns == 23 && _rows == 3)
                {// neu 
                    
                    panel.BackgroundImage = Vorlondin_Priest;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 6 && _rows == 13 || lvl == 8 && _columns == 30 && _rows == 10)
                {
                    panel.BackgroundImage = Bogenschütze;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 11 && _rows == 35 || lvl == 10 && _columns == 11 && _rows == 33 || lvl == 8 && _columns == 35 && _rows == 11)
                {
                    panel.BackgroundImage = Elfwar;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 25 && _rows == 7)
                {
                    panel.BackgroundImage = Isekai;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 4 && _rows == 33)
                {
                    panel.BackgroundImage = RunenPriester;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 4 && _rows == 37)
                {
                    panel.BackgroundImage = Dravoswache;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 7 && _rows == 33)
                {
                    panel.BackgroundImage = Elfhealer;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 22 && _rows == 12)
                {
                    panel.BackgroundImage = Sahawreedmagier;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 29 && _rows == 38 || lvl == 8 && _columns == 24 && _rows == 5)
                {
                    panel.BackgroundImage = Vorlondin_Captain;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 35 && _rows == 1 || lvl == 9 && _columns == 29 && _rows == 30 || lvl == 8 && _columns == 29 && _rows == 15)
                {
                    panel.BackgroundImage = Adel;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 7 && _columns == 2 && _rows == 20)
                {
                    panel.BackgroundImage = Ross;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 21 && _rows == 26 || lvl == 10 && _columns == 13 && _rows == 36 || lvl == 10 && _columns == 29 && _rows == 32 || lvl == 9 && _columns == 11 && _rows == 34)
                {
                    panel.BackgroundImage = Elfwache;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 33 && _rows == 34 || lvl == 9 && _columns == 29 && _rows == 27 || lvl == 8 && _columns == 37 && _rows == 8 || lvl == 8 && _columns == 35 && _rows == 8 || lvl == 8 && _columns == 33 && _rows == 34 || lvl == 8 && _columns == 31 && _rows == 34 || lvl == 8 && _columns == 2 && _rows == 35 || lvl == 8 && _columns == 2 && _rows == 37)
                {// Neu
                    panel.BackgroundImage = VEliteGuard;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 29 && _rows == 6 || lvl == 10 && _columns == 29 && _rows == 4 || lvl == 9 && _columns == 5 && _rows == 2 || lvl == 9 && _columns == 23 && _rows == 29 || lvl == 9 && _columns == 29 && _rows == 23 || lvl == 9 && _columns == 27 && _rows == 23 || lvl == 8 && _columns == 10 && _rows == 25 || lvl == 8 && _columns == 25 && _rows == 12 || lvl == 8 && _columns == 33 && _rows == 19 || lvl == 8 && _columns == 31 && _rows == 19 || lvl == 8 && _columns == 33 && _rows == 31 || lvl == 8 && _columns == 27 && _rows == 25 || lvl == 8 && _columns == 27 && _rows == 27 || lvl == 8 && _columns == 17 && _rows == 35 || lvl == 8 && _columns == 17 && _rows == 37)
                {//Neu
                    panel.BackgroundImage = Wache;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 26 && _rows == 4 || lvl == 8 && _columns == 23 && _rows == 28 || lvl == 7 && _columns == 24 && _rows == 2 || lvl == 6 && _columns == 22 && _rows == 26)
                {
                    panel.BackgroundImage = Wirt;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4 && _columns + _rows != 39 || lvl == 4 && _columns != 35 && _rows != 4 || lvl == 3 && _columns == 28 && _rows == 36 || lvl == 3 && _columns == 26 && _rows == 36 || lvl == 3 && _columns == 14 && _rows == 24 || lvl == 3 && _columns == 14 && _rows == 22 || lvl == 3 && _columns == 34 && _rows == 19 || lvl == 3 && _columns == 32 && _rows == 19 || lvl == 3 && _columns == 17 && _rows == 5 || lvl == 3 && _columns == 17 && _rows == 3 || lvl == 3 && _columns == 11 && _rows == 5 || lvl == 3 && _columns == 11 && _rows == 3 || lvl == 2 && _columns == 10 && _rows == 5 || lvl == 2 && _columns == 10 && _rows == 8 || lvl == 2 && _columns == 7 && _rows == 14)

                {
                    panel.BackgroundImage = Soldat;
                    panel.BackColor = Color.DarkGray;
                }

                else if (lvl == 9 && _columns == 24 && _rows == 19 || lvl == 8 && _columns == 23 && _rows == 9 || lvl == 6 && _columns == 21 && _rows == 9 || lvl == 3 && _columns == 24 && _rows == 20 || lvl == 2 && _columns == 3 && _rows == 10)
                {//Sword
                    panel.BackgroundImage = Schmied;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 24 && _rows == 16 || lvl == 8 && _columns == 23 && _rows == 14 || lvl == 3 && _columns == 18 && _rows == 20)
                {//Armor
                    panel.BackgroundImage = Schmied2;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 21 && _rows == 25 || lvl == 8 && _columns == 19 && _rows == 31  || lvl == 6 && _columns == 12 && _rows == 14)
                {//
                    panel.BackgroundImage = sahawreed;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 4 && _columns == 35 && _rows == 4)

                {
                    panel.BackgroundImage = Guardk;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 5 && _columns == 23 && _rows == 19)

                {
                    panel.BackgroundImage = Bandit;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 21 && _rows == 29 || lvl == 7 && _columns == 10 && _rows == 35)

                {
                    panel.BackgroundImage = Söldner;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 27 && _rows == 17 || lvl == 6 && _columns == 5 && _rows == 31)

                {
                    panel.BackgroundImage = Söldner2;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 6 && _rows == 35 || lvl == 10 && _columns == 38 && _rows == 10 || lvl == 10 && _columns == 3 && _rows == 23 || lvl == 9 && _columns == 37 && _rows == 34 || lvl == 9 && _columns == 33 && _rows == 31 || lvl == 8 && _columns == 34 && _rows == 34 || lvl == 8 && _columns == 30 && _rows == 25)

                {
                    panel.BackgroundImage = Elf;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 20 && _rows == 38)
                    //
                {
                    panel.BackgroundImage = Lehrling;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 2 && _rows == 36 || lvl == 10 && _columns == 2 && _rows == 34)
                //
                {
                    panel.BackgroundImage = ElfElite;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 12 && _rows == 24 || lvl == 9 && _columns == 3 && _rows == 16 || lvl == 8 && _columns == 30 && _rows == 1 || lvl == 6 && _columns == 33 && _rows == 4)

                {
                    panel.BackgroundImage = Wanderer;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 32 && _rows == 2 || lvl == 9 && _columns == 23 && _rows == 3 || lvl == 8 && _columns == 29 && _rows == 37||lvl == 8 && _columns == 22 && _rows == 25 || lvl == 6 && _columns == 10 && _rows == 5 || lvl == 5 && _columns == 20 && _rows == 18 || lvl == 3 && _columns == 28 && _rows == 4 || lvl == 3 && _columns == 21 && _rows == 9 || lvl == 3 && _columns == 36 && _rows == 16 || lvl == 3 && _columns == 28 && _rows == 11)

                {//
                    panel.BackgroundImage = Mann;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 12 && _rows == 8 || lvl == 9 && _columns == 35 && _rows == 38 || lvl == 8 && _columns == 34 && _rows == 26 || lvl == 6 && _columns == 20 && _rows == 19 || lvl == 3 && _columns == 26 && _rows == 21 || lvl == 3 && _columns == 36 && _rows == 17)

                {
                    panel.BackgroundImage = Frau;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 28 && _rows == 6 || lvl == 5 && _columns == 24 && _rows == 11 || lvl == 5 && _columns == 18 && _rows == 10 || lvl == 3 && _columns == 24 && _rows == 6 || lvl == 3 && _columns == 16 && _rows == 24)

                {
                    panel.BackgroundImage = DiebH;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 5 && _columns == 32 && _rows == 17 || lvl == 5 && _columns == 18 && _rows == 16 || lvl == 5 && _columns == 24 && _rows == 2)

                {
                    panel.BackgroundImage = Bettler1;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 8 && _columns == 22 && _rows == 23 || lvl == 5 && _columns == 34 && _rows == 16 || lvl == 5 && _columns == 32 && _rows == 18 || lvl == 5 && _columns == 24 && _rows == 6 || lvl == 5 && _columns == 18 && _rows == 5)

                {
                    panel.BackgroundImage = Bettler2;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 5 && _columns == 37 && _rows == 18 || lvl == 5 && _columns == 37 && _rows == 17 || lvl == 5 && _columns == 18 && _rows == 17 || lvl == 5 && _columns == 18 && _rows == 6)

                {
                    panel.BackgroundImage = Bettlerin;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 23 && _rows == 32 || lvl == 5 && _columns == 11 && _rows == 9 || lvl == 3 && _columns == 12 && _rows == 18 || lvl == 3 && _columns == 11 && _rows == 30 || lvl == 3 && _columns == 9 && _rows == 14 || lvl == 3 && _columns == 4 && _rows == 33)

                {
                    panel.BackgroundImage = Matros;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 7 && _columns == 11 && _rows == 28 || lvl == 5 && _columns == 36 && _rows == 16 || lvl == 2 && _columns == 6 && _rows == 7 || lvl == 3 && _columns == 33 && _rows == 2)

                {

                    panel.BackgroundImage = Priester;
                    panel.BackColor = Color.DarkGray;


                }
                else if (lvl == 9 && _columns == 34 && _rows == 26 || lvl == 8 && _columns == 17 && _rows == 24 || lvl == 7 && _columns == 15 && _rows == 37 || lvl == 6 && _columns == 10 && _rows == 27 || lvl == 2 && _columns == 5 && _rows == 4 || lvl == 3 && _columns == 30 && _rows == 16)

                {
                    panel.BackgroundImage = Holzer;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 36 && _rows == 19 || lvl == 10 && _columns == 37 && _rows == 14 || lvl == 10 && _columns == 37 && _rows == 12 || lvl == 10 && _columns == 35 && _rows == 15 || lvl == 8 && _columns == 35 && _rows == 30 || lvl == 8 && _columns == 30 && _rows == 30)

                {
                    panel.BackgroundImage = Zwerg;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 3 && _columns == 17 && _rows == 36)

                {
                    panel.BackgroundImage = ArmKa;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 3 && _columns == 20 && _rows == 36)

                {
                    panel.BackgroundImage = SchKa;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 3 && _columns == 23 && _rows == 36)

                {
                    panel.BackgroundImage = Bomka;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 32 && _rows == 7)

                {
                    panel.BackgroundImage = Orklaswache;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 7 && _columns == 22 && _rows == 36)

                {
                    panel.BackgroundImage = Mage;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 35 && _rows == 9)

                {
                    panel.BackgroundImage = Miner;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 37 && _rows == 34 || lvl == 10 && _columns == 22 && _rows == 38)

                {
                    panel.BackgroundImage = Direwolf;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 24 && _rows == 29 || lvl == 10 && _columns == 9 && _rows == 37 || lvl == 10 && _columns == 38 && _rows == 23 || lvl == 9 && _columns == 26 && _rows == 36 || lvl == 8 && _columns == 37 && _rows == 15)

                {
                    panel.BackgroundImage = Elfin;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 27 && _rows == 7 || lvl == 9 && _columns == 6 && _rows == 25 || lvl == 8 && _columns == 5 && _rows == 34 || lvl == 7 && _columns == 18 && _rows == 31 || lvl == 6 && _columns == 10 && _rows == 22 || lvl == 6 && _columns == 8 && _rows == 37 || lvl == 2 && _columns == 8 && _rows == 8 || lvl == 3 && _columns == 27 && _rows == 27)
                    
                {
                    panel.BackgroundImage = Farmer;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 10 && _columns == 15 && _rows == 7 || lvl == 9 && _columns == 27 && _rows == 7 || lvl == 8 && _columns == 11 && _rows == 31 || lvl == 7 && _columns == 16 && _rows == 27 || lvl == 6 && _columns == 20 && _rows == 31)
                {
                    panel.BackgroundImage = Farmer2;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 2 && _columns == 22 && _rows == 14 || lvl == 3 && _columns == 2 && _rows == 29)

                {
                    panel.BackgroundImage = Captain;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 9 && _columns == 7 && _rows == 29 || lvl == 9 && _columns == 22 && _rows == 30 || lvl == 7 && _columns == 28 && _rows == 31 || lvl == 2 && _columns == 27 && _rows == 20)

                {
                    panel.BackgroundImage = Zpirat;
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackColor = Color.LightGray;
                }
                // panel.BackColor = Color.LightGreen;

            }
            #endregion
            #region Sword

        
            else if (_grid[_columns, _rows, 0] == Swor && panel.BackColor != Color.Orchid)
            {
                if (lvl == 2 && _columns == 35 && _rows == 16 || lvl == 2 && _columns == 36 && _rows == 35 || lvl == 2 && _columns == 35 && _rows == 35)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 7 && _columns == 37 && _rows == 15 || lvl == 3 && _columns == 10 && _rows == 36 || lvl == 3 && _columns == 10 && _rows == 37)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 5)
                {
                    panel.BackgroundImage = Port;
                    panel.BackColor = Color.SlateGray;
                }
                else if (lvl == 6 && _rows < 14)
                {
                    panel.BackgroundImage = Street;
                    panel.BackColor = Color.LightGray;
                }
                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }


            }
            #endregion
            #region Text Dialog Monolog
            else if (_grid[_columns, _rows, 0] == Hinw)
            {
                panel.BackgroundImage = Question;
                panel.BackColor = Color.LightGray;
            }
            else if (_grid[_columns, _rows, 0] == Kome)
            {
                panel.BackgroundImage = really;
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.LightGray;
            }
            #endregion
            #region Damage except Gift
            else if (_grid[_columns, _rows, 0] == Dorn)
            {
                //panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.ForestGreen;
                panel.BackgroundImage = Dornen;
            }
            else if (_grid[_columns, _rows, 0] == Lava)
            {
                panel.BackgroundImage = Lavas;
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.IndianRed;
            }
            else if (_grid[_columns, _rows, 0] == Fire)
            {
                panel.BackgroundImage = Burn;
                panel.BackColor = Color.Firebrick;

            }
            else if (_grid[_columns, _rows, 0] == Etra)
            {
                panel.BackgroundImage = Electros;
                panel.BackColor = Color.Khaki;

            }
            else if (_grid[_columns, _rows, 0] == Sewe)
            {
                panel.BackgroundImage = Sewer;
                panel.BackColor = Color.Lime;

            }
            #endregion
            #region LMax


            else if (_grid[_columns, _rows, 0] == Lmax && panel.BackColor != Color.PaleVioletRed)
            {
                if (lvl == 2 && _columns == 35 && _rows == 38)
                {
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 3 && _columns == 14 && _rows == 36)
                {
                    panel.BackgroundImage = Boden;
                    panel.BackColor = Color.DarkGray;
                }
                else if (lvl == 7 && _columns == 21 && _rows == 37)
                {
                    panel.BackgroundImage = Plaza;
                    panel.BackColor = Color.FloralWhite;
                }

                else
                {
                    panel.BackgroundImage = grassy;
                    panel.BackColor = Color.LightGreen;
                }

            }
            #endregion
            #region Walkground
            else if (_grid[_columns, _rows, 0] == Bode && lvl != 4)
            {
                panel.BackgroundImage = Boden;
                panel.BackColor = Color.DarkGray;
            }
            else if (_grid[_columns, _rows, 0] == Bode && lvl == 4)

            {
                panel.BackgroundImage = Stegs;
                panel.BackColor = Color.Bisque;
            }
            else if (_grid[_columns, _rows, 0] == Steg)
            {
                panel.BackgroundImage = Stegs;
                panel.BackColor = Color.SandyBrown;

            }
            else if (_grid[_columns, _rows, 0] == Gras)
            {
                panel.BackColor = Color.LightGreen;
                panel.BackgroundImage = grassy;
            }
            else if (_grid[_columns, _rows, 0] == Stra)
            {
                panel.BackColor = Color.LightGray;
                panel.BackgroundImage = Street;
            }
            else if (_grid[_columns, _rows, 0] == Stha)
            {
                panel.BackColor = Color.SlateGray;
                panel.BackgroundImage = Port;
            }
            else if (_grid[_columns, _rows, 0] == Gass)
            {
                panel.BackColor = Color.DimGray;
                panel.BackgroundImage = Gasses;
            }
            else if (_grid[_columns, _rows, 0] == Plas)
            {
                panel.BackgroundImage = Plaza;
                panel.BackColor = Color.FloralWhite;

            }
            else if (_grid[_columns, _rows, 0] == Tepp)
            {
                panel.BackgroundImage = Teppic;
                panel.BackColor = Color.Beige;

            }
            else if (_grid[_columns, _rows, 0] == Trep)
            {
                panel.BackgroundImage = Stairs;
                panel.BackColor = Color.RosyBrown;

            }
            else if (_grid[_columns, _rows, 0] == Feld)
            {
                panel.BackgroundImage = Felds;
                panel.BackColor = Color.Wheat;
            }
            else if (_grid[_columns, _rows, 0] == Fweg)
            {
                panel.BackgroundImage = Fwegs;
                panel.BackColor = Color.Tan;

            }
            #endregion
            #region Möbel
            else if (_grid[_columns, _rows, 0] == Ofen)
            {
                panel.BackgroundImage = Oven;
                panel.BackColor = Color.DarkSlateGray;

            }
            else if (_grid[_columns, _rows, 0] == Bank)
            {
                panel.BackgroundImage = Bench;
                panel.BackColor = Color.SaddleBrown;

            }
            else if (_grid[_columns, _rows, 0] == Alta)
            {
                panel.BackgroundImage = Altar;
                panel.BackColor = Color.SlateGray;

            }
            else if (_grid[_columns, _rows, 0] == Mobl && _rows == 19 && _columns == 25)
            {
                panel.BackgroundImage = Stuhl;
                panel.BackColor = Color.PeachPuff;

                // panel.BackColor = Color.Beige;
            }
            else if (_grid[_columns, _rows, 0] == Mobl)
            {
                panel.BackColor = Color.SaddleBrown;
                // panel.BackColor = Color.Beige;
            }
            else if (_grid[_columns, _rows, 0] == Bedh)
            {
                panel.BackgroundImage = Bedhead;
                panel.BackColor = Color.WhiteSmoke;
                // panel.BackColor = Color.Beige;
            }
            else if (_grid[_columns, _rows, 0] == Bedb)
            {
                panel.BackgroundImage = Bedbody;
                panel.BackColor = Color.CornflowerBlue;
                //panel.BackColor = Color.Beige;
            }
            else if (_grid[_columns, _rows, 0] == Leve && panel.BackgroundImage != Hebel2)
            {
                panel.BackgroundImage = Hebel1;
                _grid[_columns, _rows, 2] = Loot.ToString();
                panel.BackColor = Color.PaleTurquoise;

            }
            #endregion
            #region Top
            else if (_grid[_columns, _rows, 0] == Dach)
            {
                panel.BackgroundImage = Street;
                panel.BackColor = Color.DarkRed;

            }
            #endregion
            #region Quest
            else if (_grid[_columns, _rows, 0] == GuaK)
            {
                if (lvl<8)
                {
                    panel.BackgroundImage = Guardk;
                    panel.BackColor = Color.DarkGray;
                }
                else
                {
                    panel.BackgroundImage = Vorlondin_Captain;
                    panel.BackColor = Color.DarkGray;
                }
              

            }
            #endregion
            #region Trade
            else if (_grid[_columns, _rows, 0] == TrSA)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrSB)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrSS)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrAK)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrSK)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrKK)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            else if (_grid[_columns, _rows, 0] == TrBK)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.DarkGray;

            }
            #endregion
            #region Not Used
            else if (_grid[_columns, _rows, 0] == BanC)
            {
                panel.BackgroundImage = BanCa;
                panel.BackColor = Color.DarkGray;

            }
            #endregion
            #region Gold and QuestItem
            else if (_grid[_columns, _rows, 0] == Coin)
            {
                panel.BackgroundImage = Hmoney;
                panel.BackColor = Color.Gold;

            }
            else if (_grid[_columns, _rows, 0] == QueT || _grid[_columns, _rows, 0] == QueW || _grid[_columns, _rows, 0] == QueA || _grid[_columns, _rows, 0] == QueB)
            {
                if (_grid[_columns, _rows, 0] == QueT)
                {
                    panel.BackgroundImage = Adel;
                }
                else if (_grid[_columns, _rows, 0] == QueA)
                {
                    panel.BackgroundImage = Adel;
                }
                else if (_grid[_columns, _rows, 0] == QueB)
                {
                    panel.BackgroundImage = Bogenschütze;
                }
                else if (_grid[_columns, _rows, 0] == QueW)
                {
                    panel.BackgroundImage = Bogen2;
                }
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.Ivory;
            }
            #endregion
            #region Other
            else if (_grid[_columns, _rows, 0] == Mayo)
            {
                panel.BackgroundImage = Gov;
                panel.BackColor = Color.SlateGray;

            }


            #endregion
            #region Magic
            else if (_grid[_columns, _rows, 0] == Mboo)
            {
                panel.BackColor = Color.Teal;
            }
            else if (_grid[_columns, _rows, 0] == Masd)
            {
                panel.BackgroundImage = Magic_Schield;
                panel.BackColor = Color.DarkViolet;
            }
            #endregion
            #region Mühle


            else if (_grid[_columns, _rows, 0] == Muhl)
            {
                if (_columns == 14 && _rows == 28&& lvl==6|| _columns == 6 && _rows == 29 && lvl == 8)
                {
                    panel.BackgroundImage = Wind1;
                }
                else if (_columns == 15 && _rows == 28 && lvl == 6 || _columns == 7 && _rows == 29 && lvl == 8)
                {
                    panel.BackgroundImage = Wind2;
                }
                else if (_columns == 15 && _rows == 29 && lvl == 6 || _columns == 6 && _rows == 30 && lvl == 8)
                {
                    panel.BackgroundImage = Wind3;
                }
                else if (_columns == 14 && _rows == 29 && lvl == 6 || _columns == 7 && _rows == 30 && lvl == 8)
                {
                    panel.BackgroundImage = Wind4;
                }
                //   
                //panel.BackColor = Color.Brown;

            }
            #endregion                    
            #region Palisade


            else if (_grid[_columns, _rows, 0] == Pali)
            {
                if (_columns == 3&& lvl==6|| _columns == 2 && lvl == 7|| _columns == 8 && lvl == 7)
                {
                    panel.BackgroundImage = Pali3;
                    panel.BackColor = Color.Peru;
                }
                else if (_columns == 11 && lvl == 2 || lvl == 1 || _columns == 16 && lvl == 7 || _columns == 24 && lvl == 6 || _columns == 4 && lvl == 7 || _columns == 12 && lvl == 7)
                {
                    panel.BackgroundImage = Pli2;
                    panel.BackColor = Color.Peru;

                }
                else 
                {
                    panel.BackgroundImage = Palisade;
                    panel.BackColor = Color.Peru;
                }
            }
            #endregion                    
            #region Brücke
          

            else if (_grid[_columns, _rows, 0] == Brid)
            {
                if (_columns == 30 && _rows == 31|| _columns == 31 && _rows == 31)
                {
                    panel.BackgroundImage = Bri1;
                }
                else if (_columns == 30 && _rows == 32||  _columns == 31 && _rows == 32)
                {
                    panel.BackgroundImage = Brid4;
                }
                else if (_columns == 30 && _rows == 33 || _columns == 31 && _rows == 33)
                {
                    panel.BackgroundImage = Bri2;
                }

            }
            #endregion
            #region Tribut
            else if (_grid[_columns, _rows, 0] == TgaL)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.MediumVioletRed;
            }
            else if (_grid[_columns, _rows, 0] == Tga1)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkSlateBlue;
            }
            else if (_grid[_columns, _rows, 0] == Tga2)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkSlateBlue;
            }
            else if (_grid[_columns, _rows, 0] == Tga3)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkSlateBlue;
            }
            #endregion
            #region Banditdoor
            else if (_grid[_columns, _rows, 0] == Bto1)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkBlue;
            }
            else if (_grid[_columns, _rows, 0] == Bto2)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.DarkBlue;
            }
            #endregion
            #region Questhaus
            else if (_grid[_columns, _rows, 0] == QHau)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.Silver;
            }

            else if (_grid[_columns, _rows, 0] == QuTu)
            {
                // panel.BackColor = Color.LightGreen;
                panel.BackColor = Color.RoyalBlue;
            }
            #endregion
            #endregion
        }
        

     
        public PictureBox Starts(PictureBox panel, int _rows, int _columns)
        {
            #region Gamestart
            if (_grid[_columns, _rows, 0] == Star || panel.BackColor == Color.Yellow )
            {
                panel.Image = Secret;
                panel.BorderStyle = BorderStyle.FixedSingle;
                _grid[_columns, _rows, 1] = Player;
            }



            return panel;
            #endregion
        }
        #region Move

     
        int empty = 0;
        public PictureBox Down(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss,int schleif,int lvl,int gold,int Tokens, int Mana)
        {
            bool wait = false;
            #region Fest

           
            if ( _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == VTur && Keysss == 0 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Haus || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Rock && Bombs == 0 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Wall || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Wass || _grid[_column, _row , 1] == Player && _grid[_column, _row+1, 0] == Wald)
             {
                if (_grid[_column, _row+1, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row+1, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Cave || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Ship || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Dwal && schleif == 0)
            {
                if (_grid[_column, _row + 1, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Ofen || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Alta || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Stmk || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Blck || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bank || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bto2 && Tokens < 5 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bto1 && Tokens < 2 ||_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bush || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Vill || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Cwal || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == ITur || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Tga2 && gold < 2000 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Tga1 && gold < 100)
            {
                if (_grid[_column, _row + 1, 0] == Tga2|| _grid[_column, _row + 1, 0] == Tga1)
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                if (_grid[_column, _row + 1, 0] == Bto1 )
                {
                    MessageBox.Show("Wir lassen dich durch wenn du Blutzahns Männer verprügelst, bring mindestens 2 Zeichen von Blutzahn, wir haben für dich ein einmaliges Angebot");
                }
                if (_grid[_column, _row + 1, 0] == Bto2)
                {
                    MessageBox.Show("Ha du denkst du kannst es mit uns aufnehmen kom wieder mit 5 unserer Zeichen");
                }
                if (_grid[_column, _row + 1, 0] == Blck)
                {
                    MessageBox.Show("Hier geht es nicht weiter");
                }
                if (_grid[_column, _row + 1, 0] == ITur)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                }

                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Mayo || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == ETur || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bedh || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Bedb || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Mobl)
            {
              
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Gitt || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == LTur)      {

                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Masd && Mana == 0 || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Muhl || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Pali)
            {
                if (_grid[_column, _row + 1, 0] == Masd)
                {
                    MessageBox.Show("Du hast zu Wenig Magische Kraft");
                }
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Moun || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == TgaL && gold == 0||_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Towe ) {

                if (_grid[_column, _row + 1, 0] == TgaL)
                {
                    MessageBox.Show("Du brauchst mindestens eine Münze");
                }
                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Brun || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == QHau || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Fenc || _grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Tga3 && gold < 300)
            {
                if (_grid[_column, _row + 1, 0] == Tga3 )
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }

                p++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row + 1, 0] == Fahn)  {

                p++;
            }
            #endregion
            #region Explore


            if (_row > 0 && _column > 0&& _row < 39 && _column < 39)
            {
                //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! P bearbeiten
                if (_grid[_column+1, _row + 1, 1] == Player || _grid[_column-1, _row + 1, 1] == Player || _grid[_column+1, _row - 1, 1] == Player || _grid[_column-1, _row - 1, 1] == Player || _grid[_column, _row-1, 1] == Player || _grid[_column, _row+1, 1] == Player || _grid[_column-1, _row, 1] == Player || _grid[_column, _row, 1] == Player|| _grid[_column+1, _row, 1] == Player)
                {
                    Colors(panel, _row,  _column, lvl,wait);
                }

            }
            #endregion
            #region Open

            if (_row>0&&_row == Rowsd-p+1  )
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null  || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null || _grid[_column, _row-1, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {            
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
              else  if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                //Chapter 3 part 1
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrSB && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrSA && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrSS && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrSK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrAK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Gass && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Guar && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Tga2 && panel.Image == null && gold >= 2000 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Tga1 && panel.Image == null && gold >= 100 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Stha && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Stra && panel.Image == null )
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                //Chapter 3 part 2
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dach && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Chea && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == PHea && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Plas && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bto2 && panel.Image == null && Tokens >= 5 || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Bto1 && panel.Image == null && Tokens >= 2||_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Coin && panel.Image == null)   {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Trep && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Etra && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Tepp && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Mboo && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Leve && panel.Image == null) {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Masd && panel.Image == null && Mana > 0||_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Fweg && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Feld && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Brid && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TgaL && panel.Image == null && gold >= 1)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == QueB && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == QueW && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == QueT && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == QuTu && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrBK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Tga3 && panel.Image == null && gold >= 300)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == TrPK && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Farr && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Che2 && panel.Image == null||_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Fake && panel.Image == null||_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Gold && panel.Image == null || _grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == MaHe && panel.Image == null)
                {
                    _grid[_column, _row - 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }

                #endregion
                #region End


            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Lmax || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Ende || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Star || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bomb || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Keys || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == OTur || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Schi || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Heal || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Hinw || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gift || _row > 0 && _row == Rowsd- p && _grid[_column, _row-1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Steg || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Lava || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bode || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Dorn || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Kome || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Swor || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Pers)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrSB || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrSA || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrSS || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrKK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrSK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrAK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gass || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Guar || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Tga2 || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Tga1 || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Stha || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Stra)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == GuaK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Dach || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == GuaK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Chea || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == PHea || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Plas || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bto2||_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Bto1 || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Coin)  {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Trep || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Etra || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Tepp || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Fire)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Mboo || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Sewe || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Leve)    {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Masd || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Fweg || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Feld)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Brid || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TgaL)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == QueB || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == QueA || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == QueW || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == QueT || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == QuTu || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Tga3 || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrBK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == WHea) {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == TrPK || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Farr) {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Che2 || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Fake || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == Gold || _row > 0 && _row == Rowsd - p && _grid[_column, _row - 1, 1] == null && panel.Image == Secret && _grid[_column, _row + 1, 0] == MaHe) {
                panel.Image = null;
            }
            #endregion
            return panel;
        }
        public PictureBox Wait(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl, int gold, int Tokens,bool wait)
        {
            #region Explore      
            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {
                    Colors(panel, _row, _column, lvl,wait);
                }
            }
            #endregion
            return panel;
        }   
        public PictureBox Up(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl, int gold, int Tokens, int Mana)
        {
            bool wait = false;
            #region Fest

            if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur && Keysss == 0 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock && Bombs == 0 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Wall || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Haus || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Wass || _row < 39 && _grid[_column, _row+1, 1] == Player && _grid[_column, _row , 0] == Wald)
            {
                if (_grid[_column, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Cave || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Ship || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal && schleif == 0 )
            {
                if (_grid[_column, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Ofen || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Alta || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Stmk || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Blck || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bank || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bto2 && Tokens < 5 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bto1 && Tokens < 2 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bush || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Vill || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Cwal || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == ITur || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga2 && gold < 2000 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga1 && gold < 100)
            {
                if (_grid[_column, _row, 0] == Tga1|| _grid[_column, _row, 0] == Tga2)
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                if (_grid[_column, _row , 0] == Bto1)
                {
                    MessageBox.Show("Wir lassen dich durch wenn du Blutzahns Männer verprügelst, bring mindestens 2 Zeichen von Blutzahn, wir haben für dich ein einmaliges Angebot");
                }
                if (_grid[_column, _row, 0] == Bto2)
                {
                    MessageBox.Show("Ha du denkst du kannst es mit uns aufnehmen kom wieder mit 5 unserer Zeichen");
                }
                if (_grid[_column, _row, 0] == Blck)
                {
                    MessageBox.Show("Hier geht es nicht weiter");
                }
                if (_grid[_column, _row, 0] == ITur)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Mayo || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == ETur || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bedh||_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bedb || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Mobl)
            {
                
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Gitt || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == LTur)
            {
                
                   p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Masd && Mana == 0 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Muhl || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Pali)
            {
                if (_grid[_column, _row, 0] == Masd)
                {
                    MessageBox.Show("Deine Magische Kraft Reicht nicht aus");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Moun || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Towe ||_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TgaL && gold == 0)
            {
                if (_grid[_column, _row, 0] == TgaL)
                {
                    MessageBox.Show("Du brauchst wenigstens eine Münze");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Brun || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QHau || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga3 && gold < 300 || _row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Fenc)
            {
                if (_grid[_column, _row, 0] == Tga3)
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                p--;
            }
            else if (_row < 39 && _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Fahn)
            {

                p--;
            }

            #endregion
            #region Explore


            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl,wait);
                }
            }
            #endregion         
            #region Open

            if (_row > 0 && _row == Rowsd-p - 1 )
            {


                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null || _grid[_column, _row+1, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if    (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrSB && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrSA && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrSS && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrSK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrAK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Gass && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Guar && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga2 && panel.Image == null && gold >= 2000 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga1 && panel.Image == null && gold >= 100 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Stha && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Stra && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dach && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Chea && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == PHea && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Plas && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bto2 && panel.Image == null && Tokens >= 5 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Bto1 && panel.Image == null && Tokens >= 2 ||_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Coin && panel.Image == null)  {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Trep && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Etra && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tepp && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Mboo && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Leve && panel.Image == null)   {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Masd && panel.Image == null && Mana > 0 ||_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Fweg && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Feld && panel.Image == null) {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Brid && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TgaL && panel.Image == null && gold >= 1)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QueB && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QueW && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QueT && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == QuTu && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga3 && panel.Image == null && gold >= 300 || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrBK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == null)      {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == TrPK && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Farr && panel.Image == null)
                {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Che2 && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Fake && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Gold && panel.Image == null || _grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == MaHe && panel.Image == null) {
                    _grid[_column, _row + 1, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                #endregion
                #region End
            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Lmax || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Ende || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Star || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bomb || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Keys || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == OTur || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Schi || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Heal || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Hinw || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gift || _row > 0 && _row == Rowsd-p && _grid[_column, _row , 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Steg || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Lava || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bode || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Dorn || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Kome || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Swor || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Pers)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrSB || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrSA || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrSS || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrKK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrSK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrAK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gass || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Guar || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Tga2 || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Tga1 || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Stha || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Stra)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == GuaK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Dach || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == GuaK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Chea || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == PHea || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Plas || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bto2||_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Bto1 || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Coin)   {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Trep || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Etra || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Tepp || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Fire)  {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Mboo || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Sewe || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Leve )  {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Masd || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Fweg || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Feld)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Brid || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TgaL) {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == QueW || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == QueB || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == QueA || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == QueT || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == QuTu || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Tga3 || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrBK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == WHea)
            {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == TrPK || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Farr)     {
                panel.Image = null;
            }
            else if (_row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Che2 || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Fake || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == Gold || _row > 0 && _row == Rowsd - p && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column, _row - 1, 0] == MaHe)
            {
                panel.Image = null;
            }




            #endregion
            return panel;
        }
        public PictureBox Left(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl, int gold, int Tokens,int Mana)
        {
            bool wait = false;
            #region Fest

         
            if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && Keysss == 0 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && Bombs == 0 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Haus || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Wall || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Wass || _column < 39&& _grid[_column+1, _row, 1] == Player && _grid[_column, _row, 0] == Wald)
            {
                if (_grid[_column, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column , _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Cave || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Ship || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && schleif == 0 )
            {
                if (_grid[_column, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Ofen || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Alta || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Stmk || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Blck || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bank || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto2 && Tokens < 5 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto1 && Tokens < 2 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bush || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Vill || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Cwal || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == ITur ||_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && gold < 2000 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && gold < 100)
            {
                if (_grid[_column, _row, 0] == Tga2 || _grid[_column, _row, 0] == Tga1)
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                if (_grid[_column, _row, 0] == Bto1)
                {
                    MessageBox.Show("Wir lassen dich durch wenn du Blutzahns Männer verprügelst, bring mindestens 2 Zeichen von Blutzahn, wir haben für dich ein einmaliges Angebot");
                }
                if (_grid[_column, _row, 0] == Bto2)
                {
                    MessageBox.Show("Ha du denkst du kannst es mit uns aufnehmen kom wieder mit 5 unserer Zeichen");
                }
                if (_grid[_column, _row, 0] == Blck)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                    MessageBox.Show("Hier geht es nicht weiter");
                }
                if (_grid[_column, _row, 0] == ITur)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                   // MessageBox.Show("Hier geht es nicht weiter");
                }
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Mayo || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == ETur || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bedh||_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bedb || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Mobl)
            {
               
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Gitt || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == LTur)
            {

                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd && Mana == 0 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Muhl || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Pali)
            {
                if (_grid[_column, _row, 0] == Masd)
                {
                    MessageBox.Show("Deine Magische Kraft reicht nicht aus");
                
                }

                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Moun || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Towe|| _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TgaL && gold ==0)  {

                if (_grid[_column, _row, 0] == TgaL)
                {
                    MessageBox.Show("Du brauchst wenigstens eine Münze");

                }
                c--;
            }
            else if (_column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Brun || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QHau || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga3 && gold < 300 || _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Fenc)
            {
                if (_grid[_column, _row, 0] == Tga3 )
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                c--;
            }
            else if ( _column < 39 && _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Fahn)
            {

                c--;
            }
            #endregion
            #region Explore


            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl,wait);
                }
            }
            #endregion
            #region Open

            if (_column > 0 && _column == Columnsd - c - 1 )
            {

                if ( _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null||_grid[_column+1, _row , 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {

                    _grid[_column+1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0 ||_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSB && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSA && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSS && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrAK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Gass && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Guar && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && panel.Image == null && gold >= 2000 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && panel.Image == null && gold >= 100||_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Stha && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Stra && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dach && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Chea && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == PHea && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Plas && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto2 && panel.Image == null && Tokens >= 5||_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto1 && panel.Image == null && Tokens >= 2 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Coin && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Trep && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Etra && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tepp && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Mboo && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Leve && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd && panel.Image == null && Mana > 0 ||_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Fweg && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Feld && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Brid && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TgaL && panel.Image == null && gold >= 1) {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QueW && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QueB && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QueT && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == QuTu && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga3 && panel.Image == null && gold >= 300 || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrBK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == TrPK && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Farr && panel.Image == null)    {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Che2 && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Fake && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Gold && panel.Image == null || _grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == MaHe && panel.Image == null)
                {
                    _grid[_column + 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }

                #endregion
                #region End


            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Lmax || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Ende || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Star || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bomb || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Keys || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == OTur || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Schi || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Heal || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Hinw || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Gift||_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column-1, _row , 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Steg || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Lava || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bode || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Dorn || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Kome || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Swor || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Pers)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrSB || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrSA || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrSS || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrKK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrSK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrAK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Gass || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Guar || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Tga2 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Tga1 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Stha || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Stra)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == GuaK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Dach || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == GuaK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Chea || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == PHea || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Plas || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bto2 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Bto1 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Coin)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Trep || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Etra || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Tepp || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Fire )
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Mboo || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Sewe || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Leve)     {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Masd || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Fweg || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Feld)  {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Brid || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TgaL)  {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == QueW || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == QueB || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == QueA || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == QueT || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == QuTu || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Tga3 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrBK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == WHea)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == TrPK || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Farr)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Che2 || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Fake || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == Gold || _column > 0 && _column == Columnsd - c && _grid[_column, _row, 1] == null && panel.Image == Secret && _grid[_column - 1, _row, 0] == MaHe)      {
                panel.Image = null;
            }




            #endregion
            return panel;
        }
        public PictureBox Right(Panel panMain, PictureBox panel, int _row, int _column, int Rowsd, int Columnsd, int Bombs, int Keysss, int schleif, int lvl, int gold, int Tokens, int Mana)
        {
            bool wait = false;
            #region Fest

           
            if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == VTur && Keysss == 0 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Rock && Bombs == 0 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Haus || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wall || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wass||_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Wald)
            {
                if (_grid[_column+1, _row, 0] == VTur)
                {
                    MessageBox.Show("Du brauchst einen Schlüssel");
                }
                if (_grid[_column + 1, _row, 0] == Rock)
                {
                    MessageBox.Show("Der Weg ist durch einen Felsen Blockiert");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Cave || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Ship || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Dwal && schleif == 0)
            {
                if (_grid[_column + 1, _row, 0] == Dwal)
                {
                    MessageBox.Show("Deine Waffe ist zu Stumpf");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Ofen || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Alta || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Stmk || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Blck || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bank || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bto2 && Tokens < 5 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bto1 && Tokens < 2 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bush || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Vill || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Cwal || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == ITur || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Tga2 && gold < 2000 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Tga1 && gold < 100)  {

                if (_grid[_column + 1, _row, 0] == Tga2 || _grid[_column + 1, _row, 0] == Tga1)
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                if (_grid[_column + 1, _row, 0] == Bto1)
                {
                    MessageBox.Show("Wir lassen dich durch wenn du Blutzahns Männer verprügelst, bring mindestens 2 Zeichen von Blutzahn, wir haben für dich ein einmaliges Angebot");
                }
                if (_grid[_column + 1, _row, 0] == Bto2)
                {
                    MessageBox.Show("Ha du denkst du kannst es mit uns aufnehmen kom wieder mit 5 unserer Zeichen");
                }
                if (_grid[_column + 1, _row, 0] == Blck)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                    MessageBox.Show("Hier geht es nicht weiter");
                }
                if (_grid[_column + 1, _row, 0] == ITur)
                {
                    MessageBox.Show("Die Tür ist Fest Verschlossen");
                    //MessageBox.Show("Hier geht es nicht weiter");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Mayo || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == ETur || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bedh||_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Bedb || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Mobl)  {
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Gitt || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == LTur )     {
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Masd && Mana == 0 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Muhl || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Pali)
            {
                if (_grid[_column + 1, _row, 0] == Masd)
                {
                    MessageBox.Show("Deine Magische Kraft reicht nicht aus");
                    //MessageBox.Show("Hier geht es nicht weiter");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Moun || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == TgaL && gold ==0||_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Towe) {
                if (_grid[_column + 1, _row, 0] == TgaL)
                {
                    MessageBox.Show("Du brauchst mindestens eine Münze");
                    //MessageBox.Show("Hier geht es nicht weiter");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Brun || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == QHau || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Tga3 && gold < 300 || _grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Fenc)
            {
                if (_grid[_column + 1, _row, 0] == Tga3 )
                {
                    MessageBox.Show("Du hast nicht genug Geld um Tribut zu zahlen");
                }
                c++;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column + 1, _row, 0] == Fahn)
            {
                c++;
            }
            #endregion
            #region Explore


            if (_row > 0 && _column > 0 && _row < 39 && _column < 39)
            {

                if (_grid[_column + 1, _row + 1, 1] == Player || _grid[_column - 1, _row + 1, 1] == Player || _grid[_column + 1, _row - 1, 1] == Player || _grid[_column - 1, _row - 1, 1] == Player || _grid[_column, _row - 1, 1] == Player || _grid[_column, _row + 1, 1] == Player || _grid[_column - 1, _row, 1] == Player || _grid[_column, _row, 1] == Player || _grid[_column + 1, _row, 1] == Player)
                {

                    Colors(panel, _row, _column,lvl,wait);
                }
            }
            #endregion
            #region Open

            if (_column > 0 && _column == Columnsd - c + 1 )
            {

                if ( _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Star && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Keys && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == OTur && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur && panel.Image == null && Keysss > 0 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && panel.Image == null && Bombs > 0 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Schi && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Heal && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == null||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gras && panel.Image == null)
                {
                
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Steg && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bode && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal && panel.Image == null && schleif > 0||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Kome && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Swor && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSB && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSA && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSS && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrSK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrAK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gass && panel.Image == null ||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Guar && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && panel.Image == null && gold >= 2000 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && panel.Image == null && gold >= 100||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Stha && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Stra && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dach && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Chea && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == PHea && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Plas && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto2 && panel.Image == null && Tokens >= 5 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Bto1 && panel.Image == null && Tokens >= 2 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Coin && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Trep && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Etra && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tepp && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Mboo && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Leve && panel.Image == null)   {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd && panel.Image == null && Mana > 0 ||_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Fweg || panel.Image == null&&_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Feld && panel.Image == null)
                {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Brid && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TgaL && panel.Image == null && gold >= 1)    {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == QueW && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == QueB && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == QueT && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == QuTu && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga3 && panel.Image == null && gold >= 300 || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrBK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == null)   {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == TrPK && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Farr && panel.Image == null)        {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Che2 && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Fake && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Gold && panel.Image == null || _grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == MaHe && panel.Image == null) {
                    _grid[_column - 1, _row, 1] = null;
                    _grid[_column, _row, 1] = Player;
                    panel.Image = Secret;
                }
                #endregion
                #region End              
            }
            else if (_grid[_column, _row, 1] != Player && panel.Image == Secret || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Lmax || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Ende || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Star || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bomb || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Keys || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == OTur || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Schi || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Heal || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Hinw || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gift||_column > 0 && _column == Columnsd - c && _grid[_column-1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gras)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Steg || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Lava || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bode || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Dorn || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Kome || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Swor || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Pers)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrSB || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrSA || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrSS || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrKK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrSK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrAK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gass || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Guar || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Tga2 || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Tga1 || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Stha || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Stra)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == GuaK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Dach || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == GuaK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Chea || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == PHea || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Plas || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bto2||_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Bto1 || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Coin)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Trep || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Etra || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Tepp || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Fire)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Mboo || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Sewe || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Leve)  {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Masd || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Fweg || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Feld)  {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Brid || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TgaL)
            {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == QueW || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == QueB || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == QueA || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == QueT || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == QuTu || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Tga3 || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrBK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == WHea)    {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == TrPK || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Farr)   {
                panel.Image = null;
            }
            else if (_column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Che2 || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Fake || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Gold || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == MaHe || _column > 0 && _column == Columnsd - c && _grid[_column - 1, _row, 1] == null && panel.Image == Secret && _grid[_column + 1, _row, 0] == Farr)
            {
                panel.Image = null;
            }

            #endregion
            return panel;
        }
        #endregion
        #region Event


        public void Event(Panel panMain, PictureBox panel, int _row, int _column, int lvl)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[24, 19, 1] == Player && panel.Image == Secret&& lvl==4 && count == 1)
            {
                _grid[28, 14, 0] = OTur;
                _grid[28, 23, 0] = OTur;
                MessageBox.Show("Du füllst dich voller Leben(Leben auf Max)");
              
                _grid[_column, _row, 2] = empty.ToString();                
            }
           else if (_grid[28, 11, 1] == Player && panel.Image == Secret && lvl == 5 && count == 1)
            {
             
                _grid[16, 14, 0] = OTur;
                // _grid[28, 23, 0] = OTur;
                panel.BackgroundImage = Hebel2;
                MessageBox.Show("Eine Tür hat sich geöffnet");
                panel.BackColor = Color.PaleTurquoise;
                _grid[_column, _row, 2] = empty.ToString();
                //  panel.BackgroundImage = Giftig;
                //    Life--;
            }
            else if (_grid[5, 5, 1] == Player && panel.Image == Secret && lvl == 5 && count == 1)
            {

                _grid[25, 23, 0] = OTur;
                panel.BackgroundImage = Hebel2;
                // _grid[28, 23, 0] = OTur;
                MessageBox.Show("Eine Tür hat sich geöffnet");
                panel.BackColor = Color.PaleTurquoise;
                _grid[_column, _row, 2] = empty.ToString();
                //  panel.BackgroundImage = Giftig;
                //    Life--;
            }

        }
      
        public Image EventPicture(Panel panMain, PictureBox panel, int _row, int _column, int lvl, PictureBox npc)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[24, 19, 1] == Player && panel.Image == Secret && lvl == 4 && count == 1 )   {
                npc.BackgroundImage = Gov;

            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] != Pers && _grid[_column, _row, 0] != GuaK && panel.Image == Secret)

            {
                npc.BackgroundImage = null;
            }
            return npc.BackgroundImage;
        }
        #endregion
        #region Damage
        public int  Poison(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player&& _grid[_column, _row, 0] == Gift  && panel.Image == Secret)
            {

                panel.BackColor = Color.Purple;
                panel.BackgroundImage = Giftig;
                Life--;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == Secret)
            {
               
                Life--;
            }
            return Life;
        }
        public int Dorne(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Dorn && panel.Image == Secret)
            {

                panel.BackColor = Color.ForestGreen;
                panel.BackgroundImage = null;
                Life--;
            }
            return Life;
        }
        public int Lavama(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Lava && panel.Image == Secret)
            {

                panel.BackColor = Color.IndianRed;
                panel.BackgroundImage = Lavas;
    
                Life = Life - 2;
            }
            return Life;
        }
        public int Electro(Panel panMain, PictureBox panel, int _row, int _column, int Life, int Armor)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Etra && panel.Image == Secret)
            {
                if (Armor > 0)
                {
                    Life = Life - 2;
                }
                else
                {
                }

            }
            return Life;
        }
        public int FireL(Panel panMain, PictureBox panel, int _row, int _column, int Life)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == Secret)
            {

                Life = Life - 1;
            }
            return Life;
        }
        public int FireA(Panel panMain, PictureBox panel, int _row, int _column, int Armor)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Fire && panel.Image == Secret)
            {           
                Armor = Armor - 1;
            }
            return Armor;
        }


        public int PoisonSchie(Panel panMain, PictureBox panel, int _row, int _column, int Armor)
        {
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Gift && panel.Image == Secret)
            {
                panel.BackColor = Color.Purple;
                panel.BackgroundImage = Giftig;            
                Armor--;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Sewe && panel.Image == Secret)
            {
               
                Armor--;
            }
            return Armor;
        }
        #endregion
        #region Visuel

   
        public Image Npc(Panel panMain, PictureBox panel, int _row, int _column ,PictureBox npc, int lvl)
        {
          //  var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && panel.Image == Secret||_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == Secret)
            {
                npc.BackgroundImage = panel.BackgroundImage;

            }
            else if (_grid[24, 19, 1] == Player && panel.Image == Secret && lvl == 4)
            {
                npc.BackgroundImage = Gov;

              
            }
            else if (_grid[_column, _row, 1] == Player && panel.Image == Secret && lvl == 3&& _column==33&& _row>2 && _row < 11)
            {
                npc.BackgroundImage = Altar;
            }
            else if (_grid[17, 21, 1] == Player && panel.Image == Secret && lvl == 3)
            {
                npc.BackgroundImage = Oven;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] != Pers &&  _grid[_column, _row, 0] != GuaK && panel.Image == Secret)
         
            {
                npc.BackgroundImage = null;
            }
            return npc.BackgroundImage;
        }

        #endregion
        #region Health and Mana

       
        int healss = 0;
        public int Heals(Panel panMain, PictureBox panel, int _row, int _column, int Life, int MaxLife)
        {
            
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Heal&& healss==0 && panel.Image == Secret)
            {
                healss++;
                DialogResult dialogResult = MessageBox.Show("Du hast eine Ruhige Lichtung gefunden, willst du Rasten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du füllst dich voller Leben(Leben auf Max)");
                    panel.BackColor = Color.LightPink;
                    panel.BackgroundImage = Healspot;
                    Life = MaxLife;
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.LightPink;
                    panel.BackgroundImage = Healspot;
                }
              
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Heal && healss == 1)
            {
                healss--;
            }
           
            return Life;
        }
        public bool Paheal(Panel panMain, PictureBox panel, int _row, int _column, bool Heal)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == PHea && panel.Image == Secret && count == 1 )
            {
                DialogResult dialogResult = MessageBox.Show("Der Priester bietet dir dich für 100 Gold zu heilen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                        MessageBox.Show("Du fühlst dich voller Leben(-100 zu Gold aber Leben auf Max))");
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    Heal = true;

                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    Heal = false;
                }


            }




            return Heal;
        }
        public bool Wirtheal(Panel panMain, PictureBox panel, int _row, int _column, bool Heal)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Du kannst für 300 Gold im Gasthaus Rasten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    MessageBox.Show("Du fühlst dich voller Leben(-300 zu Gold aber Leben auf Max))");
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    Heal = true;

                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    Heal = false;
                }


            }

            return Heal;
        }
        public bool Manaheal(Panel panMain, PictureBox panel, int _row, int _column, bool Mana)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == WHea && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Willst du den Mana Brunnen für 3000 Gold Benützen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    MessageBox.Show("Dein Geist fühlt sich erfrischt(-3000 zu Gold aber Mana auf Max))");
                    panel.BackColor = Color.MediumTurquoise;
                    panel.BackgroundImage = null;
                    Mana = true;

                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.MediumTurquoise;
                    panel.BackgroundImage = null;
                    Mana = false;
                }


            }

            return Mana;
        }
        public int Potions(Panel panMain, PictureBox panel, int _row, int _column, int Potionn)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == Potion && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Rucksack mit Heiltränke gefunden, willst du sie Looten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst ein paar Heiltränke(+3 zu Heiltränke))");

                    // panel.BackColor = Color.Orange;

                    Potionn = Potionn + 3;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }


            }
            return Potionn;
        }

        public int MaxLife(Panel panMain, PictureBox panel, int _row, int _column, int Max)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Lmax && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du findest Ambrosia, möchtest du davon essen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du fühlst dich voller Leben(Max Leben +1))");

                    //    panel.BackColor = Color.Orange;

                    Max = Max + 1;
                    panel.BackColor = Color.PaleVioletRed;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //panel.BackColor = Color.Orange;
                }


            }
            return Max;
        }
        #endregion
        #region Cheats

        public static int Cheatnumber;
        public bool Cheats(Panel panMain, PictureBox panel, int _row, int _column, bool cheats)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Chea && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Letzte Warnung du wirst viel Verlieren falls du cheatest", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    MessageBox.Show("Cheater!!!!!!!!(+500 Gold, Max Leben = 3, Armor =0, Schleifsteine =0, Bomben= 0))");
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    cheats = true;
                    Cheatnumber = 1;

                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    cheats = false;
                    Cheatnumber = 0;
                }


            }
       else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Che2 && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Wow du hast das DevFeld gefunden glückwünsch", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    MessageBox.Show("Schau mal auf deine Stats");
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    cheats = true;
                    Cheatnumber = 2;

                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Red;
                    panel.BackgroundImage = null;
                    cheats = false;
                    Cheatnumber = 0;
                }


            }




            return cheats;
        }
        #endregion
        #region Items



        public int Schield(Panel panMain, PictureBox panel, int _row, int _column, int Armor)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Schi&& count==1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Kiste mit Handwerksmaterialen gefunden, willst du deine Rüstung damit verstärken", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du verstärkst deine Rüstung(+1 zu Armor))");
                   
                    panel.BackColor = Color.Orange;
                    panel.BackgroundImage = null;

                    Armor = Armor + count;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Orange;
                    panel.BackgroundImage = Truhe;
                }
             
                
            }
            return Armor;
        }
        public int Magic(Panel panMain, PictureBox panel, int _row, int _column, int Spellpower)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Mboo && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Glühendes Buch gefunden gefunden, willst du es Untersuchen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du Seele fühlt sich stärker an (+1 zu Max Mana))");

                    panel.BackColor = Color.Teal;
                    panel.BackgroundImage = null;

                    Spellpower = Spellpower + count;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Teal;
                    panel.BackgroundImage = null;
                }


            }
            return Spellpower;
        }
        public int Schliefff(Panel panMain, PictureBox panel, int _row, int _column, int schleiffs)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Swor && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast einen Schleifstein gefunden, willst du ihn mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst einen Schleifstein(+1 zu Schleifsteine))");

                    schleiffs = schleiffs + count;
                    panel.BackColor = Color.Orchid;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.Orchid;
                    panel.BackgroundImage = SackmitSchleifstein;
                }


            }

            return schleiffs;
        }
        public int Bomm(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Bomb && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine nicht gezündete Bombe gefunden, willst du sie mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst eine Bombe(+1 zu Bomb))");

                    panel.BackColor = Color.OrangeRed;
                    panel.BackgroundImage = null;
                    Bombs = Bombs + count;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.OrangeRed;
                    panel.BackgroundImage = Bombe;
                }


            }
         
            return Bombs;
        }
       
        public int Keyss(Panel panMain, PictureBox panel, int _row, int _column, int Key)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Keys && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Tasche mit einem Schlüssel gefunden, willst du ihn mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst einen Schlüssek(+1 zu Keys))");

                    Key = Key + count;
                    panel.BackColor = Color.DarkGoldenrod;
                    panel.BackgroundImage = null;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    panel.BackColor = Color.DarkGoldenrod;
                    panel.BackgroundImage = null;
                }


            }
           
            return Key;
        }
        #endregion
        #region Tribut    
        public int goldTri1(Panel panMain, PictureBox panel, int _row, int _column, int Gold)
        {
            if (_row > 0)
            {
                if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && Gold >= 100 && panel.Image == Secret)
                {
                    Gold = Gold - 100;
                }
                else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && Gold >= 2000 && panel.Image == Secret)
                {
                    Gold = Gold - 2000;
                }
                else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TgaL && Gold >= 1 && panel.Image == Secret)
                {
                    Gold =0;
                }
            }
            return Gold;
        }
        #endregion
        #region Talking


        string tip;
        public string hinww(Panel panMain, PictureBox panel, int _row, int _column,int Level)
        {         
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            #region Level 1


            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 1)
            {
                if (_row == 38 && _column == 2 && count == 1)
                {
                    MessageBox.Show("Weiter gehen nur auf eigene Gefahr");
                    tip = "Weiter gehen nur auf eigene Gefahr";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 2 && _column == 2 && count == 1 || _row == 3 && _column == 2 && count == 1)
                {
                    MessageBox.Show("2 ist der Sicherste Weg");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "2 ist der Sicherste Weg";
                }
                else if (_row == 19 && _column == 19 && count == 1)
                {
                    MessageBox.Show("Geh Kurz aber nicht zu Lang, das Ende wartet am falschen Weg.");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Geh Kurz aber nicht zu Lang, das Ende wartet am falschen Weg.";
                }
                else if (_row == 12 && _column == 13 && count == 1 || _row == 13 && _column == 13 && count == 1 || _row == 14 && _column == 13 && count == 1)
                {
                    MessageBox.Show("Der Letzte der kommt steht im Mittelpunkt, er geht daher ihnen aus dem Weg.");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Der Letzte der kommt steht im Mittelpunkt, er geht daher ihnen aus dem Weg.";
                }
                else if (_row == 1 && _column == 22 && count == 1)
                {
                    MessageBox.Show("Je schneller desto gefährlicher");
                    _grid[_column, _row, 2] = empty.ToString();
                    tip = "Je schneller desto gefährlicher";
                }


            }
            #endregion
            #region Level 2


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 2)
            {
                if (_row == 34 && _column == 2 && count == 1)
                {
                    MessageBox.Show("Erinnerung Dornen Büsche kannst du zwar sehen, bei durchqueren greiffen sie Leben direkt an");
                    tip = "Erinnerung Dornen Büsche kannst du zwar sehen, bei durchqueren greiffen sie Leben direkt an";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 29 && _column == 14 && count == 1)
                {
                    MessageBox.Show("Mit Schleifsteine kannst du deine Waffe genug Schärfen um Pflanzliche Blockaden zu zerstören");
                    tip = "Mit Schleifsteine kannst du deine Waffe genug Schärfen um Pflanzliche Blockaden zu zerstören";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 32 && count == 1 || _row == 32 && _column == 32 && count == 1)
                {
                    MessageBox.Show("Lava dieses Vulkanes verursacht den Zweifachen schaden am Leben, Also verlierst du 2 Leben pro Feld das du überquerst ");
                    tip = "Lava dieses Vulkanes verursacht den Zweifachen schaden am Leben, Also verlierst du 2 Leben pro Feld das du überquerst";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 21 && _column == 35 && count == 1)
                {
                    MessageBox.Show("Vetraue nicht darauf das sich ein Weg Lohnt auch wenn es Beute gibt. Suche am besten Alternativen ");
                    tip = "Vetraue nicht darauf das sich ein Weg Lohnt auch wenn es Beute gibt. Suche am besten Alternativen ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 23 && _column == 3 && count == 1)
                {
                    MessageBox.Show("Erkunden lohnt sich ");
                    tip = "Erkunden lohnt sich";
                    _grid[_column, _row, 2] = empty.ToString();
                }


            }
            #endregion
            #region Level 3


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 3)
            {
                if (_row == 31 && _column == 4 && count == 1)
                {
                    MessageBox.Show("Willkomen in der Stadt, einzige gefahr sind Banditen, diese wehrt man mit einen  Schleifstein und Rüstungsdicke ab, dafür gibts Gold und Banditen Abzeichen");
                    tip = "Willkomen in der Stadt, einzige gefahr sind Banditen, die Wehrt man mit einen Schleifstein und Rüstungsdicke ab,dafür gibts Gold und Banditen Abzeichen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 23 && _column == 14 && count == 1)
                {
                    MessageBox.Show("Das Stadttor verlangt beim durchgehen jedes mal 100 Gold als Tribut");
                    tip = "Das Stadttor verlangt beim durchgehen jedes mal 100 Gold als Tribut";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 17 && count == 1)
                {
                    MessageBox.Show("Dieses Tor verlangt einen Tribut von 2000 Gold, du kannst falls du das Level mit 2100 Gold betritts es in prinzip überspringen, ich empfehle es nicht. Geh erst durch Wenn du absolut bereit bist");
                    tip = "Dieses Tor verlangt einen Tribut von 2000 Gold, du kannst falls du das Level mit 2100 Gold betritts es in prinzip überspringen, ich empfehle es nicht. Geh erst durch Wenn du absolut bereit bist";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 21 && _column == 35 && count == 1)
                {
                    MessageBox.Show("Hoffentlich bist du bereit, es gibt keine Händler für ne Weile");
                    tip = "Hoffentlich bist du bereit, es gibt keine Händler für ne Weile ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 5 && _column == 38 && count == 1 || _row == 5 && _column == 38 && count == 1)
                {
                    MessageBox.Show("Du verlierst sehr viel wenn du hier weiter gehst ");
                    tip = "Du verlierst sehr viel wenn du hier weiter gehst";
                    _grid[_column, _row, 2] = empty.ToString();
                }


            }
            #endregion
            #region Level 4


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 4)
            {
                if (_row == 2 && _column == 4 && count == 1)
                {
                    MessageBox.Show("Wenn du zufrieden bist mit was du gelootetst hat dann geh weiter zum Ende");
                    tip = "Wenn du zufrieden bist mit was du gelootetst hat dann geh weiter zum Ende";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 10 && _column == 9 && count == 1)
                {
                    MessageBox.Show("Das ist das Wache Schlafzimmer, hier giebt es Wachen und Loot");
                    tip = "Das ist das Wache Schlafzimmer, hier giebt es Wachen und Loot";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 12 && _column == 13 && count == 1)
                {
                    MessageBox.Show("S.2, Ps Feuer veruhrsacht 1 Leben Schaden, mit Rüstung 1 Leben und 1 Rüstung");
                    tip = "S.2, Ps Feuer veruhrsacht 1 Leben Schaden, mit Rüstung 1 Leben und 1 Rüstung";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 15 && count == 1)
                {
                    MessageBox.Show("Electro Fallen sind ungefährlich solange du keine Rüstung Trägst, sonst Leben-2 jedes mal");
                    tip = "Electro Fallen sind ungefährlich solange du keine Rüstung Trägst, sonst Leben-2 jedes mal ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 15 && _column == 28 && count == 1 || _row == 22 && _column == 28 && count == 1)
                {
                    MessageBox.Show("Du musst den Baron zuerst besuchen");
                    tip = "Du musst den Baron zuerst besuchen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 23 && count == 1 || _row == 26 && _column == 23 && count == 1)
                {
                    MessageBox.Show("Die neuen Schaden Felder sind Elektro und Feuer");
                    tip = "Die neuen Schaden Felder sind Elektro und Feuer";
                    _grid[_column, _row, 2] = empty.ToString();
                }


            }
            #endregion
            #region Level 5


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 5)
            {
                if (_row == 3 && _column == 9 && count == 1)
                {
                    MessageBox.Show("Gift ist Wieder da :D, neben Gift erwartet die Kanalisations Wasser, es besitzt denn gleichen effekt wie Gift, ist jedoch sichtbar");
                    tip = "Gift ist Wieder da (:D), neben Gift erwartet die Kanalisations Wasser, es besitzt denn gleichen effekt wie Gift, ist jedoch sichtbar";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 25 && _column == 8 && count == 1)
                {
                    MessageBox.Show("Voraus ist sehr viel Tod falls du den Falschen Weg gehst, deal with it!!");
                    tip = "Voraus ist sehr viel Tod falls du den Falschen Weg gehst, deal with it!!";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 38 && _column == 12 && count == 1)
                {
                    MessageBox.Show("Eine Ratte Greift dich an.");
                    MessageBox.Show("Ich meine Drache");
                    MessageBox.Show("Du bist Tod");
                    MessageBox.Show("Ne hier passiert einfach nichts. ");
                    tip = "HHHHHHHHHHHHHHHOOOOOOOOOOOOOOOOOOIIIIIIIIIIIIIIIIIIIIDDDDDDDDDDDDDDDDD";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 9 && _column == 21 && count == 1 || _row == 10 && _column == 20 && count == 1)
                {
                    MessageBox.Show("Ein Kraftiger Mann(Namens Jojo) verlangt beim durchgehen jedes mal 100 Gold als Tribut");
                    tip = "Ein Kraftiger Mann(Namens Jojo) verlangt beim durchgehen jedes mal 100 Gold als Tribut";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 26 && count == 1)
                {
                    MessageBox.Show("Für wie viel Gold würdest du Sterben, bei keinem Interesse geh komplet runter dann rechts dann wieder hinauf.");
                    tip = "Für wie viel Gold würdest du Sterben, bei keinem Interesse geh komplet runter dann rechts dann wieder hinauf.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 9 && _column == 29 && count == 1)
                {
                    MessageBox.Show("Ein Hebel öffnet Türen, schon gewusst?");
                    MessageBox.Show("Darum heisst ja Türhebel");
                    MessageBox.Show("Ich geh dann mal");
                    MessageBox.Show("Türe zu.");
                    tip = "Tür Joke";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 35 && _column == 34 && count == 1)
                {
                    MessageBox.Show("Fühlst du dich schon wie eine Ratte in der Kanalisation, fall ja Freu dich, jetzt kommt ein kleines Labyrinth, sei froh das ich hinter dir keine Tür schliesse");
                    tip = "Fühlst du dich schon wie eine Ratte in der Kanalisation, fall ja Freu dich, jetzt kommt ein kleines Labyrinth, sei froh das ich hinter dir keine Tür schliesse";
                    _grid[_column, _row, 2] = empty.ToString();
                }


            }
            #endregion
            #region Level 7
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 7)
            {
                if (_row == 3 && _column == 31 && count == 1 || _row == 3 && _column == 29 && count == 1)
                {
                    MessageBox.Show("Warnung gehst du weiter in die gleiche Richtung dann verlierst du all dein Geld. ALLLES!!!");
                    tip = "Warnung gehst du weiter in die gleiche Richtung dann verlierst du all dein Geld. ALLLES!!!";
                    _grid[_column, _row, 2] = empty.ToString();
                }
            }
            #endregion
            #region Level 8
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 8)
            {
                if (_row == 37 && _column == 14 && count == 1 || _row == 36 && _column == 14 && count == 1 || _row == 35 && _column == 14 && count == 1)
                {
                    MessageBox.Show("Hier geht es Weiter zur Stadt. Dieses Level is sehr offen. Du kannst es direkt beenden oder deine Geld menge erhöhen oder Rüstung, Bomben und Schleifsteine Kaufen");
                    tip = "Hier geht es Weiter zur Stadt. Dieses Level is sehr offen. Du kannst es direkt beenden oder deine Geld menge erhöhen oder Rüstung, Bomben und Schleifsteine Kaufen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 26 && _column == 5 && count == 1 )
                {
                    MessageBox.Show("Dieser Weg führt in den Wald, warnung. Unvorbereitet kann er gefährlich sein.");
                    tip = "Dieser Weg führt in den Wald, warnung. Unvorbereitet kann er gefährlich sein.";
                    _grid[_column, _row, 2] = empty.ToString();
                 
                }
                else if (_row == 35 && _column == 21 && count == 1)
                {
                    MessageBox.Show("Dies ist mein erster versuch an einer Abenteurer Gilde. Es gibt ein paar Aufträge für Geldbelohnungen");
               
                    tip = "Dies ist mein erster versuch an einer Abenteurer Gilde. Es gibt ein paar Aufträge für Geldbelohnungen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 35 && _column == 21 && count == 1)
                {
                    MessageBox.Show("Dies ist mein erster versuch an einer Abenteurer Gilde. Es gibt ein paar Aufträge für Geldbelohnungen");

                    tip = "Dies ist mein erster versuch an einer Abenteurer Gilde. Es gibt ein paar Aufträge für Geldbelohnungen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 26 && _column == 25 && count == 1)
                {
                    MessageBox.Show("Zur orientierung im Norden ist die Kirche, im Süde das Gasthaus mit dem Ende des Levels.");

                    tip = "Dies ist mein erster versuch an einer Abenteurer Gilde. Es gibt ein paar Aufträge für Geldbelohnungen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 35 && _column == 35 && count == 1)
                {
                    MessageBox.Show("Hier geht es Weiter zum Ende des Level, sei dir sicher das alles hast bevor du gehst.");

                    tip = "Hier geht es Weiter zum Ende des Level, sei dir sicher das alles hast bevor du gehst.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 7 && _column == 36 && count == 1)
                {
                    MessageBox.Show("Ich empfehle dir den Auftrag des Adeligen zu machen.");

                    tip = "Ich empfehle dir den Auftrag des Adeligen zu machen.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 22 && count == 1 || _row == 15 && _column == 22 && count == 1)
                {
                    MessageBox.Show("Warnung der Wächter verlangt 300 Gold Tribut per durchgang");

                    tip = "Warnung der Wächter verlangt 300 Gold Tribut per durchgang";
                    _grid[_column, _row, 2] = empty.ToString();
                }



            }
            #endregion
            #region Level 9
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 9)
            {
                if (_row == 37 && _column == 7 && count == 1 )
                {
                    MessageBox.Show("Warnung Behemoth Fight, falls du nicht Genug Mana oder Leben hast, dann stirbst du sehr wahrscheinlich.");
                    tip = "Warnung Behemoth Fight, falls du nicht Genug Mana oder Leben hast, dann stirbst du sehr wahrscheinlich.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
            }
            #endregion
            #region Level 10
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Hinw && Level == 10)
            {
                if (_row == 10 && _column == 34 && count == 1)
                {
                    MessageBox.Show("Befor du die Höhlen betrittst noch einen Kleinen Hinweis. Ich habe Challanges aufgestellt. Fünf Bosse Warten auf dich. Ich sage es dir direcht jetzt. Kauf dir was du kannst bei den Vier Zwergenhändler ein wenig weiter im Berg, falls du Mana brauchst, es gibt einen Manaheal Spot in der Elfenstadt im Süden. Mach die Challenges nur wenn du dich sicher fühlst. Du hast nur 4 Versuche(Jetztiges Leben + 3 Mal Respaqn), es handelt sich nicht um Normale Kämpfe. Bei einigen sind Item Relevant bei anderen nicht, besonders wichtig sind Bomben und Mana. Verstanden Gut.");
                    tip = "Befor du die Höhlen betrittst noch einen Kleinen Hinweis. Ich habe Challanges aufgestellt. Fünf Bosse Warten auf dich. Ich sage es dir direcht jetzt. Kauf dir was du kannst bei den Vier Zwergenhändler ein wenig weiter im Berg, falls du Mana brauchst, es gibt einen Manaheal Spot in der Elfenstadt im Süden. Mach die Challenges nur wenn du dich sicher fühlst. Du hast nur 4 Versuche(Jetztiges Leben + 3 Mal Respaqn), es handelt sich nicht um Normale Kämpfe. Bei einigen sind Item Relevant bei anderen nicht, besonders wichtig sind Bomben und Mana. Verstanden Gut.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
               else if (_row == 18 && _column == 24 && count == 1)
                {
                    MessageBox.Show("Letzte Warnung. Es gibt ausserdem Gift auf dem Weg.");
                    tip = "Letzte Warnung. Es gibt ausserdem Gift auf dem Weg.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
            }
            #endregion
            return tip;
        }
        string Dialog;
        public string Person(Panel panMain, PictureBox panel, int _row, int _column, int Level)
        {

            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            #region Level 2

          
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 2)
            {
                if (_row == 21 && _column == 13 && count == 1)
                {

                    Dialog = "Was!? Du suchst den Weg zur Leopold, dann musst du den Wald durchqueren und danach einen Weg durch den Vulkan finden.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 7 && count == 1 || _row == 8 && _column == 10 && count == 1 || _row == 5 && _column == 10 && count == 1)
                {
                    Dialog = "Mache bloss keine Probleme, Verstanden!!";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 8 && _column == 8 && count == 1)
                {

                    Dialog = "Nein wir haben keinen öffentlichen Hafen, der einzige Weg für dich, von hier weg zu kommen ist mit dem Schmugglerschiff, die Leopold.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 7 && _column == 6 && count == 1)
                {

                    Dialog = "Gepriesen sei die Heilige Castrosa";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 10 && _column == 3 && count == 1)
                {

                    Dialog = "Hey!!! Ich schenk dir einer von meinen Schleifsteine für auf den Weg. Er sollte irgendwo in der Umgebung sein.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 5 && count == 1)
                {

                    Dialog = "Nicht jeder kommt aus dem Nordwald wieder heraus, es gibt sehr viele giftige Sumpfgewässer die man kaum sieht.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 20 && _column == 27 && count == 1)
                {

                    Dialog = "Wow!! Nicht jeder kommt durch denn Vulkan, weiss du was ich bin heute Grosszügig, deine überfahrt kostet heute nichts.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 22 && count == 1)
                {

                    Dialog = "Der Chef spediert dir also die Reise? Dass heisst aber noch lang nicht das zu faulenzen kannst, du hilft bei der Fahrt bis zu deinem Ziel";

                    _grid[_column, _row, 2] = empty.ToString();
                }


                Kommen = Dialog;
            }
            #endregion
            #region Level 3

           
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 3)
            {
                if (_row == 29 && _column == 2 && count == 1)
                {

                    Dialog = "So da währen wir, Longcester, viel glück auf deine Weitere Reise";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 33 && _column == 3 && count == 1)
                {
                    Dialog = "Hey du da!! Ja du. Ich hab nen Auftrag bekommen dir zu Melden das der Baron dich sehen will.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 30 && _column == 11 && count == 1)
                {

                    Dialog = "Man bin ich erschöft, die Ladung die wir mit dem Letzten Handelsschiff bekommen haben war Riesig.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 2 && _column == 33 && count == 1)
                {

                    Dialog = "Gepriesen sei die Heilige Castrosa";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 9 && count == 1)
                {

                    Dialog = "ugh wasss mach iccch hiic... hier. Hic Ich war doch gerade noch in der Bar hic....zzzzzzzzzzzz";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 18 && _column == 12 && count == 1)
                {

                    Dialog = "Dass isch doch d Leopold, wart maul is ds ni es Schmuggelschiff. Weiss was eigntlich is mir egal";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 24 && _column == 16 && count == 1)
                {

                    Dialog = "Hey du da!! Ich kenn deine Sorte, wenn du keinen ärger sucht dann geh nicht in die Gassen, aber du wirst mich wahrscheinlich ignorieren oder?";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 24 && _column == 14 && count == 1 || _row == 22 && _column == 14 && count == 1)
                {

                    Dialog = "Willkomen in Longchester, Eintritt beträgt 100 Gold Stücke.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 20 && _column == 18 && count == 1)
                {
                 
                      Dialog = "Willkomen. Willkomen intressiert an Material um deine Rüstung zu verstärken, nur 250 Gold per Stück";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 20 && _column == 24 && count == 1)
                {

                    Dialog = "Ist dein Waffe Stumpf, dann Kauf dir bei Scharpstone Industries für nur 200 Gold per Stück, Schleifsteine";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 17 && count == 1)
                {

                    Dialog = "Brauchst du Gold, trägst du zuviel Material für deine Rüstung herum dann komm zu mir ich Kauf dir sie ab für 150 per Stück";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 20 && count == 1)
                {

                    Dialog = "Wer braucht schon Schleifsteine, die Antwort überrascht euch wahrscheinlich, ich brauche sie!!! Ich kaufe sie euch ab für 100 Gold per Stück";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 23 && count == 1)
                {

                    Dialog = "Hast du Angst Bomben zu transportiern, dann gib sie mir, Minen brauchen sie, Ich geb sie ihnen!! Euch gebe ich 200 Gold per Bombe";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 28 && count == 1 || _row == 36 && _column == 26 && count == 1)
                {

                    Dialog = "Tut uns leid, die Zugbrück in die Unterstadt ist Beschädigt, komm Später wieder";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 27 && count == 1)
                {

                    Dialog = "Herrjemine wie soll ich denn nach Hause kommen, wenn die Brücke beschädigt ist.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 21 && _column == 26 && count == 1)
                {

                    Dialog = "Hmm ich sollt woll langsam nach Hause gehen, es wird langsam Spät.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 9 && _column == 21 && count == 1)
                {

                    Dialog = "Hey wo ist mein Geld Beutel, dass kann nicht sein ich hab 1400 Gold verloren. Mein ganzes Vermögen!!  :(";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 11 && _column == 28 && count == 1)
                {

                    Dialog = "Jemand sollte endlich mal die Blutzahn Banditen aus der Oberstadt vertreiben, wieso erlauben die Wachen, dass die hier herum wüten";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 28 && count == 1)
                {

                    Dialog = "Jeder weiss wo die Blutzahn Banditen leben. Weshalb wird nichts gemacht?";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 7 && _column == 24 && count == 1)
                {

                    Dialog = "Ah da bist du ja, hör zu ich habe einen Schlüssel für das Lagerhaus im Hafen, ich gib ihn dir wenn du 1000Gold gibts.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 19 && _column == 34 && count == 1 || _row == 19 && _column == 32 && count == 1)
                {

                    Dialog = "Stell bloss keinen Ärger an auf dem Heiligen Boden von Castrosa";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 16 && _column == 30 && count == 1)
                {

                    Dialog = "Oh heilige Castrosa, vergib mir für all die Bäume die ich gefällt habe.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 36 && count == 1 || _row == 16 && _column == 36 && count == 1)
                {

                    Dialog = "Es ist so ein schöner Abend nicht wahr Schatz";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 3 && _column == 17 && count == 1 || _row == 5 && _column == 17 && count == 1)
                {

                    Dialog = "Stell bloss keinen Ärger an!! Verstanden!!";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 3 && _column == 11 && count == 1 || _row == 5 && _column == 11 && count == 1)
                {

                    Dialog = "Sie werden erwartet, treten sie ein.";

                    _grid[_column, _row, 2] = empty.ToString();
                }


                Kommen = Dialog;
            }
            #endregion
            #region Level 4

         
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 4)
            {
                if (_row > 14 && count == 1)
                {

                    Dialog = "Gehen sie in das Büro des Baron, er erwartet sie";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row > 4 && _row < 14 && count == 1)
                {
                    Dialog = "Hey du hast hier nichts zu suchen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 35 && count == 1)
                {

                    Dialog = "Werter Herr sie haben nichts in der Garrison zu suchen, gehen sie endlich zum Baron.";

                    _grid[_column, _row, 2] = empty.ToString();
                }




                Kommen = Dialog;
            }
             if (_grid[24, 19, 1] == Player && panel.Image == Secret && Level == 4 && count == 1)
            {

                Dialog = "So sehen wir uns also wieder, [Spieler] ich dachte ich hätte dich eliminiert, du wirst nie der Erbe des Thrones werden. Versuch nicht mal zu fliehen ich habe schon die ganze Stadtwache benachrichtig. Und gerade in diesen moment geht einer meiner Boten zu Granitos, selbst wenn du enkommst so wird er dich Jagen, so es ist Zeit für dich zum Sterben! Wachen!!!!";
                _grid[32, 17, 0] = Tepp;
                _grid[32, 20, 0] = Tepp;

                _grid[33, 22, 0] = Bode;
                _grid[35, 22, 0] = Bode;

                _grid[33, 15, 0] = Bode;
                _grid[35, 15, 0] = Bode;

                _grid[37, 17, 0] = Bode;
                _grid[37, 20, 0] = Bode;

                _grid[34, 5, 0] = Bode;
                _grid[34, 6, 0] = Bode;
                _grid[34, 7, 0] = Bode;
                _grid[34, 8, 0] = Bode;
                _grid[34, 9, 0] = Bode;
                _grid[34, 10, 0] = Bode;

                _grid[36, 5, 0] = Bode;
                _grid[36, 6, 0] = Bode;
                _grid[36, 7, 0] = Bode;
                _grid[36, 8, 0] = Bode;
                _grid[36, 9, 0] = Bode;
                _grid[36, 10, 0] = Bode;

                _grid[35, 4, 0] = Bode;

                _grid[_column, _row, 2] = empty.ToString();
                _grid[28, 14, 0] = OTur;
                _grid[28, 23, 0] = OTur;
                _grid[28, 15, 2] = empty.ToString();
                _grid[28, 22, 2] = empty.ToString();

                _grid[4, 15, 2] = Loot.ToString(); _grid[4, 15, 4] = Guar;
                    _grid[17, 24, 2] = Loot.ToString(); _grid[17, 24, 4] = Guar;
                    _grid[37, 4, 2] = Loot.ToString();_grid[37, 4, 4] = Guar;
                    _grid[12, 3, 2] = Loot.ToString(); _grid[12, 3, 4] = Guar;
                    _grid[19, 22, 2] = Loot.ToString();_grid[19, 22, 4] = Guar;
                    _grid[10, 36, 2] = Loot.ToString(); _grid[10, 36, 4] = Guar;
                    _grid[8, 12, 2] = Loot.ToString(); _grid[8, 12, 4] = Guar;
                    _grid[2, 7, 2] = Loot.ToString();_grid[2, 7, 4] = Guar;
                    _grid[31, 22, 2] = Loot.ToString(); _grid[31, 22, 4] = Guar;
                    _grid[30, 7, 2] = Loot.ToString();  _grid[30, 7, 4] = Guar;
                    _grid[16, 14, 2] = Loot.ToString(); _grid[16, 14, 4] = Guar;
                    _grid[38, 18, 2] = Loot.ToString(); _grid[38, 18, 4] = Guar;
                    _grid[30, 33, 2] = Loot.ToString();_grid[30, 33, 4] = Guar;
                    _grid[26, 33, 2] = Loot.ToString(); _grid[26, 33, 4] = Guar;
                    _grid[21, 4, 2] = Loot.ToString(); _grid[21, 4, 4] = Guar;
                    _grid[31, 25, 2] = Loot.ToString();_grid[31, 25, 4] = Guar;
                    _grid[29, 15, 2] = Loot.ToString(); _grid[29, 15, 4] = Guar;
                    _grid[34, 16, 2] = Loot.ToString();  _grid[34, 16, 4] = Guar;
                    _grid[25, 15, 2] = Loot.ToString(); _grid[25, 15, 4] = Guar;               
                    _grid[18, 8, 2] = Loot.ToString(); _grid[18, 8, 4] = GuaK;

                Kommen = Dialog;
            }
            #endregion
            #region Level 5

      
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 5)
            {
                if (_row == 9 && _column == 11 && count == 1)
                {

                    Dialog = "Falls du geschwächt bist, dann kannst du dich auf meinem Bett ausruhen";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 5 && _column == 18 && count == 1)
                {
                    Dialog = "Hast du ein wenig Kleingeld";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 18 && count == 1)
                {

                    Dialog = "Er hat als er noch Gold hatte ein Theater mehrmals besucht, es hiess südlicher Park";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 18 && _column == 20 && count == 1)
                {

                    Dialog = "Verdammt wo ist mein Gold, in der Stadt war es nicht";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 2 && _column == 24 && count == 1)
                {

                    Dialog = "Du kommst nicht von hier oder, TYPEN WIR IHR SEID DER GRUND DAS WIR KEINE JOBS FINDEN!!!!";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 24 && count == 1)
                {

                    Dialog = "Trink bloss nicht von dem Wasser, nimm Mein Wasser, Ein Flasche mit Wasser für ein Gold Stück. Ihr findet kein besseres Wasser";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 11 && _column == 24 && count == 1)
                {

                    Dialog = "Hey ich habe ein Geniales Angebot, Kauf einen Schleifstein, ich nur 200 Gold, ist doch Billg !";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 10 && _column == 18 && count == 1)
                {

                    Dialog = "Kauf meine Legalen Teile für deine Rüstung nur 250 gold per Stück";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 18 && count == 1)
                {

                    Dialog = "Verdammte Goblin, nicht mal hier ist man sicher.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 16 && _column == 18 && count == 1)
                {

                    Dialog = "Ich habe Gerüchte gehört das der Baron für die Goblin verantwortlich ist";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 19 && _column == 23 && count == 1)
                {

                    Dialog = "Man sagt der Goblinkönig hat ein seltenen Gegenstand bei sich, er soll aber sehr stark sein.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 18 && _column == 32 && count == 1)
                {

                    Dialog = "Die Einzigen Wege aus der Kanalisation sind die Wasser Ausgänge oder das Kreschnick Labyrinth, keine ahnung wieso es so heisst";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 32 && count == 1)
                {

                    Dialog = "Goblins können dir nur Schaden machen wenn du kämpfst";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 16 && _column == 34 && count == 1 )
                {

                    Dialog = "Mehr als die hälfte der Leute hier sind krank, und ich meine nicht nur Wörtlich";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 16 && _column == 36 && count == 1)
                {

                    Dialog = "Auch dieser Teil der Bevölkerung brauch geistige Hilfe.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 37 && count == 1)
                {

                    Dialog = "Ich heisse Gitia und sie heisst Huba und wir lieben es Projekte zu machen";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 18 && _column == 37 && count == 1)
                {

                    Dialog = "Beachte sie nicht sie hatte zu viel des unreine Wassers";

                    _grid[_column, _row, 2] = empty.ToString();
                }
              


                Kommen = Dialog;
            }
            else
            {
                Dialog = Kommen;
            }
            #endregion
            #region Level 6        
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 6)
            {
                if (_row == 5 && _column == 10 && count == 1)
                {

                    Dialog = "Es hat anscheinend einen Vorfall in der Villa des Barones gegeben. Alle machen die nicht zu Villa gingen, warten anscheinend im Osten der Stadt auf den Üpeltäter falls er das Land verlassen möchte";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 12 && count == 1)
                {
                    Dialog = "Bist du schon mal in Sahawreed gewesen, dort ist es um einiges wärmer als hier in Estor";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 19 && _column == 20 && count == 1)
                {
                    Dialog = "Der Gesucht soll 3 Meter gross sein,Rote Augen haben und Voller Blut beschmiert sein,Sagen sie";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 9 && _column == 21 && count == 1)
                {
                    Dialog = "Endlich Feierabend, sorry habe gerade keine Waren für dich.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 22 && _column == 10 && count == 1)
                {
                    Dialog = "Endlich mal wieder eine Prächtige Ernte eingesammelt.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 11 && count == 1)
                {
                    Dialog = "Mein Father sagte mir immer schon, ich solle Bauer werden.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 5 && count == 1)
                {
                    Dialog = "Vielleicht sollte ich denn Wachen meine Dienste als Söldner anbieten, gibt sicher ne Fette behlohnung auf den Gesuchten.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 30 && _column == 14 && count == 1)
                {
                    Dialog = "Mein Name ist Hans Müller und ich bin Müller in dieser Mühle";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 37 && _column == 8 && count == 1)
                {
                    Dialog = "Die Tribute an den Baron sind viel zu hoch....... . Huch du hast nichts gehört ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 20 && count == 1)
                {
                    Dialog = "Bin gespannt ob meine Arbeiter ihre Arbeit gemacht haben";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 17 && count == 1)
                {
                    Dialog = "Im Süden liegt Nangasto, die Militär Festung der Habichtbucht. Sie ist der einzige Weg zur Hauptstadt von Estor";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 26 && _column == 22 && count == 1)
                {
                    Dialog = "Willkommen, leider ist uns gerade der Alkohol ausgegangen, ein Typ namens Zoro hat alles weggetrunken";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 33 && count == 1)
                {
                    Dialog = "Gierige Banausen, die haben mir mein ganzes Geld abgeknöpft, welcher Tribut lautet schon, gib uns all dein Geld un wir lassen dich durch. aaaarrrrrrrgggg";
                    _grid[_column, _row, 2] = empty.ToString();
                }


                Kommen = Dialog;
            }
            else
            {
                Dialog = Kommen;
            }
            #endregion
            #region Level 7
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 7)
            {
                if (_row == 11 && _column == 2 && count == 1)
                {

                    Dialog = "Warum bauen wir eigentlich nur Weizen an?";

                    _grid[_column, _row, 2] = empty.ToString();
                }
              else  if (_row == 20 && _column == 2 && count == 1)
                {
                    Dialog = "Wieher...          Hey du unten fass mein Pferd nicht an, ich halte dich im Blick";
                    _grid[_column, _row, 2] = empty.ToString();
                }
            else    if (_row == 37 && _column == 7 && count == 1)
                {
                    Dialog = "Naragost ist die Hochfeste von Estor, kein Feind hat sie je eingenommen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 35 && _column == 10 && count == 1)
                {
                    Dialog = "Man war das ne riesige Truppe die nach Osten ging, besonders ihr Anführer sah Bedrohlich aus , so ganz in Schwarz.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 28 && _column == 11 && count == 1)
                {
                    Dialog = "Gepriesen sei die Heilige Castrosa";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 37 && _column == 15 && count == 1)
                {
                    Dialog = "Himmel noch mal die Holz Bestellung ist ja Riesige, was wollen die; etwa eine Kriegsflotte.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 16 && count == 1)
                {
                    Dialog = "Ich Hasse Brot";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 19 && count == 1)
                {
                    Dialog = "Brot, Holz, Viele neue Soldaten. Was geht hier vor?";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 28 && count == 1)
                {
                    Dialog = "200 Gold pro überquerung 100 hier, 100 auf der anderen Seite";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 13 && _column == 15 && count == 1)
                {
                    Dialog = "Willkommen in meinem Dorf, keine Sorge hier kommen die Soldaten selten. Ach du Errinerst dich nicht wer du bist. Geht zu den Elfen, die kennen sich damit aus.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 2 && _column == 24 && count == 1)
                {
                    Dialog = "Die Soldaten treiben mich noch in den Ruin, die nehmen allen Reisenden alles Geld ab. Was soll das. Wie soll ein ehrlicher Wirt was verdienen.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                Kommen = Dialog;
            }
            else
            {
                Dialog = Kommen;
            
        }
            #endregion
            #region Level 8
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 8)
            {
                if (_row == 37 && _column == 2 && count == 1 || _row == 35 && _column == 2 && count == 1)
                {

                    Dialog = "Willkomen in Vorlondin Reisender";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 5 && count == 1)
                {//Farmer
                    Dialog = "Willkommen Reisender in Vorlondin, das Land der Gemeinschaft, du wirst hier Leute von vielen anderen Rassen sehen. Ich habe sogar gehört ein Zwergenhändler ist momentan in der Anwesend";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 7 && count == 1)
                {//Müller
                    Dialog = "Die Abenteurergilde soll endlich etwas gegen all diese Wölfe machen. Meine Arbeiter können kaum in sicherheit arbeiten.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 11 && count == 1)
                {//Farmer2
                    Dialog = "Ich frage mich immer noch was die Gruppe Dunkler gestalten hier wollten. Ich würd die ja nicht im dunklen treffen wollen. ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 12 && count == 1)
                {//Farmerin
                    Dialog = "Das Gebirge dient als natürliche Grenze von uns zu den Gierigen Hälsen";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 37 && _column == 17 && count == 1 || _row == 35 && _column == 17 && count == 1)
                {

                    Dialog = "Willkomen in Wezan Reisender";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 24 && _column == 17 && count == 1)
                {//Holzer
                    Dialog = "Ich habe gehört das irgendwo im Wald ein Banditen Versteck sein sollte. Ich möcht ja Bäume fällen, aber doch nicht wenn es ein Risiko gibt das man mich überfällt.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 38 && _column == 20 && count == 1)
                {//Lehrling
                    Dialog = "Es ist so schön, mal von Dravos heim zu der Familie zu gehen, die werden nicht glauben wie Weit ich gekommen bin.";
                    _grid[_column, _row, 2] = empty.ToString();
                }           
                else if (_row == 31 && _column == 19 && count == 1)
                {//Sahawreed
                    Dialog = "Falls du dich erholen must, das Wirtshaus ist gleich um die Ecke und die Kirche ist ein Wenig weiter in der Stadt im Heiligviertel. ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 29 && _column == 21 && count == 1)
                {//Söldner
                    Dialog = "Ich hab  gehört ein Adlige hat einen Familien Schatz im Wald verloren. Wieso er im Wald war? Keine ahnung!";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 28 && _column == 23 && count == 1)
                {//Söldner
                    Dialog = "Willkomen, Wilkommen, Rasten kostet 300 Goldstücke.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 25 && _column == 22 && count == 1)
                {//Man
                    Dialog = "Die geben anscheinend Gold für Wolf- und Bärenfelle. Vielleicht sollte ich Jäger werden.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 23 && _column == 22 && count == 1)
                {//Bettler
                    Dialog = "Hast du ein Wenig Kleingeld. Hast du ein Wenig Kleingeld. Hast du ein Wenig Kleingeld. Hast du ein Wenig Kleingeld. HAST DU EIN wENIG KLEIN GELD. Er fällt um und schläft ein. ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 27 && count == 1 || _row == 25 && _column == 27 && count == 1)
                {
                    Dialog = " Stell bloss keinen Ärger an ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 37 && _column == 29 && count == 1)
                {//Mann
                    Dialog = "Ich bin froh das die Beziehungen zwischen den Elfen und Menschen sich verbessern. Ich hab gehört sie sind Experten in der Magie";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 31 && count == 1 || _row == 34 && _column == 33 && count == 1)
                {
                    Dialog = " Stell bloss keinen Ärger an im Südlichenviertel ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 34 && count == 1)
                {//Elf
                    Dialog = "Du leidest unter amnesie, geh am besten nach Paranthil, es gibt Elfenmagier die kennen sich damit aus, sie könnten dein Problem lösen.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 33 && count == 1)
                {//Guard
                    Dialog = "Die Heldin Wencyra stammt aus Vorlondin, wenn auch sie grössten teils in Dravons lebte";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 30 && _column == 35 && count == 1)
                {//Zwerg
                    Dialog = "Zwergisches Roskan Metall ist viel Härter als dieses Elfische Weichmetal Venimium. Die Denken nur weil sie ihr Metall verzaubern können, ist es automatisch besser";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 30 && _column == 30 && count == 1)
                {//Zwerg
                    Dialog = "Bomben, Brauchst du Bomben, je 1000 Gold pro Stück. Aber nur wenn du weniger als 3 Stück bei dir hast, sonst kann ich sie wegen sicherheits Gründen nicht geben";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 26 && _column == 34 && count == 1)
                {//Frau
                    Dialog = "Ich habe Gerüchte gehört das in Estor was passiert ist, aber niemand will mir sagen was.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 25 && _column == 30 && count == 1)
                {//Elf
                    Dialog = "Vorlondier sind extrem Freundlich zu andere Rassen aber sie Hassen den Orden wegen ihrem umgang mit den Magier";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 19 && _column == 31 && count == 1 || _row == 19 && _column == 33 && count == 1)
                {
                    Dialog = " Bitte behandelt die Bürger im Adeligenviertel mit Respekt";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 11 && _column == 35 && count == 1)
                {//Elfwar
                    Dialog = "Bitte behandelt die Herrin mit Respekt";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 15 && _column == 37 && count == 1)
                {//Elfin
                    Dialog = "Werter Herr sie Leiden unter Amnesie? Falls sie jemals nach Paranthil gehen dann gehen sie zum Magier Garonalas, er wird ihnen mit Garantie helfen können";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 8 && _column == 35 && count == 1 || _row == 8 && _column == 37 && count == 1)
                {
                    Dialog = " Suchen sie nach einem Auftrag, Reisender. Unser Herr hat einen Familien Schatz verloren. Helfen sie ihm Bitte!";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 15 && _column == 29 && count == 1)
                {//Adel
                    Dialog = "Es liegt in unserem Intresse das die Verhältnisse mit Peskar, Sahawreed und Trestan für immer Freundlich bleibt.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 10 && _column == 30 && count == 1)
                {//Bogenschütze
                    Dialog = "Ich hab gehört es soll irgendwo eine Bärenhöle geben. Bärenfell gibt viel Geld und wer weiss was die in ihrem Bau haben.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 28 && count == 1)
                {//Diebeshändler
                    Dialog = "Tut mir leid, ich habe im moment nichts im Angebot.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 1 && _column == 30 && count == 1)
                {//Wanderer
                    Dialog = "Ich komme gerade von der Grenze zum Orden, sie haben aus irgend einen Grund die Greze dicht gemacht.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 10 && _column == 25 && count == 1 || _row == 12 && _column == 25 && count == 1)
                {
                    Dialog = "Wir dulden keine Waffen benutzung in Heiligenviertel. Daher verhalteten sie sich Reisender ";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 7 && _column == 25 && count == 1)
                {//Isekai
                    Dialog = "Wo bin ich, ich ging grade über die Strasse. Als ein Lastwagen gekommen ist. Wer bist du, Wo bin ich. Ich glaub ich muss mich erst mal beruhigen.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 14 && _column == 23 && count == 1)
                {//Schmied
                    Dialog = " Willkomen.Willkomen intressiert an Material um deine Rüstung zu verstärken, nur 250 Gold per Stück.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 9 && _column == 23 && count == 1)
                {//Schmied
                    Dialog = "  Ist dein Waffe Stumpf, dann Kauf dir bei Scharpstone Industries für nur 200 Gold per Stück, Schleifsteine";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 12 && _column == 22 && count == 1)
                {//Sahawreed Magier
                    Dialog = "Neue Magier zu finden wird immer schwerer und schwerer. Ich frage mich warum?";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 5 && _column == 24 && count == 1)
                {//Guard Captain
                    Dialog = "Ich würde gerne mal einer der Legendären Waffen in den Händen halten. Am liebsten das Schwert Hiravance.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 3 && _column == 23 && count == 1)
                {//Priester
                    Dialog = "Preise die Erde, die Gemeinschaft, die Freundschaft und das Leben. Alles ist Teil dieser Welt.";
                    _grid[_column, _row, 2] = empty.ToString();
                }


                Kommen = Dialog;
            }
            else
            {
                Dialog = Kommen;

            }
            #endregion
            #region Level 9
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Pers && Level == 9)
            {
                if (_row == 2 && _column == 5 && count == 1)
                {

                    Dialog = "Diese Strasse führt Leinos oder Vosgon, Vosgon is in Richtung Süden Leinos in Richtung Norden, wenn du die Strass komplett nach Osten folgst dann kommst du zu Jirosk ";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 7 && count == 1)
                {
                    Dialog = "Leinos is die Haupstadt von Vorlondin, König Ories Herrscht dort und bewacht auf die Grenze zu dem Orden.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 16 && _column == 3 && count == 1)
                {

                    Dialog = "Südlich von hier liegt Binnares. Die Minenstadt.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 13 && _column == 6 && count == 1)
                {

                    Dialog = "Schon mal vom Behemoth gehört, das sollen Legändere Monster sein die sich in den Bergen verstecken, nach der Legende soll keine Waffe ausser der Legendären Fünf viel schadem anrichten können.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 25 && _column == 6 && count == 1)
                {

                    Dialog = "Aus irgend einen Grund möchte ich Pirat werden und einen Strohhut tragen. Ich sollte mal mit meinen zwei Brüdern reden. Sabal und Asher, so war ich Richie heisse ich werde König der......(du geht und hört nur noch undeutliche Worte)";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 27 && _column == 2 && count == 1)
                {

                    Dialog = "Ich verkaufe dir pro 150 Gold einen Heilungs Trank";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 4 && _column == 26 && count == 1 || _row == 32 && _column == 1 && count == 1)
                {

                    Dialog = "Falls du rasten willst, dann kannst du in meiner Scheune Schlafen, nur für 300 Gold";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 30 && _column == 22 && count == 1 || _row == 29 && _column == 7 && count == 1)
                {

                    Dialog = "Ich fahre dich auf die andere Flussseite(Warnung die fähre ist recht Buggy. bei benutzung mehr mals klicken dann sollte mann sich wieder bewegen können).";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 11 && count == 1)
                {

                    Dialog = "Paranthil schätzt das Bündnis mit Vorlondin.";

                    _grid[_column, _row, 2] = empty.ToString();
                }//
                else if (_row == 8 && _column == 27 && count == 1)
                {

                    Dialog = "Die Ernte ist dieses Jahr schlecht ausgefallen";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 3 && _column == 23 && count == 1)
                {

                    Dialog = "Elfen und Zwerge können viele sachen, die wir Menschen nicht können.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 24 && count == 1)
                {

                    Dialog = "Für 250 Gold gebe ich ein Rüstungsmaterial";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 19 && _column == 24 && count == 1)
                {

                    Dialog = "Für 250 Gold gebe ich einen Schleifstein";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 27 && count == 1)
                {

                    Dialog = "Willkomen auf den Reisenden Markt";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 23 && _column == 27 && count == 1 || _row == 23 && _column == 29 && count == 1)
                {

                    Dialog = "Stell keinen Ärger an";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 26 && _column == 34 && count == 1)
                {

                    Dialog = "Man sagt jemand hätte ein Direwolf gesehen, die Dinger sind Mords gefährlich. Ich hoffe ich treffe das nie.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 29 && _column == 23 && count == 1 || _row == 27 && _column == 29 && count == 1)
                {

                    Dialog = "Willkommen in Vosgon, ich wünsche ihnen einen Schönen aufenthalt";

                    _grid[_column, _row, 2] = empty.ToString();
                }//
                else if (_row == 32 && _column == 23 && count == 1)
                {

                    Dialog = "Leider kommen nicht sehr viele Schiffe in den Hafen, ich muss mich wahrscheinlich nach alternative Arbeit suchen.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 3 && _column == 23 && count == 1)
                {//Priester
                    Dialog = "Preise die Erde, die Gemeinschaft, die Freundschaft und das Leben. Alles ist Teil dieser Welt.";
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 25 && _column == 21 && count == 1)
                {

                    Dialog = "Vorlondin ist ein Wunderschönes Land.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 29 && _column == 30 && count == 1)
                {

                    Dialog = "Ich bin Bert Dago Luck und ich ein Wichtiger man in dieser Stadt(er ist nicht wichtig)";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 7 && _column == 24 && count == 1)
                {

                    Dialog = "Ah da bist du ja, hör zu ich habe einen Schlüssel für das Lagerhaus im Hafen, ich gib ihn dir wenn du 1000Gold gibts.";

                    _grid[_column, _row, 2] = empty.ToString();
                }              
                else if (_row == 38 && _column == 29 && count == 1)
                {

                    Dialog = "Wölf, Banditen. Und aus irgendeinem Grund wird Estor unruhig.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 33 && count == 1)
                {

                    Dialog = "Die Strasse nach Osten geht an die Grenze zu Peskar.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 26 && count == 1)
                {

                    Dialog = "Ich beforzuge ja die Häuser der Elfen, aber diese sind auch ganz Ok. ";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 37 && count == 1)
                {

                    Dialog = "Insert Elvenwitz ";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 38 && _column == 35 && count == 1)
                {

                    Dialog = "Bla bla bla ";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 31 && _column == 33 && count == 1)
                {

                    Dialog = "Es lebt sich gut in Vosgon ";

                    _grid[_column, _row, 2] = empty.ToString();
                }




                Kommen = Dialog;
            }
            #endregion
            #region Level 10

            #endregion
            return Dialog;
        }
        string Kommen;
        public string Kommentar(Panel panMain, PictureBox panel, int _row, int _column, int Level, string Dialog)
        {
           

               var count = Convert.ToInt32(_grid[_column, _row, 2]);
            #region Level 2

          
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 2)
            {
                if (_row == 6 && _column == 13 && count == 1|| _row == 7 && _column == 13 && count == 1)
                {
                 //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                   Kommen = "Will ich wirklich wieder in diese Richtung gehen";
                   
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 1 && _column == 37 && count == 1 || _row == 2 && _column == 37 && count == 1)
                {
                 //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Was will ich hier, Baden gehn??";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if ( _row == 26 && _column == 21 && count == 1 || _row == 29 && _column == 21 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Wow!! Hier ist es aber Dunkel";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 22 && count == 1 )
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Mal schauen ob sich dieser Weg lohnt?";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 17 && _column == 22 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Verdammt ich seh das Schiff, wieso muss es Haie geben";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 33 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Diese Tür sieht alt aus es muss irgend wo einen Schlüssel geben.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 35 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "................. Holy.... Jackpot!!!!";

                    _grid[_column, _row, 2] = empty.ToString();
                }



                Dialog = Kommen;
            }
            #endregion
            #region Level 4

           
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 4)
            {
                if (_row == 18 && _column == 26 && count == 1 || _row == 19 && _column == 26 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Hm das Arbeits Zimmer des Barones ist ziehmlich schick.         Der Baron: Ah da sind sie ja ich habe sie erwartet, setzen sie sich.";

                    _grid[26, 18, 2] = empty.ToString();
                    _grid[26, 19, 2] = empty.ToString();
                }
                
                Dialog = Kommen;
            }
            #endregion
            #region Level 5

            
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 5)
            {
                if (_row == 10 && _column == 37 && count == 1 )
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Das Sieht stark nach einer der Wachräume der Villa aus, es wäre wahrscheinlich ein Risiko da rein zu gehen, ich sollte den Raum îm Gedächtnis halten";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                if (_row == 1 && _column == 38 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Oh nein, da gehe ich definitiv nicht mehr rein, wenn ich nochmal gefunden werde, dann wird es sehr wahrscheinlich Blutig enden.";

                    _grid[_column, _row, 2] = empty.ToString();
                }

                Dialog = Kommen;
            }
            else
            {
                Kommen = Dialog;
            }
            #endregion
            #region Level 6
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 6)
            {
                if (_row == 6 && _column == 3 && count == 1|| _row == 6 && _column == 4 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Es ist warscheinlich nicht Sicher mit den Schiff, die Stadt zu verlassen. Die wissen wahrscheinlich, dass ich mit diesem Schiff angekommen bin.";

                    _grid[3, 6, 2] = empty.ToString();
                    _grid[4, 6, 2] = empty.ToString();
                }
               else if (_row == 15 && _column == 10 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Hmm.... Warscheinlich nicht die Beste Idee die Kaserne zu betreten, aber sie könnten Ressourcen haben die sich lohnen könnten";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 5 && _column == 22 && count == 1 || _row == 4 && _column == 22 && count == 1 || _row == 3 && _column == 22 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Das Westtor sieht stark bewacht aus, meine Rüstung und Waffen werden wahrscheinlich leiden.";

                    _grid[22, 5, 2] = empty.ToString();
                    _grid[22, 4, 2] = empty.ToString();
                    _grid[22, 3, 2] = empty.ToString();
                }
                else if (_row == 37 && _column == 17 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Süden sieht nicht nach einer Option aus, ich sehe ne riesige Festung in der Distanz.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 38 && _column == 15 && count == 1 || _row == 37 && _column == 15 && count == 1 || _row == 36 && _column == 15 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Westen ist auch keine Option, ich mag ja Schwimmen aber ich möcht ein Ziel vor Augen haben";

                    _grid[15, 36, 2] = empty.ToString();
                    _grid[15, 37, 2] = empty.ToString();
                    _grid[15, 38, 2] = empty.ToString();
                }
                else if (_row == 21 && _column == 26 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Hier wird also der Abfluss der Stadt hingeleitet, OH MEIN GOTT STINKT ES HIER!!!!";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 35 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Sieht so aus als wäre der Einzige Weg von hier Weg nach Osten nach Vorlondin";

                    _grid[_column, _row, 2] = empty.ToString();
                }

                Dialog = Kommen;
            }
            else
            {
                Kommen = Dialog;
            }
            #endregion
            #region Level 7
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 7)
            {
                if (_row == 3 && _column == 5 && count == 1 )
                {
                 
                    Kommen = "Ich sollt nicht zurück in die Stadt. Die suchen nach mir.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
             else   if (_row == 3 && _column == 8 && count == 1)
                {

                    Kommen = "Ich muss so schnell wie möglich dieses Land verlassen, von was der Baron gesagt hat. Suchen Mächtige Personen nach mir.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 2 && _column == 15 && count == 1 || _row == 3 && _column == 15 && count == 1 || _row == 4 && _column == 15 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Hm vielleicht sollte ich den Gebirgspfad nehmen, dass sollte auf jedenfall sicherer sein als auf der Hauptstrasse.";

                    _grid[15, 2, 2] = empty.ToString();
                    _grid[15, 3, 2] = empty.ToString();
                    _grid[15, 4, 2] = empty.ToString();
                }
           else     if (_row == 32 && _column == 34 && count == 1)
                {

                    Kommen = "Oh nein ich sollte definitv nicht weiter in diese Richtung Laufen. Ich seh ihn der Ferne einen Ritter in Schwarz.(Hinweis der Schwarze Ritter ist im moment ein Instakill.)";

                    _grid[_column, _row, 2] = empty.ToString();
                }

                Dialog = Kommen;
            }
            else
            {
                Kommen = Dialog;
            }
            #endregion
            #region Level 8
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 8)
            {
                if (_row == 36 && _column == 3 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "So ich glaube ich bin den Soldaten von Estor entkommen. Von Gesprächen her sollte das Vorlondin sein. Hoffentlich bin ich hier sicher.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
               
                Dialog = Kommen;
            }
            #endregion
            #region Level 9

            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Kome && Level == 9)
            {
                if (_row == 38 && _column == 10 && count == 1 )
                {
                 
                    Kommen = "Ich sollt nicht weiter in diese Richtung gehen Peskar ist nicht in diese Richtung";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 2 && count == 1 )
                {
             
                    Kommen = "Peskar liegt im Osten nicht im Süden, wieso gehe ich nach Süden";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 1 && _column == 15 && count == 1)
                {
              
                    Kommen = "Peskar liegt nicht im Norden, es liegt im Süd Osten";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 6 && _column == 38 && count == 1)
                {
                
                    Kommen = "Ich sollte nach Süden geh sonst gehe ich einen riesigen Umweg";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 18 && _column == 28 && count == 1)
                {
                    
                    Kommen = "Sieht so aus als wäre ein Markt unterwegs";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 34 && _column == 36 && count == 1|| _row == 35 && _column == 36 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "Endlich der Weg nach Peskar.";

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (_row == 36 && _column == 35 && count == 1)
                {
                    //   Dialog = "Will ich wirklich wieder in diese Richtung gehen";
                    Kommen = "................. Holy.... Jackpot!!!!";

                    _grid[_column, _row, 2] = empty.ToString();
                }



                Dialog = Kommen;
            }
            #endregion
            #region Level 10

            #endregion
            return Kommen;
        }
        #endregion
        #region Level End

        public static bool ende;

        public bool Endes(Panel panMain, PictureBox panel, int _row, int _column)
        {
         
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Ende && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast das Ende des Levels gefunden, Level beenden?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                   // MessageBox.Show("Du erhälst einen Schlüssek(+1 zu Keys))");

                    ende = false;

                   // MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
                }
                else if (dialogResult == DialogResult.No)
                {
                    ende = true;

                  //  MessageBox.Show("Du hast das Ende des Momentanen Spiel gefunden");
                }           
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] != Ende)
            {
                ende = true;

            }
          


            return ende;
        }
        #endregion
        #region Ways


        public int BomU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs,int lvel)
        {
            if (_row>0)
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Rock && lvel == 5)
                {
                    _grid[_column, _row, 0] = Stha;
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = null;
                    Bombs--;
                }

                else if(_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Rock)
           
                        {

                    _grid[_column, _row, 0] = Gras;

                    panel.BackColor = Color.LightGreen;

                    panel.BackgroundImage = null;
                    Bombs--;
                }


            }
            return Bombs;

        }
        public int ManU(Panel panMain, PictureBox panel, int _row, int _column, int Mana, int lvel)
        {
            if (_row > 0)
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Masd && lvel == 6)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = null;
                    Mana--;
                }

                else if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Masd)

                {

                    _grid[_column, _row, 0] = Gras;

                    panel.BackColor = Color.LightGreen;

                    panel.BackgroundImage = null;
                    Mana--;
                }


            }
            return Mana;

        }

        public int KeyU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row > 0)
            {


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;

        }
        public int SworU(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row > 0)
            {
               


                if (_grid[_column, _row - 1, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackColor = Color.LightGreen;
                    panel.BackgroundImage = null;
                    Bombs--;
                  
                }

            }
            return Bombs;

        }
        public int BomU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs,int lvel)
        {
            if (_row < 39)
            {
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock && lvel == 5)
                {
                    _grid[_column, _row, 0] = Stha;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }


            }
            return Bombs;
        }
        public int ManU2(Panel panMain, PictureBox panel, int _row, int _column, int Mana, int lvel)
        {
            if (_row < 39)
            {
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Masd && lvel == 6)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Masd)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }


            }
            return Mana;
        }
        public int goldTri2(Panel panMain, PictureBox panel, int _row, int _column, int Gold)
        {
            if (_row < 39)
            {
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga1 && Gold >= 100 && panel.Image == Secret)
                {

                    Gold = Gold - 100;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga2 && Gold >= 2000 && panel.Image == Secret)
                {
                    Gold = Gold - 2000;
                }
                else if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Tga3 && Gold >= 300 && panel.Image == Secret)
                {
                    Gold = Gold - 300;
                }


            }
            return Gold;
        }
        public int KeyU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row < 39)
            {
              
                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU2(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_row < 39)
            {


                if (_grid[_column, _row + 1, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        public int BomU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs, int lvel)
        {
            if (_column < 39)
            {
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && lvel == 5)
                {
                    _grid[_column, _row, 0] = Stha;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            else    if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }


            }
            return Bombs;
        }
        public int ManU3(Panel panMain, PictureBox panel, int _row, int _column, int Mana, int lvel)
        {
            if (_column < 39)
            {
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd && lvel == 6)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }


            }
            return Mana;
        }
        public int goldTri3(Panel panMain, PictureBox panel, int _row, int _column, int Gold)
        {
            if (_column < 39)
            {
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && Gold >= 100 && panel.Image == Secret)
                {

                    Gold = Gold - 100;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && Gold >= 2000 && panel.Image == Secret)
                {
                    Gold = Gold - 2000;
                }
                else if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga3 && Gold >= 300 && panel.Image == Secret)
                {
                    Gold = Gold - 300;
                }


            }
            return Gold;
        }
        public int KeyU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column < 39)
            {
             
                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU3(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column < 39)
            {
             

                if (_grid[_column + 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        public int BomU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs, int lvel)
        {
            if (_column > 0)
            {

                if (_grid[_column-1, _row, 1] == Player && _grid[_column, _row, 0] == Rock && lvel == 5)
                {
                    _grid[_column, _row, 0] = Stha;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            else    if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Rock)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }


            }
            return Bombs;
        }
        public int ManU4(Panel panMain, PictureBox panel, int _row, int _column, int Mana, int lvel)
        {
            if (_column > 0)
            {

                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd && lvel == 6)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Masd)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Mana--;
                }


            }
            return Mana;
        }
        public int goldTri4(Panel panMain, PictureBox panel, int _row, int _column, int Gold)
        {
            if (_column > 0)
            {

                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga1 && Gold >= 100 && panel.Image == Secret)
                {

                    Gold = Gold - 100;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga2 && Gold >= 2000 && panel.Image == Secret)
                {
                    Gold = Gold - 2000;
                }
                else if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Tga3 && Gold >= 300 && panel.Image == Secret)
                {
                    Gold = Gold - 300;
                }


            }
            return Gold;
        }
        public int KeyU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column > 0)
            {

             
                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == VTur)
                {
                    _grid[_column, _row, 0] = OTur;
                    panel.BackColor = Color.LightSkyBlue;
                    Bombs--;
                }
              
            }
            return Bombs;
        }
        public int SworU4(Panel panMain, PictureBox panel, int _row, int _column, int Bombs)
        {
            if (_column > 0)
            {

               

                if (_grid[_column - 1, _row, 1] == Player && _grid[_column, _row, 0] == Dwal)
                {
                    _grid[_column, _row, 0] = Gras;
                    panel.BackgroundImage = null;
                    panel.BackColor = Color.LightGreen;
                    Bombs--;
                }
            }
            return Bombs;
        }
        #endregion
        #region Gold

       
        public int Money1(Panel panMain, PictureBox panel, int _row, int _column, int Moneys)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == Money && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Säcklein Gold gefunden, willst du es Mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+200 zu Gold))");

                    // panel.BackColor = Color.Orange;

                    Moneys = Moneys + 200;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;

                }
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Coin && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Berg Gold gefunden, willst du ihn Mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+2000 zu Gold))");

               
                  //  panel.BackgroundImage = Boden;
                    Moneys = Moneys + 2000;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == LargeMoney && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Grosse Truhe Gold gefunden, willst du ihn Mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+1000 zu Gold))");


                    //  panel.BackgroundImage = Boden;
                    Moneys = Moneys + 1000;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }
            }
          else  if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == BigMoney && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Truhe Gold gefunden, willst du sie Looten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+500 zu Gold))");

                    // panel.BackColor = Color.Orange;

                    Moneys = Moneys + 500;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }


            }
            return Moneys;
        }
       /* public int Money2(Panel panMain, PictureBox panel, int _row, int _column, int Moneys)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == BigMoney && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast eine Truhe Gold gefunden, willst du sie Looten", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst Gold(+500 zu Gold))");

                   // panel.BackColor = Color.Orange;

                    Moneys = Moneys + 500;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //  panel.BackColor = Color.Orange;
                }


            }
            return Moneys;
        }
     */
        public int Arrows(Panel panMain, PictureBox panel, int _row, int _column, int Arrowss)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 3] == Arrow && count == 1 && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Du hast einen Köcher mit Goldenen Pfeilen gefunden", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du hast den Köcher mit genommen(Questitem))");

                    //    panel.BackColor = Color.Orange;

                    Arrowss = Arrowss + 1;
                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //panel.BackColor = Color.Orange;
                }


            }
            return Arrowss;
        }
        #endregion
        #region Trading
        public void Quest(Panel panMain, PictureBox panel, int _row, int _column, int lvl)
        {
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
              if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueA && lvl == 8 && count == 1)
            {
                  
                MessageBox.Show("Geehrter Herr können sie mir helfen, ein Köcher mit speziellen Pfeilen ist mir abhanden gekommen könnten sie ihn für mich finden ich biete ihnen auch ein Belohnung");

            }
          else  if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueW  && count == 1)
            {

                MessageBox.Show("Ich biete dir 150 Gold pro Wolfsfell, vergiss das nicht.");

            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueB  && count == 1)
            {

                MessageBox.Show("Ich biete dir 200 Gold pro Bärenfell, vergiss das nicht.");

            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueA && lvl == 8 && count == 1)
            {

                MessageBox.Show("Der Bastard von einem Bandit hat meinen Schmuck Gestohlen. Ich gebe dir 1500 Golde wenn du es zurück holst.");

            }
        }

        public bool Trading(Panel panMain, PictureBox panel, int _row, int _column, bool trade ,int item)
        {
           // var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrSA && panel.Image == Secret&& item ==1)
            {
                DialogResult dialogResult = MessageBox.Show("Der Preis liegt bei 150 pro Rüstungsmaterial, Verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst Gold(+150 zu Gold))");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrSS && panel.Image == Secret && item == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Der Preis liegt bei 100 pro Schleifstein, Verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst Gold(+100 zu Gold))");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
           else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrSB && panel.Image == Secret && item == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Der Preis liegt bei 200 pro Bombe, Verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst Gold(+200 zu Gold))");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == GuaK && panel.Image == Secret && item == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Der Wachhauptman gibt dir pro Banditen Abzeichen 150 Gold, Verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst Gold(+pro Abzeichen 150 zu Gold))");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == Secret && item == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Gibts du dem Adeligen seine Pfeile?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Hier hast du Tausend Gold plus es gibt noch eine überraschung neben der Villa");

                    trade = true;
                    _grid[34, 3, 0] = OTur;
                    _grid[36, 3, 2] = empty.ToString();

                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueW && panel.Image == Secret && item == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Wolfsfälle verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst 100 Gold pro Stück");

                    trade = true;
                

                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueB && panel.Image == Secret && item == 7)
            {
                DialogResult dialogResult = MessageBox.Show("Bärenfelle verkaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst 200 Gold pro Stück");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == QueA && panel.Image == Secret && item == 8)
            {
                DialogResult dialogResult = MessageBox.Show("Schmuckquest abgeben?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du bekommst 1500 Gold");

                    trade = true;


                }
                else if (dialogResult == DialogResult.No)
                {
                    trade = false;
                }


            }

            return trade;
        }
        int buyin = 0;
        public int Buying(Panel panMain, PictureBox panel, int _row, int _column, bool trade)
        {
            
             var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrSK && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Der Kaufpreis liegt bei 200 pro Schleifstein, Haufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst einen Schleifstein(+1 zu Schleifstein))");
                  

                    buyin = 1;


                }
                else if (dialogResult == DialogResult.No)
                {
                    buyin = 0;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrAK && panel.Image == Secret)
            {
                DialogResult dialogResult = MessageBox.Show("Der Kaufpreis liegt bei 250 pro Rüstungsmaterial, Kaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst Rüstungsmaterial(+1 zu Rüstungsmaterial))");
                    buyin = 2;


                }
                else if (dialogResult == DialogResult.No)
                {
                    buyin = 0;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == Secret&& count== 1)
            {
                DialogResult dialogResult = MessageBox.Show("Der Kaufpreis liegt bei 1000 für den Schlüssel zum Lagerhaus am Hafen, Kaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst den Schlüssel(+1 zu Keys))");
                    buyin = 3;

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    buyin = 0;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrKK && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Der Kaufpreis liegt bei 1000 pro Bombe , Kaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst eine Bombe(+1 zu Bombe))");
                    buyin = 4;

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    buyin = 0;
                }


            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == TrPK && panel.Image == Secret && count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Der Kaufpreis liegt bei 150 pro Potion, Kaufen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Du erhälst ein Potion(+1 zu Potion))");
                    buyin = 5;

                    _grid[_column, _row, 2] = empty.ToString();
                }
                else if (dialogResult == DialogResult.No)
                {
                    buyin = 0;
                }


            }
            else
            {
                buyin = 0;
            }
          

            return buyin;
        }
        #endregion
        #region Enemy

        #region Encountersnumbers

       
        int encount =0;
        public int Encounter(Panel panMain, PictureBox panel, int _row, int _column)
        {
           var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Band && panel.Image == Secret && count == 1)
            {             
                    encount = 1;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == BanC && panel.Image == Secret && count == 1)
            {             
                    encount = 2;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Guar && panel.Image == Secret && count == 1)
            {
                encount = 3;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == GuaK && panel.Image == Secret && count == 1)
            {
                encount = 4;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == GuaE && panel.Image == Secret && count == 1)
            {
                encount = 5;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Gobl && panel.Image == Secret && count == 1)
            {
                encount = 6;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Gobk && panel.Image == Secret && count == 1)
            {
                encount = 7;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Dark && panel.Image == Secret && count == 1)
            {
                encount = 8;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Wolf && panel.Image == Secret && count == 1)
            {
                encount = 9;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bear && panel.Image == Secret && count == 1)
            {
                encount = 10;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Assa && panel.Image == Secret && count == 1)
            {
                encount = 11;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == BandL && panel.Image == Secret && count == 1)
            {
                encount = 12;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == DWolf && panel.Image == Secret && count == 1)
            {
                encount = 13;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Behe && panel.Image == Secret && count == 1)
            {
                encount = 14;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos1 && panel.Image == Secret && count == 1)
            {
                encount = 15;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos2 && panel.Image == Secret && count == 1)
            {
                encount = 16;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos3 && panel.Image == Secret && count == 1)
            {
                encount = 17;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos4 && panel.Image == Secret && count == 1)
            {
                encount = 18;
            }
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos5 && panel.Image == Secret && count == 1)
            {
                encount = 19;
            }
            else
            {
                encount = 0;
            }


            return encount;
        }
        #endregion
        public int Points;
        public  int chance;
        public int Magie=0;
        public int Explo=0;
        public static int BehemothResult;
        public static int ZResult;
        public static int MonsterResult;
        public static int DragonResult;
        #region Fights

        
        public bool Fight(Panel panMain, PictureBox panel, int _row, int _column,bool fight,int Armor ,int Schleif,int encoun, int Bombe, int Mana,int Lvl,int tresure)
        {
            chance = 3;
            #region Bandit

          
            var count = Convert.ToInt32(_grid[_column, _row, 2]);
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Band && panel.Image == Secret&& count==1&& encoun==1)
            {
                DialogResult dialogResult = MessageBox.Show("Bandit Angriff willst du dich verteidigen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor>=1 && Schleif>=1)
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein und -1 zu Armor))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Verletzt(-2 zu Leben))");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }                
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht eine kleine Wunde(-1 zu Leben))");
                    fight = false;
                }

            }
            #endregion
            #region Banditcaptain


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == BanC && panel.Image == Secret && count == 1 && encoun == 2)
            {
                DialogResult dialogResult = MessageBox.Show("BanditChef Angriff willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 1 && Schleif >= 2||Bombe>= 1)
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein und -2 zu Armor oder falls du ne Bombe hattest dann nur Bombe-1))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Schwer Verletzt(-3 zu Leben))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht  Schwere Wunden(-3 zu Leben))");
                    fight = false;
                }
            }
            #endregion
            #region Guard           
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Guar && panel.Image == Secret && count == 1 && encoun == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Wache greift dich an willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 1 && Schleif >= 1 )
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein und -1 zu Armor ))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Schwer Verletzt(-2 zu Leben))");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht  Schwere Wunden(-1 zu Leben))");
                    fight = false;
                }
            }
            #endregion
            #region Guardkaptain


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == GuaK && panel.Image == Secret && count == 1 && encoun == 4)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Wachehauptmann greift dich an willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 2 && Schleif >= 2 || Bombe >= 1)
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-2 zu Schleifstein und -2 zu Armor oder falls du ne Bombe hattest dann nur Bombe-1))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Schwer Verletzt(-3 zu Leben))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht  Schwere Wunden(-2 zu Leben))");
                    fight = false;
                }


            }
            #endregion
            #region Eliteguard        
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == GuaE && panel.Image == Secret && count == 1 && encoun == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Elite Soldat greift dich an willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 2 && Schleif >= 1 )
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein und -2 zu Armor))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Verletzt(-2 zu Leben))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht leichte Wunden(-1 zu Leben))");
                    fight = false;
                }


            }
            #endregion
            #region Goblin       
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Gobl && panel.Image == Secret && count == 1 && encoun == 6)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Goblin greift dich an willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Schleif >= 1 )
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Verletzt(-2 zu Leben))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Du bist entkommen(kein Leben verloren))");
                    fight = false;
                }
            }
            #endregion
            #region Goblinking


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Gobk && panel.Image == Secret && count == 1 && encoun == 7)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Goblinkönig greift dich an willst du Kämpfen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 2 && Schleif >= 3 || Bombe >= 1)
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-3 zu Schleifstein und -2 zu Armor oder falls du ne Bombe hattest dann nur Bombe-1))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Verletzt(-4 zu Leben))");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht leichte Wunden(-3 zu Leben))");
                    fight = false;
                }
            }
            #endregion
            #region Black Knight


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Dark && panel.Image == Secret && count == 1 && encoun == 8)
            {
                DialogResult dialogResult = MessageBox.Show("Der Schwarze Ritter greift dich an, bist du bereit zu sterben", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 99 && Schleif >= 99 || Bombe >= 99)
                    {
                        MessageBox.Show("Du hast definitiv gecheatet, schade nur das es keine Belohnung gibt, pech gehabt");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du bist Tod");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Nein du kannst nicht wegrennen, übrigens du bist Tod");
                    fight = false;
                }


            }
            #endregion
            #region Wolf


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Wolf && panel.Image == Secret && count == 1 && encoun == 9)
            {
                DialogResult dialogResult = MessageBox.Show("Ein Wolf greift dich an ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if ( Schleif >= 1)
                    {
                        MessageBox.Show("Der Wolf liegt nun Tod vor deinen füssen. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+100 zu Gold plus 1 Wolfsfell)");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else if (Schleif == 0 && Armor >= 1)
                  
                    {
                        MessageBox.Show("Du hast ihn besiegt, er jedoch deine Rüstung ein Wenig beschädigt. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+100 zu Gold plus 1 Wolfsfell");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast ihn besiegt, er hat dich jedoch verwundet. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+100 zu Gold plus 1 Wolfsfell");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Beim Wegrennen hat er dich ein Wenig verletzt");
                    fight = false;
                }


            }
            #endregion
            #region Bear     
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bear && panel.Image == Secret && count == 1 && encoun == 10)
            {
                DialogResult dialogResult = MessageBox.Show("Ein Bär greift dich an ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Schleif >= 2 && Armor >= 1)
                    {
                        MessageBox.Show("Der Bär liegt nun Tod vor deinen füssen. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+500 zu Gold plus 2 Bärenfelle)");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else if (Schleif == 0 && Armor >= 2)

                    {
                        MessageBox.Show("Du hast ihn besiegt, er jedoch deine Rüstung ein Wenig beschädigt. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+500 zu Gold plus 2 Bärenfelle");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast ihn besiegt, er hat dich jedoch verwundet. Du nimmst sein Fell und findest dabei noch ein paar Münzen(+500 zu Gold plus 2 Bärenfelle");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Beim Wegrennen hat er dich ein Wenig verletzt");
                    fight = false;
                }
            }
            #endregion
            #region Assassin       
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Assa && panel.Image == Secret && count == 1 && encoun == 11)
            {
                DialogResult dialogResult = MessageBox.Show("Eine Dunkle Figur greift dich aus dem Schatten an ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Schleif >= 3 && Armor >= 1)
                    {
                        MessageBox.Show("Nach einen Schweren Kampf hast du ihn besiegt(-3 zu Schleifsteine, -1 zu Rüstung und -1 zu Leben ). Er hat einen Sack mit Geld dabei(+1200 zu Gold)");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }                  
                    else
                    {
                        MessageBox.Show("Du hast ihn besiegt,jedoch bist du stark verletzt(-3Leben). Er hat einen Sack mit Geld dabei(+1200 zu Gold)");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Du bist Kritische Verletzt(-4Leben)");
                    fight = false;
                }
            }
            #endregion
            #region Banditenlord       
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == BandL && panel.Image == Secret && count == 1 && encoun == 12)
            {
                DialogResult dialogResult = MessageBox.Show("Ein Banditenlord greift dich an.", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Schleif >= 4 && Armor >= 2)
                    {
                        MessageBox.Show("Nach einen Schweren Kampf hast du ihn besiegt(-4 zu Schleifsteine, -2 zu Rüstung ). Er hat einen Truhe mit Geld neben sich stehen(+2000 zu Gold+ 3 Tokens)");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du bist Schwer Verletzt, du must Fliehen(-3Leben)");
                        fight = false;

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Beim Fliehen verletzt er dich stark(-3Leben)");
                    fight = false;
                }


            }
            #endregion
            #region DireWolf           
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == DWolf && panel.Image == Secret && count == 1 && encoun == 13)
            {//Bearbeiten
                DialogResult dialogResult = MessageBox.Show("Ein DireWolf greift dich an.", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Schleif >= 3 && Armor >= 2)
                    {
                        MessageBox.Show("Es war schwer, aber du hast es geschafft. Der Dirwolf ist Tod (Wolffelle +5 Gold+ 750) ");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du bist Schwer Verletzt, du must Fliehen(-3Leben)");
                        fight = false;

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Beim Fliehen verletzt er dich stark(-3Leben)");
                    fight = false;
                }


            }
            #endregion
            #region Behemoth


            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Behe && panel.Image == Secret && count == 1 && encoun == 14)
            {//Bearbeiten
                DialogResult dialogResult = MessageBox.Show("Ein Behemoth greift dich an, Kämpfen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Mit Magie oder Waffen Kämpfen Yes= Magie Nein = Waffen", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        if (Mana>0)
                        {
                            DialogResult dialogResult3 = MessageBox.Show("Mit vielen Schwachen Zauber angreiffen oder mit einem Starken", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult3 == DialogResult.Yes)
                            {
                                MessageBox.Show("Du wirfst mehre Feuerbälle, sie zeigen jedoch kaum effekt");
                                DialogResult dialogResult4 = MessageBox.Show("Weiter drauf schiessen", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult4 == DialogResult.Yes)
                                {
                                    MessageBox.Show(" sie zeigen jedoch Langsam effekt");
                                    MessageBox.Show(" Nur schlägt der Behemoth die gegen die Wand auf. Und Spiesst dich danach auf seine Stacheln auf.");
                                    MessageBox.Show(" Du bist Tod");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }
                                else if (dialogResult4 == DialogResult.No)
                                {
                                    DialogResult dialogResult5 = MessageBox.Show("Alle deine Magie in einen Finalen Zauber stecken oder zu Waffen Wechseln(Ja Zauber nein Waffen)", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult5 == DialogResult.Yes)
                                    {
                                        MessageBox.Show(" Du wirftst ein Electro Lanze(Magie nicht Lanze)");
                                        MessageBox.Show(" Du triffst und Verletzt den Behemoth stark. Er schlägt nach dir");
                                        MessageBox.Show(" Er trifft dich Stark fällt aber danach Tod zu Boden");
                                        BehemothResult = 2;//Gewonnen aber Stark verletzt
                                        fight = true;
                                        _grid[_column, _row, 2] = empty.ToString();
                                    }
                                    else if (dialogResult5 == DialogResult.No)
                                    {
                                        DialogResult dialogResult6 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult6 == DialogResult.Yes)
                                        {
                                          
                                            MessageBox.Show(" Du Stürmst zum Behemoth......");
                                            MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                                            BehemothResult = 1;//Tod
                                            fight = true;
                                        }
                                        else if (dialogResult6 == DialogResult.No)
                                        {
                                            if (Bombe >0)
                                            {
                                                MessageBox.Show(" Du wirfst deine Bombe");
                                                MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                                MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                                if (Lvl==9)
                                                {
                                                    MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                                    MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                                    BehemothResult = 3;//Schatz ist Weg
                                                    fight = true;
                                                    _grid[5, 37, 0] = Moun;
                                                    _grid[_column, _row, 2] = empty.ToString();
                                                }
                                                else
                                                {
                                                    MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                                    BehemothResult = 1;//Tod
                                                    fight = true;
                                                }
                                              
                                               
                                            }
                                            else
                                            {
                                                MessageBox.Show(" Hast keine Bombe");
                                                MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                                BehemothResult = 1;//Tod
                                                fight = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (dialogResult3 == DialogResult.No)
                            {
                                if (Mana>=4)
                                {
                                    MessageBox.Show(" Der Behemoth wird direkt im Herz Getroffen, er Kippt um. Du bist aber nun komplett erschöpft");
                                    BehemothResult = 4;//Gewonnen aber erschöpft
                                    fight = true;
                                }
                                else
                                {
                                    MessageBox.Show(" Du wirftst ein Electro Lanze(Magie nicht Lanze)");
                                    MessageBox.Show(" Du triffst und Verletzt den Behemoth stark. Er schlägt nach dir");
                                    MessageBox.Show(" Er trifft dich Stark fällt aber danach Tod zu Boden");
                                    BehemothResult = 2;//Gewonnen aber Stark verletzt
                                    fight = true;
                                }
                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("Du hast kein Mana oder kein Magische Kraft");
                            DialogResult dialogResult7 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult7 == DialogResult.Yes)
                            {

                                MessageBox.Show(" Du Stürmst zum Behemoth......");
                                MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                                BehemothResult = 1;//Tod
                                fight = true;
                            }
                            else if (dialogResult7 == DialogResult.No)
                            {
                                if (Bombe > 0)
                                {
                                    MessageBox.Show(" Du wirfst deine Bombe");
                                    MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                    MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                    if (Lvl == 9)
                                    {
                                        MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                        MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                        BehemothResult = 3;//Schatz ist Weg
                                        fight = true; 
                                        _grid[5, 37, 0] = Moun;
                                        _grid[_column, _row, 2] = empty.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                        BehemothResult = 1;//Tod
                                        fight = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(" Hast keine Bombe");
                                    MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }
                            }
                        }
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        DialogResult dialogResult8 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult8 == DialogResult.Yes)
                        {

                            MessageBox.Show(" Du Stürmst zum Behemoth......");
                            MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                            BehemothResult = 1;//Tod
                            fight = true;
                        }
                        else if (dialogResult8 == DialogResult.No)
                        {
                            if (Bombe > 0)
                            {
                                MessageBox.Show(" Du wirfst deine Bombe");
                                MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                if (Lvl == 9)
                                {
                                    MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                    MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                    BehemothResult = 3;//Schatz ist Weg
                                    fight = true;
                                    _grid[5, 37, 0] = Moun;
                                    _grid[_column, _row, 2] = empty.ToString();
                                }
                                else
                                {
                                    MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }


                            }
                            else
                            {
                                MessageBox.Show(" Hast keine Bombe");
                                MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                BehemothResult = 1;//Tod
                                fight = true;
                            }
                        }
                    }
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du bist entkommen aber er verletzt dich Stark (- 5 zu Leben)");
                    fight = false;
                }


            }

            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos1 && panel.Image == Secret && count == 1 && encoun == 15)
            {//Bearbeiten
                DialogResult dialogResult = MessageBox.Show("Ein Behemoth greift dich an, Kämpfen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Mit Magie oder Waffen Kämpfen Yes= Magie Nein = Waffen", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        if (Mana > 0)
                        {
                            DialogResult dialogResult3 = MessageBox.Show("Mit vielen Schwachen Zauber angreiffen oder mit einem Starken", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult3 == DialogResult.Yes)
                            {
                                MessageBox.Show("Du wirfst mehre Feuerbälle, sie zeigen jedoch kaum effekt");
                                DialogResult dialogResult4 = MessageBox.Show("Weiter drauf schiessen", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult4 == DialogResult.Yes)
                                {
                                    MessageBox.Show(" sie zeigen jedoch Langsam effekt");
                                    MessageBox.Show(" Nur schlägt der Behemoth die gegen die Wand auf. Und Spiesst dich danach auf seine Stacheln auf.");
                                    MessageBox.Show(" Du bist Tod");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }
                                else if (dialogResult4 == DialogResult.No)
                                {
                                    DialogResult dialogResult5 = MessageBox.Show("Alle deine Magie in einen Finalen Zauber stecken oder zu Waffen Wechseln(Ja Zauber nein Waffen)", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult5 == DialogResult.Yes)
                                    {
                                        MessageBox.Show(" Du wirftst ein Electro Lanze(Magie nicht Lanze)");
                                        MessageBox.Show(" Du triffst und Verletzt den Behemoth stark. Er schlägt nach dir");
                                        MessageBox.Show(" Er trifft dich Stark fällt aber danach Tod zu Boden");
                                        BehemothResult = 2;//Gewonnen aber Stark verletzt
                                        fight = true;
                                        _grid[_column, _row, 2] = empty.ToString();
                                    }
                                    else if (dialogResult5 == DialogResult.No)
                                    {
                                        DialogResult dialogResult6 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult6 == DialogResult.Yes)
                                        {

                                            MessageBox.Show(" Du Stürmst zum Behemoth......");
                                            MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                                            BehemothResult = 1;//Tod
                                            fight = true;
                                        }
                                        else if (dialogResult6 == DialogResult.No)
                                        {
                                            if (Bombe > 0)
                                            {
                                                MessageBox.Show(" Du wirfst deine Bombe");
                                                MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                                MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                                if (Lvl == 9)
                                                {
                                                    MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                                    MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                                    BehemothResult = 3;//Schatz ist Weg
                                                    fight = true;
                                                    _grid[5, 37, 0] = Moun;
                                                    _grid[_column, _row, 2] = empty.ToString();
                                                }
                                                else
                                                {
                                                    MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                                    BehemothResult = 1;//Tod
                                                    fight = true;
                                                }


                                            }
                                            else
                                            {
                                                MessageBox.Show(" Hast keine Bombe");
                                                MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                                BehemothResult = 1;//Tod
                                                fight = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else if (dialogResult3 == DialogResult.No)
                            {
                                if (Mana >= 4)
                                {
                                    MessageBox.Show(" Der Behemoth wird direkt im Herz Getroffen, er Kippt um. Du bist aber nun komplett erschöpft");
                                    BehemothResult = 4;//Gewonnen aber erschöpft
                                    fight = true;
                                }
                                else
                                {
                                    MessageBox.Show(" Du wirftst ein Electro Lanze(Magie nicht Lanze)");
                                    MessageBox.Show(" Du triffst und Verletzt den Behemoth stark. Er schlägt nach dir");
                                    MessageBox.Show(" Er trifft dich Stark fällt aber danach Tod zu Boden");
                                    BehemothResult = 2;//Gewonnen aber Stark verletzt
                                    fight = true;
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Du hast kein Mana oder kein Magische Kraft");
                            DialogResult dialogResult7 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult7 == DialogResult.Yes)
                            {

                                MessageBox.Show(" Du Stürmst zum Behemoth......");
                                MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                                BehemothResult = 1;//Tod
                                fight = true;
                            }
                            else if (dialogResult7 == DialogResult.No)
                            {
                                if (Bombe > 0)
                                {
                                    MessageBox.Show(" Du wirfst deine Bombe");
                                    MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                    MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                    if (Lvl == 9)
                                    {
                                        MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                        MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                        BehemothResult = 3;//Schatz ist Weg
                                        fight = true;
                                        _grid[5, 37, 0] = Moun;
                                        _grid[_column, _row, 2] = empty.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                        BehemothResult = 1;//Tod
                                        fight = true;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(" Hast keine Bombe");
                                    MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }
                            }
                        }
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        DialogResult dialogResult8 = MessageBox.Show("Stürmst du mit deiner Waffe oder Wirfst du Bomben (Ja Waffe Nein Bombe))", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult8 == DialogResult.Yes)
                        {

                            MessageBox.Show(" Du Stürmst zum Behemoth......");
                            MessageBox.Show(" Jedoch Packt er dich. Und spiesst dich auf seinen Stacheln auf");
                            BehemothResult = 1;//Tod
                            fight = true;
                        }
                        else if (dialogResult8 == DialogResult.No)
                        {
                            if (Bombe > 0)
                            {
                                MessageBox.Show(" Du wirfst deine Bombe");
                                MessageBox.Show(" Jedoch Block der Behemoth mit seiner Hand die Bombe");
                                MessageBox.Show(" Die Bombe rollt zum Rand der Kammer und Explodiert");
                                if (Lvl == 9)
                                {
                                    MessageBox.Show(" Die Höhle fäng an Einzustürzen");
                                    MessageBox.Show(" Du schaffst es raus aber der Weg zum Schatz ist Blockiert ");
                                    BehemothResult = 3;//Schatz ist Weg
                                    fight = true;
                                    _grid[5, 37, 0] = Moun;
                                    _grid[_column, _row, 2] = empty.ToString();
                                }
                                else
                                {
                                    MessageBox.Show(" Er Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                    BehemothResult = 1;//Tod
                                    fight = true;
                                }


                            }
                            else
                            {
                                MessageBox.Show(" Hast keine Bombe");
                                MessageBox.Show(" Der Behemoth Packt dich. Und spiesst dich auf seinen Stacheln auf");
                                BehemothResult = 1;//Tod
                                fight = true;
                            }
                        }
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show(" Du willst wegrennen, aber der Behemoth ist zu schnell, er packt dich. Und spiesst dich auf seinen Stacheln auf, du bist Tod");
                    BehemothResult = 1;//Tod
                    fight = true;
                }


            }
            #endregion
            #region Die Gestalt

          
            else if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos2 && panel.Image == Secret && count == 1 && encoun == 16)
            {
                MessageBox.Show(" Ja ist immer das Erste nein immer das Zweite");
                DialogResult dialogResult = MessageBox.Show("Ein Gestalt in der Grösse eines Mensches kommt auf dich zu, sie kommt immer schneller und schneller auf dich zu, du kannst ihr nicht entkommen, Kämpfen?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
               
                    DialogResult dialogResult2 = MessageBox.Show("Denn angriff Contern oder ausweichen. Ja = Contern Nein= Ausweichen", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {                    
                        DialogResult dialogResult3 = MessageBox.Show("Er kommt rasend schnell und trifft dich mit voller wucht. Doch hast du denn Angriff ohne grosse Probleme überstanden, was jetzt gehtst du ihn den Angriff oder in die Defensive?", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult3 == DialogResult.Yes)
                        {
                            DialogResult dialogResult4 = MessageBox.Show("Du nimmst deine Waffe und Schlägst nach der Gestalt. Deine Waffe geht sinkt in seinen Leib. Du merkst das seine Wunde anfängt zu schliessen. Angriff fortsetzen oder zurückweichen", "Some Title", MessageBoxButtons.YesNo);

                            if (dialogResult4 == DialogResult.Yes)
                            {
                                #region Fight

                              
                                chance = chance - 1;
                                DialogResult dialogResult5 = MessageBox.Show("Du nimmst deinen Dolch und stichst es ihm ins Gesicht. Plötzlich fälltst du um, er hat dich am Bein mit seiner Sense verletzt. Während du umfällst,siehst du ein Rotes Leuchten in einer Kurzen Entfernung. Versucht du dich dem Licht zu nähern oder schiesst du was dagegen. ", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult5 == DialogResult.Yes)
                                {
                                   MessageBox.Show("Du schreist auf wegen deiner Fussveletzung. Plötzlich wird alles Dunkel um dir. Die Gestalt hat seinen Speer in deine Brust gerammt. Du bist Tod");
                                    ZResult = 1;
                                    fight = true;
                                }
                                else if (dialogResult5 == DialogResult.No)
                                {
                                    #region Bomb

                             
                                    DialogResult dialogResult6 = MessageBox.Show("Schiesst du einer Bombe oder einen Feuerball.", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult6 == DialogResult.Yes && Bombe >= 0)
                                    {
                                        chance = chance - 1;

                                        DialogResult dialogResult7 = MessageBox.Show("Gerade als du die Bombe schmeisst sticht die Gestalt dir in den Körper, bricht jedoch ab als er sieht wohin die Bombe fliegt, er lässt von dir ab und rennt zur Bombe. Schmeisst du einen Feuerball hinterher", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult7 == DialogResult.Yes && Mana>=1)
                                        {
                                            MessageBox.Show("Du schiesst auf das Rote Licht, die Bombe und die Gestalt. Du triffst die Bombe, diese Explodiert und nimmt das Rote Licht mit sich. In dem moment wo das Rote Licht verschwindet, verschwindet auch die Gestalt. ");
                                            MessageBox.Show("Glückwunsch du hast denn Zweiten Boss geschlagen. Du solltest dich aber untersuchen Lassen(Leben auf 2)");
                                            ZResult = 2;
                                            fight = true;
                                            _grid[_column, _row, 2] = empty.ToString();
                                        }
                                    
                                        else if (dialogResult7 == DialogResult.No )
                                            {
                                            if (Mana == 0)
                                            {
                                                MessageBox.Show(" Du hast gar keine Mana");

                                            }
                                            MessageBox.Show(" Die Gestalt kann die Bombe rechtzeitig Löschen und kommt danach zu dir zurück. Er nimmt einen Hieb mit der Sense und Köpft dich. Du bist Tod!!!");
                                            ZResult = 1;
                                            fight = true;
                                        }

                                    }
                                    #endregion
                                    #region Spell
                                    else if (dialogResult6 == DialogResult.No || Bombe == 0)
                                    {
                                        if (Bombe == 0)
                                        {
                                            MessageBox.Show(" Du hast gar keine Bombe");

                                        }
                                        if (Mana>=4)
                                        {
                                          


                                            DialogResult dialogResult7 = MessageBox.Show("All dein Mana in einem Offensiven spruch brauchen. Oder ein wenig in einen Magieschield verwenden", "Some Title", MessageBoxButtons.YesNo);
                                            if (dialogResult7 == DialogResult.Yes)
                                            {
                                                if (Armor >= 15)
                                                {
                                                    MessageBox.Show("Deine Dicke Rüstung hat gerade dein Leben gerettet. Der Feuerball trifft das Licht, es verschwindet so auch die Gestalt ");
                                                    MessageBox.Show("Glückwunsch du hast denn Zweiten Boss geschlagen. Du solltest dich aber untersuchen Lassen(Leben auf 1)");
                                                    ZResult = 3;
                                                    fight = true;
                                                    _grid[_column, _row, 2] = empty.ToString();
                                                }
                                                else
                                                {
                                                    MessageBox.Show(" Die Gestalt rammt seinen Speer direkt durch dein Herz. du bist Tod(versuche nächstesmal mehr Mana zu haben)");
                                                    ZResult = 1;
                                                    fight = true;
                                                }
                                            }
                                            else if (dialogResult7 == DialogResult.No)
                                            {
                                                MessageBox.Show("Der Magische Schield hält gegen den Angriff stand. Der Feuerball trifft das Licht, es verschwindet so auch die Gestalt ");
                                                MessageBox.Show("Glückwunsch du hast denn Zweiten Boss geschlagen. Du solltest dich aber untersuchen Lassen(Leben auf 1)");
                                                ZResult = 4;
                                                fight = true;
                                                _grid[_column, _row, 2] = empty.ToString();

                                            }
                                           
                                        }
                                        else
                                        {
                                            MessageBox.Show(" Die Gestalt rammt seinen Speer direkt durch dein Herz. du bist Tod(versuche nächstesmal mehr Mana zu haben)");
                                            ZResult = 1;
                                            fight = true;
                                        }


                                    }
                                    #endregion
                                }
                                #endregion
                            }
                            else if (dialogResult4 == DialogResult.No)
                            {
                                DialogResult dialogResult5 = MessageBox.Show("Du siehst mit deinen Augen wie sich die Gestalt die Waffe aus dem Körper zieht. Währendessen verheilt die Wunde die ihm zugefügt hast. Greifts du ihn mit einer Bombe oder Magie an während er sich heilt.", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult5 == DialogResult.Yes&& Bombe>=0)
                                {
                                    #region Bombe

                                
                                    DialogResult dialogResult6 = MessageBox.Show("Die Gestalt wird in viele Teile gesprengt. jedoch sieht du das sich alle zueinander bewegen. In der Ferne siehst du ein Rotes Leuchten, gehts du zu dem Licht", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult6 == DialogResult.Yes)
                                    {
                                        #region Greed


                                        DialogResult dialogResult7 = MessageBox.Show("Das Licht war ein Roter Edelstein. Willst du ihn zerschmettern oder mitnehmen", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult7 == DialogResult.Yes)
                                        {
                                            MessageBox.Show("Nachdem du den Edelstein zerschmettert hast gehst du zurück zu der Gestalt, jedoch ist diese nirgends zu sehen. Es ist als wäre sie in Luft aufgelöst worden.", "Some Title", MessageBoxButtons.YesNo);
                                            MessageBox.Show("Glückwunsch du hast es Geschafft. Du hast die Begegnung unbeschadet überlebt.");
                                            ZResult = 4;
                                            fight = true;
                                            _grid[_column, _row, 2] = empty.ToString();
                                        }
                                        else if (dialogResult7 == DialogResult.No)
                                        {
                                            MessageBox.Show("Du nimmst den Edelstein und gehtst weiter in die Höhle. Plötlich verspürst du Schmerzen von deiner Bauchregion. Du sieht das durch dir ein Massiver Speer ragt. Du fällst um, hörst ein hemisches Lachen und stirbst.", "Some Title", MessageBoxButtons.YesNo);
                                            ZResult = 1;
                                            fight = true;
                                        }
                                        #endregion

                                    }
                                    else if (dialogResult6 == DialogResult.No)
                                    {
                                        #region Feuerball

                              
                                        DialogResult dialogResult7 = MessageBox.Show("Willst du einen Feuerball werfen.", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult7 == DialogResult.Yes)
                                        {
                                            if (Mana>0)
                                            {
                                                MessageBox.Show("Du schiesst den Feuerball, er fliegt in die Ferne. Du hörst ein klirren und siehst das sich die Gestalt auflöst.");
                                                MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Du hast die Begegnung unbeschadet überlebt.");
                                                ZResult = 5;
                                                fight = true;
                                                _grid[_column, _row, 2] = empty.ToString();
                                            }
                                            else
                                            {
                                                MessageBox.Show(" Die Gestalt steht auf und rammt seinen Speer direkt durch dein Herz. du bist Tod(versuche nächstesmal mehr Mana zu haben)");
                                                ZResult = 1;
                                                fight = true;
                                            }
                                           
                                        }
                                        else if (dialogResult7 == DialogResult.No)
                                        {

                                        }
                                        #endregion
                                    }
                                    #endregion
                                }
                                else if (dialogResult5 == DialogResult.No|| Bombe==0)
                                {
                                    #region fail

                                  
                                    if (Bombe == 0)
                                    {
                                        MessageBox.Show("Du hast keine Bombe");
                                    }
                                    MessageBox.Show("Du beginnst einen Zauber gegen die Gestalt zu wirken. Schade für dich ist nur, dass das zulange dauert. Er rammt seinen Speer in dein Herz, du bist Tod.");
                                    ZResult = 1;
                                    fight = true;
                                    #endregion
                                }
                            }

                        }
                        else if (dialogResult3 == DialogResult.No)
                        {
                        
                            DialogResult dialogResult4 = MessageBox.Show("Du gehst in eine defensive Stellung und versucht zu erahnen wann du dich verteidigen sollst. Er kommt mit voller Geschwindigkeit auf dich zu. Jetzt verteidigen und Kontern.", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult4 == DialogResult.Yes)
                            {
                                #region Light

                         
                                chance--;
                                DialogResult dialogResult5 = MessageBox.Show("Er kommt mit so einer Starken Wucht, dass es dich umwirft. Es füllt sich an als  hätte dich jemand mit einem Hammer getroffen. Jedoch merkst du das du auch ihn getroffen hast. Für einen Kurzen Moment siehst du ein Rotes Leuchten am Hals. Schlägst du mit deiner Waffe Dagegen oder Versuchst du dich aufzurappeln und zurückzuweichen ", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult5 == DialogResult.Yes)
                                {
                                    MessageBox.Show("Du stichst mit deiner Waffe direkt auf das Rote Licht, in dem moment wo du es triffst, wirst du durch eine Druckwelle zurück geworfen und prallst gegen eine Felsen. Du schreist for schmerzen auf, siehst jedoch das sich die Gesalt auflöst. ");
                                    MessageBox.Show("Glückwunsch du hast denn Zweiten Boss geschlagen. Du solltest dich aber untersuchen Lassen(Leben auf 2)");
                                    ZResult = 2;
                                    fight = true;
                                    _grid[_column, _row, 2] = empty.ToString();

                                }
                                else if (dialogResult5 == DialogResult.No)
                                {
                                    DialogResult dialogResult6 = MessageBox.Show("Während du zurückweichst, bemerkst du ein Zweites Rotes Licht. Willst du dich auf das Licht in der Ferne Konzentrieren oder das in der Gestalt  ", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult6 == DialogResult.Yes)
                                    {
                                        #region Feuerball und Bombe

                                     
                                        DialogResult dialogResult7 = MessageBox.Show("Wirst du einen Feuerball oder eine Bombe gegen das Licht ", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult7 == DialogResult.Yes|| Bombe==0 )
                                        {
                                            if (Mana==0)
                                            {
                                                MessageBox.Show("Du versuchst einen Feuerball zu werfen, jedoch kommt nichts. Du merkst du hast gar kein Mana. Pech für dich, die Gestalt kommt zu dir und spiesst dich auf. Du bist Tod ");
                                            
                                                ZResult = 1;
                                                fight = true;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Du schiesst den Feuerball, er fliegt in die Ferne. Du hörst ein klirren und siehst das sich die Gestalt auflöst.");
                                                MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Lass dich aber Trotzdem Untersuchen(Leben auf 3).");
                                                ZResult = 6;
                                                fight = true;
                                                _grid[_column, _row, 2] = empty.ToString();
                                            }

                                        }
                                        else if (dialogResult7 == DialogResult.No&& Bombe>=1)
                                        {
                                            MessageBox.Show("Du schmeisst die Bombe und siehst wie sie fliegt, leider wirst du die Explosion nicht sehen. Die Gestalt hat sich nähmlich erholt und Köpfte dich mit seiner Sense. Daher siehst du sie Wortwörtlich nicht, da du in den Boden schaust. Du bist Tod. ");
                                            ZResult = 1;
                                            fight = true;
                                        }
                                        #endregion
                                    }
                                    else if (dialogResult6 == DialogResult.No)
                                    {
                                        MessageBox.Show("Seit du ihn das Erstemal getroffen hast, schaut er genau drauf das du ihn nicht am Hals triffst, du jedoch erleidest immer mehr und mehr Wunden gegen ihn. Du bricht während den Kampf zusammen. Er nimmt seinen Speer und ersticht dich. Du bist Tod, aber hey er wird sich wenigsten an dich erinnern, weil du lange und fair gekämpft hast, zwar habe ich keine Ahnung was dir das bring aber Glückwünsch du bist tod ");

                                        ZResult = 1;
                                        fight = true;
                                    }

                                }
                                #endregion
                            }
                            else if (dialogResult4 == DialogResult.No)
                            {
                                DialogResult dialogResult5 = MessageBox.Show("Du weichst seinem Angriff aus und versucht danach gleich ihn anzugreiffen. Willst du mit Magie oder deinen Waffen ihn angreiffen", "Some Title", MessageBoxButtons.YesNo);
                                #region Magie

                             
                                if (dialogResult5 == DialogResult.Yes)
                                {
                                    DialogResult dialogResult6 = MessageBox.Show("Befor du einen Feuerball gegen ihn wirfst, siehst du ein Leuchten ihn der Ferne. Willst du statt auf die Gestalt, denn Feuerball auf das Leuchten schiessen", "Some Title", MessageBoxButtons.YesNo);

                                    if (dialogResult6 == DialogResult.Yes)
                                    {
                                        if (Mana == 0)
                                        {
                                            MessageBox.Show("Du versuchst einen Feuerball zu werfen, jedoch kommt nichts. Du merkst du hast gar kein Mana. Pech für dich, die Gestalt kommt zu dir und spiesst dich auf. Du bist Tod ");

                                            ZResult = 1;
                                            fight = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Du schiesst den Feuerball, er fliegt in die Ferne. Du hörst ein klirren und siehst das sich die Gestalt auflöst.");
                                            MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Und du hast keinen Schaden erlitten");
                                            ZResult = 5;
                                            fight = true;
                                            _grid[_column, _row, 2] = empty.ToString();
                                        }
                                  }
                                    else if (dialogResult6 == DialogResult.No)
                                    {
                                        MessageBox.Show("Der Feuerball scheint nicht viel bewirkt zu haben als, du auf die Grosse Wunde in deinem Bauch schaust, das ging woll daneben. Du bist Tod");
                                        ZResult = 1;
                                        fight = true;
                                    }
                                }
                                #endregion
                                #region Waffe

                             
                                else if (dialogResult5 == DialogResult.No)
                                {
                                    if (Schleif>=4)
                                    {

                                   
                                    MessageBox.Show("Die Gestalt stürmt wieder auf die zu, du nimmst den Speer und rammst in durch den oberen Teil des Halses. Plötzlich gibt es eine Druckwelle und die Gestalt ist verschwunden");
                                    MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Und du hast keinen Schaden erlitten");
                                     ZResult = 5;
                                    fight = true;
                                    _grid[_column, _row, 2] = empty.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Keiner deiner Waffen kann viel schaden veruhrsachen. nach einem langen Kampf tötet dich die gestalt mit seinem Speer(versuchs nächstesmal mit mehr schleifsteinen in deinem Inventar.)");
                                        ZResult = 1;
                                        fight = true;

                                    }
                                }
                                #endregion

                            }
                        }
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {

                       
                        DialogResult dialogResult3 = MessageBox.Show("Du weichst seinem Angriff aus und versucht danach gleich ihn anzugreiffen. Willst du mit Magie oder deinen Waffen ihn angreiffen", "Some Title", MessageBoxButtons.YesNo);
                        #region Magie


                        if (dialogResult3 == DialogResult.Yes)
                        {
                            DialogResult dialogResult4 = MessageBox.Show("Befor du einen Feuerball gegen ihn wirfst, siehst du ein Leuchten ihn der Ferne. Willst du statt auf die Gestalt, denn Feuerball auf das Leuchten schiessen", "Some Title", MessageBoxButtons.YesNo);

                            if (dialogResult4 == DialogResult.Yes)
                            {
                                if (Mana == 0)
                                {
                                    MessageBox.Show("Du versuchst einen Feuerball zu werfen, jedoch kommt nichts. Du merkst du hast gar kein Mana. Pech für dich, die Gestalt kommt zu dir und spiesst dich auf. Du bist Tod ");

                                    ZResult = 1;
                                    fight = true;
                                }
                                else
                                {
                                    MessageBox.Show("Du schiesst den Feuerball, er fliegt in die Ferne. Du hörst ein klirren und siehst das sich die Gestalt auflöst.");
                                    MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Und du hast keinen Schaden erlitten");
                                    ZResult = 5;
                                    fight = true;
                                    _grid[_column, _row, 2] = empty.ToString();
                                }
                            }
                            else if (dialogResult4 == DialogResult.No)
                            {
                                MessageBox.Show("Der Feuerball scheint nicht viel bewirkt zu haben als, du auf die Grosse Wunde in deinem Bauch schaust, das ging woll daneben. Du bist Tod");
                                ZResult = 1;
                                fight = true;
                            }
                        }
                        #endregion
                        #region Waffe


                        else if (dialogResult3 == DialogResult.No)
                        {
                            if (Schleif >= 4)
                            {


                                MessageBox.Show("Die Gestalt stürmt wieder auf die zu, du nimmst den Speer und rammst in durch den oberen Teil des Halses. Plötzlich gibt es eine Druckwelle und die Gestalt ist verschwunden");
                                MessageBox.Show("Glückwunsch du hast es Geschafft den Boss zu vernichten. Und du hast keinen Schaden erlitten");
                                ZResult = 5;
                                fight = true;
                                _grid[_column, _row, 2] = empty.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Keiner deiner Waffen kann viel schaden veruhrsachen. nach einem langen Kampf tötet dich die gestalt mit seinem Speer(versuchs nächstesmal mit mehr schleifsteinen in deinem Inventar.)");
                                ZResult = 1;
                                fight = true;

                            }
                        }
                        #endregion
                    }



                }
                    else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Ich hab doch gesagt du kannst der Gestalt nicht entkommen, oder wolltest du etwa sterben(du Bist Tod)");
                    ZResult = 1;
                    fight = true;
                }


            }
            #endregion
            ////////////////////////Bearbeiten
            #region Monster

      
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos3 && panel.Image == Secret && count == 1 && encoun == 17)
            {//Monster
                Points = 0;
                MessageBox.Show("Als du fich dem Ausgang der Kammer näherst, bebt auf einmal der Boden. Du kannst gerade noch ausweichen als eine Riesen Axt an dir vorbei in den Boden saust.");
                MessageBox.Show("Hier ist der dritte Boss, sein Kampf System ist ein wenig anders. je nach achtion bekommtst du Punkte. Du fängst bei 0 an, fällst du auf -10 dann bist du sofort tod. Bei 10 hast du sofort gewonnen.(Auch hier Fliehen geht nicht)");
                DialogResult dialogResult = MessageBox.Show("Blut an der Axt, von seinen Händen und von seinem Mund. Du glaubst du weisst was der Troll frisst. Wie willst du Kämpfen defensiv oder Offensiv ", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Willst du seine Angriffe Blocken oder ausweichen während dem Defensiven Kampf.", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {//
                        #region -10 Dead

                     
                        Points = Points - 10;
                        MessageBox.Show("-10 Punkt. Gut nachgedacht.");
                        //MessageBox.Show("Viel spass damit, er nimmt einen Hieb mit seiner Axt und Teilt dich in Zwei Stücke, du bist Tod.");
                        // MonsterResult = 1;
                        // fight = true;
                        #endregion
                    }
                    else if (dialogResult2 == DialogResult.No)
                    {
                        Points++;
                        //1
                        MessageBox.Show("+ 1 Punkt wegen guten Denken");
                        DialogResult dialogResult3 = MessageBox.Show("Bekämpfst du ihn mit Magie oder deinen Waffen", "Some Title", MessageBoxButtons.YesNo);
                        if (dialogResult3 == DialogResult.Yes)
                        {
                            //0
                            Points--;
                            MessageBox.Show("- 1 Punkt Trolle kümmern sich nicht um Magie. Verlier aber nicht die hoffnung");
                            DialogResult dialogResult4 = MessageBox.Show("Du hast etwa 10 Sekunden zeit(nicht zeit zum wählem.) zu regieren. Willst du einen Zauber gegen ihn anweden.(Falls du kein Mana hast spoiler du bist Tod)", "Some Title", MessageBoxButtons.YesNo);
                            if (Mana > 0)
                            {

                                if (dialogResult4 == DialogResult.Yes)
                                {
                                    DialogResult dialogResult5 = MessageBox.Show("Du kennst die Blitzlanze und den Feuerball, was benützt du.", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult5 == DialogResult.Yes)
                                    {//
                                        #region -5 Magie 1

                                       
                                        Points = Points - 5;
                                        MessageBox.Show("- 5 Punkte Trolle in meiner Welt haben stark Resitenz gegen Blitze wenn es um Schaden geht.");
                                        //-5
                                        MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                        Magie = 1;
                                        #endregion
                                    }
                                    else if (dialogResult5 == DialogResult.No)
                                    {//
                                        #region 5 Magie 1

                                       
                                        Points = Points + 5;
                                        MessageBox.Show("+ 5 Punkte Gut mitgelesen. Das Feuer frisst sich in seine Haut und lässt eine Wunde offen, was jetzt passiert zeigt die Punkte Wertung");
                                        //5
                                        MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                        Magie = 1;
                                        #endregion
                                    }

                                }
                                else if (dialogResult4 == DialogResult.No)
                                {//
                                    #region -10

                                    
                                    Points = Points - 10;
                                    MessageBox.Show("Ok weder zauber oder Waffen. Du versuchst Diplomatie. Tja das hat nicht so gut funktioniert. Du bist nähmlich Tod");
                                    #endregion
                                }
                            }
                            else
                            {//
                                #region -10
                                Points = Points - 10;
                                MessageBox.Show("- 10Punkte Hab dich gewarnt.(Minus 10 erreicht)");
                                #endregion
                            }
                            ////////////////////////////////////////////////
                        }
                        else if (dialogResult3 == DialogResult.No)
                        {
                            DialogResult dialogResult4 = MessageBox.Show("Bekämpfst du ihn mit Bomben oder deinen Waffen", "Some Title", MessageBoxButtons.YesNo);
                            if (dialogResult4 == DialogResult.Yes)
                            {

                                Points = Points + 2;
                                //3
                                MessageBox.Show("+ 2 Punkt Trolle mögen kein Feuer");
                                DialogResult dialogResult5 = MessageBox.Show("Wirfst du sie in Richtung der Beine oder des Kopfes", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult5 == DialogResult.Yes)
                                {
                                    if (Bombe > 0)
                                    {


                                        Points = Points + 1;
                                        //4
                                        MessageBox.Show("+ 1 Punkt Troll mag kein Feuer oder Explosionen daher plus 1, aber sonst keinen grossen effekt");
                                        DialogResult dialogResult6 = MessageBox.Show("Eine Weitere Bombe schmeissen", "Some Title", MessageBoxButtons.YesNo);
                                        Explo = 1;
                                        if (dialogResult6 == DialogResult.Yes)
                                        {
                                            if (Bombe > 1)
                                            {


                                                Points = Points - 6;
                                                Explo = 2;
                                                //-2
                                                MessageBox.Show("- 5 Punkte der Troll ist nicht beindruck von deiner Zweiten Bombe, er schlägt dich mit seinem Arm.");
                                                DialogResult dialogResult7 = MessageBox.Show("Du hast etwa 10 Sekunden zeit(nicht zeit zum wählem.) zu regieren. Willst du einen Zauber gegen ihn anweden.(Falls du kein Mana hast spoiler du bist Tod)", "Some Title", MessageBoxButtons.YesNo);
                                                if (Mana>0)
                                                {
                                           
                                                if (dialogResult7 == DialogResult.Yes)
                                                {
                                                        DialogResult dialogResult8 = MessageBox.Show("Du kennst die Blitzlanze und den Feuerball, was benützt du.", "Some Title", MessageBoxButtons.YesNo);
                                                        if (dialogResult8 == DialogResult.Yes)
                                                        {//
                                                            #region -7 Bombe 2 Magie 1

                                                         
                                                            Points = -7;
                                                            MessageBox.Show("- 5 Punkte Trolle in meiner Welt haben stark Resitenz gegen Blitze wenn es um Schaden geht.");
                                                            //-7
                                                            MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                            Magie = 1;
                                                            #endregion
                                                        }
                                                        else if (dialogResult8 == DialogResult.No)
                                                        {//
                                                            #region 3 Bombe 2 Magie 1

                                                         
                                                            Points = Points +5;
                                                            MessageBox.Show("+ 5 Punkte Gut mitgelesen. Das Feuer frisst sich in seine Haut und lässt eine Wunde offen, was jetzt passiert zeigt die Punkte Wertung");
                                                            //3
                                                            MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                            Magie = 1;
                                                            #endregion
                                                        }

                                                    }
                                                else if (dialogResult7 == DialogResult.No)
                                                    {//
                                                        #region -4 Bomb 2

                                                    
                                                        Points =  -4;
                                                        MessageBox.Show("-2 Punkte Der Troll hat sich schon von der Zweiten Bombe erholt. Was jetzt passiert zeigt die Punkte Wertung");
                                                        //-4
                                                        MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                        #endregion
                                                    }
                                                }
                                                else
                                                {//
                                                    #region -10

                                                    
                                                    Points = -10;
                                                    MessageBox.Show("- 8 Hab dich gewarnt.(Minus 10 erreicht)");
                                                    #endregion
                                                }
                                            }
                                            else
                                            {//
                                                #region -10

                                               
                                                Points = Points - 13;
                                                MessageBox.Show("- 14 Du merkst das du gar keine Bombe mehr hast. Luftbomben zählen nicht.(Minus 10 erreicht)");
                                                #endregion
                                            }

                                        }
                                        else if (dialogResult6 == DialogResult.No)
                                        {
                                            Points= Points+3;
                                            //7
                                            MessageBox.Show("+3 Punkt, der Troll ist immer noch von der Bombe betäubt");

                                            DialogResult dialogResult7 = MessageBox.Show("Greifst du sein Hand an oder seinen Beine.(Andere Teile des Körpers sind schwer zu erreichen)", "Some Title", MessageBoxButtons.YesNo);
                                            if (dialogResult7 == DialogResult.Yes)
                                            {//
                                                #region 10 Bombe 1

                                                
                                                Points = Points + 3;

                                                MessageBox.Show("Wow du hast ne 10, der Troll ist besiegt.(Er kann sich nicht mehr gross wehren). ");
                                                #endregion
                                            }
                                            else if (dialogResult7 == DialogResult.No)
                                            {//
                                                #region 9 Bombe 1

                                              
                                                Points = Points + 2;
                                                MessageBox.Show("+2 Punkte, er fällt zu Boden. ");
                                                MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                #endregion
                                            }
                                        }
                                    
                                }
                                else
                                    {//
                                        #region -10

                                       
                                        Points = Points - 13;
                                        MessageBox.Show("- 13 Punkte Du merkst das du gar keine Bombe mehr hast. Luftbomben zählen nicht.(Minus 10 erreicht)");
                                        #endregion
                                    }
                                }
                            else if (dialogResult5 == DialogResult.No)
                            {
                                    if (Bombe>0)
                                    {
                                        Points = Points - 5;
                                        //-2
                                        MessageBox.Show("- 5 Punkte Der Troll bemerkt die Fliegende Bombe und schlägt sie mit der Hand weg. Jetzt stürmt er auf dich zu");
                                        DialogResult dialogResult6 = MessageBox.Show("Du hast etwa 10 Sekunden zeit(nicht zeit zum wählem.) zu regieren. Willst du einen Zauber gegen ihn anweden.(Falls du kein Mana hast spoiler du bist Tod)", "Some Title", MessageBoxButtons.YesNo);
                                        if (Mana > 0)
                                        {
                                            if (dialogResult6 == DialogResult.Yes)
                                            {
                                                DialogResult dialogResult7 = MessageBox.Show("Du kennst die Blitzlanze und den Feuerball, was benützt du.", "Some Title", MessageBoxButtons.YesNo);
                                                if (dialogResult7 == DialogResult.Yes)
                                                {//
                                                    #region -7 Bomb 1 Magie 1

                                              
                                                    Points =  - 7;
                                                    MessageBox.Show("- 5 Punkte Trolle in meiner Welt haben stark Resitenz gegen Blitze wenn es um Schaden geht.");
                                                    //-7
                                                    MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                    Magie = 1;
                                                    #endregion
                                                }
                                                else if (dialogResult7 == DialogResult.No)
                                                {//
                                                    #region 3 Bombe 1 Magie 1

                                                  
                                                    Points = Points + 5;
                                                    MessageBox.Show("+ 5 Punkte Gut mitgelesen. Das Feuer frisst sich in seine Haut und lässt eine Wunde offen, was jetzt passiert zeigt die Punkte Wertung");
                                                    //3
                                                    MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                    Magie = 1;
                                                    #endregion
                                                }

                                            }
                                            else if (dialogResult6 == DialogResult.No)
                                            {//
                                                #region -4 Bombe 1

                                             
                                                Points =  - 4;
                                                MessageBox.Show("-2 Punkte Der Troll hat sich schon von der  Bombe erholt. Was jetzt passiert zeigt die Punkte Wertung");
                                                //-4
                                                MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                                #endregion
                                            }
                                        }
                                        else
                                        {//
                                            #region -10

                                          
                                            Points = -10;
                                            MessageBox.Show("- 8 Punkte Hab dich gewarnt.(Minus 10 erreicht)");
                                            #endregion
                                        }
                                    }
                                    else
                                    {//
                                        #region -10

                                      
                                        Points = Points - 13;
                                        MessageBox.Show("- 13 Punkte Du merkst das du gar keine Bombe mehr hast. Luftbomben zählen nicht.(Minus 10 erreicht)");
                                        #endregion
                                    }

                                }
                            }
                            else if (dialogResult4 == DialogResult.No)
                            {
                                Points = Points + 1;
                                MessageBox.Show("+1 Punkt für deinen Mut");
                                DialogResult dialogResult5 = MessageBox.Show("Greift du mit deinem Schwert an oder mit einer anderen Waffe", "Some Title", MessageBoxButtons.YesNo);
                                if (dialogResult5 == DialogResult.Yes)
                                {//
                                    #region -4

                                
                                    Points = Points - 6;
                                    MessageBox.Show("-6 Punkt Trolle haben ein sehr dicke Haut, viel spass diese zu verletzen");
                                    MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                    #endregion
                                }
                                else if (dialogResult5 == DialogResult.No)
                                {
                                    DialogResult dialogResult6 = MessageBox.Show("Greift du mit deinem Axt an oder mit einer anderen Waffe", "Some Title", MessageBoxButtons.YesNo);
                                    if (dialogResult5 == DialogResult.Yes)
                                    {//
                                        #region 4

                                       
                                        Points = Points +2 ;
                                        MessageBox.Show("+2 Punkt Zwar auch hier sehr dicke Haut aber Axt eignet sich besser wegen mehr Kraft auf einen Punkt");
                                        MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                        #endregion
                                    }
                                    else if (dialogResult6 == DialogResult.No)
                                    {                                                                        
                                        DialogResult dialogResult7 = MessageBox.Show("Greift du mit deinem Speer an oder mit dem Dolch", "Some Title", MessageBoxButtons.YesNo);
                                        if (dialogResult7 == DialogResult.Yes)
                                        {//
                                            #region 7
                                            Points = Points + 5;
                                            MessageBox.Show("+5 Punkt Man kann sich darum streiten. Aber beim Speer ist die ganze Wucht an einem Punkt");
                                            MessageBox.Show("Kampf bis zur Punkt bewertung abgeschlossen. Resultat ob du ihn getötet hast oder was auch immer passiert liesst du gleich. ");
                                            #endregion
                                        }
                                        else if (dialogResult7 == DialogResult.No)
                                        {//
                                            #region -10

                                        
                                            Points = Points -11;
                                            MessageBox.Show("- 11 Punkte Ja sicher, mit dem Dolch gegen einen Troll. kannst genau so gut mit Steinen werfen, oder mit der Pfanne drauf schlagen. Du bist Tod");
                                            #endregion
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    #region -10

                  
                    Points = Points - 10;
                    MessageBox.Show("Sorry fliehen geht nicht. 10Punkt du bist Tod");
                    #endregion
                }

                if (Points== -10|| Points == -9)
                {
                    if (Points == -9)
                    {
                        MessageBox.Show("Nach langem kämpfen hast du den Troll besiegt, aber du bist daraufhin auch gestorben");
                        fight = true;
                        MonsterResult = 1;
                    }
                    MessageBox.Show("Du bist Tod");
                }
                else if (Points >= -8 && Points<=-3)
                {
                    if (Explo==1 && Magie ==0)
                    {//no Bombe or Magic
                        MonsterResult = 5;
                    }
                    else if (Explo == 1 && Magie == 1)
                    {
                        MonsterResult = 7;
                    }
                    else if (Explo == 2 && Magie == 0)
                    {
                        MonsterResult = 9;
                    }
                    else if (Explo == 2 && Magie == 1)
                    {
                        MonsterResult = 11;
                    }
                    else if (Explo == 0 && Magie == 1)
                    {
                        MonsterResult = 13;
                    }
                    else
                    {//no Bombe or Magic
                        MonsterResult = 2;
                    }
                }
                else if (Points >= -2 && Points <= 4)
                {
                    if (Explo == 1 && Magie == 0)
                    {

                    }
                    else if (Explo == 1 && Magie == 1)
                    {
                        MonsterResult = 6;
                    }
                    else if (Explo == 2 && Magie == 0)
                    {

                    }
                    else if (Explo == 2 && Magie == 1)
                    {
                        MonsterResult = 10;
                    }
                    else if (Explo == 0 && Magie == 1)
                    {

                    }
                    else
                    {//no Bombe or Magic
                        MonsterResult = 4;

                    }
                }
                else if (Points >= 5 && Points <= 8)
                {
                    if (Explo == 1 && Magie == 0)
                    {

                    }
                    else if (Explo == 1 && Magie == 1)
                    {

                    }
                    else if (Explo == 2 && Magie == 0)
                    {

                    }
                    else if (Explo == 2 && Magie == 1)
                    {

                    }
                    else if (Explo == 0 && Magie == 1)
                    {
                        MonsterResult = 12;
                    }
                    else
                    {//no Bombe or Magic
                        MonsterResult = 3;
                    }
                }
                else if (Points == 9 || Points == 10)
                {
                    if (Explo == 1 && Magie == 0)
                    {
                        MonsterResult = 8;
                    }
                    else if (Explo == 1 && Magie == 1)
                    {

                    }
                    else if (Explo == 2 && Magie == 0)
                    {

                    }
                    else if (Explo == 2 && Magie == 1)
                    {

                    }
                    else if (Explo == 0 && Magie == 1)
                    {

                    }
                    else
                    {

                    }
                }




            }
            #endregion
            /*   DialogResult dialogResult = MessageBox.Show("Drachen Angriff willst du dich verteidigen", "Some Title", MessageBoxButtons.YesNo);
               if (dialogResult == DialogResult.Yes)
               {

               }
               else if (dialogResult == DialogResult.No)
               {

               }  */
            #region Drache

            
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos4 && panel.Image == Secret && count == 1 && encoun == 18)
            {//Drache
                MessageBox.Show("Vor dir steht ein Roter Drache, auf einmal fängt er an zu Reden << Ah ein Mensch, es ist schon eine Recht Lange Zeit seit einer von euch sich in meine Höhle verwirrt hat. Du willst sich weiter in die Höhle hinein. Solltest du Schmuck oder etwas in dieser Art besitzen, dann gib sie mir und ich lasse dich unbeschadet weiter gehen. Sonst wirst du halt mein Abendessen");



                DialogResult dialogResult = MessageBox.Show("Dem Drachen den Schmuck geben", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes&& tresure>=1)
                {                 
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    DragonResult=1;
                }
                else if (dialogResult == DialogResult.No|| tresure == 0)
                {
                    MessageBox.Show("Schade für dich, dann bekomme ich halt ein Abendessen");
////////////////////////////////////////////////////
                    DialogResult dialogResult2 = MessageBox.Show("Drachen Angriff willst du dich verteidigen", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {

                    }
                    else if (dialogResult2 == DialogResult.No)
                    {

                    }
                }



            }
            #endregion
            if (_grid[_column, _row, 1] == Player && _grid[_column, _row, 4] == Bos5 && panel.Image == Secret && count == 1 && encoun == 19)
            {//Entwickler
                DialogResult dialogResult = MessageBox.Show("Entwickler Angriff willst du dich verteidigen", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Armor >= 1 && Schleif >= 1)
                    {
                        MessageBox.Show("Du hast gewonnen, deine Ausrüstung hat aber ein wenig gelitten(-1 zu Schleifstein und -1 zu Armor))");
                        fight = true;


                        _grid[_column, _row, 2] = empty.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Du hast gewonnen, aber bist Verletzt(-2 zu Leben))");
                        fight = true;
                        _grid[_column, _row, 2] = empty.ToString();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("du erleidest auf der Flucht eine kleine Wunde(-1 zu Leben))");
                    fight = false;
                }
            }

            return fight;
        }
        #endregion
        #endregion
        #region Respawn      
        public PictureBox Death(Panel panMain, PictureBox panel, int _row, int _column, int lvl)
        {
            if (panel.Image == Secret)
            {
                _grid[_column, _row, 1] = null;
                panel.Image = null;
                p = 0;
                c = 0;
            }


            return panel;
        }

        public PictureBox Respawn(Panel panMain, PictureBox panel, int _row, int _column, int lvl)
        {
            if (lvl==2 && _grid[_column, _row, 1] == Player)
            {
                _grid[_column, _row, 1] = null;
                panel.Image = null;
                _grid[8, 6, 1] = Player;
                p = 0;
                c = 0;
            }   
            return panel;
        }
        #endregion
        #region Teleport
        public PictureBox Teleport(Panel panMain, PictureBox panel, int _row, int _column, int lvl)
        {
            if (lvl == 9 && _grid[_column, _row, 1] == Player && _grid[_column, _row, 0] == Farr)
            {
                if (_grid[8, 28, 0] == Farr&& _grid[8, 28, 1] == Player)
                {
                    _grid[_column, _row, 1] = null;
                   // panel.Image = null;
                    _grid[20, 30, 1] = Player;
                  //  p = 0;
                  //  c = 0;
                }
                else if (_grid[20, 29, 0] == Farr && _grid[20, 29, 1] == Player)
                {
                    _grid[_column, _row, 1] = null;
                    // panel.Image = null;
                    _grid[8, 29, 1] = Player;
                    //  p = 0;
                    //  c = 0;
                }

            }
           
            return panel;
        }
        #endregion
    }
}
