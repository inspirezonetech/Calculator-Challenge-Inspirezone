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
        int currentOperation = 0;
        int value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            currentOperation = 1;
            
            label.Text = textBox.Text + " + ";

            value = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            CloseButton();
        }

        private void button_Subtract_Click(object sender, EventArgs e)
        {
            currentOperation = 2;

            label.Text = textBox.Text + " - ";

            value = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            CloseButton();
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            currentOperation = 3;

            label.Text = textBox.Text + " * ";

            value = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            CloseButton();
        }

        private void button_Divide_Click(object sender, EventArgs e)
        {
            currentOperation = 4;

            label.Text = textBox.Text + " / ";

            value = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
            CloseButton();
        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            int answer = 0;
            switch (currentOperation)
            {
                case 1:
                    answer = value + Convert.ToInt32(textBox.Text);
                    break;
                case 2:
                    answer = value - Convert.ToInt32(textBox.Text);
                    break;
                case 3:
                    answer = value * Convert.ToInt32(textBox.Text);
                    break;
                case 4:
                    answer = value / Convert.ToInt32(textBox.Text);
                    break;
            }

            label.Text = label.Text + textBox.Text + " = " + answer.ToString();
            value = 0;
            textBox.Text = "";
            OpenButton();
        }

        private void CloseButton()
        {
            button_Add.Enabled = false;
            button_Subtract.Enabled = false;
            button_Multiply.Enabled = false;
            button_Divide.Enabled = false;
        }

        private void OpenButton()
        {
            button_Add.Enabled = true;
            button_Subtract.Enabled = true;
            button_Multiply.Enabled = true;
            button_Divide.Enabled = true;
        }
    }
}
