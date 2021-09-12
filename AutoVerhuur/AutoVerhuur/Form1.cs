using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVerhuur
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
            //Sets button to checket to make sure it isnt empty.
            autoRadioButton.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            decimal kmPrice;
            decimal dayRate;
            decimal kmPriceTotal;

            decimal gasolinePrice = 1.793m;
            //Gets number of days between start and enddate, adds one to include today and converts to decimal.
            decimal days = Convert.ToDecimal(endDateTimePicker.Value.Subtract(startDateTimePicker.Value).TotalDays + 1);
            //Tests wich radiobutton is chacked and assigns corresponding value.
            if (autoRadioButton.Checked == true)
            {
                kmPrice = 0.20m;
                dayRate = 50;
            }
            else
            {
                kmPrice = 0.30m;
                dayRate = 95;
            }
            //Tests if input is below 100 and stores it as 0 or input - 100.
            if (kmUpDown.Value < 100)
            {
                kmPriceTotal = 0;
            }
            else
            {
                kmPriceTotal = (kmUpDown.Value - 100) * kmPrice;
            }
            //Calculates total and puts it in resultTextbox.Text.
            resultTextBox.Text = Math.Round((days * dayRate) + kmPriceTotal + (litersUpDown.Value * gasolinePrice),2).ToString();

        }
    }
}
