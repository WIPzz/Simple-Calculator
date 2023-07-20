using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test123
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double resultNum = 0;
        string oper = "";


        public Form1()
        {
            InitializeComponent();
        }

        // Number Button
        private void numBttn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            else if (!string.IsNullOrWhiteSpace(textBox2.Text))
                return;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        // Operator Button
        private void operatorBttn(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" | !string.IsNullOrWhiteSpace(textBox2.Text))
                return;
            Button button = (Button)sender;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Text = textBox1.Text + button.Text;
            oper = textBox1.Text;
            textBox3.Text = num1.ToString() + oper;
            textBox1.Clear();
        }

        // Equal Button
        private void resultBttn(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                return;
            Button button = (Button)sender;
            num2 = Convert.ToDouble(textBox1.Text);
            textBox3.Text = num1.ToString() + oper + num2.ToString();
            textBox2.Clear();
            if (oper == "+")
                resultNum = num1 + num2;
            else if (oper == "-")
                resultNum = num1 - num2;
            else if (oper == "*")
                resultNum = num1 * num2;
            else resultNum = num1 / num2;
            textBox2.Text = resultNum.ToString();
            textBox1.Clear();

        }

        // Clear Button
        private void clearBttn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            num1 = 0;
            num2 = 0;
            resultNum = 0;
            oper = "";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
