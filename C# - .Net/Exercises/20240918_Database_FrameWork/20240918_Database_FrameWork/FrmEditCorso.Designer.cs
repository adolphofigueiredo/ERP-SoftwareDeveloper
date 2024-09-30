namespace _20240918_Database_FrameWork
{
    partial class FrmEditCorso
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
            this.lblCorso = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblInizioCorso = new System.Windows.Forms.Label();
            this.lblFineCorso = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDataFine = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblCorso
            // 
            this.lblCorso.AutoSize = true;
            this.lblCorso.Location = new System.Drawing.Point(14, 15);
            this.lblCorso.Name = "lblCorso";
            this.lblCorso.Size = new System.Drawing.Size(65, 13);
            this.lblCorso.TabIndex = 0;
            this.lblCorso.Text = "Nome Corso";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(85, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(254, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblInizioCorso
            // 
            this.lblInizioCorso.AutoSize = true;
            this.lblInizioCorso.Location = new System.Drawing.Point(14, 41);
            this.lblInizioCorso.Name = "lblInizioCorso";
            this.lblInizioCorso.Size = new System.Drawing.Size(31, 13);
            this.lblInizioCorso.TabIndex = 2;
            this.lblInizioCorso.Text = "Inizio";
            // 
            // lblFineCorso
            // 
            this.lblFineCorso.AutoSize = true;
            this.lblFineCorso.Location = new System.Drawing.Point(14, 67);
            this.lblFineCorso.Name = "lblFineCorso";
            this.lblFineCorso.Size = new System.Drawing.Size(27, 13);
            this.lblFineCorso.TabIndex = 4;
            this.lblFineCorso.Text = "Fine";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(322, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // dtpDataFine
            // 
            this.dtpDataFine.Location = new System.Drawing.Point(85, 64);
            this.dtpDataFine.Name = "dtpDataFine";
            this.dtpDataFine.Size = new System.Drawing.Size(254, 20);
            this.dtpDataFine.TabIndex = 7;
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Location = new System.Drawing.Point(85, 38);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(254, 20);
            this.dtpDataInizio.TabIndex = 8;
            // 
            // FrmEditCorso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 129);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.dtpDataFine);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFineCorso);
            this.Controls.Add(this.lblInizioCorso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCorso);
            this.Name = "FrmEditCorso";
            this.Text = "Edit Corso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblInizioCorso;
        private System.Windows.Forms.Label lblFineCorso;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDataFine;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
    }
}