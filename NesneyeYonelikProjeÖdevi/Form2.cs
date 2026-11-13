using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
               
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == 0)
            {
                sağlıklıurunler f5 = new sağlıklıurunler();
                f5.Show();
                this.Hide();
                ((Label)f5.Controls["label12"]).Text = "-";

            }
            else if (listBox1.SelectedIndex == 1)
            {
                Ayırtetmeden f6 = new Ayırtetmeden();
                f6.Show();
                this.Hide();
                ((Label)f6.Controls["label11"]).Text = "-";
            }
            else
            {
                MessageBox.Show("Lutfen bir seçim yapınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

   
}
