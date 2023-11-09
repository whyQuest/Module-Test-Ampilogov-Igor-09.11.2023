using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_Test_Ampilogov_Igor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            var a = new Army[n * 3];
            for (int i = 0; i < a.Length - 2; i = i + 3)
            {
                a[i] = new Skeleton(0, 25);
                a[i + 1] = new Elephant(0, 30);
                a[i + 2] = new Infantry(1, 3);
            }
            var Cost = 0.0;
            float Speed = 0;

            listBox1.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 3 == 0)
                {
                    listBox1.Items.Add("---------------------------------");
                }
                listBox1.Items.Add(a[i].Show());
                Cost += a[i].Costing();
                Speed += a[i].Speeding();
              
            }

            Speed = Speed / a.Length;

            label2.Text = Cost.ToString();
            label3.Text = Speed.ToString();
        }
    }
}
