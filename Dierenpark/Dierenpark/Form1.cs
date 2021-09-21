using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dierenpark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Custom format to only show date and not day of week.
            ageDateTimePicker.Format = DateTimePickerFormat.Custom;
            ageDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            //Gets age.
            int age = DateTime.Today.Year - (ageDateTimePicker.Value.Year);
            //Default subscription.
            Decimal subscription = 30m;
            //Changes subscription based on parameters.
            if (MarriedCheckBox.Checked == true)
            {
                subscription = 61;
                if (age >= 65)
                    subscription = 65;
                    if(kidsNumericUpDown.Value > 0)
                        subscription -= 1;
            }
            else
                if (age >= 65)
                    subscription = 26;
            

            //Puts result of subscription plus children times child price and rounds it to two decimals.
            answerTextBox.Text = Math.Round(subscription + (kidsNumericUpDown.Value * 11m), 2).ToString();

        }
    }
}
