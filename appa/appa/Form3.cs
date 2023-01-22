using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
        SQLiteDataReader dr;
        public static string SqlCon = "Data source=C:\\sqlitedbs\\Tablolar\\kullanicibilgi.db;Version=3;";
        private void kulkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SQLiteConnection(SqlCon);
                string sql = "insert into kulbilgi(adsoyad,pin,kayittarih)values(@a,@pass,@date)";
                cmd = new SQLiteCommand();

                cmd.Parameters.AddWithValue("a", txtkulad.Text);
                cmd.Parameters.AddWithValue("pass", veritabani.MD5Ssifrele(txtkulpin.Text));
                cmd.Parameters.AddWithValue("date", DateTime.Now);
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                veritabani.GridDoldur(dataGridView1, "select * from kulbilgi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veritabanı Bağlantısı Gerçekleşemedi!\n hata mesajı!" + hata.Message);
               

                throw;
            }  





        }

        private void btn_ksil_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SQLiteConnection(SqlCon);
                string sql = "delete from kulbilgi where adsoyad=@user and kID=@kulid";
                cmd = new SQLiteCommand();
                cmd.Parameters.AddWithValue("@user", txtkulad.Text);
                cmd.Parameters.AddWithValue("@kulid", Convert.ToInt32(txtkıd.Text));
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                veritabani.GridDoldur(dataGridView1, "select * from kulbilgi");

            }
            catch (Exception hata)
            {
                MessageBox.Show("Veritabanı Bağlantısı Gerçekleşemedi!\n hata mesajı!" + hata.Message);
                
                throw;
            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            veritabani.GridDoldur(dataGridView1, "select * from kulbilgi");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtkıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtkulad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtkulpin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            try
            {
                txtkulad.Clear();
                txtkulpin.Clear();
                txtkıd.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void btn_kulguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SQLiteConnection(SqlCon);
                string sql = "update kulbilgi set pin =@pass,adsoyad = @user where  kID =@kulid";
                cmd = new SQLiteCommand();

                cmd.Parameters.AddWithValue("@pass", veritabani.MD5Ssifrele(txtkulpin.Text));
                cmd.Parameters.AddWithValue("@user", txtkulad.Text);
                cmd.Parameters.AddWithValue("@kulid", Convert.ToInt32(txtkıd.Text));
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                con.Close();
                veritabani.GridDoldur(dataGridView1, "select * from kulbilgi");
            }
            catch (Exception)
            {

                throw;
            }  
        }
    }
}
