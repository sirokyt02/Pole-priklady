using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
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
                int n = Convert.ToInt32(textBox1.Text);
                if(n!=0)
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    Random rnd = new Random();
                    double[] field=new double[n];
                    for(int i=0;i<n;i++)
                    {
                        int help = rnd.Next(0, 2);
                        if(help==0)
                        {
                            field[i] = (rnd.NextDouble())*(-1000);
                        }
                        else
                        {
                            field[i] = (rnd.NextDouble()) * 1000;
                        }
                        if(field[i]==1000)
                        {
                            field[i] *= -1;
                        }
                    }
                    Array.Sort(field);
                    double diameter = 0;
                    foreach(double db in field)
                    {
                        listBox1.Items.Add(db.ToString());
                        diameter += db;
                    }
                    diameter /= n;double max = 0;
                    foreach(double f in field)
                    {
                        if (f <= diameter) max = f;
                    }
                    listBox2.Items.Add(max.ToString());
                }
                else
                {
                    label2.Text = "Nelze vytvořit 0 čísel!";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.Text = "Nebyl zadán počet čísel!";
                label2.Visible = true;
            }
        }
    }
}
