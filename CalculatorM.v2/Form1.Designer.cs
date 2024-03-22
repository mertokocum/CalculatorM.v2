using System.Windows.Forms;
using System.Xml.Linq;

namespace CalculatorM.v2
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
            buttonSeven = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonZero = new Button();
            buttonPoint = new Button();
            buttonEquals = new Button();
            buttonSum = new Button();
            buttonDivide = new Button();
            buttonMultiply = new Button();
            buttonMinus = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            textBoxResult = new TextBox();
            label_selectedOperator = new Label();
            SuspendLayout();
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeven.Location = new Point(32, 131);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(100, 100);
            buttonSeven.TabIndex = 0;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += button_click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSix.Location = new Point(244, 237);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(100, 100);
            buttonSix.TabIndex = 5;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button_click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFive.Location = new Point(138, 237);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(100, 100);
            buttonFive.TabIndex = 6;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += button_click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFour.Location = new Point(32, 237);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(100, 100);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += button_click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNine.Location = new Point(244, 131);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(100, 100);
            buttonNine.TabIndex = 8;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += button_click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEight.Location = new Point(138, 131);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(100, 100);
            buttonEight.TabIndex = 9;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += button_click;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOne.Location = new Point(32, 343);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(100, 100);
            buttonOne.TabIndex = 12;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += button_click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTwo.Location = new Point(138, 343);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(100, 100);
            buttonTwo.TabIndex = 11;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += button_click;
            // 
            // buttonThree
            // 
            buttonThree.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThree.Location = new Point(244, 343);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(100, 100);
            buttonThree.TabIndex = 10;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += button_click;
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZero.Location = new Point(32, 449);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(206, 100);
            buttonZero.TabIndex = 15;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += button_click;
            // 
            // buttonPoint
            // 
            buttonPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPoint.Location = new Point(244, 449);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(100, 100);
            buttonPoint.TabIndex = 13;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += button_click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.FromArgb(127, 189, 82);
            buttonEquals.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEquals.Location = new Point(456, 343);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(100, 206);
            buttonEquals.TabIndex = 19;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.FromArgb(194, 212, 177);
            buttonSum.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSum.Location = new Point(350, 343);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(100, 100);
            buttonSum.TabIndex = 23;
            buttonSum.Text = "+";
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += math_operator_click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.FromArgb(194, 212, 177);
            buttonDivide.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(350, 237);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(100, 100);
            buttonDivide.TabIndex = 21;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += math_operator_click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.FromArgb(194, 212, 177);
            buttonMultiply.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(350, 131);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(100, 100);
            buttonMultiply.TabIndex = 20;
            buttonMultiply.Text = "X";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += math_operator_click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.FromArgb(194, 212, 177);
            buttonMinus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(350, 449);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(100, 100);
            buttonMinus.TabIndex = 24;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += math_operator_click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = Color.FromArgb(166, 185, 146);
            buttonCE.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCE.Location = new Point(456, 131);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(100, 100);
            buttonCE.TabIndex = 26;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.FromArgb(166, 185, 146);
            buttonC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonC.Location = new Point(456, 237);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(100, 100);
            buttonC.TabIndex = 25;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_click;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = Color.FromArgb(162, 187, 207);
            textBoxResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxResult.Location = new Point(32, 75);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(524, 50);
            textBoxResult.TabIndex = 27;
            textBoxResult.Text = "0";
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // label_selectedOperator
            // 
            label_selectedOperator.AutoSize = true;
            label_selectedOperator.BackColor = Color.White;
            label_selectedOperator.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_selectedOperator.ForeColor = Color.FromArgb(194, 212, 177);
            label_selectedOperator.Location = new Point(32, 27);
            label_selectedOperator.Name = "label_selectedOperator";
            label_selectedOperator.Size = new Size(0, 45);
            label_selectedOperator.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(584, 561);
            Controls.Add(label_selectedOperator);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCE);
            Controls.Add(buttonC);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSum);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonEquals);
            Controls.Add(buttonZero);
            Controls.Add(buttonPoint);
            Controls.Add(buttonOne);
            Controls.Add(buttonTwo);
            Controls.Add(buttonThree);
            Controls.Add(buttonEight);
            Controls.Add(buttonNine);
            Controls.Add(buttonFour);
            Controls.Add(buttonFive);
            Controls.Add(buttonSix);
            Controls.Add(buttonSeven);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculatorM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSeven;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonZero;
        private Button buttonPoint;
        private Button buttonEquals;
        private Button buttonSum;
        private Button buttonDivide;
        private Button buttonMultiply;
        private Button buttonMinus;
        private Button buttonCE;
        private Button buttonC;
        private TextBox textBoxResult;
        private Label label_selectedOperator;
    }
}
