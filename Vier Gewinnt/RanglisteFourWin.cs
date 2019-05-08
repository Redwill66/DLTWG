using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    public partial class frmRanglisteFourWin : Form
    {
        public frmRanglisteFourWin()
        {
            InitializeComponent();
        }
        private static string DLTW = Properties.Settings.Default.ConnectionString;
        private void frmRanglisteFourWin_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DLTW))
            {
                con.Open();
                using (SqlDataAdapter dba = new SqlDataAdapter("SELECT PlayerNr,Vorname, Nachname, FourWin from Spieler ORDER BY FourWin ASC", con))

                {
                   
                    DataTable dt = new DataTable();
                    dba.Fill(dt);
                    //  conn.Parameters.AddWithValue("@MemberNr", text);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["FourWin"].ToString());
                       
                        listitem.SubItems.Add(dr["Vorname"].ToString());
                        listitem.SubItems.Add(dr["Nachname"].ToString());
                        listitem.SubItems.Add(dr["PlayerNr"].ToString());
                        lvwrangfourWin.Items.Add(listitem);
                        lvwrangfourWin.AllowColumnReorder = true;
                        lvwrangfourWin.Sorting = System.Windows.Forms.SortOrder.Ascending;
                        
                    }

                }
            }
                
            }

        private void lvwrangfourWin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();

        }
    }
}
