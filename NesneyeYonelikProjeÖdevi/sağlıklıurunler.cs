using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace NesneyeYonelikProjeÖdevi
{
    public partial class sağlıklıurunler : Form
    {
        public sağlıklıurunler()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void fiyatlar()
        {
            if (listBox2.SelectedIndex == 0)
                fiyat1.Add(50.60f);
            else if (listBox2.SelectedIndex == 1)
                fiyat1.Add(50.50f);
            else if (listBox2.SelectedIndex == 2)
                fiyat1.Add(40.90f);
            else if (listBox2.SelectedIndex == 3)
                fiyat1.Add(25.90f);
            else if (listBox2.SelectedIndex == 4)
                fiyat1.Add(40.50f);
            else if (listBox2.SelectedIndex == 5)
                fiyat1.Add(30.90f);
            else if (listBox2.SelectedIndex == 6)
                fiyat1.Add(40.25f);
        }
        

        ArrayList urunler = new ArrayList();
        ArrayList fiyat = new ArrayList();
        ArrayList fiyat1 = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                urunler.Clear();
                fiyat.Clear();
                urunler.Add(listBox1.SelectedItem);
                fiyat.Add(listBox2.SelectedItem);

                fiyatlar();




                if (listBox1.SelectedIndex != listBox2.SelectedIndex)
                {
                    MessageBox.Show("Lutfen ürünün karşısındaki uygun fiyatı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var item in urunler)
                    {
                        listBox3.Items.Add(item);
                    }
                    foreach (var item in fiyat)
                    {
                        listBox4.Items.Add(item);
                    }
                    listBox1.ClearSelected();
                    listBox2.ClearSelected();
                }

            }
            catch
            {
                MessageBox.Show("Lutfen bir ürün ve fiyat seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public float Toplam()
        {
            float toplam = 0;
            foreach (var item in fiyat1)
            {
                toplam += (float)(item);
            }



            return toplam;
        }
        public double VergiliFiyat()
        {
            double vergilifiyat;
            return vergilifiyat = Vergi() + Toplam();

        }


        private void sağlıklıurunler_Load(object sender, EventArgs e)
        {
            listBox3.SelectionMode = SelectionMode.None;
            listBox4.SelectionMode = SelectionMode.None;
        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (label12.Text == "-")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
