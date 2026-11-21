using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneyeYonelikProjeÖdevi
{
    public partial class Ayırtetmeden : Form
    {
        public Ayırtetmeden()
        {
            InitializeComponent();
        }

        ArrayList urunler = new ArrayList();
        ArrayList fiyat = new ArrayList();
        ArrayList fiyat1 = new ArrayList();
        private void Ayırtetmeden_Load(object sender, EventArgs e)
        {
            listBox4.SelectionMode = SelectionMode.None;
            listBox5.SelectionMode = SelectionMode.None;
        }

        public void fiyatlar()
        {
            if (listBox2.SelectedIndex == 0)
                fiyat1.Add(52.96f);
            else if (listBox2.SelectedIndex == 1)
                fiyat1.Add(100f);
            else if (listBox2.SelectedIndex == 2)
                fiyat1.Add(40.20f);
            else if (listBox2.SelectedIndex == 3)
                fiyat1.Add(80.60f);
            else if (listBox2.SelectedIndex == 4)
                fiyat1.Add(80.36f);
            else if (listBox2.SelectedIndex == 5)
                fiyat1.Add(46.95f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                urunler.Clear();
                fiyat.Clear();
                urunler.Add(listBox3.SelectedItem);
                fiyat.Add(listBox2.SelectedItem);

                fiyatlar();





                if (listBox3.SelectedIndex != listBox2.SelectedIndex)
                {
                    MessageBox.Show("Lutfen ürünün karşısındaki uygun fiyatı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var item in urunler)
                    {
                        listBox5.Items.Add(item);
                    }
                    foreach (var item in fiyat)
                    {
                        listBox4.Items.Add(item);
                    }
                    listBox3.ClearSelected();
                    listBox2.ClearSelected();
                }


            }
            catch
            {
                MessageBox.Show("Lutfen bir ürün ve fiyat seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public float Toplam()
        {
            float toplam = 0;
            foreach (var item in fiyat1)
            {
                toplam += (float)(item);
            }

            return toplam;
        }

        public double Vergi()
        {
            double vergi;
            float toplam = 0;
            foreach (var item in fiyat1)
            {
                toplam += (float)(item);
            }


            return vergi = toplam * 0.04;
        }

        public double VergiliFiyat()
        {
            double vergilifiyat;
            return vergilifiyat = Vergi() + Toplam();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Toplam() == 0)
            {
                MessageBox.Show("Lutfen ürün seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                label2.Text = Toplam().ToString("N2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Toplam() == 0)
            {
                MessageBox.Show("Lutfen ürün seçimi yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label2.Text != Toplam().ToString("N2"))
            {
                MessageBox.Show("Lutfen bir hesap yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label8.Text = Vergi().ToString("N2");
                label10.Text = VergiliFiyat().ToString("N2");
                MessageBox.Show("Ödeme yapıldı.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label8.Text = "0";
                label10.Text = "0";
                label2.Text = "0";
                listBox5.Items.Clear();
                listBox4.Items.Clear();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label11.Text == "-")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
