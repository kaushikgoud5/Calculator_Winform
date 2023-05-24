using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int num1;
        int num2;
        string option;
        int result;


        private void btn2_Click(object sender, EventArgs e)
        {
            total.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            total.Text += btn1.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            total.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            total.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            total.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            total.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            total.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            total.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            total.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            total.Text += btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total.Clear();
            result = 0;
            num2 = 0;
            num1 = 0;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(total.Text);
            total.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            option = "-";
            num1 = int.Parse(total.Text);
            total.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {

            option = "*";
            num1 = int.Parse(total.Text);
            total.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            option = "/";
            num1 = int.Parse(total.Text);
            total.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(total.Text);
            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
            total.Text = result + "";
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}