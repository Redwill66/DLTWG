using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofLifedanielT
{
    class DBfunk
    {
        private static string DLTW = Properties.Settings.Default.ConnectionString;
        public SqlConnection Conect()
        {

            SqlConnection con = new SqlConnection(DLTW);
            con.Open();





            return con;



        }
        public SqlCommand newMemb()
        {

            string conns = (" INSERT INTO Spieler(Vorname, Nachname, PlayerNr,GameofLifeWin,ChessWin,FourWin,Minesweerpercom) VALUES(@Name, @Surname, @PlayerNr,0,0,0,0)");

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand rang()
        {

            string conns = ("SELECT Id,PlayerNr,Vorname, Nachname, FourWin from Spieler ");

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlDataAdapter List()
        {

            string conns = (" SELECT PlayerNr, Vorname, Nachname, FourWin from Spieler ORDER BY FourWin ASC");

            using (var conn = new SqlDataAdapter(conns, Conect()))
            {
                return conn;
            }
        }
       
        public SqlCommand NumberCheck()
        {

            string conns = (" Select PlayerNr from Spieler where PlayerNr= @PlayerNr");

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand LoadMem()
        {


            string conns = ("Select Id,Vorname,Nachname,PlayerNr from Spieler");
            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand SerMembr()
        {

            string conns = (" Select Id, Vorname, Nachname, PlayerNr from Spieler where PlayerNr = @PlayerNr Or Vorname = @PlayerNr OR Nachname = @PlayerNr");

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand Score()
        {

            string conns = ((" Update Spieler Set Fourwin= Fourwin+1 where PlayerNr=@PlayerNr"));

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        public SqlCommand Score2()
        {

            string conns = ((" Update Spieler Set Fourwin= Fourwin+1 where PlayerNr=@PlayerNr"));

            using (var conn = new SqlCommand(conns, Conect()))
            {
                return conn;
            }
        }
        //  using (SqlConnection connection = new SqlConnection(DLTW))


    }
}
