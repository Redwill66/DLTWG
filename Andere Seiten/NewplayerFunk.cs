using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameofLifedanielT
{
    class NewplayerFunk
    {
        public void User(string Name, string Surname, string Nummer)
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.newMemb())
            {


                conn.Parameters.AddWithValue("@Name", Name);
                conn.Parameters.AddWithValue("@Surname", Surname);



                bool isUserExisted = UsernameCheck(Nummer);

                if (isUserExisted)
                {
                    MessageBox.Show("MitgliedNr ist Vergeben");
                }
                else
                {
                    conn.Parameters.AddWithValue("@PlayerNr", Nummer);
                    conn.ExecuteNonQuery();




                }
            }
        }
        public bool UsernameCheck(string Nummer)
        {
            bool isUserExisted = false;
            DBfunk DBfunk = new DBfunk();
            SqlCommand cmd = DBfunk.NumberCheck();
            cmd.Parameters.AddWithValue("@PlayerNr", Nummer);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    isUserExisted = true;
                    break;
                }

            }
            return isUserExisted;
        }
        public object[] Fore()
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.LoadMem())
            {

                SqlDataReader reader;
                reader = conn.ExecuteReader();

                var Listt = new ListBox();
                while (reader.Read())
                {

                    Listt.Items.Add(reader[3].ToString() + "   " + reader[1].ToString() + "     " + reader[2].ToString());


                }
                object[] objCollection = new object[Listt.Items.Count];
                Listt.Items.CopyTo(objCollection, 0);
                return objCollection;
            }



        }
        public object[] Fore2()
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.LoadMem())
            {

                SqlDataReader reader;
                reader = conn.ExecuteReader();

                var Listt = new ListBox();
                while (reader.Read())
                {

                    Listt.Items.Add(reader[3].ToString() + "   " + reader[1].ToString() + "     " + reader[2].ToString());


                }
                object[] objCollection = new object[Listt.Items.Count];
                Listt.Items.CopyTo(objCollection, 0);
                return objCollection;
            }



        }
        public object[] Fore3(string text)
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.SerMembr())
            {
                conn.Parameters.AddWithValue("@PlayerNr", text);

                SqlDataReader reader;
                reader = conn.ExecuteReader();

                var Listt = new ListBox();
                while (reader.Read())
                {

                    Listt.Items.Add(reader[3].ToString() + "   " + reader[1].ToString() + "     " + reader[2].ToString());


                }
                object[] objCollection = new object[Listt.Items.Count];
                Listt.Items.CopyTo(objCollection, 0);
                return objCollection;
            }



        }
        public ListViewItem[] Fore4()
        {
            DBfunk dbClass = new DBfunk();
            using (var conn = dbClass.LoadMem())
            {

                SqlDataReader reader;
                reader = conn.ExecuteReader();

                var Listt = new ListBox();
                while (reader.Read())
                {

                    Listt.Items.Add(reader[3].ToString() + "   " + reader[1].ToString() + "     " + reader[2].ToString());


                }
                ListViewItem[] objCollection = new ListViewItem[Listt.Items.Count];
                Listt.Items.CopyTo(objCollection, 0);
                return objCollection;
            }



        } 
    }
}
