namespace _20240917_Calculator_V4._0
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
            btn_00 = new Button();
            btn_01 = new Button();
            btn_02 = new Button();
            btn_03 = new Button();
            btn_04 = new Button();
            btn_05 = new Button();
            btn_06 = new Button();
            btn_07 = new Button();
            btn_08 = new Button();
            btn_09 = new Button();
            btn_Equal = new Button();
            btn_plus = new Button();
            btn_minus = new Button();
            btn_multiplication = new Button();
            btn_division = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btn_00
            // 
            btn_00.Location = new Point(10, 149);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(75, 23);
            btn_00.TabIndex = 0;
            btn_00.Text = "0";
            btn_00.UseVisualStyleBackColor = true;
            // 
            // btn_01
            // 
            btn_01.Location = new Point(10, 120);
            btn_01.Name = "btn_01";
            btn_01.Size = new Size(75, 23);
            btn_01.TabIndex = 1;
            btn_01.Text = "1";
            btn_01.UseVisualStyleBackColor = true;
            btn_01.Click += btn_01_Click;
            // 
            // btn_02
            // 
            btn_02.Location = new Point(91, 120);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(75, 23);
            btn_02.TabIndex = 2;
            btn_02.Text = "2";
            btn_02.UseVisualStyleBackColor = true;
            // 
            // btn_03
            // 
            btn_03.Location = new Point(172, 120);
            btn_03.Name = "btn_03";
            btn_03.Size = new Size(75, 23);
            btn_03.TabIndex = 3;
            btn_03.Text = "3";
            btn_03.UseVisualStyleBackColor = true;
            // 
            // btn_04
            // 
            btn_04.Location = new Point(10, 91);
            btn_04.Name = "btn_04";
            btn_04.Size = new Size(75, 23);
            btn_04.TabIndex = 4;
            btn_04.Text = "4";
            btn_04.UseVisualStyleBackColor = true;
            // 
            // btn_05
            // 
            btn_05.Location = new Point(91, 91);
            btn_05.Name = "btn_05";
            btn_05.Size = new Size(75, 23);
            btn_05.TabIndex = 5;
            btn_05.Text = "5";
            btn_05.UseVisualStyleBackColor = true;
            // 
            // btn_06
            // 
            btn_06.Location = new Point(172, 91);
            btn_06.Name = "btn_06";
            btn_06.Size = new Size(75, 23);
            btn_06.TabIndex = 6;
            btn_06.Text = "6";
            btn_06.UseVisualStyleBackColor = true;
            // 
            // btn_07
            // 
            btn_07.Location = new Point(10, 62);
            btn_07.Name = "btn_07";
            btn_07.Size = new Size(75, 23);
            btn_07.TabIndex = 7;
            btn_07.Text = "7";
            btn_07.UseVisualStyleBackColor = true;
            // 
            // btn_08
            // 
            btn_08.Location = new Point(91, 62);
            btn_08.Name = "btn_08";
            btn_08.Size = new Size(75, 23);
            btn_08.TabIndex = 8;
            btn_08.Text = "8";
            btn_08.UseVisualStyleBackColor = true;
            // 
            // btn_09
            // 
            btn_09.Location = new Point(172, 62);
            btn_09.Name = "btn_09";
            btn_09.Size = new Size(75, 23);
            btn_09.TabIndex = 9;
            btn_09.Text = "9";
            btn_09.UseVisualStyleBackColor = true;
            // 
            // btn_Equal
            // 
            btn_Equal.Location = new Point(91, 149);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(156, 23);
            btn_Equal.TabIndex = 10;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(253, 149);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(75, 23);
            btn_plus.TabIndex = 11;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(253, 120);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(75, 23);
            btn_minus.TabIndex = 12;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            // 
            // btn_multiplication
            // 
            btn_multiplication.Location = new Point(253, 91);
            btn_multiplication.Name = "btn_multiplication";
            btn_multiplication.Size = new Size(75, 23);
            btn_multiplication.TabIndex = 13;
            btn_multiplication.Text = "*";
            btn_multiplication.UseVisualStyleBackColor = true;
            btn_multiplication.Click += btn_multiplication_Click;
            // 
            // btn_division
            // 
            btn_division.Location = new Point(253, 62);
            btn_division.Name = "btn_division";
            btn_division.Size = new Size(75, 23);
            btn_division.TabIndex = 14;
            btn_division.Text = "/";
            btn_division.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 15;
            label1.Text = "Risultato";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 44);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 16;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 44);
            label3.Name = "label3";
            label3.Size = new Size(38, 23);
            label3.TabIndex = 17;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(38, 23);
            label4.TabIndex = 18;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 182);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_division);
            Controls.Add(btn_multiplication);
            Controls.Add(btn_minus);
            Controls.Add(btn_plus);
            Controls.Add(btn_Equal);
            Controls.Add(btn_09);
            Controls.Add(btn_08);
            Controls.Add(btn_07);
            Controls.Add(btn_06);
            Controls.Add(btn_05);
            Controls.Add(btn_04);
            Controls.Add(btn_03);
            Controls.Add(btn_02);
            Controls.Add(btn_01);
            Controls.Add(btn_00);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_00;
        private Button btn_01;
        private Button btn_02;
        private Button btn_03;
        private Button btn_04;
        private Button btn_05;
        private Button btn_06;
        private Button btn_07;
        private Button btn_08;
        private Button btn_09;
        private Button btn_Equal;
        private Button btn_plus;
        private Button btn_minus;
        private Button btn_multiplication;
        private Button btn_division;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
