using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox4.Text = "Результат работы программы"+ Environment.NewLine;
            textBox4.Text += " При X =" +textBox1.Text + Environment.NewLine;
            textBox4.Text += " При Y =" + textBox2.Text + Environment.NewLine;
            double a;
            if (x * y > 0)
                a = Math.Pow(x * x + y, 2) - Math.Sqrt(x * x * y);
            else
                if (x * y < 0)
                a = Math.Pow(x * x + y, 2) - Math.Sqrt(Math.Abs(x * x * y));
            else a = Math.Pow(x * x + y, 2) + 1;
            textBox4.Text += " a = " + a.ToString() + Environment.NewLine;
        }
    }
}
