using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vlaggen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Location for pictureBoxes.
            int hLoc = 60;
            int vLoc = 50;

            
             
            foreach (string flags in imageList1.Images.Keys) 
            {
                int screenWidth = flagPanel.Width;
                int screenHeight = flagPanel.Height;

                //Creation and configurations of pictureBoxes.
                PictureBox flag = new PictureBox();
                flag.Image = imageList1.Images[flags];

                flag.Height = 110;
                flag.Width = 165;
                flag.Name = flags;
                flag.Location = new Point(hLoc, vLoc);
                flagPanel.Controls.Add(flag);
                //Location of name labels in relation to pictureBoxes.
                int flagNameVLoc = vLoc + 110;
                int flagNameHLoc = hLoc + 30;
                //Creation and configuration of labels for pictureboxes.
                Label flagName = new Label();
                flagName.Text = flag.Name;
                int i = flagName.Text.IndexOf('.');
                flagName.Text = flagName.Text.Substring(0, i);
                flagName.BackColor = Color.FromArgb(20, 20, 20);
                flagName.ForeColor = Color.White;
                flagName.BorderStyle = BorderStyle.None;
                flagName.TextAlign = ContentAlignment.MiddleCenter;
                flagName.Location = new Point(flagNameHLoc, flagNameVLoc);
                flagPanel.Controls.Add(flagName);
                //Change horizontal location of pictureBoxes.
                hLoc += 175;

                if (flag.Location.X + flag.Width >= screenWidth - flag.Width)
                {
                    //Resets horizontal location and changes vertical location of pictureBoxes.
                    hLoc = 60;
                    vLoc += 150;
                }

                

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }
        //Initializes  the objects.
        Panel testPanel = new Panel();
        PictureBox testFlag = new PictureBox();
        Panel answerPanel = new Panel();
        Label correctCount = new Label();
        //Tracks correct answers.
        int counter = 0;
        //Stores correct answer.
        string answer;
        public void test_CLick(object sender, EventArgs e)
        {
            //Hides panels containing pictureboxes and buttons that need to be inaccessable.
            flagPanel.Hide();
            buttonPanel.Hide();


            //Creates new panels.
            testPanel.Dock = DockStyle.Top;
            testPanel.Height = 440;
            Controls.Add(testPanel);

            answerPanel.Dock = DockStyle.Bottom;
            answerPanel.Height = 140;
            answerPanel.BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(answerPanel);
            //Creates a label that views the amount of correct answers.
            correctCount.Dock = DockStyle.Right;
            correctCount.BackColor = Color.FromArgb(30, 30, 30);
            correctCount.ForeColor = Color.White;
            correctCount.BorderStyle = BorderStyle.None;
            correctCount.Text = string.Format("Correct: {0}", counter);
            answerPanel.Controls.Add(correctCount);
            
            Random rng = new Random();
            
            //Sets picturebox size and location.
            testFlag.Size = new Size(200, 200);
            int x = 340;
            int y = 200;
            testFlag.Location = new Point(x, y);



            //Generates a random number within the amount of images in imageList1.
            //Uses random number to pick an image.
            //Adds image.
            //Converts image keys to string.
            //Gets position of ".".
            //Stores image name without extension.
            int rngFlag = rng.Next(imageList1.Images.Count);
            testFlag.Image = imageList1.Images[rngFlag];
            testPanel.Controls.Add(testFlag);
            testFlag.Name = imageList1.Images.Keys[rngFlag].ToString();
            int i = testFlag.Name.IndexOf('.');
            string option1 = testFlag.Name.Substring(0, i);

            rngFlag = rng.Next(imageList1.Images.Count);
            testFlag.Image = imageList1.Images[rngFlag];
            testPanel.Controls.Add(testFlag);
            testFlag.Name = imageList1.Images.Keys[rngFlag].ToString();
            i = testFlag.Name.IndexOf('.');
            string option2 = testFlag.Name.Substring(0, i);

            rngFlag = rng.Next(imageList1.Images.Count);
            testFlag.Image = imageList1.Images[rngFlag];
            testPanel.Controls.Add(testFlag);
            testFlag.Name = imageList1.Images.Keys[rngFlag].ToString();
            i = testFlag.Name.IndexOf('.');
            string option3 = testFlag.Name.Substring(0, i);

            rngFlag = rng.Next(imageList1.Images.Count);
            testFlag.Image = imageList1.Images[rngFlag];
            testPanel.Controls.Add(testFlag);
            testFlag.Name = imageList1.Images.Keys[rngFlag].ToString();
            i = testFlag.Name.IndexOf('.');
            answer = testFlag.Name.Substring(0, i);

            //Array with image names.
            string[] options = new string[4];
            options[0] = answer;
            options[1] = option1;
            options[2] = option2;
            options[3] = option3;
            //Shuffles 4 numbers.
            var indexes = Enumerable.Range(0, 4).OrderBy(i => rng.Next());
            //Location of first answerButton.
            int ansX = 265;
            int ansY = 5;
            

            foreach (int index in indexes)
            {   //Creates answerButtons and puts answers on them.
                Button answerButton = new Button();
                answerButton.Width = 300;
                answerButton.Height = 25;
                answerButton.FlatStyle = FlatStyle.Flat;
                answerButton.BackColor = Color.White;
                answerButton.Location = new Point(ansX, ansY);
                string answerText = options[index];
                answerButton.Text = answerText;
                answerPanel.Controls.Add(answerButton);
                answerButton.Click += answer_CLick;
                //Changes answerButton vertical location.
                ansY += 30;

                
            }


            //Creates a button that goes back to previous panels.
            Button backButton = new Button();
            backButton.BackColor = Color.White;
            backButton.Text = "Back";
            answerPanel.Controls.Add(backButton);
            backButton.Click += back_CLick;
            
            
        }
        
        private void answer_CLick(object sender, EventArgs e)
        {
                
                Button button = (Button)sender;

                
                //Checks if answer is true and restarts test.
                if (button.Text == answer)
                {
                
                    correctCount.Text = string.Format("Correct: {0}", counter);
                    counter += 1;
                }
                answerPanel.Controls.Clear();
                test_CLick(this, new EventArgs());

        }

        private void back_CLick(object sender, EventArgs e)
        {
            //Resets counter.
            counter = 0;
            //Shows starting panels.
            flagPanel.Show();
            buttonPanel.Show();
            //removes current panels.
            Controls.Remove(testPanel);
            testFlag.Controls.Clear();
            Controls.Remove(answerPanel);
            answerPanel.Controls.Clear();



        }

    }

}
