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
                    for(int i=0;i<=end;i++)
                    {
                        if((field[i]>47)&&(field[i]<58))
                        {
                            field[i] = 'x';
                        }
                    }
                }
                else
                {
                    char maxchar=field[0];int place = 0;
                    for(int i =0;i<=end;i++)
                    {
                        if (field[i] > maxchar) { maxchar = field[i];place = i; };
                    }
                    maxchar = field[place];
                    field[place] = field[end];
                    field[end] = maxchar;
                }
                string s="";
                foreach(char ch in field)
                {
                    s += ch;
                }
                textBox2.Text = s;
            }
            else
            {
                label2.Text = "Nebyl zadán žádný znak!";
                label2.Visible = true;
            }
        }
    }
}
