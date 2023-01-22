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
using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection.Emit;

using appa;

namespace appa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.kullanicimsession.ToString();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wbcl = new WebClient();
                Application.DoEvents();
                string getir = wbcl.DownloadString(textBox2.Text);
                textBox1.Text = getir;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İnternet Bağlantısı Gerçekleşemedi!\n hata mesajı!" + hata.Message);

                throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("Kaynak Kodu Kopyalandı.");
        }

       
    }
}
