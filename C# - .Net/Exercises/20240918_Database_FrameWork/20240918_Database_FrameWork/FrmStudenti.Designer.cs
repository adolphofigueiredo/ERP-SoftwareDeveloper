namespace _20240918_Database_FrameWork
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
            this.pnlCriterieRicerca = new System.Windows.Forms.Panel();
            this.lbNatoA = new System.Windows.Forms.Label();
            this.lblDataDa = new System.Windows.Forms.Label();
            this.lblNominativo = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.dtpNatoAFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpNatoDaFilter = new System.Windows.Forms.DateTimePicker();
            this.txtNominativoFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRisultati = new System.Windows.Forms.DataGridView();
            this.pnlCriterieRicerca.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCriterieRicerca
            // 
            this.pnlCriterieRicerca.Controls.Add(this.lbNatoA);
            this.pnlCriterieRicerca.Controls.Add(this.lblDataDa);
            this.pnlCriterieRicerca.Controls.Add(this.lblNominativo);
            this.pnlCriterieRicerca.Controls.Add(this.btnCerca);
            this.pnlCriterieRicerca.Controls.Add(this.dtpNatoAFilter);
            this.pnlCriterieRicerca.Controls.Add(this.dtpNatoDaFilter);
            this.pnlCriterieRicerca.Controls.Add(this.txtNominativoFilter);
            this.pnlCriterieRicerca.Location = new System.Drawing.Point(13, 12);
            this.pnlCriterieRicerca.Name = "pnlCriterieRicerca";
            this.pnlCriterieRicerca.Size = new System.Drawing.Size(785, 52);
            this.pnlCriterieRicerca.TabIndex = 0;
            // 
            // lbNatoA
            // 
            this.lbNatoA.AutoSize = true;
            this.lbNatoA.Location = new System.Drawing.Point(423, 3);
            this.lbNatoA.Name = "lbNatoA";
            this.lbNatoA.Size = new System.Drawing.Size(39, 13);
            this.lbNatoA.TabIndex = 6;
            this.lbNatoA.Text = "Nato a";
            // 
            // lblDataDa
            // 
            this.lblDataDa.AutoSize = true;
            this.lblDataDa.Location = new System.Drawing.Point(217, 3);
            this.lblDataDa.Name = "lblDataDa";
            this.lblDataDa.Size = new System.Drawing.Size(45, 13);
            this.lblDataDa.TabIndex = 5;
            this.lblDataDa.Text = "Nato da";
            // 
            // lblNominativo
            // 
            this.lblNominativo.AutoSize = true;
            this.lblNominativo.Location = new System.Drawing.Point(11, 3);
            this.lblNominativo.Name = "lblNominativo";
            this.lblNominativo.Size = new System.Drawing.Size(165, 13);
            this.lblNominativo.TabIndex = 4;
            this.lblNominativo.Text = "Nominativo (Nome e/o Cognome)";
            // 
            // btnCerca
            // 
            this.btnCerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerca.Location = new System.Drawing.Point(627, 17);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(149, 23);
            this.btnCerca.TabIndex = 3;
            this.btnCerca.Text = "Search";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // dtpNatoAFilter
            // 
            this.dtpNatoAFilter.Location = new System.Drawing.Point(420, 18);
            this.dtpNatoAFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpNatoAFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNatoAFilter.Name = "dtpNatoAFilter";
            this.dtpNatoAFilter.ShowCheckBox = true;
            this.dtpNatoAFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpNatoAFilter.TabIndex = 2;
            // 
            // dtpNatoDaFilter
            // 
            this.dtpNatoDaFilter.Location = new System.Drawing.Point(214, 18);
            this.dtpNatoDaFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpNatoDaFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNatoDaFilter.Name = "dtpNatoDaFilter";
            this.dtpNatoDaFilter.ShowCheckBox = true;
            this.dtpNatoDaFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpNatoDaFilter.TabIndex = 1;
            // 
            // txtNominativoFilter
            // 
            this.txtNominativoFilter.Location = new System.Drawing.Point(8, 18);
            this.txtNominativoFilter.Name = "txtNominativoFilter";
            this.txtNominativoFilter.Size = new System.Drawing.Size(200, 20);
            this.txtNominativoFilter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRisultati);
            this.panel1.Location = new System.Drawing.Point(14, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 318);
            this.panel1.TabIndex = 1;
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
            this.dgvRisultati.Size = new System.Drawing.Size(784, 318);
            this.dgvRisultati.TabIndex = 0;
            // 
            // FrmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCriterieRicerca);
            this.MinimumSize = new System.Drawing.Size(827, 439);
            this.Name = "FrmStudenti";
            this.Text = "FrmStudenti";
            this.pnlCriterieRicerca.ResumeLayout(false);
            this.pnlCriterieRicerca.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCriterieRicerca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNominativoFilter;
        private System.Windows.Forms.Label lbNatoA;
        private System.Windows.Forms.Label lblDataDa;
        private System.Windows.Forms.Label lblNominativo;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.DateTimePicker dtpNatoAFilter;
        private System.Windows.Forms.DateTimePicker dtpNatoDaFilter;
        private System.Windows.Forms.DataGridView dgvRisultati;
    }
}