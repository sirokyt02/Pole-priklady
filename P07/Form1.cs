using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = listBox1.Items.Count;
            if(size!=0)
            {
                label2.Visible = false;
                listBox2.Items.Clear();
                textBox1.Text = "";
                
                int[] pole = new int[size];int end = -1;
                for (int i=0; i<size;i++)
                {
                    int number = Convert.ToInt32(listBox1.Items[i]);
                    if(number==0)
                    {
                        end = i-1;
                        break;
                    }
                    else
                    {
                        pole[i] = number;
                    }
                }
                if(end<0)
                {
                    label2.Text = "Nebyla zadána nula!";
                    label2.Visible = true;
                }
                else
                {
                    int share = pole[0] / pole[end];
                    textBox1.Text = Convert.ToString(share);
                    for(int i=0;i<end;i++)
                    {
                        if(pole[i]<pole[end])
                        {
                            listBox2.Items.Add((i+1).ToString() + ". " + pole[i].ToString());
                        }
                    }
                }
            }
            else
            {
                label2.Text = "Nebylo zadáno žádné číslo!";
                label2.Visible = true;
            }
        }
    }
}
