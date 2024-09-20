using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 1: verificare connessione al db passando la connection string attraverso una textbox
// 2; mostrare un messaggio a video (Messagebox) con il risultato scalare della query inputata dall'utente.
// 3: visualizzare in forma tabellare i dati estratti da una query inputata dall'utente.


namespace DbExplorer_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");

            btnCheckConnection.Enabled = false;
            using (SqlConnection sqlConnection = new SqlConnection(txtConnectionString.Text))
            {
                try
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    MessageBox.Show("Connessione OK");
                }
                catch (Exception)
                {
                    MessageBox.Show("Connessione KO");
                }
            }
            btnCheckConnection.Enabled = true;

        }

        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuery.Text)) throw new Exception("query vuota!");

            tabQueryResult.TabPages.Clear();

            btnExecuteQuery.Enabled = false;
            using (SqlConnection sqlConnection = new SqlConnection(txtConnectionString.Text))
            {
                try
                {
                    sqlConnection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(txtQuery.Text, sqlConnection);
                    DataSet setDiDati = new DataSet();
                    adapter.Fill(setDiDati);

                    sqlConnection.Close();

                    DataTableCollection tables = setDiDati.Tables;

                    foreach (DataTable table in tables)
                    {
                        var tab= new TabPage()
                        {
                            Text=table.TableName,
                        };
                        //tab.Text=table.TableName;

                        var dgvData = new DataGridView()
                        {
                            AutoGenerateColumns = true,
                            DataSource = setDiDati,
                            DataMember = table.TableName,
                            Dock = DockStyle.Fill
                        };
                        tab.Controls.Add(dgvData);
                        tabQueryResult.TabPages.Add(tab);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eccezione:", ex.Message);
                }
            }
            btnExecuteQuery.Enabled = true;
        }

        private void btnCountQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuery.Text)) throw new Exception("query vuota!");

            btnCountQuery.Enabled = false;
            using (SqlConnection sqlConnection = new SqlConnection(txtConnectionString.Text))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = txtQuery.Text;

                    var num = cmd.ExecuteScalar();
                    sqlConnection.Close();

                    MessageBox.Show(num.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eccezione:", ex.Message);
                }
            }
            btnCountQuery.Enabled = true;
        }
    }
}
