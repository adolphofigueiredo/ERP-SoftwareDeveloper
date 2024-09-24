using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Mappers;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Models.Dtos;

namespace DbExplorer_WinApp
{
    public partial class FrmStudenti : Form
    {
        public FrmStudenti()
        {
            InitializeComponent();
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            btnCerca.Enabled = false;
            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
                {
                    IQueryable<StudenteEntity> query = ctx.Studenti;

                    if (!string.IsNullOrEmpty(txtNominativoFilter.Text))
                        query = query.Where(r => r.Nome.Contains(txtNominativoFilter.Text)
                            || r.Cognome.Contains(txtNominativoFilter.Text));

                    if (dtpNatoDaFilter.Checked)
                        query = query.Where(r => r.DataDiNascita >= dtpNatoDaFilter.Value);
                    if (dtpNatoAFilter.Checked)
                        query = query.Where(r => r.DataDiNascita <= dtpNatoAFilter.Value);

                    List<StudenteEntity> studentiList = query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....

                    List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                    dgvRisultati.AutoGenerateColumns = true;
                    dgvRisultati.DataSource = studentiDto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnCerca.Enabled = true;
            }
        }
    }
}
