using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") || (textBox2.Text != ""))
            {
                int pocet = Convert.ToInt32(textBox1.Text);
                if (pocet != 0)
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    Random rnd = new Random();
                    int[] pole = new int[pocet];
                    for (int i = 0; i < pocet; i++)
                    {
                        pole[i] = rnd.Next(1, 100);
                        listBox1.Items.Add(pole[i].ToString());
                    }

                }
                else
                {
                    label2.Text = "Nelze vytvořit 0 čísel!";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Text = "Nebyla správně zadána čísla!";
                label2.Visible = true;
            }
        }
    }
}
