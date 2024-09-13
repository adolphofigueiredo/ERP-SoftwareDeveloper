namespace _20240913_Windows_Form_APP
{
    partial class frmEsempio
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
            btnSaluta = new Button();
            txtNominativo = new TextBox();
            SuspendLayout();
            // 
            // btnSaluta
            // 
            btnSaluta.Enabled = false;
            btnSaluta.Location = new Point(630, 20);
            btnSaluta.Name = "btnSaluta";
            btnSaluta.Size = new Size(100, 23);
            btnSaluta.TabIndex = 0;
            btnSaluta.Text = "Saluta";
            btnSaluta.UseVisualStyleBackColor = true;
            btnSaluta.Click += btnSaluta_Click;
            // 
            // txtNominativo
            // 
            txtNominativo.Location = new Point(20, 20);
            txtNominativo.Name = "txtNominativo";
            txtNominativo.Size = new Size(500, 23);
            txtNominativo.TabIndex = 1;
            txtNominativo.TextChanged += txtNominativo_TextChanged;
            // 
            // frmEsempio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNominativo);
            Controls.Add(btnSaluta);
            Name = "frmEsempio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaluta;
        private TextBox txtNominativo;
    }
}
