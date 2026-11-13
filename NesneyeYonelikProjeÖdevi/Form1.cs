using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace NesneyeYonelikProjeÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        float boy, kilo;
        float vki;



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            try
            {
                boy = int.Parse(textBox1.Text);
                kilo = int.Parse(textBox2.Text);

               
                if ((kilo < 30 || kilo > 550) && (boy < 100 || boy > 300))
                {
                    MessageBox.Show("Lutfen [30 - 550] kg arasi uygun bir kilo ve [100 - 300] cm arasi uygun bir boy giriniz.\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (kilo < 30 || kilo > 550)
                {
                    MessageBox.Show("Lutfen [30 - 550] kg arasi uygun bir kilo giriniz.\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (boy >= 100 && boy <= 300)
                    boy = boy / 100;
                else if (boy < 100 || boy > 300)
                {
                    MessageBox.Show("Lutfen [100 - 300] cm arasi uygun bir boy giriniz.\n", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
            }
            catch
            {
                MessageBox.Show("Lutfen boş bir değer girmeyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            vki = kilo / (boy * boy);


            if (vki <= 18.5)
            {
                f2.Show();
                this.Hide();
                ((Label)f2.Controls["label1"]).Text = ("VKİ degeriniz =  " + vki.ToString("N2"));
            }
            else if (vki > 18.5 && vki <= 25)
            {
                f3.Show();
                this.Hide();
                ((Label)f3.Controls["label1"]).Text = ("VKİ degeriniz =  " + vki.ToString("N2"));
            }
            else if (vki > 25 && vki <= 30)
            {
                f4.Show();
                this.Hide();
                ((Label)f4.Controls["label1"]).Text = ("VKİ degeriniz =  " + vki.ToString("N2"));
            }
            else if (vki > 30)
            {
                MessageBox.Show("VKI değeriniz ile obez aralıkları içindesiniz. Bir sağlik kuruluşuna başvurup, hekim ve diyetisyen kontrolünde zayıflayarak normal ağırlığa inmeniz sağlığınız açısından çok önemlidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

      
    
    } 

    
}
