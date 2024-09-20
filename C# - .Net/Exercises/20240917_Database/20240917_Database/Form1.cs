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

namespace _20240917_Database                                                                                        //O namespace e uma maneira de organizar o c�digo em diferentes �reas ou se��es l�gicas. O namespace pode
                                                                                                                    //ser visto como um cont�iner que agrupa classes relacionadas, permitindo que voc� evite conflitos de
                                                                                                                    //nome quando diferentes partes do programa usam nomes semelhantes.
{
    public partial class DataBase_Connection : Form                                                                 //O public e um modificador de acesso que significa que a classe pode ser acessada de qualquer lugar no c�digo.
                                                                                                                    //O partial permite que a defini��o da classe seja dividida em v�rios arquivos. Isso � comum em
                                                                                                                    //aplica��es Windows Forms, onde o designer visual (arranjo de bot�es, campos de texto, etc.)
                                                                                                                    //fica em um arquivo separado.
                                                                                                                    //O class DataBase_Connection : Define uma classe chamada DataBase_Connection. � o nome da classe que ser� usada
                                                                                                                    //para gerenciar a conex�o com o banco de dados, ou para lidar com a interface da aplica��o relacionada a isso.
                                                                                                                    //O : Form diz que a classe DataBase_Connection herda da classe Form, que faz parte do Windows Forms (System.Windows.Forms).
                                                                                                                    //Isso significa que a classe DataBase_Connection � um formul�rio de janela gr�fica que pode conter bot�es,
                                                                                                                    //campos de texto e outros controles visuais.
    {
        public DataBase_Connection()                                                                                //public DataBase_Connection(): Este � o construtor da classe DataBase_Connection. Ele � chamado automaticamente quando
                                                                                                                    //uma nova inst�ncia da classe � criada. O papel do construtor � inicializar o objeto, ou seja, configurar qualquer
                                                                                                                    //estado ou dados iniciais necess�rios.
        {
            InitializeComponent();                                                                                  //Esse m�todo � respons�vel por inicializar todos os controles visuais (como bot�es, caixas de texto, labels) que
                                                                                                                    //est�o no formul�rio. Ele � gerado automaticamente pelo Windows Forms Designer e fica em um arquivo separado
                                                                                                                    //(geralmente no arquivo .Designer.cs associado � classe).
                                                                                                                    //O m�todo InitializeComponent() configura o layout da interface, posiciona os elementos no formul�rio e pode
                                                                                                                    //associar eventos(como cliques de bot�o) a seus respectivos m�todos.
        }
        private void btn_CheckConnection_Click(object sender, EventArgs e)                                          //Estou criando um metodo para quando clicar no botao que deve verificar a conexao.
                                                                                                                    //O private define que o m�todo s� pode ser acessado de dentro da pr�pria classe.
                                                                                                                    //O void diz que o m�todo n�o retorna nenhum valor.
                                                                                                                    //O btn_CheckConnection_Click +e o nome do m�todo, que ser� chamado quando o bot�o for clicado.
                                                                                                                    //O par�metro object sender refere-se ao objeto que disparou o evento, neste caso, o bot�o. Ele permite
                                                                                                                    //acessar informa��es sobre o bot�o que foi clicado.
        {
            if (string.IsNullOrEmpty(txt_ConnectionString.Text)) throw new Exception("Connection string vuota!");   //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto se ele foi preenchido ou nao.
                                                                                                                    //O string.IsNullOrEmpty � um m�todo est�tico da classe String, que retorna true se a string for nula ou vazia.
                                                                                                                    //O txt_ConnectionString.Text refere-se ao conte�do digitado no componente de texto txt_ConnectionString, e o nome da caixa
                                                                                                                    //de texto (TextBox) que est� no formul�rio. Esse controle permite que o usu�rio insira informa��es, como a string de conex�o ao
                                                                                                                    //banco de dados. A propriedade .Text � usada para obter ou definir o conte�do textual do controle txt_ConnectionString.
                                                                                                                    //Nesse caso, quando voc� l� txt_ConnectionString.Text, voc� est� pegando o texto que o usu�rio digitou no campo de entrada.
                                                                                                                    //Quando voc� define txt_ConnectionString.Text, voc� altera o conte�do desse campo. Resumindo, a propriedade .Text cont�m
                                                                                                                    //o texto exibido ou digitado dentro da caixa de texto.
                                                                                                                    //O throw new Exception("Connection string vuota!"), lan�a ma nova exce��o do tipo Exception, interrompendo a execu��o
                                                                                                                    //do m�todo. A mensagem "Connection string vuota!" ser� exibida como a descri��o do erro.

            btn_CheckConnection.Enabled = false;                                                                    //O btn_CheckConnection.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando false, o bot�o fica
                                                                                                                    //desabilitado, cinza e n�o clic�vel. Ele desativa o bot�o para evitar m�ltiplos cliques durante o processamento da verifica��o
                                                                                                                    //de conex�o.

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))                      //O using, declara um bloco de c�digo onde o objeto sqlConnection ser� utilizado. Ao final do bloco, o objeto ser� automaticamente
                                                                                                                    //descartado (chama o m�todo Dispose), liberando recursos de forma eficiente. O SqlConnection e uma Classe que representa uma
                                                                                                                    //conex�o SQL com um banco de dados. Est� localizada no namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text)
                                                                                                                    //cria uma nova inst�ncia de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o par�metro de conex�o.Isso estabelece
                                                                                                                    //os par�metros para a conex�o com o banco de dados especificado.
            {
                try                                                                                                 //O try e um bloco de c�digo onde ser�o feitas tentativas que podem gerar exce��es e se ocorrer uma exce��o, o controle ser� passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conex�o com o banco de dados usando a string de conex�o fornecida. Se a conex�o falhar, ser�
                                                                                                                    //gerada uma exce��o, enviando o fluxo do programa para o bloco catch.
                    
                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conex�o com o banco de dados, isso � importante para liberar a conex�o ap�s o uso. Embora o using j�
                                                                                                                    //garanta o fechamento, � uma boa pr�tica fechar explicitamente.
                    
                    MessageBox.Show("Connessione OK");                                                              //Exibe uma caixa de di�logo ao usu�rio com uma mensagem "Connessione OK", indicanso que a conex�o foi estabelecida com sucesso.
                }
                catch(Exception)                                                                                    //O catch (Exception) e o bloco que captura exce��es geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conex�o
                                                                                                                    //ele ser� capturado aqui.

                                                                                                                    //Este Exception e o tipo mais gen�rico de exce��o em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.
                {
                    MessageBox.Show("Conessione Fallita!");                                                         //Exibe uma mensagem ao usu�rio informando que a tentativa de conex�o falhou.
                }
            }
            btn_CheckConnection.Enabled = true;                                                                     //O btn_CheckConnection.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando true, o bot�o fica
                                                                                                                    //habilitado e clic�vel. Reativa o bot�o, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //falha na tentativa de conex�o.
        }
        private void btn_ExecuteQuery_Click (object sender, EventArgs e)                                            //O private diz que o m�todo � acess�vel apenas dentro da classe DataBase_Connection.
                                                                                                                    //O void diz que o m�todo n�o retorna nenhum valor.
                                                                                                                    //O btn_ExecuteQuery_Click e nome do m�todo chamado quando o bot�o "ExecuteQuery" � clicado. O object sender � o par�metro sender
                                                                                                                    //representa o objeto que gerou o evento. No caso de um clique de bot�o, o sender seria o pr�prio bot�o que foi clicado. Isso �
                                                                                                                    //importante se voc� tiver v�rios bot�es associados ao mesmo m�todo de evento, assim o par�metro sender permite voc� quiser acessar
                                                                                                                    //propriedades espec�ficas do bot�o(ou de outro controle), voc� precisa convert�-lo para o tipo apropriado, como Button.
                                                                                                                    //O EventArgs � o par�metro que cont�m dados adicionais sobre o evento que ocorreu. No caso de um evento de clique de bot�o, a
                                                                                                                    //classe EventArgs n�o cont�m muitas informa��es adicionais, pois o clique em si � um evento simples. Embora EventArgs seja o tipo
                                                                                                                    //base para a maioria dos eventos, h� eventos mais complexos que passam informa��es mais detalhadas, como o movimento do mouse ou
                                                                                                                    //o pressionamento de uma tecla. Para esses eventos, voc� usaria classes derivadas de EventArgs, como MouseEventArgs ou KeyEventArgs.
                                                                                                                    //Resumindo o object sender representa o objeto que disparou o evento, no caso de um clique, seria o bot�o. Ele permite que voc�
                                                                                                                    //identifique qual controle espec�fico foi clicado. Ja o EventArgs e cont�m informa��es sobre o evento em si.No caso de eventos
                                                                                                                    //simples, como clique de bot�o, EventArgs � gen�rico, mas em eventos mais complexos, classes derivadas podem fornecer detalhes
                                                                                                                    //adicionais como coordenadas do mouse, teclas pressionadas, etc.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");                    //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto se ele foi preenchido ou nao.
                                                                                                                    //O string.IsNullOrEmpty � um m�todo est�tico da classe String, que retorna true se a string for nula ou vazia.
                                                                                                                    //O txt_QueryString.Text refere-se ao conte�do digitado no componente de texto txt_QueryString, e o nome da caixa
                                                                                                                    //de texto (TextBox) que est� no formul�rio. Esse controle permite que o usu�rio insira informa��es, como a query de interrogacao ao
                                                                                                                    //banco de dados. A propriedade .Text � usada para obter ou definir o conte�do textual do controle txt_QueryString.
                                                                                                                    //Nesse caso, quando voc� l� txt_QueryString.Text, voc� est� pegando o texto que o usu�rio digitou no campo de entrada.
                                                                                                                    //Quando voc� define txt_QueryString.Text, voc� altera o conte�do desse campo. Resumindo, a propriedade .Text cont�m
                                                                                                                    //o texto exibido ou digitado dentro da caixa de texto.
                                                                                                                    //O throw new Exception("Query vuota!"), lan�a ma nova exce��o do tipo Exception, interrompendo a execu��o do m�todo. A mensagem
                                                                                                                    //"Query vuota!" ser� exibida como a descri��o do erro.


            




            
            
            
            btn_ExecuteQuery.Enabled = false;                                                                       //O btn_ExecuteQuery.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando false, o bot�o fica
                                                                                                                    //desabilitado, cinza e n�o clic�vel. Ele desativa o bot�o para evitar m�ltiplos cliques durante o processamento

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))                      //O using, declara um bloco de c�digo onde o objeto sqlConnection ser� utilizado. Ao final do bloco, o objeto ser� automaticamente
                                                                                                                    //descartado (chama o m�todo Dispose), liberando recursos de forma eficiente. O SqlConnection e uma Classe que representa uma
                                                                                                                    //conex�o SQL com um banco de dados. Est� localizada no namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text)
                                                                                                                    //cria uma nova inst�ncia de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o par�metro de conex�o.Isso estabelece
                                                                                                                    //os par�metros para a conex�o com o banco de dados especificado.
            {
                try                                                                                                 //O try e um bloco de c�digo onde ser�o feitas tentativas que podem gerar exce��es e se ocorrer uma exce��o, o controle ser� passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conex�o com o banco de dados usando a string de conex�o fornecida. Se a conex�o falhar, ser�
                                                                                                                    //gerada uma exce��o, enviando o fluxo do programa para o bloco catch.

                    SqlDataAdapter adapter = new SqlDataAdapter(txt_QueryString.Text , sqlConnection);              //O SqlDataAdapter � respons�vel por executar a query SQL e trazer os resultados da txt_QueryString.Text que e a consulta SQL que o
                                                                                                                    //usu�rio digitou. O sqlConnection e a conex�o aberta com o banco de dados, ou seja, O SqlDataAdapter age como uma ponte entre o
                                                                                                                    //banco de dados e o aplicativo, facilitando a recupera��o de dados de forma f�cil.
                    
                    DataSet setDiDati = new DataSet();                                                              //O DataSet � um cont�iner de dados, como uma "tabela" em mem�ria)
                    adapter.Fill(setDiDati, "Dati");                                                                //Usa o adapter.Fill para preencher o DataSet com os resultados da consulta SQL.
                                                                                                                    //A tabela de resultados dentro do DataSet � chamada de "Dati".
                                                                                                                    //O DataSet � usado para armazenar os resultados da query de maneira estruturada e em mem�ria, para que possam ser exibidos no aplicativo.
                    
                    
                    
                    
                    DataTableCollection tables = setDiDati.Tables;

                    
                    
                    
                    
                    foreach (DataTable table in tables) 
                    
                    
                    {
                        TabPage tabPage = new TabPage();
                    }
                    





                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conex�o com o banco de dados, isso � importante para liberar a conex�o ap�s o uso. Embora o using j�
                                                                                                                    //garanta o fechamento, � uma boa pr�tica fechar explicitamente.

                    dgv_Data.AutoGenerateColumns = true;                                                            //O AutoGenerateColumns habilita a gera��o autom�tica de colunas no DataGridView com base nos dados que foram retornados.
                    dgv_Data.DataSource = setDiDati;                                                                //O DataSource define o setDiDati como a fonte de dados para o DataGridView
                    dgv_Data.DataMember = "Dati";                                                                   //O DataMember especifica qual "tabela" dentro do DataSet ser� exibida e neste caso, a tabela � "Dati"

                }
                catch (Exception ex)                                                                                //O catch (Exception) e o bloco que captura exce��es geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conex�o
                                                                                                                    //ele ser� capturado aqui.

                                                                                                                    //Este Exception e o tipo mais gen�rico de exce��o em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.

                                                                                                                    //O ex � o nome da vari�vel que vai armazenar a exce��o capturada. Atrav�s dela, e possivel acessar informa��es sobre o erro, como
                                                                                                                    //a mensagem de erro e o tipo de exce��o.
                {
                    MessageBox.Show("Eccezione:", ex.Message);                                                      //o MessageBox.Show abre uma caixa de di�logo que exibe uma mensagem para o usu�rio.
                                                                                                                    //O "Eccezione: " e um Texto fixo que informa que ocorreu uma exce��o.
                                                                                                                    //o codigo ex.Message e a mensagem da exce��o ex que cont�m uma descri��o do erro que ocorreu. Cada tipo de exce��o pode ter
                                                                                                                    //uma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_ExecuteQuery.Enabled = true;                                                                        //O btn_ExecuteQuery.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando true, o bot�o fica
                                                                                                                    //habilitado e clic�vel. Reativa o bot�o, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //n�o do comando.
        }


        private void btn_CountQuery_Click(object sender, EventArgs e)                                               //Estou criando um metodo para quando se clica no botao que deve verificar a conexao.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");                    //Aqui estou dizendo que ao ser clicado a condicao deve verificar no campo de texto onde deve ser

            btn_CountRecords.Enabled = false;                                                                       //O btn_CountRecords.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando false, o bot�o fica
                                                                                                                    //desabilitado, cinza e n�o clic�vel. Ele desativa o bot�o para evitar m�ltiplos cliques durante o processamento                                                                                          //colocada a string de conexao esta preenchida
            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))
            {
                try                                                                                                 //O try e um bloco de c�digo onde ser�o feitas tentativas que podem gerar exce��es e se ocorrer uma exce��o, o controle ser� passado
                                                                                                                    //para o bloco catch.
                {
                    sqlConnection.Open();                                                                           //O sqlConnection.Open() tenta abrir a conex�o com o banco de dados usando a string de conex�o fornecida. Se a conex�o falhar, ser�
                                                                                                                    //gerada uma exce��o, enviando o fluxo do programa para o bloco catch.

                    SqlCommand cmd = sqlConnection.CreateCommand();                                                 //O SqlCommand cmd declara uma vari�vel cmd do tipo SqlCommand. O SqlCommand � uma classe que representa uma instru��o SQL a ser
                                                                                                                    //executada em um banco de dados.
                                                                                                                    //O m�todo CreateCommand() � chamado na inst�ncia sqlConnection que representa a conex�o com o banco de dados, assim este m�todo
                                                                                                                    //cria um novo objeto SqlCommand associado � conex�o atual (sqlConnection). Isso significa que o comando pode ser executado usando
                                                                                                                    //a conex�o que acabou de ser aberta. Por que isso � importante, ao criar um comando dessa maneira, o SqlCommand est� automaticamente
                                                                                                                    //associado � conex�o que foi estabelecida, facilitando a execu��o de comandos SQL. Se fosse usado um construtor de SqlCommand
                                                                                                                    //diretamente, precisaria passar a conex�o manualmente.
                    
                    cmd.CommandText = txt_QueryString.Text;                                                         //O cmd.CommandText � uma propriedade que pode ser definida como uma string que representa a consulta SQL.
                                                                                                                    //O txt_QueryString.Text esta pegando a query inserida no TextBox, o texto digitado pelo usu�rio � atribu�do � propriedade
                                                                                                                    //CommandText do SqlCommand. Assim, cmd agora cont�m a consulta que o usu�rio deseja executar.      

                    var num = cmd.ExecuteScalar();                                                                  //O cmd.ExecuteScalar() � um m�todo do SqlCommand que executa a consulta SQL definida na propriedade CommandText. Ele � usado para
                                                                                                                    //executar comandos SQL que retornam um �nico valor, como uma contagem ou uma soma. A primeira coluna da primeira linha do resultado
                                                                                                                    //da consulta � retornada.
                                                                                                                    //O var num, num � declarada, o uso de var significa que o tipo da vari�vel ser� inferido pelo compilador com base no valor retornado
                                                                                                                    //por ExecuteScalar(), ou seja, num armazenar� o valor retornado pela consulta, que ser� do tipo object, pois ExecuteScalar() pode
                                                                                                                    //retornar valores de diferentes tipos (int, string, etc.). Se a consulta retornou um valor, num conter� esse valor. Se a consulta
                                                                                                                    //n�o retornar nada, se a tabela estiver vazia, num ser� null.

                    sqlConnection.Close();                                                                          //O sqlConnection.Close() fecha a conex�o com o banco de dados, isso � importante para liberar a conex�o ap�s o uso. Embora o using j�
                                                                                                                    //garanta o fechamento, � uma boa pr�tica fechar explicitamente.

                    MessageBox.Show(num.ToString());                                                                //Ao chamar ToString(), garantimos que o valor de num, independentemente do seu tipo original (pode ser um n�mero, texto, etc.), seja
                                                                                                                    //convertido corretamente para um formato de string que pode ser exibido na caixa de di�logo.
                }
                catch (Exception ex)                                                                                //O catch (Exception) e o bloco que captura exce��es geradas dentro do try e se ocorrer um erro durante a tentativa de abrir a conex�o
                                                                                                                    //ele ser� capturado aqui.

                                                                                                                    //Este Exception e o tipo mais gen�rico de exce��o em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.

                                                                                                                    //O ex � o nome da vari�vel que vai armazenar a exce��o capturada. Atrav�s dela, e possivel acessar informa��es sobre o erro, como
                                                                                                                    //a mensagem de erro e o tipo de exce��o.
                {
                    MessageBox.Show("Eccezione:" , ex.Message);                                                     //o MessageBox.Show abre uma caixa de di�logo que exibe uma mensagem para o usu�rio.
                                                                                                                    //O "Eccezione: " e um Texto fixo que informa que ocorreu uma exce��o.
                                                                                                                    //o codigo ex.Message e a mensagem da exce��o ex que cont�m uma descri��o do erro que ocorreu. Cada tipo de exce��o pode ter
                                                                                                                    //uma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_CountRecords.Enabled = true;                                                                        //O btn_CountRecords.Enabled e a propriedade Enabled controla se o bot�o est� ativo ou desativado. Quando true, o bot�o fica
                                                                                                                    //habilitado e clic�vel. Reativa o bot�o, permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                                    //n�o do comando.
        }
    }
}
