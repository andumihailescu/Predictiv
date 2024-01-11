namespace Predictiv
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            numericUpDown1 = new NumericUpDown();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            numericUpDown2 = new NumericUpDown();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(54, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(360, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 256);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(669, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 256);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 271);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Original image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 271);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Error image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(735, 271);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Decoded image";
            // 
            // button1
            // 
            button1.Location = new Point(12, 294);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 6;
            button1.Text = "Load image";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 294);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 7;
            button2.Text = "Predict";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(240, 294);
            button3.Name = "button3";
            button3.Size = new Size(108, 29);
            button3.TabIndex = 8;
            button3.Text = "Store";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(857, 294);
            button4.Name = "button4";
            button4.Size = new Size(113, 29);
            button4.TabIndex = 11;
            button4.Text = "Save Decoded";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(743, 294);
            button5.Name = "button5";
            button5.Size = new Size(108, 29);
            button5.TabIndex = 10;
            button5.Text = "Decode";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(625, 294);
            button6.Name = "button6";
            button6.Size = new Size(112, 29);
            button6.TabIndex = 9;
            button6.Text = "Load encoded";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(453, 294);
            button7.Name = "button7";
            button7.Size = new Size(135, 29);
            button7.TabIndex = 12;
            button7.Text = "Show error matrix";
            button7.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numericUpDown1.Location = new Point(587, 338);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(54, 329);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(54, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "128";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(54, 359);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(40, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "A";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(54, 389);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(39, 24);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "B";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(54, 419);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(39, 24);
            radioButton4.TabIndex = 17;
            radioButton4.TabStop = true;
            radioButton4.Text = "C";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(54, 449);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(90, 24);
            radioButton5.TabIndex = 18;
            radioButton5.TabStop = true;
            radioButton5.Text = "A + B - C";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(54, 479);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(122, 24);
            radioButton6.TabIndex = 19;
            radioButton6.TabStop = true;
            radioButton6.Text = "A + (B - C) / 2";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(54, 509);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(122, 24);
            radioButton7.TabIndex = 20;
            radioButton7.TabStop = true;
            radioButton7.Text = "B + (A - C) / 2";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(54, 539);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(99, 24);
            radioButton8.TabIndex = 21;
            radioButton8.TabStop = true;
            radioButton8.Text = "(A + B) / 2";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(54, 569);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(75, 24);
            radioButton9.TabIndex = 22;
            radioButton9.TabStop = true;
            radioButton9.Text = "jpegLS";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(360, 329);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(83, 24);
            radioButton10.TabIndex = 23;
            radioButton10.TabStop = true;
            radioButton10.Text = "Original";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(360, 359);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(135, 24);
            radioButton11.TabIndex = 24;
            radioButton11.TabStop = true;
            radioButton11.Text = "Error protection";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(360, 389);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(91, 24);
            radioButton12.TabIndex = 25;
            radioButton12.TabStop = true;
            radioButton12.Text = "Decoded";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            numericUpDown2.Location = new Point(360, 416);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 26;
            numericUpDown2.Value = new decimal(new int[] { 3, 0, 0, 65536 });
            // 
            // button8
            // 
            button8.Location = new Point(360, 449);
            button8.Name = "button8";
            button8.Size = new Size(135, 29);
            button8.TabIndex = 27;
            button8.Text = "Show histogram";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(button8);
            Controls.Add(numericUpDown2);
            Controls.Add(radioButton12);
            Controls.Add(radioButton11);
            Controls.Add(radioButton10);
            Controls.Add(radioButton9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(numericUpDown1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private NumericUpDown numericUpDown1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private NumericUpDown numericUpDown2;
        private Button button8;
    }
}
