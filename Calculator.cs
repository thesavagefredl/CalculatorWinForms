public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare variables
        float equals, num1;
        int count;

        //Assign buttons with values
        private void btn3_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 3;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 0;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 2;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 9;
        }

        //Creating the methods
        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtSym.Text = "+";
            num1 = float.Parse(txtView.Text);
            txtView.Clear();
            txtView.Focus();
            count = 2;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtSym.Text = "-";
            if(txtView.Text != "")
            {
                num1 = float.Parse(txtView.Text);
                txtView.Clear();
                txtView.Focus();
                count = 1;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtSym.Text = "x";
            num1 = float.Parse(txtView.Text);
            txtView.Clear();
            txtView.Focus();
            count = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtSym.Text = "/";
            num1 = float.Parse(txtView.Text);
            txtView.Clear();
            txtView.Focus();
            count = 4;
        }

        //
        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute(count);
        }public void compute(int count) //Calculation
        {
            switch (count)
            {
                case 1:
                    equals = num1 - float.Parse(txtView.Text);
                    txtView.Text = equals.ToString();
                    break;
                case 2:
                    equals = num1 + float.Parse(txtView.Text);
                    txtView.Text = equals.ToString();
                    break;
                case 3:
                    equals = num1 * float.Parse(txtView.Text);
                    txtView.Text = equals.ToString();
                    break;
                case 4:
                    equals = num1 / float.Parse(txtView.Text);
                    txtView.Text = equals.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int c = txtView.TextLength;
            int flag = 0;
            string text = txtView.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtView.Text = txtView.Text + ".";
            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + 0 + 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            txtSym.Clear();
            txtView.Clear();
            count = 0;
        }
    }
}
