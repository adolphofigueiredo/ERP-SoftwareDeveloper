namespace DbExplorer_WinApp
{
    partial class FrmStudenti
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
            this.pnlCriteriRicerca = new System.Windows.Forms.Panel();
            this.btnCerca = new System.Windows.Forms.Button();
            this.pnlRisultatiRicerca = new System.Windows.Forms.Panel();
            this.dgvRisultati = new System.Windows.Forms.DataGridView();
            this.txtNominativoFilter = new System.Windows.Forms.TextBox();
            this.lblNominativo = new System.Windows.Forms.Label();
            this.lblDataDa = new System.Windows.Forms.Label();
            this.dtpNatoDaFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpNatoAFilter = new System.Windows.Forms.DateTimePicker();
            this.lblNatoA = new System.Windows.Forms.Label();
            this.pnlCriteriRicerca.SuspendLayout();
            this.pnlRisultatiRicerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCriteriRicerca
            // 
            this.pnlCriteriRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCriteriRicerca.Controls.Add(this.dtpNatoAFilter);
            this.pnlCriteriRicerca.Controls.Add(this.lblNatoA);
            this.pnlCriteriRicerca.Controls.Add(this.dtpNatoDaFilter);
            this.pnlCriteriRicerca.Controls.Add(this.lblDataDa);
            this.pnlCriteriRicerca.Controls.Add(this.lblNominativo);
            this.pnlCriteriRicerca.Controls.Add(this.txtNominativoFilter);
            this.pnlCriteriRicerca.Controls.Add(this.btnCerca);
            this.pnlCriteriRicerca.Location = new System.Drawing.Point(12, 12);
            this.pnlCriteriRicerca.Name = "pnlCriteriRicerca";
            this.pnlCriteriRicerca.Size = new System.Drawing.Size(881, 61);
            this.pnlCriteriRicerca.TabIndex = 0;
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Location = new System.Drawing.Point(751, 24);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(127, 23);
            this.btnCerca.TabIndex = 0;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // pnlRisultatiRicerca
            // 
            this.pnlRisultatiRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRisultatiRicerca.Controls.Add(this.dgvRisultati);
            this.pnlRisultatiRicerca.Location = new System.Drawing.Point(12, 79);
            this.pnlRisultatiRicerca.Name = "pnlRisultatiRicerca";
            this.pnlRisultatiRicerca.Size = new System.Drawing.Size(881, 368);
            this.pnlRisultatiRicerca.TabIndex = 1;
            // 
            // dgvRisultati
            // 
            this.dgvRisultati.AllowUserToAddRows = false;
            this.dgvRisultati.AllowUserToDeleteRows = false;
            this.dgvRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRisultati.Location = new System.Drawing.Point(0, 0);
            this.dgvRisultati.Name = "dgvRisultati";
            this.dgvRisultati.ReadOnly = true;
            this.dgvRisultati.RowHeadersWidth = 51;
            this.dgvRisultati.RowTemplate.Height = 24;
            this.dgvRisultati.Size = new System.Drawing.Size(881, 368);
            this.dgvRisultati.TabIndex = 0;
            // 
            // txtNominativoFilter
            // 
            this.txtNominativoFilter.Location = new System.Drawing.Point(3, 24);
            this.txtNominativoFilter.Name = "txtNominativoFilter";
            this.txtNominativoFilter.Size = new System.Drawing.Size(330, 22);
            this.txtNominativoFilter.TabIndex = 1;
            // 
            // lblNominativo
            // 
            this.lblNominativo.AutoSize = true;
            this.lblNominativo.Location = new System.Drawing.Point(3, 7);
            this.lblNominativo.Name = "lblNominativo";
            this.lblNominativo.Size = new System.Drawing.Size(203, 16);
            this.lblNominativo.TabIndex = 2;
            this.lblNominativo.Text = "Nominativo (nome e/o cognome)";
            // 
            // lblDataDa
            // 
            this.lblDataDa.AutoSize = true;
            this.lblDataDa.Location = new System.Drawing.Point(340, 7);
            this.lblDataDa.Name = "lblDataDa";
            this.lblDataDa.Size = new System.Drawing.Size(55, 16);
            this.lblDataDa.TabIndex = 3;
            this.lblDataDa.Text = "Nato da";
            // 
            // dtpNatoDaFilter
            // 
            this.dtpNatoDaFilter.Location = new System.Drawing.Point(339, 24);
            this.dtpNatoDaFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpNatoDaFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNatoDaFilter.Name = "dtpNatoDaFilter";
            this.dtpNatoDaFilter.ShowCheckBox = true;
            this.dtpNatoDaFilter.Size = new System.Drawing.Size(200, 22);
            this.dtpNatoDaFilter.TabIndex = 4;
            // 
            // dtpNatoAFilter
            // 
            this.dtpNatoAFilter.Location = new System.Drawing.Point(545, 24);
            this.dtpNatoAFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpNatoAFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNatoAFilter.Name = "dtpNatoAFilter";
            this.dtpNatoAFilter.ShowCheckBox = true;
            this.dtpNatoAFilter.Size = new System.Drawing.Size(200, 22);
            this.dtpNatoAFilter.TabIndex = 6;
            // 
            // lblNatoA
            // 
            this.lblNatoA.AutoSize = true;
            this.lblNatoA.Location = new System.Drawing.Point(546, 7);
            this.lblNatoA.Name = "lblNatoA";
            this.lblNatoA.Size = new System.Drawing.Size(47, 16);
            this.lblNatoA.TabIndex = 5;
            this.lblNatoA.Text = "Nato a";
            // 
            // FrmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.pnlRisultatiRicerca);
            this.Controls.Add(this.pnlCriteriRicerca);
            this.MinimumSize = new System.Drawing.Size(923, 497);
            this.Name = "FrmStudenti";
            this.Text = "Studenti";
            this.pnlCriteriRicerca.ResumeLayout(false);
            this.pnlCriteriRicerca.PerformLayout();
            this.pnlRisultatiRicerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCriteriRicerca;
        private System.Windows.Forms.Panel pnlRisultatiRicerca;
        private System.Windows.Forms.DataGridView dgvRisultati;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtNominativoFilter;
        private System.Windows.Forms.Label lblNominativo;
        private System.Windows.Forms.DateTimePicker dtpNatoAFilter;
        private System.Windows.Forms.Label lblNatoA;
        private System.Windows.Forms.DateTimePicker dtpNatoDaFilter;
        private System.Windows.Forms.Label lblDataDa;
    }
}