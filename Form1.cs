using System;

namespace myCalculater
{
    public partial class Form1 : Form
    {
        char operation;
        double result = 0.0; 
        bool isOpreating = false;
        public Form1()
        {
            InitializeComponent();
        }

        public void showAnswer()
        {
            if (operation == '+')
            {
                Screen.Text = (result + double.Parse(Screen.Text)).ToString();
            }
            else if (operation == '-')
            {
                Screen.Text = (result - double.Parse(Screen.Text)).ToString();
            }
            else if (operation == '*')
            {
                Screen.Text = (result * double.Parse(Screen.Text)).ToString();
            }
            else if (operation == '/')
            {
                if (double.Parse(Screen.Text) != 0)
                    Screen.Text = (result / double.Parse(Screen.Text)).ToString();
            }
            result = 0;
            operation = 'N';
            isOpreating = false;
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
                Screen.Clear();
            Screen.Text = Screen.Text + '0';
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '1';
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating )
                Screen.Clear();
            Screen.Text = Screen.Text + '2';
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '3';
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '4';
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '5';
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '6';

        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '7';
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '8';
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || isOpreating)
                Screen.Clear();
            Screen.Text = Screen.Text + '9';
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (isOpreating)
                Screen.Text = "0";
            if (!Screen.Text.Contains('.'))
                Screen.Text = Screen.Text + '.';
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (isOpreating)
            {
                showAnswer();
            }
            operation = '+';
            result = double.Parse(Screen.Text);
            isOpreating = true;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            if(isOpreating)
            {
                showAnswer();
            }
            operation = '-';
            result = double.Parse(Screen.Text);
            isOpreating = true;
        }

        private void multiplay_Click(object sender, EventArgs e)
        {
            if (isOpreating)
            {
                showAnswer();
            }
            operation = '*';
            result = double.Parse(Screen.Text);
            isOpreating = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (isOpreating)
            {
                showAnswer();
            }
            operation = '/';
            result = double.Parse(Screen.Text);
            isOpreating = true;
        }

        private void delet_Click(object sender, EventArgs e)
        {
            string temp = Screen.Text;
            if (temp.Length > 1)
                temp = temp.Remove(temp.Length - 1);
            else
                temp = "0";
            Screen.Text = temp;
        }

        public void equal_Click(object sender, EventArgs e)
        {
            showAnswer();
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            result = 0;
            Screen.Text = "0";
            isOpreating = false;
        }
    }
}