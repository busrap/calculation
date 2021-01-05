using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int dikdörtgen_alan(int sayı1,int sayı2)
        {
            int alan = sayı1 * sayı2;
            return alan;
        }
        private int dikdörtgen_cevre(int sayı1,int sayı2)
        {
            int cevre = 2 * (sayı1 + sayı2);

            return cevre;
        }
        private void button1_Click(object sender, EventArgs e)
        {/*
            dikgörtgen alan ve cevre hesaplama
             * **/

            if (txt_girilen_1.Text == string.Empty || txt_girilen_2.Text == string.Empty)
            {
                MessageBox.Show("Alanları boş bırakmayınız!");
            }


            if (txt_girilen_1.Text!=string.Empty && txt_girilen_2.Text!=string.Empty)
            {
                int girilensayı1 = Convert.ToInt32(txt_girilen_1.Text);
                int girilensayı2 = Convert.ToInt32(txt_girilen_2.Text);

                if (checkBox_alan_hesap.Checked)
                {
                    lbl_sonuc.Text = dikdörtgen_alan(girilensayı1, girilensayı2).ToString();
                }

                else if (chexbox_cevre_hesap.Checked)
                {
                    lbl_sonuc.Text = dikdörtgen_cevre(girilensayı1, girilensayı2).ToString();
                }

            }


            
        }

        private void checkBox_alan_hesap_CheckedChanged(object sender, EventArgs e)
        {
            chexbox_cevre_hesap.Checked = !checkBox_alan_hesap.Checked;
        }

        private void chexbox_cevre_hesap_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_alan_hesap.Checked = !chexbox_cevre_hesap.Checked;
        }
    }
}
