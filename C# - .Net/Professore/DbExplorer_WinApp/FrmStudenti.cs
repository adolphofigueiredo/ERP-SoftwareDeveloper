using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Mappers;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Models.Dtos;
using DbExplorer_WinApp.Repositories;
using DbExplorer_WinApp.Models.Filters;

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
                StudentiRepository repository = new StudentiRepository();
                var filtro = new StudenteFilter
                {
                    Nominativo = txtNominativoFilter.Text,
                    Da = null,
                    A = null
                };

                if (dtpNatoDaFilter.Checked) filtro.Da = dtpNatoDaFilter.Value;
                if (dtpNatoAFilter.Checked) filtro.A = dtpNatoAFilter.Value;

                ICollection<StudenteEntity> studentiList = repository.Find(filtro);
                List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                dgvRisultati.AutoGenerateColumns = true;
                dgvRisultati.DataSource = studentiDto;
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
