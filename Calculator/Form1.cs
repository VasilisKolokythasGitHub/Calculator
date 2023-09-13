namespace Calculator
{
    public partial class Form1 : Form
    {

        private decimal FirstNumber = 0.0m;
        private decimal SecondNumber = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";

            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";

            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";

            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";

            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";

            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";

            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";

            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";

            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";

            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = 0.0m;
            SecondNumber = 0.0m;
            textBox.Text = "0";
        }

        private void MinPlusBtn_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else if (textBox.Text.Contains('-'))
            {
                textBox.Text = textBox.Text.Trim('-');
            }
            else if (!textBox.Text.Contains('-'))
            {
                textBox.Text = '-' + textBox.Text;
            }

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "+";
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "/";
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "*";
        }

        private void ModBtn_Click(object sender, EventArgs e)
        {
            FirstNumber = decimal.Parse(textBox.Text);
            textBox.Clear();
            operators = "%";
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            string inputValue = textBox.Text;
            switch (inputValue)
            {
                case "-":
                    Result = FirstNumber - SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "+":
                    Result = FirstNumber + SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "%":
                    Result = FirstNumber % SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
            }

                    SecondNumber = decimal.Parse(textBox.Text);
            switch (operators)
            {
                case "-":
                    Result = FirstNumber - SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "+":
                    Result = FirstNumber + SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "/":
                    Result = FirstNumber / SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
                case "%":
                    Result = FirstNumber % SecondNumber;
                    textBox.Text = Result.ToString();
                    break;
            }
        }
    }
}
