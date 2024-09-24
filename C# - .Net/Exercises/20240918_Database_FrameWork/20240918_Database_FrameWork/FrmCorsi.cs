using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Mappers;
using _20240918_Database_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmCorsi : Form
    {
        public FrmCorsi()
        {
            InitializeComponent();
        }

        private void btnCercaCorso_Click(object sender, EventArgs e)
        {
            btnCercaCorso.Enabled = false;


            try 
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
                {
                    IQueryable<CorsoEntity> query = ctx.Corsi;

                    if (!string.IsNullOrEmpty(txtNominativoCorsoFilter.Text))
                        query = query.Where(r => r.Nome.Contains(txtNominativoCorsoFilter.Text));

                    if (dtpInizioCorsoFilter.Checked)
                        query = query.Where(r => r.DataValiditaInizio >= dtpInizioCorsoFilter.Value);

                    if (dtpFineCorsoFilter.Checked)
                        query = query.Where(r => r.DataValiditaFine <= dtpFineCorsoFilter.Value);

                    List<CorsoEntity> corsoList = query.ToList();

                    List<CorsoDto> corsiDto = corsoList.Select(c => CorsoMapper.Map(c)).ToList();
                    dgvRisultatiCorso.AutoGenerateColumns = true;
                    dgvRisultatiCorso.DataSource = corsiDto;

                }
                    

            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");
            }
            
            finally 
            {
                btnCercaCorso.Enabled = true;
            }
        }
    }
}
