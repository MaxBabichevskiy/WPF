using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double num_1, num_2, result;
        string operation;


        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num_1))
            {
                operation = "-";
                textBox1.Text = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num_2))
            {
                switch (operation)
                {
                    case "+":
                        result = num_1 + num_2;
                        break;
                    case "-":
                        result = num_1 - num_2;
                        break;
                    case "*":
                        result = num_1 * num_2;
                        break;
                    case "/":
                        if (num_2 != 0)
                        {
                            result = num_1 / num_2;
                        }
                        else
                        {
                            MessageBox.Show("Делить на ноль нельзя!");
                        }
                        break;
                }
                textBox1.Text = result.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num_1))
            {
                operation = "*";
                textBox1.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num_1))
            {
                operation = "/";
                textBox1.Text = "";
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            num_1 = 0;
            num_2 = 0;
            result = 0;
            operation = "";
            textBox1.Text = "";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out num_1))
            {
                operation = "+";
                textBox1.Text = "";
            }
        }
    }
}