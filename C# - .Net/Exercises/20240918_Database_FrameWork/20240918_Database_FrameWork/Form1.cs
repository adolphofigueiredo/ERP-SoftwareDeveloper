// 1: verificare connessione al db passando la connection string attraverso una textbox
// 2; mostrare un messaggio a video (Messagebox) con il risultato scalare della query inputata dall'utente.
// 3: visualizzare in forma tabellare i dati estratti da una query inputata dall'utente.

using System.ComponentModel.Design;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Security.Policy;

namespace _20240918_Database_FrameWork                                                             //O namespace é uma maneira de organizar o código em diferentes áreas ou seções lógicas. O namespace pode
                                                                                                   //ser visto como um contêiner que agrupa classes relacionadas, permitindo que você evite conflitos de
                                                                                                   //nome quando diferentes partes do programa usam nomes semelhantes.
{
    public partial class DataBase_Connection : Form                                                //O public é um modificador de acesso que significa que a classe pode ser acessada de qualquer lugar no código.
                                                                                                   //O partial permite que a definição da classe seja dividida em vários arquivos. Isso é comum em aplicações
                                                                                                   //Windows Forms, onde o design visual (arranjo de botões, campos de texto, etc.) fica em um arquivo separado.
                                                                                                   //O class DataBase_Connection é a definição de uma classe chamada DataBase_Connection. É o nome da classe que
                                                                                                   //será usada para gerenciar a conexão com o banco de dados, ou para lidar com a interface da aplicação
                                                                                                   //relacionada a isso.
                                                                                                   //O : Form diz que a classe DataBase_Connection herda os atributos e métodos da classe Form, que faz parte do
                                                                                                   //Windows Forms (System.Windows.Forms). Isso significa que a classe DataBase_Connection é um formulário de
                                                                                                   //janela gráfica que pode conter botões, campos de texto e outros controles visuais.
    {
        public DataBase_Connection()                                                               //O public DataBase_Connection() é o construtor da classe DataBase_Connection. Ele é chamado automaticamente
                                                                                                   //quando uma nova instância da classe é criada. O papel do construtor é inicializar o objeto, ou seja,
                                                                                                   //configurar qualquer estado ou dados iniciais necessários.
        {
            InitializeComponent();                                                                 //Esse método é responsável por inicializar todos os controles visuais (como botões, caixas de texto, labels)
                                                                                                   //que estão no formulário. Ele é gerado automaticamente pelo Windows Forms Designer e fica em um arquivo
                                                                                                   //separado (geralmente no arquivo .Designer.cs associado à classe).
                                                                                                   //O método InitializeComponent() configura o layout da interface, posiciona os elementos no formulário e pode
                                                                                                   //associar eventos(como cliques de botão) a seus respectivos métodos.
        }
        private void btn_CheckConnection_Click(object sender, EventArgs e)                         //Estou criando um método para, que o botão ao ser clicado verifique a conexão.
                                                                                                   //O private define que o método só pode ser acessado de dentro da própria classe.
                                                                                                   //O void diz que o método não retorna nenhum valor.
                                                                                                   //O btn_CheckConnection_Click é o nome do método que será chamado quando o botão for clicado.
                                                                                                   //O parâmetro object sender refere-se ao objeto que disparou o evento, neste caso, o botão. Ele permite
                                                                                                   //acessar informações sobre o botão que foi clicado.
        {
            if (string.IsNullOrEmpty(txt_ConnectionString.Text)) throw new Exception("Connection string vuota!");
                                                                                                   //Aqui estou dizendo que quando o botão foi acionado a condição deve verificar no campo de texto se ele foi
                                                                                                   //preenchido ou não. O string.IsNullOrEmpty é um método estático da classe String, que retorna true se a
                                                                                                   //string for nula ou vazia. O txt_ConnectionString.Text refere-se ao conteúdo digitado no componente de texto
                                                                                                   //txt_ConnectionString, e o nome da caixa de texto (TextBox) que está no formulário. Esse controle permite que
                                                                                                   //o usuário insira informações, como a string de conexão ao banco de dados. A propriedade .Text é usada para
                                                                                                   //obter ou definir o conteúdo textual do controle txt_ConnectionString. Nesse caso, quando você lê
                                                                                                   //txt_ConnectionString.Text, você está pegando o texto que o usuário digitou no campo de entrada. Quando você
                                                                                                   //define txt_ConnectionString.Text, você altera o conteúdo desse campo. Resumindo, a propriedade .Text contém
                                                                                                   //o texto exibido ou digitado dentro da caixa de texto. O throw new Exception("Connection string vuota!"),
                                                                                                   //lança ma nova exceção do tipo Exception, interrompendo a execução do método. A mensagem "Connection string
                                                                                                   //vuota!" será exibida como a descrição do erro.

            btn_CheckConnection.Enabled = false;                                                   //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como false, o botão fica desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos
                                                                                                   //cliques durante o processamento do que foi solicitado.

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))     //O using, declara um bloco de código onde o objeto sqlConnection será utilizado. Ao final do bloco, o objeto
                                                                                                   //será automaticamente descartado (chama o método Dispose), liberando recursos de forma eficiente. O
                                                                                                   //SqlConnection é uma Classe que representa uma conexão SQL com um banco de dados. Está localizada no
                                                                                                   //namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text) cria uma nova instância
                                                                                                   //de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o parâmetro de conexão. Assim,
                                                                                                   //estabelecendo os parâmetros para a conexão com o banco de dados especificado.
            {
                try                                                                                //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção,
                                                                                                   //o controle será passado para o bloco catch.
                {
                    sqlConnection.Open();                                                          //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida.
                                                                                                   //Se a conexão falhar, será gerada uma exceção, enviando o fluxo do programa para o bloco catch.

                    sqlConnection.Close();                                                         //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão
                                                                                                   //após o uso. Embora o using já garanta o fechamento, fechar explicitamente é uma boa prática.

                    MessageBox.Show("Connessione OK");                                             //Exibe uma caixa de diálogo ao usuário com uma mensagem "Connessione OK", indicanso que a conexão foi
                                                                                                   //estabelecida com sucesso.
                }
                catch (Exception)                                                                  //O catch (Exception) é o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a
                                                                                                   //tentativa de abrir a conexão ele será capturado aqui. Este Exception é o tipo mais genérico de exceção
                                                                                                   //em C#. Isso captura qualquer tipo de erro que ocorra no bloco try.
                {
                    MessageBox.Show("Conessione Fallita!");                                        //Exibe uma mensagem ao usuário informando que a tentativa de conexão falhou.
                }
            }
            btn_CheckConnection.Enabled = true;                                                    //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como true, o botão fica habilitado e clicável. Reativa o botão, permitindo que ele seja clicado
                                                                                                   //novamente. Isso ocorre independentemente do sucesso ou falha na tentativa de execução do que foi pedido.
        }
        private void btn_ExecuteQuery_Click(object sender, EventArgs e)                            //Estou criando um método para, que o botão ao ser clicado faça a pesquisa que a query está pedindo. O
                                                                                                   //private diz que o método é acessível apenas dentro da classe DataBase_Connection. O void diz que o
                                                                                                   //método não retorna nenhum valor. O btn_ExecuteQuery_Click é o nome do método que será chamado quando
                                                                                                   //o botão "ExecuteQuery" for clicado. O parâmetro object sender refere-se ao objeto que disparou o
                                                                                                   //evento, neste caso, o botão. Ele permite acessar informações sobre o botão que foi clicado.Isso é
                                                                                                   //importante se você tiver vários botões associados ao mesmo método de evento, assim o parâmetro sender
                                                                                                   //permite você quiser acessar propriedades específicas do botão(ou de outro controle), você precisa
                                                                                                   //convertê-lo para o tipo apropriado, como Button. O EventArgs é o parâmetro que contém dados adicionais
                                                                                                   //sobre o evento que ocorreu. No caso de um evento de clique de botão, a classe EventArgs não contém
                                                                                                   //muitas informações adicionais, pois o clique em si é um evento simples. Embora EventArgs seja o tipo
                                                                                                   //base para a maioria dos eventos, há eventos mais complexos que passam informações mais detalhadas,
                                                                                                   //como o movimento do mouse ou o pressionamento de uma tecla. Para esses eventos, você usaria classes
                                                                                                   //derivadas de EventArgs, como MouseEventArgs ou KeyEventArgs. Resumindo o object sender representa o
                                                                                                   //objeto que disparou o evento, no caso de um clique, seria o botão. Ele permite que você identifique
                                                                                                   //qual controle específico foi clicado.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");
                                                                                                   //Aqui estou dizendo que quando o botão foi acionado a condição deve verificar no campo de texto se ele foi
                                                                                                   //preenchido ou não. O string.IsNullOrEmpty é um método estático da classe String, que retorna true se a
                                                                                                   //string for nula ou vazia. O txt_QueryString.Text refere-se ao conteúdo digitado no componente de texto
                                                                                                   //txt_QueryString, e o nome da caixa de texto (TextBox) que está no formulário. Esse controle permite que
                                                                                                   //o usuário insira informações, como a string de conexão ao banco de dados. A propriedade .Text é usada para
                                                                                                   //obter ou definir o conteúdo textual do controle txt_QueryString. Nesse caso, quando você lê
                                                                                                   //txt_QueryString.Text, você está pegando o texto que o usuário digitou no campo de entrada. Quando você
                                                                                                   //define txt_QueryString.Text, você altera o conteúdo desse campo. Resumindo, a propriedade .Text contém
                                                                                                   //o texto exibido ou digitado dentro da caixa de texto. O throw new Exception("Query vuota!"),
                                                                                                   //lança ma nova exceção do tipo Exception, interrompendo a execução do método. A mensagem "Query vuota!"
                                                                                                   //será exibida como a descrição do erro.

            tab_QueryResult.TabPages.Clear();                                                      //O TabControl é um controle de interface gráfica do Windows Forms que exibe várias abas, ou "páginas",
                                                                                                   //onde cada aba pode conter diferentes controles(por exemplo, uma tabela de dados ou um gráfico). O
                                                                                                   //tab_QueryResult é o nome do controle no formulário, que exibe o resultado das consultas feitas pelo
                                                                                                   //usuário, cada uma em uma aba separada. O TabPages é a propriedade do controle TabControl que mantém
                                                                                                   //uma coleção de todas as páginas de aba (TabPage) associadas ao TabControl. Cada aba em um TabControl
                                                                                                   //é representada por um objeto TabPage. A coleção TabPages permite que você acesse, adicione ou remova
                                                                                                   //essas páginas. O método Clear() remove todos os itens da coleção. No contexto de um TabControl, ele
                                                                                                   //remove todas as abas (TabPages) associadas ao controle, quando você chama Clear(), todas as abas do
                                                                                                   //controle tab_QueryResult são removidas. Isso é útil quando você quer resetar o controle e garantir
                                                                                                   //que todas as abas anteriores sejam descartadas antes de exibir novos resultados.

            btn_ExecuteQuery.Enabled = false;                                                      //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como false, o botão fica desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos
                                                                                                   //cliques durante o processamento do que foi solicitado.

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))     //O using, declara um bloco de código onde o objeto sqlConnection será utilizado. Ao final do bloco, o objeto
                                                                                                   //será automaticamente descartado (chama o método Dispose), liberando recursos de forma eficiente. O
                                                                                                   //SqlConnection é uma Classe que representa uma conexão SQL com um banco de dados. Está localizada no
                                                                                                   //namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text) cria uma nova instância
                                                                                                   //de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o parâmetro de conexão. Assim,
                                                                                                   //estabelecendo os parâmetros para a conexão com o banco de dados especificado.
            {
                try                                                                                //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção,
                                                                                                   //o controle será passado para o bloco catch.
                {
                    sqlConnection.Open();                                                          //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida.
                                                                                                   //Se a conexão falhar, será gerada uma exceção, enviando o fluxo do programa para o bloco catch.

                    SqlDataAdapter adapter = new SqlDataAdapter(txt_QueryString.Text, sqlConnection);   
                                                                                                   //O SqlDataAdapter é responsável por executar a query SQL e trazer os resultados da txt_QueryString.Text que
                                                                                                   //é a consulta SQL que o usuário digitou. O sqlConnection é a conexão aberta com o banco de dados, ou seja,
                                                                                                   //O SqlDataAdapter age como uma ponte entre obanco de dados e o aplicativo, facilitando a recuperação de
                                                                                                   //dados de forma fácil.

                    DataSet setDiDati = new DataSet();                                             //O DataSet é um contêiner de dados, como uma "tabela" em memória.
                    adapter.Fill(setDiDati);                                                       //Usa o adapter.Fill para preencher o DataSet com os resultados da consulta SQL.
                                                                                                   //A tabela de resultados dentro do DataSet é chamada de "Dati".
                                                                                                   
                    sqlConnection.Close();                                                         //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão
                                                                                                   //após o uso. Embora o using já garanta o fechamento, fechar explicitamente é uma boa prática

                    DataTableCollection tables = setDiDati.Tables;                                 //O DataTableCollection é uma coleção de DataTable dentro de um DataSet. O DataSet(setDiDati) pode conter
                                                                                                   //várias tabelas de dados, e a propriedade Tables é a coleção que armazena todas essas tabelas. Isso
                                                                                                   //significa que setDiDati. Tables representa todas as tabelas que foram carregadas para o DataSet a
                                                                                                   //partir da consulta SQL, ou seja, essa linha captura todas as tabelas resultantes da execução da consulta
                                                                                                   //SQL e as coloca na variável tables.

                    foreach (DataTable table in tables)                                            //O foreach percorre a coleção tables (que contém as tabelas do DataSet). A cada iteração, uma tabela
                                                                                                   //(DataTable) da coleção é armazenada na variável table. O código está iterando sobre cada tabela que
                                                                                                   //foi retornada pela consulta SQL. Isso permite que o programa lide com vários conjuntos de resultados
                                                                                                   //(ou tabelas) de uma vez, criando abas separadas para cada uma delas.
                    {
                        var tab = new TabPage();                                                   //Cada TabPage representa uma única aba dentro de um controle TabControl em um formulário. Esta linha
                                                                                                   //cria uma nova aba (TabPage) que será usada para exibir os dados da tabela atual (table) da iteração,
                                                                                                   //ou seja, para cada tabela retornada pela consulta SQL, o código cria uma nova aba no controle
                                                                                                   //TabControl do formulário para que cada tabela tenha sua própria exibição separada.
                        
                        {
                            tab.Text = table.TableName;                                            //A propriedade Text define o texto que será exibido na aba da interface. Aqui, o nome da aba é
                                                                                                   //definido como o nome da tabela atual (table.TableName). O nome da tabela que está sendo exibida
                                                                                                   //(obtido através de table.TableName) é atribuído ao texto da aba para que o usuário saiba qual tabela
                                                                                                   //está sendo mostrada em cada aba. O TableName é o nome que a tabela tinha no banco de dados ou um
                                                                                                   //nome atribuído automaticamente.
                        };

                        var dgvData = new DataGridView();                                          //Um DataGridView é um controle de interface que exibe dados em formato de grade, com linhas e colunas.
                                                                                                   //Ele é muito usado para mostrar tabelas de banco de dados em interfaces gráficas, ou seja, ela cria um
                                                                                                   //novo DataGridView, que será usado para exibir os dados da tabela atual. O DataGridView permite que os
                                                                                                   //dados sejam visualizados em uma interface de usuário com formatação de tabela. Resumindo, para cada
                                                                                                   //tabela(DataTable) processada, o código cria um novo DataGridView que será preenchido com os dados
                                                                                                   //dessa tabela. Este DataGridView será posteriormente adicionado à aba (TabPage) criada, para que cada
                                                                                                   //aba mostre seus dados em um formato tabular.
                        {
                            dgvData.AutoGenerateColumns = true;                                    //O AutoGenerateColumns habilita a geração automática de colunas no DataGridView com base nos dados que
                                                                                                   //foram retornados.
                            
                            dgvData.DataSource = setDiDati;                                        //O DataSource define o setDiDati como a fonte de dados para o DataGridView                            

                            dgvData.DataMember = table.TableName;                                  //O DataMember especifica qual "tabela" dentro do DataSet será exibida                            

                            dgvData.Dock = DockStyle.Fill;                                         //A propriedade Dock do controle(dgvData) especifica como o controle será redimensionado dentro de seu
                                                                                                   //contêiner pai(neste caso, a aba ou TabPage). O valor DockStyle.Fill instrui o controle
                                                                                                   //DataGridView(dgvData) a preencher completamente o espaço disponível dentro da aba(TabPage).Isso
                                                                                                   //significa que o controle se ajustará automaticamente ao tamanho da aba, ocupando todo o espaço
                                                                                                   //disponível dentro dela. Esse comportamento é útil para garantir que o DataGridView seja
                                                                                                   //redimensionado dinamicamente, permitindo que os dados da tabela sejam exibidos adequadamente,
                                                                                                   //independentemente do tamanho da janela. Se a aba for redimensionada, o DataGridView também será
                                                                                                   //redimensionado para preencher todo o espaço da aba.
                        };
                        tab.Controls.Add(dgvData);                                                 //O método Controls.Add() adiciona um controle ao contêiner de controles de um outro controle. Aqui,
                                                                                                   //o TabPage (tab) é o contêiner, e o controle dgvData (o DataGridView) é o controle que será adicionado
                                                                                                   //à aba. O controle DataGridView (dgvData), que foi criado e configurado anteriormente, é adicionado
                                                                                                   //à aba (tab). Isso faz com que o DataGridView seja exibido dentro da aba quando o formulário for
                                                                                                   //mostrado ao usuário. Após configurar o DataGridView (habilitando colunas automáticas, definindo a
                                                                                                   //fonte de dados e outros aspectos), ele precisa ser exibido na interface do usuário. O Controls.Add()
                                                                                                   //garante que o controle seja colocado na aba correta. O DataGridView preencherá a aba(por causa do
                                                                                                   //DockStyle.Fill definido anteriormente), e o usuário poderá ver e interagir com os dados da tabela.

                        tab_QueryResult.TabPages.Add(tab);                                         //O TabPages é uma coleção de páginas de abas(TabPage) dentro de um controle TabControl.O método Add()
                                                                                                   //insere uma nova aba na coleção de abas. A aba (tab) que contém o DataGridView (preenchido com os dados
                                                                                                   //da tabela SQL) é adicionada ao controle de abas principal(tab_QueryResult). Isso faz com que a nova
                                                                                                   //aba seja exibida no controle de abas(TabControl), permitindo ao usuário alternar entre diferentes abas
                                                                                                   //que mostram diferentes tabelas. O controle de abas(TabControl) tab_QueryResult é usado para exibir
                                                                                                   //múltiplos conjuntos de resultados de tabelas SQL. Cada vez que uma nova tabela é processada, uma nova
                                                                                                   //aba é criada e adicionada ao controle de abas. Isso permite ao usuário navegar entre diferentes tabelas
                                                                                                   //de resultados, já que cada uma será exibida em uma aba separada.
                    }
                }
                catch (Exception ex)                                                               //O catch (Exception) é o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a
                                                                                                   //tentativa de abrir a conexão ele será capturado aqui. Este Exception é o tipo mais genérico de exceção
                                                                                                   //em C#. Isso captura qualquer tipo de erro que ocorra no bloco try. O ex é o nome da variável que vai
                                                                                                   //armazenar a exceção capturada. Através dela, é possível acessar informações sobre o erro, como a
                                                                                                   //mensagem de erro e o tipo de exceção.
                {
                    MessageBox.Show("Eccezione:", ex.Message);                                     //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                   //O "Eccezione: " é um Texto fixo que informa que ocorreu uma exceção. O código
                                                                                                   //ex.Message é a mensagem da exceção ex que contém uma descrição do erro que ocorreu.
                                                                                                   //Cada tipo de exceção pode teruma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_ExecuteQuery.Enabled = true;                                                       //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como true, o botão fica habilitado e clicável. Reativa o botão, permitindo que ele seja clicado
                                                                                                   //novamente. Isso ocorre independentemente do sucesso ou falha na tentativa de execução do que foi pedido.
        }


        private void btn_CountQuery_Click(object sender, EventArgs e)                              //Estou criando um método para, que o botão ao ser clicado faça a pesquisa que a query está pedindo. O
                                                                                                   //private diz que o método é acessível apenas dentro da classe DataBase_Connection. O void diz que o
                                                                                                   //método não retorna nenhum valor. O btn_CountQuery_Click é o nome do método que será chamado quando
                                                                                                   //o botão "CountQuery" for clicado. O parâmetro object sender refere-se ao objeto que disparou o
                                                                                                   //evento, neste caso, o botão. Ele permite acessar informações sobre o botão que foi clicado.Isso é
                                                                                                   //importante se você tiver vários botões associados ao mesmo método de evento, assim o parâmetro sender
                                                                                                   //permite você quiser acessar propriedades específicas do botão(ou de outro controle), você precisa
                                                                                                   //convertê-lo para o tipo apropriado, como Button. O EventArgs é o parâmetro que contém dados adicionais
                                                                                                   //sobre o evento que ocorreu. No caso de um evento de clique de botão, a classe EventArgs não contém
                                                                                                   //muitas informações adicionais, pois o clique em si é um evento simples. Embora EventArgs seja o tipo
                                                                                                   //base para a maioria dos eventos, há eventos mais complexos que passam informações mais detalhadas,
                                                                                                   //como o movimento do mouse ou o pressionamento de uma tecla. Para esses eventos, você usaria classes
                                                                                                   //derivadas de EventArgs, como MouseEventArgs ou KeyEventArgs. Resumindo o object sender representa o
                                                                                                   //objeto que disparou o evento, no caso de um clique, seria o botão. Ele permite que você identifique
                                                                                                   //qual controle específico foi clicado.
        {
            if (string.IsNullOrEmpty(txt_QueryString.Text)) throw new Exception("Query vuota!");
                                                                                                   //Aqui estou dizendo que quando o botão foi acionado a condição deve verificar no campo de texto se ele foi
                                                                                                   //preenchido ou não. O string.IsNullOrEmpty é um método estático da classe String, que retorna true se a
                                                                                                   //string for nula ou vazia. O txt_QueryString.Text refere-se ao conteúdo digitado no componente de texto
                                                                                                   //txt_QueryString, e o nome da caixa de texto (TextBox) que está no formulário. Esse controle permite que
                                                                                                   //o usuário insira informações, como a string de conexão ao banco de dados. A propriedade .Text é usada para
                                                                                                   //obter ou definir o conteúdo textual do controle txt_QueryString. Nesse caso, quando você lê
                                                                                                   //txt_QueryString.Text, você está pegando o texto que o usuário digitou no campo de entrada. Quando você
                                                                                                   //define txt_QueryString.Text, você altera o conteúdo desse campo. Resumindo, a propriedade .Text contém
                                                                                                   //o texto exibido ou digitado dentro da caixa de texto. O throw new Exception("Query vuota!"),
                                                                                                   //lança ma nova exceção do tipo Exception, interrompendo a execução do método. A mensagem "Query vuota!"
                                                                                                   //será exibida como a descrição do erro.

            btn_CountRecords.Enabled = false;                                                      //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como false, o botão fica desabilitado, cinza e não clicável. Ele desativa o botão para evitar múltiplos
                                                                                                   //cliques durante o processamento do que foi solicitado.

            using (SqlConnection sqlConnection = new SqlConnection(txt_ConnectionString.Text))     //O using, declara um bloco de código onde o objeto sqlConnection será utilizado. Ao final do bloco, o objeto
                                                                                                   //será automaticamente descartado (chama o método Dispose), liberando recursos de forma eficiente. O
                                                                                                   //SqlConnection é uma Classe que representa uma conexão SQL com um banco de dados. Está localizada no
                                                                                                   //namespace System.Data.SqlClient. O new SqlConnection(txt_ConnectionString.Text) cria uma nova instância
                                                                                                   //de SqlConnection, usando o texto da caixa txt_ConnectionString.Text como o parâmetro de conexão. Assim,
                                                                                                   //estabelecendo os parâmetros para a conexão com o banco de dados especificado.
            {
                try                                                                                //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se ocorrer uma exceção,
                                                                                                   //o controle será passado para o bloco catch.
                {
                    sqlConnection.Open();                                                          //O sqlConnection.Open() tenta abrir a conexão com o banco de dados usando a string de conexão fornecida.
                                                                                                   //Se a conexão falhar, será gerada uma exceção, enviando o fluxo do programa para o bloco catch.

                    SqlCommand cmd = sqlConnection.CreateCommand();                                //O SqlCommand cmd declara uma variável cmd do tipo SqlCommand. O SqlCommand é uma classe que representa uma
                                                                                                   //instrução SQL a ser executada em um banco de dados. O método CreateCommand() é chamado na instância
                                                                                                   //sqlConnection que representa a conexão com o banco de dados, assim este método cria um novo objeto SqlCommand
                                                                                                   //associado à conexão atual (sqlConnection). Isso significa que o comando pode ser executado usando a conexão
                                                                                                   //que acabou de ser aberta. Por que isso é importante, ao criar um comando dessa maneira, o SqlCommand está
                                                                                                   //automaticamente associado à conexão que foi estabelecida, facilitando a execução de comandos SQL. Se fosse
                                                                                                   //usado um construtor de SqlCommand diretamente, precisaria passar a conexão manualmente.

                    cmd.CommandText = txt_QueryString.Text;                                        //O cmd.CommandText é uma propriedade que pode ser definida como uma string que representa a consulta SQL.
                                                                                                   //O txt_QueryString.Text esta pegando a query inserida no TextBox, o texto digitado pelo usuário é atribuído
                                                                                                   //à propriedade CommandText do SqlCommand. Assim, cmd agora contém a consulta que o usuário deseja executar.      

                    var num = cmd.ExecuteScalar();                                                 //O cmd.ExecuteScalar() é um método do SqlCommand que executa a consulta SQL definida na propriedade
                                                                                                   //CommandText. Ele é usado para executar comandos SQL que retornam um único valor, como uma contagem ou uma
                                                                                                   //soma. A primeira coluna da primeira linha do resultado da consulta é retornada. O var num, num é declarada,
                                                                                                   //o uso de var significa que o tipo da variável será inferido pelo compilador com base no valor retornado
                                                                                                   //por ExecuteScalar(), ou seja, num armazenará o valor retornado pela consulta, que será do tipo object,
                                                                                                   //pois ExecuteScalar() pode retornar valores de diferentes tipos (int, string, etc.). Se a consulta retornou
                                                                                                   //um valor, num conterá esse valor. Se a consulta não retornar nada, se a tabela estiver vazia, num será null.

                    sqlConnection.Close();                                                         //O sqlConnection.Close() fecha a conexão com o banco de dados, isso é importante para liberar a conexão
                                                                                                   //após o uso. Embora o using já garanta o fechamento, fechar explicitamente é uma boa prática

                    MessageBox.Show(num.ToString());                                               //Ao chamar ToString(), garantimos que o valor de num, independentemente do seu tipo original (pode ser
                                                                                                   //um número, texto, etc.), seja~convertido corretamente para um formato de string que pode ser exibido
                                                                                                   //na caixa de diálogo.
                }
                catch (Exception ex)                                                               //O catch (Exception) é o bloco que captura exceções geradas dentro do try e se ocorrer um erro durante a
                                                                                                   //tentativa de abrir a conexão ele será capturado aqui. Este Exception é o tipo mais genérico de exceção
                                                                                                   //em C#. Isso captura qualquer tipo de erro que ocorra no bloco try. O ex é o nome da variável que vai
                                                                                                   //armazenar a exceção capturada. Através dela, é possível acessar informações sobre o erro, como a
                                                                                                   //mensagem de erro e o tipo de exceção.
                {
                    MessageBox.Show("Eccezione:", ex.Message);                                     //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                   //O "Eccezione: " é um Texto fixo que informa que ocorreu uma exceção. O código
                                                                                                   //ex.Message é a mensagem da exceção ex que contém uma descrição do erro que ocorreu.
                                                                                                   //Cada tipo de exceção pode teruma mensagem diferente, explicando o que deu errado.
                }
            }
            btn_CountRecords.Enabled = true;                                                       //O btn_CheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou desativado. Quando
                                                                                                   //está como true, o botão fica habilitado e clicável. Reativa o botão, permitindo que ele seja clicado
                                                                                                   //novamente. Isso ocorre independentemente do sucesso ou falha na tentativa de execução do que foi pedido.
        }
    }
}