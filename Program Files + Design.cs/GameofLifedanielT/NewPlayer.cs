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
    public partial class frmNewPlayer : Form
    {
        private static string DLTW = Properties.Settings.Default.ConnectionString;
        public frmNewPlayer()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmstart fnp = new frmstart();
            Hide();
            fnp.ShowDialog();
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Bitte Vornamen eingeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Bitte Nachnamen eingeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtplayerNr.Text))
            {
                MessageBox.Show("Bitte Membernummer eingeben", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            NewplayerFunk newPlayFun = new NewplayerFunk();
            newPlayFun.User(txtname.Text, txtSurname.Text,  txtplayerNr.Text);
            lblsucsess.Text = "User Erfolgreich erstellt";

        }
    }
}
