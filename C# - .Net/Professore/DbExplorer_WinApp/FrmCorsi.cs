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

namespace DbExplorer_WinApp
{
    public partial class FrmCorsi : Form
    {
        public FrmCorsi()
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
                    IQueryable<CorsoEntity> query = ctx.Corsi;

                    if (!string.IsNullOrEmpty(txtNomeCorsoFilter.Text))
                        query = query.Where(r => r.Nome.Contains(txtNomeCorsoFilter.Text));

                    if (dtpValiditaDaFilter.Checked && dtpValiditaAFilter.Checked)
                    {
                        query = query.Where(db => dtpValiditaAFilter.Value >= db.DataValiditaInizio &&
                            dtpValiditaDaFilter.Value <= db.DataValiditaFine);
                    }
                    else if (dtpValiditaDaFilter.Checked)
                        query = query.Where(db => db.DataValiditaInizio <= dtpValiditaDaFilter.Value);
                    else if (dtpValiditaAFilter.Checked)
                        query = query.Where(db => db.DataValiditaFine >= dtpValiditaAFilter.Value);

                    List<CorsoEntity> corsiList = query.ToList(); // SELECT * FROM AnagreaficheStudenti WHERE  nome or cognome contains filter ....

                    List<CorsoDto> corsiDto = corsiList.Select(r => CorsoMapper.Map(r)).ToList();
                    dgvRisultatiRicerca.AutoGenerateColumns = true;
                    dgvRisultatiRicerca.DataSource = corsiDto;
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
