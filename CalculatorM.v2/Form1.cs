namespace CalculatorM.v2


{
    public partial class Form1 : Form
    {

        double _result = 0;
        string _operatorSelected = " ";
        bool _isOperatorSelected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (_isOperatorSelected))
            {
                textBoxResult.Clear();
            }
            _isOperatorSelected = false;
            Button clickedButton = sender as Button;

            if (clickedButton.Text == ",")  // block repetition of , 
            {
                if (!textBoxResult.Text.Contains(","))
                {
                    textBoxResult.Text += clickedButton.Text;
                }
            }
            else textBoxResult.Text += clickedButton.Text;



        }

        private void math_operator_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (_result != 0) // if  result is not 0 clicking the operator performs the button_equals
            {
                buttonEquals.PerformClick();
                _operatorSelected = clickedButton.Text;
                label_selectedOperator.Text = _result + " " + _operatorSelected;
                _isOperatorSelected = true;
            }
            else
            {
                _operatorSelected = clickedButton.Text;
                _result = double.Parse(textBoxResult.Text); //String to double
                label_selectedOperator.Text = _result + " " + _operatorSelected;
                _isOperatorSelected = true;
            }
        }

        private void buttonCE_click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonC_click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            _result = 0;
            label_selectedOperator.Text = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (_operatorSelected)
            {
                case "+":
                    textBoxResult.Text = (_result + Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "-":
                    textBoxResult.Text = (_result - Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "X":
                    textBoxResult.Text = (_result * Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (_result / Double.Parse(textBoxResult.Text)).ToString();
                    break;

                default:
                    break;
            }

            _result = double.Parse(textBoxResult.Text);
            label_selectedOperator.Text = "";
        }




    }
}
