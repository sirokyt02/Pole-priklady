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
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                int amount = Convert.ToInt32(textBox1.Text);
                int number = Convert.ToInt32(textBox2.Text);
                if (amount != 0)
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    Random rnd = new Random();
                    int[] field = new int[amount];
                    for (int i = 0; i < amount; i++)
                    {
                        field[i] = rnd.Next(1, 100);
                    }
                    Array.Sort(field);
                    int lower = 0;
                    foreach (int n in field)
                    {
                        listBox1.Items.Add(n.ToString());
                        if (n <= number)
                        {
                            lower++;
                        }
                    }
                    int[] lowfield = field.Take(lower).ToArray();
                    int[] highfield = field.Skip(lower).ToArray();
                    foreach(int n in lowfield)
                    {
                        listBox2.Items.Add(n.ToString());
                    }
                    foreach (int n in highfield)
                    {
                        listBox3.Items.Add(n.ToString());
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
