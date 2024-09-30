using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models;
using _20240918_Database_FrameWork.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
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
            btnSave.Enabled = false;


            try
            {
                StudenteRepository repository = new StudenteRepository();
                repository.Post(new StudenteEntity
                {
                    Nome = txtNome.Text,
                    Cognome = txtCognome.Text,
                    CodiceFiscale = txtCodiceFiscale.Text,
                    DataDiNascita = dtpDataDiNascita.Value,
                    CorsoId = (int)cboCorso.SelectedValue
                });
            }
            catch (Exception ex)                                                                   //O catch (Exception) é o bloco que captura exceções geradas dentro do try e se ocorrer
                                                                                                   //um erro durante a tentativa de abrir a conexão ele será capturado aqui. Este Exception
                                                                                                   //é o tipo mais genérico de exceção em C#. Isso captura qualquer tipo de erro que ocorra
                                                                                                   //no bloco try. O ex é o nome da variável que vai armazenar a exceção capturada. Através
                                                                                                   //dela, é possível acessar informações sobre o erro, como a mensagem de erro e o tipo de
                                                                                                   //exceção.
            {
                MessageBox.Show($"Ooops, That is an error: {ex.Message}");                         //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                   //Existe um Texto fixo que informa que ocorreu uma exceção. O código ex.Message é a
                                                                                                   //mensagem da exceção ex que contém uma descrição do erro que ocorreu. Cada tipo de
                                                                                                   //exceção pode teruma mensagem diferente, explicando o que deu errado.
            }
            finally                                                                                //Este bloco será executado independentemente de uma exceção ter ocorrido ou não.
            {
                btnSave.Enabled = true;                                                            //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como true, o botão fica habilitado e clicável. Reativa o botão,
                                                                                                   //permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                   //falha na tentativa de execução do que foi pedido.
            }
        }
    }
}