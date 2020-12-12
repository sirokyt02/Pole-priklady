using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
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
                if (n <= 0)
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Nelze vygenerovat 0 nebo méně písmen.";
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    listBox1.Items.Clear();
                    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    Random rnd = new Random();
                    int[] counter = new int[26];
                    for(int i=0;i<=25;i++)
                    {
                        counter[i] = 0;
                    }
                    char[] field = new char[n];
                    for (int i = 0; i < n; i++)
                    {
                        int index = rnd.Next(alphabet.Length);
                        field[i] = alphabet[index];
                        listBox1.Items.Add(field[i].ToString());
                        counter[field[i] - 65]++;
                    }
                    int max = 0, maxnumber = 0;
                    for(int i=0;i<=25;i++)
                    {
                        if (counter[i] > max) { max = counter[i]; maxnumber = i; }
                    }
                    label2.ForeColor = Color.Black;
                    if (max == 1) label2.Text = "Všechna písmena se vyskytují stejně často.";
                    else label2.Text = "Písmeno "+alphabet[maxnumber].ToString()+ " se vyskytnulo nejčastěji a to " + max.ToString() + "x.";
                    label2.Visible = true;
                }
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Nebyl zadán počet písmen!";
                label2.Visible = true;
            }
        }
    }
}
