namespace DbExplorer_WinApp
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
            this.pnlCriteriRicerca = new System.Windows.Forms.Panel();
            this.txtNomeCorsoFilter = new System.Windows.Forms.TextBox();
            this.pnlRisultatiRicerca = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpValiditaDaFilter = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpValiditaAFilter = new System.Windows.Forms.DateTimePicker();
            this.btnCerca = new System.Windows.Forms.Button();
            this.dgvRisultatiRicerca = new System.Windows.Forms.DataGridView();
            this.pnlCriteriRicerca.SuspendLayout();
            this.pnlRisultatiRicerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultatiRicerca)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCriteriRicerca
            // 
            this.pnlCriteriRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCriteriRicerca.Controls.Add(this.btnCerca);
            this.pnlCriteriRicerca.Controls.Add(this.label3);
            this.pnlCriteriRicerca.Controls.Add(this.dtpValiditaAFilter);
            this.pnlCriteriRicerca.Controls.Add(this.label2);
            this.pnlCriteriRicerca.Controls.Add(this.dtpValiditaDaFilter);
            this.pnlCriteriRicerca.Controls.Add(this.label1);
            this.pnlCriteriRicerca.Controls.Add(this.txtNomeCorsoFilter);
            this.pnlCriteriRicerca.Location = new System.Drawing.Point(12, 12);
            this.pnlCriteriRicerca.Name = "pnlCriteriRicerca";
            this.pnlCriteriRicerca.Size = new System.Drawing.Size(780, 62);
            this.pnlCriteriRicerca.TabIndex = 0;
            // 
            // txtNomeCorsoFilter
            // 
            this.txtNomeCorsoFilter.Location = new System.Drawing.Point(3, 22);
            this.txtNomeCorsoFilter.Name = "txtNomeCorsoFilter";
            this.txtNomeCorsoFilter.Size = new System.Drawing.Size(333, 22);
            this.txtNomeCorsoFilter.TabIndex = 0;
            // 
            // pnlRisultatiRicerca
            // 
            this.pnlRisultatiRicerca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRisultatiRicerca.Controls.Add(this.dgvRisultatiRicerca);
            this.pnlRisultatiRicerca.Location = new System.Drawing.Point(12, 80);
            this.pnlRisultatiRicerca.Name = "pnlRisultatiRicerca";
            this.pnlRisultatiRicerca.Size = new System.Drawing.Size(780, 358);
            this.pnlRisultatiRicerca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome corso";
            // 
            // dtpValiditaDaFilter
            // 
            this.dtpValiditaDaFilter.Location = new System.Drawing.Point(342, 22);
            this.dtpValiditaDaFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpValiditaDaFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpValiditaDaFilter.Name = "dtpValiditaDaFilter";
            this.dtpValiditaDaFilter.ShowCheckBox = true;
            this.dtpValiditaDaFilter.Size = new System.Drawing.Size(164, 22);
            this.dtpValiditaDaFilter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valido da";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valido a";
            // 
            // dtpValiditaAFilter
            // 
            this.dtpValiditaAFilter.Location = new System.Drawing.Point(512, 22);
            this.dtpValiditaAFilter.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpValiditaAFilter.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpValiditaAFilter.Name = "dtpValiditaAFilter";
            this.dtpValiditaAFilter.ShowCheckBox = true;
            this.dtpValiditaAFilter.Size = new System.Drawing.Size(164, 22);
            this.dtpValiditaAFilter.TabIndex = 4;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(683, 20);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(93, 23);
            this.btnCerca.TabIndex = 6;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // dgvRisultatiRicerca
            // 
            this.dgvRisultatiRicerca.AllowUserToAddRows = false;
            this.dgvRisultatiRicerca.AllowUserToDeleteRows = false;
            this.dgvRisultatiRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRisultatiRicerca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRisultatiRicerca.Location = new System.Drawing.Point(0, 0);
            this.dgvRisultatiRicerca.Name = "dgvRisultatiRicerca";
            this.dgvRisultatiRicerca.ReadOnly = true;
            this.dgvRisultatiRicerca.RowHeadersWidth = 51;
            this.dgvRisultatiRicerca.RowTemplate.Height = 24;
            this.dgvRisultatiRicerca.Size = new System.Drawing.Size(780, 358);
            this.dgvRisultatiRicerca.TabIndex = 0;
            // 
            // FrmCorsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRisultatiRicerca);
            this.Controls.Add(this.pnlCriteriRicerca);
            this.Name = "FrmCorsi";
            this.Text = "Elenco Corsi";
            this.pnlCriteriRicerca.ResumeLayout(false);
            this.pnlCriteriRicerca.PerformLayout();
            this.pnlRisultatiRicerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRisultatiRicerca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCriteriRicerca;
        private System.Windows.Forms.TextBox txtNomeCorsoFilter;
        private System.Windows.Forms.Panel pnlRisultatiRicerca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpValiditaAFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpValiditaDaFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.DataGridView dgvRisultatiRicerca;
    }
}