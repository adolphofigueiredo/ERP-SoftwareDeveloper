// 1: verificare connessione al db passando la connection string attraverso una textbox
// 2; mostrare un messaggio a video (Messagebox) con il risultato scalare della query inputata dall'utente.
// 3: visualizzare in forma tabellare i dati estratti da una query inputata dall'utente.

using System.ComponentModel.Design;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;

namespace _20240917_Database                                                                                        //O namespace e uma maneira de organizar o código em diferentes áreas ou seções lógicas. O namespace pode
                                                                                                                    //ser visto como um contêiner que agrupa classes relacionadas, permitindo que você evite conflitos de
                                                                                                                    //nome quando diferentes partes do programa usam nomes semelhantes.
{
    public partial class DataBase_Connection : Form                                                                 //O public e um modificador de acesso que significa que a classe pode ser acessada de qualquer lugar no código.
                                                                                                                    //O partial permite que a definição da classe seja dividida em vários arquivos. Isso é comum em
                                                                                                                    //aplicações Windows Forms, onde o designer visual (arranjo de botões, campos de texto, etc.)
                                                                                                                    //fica em um arquivo separado.
                                                                                                                    //O class DataBase_Connection : Define uma classe chamada DataBase_Connection. É o nome da classe que será usada
                                                                                                                    //para gerenciar a conexão com o banco de dados, ou para lidar com a interface da aplicação relacionada a isso.
                                                                                                                    //O : Form diz que a classe DataBase_Connection herda da classe Form, que faz parte do Windows Forms (System.Windows.Forms).
                                                                                                                    //Isso significa que a classe DataBase_Connection é um formulário de janela gráfica que pode conter botões,
                                                                                                                    //campos de texto e outros controles visuais.
    {
        public DataBase_Connection()                                                                                //public DataBase_Connection(): Este é o construtor da classe DataBase_Connection. Ele é chamado automaticamente quando
                                                                                                                    //uma nova instância da classe é criada. O papel do construtor é inicializar o objeto, ou seja, configurar qualquer
                                                                                                                    //estado ou dados iniciais necessários.
        {
            InitializeComponent();                                                                                  //Esse método é responsável por inicializar todos os controles visuais (como botões, caixas de texto, labels) que
                                                                                                                    //estão no formulário. Ele é gerado automaticamente pelo Windows Forms Designer e fica em um arquivo separado
                                                                                                                    //(geralmente no arquivo .Designer.cs associado à classe).
                                                                                                                    //O método InitializeComponent() configura o layout da interface, posiciona os elementos no formulário e pode
                                                                                                                    //associar eventos(como cliques de botão) a seus respectivos métodos.
        }
        private void btn_CheckConnection_Click(object sender, EventArgs e)                                          //Estou criando um metodo para quando clicar no botao que deve verificar a conexao.
                                                                                                                    //O private define que o método só pode ser acessado de dentro da própria classe.
                                                                                                                    //O void diz que o método não retorna nenhum valor.
                                                                                                                    //O btn_CheckConnection_Click +e o nome do método, que será chamado quando o botão for clicado.
                                                                                                                    //O parâmetro object sender refere-se ao objeto que disparou o evento, neste caso, o botão. Ele permite
                                                                                                                    //acessar informações sobre o botão que foi clicado.
        {
            if (string.IsNullOrEmpty(txt_ConnectionString.Text)) throw new Exception("Connection string vuota!");   //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto se ele foi preenchido ou nao.
                                                                                                                    //O string.IsNullOrEmpty é um método estático da classe String, que retorna true se a string for nula ou vazia.
                                                                                                                    //O txt_ConnectionString.Text refere-se ao conteúdo digitado no componente de texto txt_ConnectionString, e o nome da caixa
                                                                                                                    //de texto (TextBox) que está no formulário. Esse controle permite que o usuário insira informações, como a string de conexão ao
                                                                                                                    //banco de dados. A propriedade .Text é usada para obter ou definir o conteúdo textual do controle txt_ConnectionString.
                                                                                                                    //Nesse caso, quando você lê txt_ConnectionString.Text, você está pegando o texto que o usuário digitou no campo de entrada.
                                                                                                                    //Quando você define txt_ConnectionString.Text, você altera o conteúdo desse campo. Resumindo, a propriedade .Text contém
                                                                                                                    //o texto exibido ou digitado dentro da caixa de texto.
                                                                                                                    //O throw new Exception("Connection string vuota!"), lança ma nova exceção do tipo Exception, interrompendo a execução
                                                                                                                    //do método. A mensagem "Connection string vuota!" será exibida como a descrição do erro.

            btn_CheckConnection.Enabled = false;                                                                    //O btn_CheckConnection.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando false, o botão fica
                                                                                                                    //desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos cliques durante o processamento da verificação
                                                                                                                    //de conexão.

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))                      //O using, declara um bloco de código onde o objeto sqlConnection será utilizado. Ao final do bloco, o objeto será automaticamente
                                                                                                                    //descartado (chama o método Dispose), liberando recursos de forma eficiente. O SqlConnection e uma Classe que representa uma
                                                                                                                    //conexão SQL com um banco de dados. Está localizada no namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text)
                                                                                                                    //cria uma nova instância de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o parâmetro de conexão.Isso estabelece
                                                                                                                    //os parâmetros para a conexão com o banco de dados especificado.
            {
                try                                                                                                 //O try e um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção, o controle será passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida. Se a conexão falhar, será
                                                                                                                    //gerada uma exceção, enviando o fluxo do programa para o bloco catch.
                    
                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão após o uso. Embora o using já
                                                                                                                    //garanta o fechamento, é uma boa prática fechar explicitamente.
                    
                    MessageBox.Show("Connessione OK");                                                              //Exibe uma caixa de diálogo ao usuário com uma mensagem "Connessione OK", indicanso que a conexão foi estabelecida com sucesso.
                }
                catch(Exception)                                                                                    //O catch (Exception) e o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conexão
                                                                                                                    //ele será capturado aqui.

                                                                                                                    //Este Exception e o tipo mais genérico de exceção em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.
                {
                    MessageBox.Show("Conessione Fallita!");                                                         //Exibe uma mensagem ao usuário informando que a tentativa de conexão falhou.
                }
            }
            btn_CheckConnection.Enabled = true;                                                                     //O btn_CheckConnection.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando true, o botão fica
                                                                                                                    //habilitado e clicável. Reativa o botão, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //falha na tentativa de conexão.
        }
        private void btn_ExecuteQuery_Click (object sender, EventArgs e)                                            //O private diz que o método é acessível apenas dentro da classe DataBase_Connection.
                                                                                                                    //O void diz que o método não retorna nenhum valor.
                                                                                                                    //O btn_ExecuteQuery_Click e nome do método chamado quando o botão "ExecuteQuery" é clicado. O object sender é o parâmetro sender
                                                                                                                    //representa o objeto que gerou o evento. No caso de um clique de botão, o sender seria o próprio botão que foi clicado. Isso é
                                                                                                                    //importante se você tiver vários botões associados ao mesmo método de evento, assim o parâmetro sender permite você quiser acessar
                                                                                                                    //propriedades específicas do botão(ou de outro controle), você precisa convertê-lo para o tipo apropriado, como Button.
                                                                                                                    //O EventArgs é o parâmetro que contém dados adicionais sobre o evento que ocorreu. No caso de um evento de clique de botão, a
                                                                                                                    //classe EventArgs não contém muitas informações adicionais, pois o clique em si é um evento simples. Embora EventArgs seja o tipo
                                                                                                                    //base para a maioria dos eventos, há eventos mais complexos que passam informações mais detalhadas, como o movimento do mouse ou
                                                                                                                    //o pressionamento de uma tecla. Para esses eventos, você usaria classes derivadas de EventArgs, como MouseEventArgs ou KeyEventArgs.
                                                                                                                    //Resumindo o object sender representa o objeto que disparou o evento, no caso de um clique, seria o botão. Ele permite que você
                                                                                                                    //identifique qual controle específico foi clicado. Ja o EventArgs e contém informações sobre o evento em si.No caso de eventos
                                                                                                                    //simples, como clique de botão, EventArgs é genérico, mas em eventos mais complexos, classes derivadas podem fornecer detalhes
                                                                                                                    //adicionais como coordenadas do mouse, teclas pressionadas, etc.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");                    //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto se ele foi preenchido ou nao.
                                                                                                                    //O string.IsNullOrEmpty é um método estático da classe String, que retorna true se a string for nula ou vazia.
                                                                                                                    //O txt_QueryString.Text refere-se ao conteúdo digitado no componente de texto txt_QueryString, e o nome da caixa
                                                                                                                    //de texto (TextBox) que está no formulário. Esse controle permite que o usuário insira informações, como a query de interrogacao ao
                                                                                                                    //banco de dados. A propriedade .Text é usada para obter ou definir o conteúdo textual do controle txt_QueryString.
                                                                                                                    //Nesse caso, quando você lê txt_QueryString.Text, você está pegando o texto que o usuário digitou no campo de entrada.
                                                                                                                    //Quando você define txt_QueryString.Text, você altera o conteúdo desse campo. Resumindo, a propriedade .Text contém
                                                                                                                    //o texto exibido ou digitado dentro da caixa de texto.
                                                                                                                    //O throw new Exception("Query vuota!"), lança ma nova exceção do tipo Exception, interrompendo a execução do método. A mensagem
                                                                                                                    //"Query vuota!" será exibida como a descrição do erro.


            




            
            
            
            btn_ExecuteQuery.Enabled = false;                                                                       //O btn_ExecuteQuery.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando false, o botão fica
                                                                                                                    //desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos cliques durante o processamento

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))                      //O using, declara um bloco de código onde o objeto sqlConnection será utilizado. Ao final do bloco, o objeto será automaticamente
                                                                                                                    //descartado (chama o método Dispose), liberando recursos de forma eficiente. O SqlConnection e uma Classe que representa uma
                                                                                                                    //conexão SQL com um banco de dados. Está localizada no namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text)
                                                                                                                    //cria uma nova instância de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o parâmetro de conexão.Isso estabelece
                                                                                                                    //os parâmetros para a conexão com o banco de dados especificado.
            {
                try                                                                                                 //O try e um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção, o controle será passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida. Se a conexão falhar, será
                                                                                                                    //gerada uma exceção, enviando o fluxo do programa para o bloco catch.

                    SqlDataAdapter adapter = new SqlDataAdapter(txt_QueryString.Text , sqlConnection);              //O SqlDataAdapter é responsável por executar a query SQL e trazer os resultados da txt_QueryString.Text que e a consulta SQL que o
                                                                                                                    //usuário digitou. O sqlConnection e a conexão aberta com o banco de dados, ou seja, O SqlDataAdapter age como uma ponte entre o
                                                                                                                    //banco de dados e o aplicativo, facilitando a recuperação de dados de forma fácil.
                    
                    DataSet setDiDati = new DataSet();                                                              //O DataSet é um contêiner de dados, como uma "tabela" em memória)
                    adapter.Fill(setDiDati, "Dati");                                                                //Usa o adapter.Fill para preencher o DataSet com os resultados da consulta SQL.
                                                                                                                    //A tabela de resultados dentro do DataSet é chamada de "Dati".
                                                                                                                    //O DataSet é usado para armazenar os resultados da query de maneira estruturada e em memória, para que possam ser exibidos no aplicativo.
                    
                    
                    
                    
                    DataTableCollection tables = setDiDati.Tables;

                    
                    
                    
                    
                    foreach (DataTable table in tables) 
                    
                    
                    {
                        TabPage tabPage = new TabPage();
                    }
                    





                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão após o uso. Embora o using já
                                                                                                                    //garanta o fechamento, é uma boa prática fechar explicitamente.

                    dgv_Data.AutoGenerateColumns = true;                                                            //O AutoGenerateColumns habilita a geração automática de colunas no DataGridView com base nos dados que foram retornados.
                    dgv_Data.DataSource = setDiDati;                                                                //O DataSource define o setDiDati como a fonte de dados para o DataGridView
                    dgv_Data.DataMember = "Dati";                                                                   //O DataMember especifica qual "tabela" dentro do DataSet será exibida e neste caso, a tabela é "Dati"

                }
                catch (Exception ex)                                                                                //O catch (Exception) e o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conexão
                                                                                                                    //ele será capturado aqui.

                                                                                                                    //Este Exception e o tipo mais genérico de exceção em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.

                                                                                                                    //O ex é o nome da variável que vai armazenar a exceção capturada. Através dela, e possivel acessar informações sobre o erro, como
                                                                                                                    //a mensagem de erro e o tipo de exceção.
                {
                    MessageBox.Show("Eccezione:", ex.Message);                                                      //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                                    //O "Eccezione: " e um Texto fixo que informa que ocorreu uma exceção.
                                                                                                                    //o codigo ex.Message e a mensagem da exceção ex que contém uma descrição do erro que ocorreu. Cada tipo de exceção pode ter
                                                                                                                    //uma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_ExecuteQuery.Enabled = true;                                                                        //O btn_ExecuteQuery.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando true, o botão fica
                                                                                                                    //habilitado e clicável. Reativa o botão, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //não do comando.
        }


        private void btn_CountQuery_Click(object sender, EventArgs e)                                               //Estou criando um metodo para quando se clica no botao que deve verificar a conexao.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");                    //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto onde deve ser

            btn_CountRecords.Enabled = false;                                                                       //O btn_CountRecords.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando false, o botão fica
                                                                                                                    //desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos cliques durante o processamento                                                                                          //colocada a string de conexao esta preenchida
            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))
            {
                try                                                                                                 //O try e um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção, o controle será passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida. Se a conexão falhar, será
                                                                                                                    //gerada uma exceção, enviando o fluxo do programa para o bloco catch.

                    SqlCommand cmd = sqlConnection.CreateCommand();                                                 //O SqlCommand cmd declara uma variável cmd do tipo SqlCommand. O SqlCommand é uma classe que representa uma instrução SQL a ser
                                                                                                                    //executada em um banco de dados.
                                                                                                                    //O método CreateCommand() é chamado na instância sqlConnection que representa a conexão com o banco de dados, assim este método
                                                                                                                    //cria um novo objeto SqlCommand associado à conexão atual (sqlConnection). Isso significa que o comando pode ser executado usando
                                                                                                                    //a conexão que acabou de ser aberta. Por que isso é importante, ao criar um comando dessa maneira, o SqlCommand está automaticamente
                                                                                                                    //associado à conexão que foi estabelecida, facilitando a execução de comandos SQL. Se fosse usado um construtor de SqlCommand
                                                                                                                    //diretamente, precisaria passar a conexão manualmente.
                    
                    cmd.CommandText = txt_QueryString.Text;                                                         //O cmd.CommandText é uma propriedade que pode ser definida como uma string que representa a consulta SQL.
                                                                                                                    //O txt_QueryString.Text esta pegando a query inserida no TextBox, o texto digitado pelo usuário é atribuído à propriedade
                                                                                                                    //CommandText do SqlCommand. Assim, cmd agora contém a consulta que o usuário deseja executar.      

                    var num = cmd.ExecuteScalar();                                                                  //O cmd.ExecuteScalar() é um método do SqlCommand que executa a consulta SQL definida na propriedade CommandText. Ele é usado para
                                                                                                                    //executar comandos SQL que retornam um único valor, como uma contagem ou uma soma. A primeira coluna da primeira linha do resultado
                                                                                                                    //da consulta é retornada.
                                                                                                                    //O var num, num é declarada, o uso de var significa que o tipo da variável será inferido pelo compilador com base no valor retornado
                                                                                                                    //por ExecuteScalar(), ou seja, num armazenará o valor retornado pela consulta, que será do tipo object, pois ExecuteScalar() pode
                                                                                                                    //retornar valores de diferentes tipos (int, string, etc.). Se a consulta retornou um valor, num conterá esse valor. Se a consulta
                                                                                                                    //não retornar nada, se a tabela estiver vazia, num será null.

                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão após o uso. Embora o using já
                                                                                                                    //garanta o fechamento, é uma boa prática fechar explicitamente.

                    MessageBox.Show(num.ToString());                                                                //Ao chamar ToString(), garantimos que o valor de num, independentemente do seu tipo original (pode ser um número, texto, etc.), seja
                                                                                                                    //convertido corretamente para um formato de string que pode ser exibido na caixa de diálogo.
                }
                catch (Exception ex)                                                                                //O catch (Exception) e o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conexão
                                                                                                                    //ele será capturado aqui.

                                                                                                                    //Este Exception e o tipo mais genérico de exceção em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.

                                                                                                                    //O ex é o nome da variável que vai armazenar a exceção capturada. Através dela, e possivel acessar informações sobre o erro, como
                                                                                                                    //a mensagem de erro e o tipo de exceção.
                {
                    MessageBox.Show("Eccezione:" , ex.Message);                                                     //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                                    //O "Eccezione: " e um Texto fixo que informa que ocorreu uma exceção.
                                                                                                                    //o codigo ex.Message e a mensagem da exceção ex que contém uma descrição do erro que ocorreu. Cada tipo de exceção pode ter
                                                                                                                    //uma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_CountRecords.Enabled = true;                                                                        //O btn_CountRecords.Enabled e a propriedade Enabled controla se o botão está ativo ou desativado. Quando true, o botão fica
                                                                                                                    //habilitado e clicável. Reativa o botão, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //não do comando.
        }
    }
}
