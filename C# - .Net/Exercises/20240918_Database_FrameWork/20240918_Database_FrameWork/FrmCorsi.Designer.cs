namespace _20240918_Database_FrameWork
{
    partial class FrmCorsi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFineCorsoFilter = new System.Windows.Forms.Label();
            this.txtNominativoCorsoFilter = new System.Windows.Forms.TextBox();
            this.lblInizioCorsoFilter = new System.Windows.Forms.Label();
            this.dtpInizioCorsoDaFilter = new System.Windows.Forms.DateTimePicker();
            this.lblNominativoCorso = new System.Windows.Forms.Label();
            this.dtpFineCorsoDaFilter = new System.Windows.Forms.DateTimePicker();
            this.btnCercaCorso = new System.Windows.Forms.Button();
            this.dgvRisultatiCorso = new System.Windows.Forms.DataGridView();
            this.dtpInizioCorsoAFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpFineCorsoAFilter = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultatiCorso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtpInizioCorsoAFilter);
            this.panel1.Controls.Add(this.dtpFineCorsoAFilter);
            this.panel1.Controls.Add(this.lblFineCorsoFilter);
            this.panel1.Controls.Add(this.txtNominativoCorsoFilter);
            this.panel1.Controls.Add(this.lblInizioCorsoFilter);
            this.panel1.Controls.Add(this.dtpInizioCorsoDaFilter);
            this.panel1.Controls.Add(this.lblNominativoCorso);
            this.panel1.Controls.Add(this.dtpFineCorsoDaFilter);
            this.panel1.Controls.Add(this.btnCercaCorso);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblFineCorsoFilter
            // 
            this.lblFineCorsoFilter.AutoSize = true;
            this.lblFineCorsoFilter.Location = new System.Drawing.Point(423, 3);
            this.lblFineCorsoFilter.Name = "lblFineCorsoFilter";
            this.lblFineCorsoFilter.Size = new System.Drawing.Size(27, 13);
            this.lblFineCorsoFilter.TabIndex = 13;
            this.lblFineCorsoFilter.Text = "Fine";
            // 
            // txtNominativoCorsoFilter
            // 
            this.txtNominativoCorsoFilter.Location = new System.Drawing.Point(8, 32);
            this.txtNominativoCorsoFilter.Name = "txtNominativoCorsoFilter";
            this.txtNominativoCorsoFilter.Size = new System.Drawing.Size(200, 20);
            this.txtNominativoCorsoFilter.TabIndex = 7;
            // 
            // lblInizioCorsoFilter
            // 
            this.lblInizioCorsoFilter.AutoSize = true;
            this.lblInizioCorsoFilter.Location = new System.Drawing.Point(217, 3);
            this.lblInizioCorsoFilter.Name = "lblInizioCorsoFilter";
            this.lblInizioCorsoFilter.Size = new System.Drawing.Size(31, 13);
            this.lblInizioCorsoFilter.TabIndex = 12;
            this.lblInizioCorsoFilter.Text = "Inizio";
            // 
            // dtpInizioCorsoDaFilter
            // 
            this.dtpInizioCorsoDaFilter.Location = new System.Drawing.Point(214, 18);
            this.dtpInizioCorsoDaFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpInizioCorsoDaFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpInizioCorsoDaFilter.Name = "dtpInizioCorsoDaFilter";
            this.dtpInizioCorsoDaFilter.ShowCheckBox = true;
            this.dtpInizioCorsoDaFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpInizioCorsoDaFilter.TabIndex = 8;
            this.dtpInizioCorsoDaFilter.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lblNominativoCorso
            // 
            this.lblNominativoCorso.AutoSize = true;
            this.lblNominativoCorso.Location = new System.Drawing.Point(5, 3);
            this.lblNominativoCorso.Name = "lblNominativoCorso";
            this.lblNominativoCorso.Size = new System.Drawing.Size(96, 13);
            this.lblNominativoCorso.TabIndex = 11;
            this.lblNominativoCorso.Text = "Nominativo (Corso)";
            // 
            // dtpFineCorsoDaFilter
            // 
            this.dtpFineCorsoDaFilter.Location = new System.Drawing.Point(420, 18);
            this.dtpFineCorsoDaFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFineCorsoDaFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFineCorsoDaFilter.Name = "dtpFineCorsoDaFilter";
            this.dtpFineCorsoDaFilter.ShowCheckBox = true;
            this.dtpFineCorsoDaFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpFineCorsoDaFilter.TabIndex = 9;
            this.dtpFineCorsoDaFilter.Value = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            // 
            // btnCercaCorso
            // 
            this.btnCercaCorso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCercaCorso.Location = new System.Drawing.Point(626, 29);
            this.btnCercaCorso.Name = "btnCercaCorso";
            this.btnCercaCorso.Size = new System.Drawing.Size(149, 23);
            this.btnCercaCorso.TabIndex = 10;
            this.btnCercaCorso.Text = "Search";
            this.btnCercaCorso.UseVisualStyleBackColor = true;
            this.btnCercaCorso.Click += new System.EventHandler(this.btnCercaCorso_Click);
            // 
            // dgvRisultatiCorso
            // 
            this.dgvRisultatiCorso.AllowUserToAddRows = false;
            this.dgvRisultatiCorso.AllowUserToDeleteRows = false;
            this.dgvRisultatiCorso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRisultatiCorso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisultatiCorso.Location = new System.Drawing.Point(14, 96);
            this.dgvRisultatiCorso.Name = "dgvRisultatiCorso";
            this.dgvRisultatiCorso.ReadOnly = true;
            this.dgvRisultatiCorso.Size = new System.Drawing.Size(784, 292);
            this.dgvRisultatiCorso.TabIndex = 1;
            // 
            // dtpInizioCorsoAFilter
            // 
            this.dtpInizioCorsoAFilter.Location = new System.Drawing.Point(214, 44);
            this.dtpInizioCorsoAFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpInizioCorsoAFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpInizioCorsoAFilter.Name = "dtpInizioCorsoAFilter";
            this.dtpInizioCorsoAFilter.ShowCheckBox = true;
            this.dtpInizioCorsoAFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpInizioCorsoAFilter.TabIndex = 14;
            this.dtpInizioCorsoAFilter.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFineCorsoAFilter
            // 
            this.dtpFineCorsoAFilter.Location = new System.Drawing.Point(420, 44);
            this.dtpFineCorsoAFilter.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFineCorsoAFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFineCorsoAFilter.Name = "dtpFineCorsoAFilter";
            this.dtpFineCorsoAFilter.ShowCheckBox = true;
            this.dtpFineCorsoAFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpFineCorsoAFilter.TabIndex = 15;
            this.dtpFineCorsoAFilter.Value = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            // 
            // FrmCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 400);
            this.Controls.Add(this.dgvRisultatiCorso);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(827, 439);
            this.Name = "FrmCorsi";
            this.Text = "FrmCorsi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultatiCorso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFineCorsoFilter;
        private System.Windows.Forms.TextBox txtNominativoCorsoFilter;
        private System.Windows.Forms.Label lblInizioCorsoFilter;
        private System.Windows.Forms.DateTimePicker dtpInizioCorsoDaFilter;
        private System.Windows.Forms.Label lblNominativoCorso;
        private System.Windows.Forms.DateTimePicker dtpFineCorsoDaFilter;
        private System.Windows.Forms.Button btnCercaCorso;
        private System.Windows.Forms.DataGridView dgvRisultatiCorso;
        private System.Windows.Forms.DateTimePicker dtpInizioCorsoAFilter;
        private System.Windows.Forms.DateTimePicker dtpFineCorsoAFilter;
    }
}