namespace CalculatorM.v2


{
    public partial class Form1 : Form
    {

        Double result = 0;
        String operatorSelected = " ";
        bool isOperatorSelected = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxResult.Text == "0") || (isOperatorSelected))
            {
                textBoxResult.Clear();
            }
            isOperatorSelected = false;
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

            if (result != 0) // if  result is not 0 clicking the operator performs the button_equals
            {
                buttonEquals.PerformClick();
                operatorSelected = clickedButton.Text;
                label_selectedOperator.Text = result + " " + operatorSelected;
                isOperatorSelected = true;
            }
            else
            {
                operatorSelected = clickedButton.Text;
                result = Double.Parse(textBoxResult.Text); //String to double
                label_selectedOperator.Text = result + " " + operatorSelected;
                isOperatorSelected = true;
            }
        }

        private void buttonCE_click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";

        }

        private void buttonC_click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            result = 0;

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string expression = label_selectedOperator.Text;
            double resultValue = result;


            switch (operatorSelected)
            {

                case "+":
                    textBoxResult.Text = (result + Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "-":
                    textBoxResult.Text = (result - Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "X":
                    textBoxResult.Text = (result * Double.Parse(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (result / Double.Parse(textBoxResult.Text)).ToString();
                    break;

                default:
                    break;
            }

            result = Double.Parse(textBoxResult.Text);
            label_selectedOperator.Text = "";
        }




    }
}
