using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class1_WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(txt1.Text);
            double val2 = double.Parse(txt2.Text);
            double res = 0;
            res = val1 + val2;

            txtResult.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(txt1.Text);
            double val2 = double.Parse(txt2.Text);
            double res = 0;
            res = val1 - val2;

            txtResult.Text = res.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(txt1.Text);
            double val2 = double.Parse(txt2.Text);
            double res = 0;
            res = val1 * val2;

            txtResult.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double val1 = double.Parse(txt1.Text);
            double val2 = double.Parse(txt2.Text);
            double res = 0;
            res = val1 / val2;

            txtResult.Text = res.ToString();
        }
    }
}
