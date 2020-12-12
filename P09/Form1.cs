using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
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
                int size = Convert.ToInt32(textBox1.Text);
                if(size<=0)
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Nelze vygenerovat 0 nebo méně čísel!";
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    double[] field = new double[size];
                    Random rnd = new Random();
                    for(int i=0; i<size;i++)
                    {
                        field[i] = rnd.Next(1,11);
                    }
                    Array.Sort(field);
                    foreach(int i in field)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                    double mid=0;
                    if(size%2==0)
                    {
                        mid = size / 2;
                        mid = field[(int)mid - 1] + field[(int)mid];
                        mid /= 2;
                    }
                    else
                    {
                        mid = ((size - 1) / 2)+1;
                        mid = field[(int)mid - 1];
                    }
                    int count;
                    int countfirst= Array.IndexOf(field, mid);
                    int countlast = Array.LastIndexOf(field, mid);
                    if (countfirst == -1) count = 0;
                    else
                    {
                        if (countfirst == countlast) count = 1;
                        else { count = (countlast - countfirst) + 1; }
                    }
                    label2.ForeColor = Color.Black;
                    label2.Text = "Medián je číslo " + mid.ToString() + ". Toto číslo se celkem vyskytlo " + count.ToString() + "x.";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.ForeColor=Color.Red;
                label2.Text = "Nebyl zadán počet!";
                label2.Visible = true;
            }
        }
    }
}
