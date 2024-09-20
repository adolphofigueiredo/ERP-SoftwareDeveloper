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
            btn_CountRecords = new Button();
            dgv_Data = new DataGridView();
            btn_ExecuteQuery = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgv_Data).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CheckConnection
            // 
            btn_CheckConnection.Location = new Point(572, 12);
            btn_CheckConnection.Name = "btn_CheckConnection";
            btn_CheckConnection.Size = new Size(125, 23);
            btn_CheckConnection.TabIndex = 1;
            btn_CheckConnection.Text = "Check Connection";
            btn_CheckConnection.UseVisualStyleBackColor = true;
            btn_CheckConnection.Click += btn_CheckConnection_Click;
            // 
            // txt_ConnectionString
            // 
            txt_ConnectionString.Location = new Point(12, 12);
            txt_ConnectionString.Name = "txt_ConnectionString";
            txt_ConnectionString.Size = new Size(554, 23);
            txt_ConnectionString.TabIndex = 0;
            txt_ConnectionString.Text = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
            // 
            // txt_QueryString
            // 
            txt_QueryString.Location = new Point(12, 41);
            txt_QueryString.Multiline = true;
            txt_QueryString.Name = "txt_QueryString";
            txt_QueryString.Size = new Size(685, 205);
            txt_QueryString.TabIndex = 2;
            // 
            // btn_CountRecords
            // 
            btn_CountRecords.Location = new Point(357, 252);
            btn_CountRecords.Name = "btn_CountRecords";
            btn_CountRecords.Size = new Size(340, 43);
            btn_CountRecords.TabIndex = 4;
            btn_CountRecords.Text = "Count Records";
            btn_CountRecords.UseVisualStyleBackColor = true;
            btn_CountRecords.Click += btn_CountQuery_Click;
            // 
            // dgv_Data
            // 
            dgv_Data.AllowUserToAddRows = false;
            dgv_Data.AllowUserToDeleteRows = false;
            dgv_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Data.Location = new Point(6, 6);
            dgv_Data.Name = "dgv_Data";
            dgv_Data.ReadOnly = true;
            dgv_Data.Size = new Size(665, 262);
            dgv_Data.TabIndex = 5;
            // 
            // btn_ExecuteQuery
            // 
            btn_ExecuteQuery.Location = new Point(12, 252);
            btn_ExecuteQuery.Name = "btn_ExecuteQuery";
            btn_ExecuteQuery.Size = new Size(340, 42);
            btn_ExecuteQuery.TabIndex = 3;
            btn_ExecuteQuery.Text = "Execute";
            btn_ExecuteQuery.UseVisualStyleBackColor = true;
            btn_ExecuteQuery.Click += btn_ExecuteQuery_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 300);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(685, 302);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_Data);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 274);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataBase_Connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 614);
            Controls.Add(tabControl1);
            Controls.Add(btn_ExecuteQuery);
            Controls.Add(btn_CountRecords);
            Controls.Add(txt_QueryString);
            Controls.Add(txt_ConnectionString);
            Controls.Add(btn_CheckConnection);
            Name = "DataBase_Connection";
            Text = "DataBase Connection";
            ((System.ComponentModel.ISupportInitialize)dgv_Data).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CheckConnection;
        private TextBox txt_ConnectionString;
        private TextBox txt_QueryString;
        private Button btn_CountRecords;
        private DataGridView dgv_Data;
        private Button btn_ExecuteQuery;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}
