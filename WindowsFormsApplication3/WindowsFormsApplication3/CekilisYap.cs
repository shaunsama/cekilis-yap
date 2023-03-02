using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cekilisSay = 1;
        int yedekCekilisSay = 1;
        
        private void btnCekilisYap_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            List<string> ListKatilanlar = new List<string>(rTxtKatilanlar.Text.Split('\n'));
            int toplamKatilim = ListKatilanlar.Count;         
            Form2.toplamKatilimci = toplamKatilim.ToString();
            try
            {
                if (rTxtKatilanlar.Text == "" || rTxtKatilanlar.Text.StartsWith(" "))
                {
                    toplamKatilim = 0;
                    Form2.toplamKatilimci = toplamKatilim.ToString();
                }
                if (txtKazananSayisi.Text == "" || txtKazananSayisi.Text == "0" ||txtKazananSayisi.Text.StartsWith("00") || txtKazananSayisi.Text.StartsWith(" "))
                {
                    Form2.kazananTalihliler = "Katılımcı yok.";
                }
                else
                {

                    int kazanacakSayisi = Convert.ToInt32(txtKazananSayisi.Text);

                    for (int i = 0; i < kazanacakSayisi; i++)
                    {
                        int kazananKisi = rnd.Next(0, ListKatilanlar.Count);

                        if (ListKatilanlar.Count == 0)
                        {
                            Form2.kazananTalihliler += "\n" + cekilisSay++ + ". ";
                        }
                        else
                        {

                            if (comboBox1.SelectedIndex == 0)
                            {
                                Form2.kazananTalihliler += "\n" + cekilisSay++ + ". " + ListKatilanlar[kazananKisi];
                                ListKatilanlar.Remove(ListKatilanlar[kazananKisi]);

                            }
                            else
                            {
                                Form2.kazananTalihliler += "\n" + cekilisSay++ + ". " + ListKatilanlar[kazananKisi];
                                ListKatilanlar.Remove(ListKatilanlar[kazananKisi]);
                            }
                        }
                    }

                }

                if (txtYedekSayisi.Text == "" || txtYedekSayisi.Text == "0" || txtYedekSayisi.Text.StartsWith("00") || txtYedekSayisi.Text.StartsWith(" "))
                {
                    Form2.yedekTalihliler = "Katılımcı yok.";
                }
                else
                {
                    int yedekSayisi = Convert.ToInt32(txtYedekSayisi.Text);
                    for (int j = 0; j < yedekSayisi; j++)
                    {
                        int yedekKazananKisi = rnd.Next(0, ListKatilanlar.Count);

                        if (ListKatilanlar.Count != 0)
                        {
                            Form2.yedekTalihliler += "\n" + yedekCekilisSay++ + ". " + ListKatilanlar[yedekKazananKisi];
                            ListKatilanlar.Remove(ListKatilanlar[yedekKazananKisi]);
                        }
                        else
                        {
                            Form2.yedekTalihliler += "\n" + yedekCekilisSay++ + ". ";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Form2.kazananTalihliler = "Katılımcı yok.";
                Form2.yedekTalihliler = "Katılımcı yok.";

            }
           

            string cekilisIsmi = txtCekilisIsmi.Text;
            if (cekilisIsmi == "" || cekilisIsmi.StartsWith(" "))
            {
                Form2.cekilisinIsmi = "''İsimsiz Çekiliş'' çekilişine ait sonuçları aşağıda görebilirsiniz.";
                

            }
            else
            {
                Form2.cekilisinIsmi = "''" + cekilisIsmi + "''" + " çekilişine ait sonuçları aşağıda görebilirsiniz.";
            }
            Form2 frm = new Form2();
            this.Visible = false;
            frm.ShowDialog();
                          
        }
    

        private void btnCekilisYap_MouseMove(object sender, MouseEventArgs e)
        {
            btnCekilisYap.BackColor = Color.FromArgb(45, 206, 75);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kapatmak istediğine emin misin ?", "Kapatmak istediğine emin misin ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            rTxtKatilanlar.Focus();

        }
        private void rTxtKatilanlar_Enter(object sender, EventArgs e)
        {
            rTxtKatilanlar.ForeColor = Color.Black;
        }

        private void rTxtKatilanlar_Leave(object sender, EventArgs e)
        {
            rTxtKatilanlar.ForeColor = SystemColors.ControlDark;
        }

        private void txtCekilisIsmi_Enter(object sender, EventArgs e)
        {
            txtCekilisIsmi.ForeColor = Color.Black;
        }

        private void txtCekilisIsmi_Leave(object sender, EventArgs e)
        {
            txtCekilisIsmi.ForeColor = SystemColors.ControlDark;
        }

        private void txtKazananSayisi_Enter(object sender, EventArgs e)
        {
            txtKazananSayisi.ForeColor = Color.Black;
        }

        private void txtKazananSayisi_Leave(object sender, EventArgs e)
        {
            txtKazananSayisi.ForeColor = SystemColors.ControlDark;
        }

        private void txtYedekSayisi_Enter(object sender, EventArgs e)
        {
            txtYedekSayisi.ForeColor = Color.Black;
        }

        private void txtYedekSayisi_Leave(object sender, EventArgs e)
        {
            txtYedekSayisi.ForeColor = SystemColors.ControlDark;
        }
        private void btnCekilisYap_MouseLeave(object sender, EventArgs e)
        {
            btnCekilisYap.BackColor = Color.FromArgb(60, 212, 88);
        }
        
    }
}
