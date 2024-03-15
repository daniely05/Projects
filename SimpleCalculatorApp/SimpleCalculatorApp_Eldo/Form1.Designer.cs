namespace SimpleCalculatorApp_Eldo
{
    partial class frmCalculator
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
            btnEnter = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            tbText = new TextBox();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnZero = new Button();
            btnPoint = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.IndianRed;
            btnEnter.Font = new Font("Segoe UI", 15F);
            btnEnter.Location = new Point(257, 375);
            btnEnter.Margin = new Padding(3, 4, 3, 4);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(95, 224);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            btnEnter.KeyPress += btnEnter_KeyPress_1;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.Plum;
            btnPlus.Font = new Font("Segoe UI", 20F);
            btnPlus.Location = new Point(257, 247);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(95, 120);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            btnPlus.KeyPress += btnPlus_KeyPress_1;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Plum;
            btnMinus.Font = new Font("Segoe UI", 20F);
            btnMinus.Location = new Point(257, 183);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(95, 56);
            btnMinus.TabIndex = 2;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            btnMinus.KeyPress += btnMinus_KeyPress;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Plum;
            btnDivide.Font = new Font("Segoe UI", 20F);
            btnDivide.Location = new Point(109, 185);
            btnDivide.Margin = new Padding(3, 4, 3, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(67, 53);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            btnDivide.KeyPress += btnDivide_KeyPress;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Plum;
            btnMultiply.Font = new Font("Segoe UI", 20F);
            btnMultiply.Location = new Point(183, 185);
            btnMultiply.Margin = new Padding(3, 4, 3, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(67, 53);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            btnMultiply.KeyPress += btnMultiply_KeyPress;
            // 
            // tbText
            // 
            tbText.BackColor = Color.FromArgb(172, 190, 165);
            tbText.Font = new Font("Segoe UI", 20F);
            tbText.Location = new Point(24, 93);
            tbText.Margin = new Padding(3, 4, 3, 4);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.Size = new Size(326, 80);
            tbText.TabIndex = 5;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(224, 224, 224);
            btnNine.Font = new Font("Segoe UI", 20F);
            btnNine.Location = new Point(183, 247);
            btnNine.Margin = new Padding(3, 4, 3, 4);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(67, 72);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            btnNine.KeyPress += btnNine_KeyPress;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(224, 224, 224);
            btnEight.Font = new Font("Segoe UI", 20F);
            btnEight.Location = new Point(109, 247);
            btnEight.Margin = new Padding(3, 4, 3, 4);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(67, 72);
            btnEight.TabIndex = 7;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            btnEight.KeyPress += btnEight_KeyPress;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(224, 224, 224);
            btnSeven.Font = new Font("Segoe UI", 20F);
            btnSeven.Location = new Point(33, 247);
            btnSeven.Margin = new Padding(3, 4, 3, 4);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(69, 72);
            btnSeven.TabIndex = 8;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            btnSeven.KeyPress += btnSeven_KeyPress;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(224, 224, 224);
            btnFour.Font = new Font("Segoe UI", 20F);
            btnFour.Location = new Point(33, 340);
            btnFour.Margin = new Padding(3, 4, 3, 4);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(69, 72);
            btnFour.TabIndex = 11;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            btnFour.KeyPress += btnFour_KeyPress;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(224, 224, 224);
            btnFive.Font = new Font("Segoe UI", 20F);
            btnFive.Location = new Point(109, 340);
            btnFive.Margin = new Padding(3, 4, 3, 4);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(67, 72);
            btnFive.TabIndex = 10;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            btnFive.KeyPress += btnFive_KeyPress;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(224, 224, 224);
            btnSix.Font = new Font("Segoe UI", 20F);
            btnSix.Location = new Point(183, 340);
            btnSix.Margin = new Padding(3, 4, 3, 4);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(67, 72);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            btnSix.KeyPress += btnSix_KeyPress;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(224, 224, 224);
            btnOne.Font = new Font("Segoe UI", 20F);
            btnOne.Location = new Point(33, 433);
            btnOne.Margin = new Padding(3, 4, 3, 4);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(69, 72);
            btnOne.TabIndex = 14;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            btnOne.KeyPress += btnOne_KeyPress;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(224, 224, 224);
            btnTwo.Font = new Font("Segoe UI", 20F);
            btnTwo.Location = new Point(109, 433);
            btnTwo.Margin = new Padding(3, 4, 3, 4);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(67, 72);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            btnTwo.KeyPress += btnTwo_KeyPress;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(224, 224, 224);
            btnThree.Font = new Font("Segoe UI", 20F);
            btnThree.Location = new Point(183, 433);
            btnThree.Margin = new Padding(3, 4, 3, 4);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(67, 72);
            btnThree.TabIndex = 12;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            btnThree.KeyPress += btnThree_KeyPress;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(224, 224, 224);
            btnZero.Font = new Font("Segoe UI", 20F);
            btnZero.Location = new Point(34, 527);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(142, 72);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            btnZero.KeyPress += btnZero_KeyPress;
            // 
            // btnPoint
            // 
            btnPoint.BackColor = Color.LightSkyBlue;
            btnPoint.Font = new Font("Segoe UI", 20F);
            btnPoint.Location = new Point(183, 527);
            btnPoint.Margin = new Padding(3, 4, 3, 4);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(67, 72);
            btnPoint.TabIndex = 15;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = false;
            btnPoint.Click += btnPoint_Click;
            btnPoint.KeyPress += btnPoint_KeyPress;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.Font = new Font("Segoe UI", 20F);
            btnClear.Location = new Point(33, 185);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 53);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            btnClear.KeyPress += btnClear_KeyPress;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 640);
            Controls.Add(btnClear);
            Controls.Add(btnZero);
            Controls.Add(btnPoint);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(tbText);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnEnter);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCalculator";
            Text = "Calculator";
            KeyPress += frmCalculator_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnDivide;
        private Button btnMultiply;
        private TextBox tbText;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnZero;
        private Button btnPoint;
        private Button btnClear;
    }
}
