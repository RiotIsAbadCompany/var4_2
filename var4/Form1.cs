using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace var4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> c = new List<int>();
            List<int> v = new List<int>();
            List<int> b = new List<int>();

            for (int j = 0; j < 10; j++)
            {
                c.Add(rnd.Next(-10, 15));
                if (c[j] < 0 && c[j] > -10)
                {
                    v.Add(c[j]);
                }
                else if (c[j] > 0 && c[j] >= 10)
                {
                    b.Add(c[j]);
                }

            }
            c.Sort();
            listBox1.DataSource = c;
            listBox2.DataSource = v;
            listBox3.DataSource = b;
            string combinedString = string.Join(",", c);
            string combinedString2 = string.Join(",", v);
            string combinedString3 = string.Join(",", b);
            String a = combinedString + ", " + combinedString2 +"," + combinedString3;
            StreamWriter s = new StreamWriter(@"Rezultat.txt");
            s.Write(a);
            s.Close();
        }
    }
}
