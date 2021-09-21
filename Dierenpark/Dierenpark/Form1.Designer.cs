
namespace Dierenpark
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kidsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MarriedCheckBox = new System.Windows.Forms.CheckBox();
            this.ageDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kidsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // kidsNumericUpDown
            // 
            this.kidsNumericUpDown.Location = new System.Drawing.Point(98, 60);
            this.kidsNumericUpDown.Name = "kidsNumericUpDown";
            this.kidsNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.kidsNumericUpDown.TabIndex = 0;
            this.kidsNumericUpDown.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // MarriedCheckBox
            // 
            this.MarriedCheckBox.AutoSize = true;
            this.MarriedCheckBox.Location = new System.Drawing.Point(98, 25);
            this.MarriedCheckBox.Name = "MarriedCheckBox";
            this.MarriedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MarriedCheckBox.TabIndex = 1;
            this.MarriedCheckBox.UseVisualStyleBackColor = true;
            this.MarriedCheckBox.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // ageDateTimePicker
            // 
            this.ageDateTimePicker.CustomFormat = "";
            this.ageDateTimePicker.Location = new System.Drawing.Point(98, 103);
            this.ageDateTimePicker.Name = "ageDateTimePicker";
            this.ageDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.ageDateTimePicker.TabIndex = 2;
            this.ageDateTimePicker.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(98, 144);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(100, 20);
            this.answerTextBox.TabIndex = 3;
            this.answerTextBox.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Echtpaar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kinderen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geboortedatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultaat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 190);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.ageDateTimePicker);
            this.Controls.Add(this.MarriedCheckBox);
            this.Controls.Add(this.kidsNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dierenpark abonnementen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kidsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown kidsNumericUpDown;
        private System.Windows.Forms.CheckBox MarriedCheckBox;
        private System.Windows.Forms.DateTimePicker ageDateTimePicker;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

