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
    public partial class Form4 : Form
    {   
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (listBox1.SelectedIndex == 0)
            {
                meyveler f8 = new meyveler();
                f8.Show();
                this.Hide();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                sebzeler f9 = new sebzeler();
                f9.Show();
                this.Hide();

            }
            else if (listBox1.SelectedIndex == 2)
            {
                Ayırtetmeden f6 = new Ayırtetmeden();
                f6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lutfen bir seçim yapınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
