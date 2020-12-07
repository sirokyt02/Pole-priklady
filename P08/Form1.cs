using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
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
                label2.Visible = false;
                textBox2.Text = "";
                int size = textBox1.Text.Count();
                char[] field = new char[size];int end=-1;
                foreach(char ch in textBox1.Text)
                {
                    end++;
                    field[end] = ch;
                }
                if((field[end]>47)&&(field[end]<58))
                {
                    for(int i=0;i<=end)
                    {
                        if((ch>47)&&(ch<58))
                        {

                        }
                    }
                }
            }
            else
            {
                label2.Text = "Nebyl zadán žádný znak!";
                label2.Visible = true;
            }
        }
    }
}
