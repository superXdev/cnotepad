namespace CNotepad
{
    partial class PasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.lengthNum = new System.Windows.Forms.NumericUpDown();
            this.alphaBox = new System.Windows.Forms.CheckBox();
            this.alphaCapitalBox = new System.Windows.Forms.CheckBox();
            this.numBox = new System.Windows.Forms.CheckBox();
            this.symbolsBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(365, 10);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(75, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // lengthNum
            // 
            this.lengthNum.Location = new System.Drawing.Point(63, 66);
            this.lengthNum.Name = "lengthNum";
            this.lengthNum.Size = new System.Drawing.Size(58, 20);
            this.lengthNum.TabIndex = 3;
            this.lengthNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // alphaBox
            // 
            this.alphaBox.AutoSize = true;
            this.alphaBox.Checked = true;
            this.alphaBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alphaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaBox.Location = new System.Drawing.Point(12, 38);
            this.alphaBox.Name = "alphaBox";
            this.alphaBox.Size = new System.Drawing.Size(59, 20);
            this.alphaBox.TabIndex = 4;
            this.alphaBox.Text = "[a - z]";
            this.alphaBox.UseVisualStyleBackColor = true;
            // 
            // alphaCapitalBox
            // 
            this.alphaCapitalBox.AutoSize = true;
            this.alphaCapitalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaCapitalBox.Location = new System.Drawing.Point(81, 38);
            this.alphaCapitalBox.Name = "alphaCapitalBox";
            this.alphaCapitalBox.Size = new System.Drawing.Size(62, 20);
            this.alphaCapitalBox.TabIndex = 5;
            this.alphaCapitalBox.Text = "[A - Z]";
            this.alphaCapitalBox.UseVisualStyleBackColor = true;
            // 
            // numBox
            // 
            this.numBox.AutoSize = true;
            this.numBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox.Location = new System.Drawing.Point(149, 38);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(59, 20);
            this.numBox.TabIndex = 6;
            this.numBox.Text = "[0 - 9]";
            this.numBox.UseVisualStyleBackColor = true;
            // 
            // symbolsBox
            // 
            this.symbolsBox.AutoSize = true;
            this.symbolsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsBox.Location = new System.Drawing.Point(214, 38);
            this.symbolsBox.Name = "symbolsBox";
            this.symbolsBox.Size = new System.Drawing.Size(80, 20);
            this.symbolsBox.TabIndex = 7;
            this.symbolsBox.Text = "Symbols";
            this.symbolsBox.UseVisualStyleBackColor = true;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 102);
            this.Controls.Add(this.symbolsBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.alphaCapitalBox);
            this.Controls.Add(this.alphaBox);
            this.Controls.Add(this.lengthNum);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.NumericUpDown lengthNum;
        private System.Windows.Forms.CheckBox alphaBox;
        private System.Windows.Forms.CheckBox alphaCapitalBox;
        private System.Windows.Forms.CheckBox numBox;
        private System.Windows.Forms.CheckBox symbolsBox;
    }
}