namespace SD_320_Assignment
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
            this.AppTitle = new System.Windows.Forms.Label();
            this.textBoxPanel = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonNo7 = new System.Windows.Forms.Button();
            this.buttonNo8 = new System.Windows.Forms.Button();
            this.buttonNo9 = new System.Windows.Forms.Button();
            this.buttonNo4 = new System.Windows.Forms.Button();
            this.buttonNo5 = new System.Windows.Forms.Button();
            this.buttonNo6 = new System.Windows.Forms.Button();
            this.buttonNo1 = new System.Windows.Forms.Button();
            this.buttonNo2 = new System.Windows.Forms.Button();
            this.buttonNo3 = new System.Windows.Forms.Button();
            this.buttonSigned = new System.Windows.Forms.Button();
            this.buttonNo0 = new System.Windows.Forms.Button();
            this.buttonDecimalPoint = new System.Windows.Forms.Button();
            this.buttonEqualsSign = new System.Windows.Forms.Button();
            this.buttonPlusSign = new System.Windows.Forms.Button();
            this.buttonMinusSign = new System.Windows.Forms.Button();
            this.buttonMultiplySign = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDivideSign = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.textBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AccessibleDescription = "Application Title Calculator";
            this.AppTitle.AccessibleName = "Application TItle";
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppTitle.Location = new System.Drawing.Point(12, 9);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(102, 25);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "Calculator";
            this.AppTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.AccessibleDescription = "Textbox Output Screen";
            this.textBoxPanel.AccessibleName = "Output Screen";
            this.textBoxPanel.BackColor = System.Drawing.Color.White;
            this.textBoxPanel.Controls.Add(this.textBoxOutput);
            this.textBoxPanel.Location = new System.Drawing.Point(16, 37);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPanel.Size = new System.Drawing.Size(294, 61);
            this.textBoxPanel.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AccessibleDescription = "Output Screen with operation";
            this.textBoxOutput.AccessibleName = "Output Screen";
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(72, 20);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(219, 16);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Text = "0";
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // buttonNo7
            // 
            this.buttonNo7.AccessibleDescription = "Keypad Number 7";
            this.buttonNo7.AccessibleName = "Button 7";
            this.buttonNo7.Location = new System.Drawing.Point(16, 160);
            this.buttonNo7.Name = "buttonNo7";
            this.buttonNo7.Size = new System.Drawing.Size(69, 51);
            this.buttonNo7.TabIndex = 2;
            this.buttonNo7.Text = "7";
            this.buttonNo7.UseVisualStyleBackColor = true;
            this.buttonNo7.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo8
            // 
            this.buttonNo8.AccessibleDescription = "Keypad Number 8";
            this.buttonNo8.AccessibleName = "Button 8";
            this.buttonNo8.Location = new System.Drawing.Point(91, 160);
            this.buttonNo8.Name = "buttonNo8";
            this.buttonNo8.Size = new System.Drawing.Size(69, 51);
            this.buttonNo8.TabIndex = 3;
            this.buttonNo8.Text = "8";
            this.buttonNo8.UseVisualStyleBackColor = true;
            this.buttonNo8.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo9
            // 
            this.buttonNo9.AccessibleDescription = "Keypad Number 9";
            this.buttonNo9.AccessibleName = "Button 9";
            this.buttonNo9.Location = new System.Drawing.Point(166, 160);
            this.buttonNo9.Name = "buttonNo9";
            this.buttonNo9.Size = new System.Drawing.Size(69, 51);
            this.buttonNo9.TabIndex = 4;
            this.buttonNo9.Text = "9";
            this.buttonNo9.UseVisualStyleBackColor = true;
            this.buttonNo9.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo4
            // 
            this.buttonNo4.AccessibleDescription = "Keypad Number 4";
            this.buttonNo4.AccessibleName = "Button 4";
            this.buttonNo4.Location = new System.Drawing.Point(16, 217);
            this.buttonNo4.Name = "buttonNo4";
            this.buttonNo4.Size = new System.Drawing.Size(69, 51);
            this.buttonNo4.TabIndex = 5;
            this.buttonNo4.Text = "4";
            this.buttonNo4.UseVisualStyleBackColor = true;
            this.buttonNo4.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo5
            // 
            this.buttonNo5.AccessibleDescription = "Keypad Number 5";
            this.buttonNo5.AccessibleName = "Button 5";
            this.buttonNo5.Location = new System.Drawing.Point(91, 217);
            this.buttonNo5.Name = "buttonNo5";
            this.buttonNo5.Size = new System.Drawing.Size(69, 51);
            this.buttonNo5.TabIndex = 6;
            this.buttonNo5.Text = "5";
            this.buttonNo5.UseVisualStyleBackColor = true;
            this.buttonNo5.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo6
            // 
            this.buttonNo6.AccessibleDescription = "Keypad Number 6";
            this.buttonNo6.AccessibleName = "Button 6";
            this.buttonNo6.Location = new System.Drawing.Point(166, 217);
            this.buttonNo6.Name = "buttonNo6";
            this.buttonNo6.Size = new System.Drawing.Size(69, 51);
            this.buttonNo6.TabIndex = 7;
            this.buttonNo6.Text = "6";
            this.buttonNo6.UseVisualStyleBackColor = true;
            this.buttonNo6.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo1
            // 
            this.buttonNo1.AccessibleDescription = "Keypad Number 1";
            this.buttonNo1.AccessibleName = "Button 1";
            this.buttonNo1.Location = new System.Drawing.Point(16, 274);
            this.buttonNo1.Name = "buttonNo1";
            this.buttonNo1.Size = new System.Drawing.Size(69, 51);
            this.buttonNo1.TabIndex = 8;
            this.buttonNo1.Text = "1";
            this.buttonNo1.UseVisualStyleBackColor = true;
            this.buttonNo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo2
            // 
            this.buttonNo2.AccessibleDescription = "Keypad Number 2";
            this.buttonNo2.AccessibleName = "Button 2";
            this.buttonNo2.Location = new System.Drawing.Point(91, 274);
            this.buttonNo2.Name = "buttonNo2";
            this.buttonNo2.Size = new System.Drawing.Size(69, 51);
            this.buttonNo2.TabIndex = 9;
            this.buttonNo2.Text = "2";
            this.buttonNo2.UseVisualStyleBackColor = true;
            this.buttonNo2.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNo3
            // 
            this.buttonNo3.AccessibleDescription = "Keypad number 3";
            this.buttonNo3.AccessibleName = "Button 3";
            this.buttonNo3.Location = new System.Drawing.Point(166, 274);
            this.buttonNo3.Name = "buttonNo3";
            this.buttonNo3.Size = new System.Drawing.Size(69, 51);
            this.buttonNo3.TabIndex = 10;
            this.buttonNo3.Text = "3";
            this.buttonNo3.UseVisualStyleBackColor = true;
            this.buttonNo3.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSigned
            // 
            this.buttonSigned.AccessibleDescription = "Keypad for positive/negative sign";
            this.buttonSigned.AccessibleName = "Button Sign";
            this.buttonSigned.Location = new System.Drawing.Point(16, 331);
            this.buttonSigned.Name = "buttonSigned";
            this.buttonSigned.Size = new System.Drawing.Size(69, 51);
            this.buttonSigned.TabIndex = 11;
            this.buttonSigned.Text = "+/-";
            this.buttonSigned.UseVisualStyleBackColor = true;
            // 
            // buttonNo0
            // 
            this.buttonNo0.AccessibleDescription = "Keypad Number 0";
            this.buttonNo0.AccessibleName = "Button 0";
            this.buttonNo0.Location = new System.Drawing.Point(91, 331);
            this.buttonNo0.Name = "buttonNo0";
            this.buttonNo0.Size = new System.Drawing.Size(69, 51);
            this.buttonNo0.TabIndex = 12;
            this.buttonNo0.Text = "0";
            this.buttonNo0.UseVisualStyleBackColor = true;
            this.buttonNo0.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDecimalPoint
            // 
            this.buttonDecimalPoint.AccessibleDescription = "Keypad Decimal Point";
            this.buttonDecimalPoint.AccessibleName = "Button Decimal Point";
            this.buttonDecimalPoint.Location = new System.Drawing.Point(166, 331);
            this.buttonDecimalPoint.Name = "buttonDecimalPoint";
            this.buttonDecimalPoint.Size = new System.Drawing.Size(69, 51);
            this.buttonDecimalPoint.TabIndex = 13;
            this.buttonDecimalPoint.Text = ".";
            this.buttonDecimalPoint.UseVisualStyleBackColor = true;
            this.buttonDecimalPoint.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonEqualsSign
            // 
            this.buttonEqualsSign.AccessibleDescription = "Keypad Equals Sign";
            this.buttonEqualsSign.AccessibleName = "Button Equals Sign";
            this.buttonEqualsSign.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEqualsSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEqualsSign.Location = new System.Drawing.Point(241, 331);
            this.buttonEqualsSign.Name = "buttonEqualsSign";
            this.buttonEqualsSign.Size = new System.Drawing.Size(69, 51);
            this.buttonEqualsSign.TabIndex = 14;
            this.buttonEqualsSign.Text = "=";
            this.buttonEqualsSign.UseVisualStyleBackColor = false;
            // 
            // buttonPlusSign
            // 
            this.buttonPlusSign.AccessibleDescription = "Keypad Plus Sign";
            this.buttonPlusSign.AccessibleName = "Button Plus Sign";
            this.buttonPlusSign.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPlusSign.Location = new System.Drawing.Point(241, 274);
            this.buttonPlusSign.Name = "buttonPlusSign";
            this.buttonPlusSign.Size = new System.Drawing.Size(69, 51);
            this.buttonPlusSign.TabIndex = 15;
            this.buttonPlusSign.Text = "+";
            this.buttonPlusSign.UseVisualStyleBackColor = false;
            this.buttonPlusSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMinusSign
            // 
            this.buttonMinusSign.AccessibleDescription = "Keypad Minus Sign";
            this.buttonMinusSign.AccessibleName = "Button Minus Sign";
            this.buttonMinusSign.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMinusSign.Location = new System.Drawing.Point(241, 217);
            this.buttonMinusSign.Name = "buttonMinusSign";
            this.buttonMinusSign.Size = new System.Drawing.Size(69, 51);
            this.buttonMinusSign.TabIndex = 16;
            this.buttonMinusSign.Text = "-";
            this.buttonMinusSign.UseVisualStyleBackColor = false;
            this.buttonMinusSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonMultiplySign
            // 
            this.buttonMultiplySign.AccessibleDescription = "Keypad Multiply Sign";
            this.buttonMultiplySign.AccessibleName = "Button Multiply Sign";
            this.buttonMultiplySign.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMultiplySign.Location = new System.Drawing.Point(241, 160);
            this.buttonMultiplySign.Name = "buttonMultiplySign";
            this.buttonMultiplySign.Size = new System.Drawing.Size(69, 51);
            this.buttonMultiplySign.TabIndex = 17;
            this.buttonMultiplySign.Text = "x";
            this.buttonMultiplySign.UseVisualStyleBackColor = false;
            this.buttonMultiplySign.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.AccessibleDescription = "Keypad Clear";
            this.buttonClear.AccessibleName = "Button Clear";
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.Location = new System.Drawing.Point(16, 104);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(144, 50);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDivideSign
            // 
            this.buttonDivideSign.AccessibleDescription = "Keypad Divide Sign";
            this.buttonDivideSign.AccessibleName = "Button Divide Sign";
            this.buttonDivideSign.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDivideSign.Location = new System.Drawing.Point(241, 104);
            this.buttonDivideSign.Name = "buttonDivideSign";
            this.buttonDivideSign.Size = new System.Drawing.Size(69, 50);
            this.buttonDivideSign.TabIndex = 20;
            this.buttonDivideSign.Text = "÷";
            this.buttonDivideSign.UseVisualStyleBackColor = false;
            this.buttonDivideSign.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.AccessibleDescription = "Keypad Clear Entry";
            this.buttonClearEntry.AccessibleName = "Button Clear Entry";
            this.buttonClearEntry.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonClearEntry.Location = new System.Drawing.Point(166, 104);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(69, 50);
            this.buttonClearEntry.TabIndex = 21;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonDivideSign);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiplySign);
            this.Controls.Add(this.buttonMinusSign);
            this.Controls.Add(this.buttonPlusSign);
            this.Controls.Add(this.buttonEqualsSign);
            this.Controls.Add(this.buttonDecimalPoint);
            this.Controls.Add(this.buttonNo0);
            this.Controls.Add(this.buttonSigned);
            this.Controls.Add(this.buttonNo3);
            this.Controls.Add(this.buttonNo2);
            this.Controls.Add(this.buttonNo1);
            this.Controls.Add(this.buttonNo6);
            this.Controls.Add(this.buttonNo5);
            this.Controls.Add(this.buttonNo4);
            this.Controls.Add(this.buttonNo9);
            this.Controls.Add(this.buttonNo8);
            this.Controls.Add(this.buttonNo7);
            this.Controls.Add(this.textBoxPanel);
            this.Controls.Add(this.AppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.textBoxPanel.ResumeLayout(false);
            this.textBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AppTitle;
        private Panel textBoxPanel;
        private Button buttonNo7;
        private Button buttonNo8;
        private Button buttonNo9;
        private Button buttonNo4;
        private Button buttonNo5;
        private Button buttonNo6;
        private Button buttonNo1;
        private Button buttonNo2;
        private Button buttonNo3;
        private Button buttonSigned;
        private Button buttonNo0;
        private Button buttonDecimalPoint;
        private Button buttonEqualsSign;
        private Button buttonPlusSign;
        private Button buttonMinusSign;
        private Button buttonMultiplySign;
        private Button buttonClear;
        private Button buttonDivideSign;
        private Button buttonClearEntry;
        private TextBox textBoxOutput;
    }
}