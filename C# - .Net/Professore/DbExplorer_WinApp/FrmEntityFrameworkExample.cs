using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DbExplorer_WinApp.Models;
using DbExplorer_WinApp.Models.Entities;
using DbExplorer_WinApp.Models.Mappers;

namespace DbExplorer_WinApp
{
    public partial class FrmEntityFrameworkExample : Form
    {
        public FrmEntityFrameworkExample()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");
            btnCheckConnection.Enabled = false;
            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                {
                    if (ctx.Database.Exists())
                    {
                        MessageBox.Show("Connessione OK");

                        int countStudenti = ctx.Studenti.Count();// SELECT count(*) FROM AnagreaficheStudenti
                        lblCountStudenti.Text = countStudenti.ToString();

                        int countCorsi = ctx.Corsi.Count();// SELECT count(*) FROM AnagreaficheCorsi
                        lblCountCorsi.Text = countCorsi.ToString();
                    }
                    else MessageBox.Show("DB non esiste!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore di connessione: {ex.Message}");
                throw;
            }
            finally
            {
                btnCheckConnection.Enabled = true;
            }
        }

        private void btnCercaStudenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");
            btnCercaStudenti.Enabled = false;
            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                {
                    List<StudenteEntity> studentiList = ctx.Studenti.ToList(); // SELECT * FROM AnagreaficheStudenti

                    /*List<StudenteDto> studentiDto = new List<StudenteDto>();
                    foreach (var studenteEntity in studentiList)
                    {
                        studentiDto.Add(new StudenteDto()
                        {
                            CodiceFiscale = studenteEntity.CodiceFiscale,
                            Cognome = studenteEntity.Cognome,
                            Nome = studenteEntity.Nome,
                            CorsoId = studenteEntity.CorsoId,
                            DataDiNascita = studenteEntity.DataDiNascita,
                            Id = studenteEntity.Id,
                        }
                        );

                        studentiDto.Add(StudenteMapper.Map(studenteEntity)); // uguale a fare studentiDto.Add(new StudenteDto() ...
                    }

                    List<StudenteDto> studentiDto2 = studentiList.Select(e=> StudenteMapper.Map(e)).ToList();
                    */





                    dgvStudentiList.AutoGenerateColumns = true;
                    dgvStudentiList.DataSource = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }

        private void btnCercaCorsi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connectionstring vuota!");
            btnCercaStudenti.Enabled = false;
            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                {
                    dgvCorsiList.AutoGenerateColumns = true;
                    dgvCorsiList.DataSource = ctx.Corsi.ToList().Select(r => CorsoMapper.Map(r)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"OPS, si è verificato un errore: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }
    }
}
