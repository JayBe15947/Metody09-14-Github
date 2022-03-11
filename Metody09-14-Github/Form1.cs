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

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = textBox5.Text;
            string s2;
            int pocetSlov = Swag.PocetSlov(s1, out s2);

            Swag.PocetSlov(s1, out s2);
            MessageBox.Show("Pocet slov: " + pocetSlov);
            MessageBox.Show("Retezec: " + s2);
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string s1 = textBox8.Text;
            string s2 = textBox9.Text;
            int pocetOdlisnychPozic = 0, prvniIndex = -1;
            bool identicke = Swag.Identicke(s1, s2, out pocetOdlisnychPozic, out prvniIndex);
            if (identicke) MessageBox.Show("Ano jsou identicke");
            else MessageBox.Show("Ne nejsou identicke");
            MessageBox.Show("Počet odlišných pozic: " + pocetOdlisnychPozic);
            MessageBox.Show("Prvni index: " + prvniIndex);
        }
    }
}
