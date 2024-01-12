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
            pbOriginalImage = new PictureBox();
            pbErrorImage = new PictureBox();
            pbDecodedImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLoadImage = new Button();
            btnPredict = new Button();
            btnStore = new Button();
            btnSaveDecoded = new Button();
            btnDecode = new Button();
            btnLoadEncoded = new Button();
            btnShowErrorMatrix = new Button();
            numericUpDown1 = new NumericUpDown();
            rb128 = new RadioButton();
            rbA = new RadioButton();
            rbB = new RadioButton();
            rbC = new RadioButton();
            rbABC = new RadioButton();
            rbABC2 = new RadioButton();
            rbBAC2 = new RadioButton();
            rbAB2 = new RadioButton();
            rbJpegLS = new RadioButton();
            rbOriginal = new RadioButton();
            rbErrorProtection = new RadioButton();
            rbDecoded = new RadioButton();
            numericUpDown2 = new NumericUpDown();
            btnShowHistogram = new Button();
            ((System.ComponentModel.ISupportInitialize)pbOriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbErrorImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDecodedImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // pbOriginalImage
            // 
            pbOriginalImage.Location = new Point(54, 12);
            pbOriginalImage.Name = "pbOriginalImage";
            pbOriginalImage.Size = new Size(256, 256);
            pbOriginalImage.TabIndex = 0;
            pbOriginalImage.TabStop = false;
            // 
            // pbErrorImage
            // 
            pbErrorImage.Location = new Point(360, 12);
            pbErrorImage.Name = "pbErrorImage";
            pbErrorImage.Size = new Size(256, 256);
            pbErrorImage.TabIndex = 1;
            pbErrorImage.TabStop = false;
            // 
            // pbDecodedImage
            // 
            pbDecodedImage.Location = new Point(669, 12);
            pbDecodedImage.Name = "pbDecodedImage";
            pbDecodedImage.Size = new Size(256, 256);
            pbDecodedImage.TabIndex = 2;
            pbDecodedImage.TabStop = false;
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
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(12, 294);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(108, 29);
            btnLoadImage.TabIndex = 6;
            btnLoadImage.Text = "Load image";
            btnLoadImage.UseVisualStyleBackColor = true;
            btnLoadImage.Click += btnLoadImage_Click;
            // 
            // btnPredict
            // 
            btnPredict.Location = new Point(126, 294);
            btnPredict.Name = "btnPredict";
            btnPredict.Size = new Size(108, 29);
            btnPredict.TabIndex = 7;
            btnPredict.Text = "Predict";
            btnPredict.UseVisualStyleBackColor = true;
            btnPredict.Click += btnPredict_Click;
            // 
            // btnStore
            // 
            btnStore.Location = new Point(240, 294);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(108, 29);
            btnStore.TabIndex = 8;
            btnStore.Text = "Store";
            btnStore.UseVisualStyleBackColor = true;
            // 
            // btnSaveDecoded
            // 
            btnSaveDecoded.Location = new Point(857, 294);
            btnSaveDecoded.Name = "btnSaveDecoded";
            btnSaveDecoded.Size = new Size(113, 29);
            btnSaveDecoded.TabIndex = 11;
            btnSaveDecoded.Text = "Save Decoded";
            btnSaveDecoded.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(743, 294);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(108, 29);
            btnDecode.TabIndex = 10;
            btnDecode.Text = "Decode";
            btnDecode.UseVisualStyleBackColor = true;
            // 
            // btnLoadEncoded
            // 
            btnLoadEncoded.Location = new Point(625, 294);
            btnLoadEncoded.Name = "btnLoadEncoded";
            btnLoadEncoded.Size = new Size(112, 29);
            btnLoadEncoded.TabIndex = 9;
            btnLoadEncoded.Text = "Load encoded";
            btnLoadEncoded.UseVisualStyleBackColor = true;
            // 
            // btnShowErrorMatrix
            // 
            btnShowErrorMatrix.Location = new Point(453, 294);
            btnShowErrorMatrix.Name = "btnShowErrorMatrix";
            btnShowErrorMatrix.Size = new Size(135, 29);
            btnShowErrorMatrix.TabIndex = 12;
            btnShowErrorMatrix.Text = "Show error matrix";
            btnShowErrorMatrix.UseVisualStyleBackColor = true;
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
            // rb128
            // 
            rb128.AutoSize = true;
            rb128.Checked = true;
            rb128.Location = new Point(54, 329);
            rb128.Name = "rb128";
            rb128.Size = new Size(54, 24);
            rb128.TabIndex = 14;
            rb128.TabStop = true;
            rb128.Text = "128";
            rb128.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            rbA.AutoSize = true;
            rbA.Location = new Point(54, 359);
            rbA.Name = "rbA";
            rbA.Size = new Size(40, 24);
            rbA.TabIndex = 15;
            rbA.Text = "A";
            rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            rbB.AutoSize = true;
            rbB.Location = new Point(54, 389);
            rbB.Name = "rbB";
            rbB.Size = new Size(39, 24);
            rbB.TabIndex = 16;
            rbB.Text = "B";
            rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            rbC.AutoSize = true;
            rbC.Location = new Point(54, 419);
            rbC.Name = "rbC";
            rbC.Size = new Size(39, 24);
            rbC.TabIndex = 17;
            rbC.Text = "C";
            rbC.UseVisualStyleBackColor = true;
            // 
            // rbABC
            // 
            rbABC.AutoSize = true;
            rbABC.Location = new Point(54, 449);
            rbABC.Name = "rbABC";
            rbABC.Size = new Size(90, 24);
            rbABC.TabIndex = 18;
            rbABC.Text = "A + B - C";
            rbABC.UseVisualStyleBackColor = true;
            // 
            // rbABC2
            // 
            rbABC2.AutoSize = true;
            rbABC2.Location = new Point(54, 479);
            rbABC2.Name = "rbABC2";
            rbABC2.Size = new Size(122, 24);
            rbABC2.TabIndex = 19;
            rbABC2.Text = "A + (B - C) / 2";
            rbABC2.UseVisualStyleBackColor = true;
            // 
            // rbBAC2
            // 
            rbBAC2.AutoSize = true;
            rbBAC2.Location = new Point(54, 509);
            rbBAC2.Name = "rbBAC2";
            rbBAC2.Size = new Size(122, 24);
            rbBAC2.TabIndex = 20;
            rbBAC2.Text = "B + (A - C) / 2";
            rbBAC2.UseVisualStyleBackColor = true;
            // 
            // rbAB2
            // 
            rbAB2.AutoSize = true;
            rbAB2.Location = new Point(54, 539);
            rbAB2.Name = "rbAB2";
            rbAB2.Size = new Size(99, 24);
            rbAB2.TabIndex = 21;
            rbAB2.Text = "(A + B) / 2";
            rbAB2.UseVisualStyleBackColor = true;
            // 
            // rbJpegLS
            // 
            rbJpegLS.AutoSize = true;
            rbJpegLS.Location = new Point(54, 569);
            rbJpegLS.Name = "rbJpegLS";
            rbJpegLS.Size = new Size(75, 24);
            rbJpegLS.TabIndex = 22;
            rbJpegLS.Text = "jpegLS";
            rbJpegLS.UseVisualStyleBackColor = true;
            // 
            // rbOriginal
            // 
            rbOriginal.AutoSize = true;
            rbOriginal.Location = new Point(360, 329);
            rbOriginal.Name = "rbOriginal";
            rbOriginal.Size = new Size(83, 24);
            rbOriginal.TabIndex = 23;
            rbOriginal.Text = "Original";
            rbOriginal.UseVisualStyleBackColor = true;
            // 
            // rbErrorProtection
            // 
            rbErrorProtection.AutoSize = true;
            rbErrorProtection.Location = new Point(360, 359);
            rbErrorProtection.Name = "rbErrorProtection";
            rbErrorProtection.Size = new Size(135, 24);
            rbErrorProtection.TabIndex = 24;
            rbErrorProtection.Text = "Error protection";
            rbErrorProtection.UseVisualStyleBackColor = true;
            // 
            // rbDecoded
            // 
            rbDecoded.AutoSize = true;
            rbDecoded.Location = new Point(360, 389);
            rbDecoded.Name = "rbDecoded";
            rbDecoded.Size = new Size(91, 24);
            rbDecoded.TabIndex = 25;
            rbDecoded.Text = "Decoded";
            rbDecoded.UseVisualStyleBackColor = true;
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
            // btnShowHistogram
            // 
            btnShowHistogram.Location = new Point(360, 449);
            btnShowHistogram.Name = "btnShowHistogram";
            btnShowHistogram.Size = new Size(135, 29);
            btnShowHistogram.TabIndex = 27;
            btnShowHistogram.Text = "Show histogram";
            btnShowHistogram.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btnShowHistogram);
            Controls.Add(numericUpDown2);
            Controls.Add(rbDecoded);
            Controls.Add(rbErrorProtection);
            Controls.Add(rbOriginal);
            Controls.Add(rbJpegLS);
            Controls.Add(rbAB2);
            Controls.Add(rbBAC2);
            Controls.Add(rbABC2);
            Controls.Add(rbABC);
            Controls.Add(rbC);
            Controls.Add(rbB);
            Controls.Add(rbA);
            Controls.Add(rb128);
            Controls.Add(numericUpDown1);
            Controls.Add(btnShowErrorMatrix);
            Controls.Add(btnSaveDecoded);
            Controls.Add(btnDecode);
            Controls.Add(btnLoadEncoded);
            Controls.Add(btnStore);
            Controls.Add(btnPredict);
            Controls.Add(btnLoadImage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbDecodedImage);
            Controls.Add(pbErrorImage);
            Controls.Add(pbOriginalImage);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbOriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbErrorImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDecodedImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbOriginalImage;
        private PictureBox pbErrorImage;
        private PictureBox pbDecodedImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnLoadImage;
        private Button btnPredict;
        private Button btnStore;
        private Button btnSaveDecoded;
        private Button btnDecode;
        private Button btnLoadEncoded;
        private Button btnShowErrorMatrix;
        private NumericUpDown numericUpDown1;
        private RadioButton rb128;
        private RadioButton rbA;
        private RadioButton rbB;
        private RadioButton rbC;
        private RadioButton rbABC;
        private RadioButton rbABC2;
        private RadioButton rbBAC2;
        private RadioButton rbAB2;
        private RadioButton rbJpegLS;
        private RadioButton rbOriginal;
        private RadioButton rbErrorProtection;
        private RadioButton rbDecoded;
        private NumericUpDown numericUpDown2;
        private Button btnShowHistogram;
    }
}
