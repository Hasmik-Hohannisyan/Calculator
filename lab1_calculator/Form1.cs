using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (TextBox.Text == "0" || NewNumber)
            {
                TextBox.Text = btn.Text;
                NewNumber = false;
            }
            else
            {
                TextBox.Text += btn.Text;
            }

        }


        string result;
        string operand;
        bool NewNumber;

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            result = TextBox.Text;
            operand = btn.Text;
            NewNumber = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(result);
            double n2 = double.Parse(TextBox.Text);
            double y = 0D;

            switch (operand)
            {
                case "+":
                    y = n1 + n2;
                    break;
                case "-":
                    y = n1 - n2;
                    break;
                case "*":
                    y = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        y = n1 / n2;
                    }
                    break;
                case "%":
                    y = n1 * n2 / 100;
                    break;
                case "^":
                    y = Math.Pow(n1, n2);
                    break;
                case "Root":
                    y = Math.Pow(n1, 1 / n2);
                    break;
                case "1/x":
                    y = 1 / n1;
                    break;
            }
            result = y.ToString();
            TextBox.Text = result;
            NewNumber = true;
        }

        private void clean_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            //Button btn = sender as Button;
            //  TextBox.Text = "0";
            // operand = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double y;
            if (double.TryParse("1.2", out y))
            {
                TextBox.Text += '.';
            }
            else
            {
                TextBox.Text += ',';
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != "")
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
           if (TextBox.Text != "")
            {
                if (TextBox.Text[0] == '-')
                {
                    TextBox.Text = TextBox.Text.Remove(0, 1);
                }
                else
                {
                    TextBox.Text = '-' + TextBox.Text;
                }
            }
        }
    }
}
