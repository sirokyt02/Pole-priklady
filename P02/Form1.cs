using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
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
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                int pocet = Convert.ToInt32(textBox1.Text);
                if(pocet!=0)
                {
                    label2.Visible = false;
                    Random rnd = new Random();
                    int[] pole = new int[pocet];

                    for (int i = 0; i < pocet; i++)
                    {
                        int cislo = rnd.Next(1, 50);
                        pole[i] = cislo;
                    }
                    if(radioButton1.Checked==true)
                    {
                        int zacatek = 2147483647, max;
                        foreach (int cisilko in pole)
                        {
                            listBox1.Items.Add(Convert.ToString(cisilko));
                            if(cisilko<zacatek)zacatek=cisilko;
                        }
                        listBox2.Items.Add(Convert.ToString(zacatek));
                        for(int i=1;i<pocet;i++)
                        {
                            max = 2147483647;
                            foreach (int cisilko in pole)
                            {
                                if((cisilko>zacatek)&&(cisilko<max))
                                {
                                    max = cisilko;
                                }
                            }
                            if(max!= 2147483647) listBox2.Items.Add(Convert.ToString(max));
                            zacatek = max;
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        int zacatek = -2147483648, min;
                        foreach (int cisilko in pole)
                        {
                            listBox1.Items.Add(Convert.ToString(cisilko));
                            if (cisilko > zacatek) zacatek = cisilko;
                        }
                        listBox2.Items.Add(Convert.ToString(zacatek));
                        for (int i = 1; i < pocet; i++)
                        {
                            min = -2147483648;
                            foreach (int cisilko in pole)
                            {
                                if ((cisilko < zacatek) && (cisilko > min))
                                {
                                    min = cisilko;
                                }
                            }
                            if (min != -2147483648) listBox2.Items.Add(Convert.ToString(min));
                            zacatek = min;
                        }
                    }

                }
                else
                {
                    label2.Text = "Bylo zadáno, že se má vygenerovat 0 čísel!";
                    label2.Visible = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                }
            }
            else
            {
                label2.Text = "Nebyl zadán počet čísel!";
                label2.Visible = true;
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }
    }
}
