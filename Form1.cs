using System;
using System.Drawing;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form1 : Form
    {


        private string counter(string count)
        {
            lblCommandsNum.Text = (int.Parse(lblCommandsNum.Text) + 1).ToString();
            return lblCommandsNum.Text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
             counter(lblCommandsNum.Text);
        }


        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            counter(lblCommandsNum.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCommand3_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            counter(lblCommandsNum.Text);
        }
    }
}
