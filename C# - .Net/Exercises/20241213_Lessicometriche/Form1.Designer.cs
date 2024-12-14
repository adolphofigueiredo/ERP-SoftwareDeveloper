namespace _20241213_Lessicometriche
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
            lbl_SelezionaFile = new Label();
            txtbox_PercorsoFile = new TextBox();
            btn_SelezionaFile = new Button();
            btn_eseguire = new Button();
            richTextBoxRisultato = new RichTextBox();
            SuspendLayout();
            // 
            // lbl_SelezionaFile
            // 
            lbl_SelezionaFile.AutoSize = true;
            lbl_SelezionaFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SelezionaFile.Location = new Point(12, 10);
            lbl_SelezionaFile.Name = "lbl_SelezionaFile";
            lbl_SelezionaFile.Size = new Size(28, 15);
            lbl_SelezionaFile.TabIndex = 0;
            lbl_SelezionaFile.Text = "File:";
            // 
            // txtbox_PercorsoFile
            // 
            txtbox_PercorsoFile.Location = new Point(46, 10);
            txtbox_PercorsoFile.Name = "txtbox_PercorsoFile";
            txtbox_PercorsoFile.Size = new Size(610, 23);
            txtbox_PercorsoFile.TabIndex = 1;
            // 
            // btn_SelezionaFile
            // 
            btn_SelezionaFile.Location = new Point(662, 10);
            btn_SelezionaFile.Name = "btn_SelezionaFile";
            btn_SelezionaFile.Size = new Size(126, 23);
            btn_SelezionaFile.TabIndex = 2;
            btn_SelezionaFile.Text = "Seleziona File";
            btn_SelezionaFile.UseVisualStyleBackColor = true;
            btn_SelezionaFile.Click += btn_SelezionaFile_Click;
            // 
            // btn_eseguire
            // 
            btn_eseguire.Location = new Point(280, 39);
            btn_eseguire.Name = "btn_eseguire";
            btn_eseguire.Size = new Size(256, 23);
            btn_eseguire.TabIndex = 4;
            btn_eseguire.Text = "Analizza";
            btn_eseguire.UseVisualStyleBackColor = true;
            btn_eseguire.Click += btn_eseguire_Click;
            // 
            // richTextBoxRisultato
            // 
            richTextBoxRisultato.Location = new Point(12, 68);
            richTextBoxRisultato.Name = "richTextBoxRisultato";
            richTextBoxRisultato.Size = new Size(776, 183);
            richTextBoxRisultato.TabIndex = 5;
            richTextBoxRisultato.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 263);
            Controls.Add(richTextBoxRisultato);
            Controls.Add(btn_eseguire);
            Controls.Add(btn_SelezionaFile);
            Controls.Add(txtbox_PercorsoFile);
            Controls.Add(lbl_SelezionaFile);
            Name = "Form1";
            Text = "Lessicometriche";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_SelezionaFile;
        private TextBox txtbox_PercorsoFile;
        private Button btn_SelezionaFile;
        private Button btn_eseguire;
        private RichTextBox richTextBoxRisultato;
    }
}
