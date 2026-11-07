namespace BasicCalculator
{
    public partial class frmCalculator : Form
    {
        MemoryCalculator calc = new MemoryCalculator();
        string currentOp = "";
        //for current operation

        List<string> equationToken = new List<string>();
        double result = 0;
        bool isNewOperation = true;
        string lastOperation = "";
        string lastNumber = "";

        public frmCalculator()
        {
            InitializeComponent();
        }//frmCalculator

        //event handlers
        private void btnOne_Click(object sender, EventArgs e)
        {
            HandleNumberInput("1");
        }//btnOne_Click

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            //if i delete this, the design will crash. idk why. :[
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("2");
        }//btnTwo_Click

        private void btnThree_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("3");
        }//btnThree_Click

        private void btnFour_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("4");
        }//btnFour_Click

        private void btnFive_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("5");
        }//btnFive_Click

        private void btnSix_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("6");
        }//btnSix_Click

        private void btnSeven_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("7");
        }//btnSeven_Click

        private void btnEight_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("8");
        }//btnEight_Click

        private void btnNine_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("9");
        }//btnNine_Click

        private void btnZero_Click(object sender, EventArgs e)
        {
            //clone of btnOne_Click
            HandleNumberInput("0");
        }//btnZero_Click

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            currentOp = "";
            equationToken.Clear();
            calc.method_clear();

            isNewOperation = true;
            lastOperation = "";
            lastNumber = "";
        }//btnClear_Click

        private void btnDivide_Click(object sender, EventArgs e)
        {
            isNewOperation = true;
            currentOp += "/";
            txtBox.Text = currentOp;
            equationToken.Add("/");
        }//btnDivide_Click

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            isNewOperation = true;
            currentOp += "*";
            txtBox.Text = currentOp;
            equationToken.Add("*");
        }//btnMultiply_Click

        private void btnMinus_Click(object sender, EventArgs e)
        {
            isNewOperation = true;
            currentOp += "-";
            txtBox.Text = currentOp;
            equationToken.Add("-");
        }//btnMinus_Click

        private void btnPlus_Click(object sender, EventArgs e)
        {
            isNewOperation = true;
            currentOp += "+";
            txtBox.Text = currentOp;
            equationToken.Add("+");
        }//btnPlus_Click

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                currentOp = "";
                equationToken.Clear();
                isNewOperation = true;
            }
            if (equationToken.Count > 0 && equationToken[equationToken.Count - 1].Contains("."))
            {
                return;
            }

            currentOp += ".";
            txtBox.Text = currentOp;
            equationToken.Add(".");
        }//btnDecimal_Click

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOp) || equationToken.Count == 0)
            {
                currentOp = "";
                equationToken.Clear();
                txtBox.Text = "";
                return;
            }

            if (equationToken.Count == 1 && equationToken[0].Length > 1)
            {
                string singleToken = equationToken[0];
                equationToken.Clear();
                foreach (char c in singleToken)
                {
                    equationToken.Add(c.ToString());
                }

            }

            currentOp = currentOp.Substring(0, currentOp.Length - 1);
            txtBox.Text = currentOp;

            equationToken.RemoveAt(equationToken.Count - 1);

            if (equationToken.Count == 0)
            {
                currentOp = "";
            }
        }//btnBack_Click

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Double.TryParse(currentOp, out result);
            result = calc.method_squareRoot(result);
            currentOp = result.ToString();
            txtBox.Text = currentOp;
            equationToken.Clear();
            equationToken.Add(currentOp);
        }//btnSquare_Click

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOp))
            {
                return;
            }

            if (Double.TryParse(currentOp, out result))
            {
                result = calc.method_reverseSign(result);

                currentOp = result.ToString();
                txtBox.Text = currentOp;

                equationToken.Clear();
                equationToken.Add(currentOp);
            }
        }//btnNegate_Click

        public void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(currentOp, out result))
            {
                try
                {
                    result = calc.method_reciprocal(result);

                    currentOp = result.ToString();
                    txtBox.Text = currentOp;

                    equationToken.Clear();
                    equationToken.Add(currentOp);
                }
                catch (DivideByZeroException)
                {
                    txtBox.Text = "Cannot divide by Zero.";
                    currentOp = "";
                    equationToken.Clear();
                }
            }
        }//btnReciprocal_Click

        private void btnEquals_Click(object sender, EventArgs e)
        {

            try
            {
                if (!isNewOperation && !string.IsNullOrEmpty(lastOperation) && !string.IsNullOrEmpty(lastNumber))
                {
                    equationToken.Add(lastOperation);

                    foreach (char c in lastNumber)
                    {
                        equationToken.Add(c.ToString());
                    }
                }
                else
                {
                    if (equationToken.Count >= 3)
                    {
                        string fullNum = "";
                        int idx = equationToken.Count - 1;

                        while (idx >= 0 && equationToken[idx] != "+" && equationToken[idx] != "-" && equationToken[idx] != "*" && equationToken[idx] != "/")
                        {
                            fullNum = equationToken[idx] + fullNum;
                            idx--;
                        }

                        lastNumber = fullNum;
                        if (idx >= 0)
                        {
                            lastOperation = equationToken[idx];
                        }
                    }
                }

                result = calc.Calculate(equationToken);

                currentOp = result.ToString();
                txtBox.Text = currentOp;

                equationToken.Clear();
                equationToken.Add(currentOp);
                isNewOperation = false;



            }
            catch (DivideByZeroException)
            {
                txtBox.Text = "Cannot Divide by zero";
                currentOp = "";
                equationToken.Clear();
                isNewOperation = true;

            }


        }//btnEquals_Click

        private void HandleNumberInput(string digit)
        {
            if (!isNewOperation)
            {
                currentOp = "";
                equationToken.Clear();
                isNewOperation = true;
            }
            currentOp += digit;
            txtBox.Text = currentOp;
            equationToken.Add(digit);
        }//HandleNumberInput
        private void UpdateMemoryLabel() {
            if (calc.method_hasMemory() == true)
            {
                lblM.Text = "M";
            }
            else { 
                lblM.Text = " ";
            }
        
        }//UpdateMem label
        private void btnMC_Click(object sender, EventArgs e)
        {
            calc.method_memoryClear();
            UpdateMemoryLabel();
        }//MC_click

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(currentOp, out result))
            {
                calc.method_memoryStore(result);
                UpdateMemoryLabel();
            }
        }//MS_click
        private void btnMR_Click(object sender, EventArgs e)
        {
            result = calc.method_memoryRecall();
            currentOp = result.ToString();
            txtBox.Text = currentOp;
            equationToken.Clear();
            equationToken.Add(currentOp);
            UpdateMemoryLabel();

        }//MC_click

        private void btnMplus_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(currentOp, out result)) {
                calc.method_memoryAdd(result);
                UpdateMemoryLabel();
            }
        }//M+_click
    }//class frmCalculator
    public class Calculator
        {
            protected double operand1;
            protected double operand2;
            protected double result;

            //forgive the naming convention I just finished a beast of an sql project
            public double method_add(double a, double b){
           return a + b ;
        }//add logic
            public double method_subtract(double a, double b) {
            return a - b;
        }// subtract logic
            public double method_multiply(double a, double b) {  
            return a * b ; 
        }//multiply logic
            public double method_divide(double a, double b) {
            if (b == 0)
            {
                throw new DivideByZeroException();

            }
            else {
                return a / b;
            }
        }//divide logic
            public double method_squareRoot(double a) {
            return Math.Sqrt(a);
        }//square root logic
            public double method_reciprocal(double a) {
            if (a == 0) {
                throw new DivideByZeroException();
            }
            return 1 / a;
        }//reciprocal logic
            public double method_reverseSign(double a) {
           return a * -1;
        }//reverse sign logic
            public void method_clear() {
            operand1 = 0;
            operand2 = 0;
            result = 0;
            }//clear logic
            public double Calculate(List<string> tokens)
            {
                if (tokens == null || tokens.Count == 0)
                {
                    return 0;
                }

                List<double> numbers = new List<double>();
                List<string> operators = new List<string>();
                string currentNumberBuild = "";

                foreach (string token in tokens)
                {
                    if (token == "+" || token == "-" || token == "/"|| token =="*")
                    {
                        if (!string.IsNullOrEmpty(currentNumberBuild) && currentNumberBuild != "-")
                        {
                                numbers.Add(double.Parse(currentNumberBuild));
                                currentNumberBuild = "";
                        }
                        operators.Add(token);
                    }
                    else
                    {
                        currentNumberBuild += token;
                    }
                }

                if (!String.IsNullOrEmpty(currentNumberBuild)) {
                    numbers.Add(double.Parse(currentNumberBuild));
                }

                if (operators.Count == 0 && numbers.Count > 0)
                {
                    return numbers[0];
                }

                double runningTotal = numbers[0];

                    for (int i = 0; i < operators.Count; i++)
                    {
                        string op = operators[i];
                        double nextNum = numbers[i + 1];
                        operand1 = runningTotal;
                        operand2 = nextNum;

                        if (op == "+")
                        {
                        runningTotal = method_add(operand1, operand2);
                        }
                        else if (op == "-")
                        {
                            runningTotal = method_subtract(operand1, operand2);
                        }
                        else if (op == "*")
                        {
                            runningTotal = method_multiply(operand1, operand2);
                        }
                        else if (op == "/")
                        {
                            runningTotal = method_divide(operand1, operand2);
                        }
                    }
                result = runningTotal;
            return result;
            }
        }// Class Calculate
}//namespace
