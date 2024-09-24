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
    public partial class FrmEntityFrameworkExample : Form
    {
        public FrmEntityFrameworkExample()
        {
            InitializeComponent();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection string vuota");
            btnCheckConnection.Enabled = false;

            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                {
                    if (ctx.Database.Exists())
                    {
                        MessageBox.Show("Connection OK");

                        int countStudenti = ctx.Studenti.Count();                                  //Seria o mesmo que escrever em SQL SELECT Count(*) FROM AnagraficheStudenti
                        lblCountStudenti.Text = countStudenti.ToString();

                        int countCorsi = ctx.Corsi.Count();                                        //Seria o mesmo que escrever em SQL SELECT Count(*) FROM AnagraficheCorsi
                        lblCountCorsi.Text = countCorsi.ToString();
                    }
                    else MessageBox.Show("This database does not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}");
                throw;
            }
            finally
            {
                btnCheckConnection.Enabled = true;
            }

        }

        private void btnCercaStudenti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection String is Empty!");
            btnCercaStudenti.Enabled = false;

            try
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                {

                    List<StudenteEntity> studentiList = ctx.Studenti.ToList();                     //Seria o mesmo que escrever em SQL SELECT * FROM AnagraficheStudenti

                    // uguale a fare studentiDto.Add(new StudenteDto()...
                    //List<StudenteDto> studentiDto = new List<StudenteDto>();
                    //foreach (var studenteEntity in studentiList)
                    //{
                    //    studentiDto.Add(new StudenteDto()
                    //    {
                    //        CodiceFiscale = studenteEntity.CodiceFiscale,
                    //        Cognome = studenteEntity.Cognome,
                    //        Nome = studenteEntity.Nome,
                    //        CorsoId = studenteEntity.CorsoId,
                    //        DataDiNascita = studenteEntity.DataDiNascita,
                    //        Id = studenteEntity.Id,
                    //     }
                    //     );
                    //     studentiDto.Add(StudenteMapper.Map(studenteEntity));                    //É o mesmo que ecrever studentiDto.Add(new StudenteDto()...
                    //}
                    //List<StudenteDto> studentiDto2 = studentiList.Select(e=> StudenteMapper.Map(e)).ToList();

                    dgvStudentiList.AutoGenerateColumns = true;
                    dgvStudentiList.DataSource = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }
        private void btnCercaCorsi_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection String is Empty!");
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
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");
            }
            finally
            {
                btnCercaStudenti.Enabled = true;
            }
        }

    }
}
