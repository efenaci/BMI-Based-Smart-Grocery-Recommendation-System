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
    public partial class sebzeler : Form
    {
        public sebzeler()
        {
            InitializeComponent();
        }

        ArrayList urunler = new ArrayList();
        ArrayList fiyat = new ArrayList();
        ArrayList fiyat1 = new ArrayList();
        private void sebzeler_Load(object sender, EventArgs e)
        {
            listBox4.SelectionMode = SelectionMode.None;
            listBox5.SelectionMode = SelectionMode.None;
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

        public void fiyatlar()
        {
            if (listBox2.SelectedIndex == 0)
                fiyat1.Add(30.50f);
            else if (listBox2.SelectedIndex == 1)
                fiyat1.Add(15.20f);
            else if (listBox2.SelectedIndex == 2)
                fiyat1.Add(17.80f);
            else if (listBox2.SelectedIndex == 3)
                fiyat1.Add(50.90f);
            else if (listBox2.SelectedIndex == 4)
                fiyat1.Add(60.70f);
            else if (listBox2.SelectedIndex == 5)
                fiyat1.Add(80f);

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

        public double Vergi()
        {
            double vergi;
            float toplam = 0;
            foreach (var item in fiyat1)
            {
                toplam += (float)(item);
            }


            return vergi = toplam * 0.069;
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

        private void label4_Click(object sender, EventArgs e)
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
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
