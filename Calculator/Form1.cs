using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        public string operation = "";
        private bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

 

        private void button_click(object sender, EventArgs e)
        {


           
                if ((textBox1.Text == "0") || (isOperationPerformed)) { textBox1.Clear(); }
                

                isOperationPerformed = false;
                Button button = (Button)sender;
                textBox1.Text = textBox1.Text + button.Text;
            

        }

        private void operator_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (result != 0)
            {
                button15.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;


            }
            else
            {
                operation = button.Text;
                result = double.Parse(textBox1.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox1.Text);
            operation = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            operation = "";
        }
    }
}
