using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterverbruik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Ensures that one radio button is selected by default.
            TariffZeroRadioButton.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            
            decimal tariffOne = 100m + 0.25m * cubicMetresUpDown.Value;
            decimal tariffTwo = 75m + 0.38m * cubicMetresUpDown.Value;
            //Decides which tariff is used.
            if (TariffOneRadioButton.Checked)
                resultTextBox.Text = Math.Round(tariffOne, 2).ToString();
            else if (TariffTwoRadioButton.Checked)
                resultTextBox.Text = Math.Round(tariffTwo, 2).ToString();
            else if(tariffOne < tariffTwo)
                resultTextBox.Text = Math.Round(tariffOne, 2).ToString();
            else
                resultTextBox.Text = Math.Round(tariffTwo, 2).ToString();
        }
    }
}
