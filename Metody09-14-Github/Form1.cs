using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14_Github
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double x1, x2, diskriminant;
            Swag.Diskriminant(a, b, c, out x1, out x2, out diskriminant);
            if (diskriminant < 0) MessageBox.Show("Rovnice nemá řešení v R");
            else if (diskriminant > 0) MessageBox.Show("Rovnice má 2 kořeny");
            else MessageBox.Show("Rovnice má jeden dvojnásobný kořen " + x1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string retezec = textBox4.Text;
            int cifSoucet = 0, soucetLichCif = 0, soucetSudCif = 0;
            if (Swag.ObsahujeCislici(retezec, out cifSoucet, out soucetLichCif, out soucetSudCif))
            {
                MessageBox.Show("Obsahuje číslici");
                MessageBox.Show("Ciferný součet: " + cifSoucet);
                MessageBox.Show("Ciferný součet lichých čísel: " + soucetLichCif);
                MessageBox.Show("Ciferný součet sudých čísel: " + soucetSudCif);
            }
        }
    }
}
