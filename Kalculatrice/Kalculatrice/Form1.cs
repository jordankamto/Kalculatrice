using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculatrice
{
    public partial class Form1 : Form
    {
        string previous = "";
        string next = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }

        private void dpoint_Click(object sender, EventArgs e)
        {
            display.Text += "";
            userInput += ".";
            display.Text += userInput;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            next = userInput;
            double fnum, snum;
            fnum = Convert.ToDouble(previous);
            snum = Convert.ToDouble(next);

            if (function == '+') 
            {
                result = fnum + snum;
                display.Text = result.ToString();

            }
            else if (function == '-')
            {
                result = fnum - snum;
                display.Text = result.ToString();
            }
            else if (function == '/')
            {
                if (snum == '0')
                {
                    display.Text = "Division impossible";
                }
                else
                {
                    result = fnum / snum;
                    display.Text = result.ToString();
                }
            }
            else if (function == '*')
            {
                result = fnum * snum;
                display.Text = result.ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            previous = "";
            next = "";
            result = 0.0;
            userInput = "";
            display.Text = "0";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            function = '-';
            previous = userInput;
            userInput = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            function = '+';
            previous = userInput;
            userInput = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            function = '/';
            previous = userInput;
            userInput = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            previous = userInput;
            userInput = "";
        }
    }
}
