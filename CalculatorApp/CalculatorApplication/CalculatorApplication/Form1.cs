using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // txtDisplay.Text = txtDisplay.Focus;
            txtDisplay.Focus();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnPoints.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length- 1);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        int value1, value2, answer;
        bool addition = false;
        bool substraction = false;
        bool multipliction = false;
        bool division = false;
        bool power = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
             addition = true;
             substraction = false;
             multipliction = false;
             division = false;
             txtDisplay.Clear();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
            addition = false;
            substraction = true;
            multipliction = false;
            division = false;
            txtDisplay.Clear();
        }

        private void btnMultipy_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
            addition = false;
            substraction = false;
            multipliction = true;
            division = false;
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
            addition = false;
            substraction = false;
            multipliction = false;
            division = true;
            txtDisplay.Clear();
        }


        private void btnPower_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
            addition = false;
            substraction = false;
            multipliction = false;
            division = false;
            power = true;
            txtDisplay.Clear();
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value2 = int.Parse(txtDisplay.Text);
            if (addition)
            {
                answer = value1 + value2;
                txtDisplay.Text = answer.ToString();

            }

            if (substraction)
            {
                answer = value1 - value2;
                txtDisplay.Text = answer.ToString();

            }

            if (multipliction)
            {
                answer = value1 * value2;
                txtDisplay.Text = answer.ToString();

            }

            if (division)
            {
                if (value2==0)
                {
                    txtDisplay.Text = "Error can't display result";
                }
                else
                {
                    answer = value1/value2;
                    txtDisplay.Text = answer.ToString();
                }
                
            }
               
            if (power)
            {
                int i,answer=value1;
                for (i=0; i<value2; i++)
                {
                    answer *= value1;
                    txtDisplay.Text = answer.ToString();
                }

            }


        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(txtDisplay.Text);
            answer = 1;
            for (int i=0;i<value1;i++)
            {
                answer *= value1;
                txtDisplay.Text = answer.ToString();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1cs about = new AboutBox1cs();
            about.ShowDialog();

        }


    }
}
