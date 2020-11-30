using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label2.Visible = false;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                int pocet = Convert.ToInt32(textBox1.Text);
                if (pocet != 0)
                {
                    Random rnd = new Random();
                    int[] pole = new int[pocet];
                    int min = int.MaxValue, max = int.MinValue, poradimax = 0, poradimin = 0;
                    for (int i = 0; i < pocet; i++)
                    {
                        int cislo = rnd.Next(50, 250);
                        pole[i] = cislo;
                        if (cislo < min) { min = cislo; poradimin = i; }
                        if (cislo > max) { max = cislo; poradimax = i; }
                    }
                    double prumer = 0;
                    foreach (int cisilko in pole)
                    {
                        listBox1.Items.Add(Convert.ToString(cisilko));
                        prumer += cisilko;
                    }
                    if (pocet < 3)
                    {
                        label2.Text = "Průměr nelze zobrazit!";
                        label2.Visible = true;
                    }
                    else
                    {
                        prumer -= min; prumer -= max;
                        prumer /= (pocet - 2);
                        label2.Text = "Průměr bez min a max čísla: " + Convert.ToString(prumer);
                        label2.Visible = true;
                    }
                    pole[poradimin] = max;
                    pole[poradimax] = min;
                    foreach (int cisilko in pole)
                    {
                        listBox2.Items.Add(Convert.ToString(cisilko));
                    }
                }
                else
                {
                    label2.Text = "Zadali jste, že chcete vytvořit 0 prvků!";
                    label2.Visible = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                }
            }
            else
            {
                label2.Text = "Nebyl zadán počet!";
                label2.Visible = true;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }
    }
}
