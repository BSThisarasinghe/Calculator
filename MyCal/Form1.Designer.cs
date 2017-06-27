namespace MyCal
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.clearAll = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(199, 36);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearAll
            // 
            this.clearAll.Location = new System.Drawing.Point(12, 54);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(45, 36);
            this.clearAll.TabIndex = 1;
            this.clearAll.Text = "CA";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(63, 54);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(96, 36);
            this.clear.TabIndex = 2;
            this.clear.Text = "<--";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(165, 54);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(45, 36);
            this.mul.TabIndex = 4;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.button4_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(12, 96);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 36);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(63, 96);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 36);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(114, 96);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 36);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(165, 96);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(45, 36);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 138);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 36);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(63, 138);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 36);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(114, 138);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 36);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(165, 138);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(45, 36);
            this.sub.TabIndex = 12;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 180);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 36);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(63, 180);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 36);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(114, 180);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 36);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(165, 180);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(45, 78);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(12, 222);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(45, 36);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(63, 222);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(45, 36);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(114, 222);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(45, 36);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 276);
            this.Controls.Add(this.label);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.div);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.textBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label label;
    }
}

