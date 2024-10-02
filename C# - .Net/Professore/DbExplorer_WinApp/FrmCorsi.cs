using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Models.Entities;
using BusinessLayer.Models.Dtos;
using BusinessLayer.Models;
using BusinessLayer.Models.Mappers;
using BusinessLayer.Models.Filters;
using BusinessLayer.Repositories;

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
                CorsiRepository repository = new CorsiRepository();
                var filtro = new CorsoFilter
                {
                    Nome = txtNomeCorsoFilter.Text,
                    Da = null,
                    A = null
                };

                if (dtpValiditaDaFilter.Checked) filtro.Da = dtpValiditaDaFilter.Value;
                if (dtpValiditaAFilter.Checked) filtro.A = dtpValiditaAFilter.Value;

                ICollection<CorsoEntity> studentiList = repository.Find(filtro);
                List<CorsoDto> studentiDto = studentiList.Select(r => CorsoMapper.Map(r)).ToList();
                dgvRisultatiRicerca.AutoGenerateColumns = true;
                dgvRisultatiRicerca.DataSource = studentiDto;
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
