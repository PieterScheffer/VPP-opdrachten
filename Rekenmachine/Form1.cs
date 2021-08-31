using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        Decimal resultValue = 0;
        String operationPerformed = "";
        Boolean isCalculationFinished = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {   //Makes sure textBoxResult is zero and not blank. Also resets textBoxResult to zero after a calculation finishes.
            if ((textBoxResult.Text == "0") || isCalculationFinished == true)
                textBoxResult.Clear();

            isCalculationFinished = false;
            //Adds the text of the button that has been pressed to textBoxResult.
            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;
        }
        
        private void operator_Click(object sender, EventArgs e)
        {   //Stores the operation and the operated on value and previews them. Also resets textBoxResult.
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Decimal.Parse(textBoxResult.Text);
            currentOperationText.Text = resultValue + " " + operationPerformed;
            textBoxResult.Text = "0";
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            //Resets all values.
            textBoxResult.Text = "0";
            Decimal resultValue = 0;
            currentOperationText.Text = "0";
            currentOperationText.Text = "";
            Button[] Saveslots = { saveSlot1, saveSlot2, saveSlot3, saveSlot4, saveSlot5, saveSlot6, saveSlot7, saveSlot8, saveSlot9 };
            for (int i = 0; i <= 8;)
            {
                Saveslots[i].Text = "";
                i++;
            }
        }

        private void equalTo_Click(object sender, EventArgs e)
        {
            //Writes out full calculation above the rusult.
            currentOperationText.Text = currentOperationText.Text + " " + textBoxResult.Text + " =";
            //Determines which operator is used.
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
                       
            }
            //Causes button_Click to set textBoxResult to zero before adding new values.
            isCalculationFinished = true;
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            //Determines how the percentage button is used depending on operation performed.
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = ((resultValue / 100) * Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = ((resultValue / 100) * Decimal.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (Decimal.Parse(textBoxResult.Text) / 100).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (Decimal.Parse(textBoxResult.Text) / 100).ToString();
                    break;
                default:
                    break;

            }

        }
  
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Writes textBoxResult to Button text.
            Button[] Saveslots = { saveSlot1, saveSlot2, saveSlot3, saveSlot4, saveSlot5, saveSlot6, saveSlot7, saveSlot8, saveSlot9};

            int i = 0;

            while (Saveslots[i].Text != "" && i < 8)
            {
                i ++;
            }

            Saveslots[i].Text = textBoxResult.Text;
            
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //Loads previously stored text by pressing buttons.
            Button button = (Button)sender;
            
            if (button.Text != "")
            textBoxResult.Text = button.Text;

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            //removes one digit from textBoxResult.
            if (textBoxResult.Text.Length != 1)
            {
                textBoxResult.Text = textBoxResult.Text.Remove (textBoxResult.Text.Length - 1);
            }
            else
            {
                textBoxResult.Text = "0";

            }
        
        }

    }
        
        
}
