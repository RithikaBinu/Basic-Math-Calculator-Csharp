namespace Fourth
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnClear = new Button();
            button11 = new Button();
            btnEquals = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Yu Gothic UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(47, 55);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(705, 51);
            txtDisplay.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(73, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 51);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(211, 144);
            button2.Name = "button2";
            button2.Size = new Size(94, 51);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RosyBrown;
            button3.Location = new Point(360, 144);
            button3.Name = "button3";
            button3.Size = new Size(94, 51);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RosyBrown;
            button4.Location = new Point(73, 225);
            button4.Name = "button4";
            button4.Size = new Size(94, 51);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.RosyBrown;
            button5.Location = new Point(211, 225);
            button5.Name = "button5";
            button5.Size = new Size(94, 51);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.RosyBrown;
            button6.Location = new Point(360, 225);
            button6.Name = "button6";
            button6.Size = new Size(94, 51);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberButton_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.RosyBrown;
            button7.Location = new Point(73, 305);
            button7.Name = "button7";
            button7.Size = new Size(94, 51);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberButton_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.RosyBrown;
            button8.Location = new Point(211, 305);
            button8.Name = "button8";
            button8.Size = new Size(94, 51);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.RosyBrown;
            button9.Location = new Point(360, 305);
            button9.Name = "button9";
            button9.Size = new Size(94, 51);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberButton_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Location = new Point(73, 387);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 51);
            btnClear.TabIndex = 10;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.RosyBrown;
            button11.Location = new Point(211, 387);
            button11.Name = "button11";
            button11.Size = new Size(94, 51);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += NumberButton_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.RosyBrown;
            btnEquals.Location = new Point(360, 387);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(94, 51);
            btnEquals.TabIndex = 12;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.RosyBrown;
            button13.Location = new Point(519, 144);
            button13.Name = "button13";
            button13.Size = new Size(94, 51);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += OperatorButton_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.RosyBrown;
            button14.Location = new Point(519, 225);
            button14.Name = "button14";
            button14.Size = new Size(94, 51);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += OperatorButton_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.RosyBrown;
            button15.Location = new Point(519, 305);
            button15.Name = "button15";
            button15.Size = new Size(94, 51);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            button15.Click += OperatorButton_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.RosyBrown;
            button16.Location = new Point(519, 387);
            button16.Name = "button16";
            button16.Size = new Size(94, 51);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += OperatorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tomato;
            ClientSize = new Size(800, 478);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(btnEquals);
            Controls.Add(button11);
            Controls.Add(btnClear);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnClear;
        private Button button11;
        private Button btnEquals;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}
