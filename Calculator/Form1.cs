using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form;
    {
        Double resultValue = 0;
        String operationPerformed = " ";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {            
            if(text_box.Text == "0" || isOperationPerformed)
            {
                text_box.Clear();
                isOperationPerformed = false;
            }
            Button button = sender as Button;            
            text_box.Text = text_box.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(text_box.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            text_box.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_box.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text_box.Text = "0";
            resultValue = 0;
        }

        private void result(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    text_box.Text = (resultValue + Double.Parse(text_box.Text)).ToString();
                    break;
                case "-":
                    text_box.Text = (resultValue - Double.Parse(text_box.Text)).ToString();
                    break;
                case "/":
                    text_box.Text = (resultValue / Double.Parse(text_box.Text)).ToString();
                    break;
                case "x":
                    text_box.Text = (resultValue * Double.Parse(text_box.Text)).ToString();
                    break;               
            }
            isOperationPerformed = true;
            if (isOperationPerformed)            
            { 
                labelCurrentOperation.Text = " ";
            }
        }

        private void labelCurrentOperation_Click(object sender, EventArgs e)
        {

        }
    }
}
