using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbExplorer_WinApp.Models.Dtos;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Mappers;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Repositories;

namespace DbExplorer_WinApp
{
    public partial class FrmEditStudente : Form
    {
        public FrmEditStudente()
        {
            InitializeComponent();
            using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
            {
                cboCorso.DataSource = ctx.Corsi.Where(c =>
                    c.DataValiditaInizio <= DateTime.Now &&
                    c.DataValiditaFine == null || c.DataValiditaFine > DateTime.Now).ToList();

                cboCorso.DisplayMember = nameof(CorsoEntity.Nome);
                cboCorso.ValueMember = nameof(CorsoEntity.Id);
            }
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
