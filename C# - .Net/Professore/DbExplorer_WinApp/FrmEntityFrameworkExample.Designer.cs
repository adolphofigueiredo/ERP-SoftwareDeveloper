namespace DbExplorer_WinApp
{
    partial class FrmEntityFrameworkExample
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountStudenti = new System.Windows.Forms.Label();
            this.lblCountCorsi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStudentiList = new System.Windows.Forms.DataGridView();
            this.btnCercaStudenti = new System.Windows.Forms.Button();
            this.dgvCorsiList = new System.Windows.Forms.DataGridView();
            this.btnCercaCorsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorsiList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(12, 17);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(714, 22);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(732, 11);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(118, 35);
            this.btnCheckConnection.TabIndex = 1;
            this.btnCheckConnection.Text = "Check";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Studenti censiti:";
            // 
            // lblCountStudenti
            // 
            this.lblCountStudenti.AutoSize = true;
            this.lblCountStudenti.Location = new System.Drawing.Point(118, 42);
            this.lblCountStudenti.Name = "lblCountStudenti";
            this.lblCountStudenti.Size = new System.Drawing.Size(14, 16);
            this.lblCountStudenti.TabIndex = 3;
            this.lblCountStudenti.Text = "0";
            // 
            // lblCountCorsi
            // 
            this.lblCountCorsi.AutoSize = true;
            this.lblCountCorsi.Location = new System.Drawing.Point(226, 42);
            this.lblCountCorsi.Name = "lblCountCorsi";
            this.lblCountCorsi.Size = new System.Drawing.Size(14, 16);
            this.lblCountCorsi.TabIndex = 5;
            this.lblCountCorsi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Corsi censiti:";
            // 
            // dgvStudentiList
            // 
            this.dgvStudentiList.AllowUserToAddRows = false;
            this.dgvStudentiList.AllowUserToDeleteRows = false;
            this.dgvStudentiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiList.Location = new System.Drawing.Point(6, 76);
            this.dgvStudentiList.Name = "dgvStudentiList";
            this.dgvStudentiList.ReadOnly = true;
            this.dgvStudentiList.RowHeadersWidth = 51;
            this.dgvStudentiList.RowTemplate.Height = 24;
            this.dgvStudentiList.Size = new System.Drawing.Size(844, 226);
            this.dgvStudentiList.TabIndex = 6;
            // 
            // btnCercaStudenti
            // 
            this.btnCercaStudenti.Location = new System.Drawing.Point(648, 308);
            this.btnCercaStudenti.Name = "btnCercaStudenti";
            this.btnCercaStudenti.Size = new System.Drawing.Size(202, 35);
            this.btnCercaStudenti.TabIndex = 7;
            this.btnCercaStudenti.Text = "Cerca studenti";
            this.btnCercaStudenti.UseVisualStyleBackColor = true;
            this.btnCercaStudenti.Click += new System.EventHandler(this.btnCercaStudenti_Click);
            // 
            // dgvCorsiList
            // 
            this.dgvCorsiList.AllowUserToAddRows = false;
            this.dgvCorsiList.AllowUserToDeleteRows = false;
            this.dgvCorsiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorsiList.Location = new System.Drawing.Point(6, 349);
            this.dgvCorsiList.Name = "dgvCorsiList";
            this.dgvCorsiList.ReadOnly = true;
            this.dgvCorsiList.RowHeadersWidth = 51;
            this.dgvCorsiList.RowTemplate.Height = 24;
            this.dgvCorsiList.Size = new System.Drawing.Size(844, 226);
            this.dgvCorsiList.TabIndex = 8;
            // 
            // btnCercaCorsi
            // 
            this.btnCercaCorsi.Location = new System.Drawing.Point(648, 581);
            this.btnCercaCorsi.Name = "btnCercaCorsi";
            this.btnCercaCorsi.Size = new System.Drawing.Size(202, 35);
            this.btnCercaCorsi.TabIndex = 9;
            this.btnCercaCorsi.Text = "Cerca corsi";
            this.btnCercaCorsi.UseVisualStyleBackColor = true;
            this.btnCercaCorsi.Click += new System.EventHandler(this.btnCercaCorsi_Click);
            // 
            // FrmEntityFrameworkExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 651);
            this.Controls.Add(this.btnCercaCorsi);
            this.Controls.Add(this.dgvCorsiList);
            this.Controls.Add(this.btnCercaStudenti);
            this.Controls.Add(this.dgvStudentiList);
            this.Controls.Add(this.lblCountCorsi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCountStudenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "FrmEntityFrameworkExample";
            this.Text = "FrmEntityFrameworkExample";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorsiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountStudenti;
        private System.Windows.Forms.Label lblCountCorsi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStudentiList;
        private System.Windows.Forms.Button btnCercaStudenti;
        private System.Windows.Forms.DataGridView dgvCorsiList;
        private System.Windows.Forms.Button btnCercaCorsi;
    }
}