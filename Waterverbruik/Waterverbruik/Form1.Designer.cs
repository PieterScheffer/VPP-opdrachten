
namespace Waterverbruik
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
            this.resultButton = new System.Windows.Forms.Button();
            this.tariffGroupBox = new System.Windows.Forms.GroupBox();
            this.TariffOneRadioButton = new System.Windows.Forms.RadioButton();
            this.TariffTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.TariffZeroRadioButton = new System.Windows.Forms.RadioButton();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cubicMetresUpDown = new System.Windows.Forms.NumericUpDown();
            this.tariffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubicMetresUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(50, 222);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(75, 23);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "Resultaat";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // tariffGroupBox
            // 
            this.tariffGroupBox.Controls.Add(this.TariffZeroRadioButton);
            this.tariffGroupBox.Controls.Add(this.TariffTwoRadioButton);
            this.tariffGroupBox.Controls.Add(this.TariffOneRadioButton);
            this.tariffGroupBox.Location = new System.Drawing.Point(50, 31);
            this.tariffGroupBox.Name = "tariffGroupBox";
            this.tariffGroupBox.Size = new System.Drawing.Size(229, 138);
            this.tariffGroupBox.TabIndex = 1;
            this.tariffGroupBox.TabStop = false;
            this.tariffGroupBox.Text = "Tarief";
            // 
            // TariffOneRadioButton
            // 
            this.TariffOneRadioButton.AutoSize = true;
            this.TariffOneRadioButton.Location = new System.Drawing.Point(6, 55);
            this.TariffOneRadioButton.Name = "TariffOneRadioButton";
            this.TariffOneRadioButton.Size = new System.Drawing.Size(182, 30);
            this.TariffOneRadioButton.TabIndex = 0;
            this.TariffOneRadioButton.TabStop = true;
            this.TariffOneRadioButton.Text = "Tarief 1: €100,- vaste kosten per \r\njaar en €0,25 per m3 gebruikt.";
            this.TariffOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // TariffTwoRadioButton
            // 
            this.TariffTwoRadioButton.AutoSize = true;
            this.TariffTwoRadioButton.Location = new System.Drawing.Point(6, 91);
            this.TariffTwoRadioButton.Name = "TariffTwoRadioButton";
            this.TariffTwoRadioButton.Size = new System.Drawing.Size(176, 30);
            this.TariffTwoRadioButton.TabIndex = 1;
            this.TariffTwoRadioButton.TabStop = true;
            this.TariffTwoRadioButton.Text = "Tarief 2: €75,- vaste kosten per \r\njaar en €0,38 per m3 gebruikt.\r\n";
            this.TariffTwoRadioButton.UseVisualStyleBackColor = true;
            // 
            // TariffZeroRadioButton
            // 
            this.TariffZeroRadioButton.AutoSize = true;
            this.TariffZeroRadioButton.Location = new System.Drawing.Point(6, 19);
            this.TariffZeroRadioButton.Name = "TariffZeroRadioButton";
            this.TariffZeroRadioButton.Size = new System.Drawing.Size(219, 30);
            this.TariffZeroRadioButton.TabIndex = 2;
            this.TariffZeroRadioButton.TabStop = true;
            this.TariffZeroRadioButton.Text = "Tarief 0: Gebruikt het goedkoopste tarief \r\ngebaseerd op m3 water gebruikt.";
            this.TariffZeroRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(175, 225);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "€";
            // 
            // cubicMetresUpDown
            // 
            this.cubicMetresUpDown.Location = new System.Drawing.Point(50, 184);
            this.cubicMetresUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cubicMetresUpDown.Name = "cubicMetresUpDown";
            this.cubicMetresUpDown.Size = new System.Drawing.Size(75, 20);
            this.cubicMetresUpDown.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 268);
            this.Controls.Add(this.cubicMetresUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.tariffGroupBox);
            this.Controls.Add(this.resultButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Waterverbruik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tariffGroupBox.ResumeLayout(false);
            this.tariffGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cubicMetresUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.GroupBox tariffGroupBox;
        private System.Windows.Forms.RadioButton TariffTwoRadioButton;
        private System.Windows.Forms.RadioButton TariffOneRadioButton;
        private System.Windows.Forms.RadioButton TariffZeroRadioButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cubicMetresUpDown;
    }
}

