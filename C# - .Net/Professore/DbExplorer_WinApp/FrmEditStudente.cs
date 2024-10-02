using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using BusinessLayer.Repositories;
using BusinessLayer.Models.Entities;
using BusinessLayer.Models;

namespace DbExplorer_WinApp
{
    public partial class FrmEditStudente : Form
    {
        public FrmEditStudente()
        {
            InitializeComponent();

            var corsiRepository = new CorsiRepository();
            
            cboCorso.DataSource = corsiRepository.GetCorsiValidi(DateTime.Now);

            cboCorso.DisplayMember = nameof(CorsoEntity.Nome);
            cboCorso.ValueMember = nameof(CorsoEntity.Id);
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            btnSalva.Enabled = false;

            try
            {
                StudentiRepository repository = new StudentiRepository();
                repository.Post(new StudenteEntity
                {
                    Nome = txtNome.Text,
                    Cognome = txtCognome.Text,
                    CodiceFiscale = txtCf.Text,
                    DataDiNascita = dtpDataNascita.Value,
                    CorsoId = (int)cboCorso.SelectedValue
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnSalva.Enabled = true;
            }
        }
    }
}
