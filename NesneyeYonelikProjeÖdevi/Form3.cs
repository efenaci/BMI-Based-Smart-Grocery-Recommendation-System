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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        















        
        private void button1_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == 0)
            {
                sağlıklıurunler f5 = new sağlıklıurunler();
                f5.Show();
                this.Hide();

            }
            else if (listBox1.SelectedIndex == 1)
            {
                Kaskütlesi f7 = new Kaskütlesi();
                f7.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lutfen bir seçim yapınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
