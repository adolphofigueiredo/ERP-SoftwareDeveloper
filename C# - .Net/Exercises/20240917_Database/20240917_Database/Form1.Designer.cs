namespace _20240917_Database
{
    partial class DataBase_Connection
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
            btn_CheckConnection = new Button();
            txt_ConnectionString = new TextBox();
            txt_QueryString = new TextBox();
            btn_ExecuteQuery = new Button();
            dataGridView1 = new DataGridView();
            btn_ShowQuery = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_CheckConnection
            // 
            btn_CheckConnection.Location = new Point(572, 12);
            btn_CheckConnection.Name = "btn_CheckConnection";
            btn_CheckConnection.Size = new Size(125, 23);
            btn_CheckConnection.TabIndex = 0;
            btn_CheckConnection.Text = "Check Connection";
            btn_CheckConnection.UseVisualStyleBackColor = true;
            // 
            // txt_ConnectionString
            // 
            txt_ConnectionString.Location = new Point(12, 12);
            txt_ConnectionString.Name = "txt_ConnectionString";
            txt_ConnectionString.Size = new Size(554, 23);
            txt_ConnectionString.TabIndex = 1;
            // 
            // txt_QueryString
            // 
            txt_QueryString.Location = new Point(12, 41);
            txt_QueryString.Multiline = true;
            txt_QueryString.Name = "txt_QueryString";
            txt_QueryString.Size = new Size(685, 205);
            txt_QueryString.TabIndex = 2;
            // 
            // btn_ExecuteQuery
            // 
            btn_ExecuteQuery.Location = new Point(12, 251);
            btn_ExecuteQuery.Name = "btn_ExecuteQuery";
            btn_ExecuteQuery.Size = new Size(340, 43);
            btn_ExecuteQuery.TabIndex = 3;
            btn_ExecuteQuery.Text = "Execute";
            btn_ExecuteQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(685, 302);
            dataGridView1.TabIndex = 4;
            // 
            // btn_ShowQuery
            // 
            btn_ShowQuery.Location = new Point(358, 252);
            btn_ShowQuery.Name = "btn_ShowQuery";
            btn_ShowQuery.Size = new Size(340, 42);
            btn_ShowQuery.TabIndex = 5;
            btn_ShowQuery.Text = "Show";
            btn_ShowQuery.UseVisualStyleBackColor = true;
            // 
            // DataBase_Connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 614);
            Controls.Add(btn_ShowQuery);
            Controls.Add(dataGridView1);
            Controls.Add(btn_ExecuteQuery);
            Controls.Add(txt_QueryString);
            Controls.Add(txt_ConnectionString);
            Controls.Add(btn_CheckConnection);
            Name = "DataBase_Connection";
            Text = "DataBase Connection";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CheckConnection;
        private TextBox txt_ConnectionString;
        private TextBox txt_QueryString;
        private Button btn_ExecuteQuery;
        private DataGridView dataGridView1;
        private Button btn_ShowQuery;
    }
}
