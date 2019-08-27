using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class FourwinBuild
    {
        private int _row;
        private int _column;
        private const int CellSize = 70;
        private const int MaxRows = 99;
        private const int MaxColumns = 99;

        public const int size = 8;

        
        //   private const int CellSize = 10;
        private static int depth = 6;
        // public static List<Figure> Figures = new List<Figure>();

        private readonly string[,,] _grid = new string[MaxColumns, MaxRows, depth];
        private const string Free = "Free";
        private const string Button = "Button";
        private const string Play = "Play";
     
        public PictureBox GenerateGrid()
        {
            
            PictureBox panel = new PictureBox()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,

                BorderStyle = BorderStyle.FixedSingle

            };

            _grid[_column, _row, 0] = Free;

            panel.Location = new Point(_row * CellSize, _column * CellSize);
            return panel;
        }
        public Button GenerateGrid2()
        {

            Button panels = new Button()//Panel sind die Informationen der Einzelenen Panels definiert.
            {
                Name = "pan" + _row + _column,
                Height = CellSize,
                Width = CellSize,
                //BackColor= Color.Green

                //BorderStyle = BorderStyle.FixedSingle

            };

            _grid[_column, _row, 0] = Button;



          
            return panels;
        }
        public DataTable Befor()
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.LoadMem())
            {

                DataTablesFun dataTablesFunktions = new DataTablesFun();
                SqlDataReader reader;
                reader = conn.ExecuteReader();

                DataTable dt = dataTablesFunktions.dt();


                dt.Load(reader);

                return dt;
            }



        }
        public object[] ScoreFill(object[] ojc, int n)
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.Score())
            {
                ListBox ls = new ListBox();
                ls.Items.AddRange(ojc);
                //  conn.Parameters.AddWithValue("@MemberNr", text);
                var data = ls.Items.OfType<string>().Select(line => line.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                     .Select(items => new
                                     {
                                         PlayerNrL = items[0],
                                         Vorname = items[1],
                                         Nachname = items[2],
                                     });
                int b = 0;
                foreach (var item in data)
                {
                    if (n == b)
                    {
                        conn.Parameters.AddWithValue("@PlayerNr", SqlDbType.NVarChar).Value = item.PlayerNrL;
                        conn.ExecuteNonQuery();
                        break;
                    }
                    else
                    {
                        b++;
                    }
                }
                object[] objCollection = new object[ls.Items.Count];
                ls.Items.CopyTo(objCollection, 0);
                return objCollection;

            }
        }
        public object[] ScoreFill2(object[] ojc, int n)
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.Score())
            {
                ListBox ls = new ListBox();
                ls.Items.AddRange(ojc);
                //  conn.Parameters.AddWithValue("@MemberNr", text);
                var data = ls.Items.OfType<string>().Select(line => line.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                     .Select(items => new
                                     {
                                         PlayerNrL = items[0],
                                         Vorname = items[1],
                                         Nachname = items[2],
                                     });
                int b = 0;
                foreach (var item in data)
                {
                    if (n == b)
                    {
                        conn.Parameters.AddWithValue("@PlayerNr", SqlDbType.NVarChar).Value = item.PlayerNrL;
                        conn.ExecuteNonQuery();
                        break;
                    }
                    else
                    {
                        b++;
                    }
                }
                object[] objCollection = new object[ls.Items.Count];
                ls.Items.CopyTo(objCollection, 0);
                return objCollection;

            }
        }


    }

}
