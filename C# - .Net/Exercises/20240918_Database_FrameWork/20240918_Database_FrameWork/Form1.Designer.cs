namespace _20240918_Database_FrameWork
{
    partial class DataBase_Connection
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
            this.txt_ConnectionString = new System.Windows.Forms.TextBox();
            this.btn_CheckConnection = new System.Windows.Forms.Button();
            this.txt_QueryString = new System.Windows.Forms.TextBox();
            this.btn_ExecuteQuery = new System.Windows.Forms.Button();
            this.btn_CountRecords = new System.Windows.Forms.Button();
            this.tab_QueryResult = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // txt_ConnectionString
            // 
            this.txt_ConnectionString.Location = new System.Drawing.Point(12, 12);
            this.txt_ConnectionString.Multiline = true;
            this.txt_ConnectionString.Name = "txt_ConnectionString";
            this.txt_ConnectionString.Size = new System.Drawing.Size(619, 23);
            this.txt_ConnectionString.TabIndex = 0;
            this.txt_ConnectionString.Text = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
            // 
            // btn_CheckConnection
            // 
            this.btn_CheckConnection.Location = new System.Drawing.Point(637, 12);
            this.btn_CheckConnection.Name = "btn_CheckConnection";
            this.btn_CheckConnection.Size = new System.Drawing.Size(151, 23);
            this.btn_CheckConnection.TabIndex = 1;
            this.btn_CheckConnection.Text = "Check Connection";
            this.btn_CheckConnection.UseVisualStyleBackColor = true;
            this.btn_CheckConnection.Click += new System.EventHandler(this.btn_CheckConnection_Click);
            // 
            // txt_QueryString
            // 
            this.txt_QueryString.Location = new System.Drawing.Point(12, 41);
            this.txt_QueryString.Multiline = true;
            this.txt_QueryString.Name = "txt_QueryString";
            this.txt_QueryString.Size = new System.Drawing.Size(776, 236);
            this.txt_QueryString.TabIndex = 2;
            // 
            // btn_ExecuteQuery
            // 
            this.btn_ExecuteQuery.Location = new System.Drawing.Point(12, 283);
            this.btn_ExecuteQuery.Name = "btn_ExecuteQuery";
            this.btn_ExecuteQuery.Size = new System.Drawing.Size(383, 46);
            this.btn_ExecuteQuery.TabIndex = 3;
            this.btn_ExecuteQuery.Text = "Execute";
            this.btn_ExecuteQuery.UseVisualStyleBackColor = true;
            this.btn_ExecuteQuery.Click += new System.EventHandler(this.btn_ExecuteQuery_Click);
            // 
            // btn_CountRecords
            // 
            this.btn_CountRecords.Location = new System.Drawing.Point(402, 283);
            this.btn_CountRecords.Name = "btn_CountRecords";
            this.btn_CountRecords.Size = new System.Drawing.Size(386, 46);
            this.btn_CountRecords.TabIndex = 4;
            this.btn_CountRecords.Text = "Count Records";
            this.btn_CountRecords.UseVisualStyleBackColor = true;
            this.btn_CountRecords.Click += new System.EventHandler(this.btn_CountQuery_Click);
            // 
            // tab_QueryResult
            // 
            this.tab_QueryResult.Location = new System.Drawing.Point(12, 335);
            this.tab_QueryResult.Name = "tab_QueryResult";
            this.tab_QueryResult.SelectedIndex = 0;
            this.tab_QueryResult.Size = new System.Drawing.Size(776, 254);
            this.tab_QueryResult.TabIndex = 6;
            // 
            // DataBase_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 601);
            this.Controls.Add(this.tab_QueryResult);
            this.Controls.Add(this.btn_CountRecords);
            this.Controls.Add(this.btn_ExecuteQuery);
            this.Controls.Add(this.txt_QueryString);
            this.Controls.Add(this.btn_CheckConnection);
            this.Controls.Add(this.txt_ConnectionString);
            this.Name = "DataBase_Connection";
            this.Text = "DataBase Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConnectionString;
        private System.Windows.Forms.Button btn_CheckConnection;
        private System.Windows.Forms.TextBox txt_QueryString ;
        private System.Windows.Forms.Button btn_ExecuteQuery;
        private System.Windows.Forms.Button btn_CountRecords;
        private System.Windows.Forms.TabControl tab_QueryResult;
    }
}

