using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator_Example
{
    
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum Is : " + sum);
            }
        }

        bool ValidateInputs()
        {
            bool isValid = true;

            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را واردکنید");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را واردکنید");
                }
            }

            return isValid;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int Minus = calculate.Minus(int.Parse(txtNumber1.Value.ToString()), int.Parse(txtNumber2.Value.ToString()));
                MessageBox.Show("Minus is : " + Minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Multiple Is : " + multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Divide Is : " + divide);
            }
        }
    }
}
