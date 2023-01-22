using HtmlAgilityPack;
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
using System.Xml;
using System.Net;
using System.IO;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using System.DirectoryServices.ActiveDirectory;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Data.SQLite;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Reflection.Emit;

namespace appa
{
    public partial class Form5 : Form
    {
        public string html;
        public Uri url;
        public Form5()
        {
            InitializeComponent();
        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.kullanicimsession.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                WebClient wbcl = new WebClient();
                Application.DoEvents();
                string getir = wbcl.DownloadString(textBox1.Text);
                textBox2.Text = getir;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Html Kodları Getirilecek link girilmedi.!");


                
            }

           
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string htmlCode = textBox2.Text;      
            string pattern3 = @"https[^""]*\/product[^""]*""";  //                  media mark
            string pattern5 = @"div class=""p-card-chldrn-cntnr card-border""[^>]*>\s*<a\s+(?:[^>]*?\s+)?href=""[^""]*""";  // trendyol

            try
            {
                Regex regex = new Regex(pattern5);
                MatchCollection matches = regex.Matches(htmlCode);
                foreach (Match match in matches)
                {
                    listBox1.Items.Add(match.Value);
                    if (match.Success)
                    {
                        string divContent = match.Groups[0].Value;
                        pattern5 = @"<a href='.*?'>";
                        regex = new Regex(pattern5);
                        MatchCollection linkMatches = regex.Matches(divContent);
                        foreach (Match linkMatch in linkMatches)
                        {
                            string link = linkMatch.Value;
                            listBox1.Items.Add(link);
                        }
                    }

                }
                string[] items = listBox1.Items.Cast<string>().ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = items[i].Substring(53);

                }
                listBox1.Items.Clear();
                foreach (string item in items)
                {
                    listBox1.Items.Add(item);

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Html Kodları Mevcut Düzende Degil.!" );


                
            }


            

           




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.SelectedItem.ToString();

            try
            {
                string deger = textBox3.Text;

                textBox3.Text = "https://www.trendyol.com" + deger;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Listeden Link Seçilmedi!\n hata mesajı!" );


              
            }
            
            


           


        }


        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                WebClient wbcl = new WebClient();
                Application.DoEvents();
                string getir = wbcl.DownloadString(textBox3.Text);
                textBox4.Text = getir;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Listeden Link Seçilmedi!");


                
            }
            
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string htmlCode = textBox4.Text;

            string pattern3 = @"https[^""]*\/product[^""]*""";
                                                               
            string pattern2 = @"class=""seller-name-text""[^>]*title=""([^""]*)""";
            try
            {
                Regex regex = new Regex(pattern2);
                MatchCollection matches = regex.Matches(htmlCode);
                foreach (Match match in matches)
                {
                    listBox2.Items.Add(match.Value);
                    if (match.Success)
                    {
                        string divContent = match.Groups[0].Value;
                        pattern2 = @"<a href='.*?'>";
                        regex = new Regex(pattern2);
                        MatchCollection linkMatches = regex.Matches(divContent);
                        foreach (Match linkMatch in linkMatches)
                        {
                            string link = linkMatch.Value;
                            listBox1.Items.Add(link);
                        }
                    }


                }
                string[] items = listBox2.Items.Cast<string>().ToArray();
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = items[i].Substring(31);

                }
                listBox2.Items.Clear();
                foreach (string item in items)
                {
                    listBox2.Items.Add(item);

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Satıcıların Getirilecegi Html Kodları Girilmedi.!");


                
            }


           
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }
    }
}


//public void verial(String Url,String Xpath,ListBox list1) {

//    try
//    {
//        url = new Uri(Url);
//    }
//    catch (UriFormatException)
//    {
//        if (MessageBox.Show("hatalı url1","hata",MessageBoxButtons.OK,MessageBoxIcon.Error) == DialogResult.OK)
//        {

//        }

//    }

//    catch (ArgumentNullException)
//    {
//        if (MessageBox.Show("hatalı url1", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
//        {

//        }

//    }

//    WebClient client = new WebClient();
//    client.Encoding = Encoding.UTF8;

//    try
//    {
//        html = client.DownloadString(url);

//    }
//    catch (WebException)
//    {
//        if (MessageBox.Show("hatalı url2", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
//        {

//        }

//    }

//    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
//    doc.LoadHtml(html);

//    try
//    {
//        try
//        {
//            MessageBox.Show((doc.DocumentNode.SelectSingleNode(Xpath).InnerText));
//        }
//        catch (NullReferenceException)
//        {
//            MessageBox.Show("The XPath did not match any elements in the HTML document", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }



//    }
//    catch (NullReferenceException)
//    {
//        if (MessageBox.Show("hatalı xpath", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
//        {

//        }


//    }


//}