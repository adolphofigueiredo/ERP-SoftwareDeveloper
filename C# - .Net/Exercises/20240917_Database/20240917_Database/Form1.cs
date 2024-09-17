// 1: verificare connessione al db passando la connection string attraverso una textbox
// 2; mostrare un messaggio a video (Messagebox) con il risultato scalare della query inputata dall'utente.
// 3: visualizzare in forma tabellare i dati estratti da una query inputata dall'utente.

using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _20240917_Database
{
    public partial class DataBase_Connection : Form
    {
        public DataBase_Connection()
        {
            InitializeComponent();
        }

        private void btn_CheckConnection_Click(object sender, EventArgs e)                                          //Estou criando um metodo para quando se clica no
                                                                                                                    //botao que deve verificar a conexao.
        {
            if (string.IsNullOrEmpty(txt_ConnectionString.Text)) throw new Exception("Connection string vuota!");   //Aqui estou dizendo que ao ser clicado a condicao
                                                                                                                    //deve verificar no campo de texto onde deve ser
            btn_CheckConnection.Enabled = false;                                                                    //Faz o botao check connection ficar meio
                                                                                                                    //apagado enquanto pensa                                                                                                   //colocada a string de conexao esta preenchida
            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))
            {
                try
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    MessageBox.Show("Connessione OK");
                }
                catch(Exception)
                {
                    MessageBox.Show("Conessione Fallita!");
                }
            }
            btn_CheckConnection.Enabled = true;                                                                     //Faz o botao check connection voltar a
                                                                                                                    //aparecer depois que executa a acao
        }

        private void btn_CountQuery_Click(object sender, EventArgs e)                                               //Estou criando um metodo para quando se clica no
                                                                                                                    //botao que deve verificar a conexao.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");                    //Aqui estou dizendo que ao ser clicado a condicao
                                                                                                                    //deve verificar no campo de texto onde deve ser
            btn_ExecuteQuery.Enabled = false;                                                                       //Faz o botao check connection ficar meio
                                                                                                                    //apagado enquanto pensa                                                                                                   //colocada a string de conexao esta preenchida
            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = txt_QueryString.Text;
                    
                    var num = cmd.ExecuteScalar();
                    sqlConnection.Close();

                    MessageBox.Show(num.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eccezione:" , ex.Message);
                }
            }
            btn_ExecuteQuery.Enabled = true;                                                                        //Faz o botao check connection voltar a
                                                                                                                    //aparecer depois que executa a acao
        }
    }
}
