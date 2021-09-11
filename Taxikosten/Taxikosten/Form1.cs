using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxikosten
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "dddd d-M-yyyy   HH : mm";

            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "dddd d-M-yyyy   HH : mm";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calc_Button_Click(object sender, EventArgs e)
        {
      
            decimal minutes = Convert.ToDecimal(endDateTimePicker.Value.Subtract(startDateTimePicker.Value).TotalMinutes);

            if (startDateTimePicker.Value.DayOfWeek == DayOfWeek.Friday && startDateTimePicker.Value.Hour > 22 || startDateTimePicker.Value.DayOfWeek == DayOfWeek.Saturday || startDateTimePicker.Value.DayOfWeek == DayOfWeek.Sunday
               || startDateTimePicker.Value.DayOfWeek == DayOfWeek.Monday && startDateTimePicker.Value.Hour < 7)
            {
                if (startDateTimePicker.Value.Hour < 8 && startDateTimePicker.Value.Hour > 18)
                    resultTextBox.Text = Math.Round((minutes * 0.45m) * 1.15m, 2).ToString();
                else
                    resultTextBox.Text = Math.Round((minutes * 0.25m) * 1.15m, 2).ToString();

            }
            else
            {

                if (startDateTimePicker.Value.Hour < 8 && startDateTimePicker.Value.Hour > 18)
                    resultTextBox.Text = Math.Round(minutes * 0.45m, 2).ToString();
                else
                    resultTextBox.Text = Math.Round(minutes * 0.25m, 2).ToString();

            }
            



        }

    }
}
