namespace Calculator
{
    public partial class Calculator : Form
    {
        private string numberInput;
        private char op;
        private string operand1;
        private string operand2;

        public Calculator()
        {
            InitializeComponent();
            numberInput = "0";
            op = ' ';
            operand1 = "0";
            operand2 = "0";
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lbl_display.Text = numberInput;
        }

        private void number_Click(object sender, EventArgs e)
        {
            if (numberInput == "0")
            {
                numberInput = "";
            }

            numberInput += ((Button)sender).Text;
            UpdateDisplay();
        }

        private void operator_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                op = ((Button)sender).Text[0];
                operand1 = numberInput;
                numberInput = "0";
            }
            else
            {
                operand2 = numberInput;
                double result = Calculate();
                operand1 = lbl_display.Text = result.ToString();
                numberInput = "0";
                op = ((Button)sender).Text[0];
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            operand2 = numberInput;
            double result = Calculate();
            operand1 = lbl_display.Text = result.ToString();
        }

        private double Calculate()
        {
            double operandD1 = Double.Parse(operand1);
            double operandD2 = Double.Parse(operand2);

            switch (op)
            {
                case '+':
                    return operandD1 + operandD2;
                case '-':
                    return operandD1 - operandD2;
            }

            return 0;
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (!numberInput.Contains(","))
            {
                numberInput += ",";
            }

            UpdateDisplay();
        }

        private void btn_polarity_Click(object sender, EventArgs e)
        {
            char first = numberInput[0];

            if (char.IsDigit(first))
            {
                if (numberInput != "0")
                {
                    numberInput = "-" + numberInput;
                }
            }
            else
            {
                numberInput = numberInput.Remove(0, 1);
            }

            UpdateDisplay();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            numberInput = "0";
            op = ' ';
            operand1 = "0";
            operand2 = "0";
            UpdateDisplay();
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (numberInput.Length > 1)
            {
                numberInput = numberInput.Remove(numberInput.Length - 1, 1);
            }
            else
            {
                numberInput = "0";
            }

            UpdateDisplay();
        }
    }
}