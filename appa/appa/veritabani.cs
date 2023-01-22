using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Data.SqlClient;

using appa;

namespace appa
{
    class veritabani
    {
        static SQLiteConnection con;
        static SQLiteDataAdapter da;
        static SQLiteCommand cmd;
        static DataSet ds;
        static SQLiteDataReader dr;
        public static string SqlCon = "Data source=C:\\sqlitedbs\\Tablolar\\kullanicibilgi.db;Version=3;";


        public static bool baglantidurum()
        {
            string Sqlcon = "Data source=C:\\sqlitedbs\\Tablolar\\kullanicibilgi.db;Version=3;";
            using (var baglan = new SQLiteConnection(Sqlcon))
            {

                try
                {
                    baglan.Open();
                    MessageBox.Show("Veritabanı Bağlantısı Gerçekleşti.");
                    return true;
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Veritabanı Bağlantısı Gerçekleşemedi!\n hata mesajı!" + hata.Message);
                    throw;
                }

            }

        }

        public static DataGridView GridDoldur(DataGridView gridim, string SqlSelectSorgu)
        {
            con = new SQLiteConnection(SqlCon);
            da = new SQLiteDataAdapter(SqlSelectSorgu, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, SqlSelectSorgu);

            gridim.DataSource = ds.Tables[SqlSelectSorgu];
            con.Close();

            return gridim;

        }



        public static string MD5Ssifrele(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            //dizi yani girilen metnin ya da rakamların değeri çıkartılıyor
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in dizi)
            {
                sb.Append(item.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        public static bool LoginKontrol(string password)
        {
            string sorgu = "select * from kulbilgi where pin=@pinn";

            con = new SQLiteConnection(SqlCon);
            cmd = new SQLiteCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@pinn", veritabani.MD5Ssifrele(password));

            con.Open();

            dr = cmd.ExecuteReader();
            //Eğer veri geldiyse

            if (dr.Read())
            {
                Form1.kullanicimsession = dr["adsoyad"].ToString();

                con.Close();
                return true;
                MessageBox.Show("Tebrikler.Giriş Yaptınız..");
            }
            else
            {
                con.Close();
                return false;

                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");


            }

        }

        static SQLiteConnection baglanti = new SQLiteConnection("Data source=C:\\sqlitedbs\\Tablolar\\kullanicibilgi.db;Version=3;");

        public static void errorperovidergetir(TextBox text, ErrorProvider erpr)
        {
            if (text.Text.Trim() == "")
                erpr.SetError(text, "Bu Alan Boş Geçilmez!!");
            else
                erpr.SetError(text, "");

        }


    }
}





