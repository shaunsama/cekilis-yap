using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static public string toplamKatilimci;
        static public string kazananTalihliler;
        static public string yedekTalihliler;
        static public string cekilisinIsmi;
        //int simdikiWith = 367;
        //int simdikiHeight = 283;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = toplamKatilimci;
            richTextBox1.Text = kazananTalihliler;
            richTextBox2.Text = yedekTalihliler;
            richTextBox3.Text = cekilisinIsmi;
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            
            toplamKatilimci = "";
            kazananTalihliler = "";
            yedekTalihliler = "";
            
           
            Form1 frm = new Form1();
            this.Visible = false;
            frm.ShowDialog();
            

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kapatmak istediğine emin misin ?", "Kapatmak istediğine emin misin ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
            
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
    }
}
