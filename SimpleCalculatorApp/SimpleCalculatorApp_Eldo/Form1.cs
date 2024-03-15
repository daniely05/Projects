namespace SimpleCalculatorApp_Eldo
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        double getal1;
        double getal2 = 0;
        double uitkomst;
        string lastPressed = "";
        private void btnOne_Click(object sender, EventArgs e)
        {
            tbText.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbText.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbText.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbText.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbText.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbText.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            tbText.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {

            tbText.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            tbText.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {

            tbText.Text += "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            lastPressed = "/";
            getal1 = double.Parse(tbText.Text);


            tbText.Clear();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            lastPressed = "*";
            getal1 = double.Parse(tbText.Text);


            tbText.Clear();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            lastPressed = "-";
            getal1 = double.Parse(tbText.Text);


            tbText.Clear();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            lastPressed = "+";
            getal1 = double.Parse(tbText.Text);


            tbText.Clear();

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            getal2 = double.Parse(tbText.Text);



            if (lastPressed == "+")
            {
                uitkomst = getal1 + getal2;
            }
            else if (lastPressed == "*")
            {
                uitkomst = getal1 * getal2;
            }
            else if (lastPressed == "/")
            {
                uitkomst = getal1 / getal2;
                if (getal2 == 0)
                {
                    tbText.Text = "NaN";
                    return;

                }
            }
            else if (lastPressed == "-")
            {
                uitkomst = getal1 - getal2;
            }
            else
            {
                tbText.Text = getal1.ToString();
            }

            tbText.Text = $"{uitkomst}";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbText.Clear();
            getal1 = 0;
            getal2 = 0;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbText.Text += ".";
        }

        private void btnEnter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnPlus_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnEnter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnPlus_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnEnter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnEnter.PerformClick();
            }
        }

        private void btnPlus_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Add)
            {
                btnPlus.PerformClick();
            }
        }

        private void btnMinus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.OemMinus)
            {
                btnMinus.PerformClick();
            }
        }

        private void btnMultiply_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Multiply)
            {
                btnMultiply.PerformClick();
            }
        }

        private void btnDivide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Divide)
            {
                btnDivide.PerformClick();
            }
        }

        private void btnClear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumLock)
            {
                btnClear.PerformClick();
            }
        }

        private void btnSeven_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad7)
            {
                btnSeven.PerformClick();
            }
        }

        private void btnEight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad8)
            {
                btnEight.PerformClick();
            }
        }

        private void btnNine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad9)
            {
                btnNine.PerformClick();
            }
        }


        private void btnFour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad4)
            {
                btnFour.PerformClick();
            }
        }



        private void btnFive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad5)
            {
                btnFive.PerformClick();
            }
        }

        private void btnSix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad6)
            {
                btnSix.PerformClick();
            }

        }

        private void btnOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad1)
            {
                btnOne.PerformClick();
            }

        }

        private void btnTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad2)
            {
                btnTwo.PerformClick();
            }

        }

        private void btnThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad3)
            {
                btnThree.PerformClick();
            }
        }

        private void btnZero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.NumPad0)
            {
                btnZero.PerformClick();
            }
        }

        private void btnPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Decimal)
            {
                btnPoint.PerformClick();
            }
        }

        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {

            //e.KeyChar
            //if (e.KeyChar == (char)Keys.Decimal)
            //{
            //    btnPoint.PerformClick();
            //}

        }
    }
}
