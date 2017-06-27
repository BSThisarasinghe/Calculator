using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num, ans;
        int count;

        private void button4_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            count = 3;
            label.Text = num.ToString() + "*";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 0;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            compute();
            label.Text = "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + 9;
        }

        private void div_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            count = 4;
            label.Text = num.ToString() + "/";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            count = 2;
            label.Text = num.ToString() + "-";
        }

        private void plus_Click(object sender, EventArgs e)
        {

            num = double.Parse(textBox.Text);
            textBox.Clear();
            textBox.Focus();
            count = 1;
            label.Text = num.ToString() + "+";
        }
        public void compute()
        {
            switch (count){
             case 1:
                ans = num + double.Parse(textBox.Text);
                textBox.Text = ans.ToString();
                break;
            case 2:
                ans = num - double.Parse(textBox.Text);
                textBox.Text = ans.ToString();
                break;
            case 3:
                ans = num * double.Parse(textBox.Text);
                textBox.Text = ans.ToString();
                break;
            case 4:
                ans = num / double.Parse(textBox.Text);
                textBox.Text = ans.ToString();
                break;
            default:
                break;

        }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            label.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            int length = textBox.TextLength - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox.Text = textBox.Text + text[i];
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
