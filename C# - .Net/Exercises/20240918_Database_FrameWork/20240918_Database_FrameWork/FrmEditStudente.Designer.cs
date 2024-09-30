namespace _20240918_Database_FrameWork
{
    partial class FrmEditStudente
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
            this.txtCodiceFiscale = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataDiNascita = new System.Windows.Forms.DateTimePicker();
            this.cboCorso = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblCodiceFiscale = new System.Windows.Forms.Label();
            this.lblDataDiNascita = new System.Windows.Forms.Label();
            this.lblCorso = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodiceFiscale
            // 
            this.txtCodiceFiscale.Location = new System.Drawing.Point(93, 64);
            this.txtCodiceFiscale.Name = "txtCodiceFiscale";
            this.txtCodiceFiscale.Size = new System.Drawing.Size(234, 20);
            this.txtCodiceFiscale.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(93, 38);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(234, 20);
            this.txtCognome.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 20);
            this.txtNome.TabIndex = 3;
            // 
            // dtpDataDiNascita
            // 
            this.dtpDataDiNascita.Location = new System.Drawing.Point(93, 90);
            this.dtpDataDiNascita.Name = "dtpDataDiNascita";
            this.dtpDataDiNascita.Size = new System.Drawing.Size(234, 20);
            this.dtpDataDiNascita.TabIndex = 4;
            // 
            // cboCorso
            // 
            this.cboCorso.FormattingEnabled = true;
            this.cboCorso.Location = new System.Drawing.Point(93, 116);
            this.cboCorso.Name = "cboCorso";
            this.cboCorso.Size = new System.Drawing.Size(234, 21);
            this.cboCorso.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(10, 41);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 7;
            this.lblCognome.Text = "Cognome";
            // 
            // lblCodiceFiscale
            // 
            this.lblCodiceFiscale.AutoSize = true;
            this.lblCodiceFiscale.Location = new System.Drawing.Point(10, 67);
            this.lblCodiceFiscale.Name = "lblCodiceFiscale";
            this.lblCodiceFiscale.Size = new System.Drawing.Size(76, 13);
            this.lblCodiceFiscale.TabIndex = 8;
            this.lblCodiceFiscale.Text = "Codice Fiscale";
            // 
            // lblDataDiNascita
            // 
            this.lblDataDiNascita.AutoSize = true;
            this.lblDataDiNascita.Location = new System.Drawing.Point(10, 94);
            this.lblDataDiNascita.Name = "lblDataDiNascita";
            this.lblDataDiNascita.Size = new System.Drawing.Size(80, 13);
            this.lblDataDiNascita.TabIndex = 9;
            this.lblDataDiNascita.Text = "Data di Nascita";
            // 
            // lblCorso
            // 
            this.lblCorso.AutoSize = true;
            this.lblCorso.Location = new System.Drawing.Point(10, 121);
            this.lblCorso.Name = "lblCorso";
            this.lblCorso.Size = new System.Drawing.Size(34, 13);
            this.lblCorso.TabIndex = 10;
            this.lblCorso.Text = "Corso";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(314, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // FrmEditStudente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 176);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCorso);
            this.Controls.Add(this.lblDataDiNascita);
            this.Controls.Add(this.lblCodiceFiscale);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cboCorso);
            this.Controls.Add(this.dtpDataDiNascita);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtCodiceFiscale);
            this.Name = "FrmEditStudente";
            this.Text = "Edit Studente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataDiNascita;
        private System.Windows.Forms.ComboBox cboCorso;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.Label lblDataDiNascita;
        private System.Windows.Forms.Label lblCorso;
        private System.Windows.Forms.Button btnSave;
    }
}