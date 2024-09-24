using _20240918_Database_FrameWork.Models;
using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Mappers;
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

                    if(!string.IsNullOrEmpty(txtNominativoFilter.Text))
                        query = query.Where(r => r.Nome.Contains(txtNominativoFilter.Text)
                        || r.Cognome.Contains(txtNominativoFilter.Text));

                    if (dtpNatoDaFilter.Checked)
                        query = query.Where(r => r.DataDiNascita >= dtpNatoDaFilter.Value);

                    if (dtpNatoAFilter.Checked)
                        query = query.Where(r => r.DataDiNascita <= dtpNatoAFilter.Value);

                    List<StudenteEntity> studentList = query.ToList();

                    List<StudenteDto> studentiDto = studentList.Select(r => StudenteMapper.Map(r)).ToList();
                    dgvRisultati.AutoGenerateColumns = true;
                    dgvRisultati.DataSource = studentiDto;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");
            }
            finally
            { 
                btnCerca.Enabled = true;
            }
        
        }

    }
}
