
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Collections;








namespace appa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string kullanicimsession = "";
        public int denemesayisi = 0;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                if (veritabani.LoginKontrol(txtpingir.Text))
                {

                    Form2 a = new Form2();
                    this.Hide();
                    a.Show();

                }
                else
                {
                    denemesayisi++;
                    if (denemesayisi == 3)
                    {
                        MessageBox.Show("3 defa hatalý giriþ yaptýnýz");
                        Application.Exit();
                    }

                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("Geçersiz Ýþlem!\n hata mesajý!" + exx.Message);

                throw;
            }
           

        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            Form3 uye = new Form3();
            uye.ShowDialog();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtpingir.Text.Length == 4)
                {

                }
                else
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
                    txtpingir.Text += btn.Text;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlýþ Bir Ýþlem Yaptýnýz.");

            }
        }
    }
}
