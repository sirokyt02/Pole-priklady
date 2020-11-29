using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                int pocet = Convert.ToInt32(textBox1.Text);
                if(pocet!=0)
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();
                    listBox5.Items.Clear();
                    Random rnd = new Random();
                    int[] A = new int[pocet];
                    for(int i=0;i<pocet;i++)
                    {
                        A[i] = rnd.Next(100);
                        listBox1.Items.Add(Convert.ToString(A[i]));
                    }
                }
                else
                {
                    label2.Text = "Zadali jste, že chcete vygenerovat 0 čísel!";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Text = "Nebyl zadán počet čísel!";
                label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                int pocet = Convert.ToInt32(textBox2.Text);
                if (pocet != 0)
                {
                    label2.Visible = false;
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();
                    listBox5.Items.Clear();
                    Random rnd = new Random();
                    int[] B = new int[pocet];
                    for (int i = 0; i < pocet; i++)
                    {
                        B[i] = rnd.Next(100);
                        listBox2.Items.Add(Convert.ToString(B[i]));
                    }
                }
                else
                {
                    label2.Text = "Zadali jste, že chcete vygenerovat 0 čísel!";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Text = "Nebyl zadán počet čísel!";
                label2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lisone = listBox1.Items.Count;
            int listwo = listBox2.Items.Count;
            if((lisone!=0)||(listwo!=0))
            {
                listBox3.Items.Clear();
                label2.Visible = false;
                foreach(String cisilko in listBox1.Items)
                {
                    listBox3.Items.Add(cisilko);
                }
                foreach (String cisilko in listBox2.Items)
                {
                    listBox3.Items.Add(cisilko);
                }
            }
            else
            {
                label2.Text = "Nebyly vygenerovány množiny!";
                label2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int lisone = listBox1.Items.Count;
            int listwo = listBox2.Items.Count;
            if ((lisone != 0) || (listwo != 0))
            {
                listBox4.Items.Clear();
                label2.Visible = false;
                lisone += listwo;
                int[] poleA = new int [lisone];
                int poradi = 0;
                foreach (String cisilko in listBox1.Items)
                {
                    poleA[poradi] = Convert.ToInt32(cisilko);
                    poradi++;
                }
                foreach (String cisilko in listBox2.Items)
                {
                    poleA[poradi]=Convert.ToInt32(cisilko);
                    poradi++;
                }
                int[] poleB = poleA.Distinct().ToArray();
                foreach(int cisilko in poleB)
                {
                    listBox4.Items.Add(cisilko.ToString());
                }
            }
            else
            {
                label2.Text = "Nebyly vygenerovány množiny!";
                label2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int lisone = listBox1.Items.Count;
            int listwo = listBox2.Items.Count;
            if ((lisone != 0) || (listwo != 0))
            {
                listBox5.Items.Clear();
                label2.Visible = false;
                int prvni = 0,druhy = 0;
                foreach(String cisilko in listBox1.Items)
                {
                    prvni = Convert.ToInt32(cisilko);
                    foreach(String cislo in listBox2.Items)
                    {
                        druhy = Convert.ToInt32(cislo);
                        if (prvni == druhy) listBox5.Items.Add(cislo.ToString());
                    }
                }
            }
            else
            {
                label2.Text = "Nebyly vygenerovány množiny!";
                label2.Visible = true;
            }
        }
    }
}
