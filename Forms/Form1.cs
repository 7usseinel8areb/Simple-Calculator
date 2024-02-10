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
        string operation = "";
        double result = 0;
        bool IsOperation = false;
        bool IsResult = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (textBox1.Text == "0" || IsOperation == true || IsResult ==true)
            {
                textBox1.Clear();
            }
            if(but.Text == ".") 
            {
                if(!textBox1.Text.Contains("."))
                {
                    AddNumberToTextBox(but);
                }
            }
            else
            {
                AddNumberToTextBox(but);
            }
            IsOperation = false;
            IsResult = false;
        }
        void AddNumberToTextBox(Button but)
        {
            textBox1.Text = textBox1.Text + but.Text;
        }

        
        private void button10_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            result = double.Parse(textBox1.Text);
            IsOperation = true;
            IsResult = false;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                case "x":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
            }
            IsResult = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
        }
    }
}
