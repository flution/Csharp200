using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 100;
            lblResult_Text = value.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double value = 3.14;
            lblResult.Text = value.ToString();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string value = "Hello World!";
            lblResult.text = value.ToString();
        }
    }
}
