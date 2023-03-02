namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCekilisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCekilisIsmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYedekSayisi = new System.Windows.Forms.TextBox();
            this.txtKazananSayisi = new System.Windows.Forms.TextBox();
            this.rTxtKatilanlar = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCekilisYap
            // 
            this.btnCekilisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(212)))), ((int)(((byte)(88)))));
            this.btnCekilisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCekilisYap.FlatAppearance.BorderSize = 0;
            this.btnCekilisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCekilisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(206)))), ((int)(((byte)(75)))));
            this.btnCekilisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekilisYap.ForeColor = System.Drawing.Color.White;
            this.btnCekilisYap.Location = new System.Drawing.Point(26, 227);
            this.btnCekilisYap.Name = "btnCekilisYap";
            this.btnCekilisYap.Size = new System.Drawing.Size(678, 35);
            this.btnCekilisYap.TabIndex = 6;
            this.btnCekilisYap.Text = "KAZANANLARI BELİRLE";
            this.btnCekilisYap.UseVisualStyleBackColor = false;
            this.btnCekilisYap.Click += new System.EventHandler(this.btnCekilisYap_Click);
            this.btnCekilisYap.MouseLeave += new System.EventHandler(this.btnCekilisYap_MouseLeave);
            this.btnCekilisYap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCekilisYap_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Katılımcı Listesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(22, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Her satıra 1 katılımcı gelecek şekilde ekleyin.";
            // 
            // txtCekilisIsmi
            // 
            this.txtCekilisIsmi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCekilisIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCekilisIsmi.Location = new System.Drawing.Point(25, 47);
            this.txtCekilisIsmi.Multiline = true;
            this.txtCekilisIsmi.Name = "txtCekilisIsmi";
            this.txtCekilisIsmi.Size = new System.Drawing.Size(678, 35);
            this.txtCekilisIsmi.TabIndex = 2;
            this.txtCekilisIsmi.Enter += new System.EventHandler(this.txtCekilisIsmi_Enter);
            this.txtCekilisIsmi.Leave += new System.EventHandler(this.txtCekilisIsmi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Çekiliş İsmi (Opsiyonel):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kazanacak Kişi Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(371, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Yedek Kişi Sayısı:";
            // 
            // txtYedekSayisi
            // 
            this.txtYedekSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYedekSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYedekSayisi.Location = new System.Drawing.Point(375, 119);
            this.txtYedekSayisi.MaxLength = 999999999;
            this.txtYedekSayisi.Multiline = true;
            this.txtYedekSayisi.Name = "txtYedekSayisi";
            this.txtYedekSayisi.Size = new System.Drawing.Size(328, 35);
            this.txtYedekSayisi.TabIndex = 4;
            this.txtYedekSayisi.Enter += new System.EventHandler(this.txtYedekSayisi_Enter);
            this.txtYedekSayisi.Leave += new System.EventHandler(this.txtYedekSayisi_Leave);
            // 
            // txtKazananSayisi
            // 
            this.txtKazananSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKazananSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKazananSayisi.Location = new System.Drawing.Point(25, 119);
            this.txtKazananSayisi.MaxLength = 999999999;
            this.txtKazananSayisi.Multiline = true;
            this.txtKazananSayisi.Name = "txtKazananSayisi";
            this.txtKazananSayisi.Size = new System.Drawing.Size(326, 35);
            this.txtKazananSayisi.TabIndex = 3;
            this.txtKazananSayisi.Enter += new System.EventHandler(this.txtKazananSayisi_Enter);
            this.txtKazananSayisi.Leave += new System.EventHandler(this.txtKazananSayisi_Leave);
            // 
            // rTxtKatilanlar
            // 
            this.rTxtKatilanlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtKatilanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtKatilanlar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rTxtKatilanlar.Location = new System.Drawing.Point(24, 63);
            this.rTxtKatilanlar.Name = "rTxtKatilanlar";
            this.rTxtKatilanlar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rTxtKatilanlar.ShowSelectionMargin = true;
            this.rTxtKatilanlar.Size = new System.Drawing.Size(678, 149);
            this.rTxtKatilanlar.TabIndex = 0;
            this.rTxtKatilanlar.Text = "";
            this.rTxtKatilanlar.Enter += new System.EventHandler(this.rTxtKatilanlar_Enter);
            this.rTxtKatilanlar.Leave += new System.EventHandler(this.rTxtKatilanlar_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 691;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 25;
            this.comboBox1.Items.AddRange(new object[] {
            "Yalnızca 1 katılım hakkı olsun",
            "Birden fazla katılım hakkı olsun"});
            this.comboBox1.Location = new System.Drawing.Point(26, 186);
            this.comboBox1.MaxDropDownItems = 15;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(678, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(1)))), ((int)(((byte)(27)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(719, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 25;
            this.button1.TabStop = false;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(685, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "_";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCekilisIsmi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btnCekilisYap);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtKazananSayisi);
            this.panel3.Controls.Add(this.txtYedekSayisi);
            this.panel3.Location = new System.Drawing.Point(12, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 265);
            this.panel3.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tekrar eden katılımcılar:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rTxtKatilanlar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 215);
            this.panel2.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(753, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çekiliş Yap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCekilisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCekilisIsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYedekSayisi;
        private System.Windows.Forms.RichTextBox rTxtKatilanlar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKazananSayisi;
    }
}

