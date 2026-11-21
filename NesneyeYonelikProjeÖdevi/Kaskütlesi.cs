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
    public partial class Kaskütlesi : Form
    {
        public Kaskütlesi()
        {
            InitializeComponent();
        }

        ArrayList urunler = new ArrayList();
        ArrayList fiyat = new ArrayList();
        ArrayList fiyat1 = new ArrayList();

        private void Kaskütlesi_Load(object sender, EventArgs e)
        {
            listBox4.SelectionMode = SelectionMode.None;
            listBox5.SelectionMode = SelectionMode.None;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
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


            return vergi = toplam * 0.056;
        }

        public void fiyatlar()
        {
            if (listBox2.SelectedIndex == 0)
                fiyat1.Add(300f);
            else if (listBox2.SelectedIndex == 1)
                fiyat1.Add(50.70f);
            else if (listBox2.SelectedIndex == 2)
                fiyat1.Add(70.80f);
            else if (listBox2.SelectedIndex == 3)
                fiyat1.Add(60.40f);
            else if (listBox2.SelectedIndex == 4)
                fiyat1.Add(40.25f);
            else if (listBox2.SelectedIndex == 5)
                fiyat1.Add(50.90f);
            else if (listBox2.SelectedIndex == 6)
                fiyat1.Add(50.20f);
            else if (listBox2.SelectedIndex == 7)
                fiyat1.Add(40.80f);
            else if (listBox2.SelectedIndex == 8)
                fiyat1.Add(100.90f);
            else if (listBox2.SelectedIndex == 9)
                fiyat1.Add(50f);
            else if (listBox2.SelectedIndex == 10)
                fiyat1.Add(150.25f);
        }

        public double VergiliFiyat()
        {
            double vergilifiyat;
            return vergilifiyat = Vergi() + Toplam();

        }
        private void button3_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (Toplam() == 0)
            {
                MessageBox.Show("Lutfen ürün seçimi yapınız.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                label2.Text = Toplam().ToString("N2");

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
    }
}
