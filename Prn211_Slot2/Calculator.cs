using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prn211_Slot2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string number1 = txtNum1.Text;
            string number2 = txtNum2.Text;
            double num1 = 0, num2 = 0;
            bool isSuccess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            if (isSuccess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 + num2) + ".", "Ket Qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number Invalid. Try Again!", "Ket Qua", MessageBoxButtons.OK);
            }


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string number1 = txtNum1.Text;
            string number2 = txtNum2.Text;
            double num1 = 0, num2 = 0;
            bool isSuccess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            if (isSuccess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 - num2) + ".", "Ket Qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number Invalid. Try Again!", "Ket Qua", MessageBoxButtons.OK);
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            string number1 = txtNum1.Text;
            string number2 = txtNum2.Text;
            double num1 = 0, num2 = 0;
            bool isSuccess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            if (isSuccess && isSuccess2)
            {
                MessageBox.Show("Your result: " + (num1 * num2) + ".", "Ket Qua", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Number Invalid. Try Again!", "Ket Qua", MessageBoxButtons.OK);
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            string number1 = txtNum1.Text;
            string number2 = txtNum2.Text;
            double num1 = 0, num2 = 0;
            bool isSuccess = double.TryParse(number1, out num1);
            bool isSuccess2 = double.TryParse(number2, out num2);
            if (isSuccess && isSuccess2)
            {
                if(num2 == 0)
                {
                    MessageBox.Show("The Seond number must not be 0. Try Again!", "Ket Qua", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Your result: " + (num1 / num2) + ".", "Ket Qua", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Number Invalid. Try Again!", "Ket Qua", MessageBoxButtons.OK);
            }
        }
    }
}
