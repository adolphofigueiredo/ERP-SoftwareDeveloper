namespace DbExplorer_WinApp
{
    partial class Form1
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecuteQuery = new System.Windows.Forms.Button();
            this.btnCountQuery = new System.Windows.Forms.Button();
            this.tabQueryResult = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(13, 13);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(652, 22);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(671, 8);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(122, 32);
            this.btnCheckConnection.TabIndex = 1;
            this.btnCheckConnection.Text = "Check connection";
            this.btnCheckConnection.UseVisualStyleBackColor = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(12, 41);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(781, 173);
            this.txtQuery.TabIndex = 2;
            // 
            // btnExecuteQuery
            // 
            this.btnExecuteQuery.Location = new System.Drawing.Point(12, 220);
            this.btnExecuteQuery.Name = "btnExecuteQuery";
            this.btnExecuteQuery.Size = new System.Drawing.Size(398, 32);
            this.btnExecuteQuery.TabIndex = 3;
            this.btnExecuteQuery.Text = "Esegui query";
            this.btnExecuteQuery.UseVisualStyleBackColor = true;
            this.btnExecuteQuery.Click += new System.EventHandler(this.btnExecuteQuery_Click);
            // 
            // btnCountQuery
            // 
            this.btnCountQuery.Location = new System.Drawing.Point(416, 220);
            this.btnCountQuery.Name = "btnCountQuery";
            this.btnCountQuery.Size = new System.Drawing.Size(377, 32);
            this.btnCountQuery.TabIndex = 5;
            this.btnCountQuery.Text = "Esegui count query";
            this.btnCountQuery.UseVisualStyleBackColor = true;
            this.btnCountQuery.Click += new System.EventHandler(this.btnCountQuery_Click);
            // 
            // tabQueryResult
            // 
            this.tabQueryResult.Location = new System.Drawing.Point(12, 259);
            this.tabQueryResult.Name = "tabQueryResult";
            this.tabQueryResult.SelectedIndex = 0;
            this.tabQueryResult.Size = new System.Drawing.Size(776, 325);
            this.tabQueryResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.tabQueryResult);
            this.Controls.Add(this.btnCountQuery);
            this.Controls.Add(this.btnExecuteQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecuteQuery;
        private System.Windows.Forms.Button btnCountQuery;
        private System.Windows.Forms.TabControl tabQueryResult;
    }
}

