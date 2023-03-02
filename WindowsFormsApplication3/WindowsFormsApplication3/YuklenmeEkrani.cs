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
    public partial class YuklenmeEkrani : Form
    {
        public YuklenmeEkrani()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                panel2.Width += 2;
                if (panel2.Width >= 174)
                {
                    timer1.Stop();
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Visible = false;
                }

            }
            catch (Exception)
            {

                return;
            }
        }  
    }
}
