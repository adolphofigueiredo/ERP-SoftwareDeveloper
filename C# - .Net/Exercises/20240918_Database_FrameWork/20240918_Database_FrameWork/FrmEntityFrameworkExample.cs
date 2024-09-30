using _20240918_Database_FrameWork.Models;
using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmEntityFrameworkExample : Form                                          //A classe FrmEntityFrameworkExample herda da classe Form, o que significa que ela é um formulário
                                                                                                   //de uma aplicação Windows Forms. A palavra-chave partial indica que a definição
                                                                                                   //dessa classe pode estar espalhada por vários arquivos, o que é típico quando
                                                                                                   //usamos o Windows Forms Designer, que gera automaticamente parte do código.

    {
        public FrmEntityFrameworkExample()                                                         //Construtor do tipo publico que chama o método InitializeComponent()
        {
            InitializeComponent();                                                                 //O construtor FrmStudenti() chama o método InitializeComponent(), que é responsável
                                                                                                   //por inicializar e configurar os controles visuais do formulário (gerado
                                                                                                   //automaticamente pelo designer do Windows Forms).
        }
        private void btnCheckConnection_Click(object sender, EventArgs e)                          //O private void btnCheckConnection_Click é o método que é acionado quando o botão btnCheckConnection
                                                                                                   //é clicado. O object sender se refere ao controle que disparou o evento (neste caso, o
                                                                                                   //botão). Já o EventArgs e contém os dados do evento. Como é um clique de botão, não é
                                                                                                   //usado neste caso.
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection string vuota");
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

            btnCheckConnection.Enabled = false;                                                    //O btnCheckConnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como false, o botão fica desabilitado, cinza e não clicável.
                                                                                                   //Ele desativa o botão para evitar múltiplos cliques durante o processamento do que foi
                                                                                                   //solicitado.

            try                                                                                    //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se
                                                                                                   //ocorrer uma exceção, o controle será passado para o bloco catch.
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                                                                                                   //O using é uma declaração que é usada em C# para garantir que os recursos não gerenciados, como conexões de
                                                                                                   //banco de dados, arquivos ou streams, sejam liberados corretamente quando o bloco de código é concluído. No
                                                                                                   //caso de classes que implementam a interface IDisposable(como a classe de contexto do Entity Framework), o
                                                                                                   //using chama o método Dispose() automaticamente quando o bloco de código é finalizado, garantindo que a
                                                                                                   //conexão com o banco de dados seja fechada corretamente e que a memória seja liberada. A ItsCorsiEsamiContext
                                                                                                   //é uma classe que provavelmente deriva de DbContext, a classe base do Entity Framework para interagir com
                                                                                                   //um banco de dados. O DbContext gerencia as consultas e transações com o banco de dados, permitindo que a
                                                                                                   //aplicação interaja com dados persistentes(armazenados). A ctx é uma variável local do tipo
                                                                                                   //ItsCorsiEsamiContext. Este objeto será usado dentro do bloco using para interagir com o banco de dados,
                                                                                                   //como realizar consultas, atualizações, inserções ou exclusões. Já o new ItsCorsiEsamiContext(txtConnectionString.Text)
                                                                                                   //está sendo usado para instanciar um novo objeto da classe ItsCorsiEsamiContext, passando um parâmetro para
                                                                                                   //o construtor.txtConnectionString. Finalmente a propriedade Text de um controle (provavelmente um TextBox
                                                                                                   //na interface gráfica) chamado txtConnectionString. Esta string de conexão contém as informações necessárias
                                                                                                   //para se conectar ao banco de dados, como o endereço do servidor e nome do banco de dados. O construtor
                                                                                                   //ItsCorsiEsamiContext espera uma string de conexão, que é passada como argumento. Esse construtor é definido
                                                                                                   //na classe que herda de DbContext para inicializar a conexão com o banco de dados.
                {
                    if (ctx.Database.Exists())                                                     //Esta linha verifica se o banco de dados associado ao contexto (ctx) realmente existe.
                                                                                                   //A ctx é uma instância de ItsCorsiEsamiContext, que herda de DbContext, parte do Entity
                                                                                                   //Framework. O parâmetro .Exists() retorna true se o banco de dados está acessível e
                                                                                                   //existe fisicamente.
                    {
                        MessageBox.Show("Connection OK");                                          //Caso o banco exista, ele exibe uma mensagem "Connection OK" através de MessageBox.Show().

                        int countStudenti = ctx.Studenti.Count();                                  //Seria o mesmo que escrever em SQL SELECT Count(*) FROM AnagraficheStudenti
                        lblCountStudenti.Text = countStudenti.ToString();                          //A ctx é uma instância do ItsCorsiEsamiContext, que herda de DbContext, sendo assim responsável
                                                                                                   //por manter a conexão com o banco de dados. A ctx.Studenti acessa o DbSet<StudenteEntity>, ou seja,
                                                                                                   //a coleção de registros da tabela AnagraficheStudenti, os dados dos estudantes.
                                                                                                   //O lblCountStudenti é um controle de interface do tipo Label (componente de exibição no formulário).
                                                                                                   //O countStudenti.ToString() converte o número inteiro (quantidade de estudantes) em uma string para
                                                                                                   //ser exibida no controle lblCountStudenti. O ToString() é necessário porque lblCountStudenti.Text
                                                                                                   //aceita apenas strings, e countStudenti é do tipo int.

                        int countCorsi = ctx.Corsi.Count();                                        //Seria o mesmo que escrever em SQL SELECT Count(*) FROM AnagraficheCorsi
                        lblCountCorsi.Text = countCorsi.ToString();                                //A ctx é uma instância do ItsCorsiEsamiContext, que herda de DbContext, sendo assim responsável
                                                                                                   //por manter a conexão com o banco de dados. A ctx.Corsi acessa o DbSet<CorsoEntity>, ou seja,
                                                                                                   //a coleção de registros da tabela AnagraficheCorsi, os dados dos cursos.
                                                                                                   //O lblCountCorsi é um controle de interface do tipo Label (componente de exibição no formulário).
                                                                                                   //O countCorsi.ToString() converte o número inteiro (quantidade de estudantes) em uma string para
                                                                                                   //ser exibida no controle lblCountCorsi. O ToString() é necessário porque lblCountCorsi.Text
                                                                                                   //aceita apenas strings, e countCorsi é do tipo int.
                    }
                    else MessageBox.Show("This database does not exist!");                         //Caso o banco de dados não exista(ou não seja acessível), o bloco else é executado e
                                                                                                   //uma caixa de mensagem é exibida informando que o banco de dados não existe.
                }
            }
            catch (Exception ex)                                                                   //O catch (Exception) é o bloco que captura exceções geradas dentro do try e se ocorrer
                                                                                                   //um erro durante a tentativa de abrir a conexão ele será capturado aqui. Este Exception
                                                                                                   //é o tipo mais genérico de exceção em C#. Isso captura qualquer tipo de erro que ocorra
                                                                                                   //no bloco try. O ex é o nome da variável que vai armazenar a exceção capturada. Através
                                                                                                   //dela, é possível acessar informações sobre o erro, como a mensagem de erro e o tipo de
                                                                                                   //exceção.
            {
                MessageBox.Show($"Connection error: {ex.Message}");                                //o MessageBox.Show abre uma caixa de diálogo que exibe uma mensagem para o usuário.
                                                                                                   //Existe um Texto fixo que informa que ocorreu uma exceção. O código ex.Message é a
                                                                                                   //mensagem da exceção ex que contém uma descrição do erro que ocorreu. Cada tipo de
                                                                                                   //exceção pode teruma mensagem diferente, explicando o que deu errado.
            }
            finally                                                                                //Este bloco será executado independentemente de uma exceção ter ocorrido ou não.
            {
                btnCheckConnection.Enabled = true;                                                 //O btnCheckconnection.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como true, o botão fica habilitado e clicável. Reativa o botão,
                                                                                                   //permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                   //falha na tentativa de execução do que foi pedido.
            }

        }

        private void btnCercaStudenti_Click(object sender, EventArgs e)                            //O private void btnCercaStudenti_Click é o método que é acionado quando o botão btnCercaStudenti
                                                                                                   //é clicado. O object sender se refere ao controle que disparou o evento (neste caso, o
                                                                                                   //botão). Já o EventArgs e contém os dados do evento. Como é um clique de botão, não é
                                                                                                   //usado neste caso.
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection String is Empty!");
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

            btnCercaStudenti.Enabled = false;                                                      //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como false, o botão fica desabilitado, cinza e não clicável.
                                                                                                   //Ele desativa o botão para evitar múltiplos cliques durante o processamento do que foi
                                                                                                   //solicitado.

            try                                                                                    //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se
                                                                                                   //ocorrer uma exceção, o controle será passado para o bloco catch.
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                                                                                                   //O using é uma declaração que é usada em C# para garantir que os recursos não gerenciados, como conexões de
                                                                                                   //banco de dados, arquivos ou streams, sejam liberados corretamente quando o bloco de código é concluído. No
                                                                                                   //caso de classes que implementam a interface IDisposable(como a classe de contexto do Entity Framework), o
                                                                                                   //using chama o método Dispose() automaticamente quando o bloco de código é finalizado, garantindo que a
                                                                                                   //conexão com o banco de dados seja fechada corretamente e que a memória seja liberada. A ItsCorsiEsamiContext
                                                                                                   //é uma classe que provavelmente deriva de DbContext, a classe base do Entity Framework para interagir com
                                                                                                   //um banco de dados. O DbContext gerencia as consultas e transações com o banco de dados, permitindo que a
                                                                                                   //aplicação interaja com dados persistentes(armazenados). A ctx é uma variável local do tipo
                                                                                                   //ItsCorsiEsamiContext. Este objeto será usado dentro do bloco using para interagir com o banco de dados,
                                                                                                   //como realizar consultas, atualizações, inserções ou exclusões. Já o new ItsCorsiEsamiContext(txtConnectionString.Text)
                                                                                                   //está sendo usado para instanciar um novo objeto da classe ItsCorsiEsamiContext, passando um parâmetro para
                                                                                                   //o construtor.txtConnectionString. Finalmente a propriedade Text de um controle (provavelmente um TextBox
                                                                                                   //na interface gráfica) chamado txtConnectionString. Esta string de conexão contém as informações necessárias
                                                                                                   //para se conectar ao banco de dados, como o endereço do servidor e nome do banco de dados. O construtor
                                                                                                   //ItsCorsiEsamiContext espera uma string de conexão, que é passada como argumento. Esse construtor é definido
                                                                                                   //na classe que herda de DbContext para inicializar a conexão com o banco de dados.
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

                    dgvStudentiList.AutoGenerateColumns = true;                                       //AutoGenerateColumns é uma propriedade do DataGridView que controla como as colunas da grade de dados são
                                                                                                   //geradas quando você vincula uma fonte de dados. Quando AutoGenerateColumns está definido como true, as
                                                                                                   //colunas do DataGridView são geradas automaticamente com base nas propriedades dos objetos na fonte de dados.

                    dgvStudentiList.DataSource = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                                                                                                   //O dgvStudentiList se refere a um controle DataGridView presente em um formulário do
                                                                                                   //Windows Forms, utilizado para exibir dados tabulares. Neste caso, o DataGridView é
                                                                                                   //configurado para mostrar uma lista de estudantes, já que a variável está nomeada
                                                                                                   //como StudentiList. O DataSource é a propriedade que define a fonte de dados para
                                                                                                   //o controle DataGridView. Atribuindo uma lista de dados a essa propriedade, o
                                                                                                   //controle exibirá os dados em forma de tabela, automaticamente preenchendo as colunas
                                                                                                   //com as propriedades do objeto atribuído.
                                                                                                   //O studentiList.Select(r => StudenteMapper.Map(r))studentiList refere - se a uma lista
                                                                                                   //de objetos do tipo StudenteEntity, provavelmente recuperada de um banco de dados.Essa
                                                                                                   //lista contém os dados dos estudantes que serão exibidos no DataGridView.
                                                                                                   //No .Select(r => StudenteMapper.Map(r)) o método .Select é utilizado para projetar(ou
                                                                                                   //mapear) os objetos da lista studentiList de um tipo para outro. No caso, está mapeando
                                                                                                   //objetos de StudenteEntity para StudenteDto, por meio do StudenteMapper.Map(r), onde r
                                                                                                   //representa cada estudante da lista original, o .StudenteMapper.Map(r) está sendo
                                                                                                   //chamado para converter(ou "mapear") cada objeto StudenteEntity para um objeto
                                                                                                   //StudenteDto. O mapeamento é necessário, geralmente, para formatar ou simplificar os
                                                                                                   //dados antes de exibi-los ou para evitar expor diretamente entidades do banco de dados
                                                                                                   //no front-end.
                }
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
                btnCercaStudenti.Enabled = true;                                                   //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como true, o botão fica habilitado e clicável. Reativa o botão,
                                                                                                   //permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                   //falha na tentativa de execução do que foi pedido.
            }
        }
        private void btnCercaCorsi_Click(object sender, EventArgs e)                               //O private void btnCercaCorsi_Click é o método que é acionado quando o botão btnCercaCorsi
                                                                                                   //é clicado. O object sender se refere ao controle que disparou o evento (neste caso, o
                                                                                                   //botão). Já o EventArgs e contém os dados do evento. Como é um clique de botão, não é
                                                                                                   //usado neste caso.
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text)) throw new Exception("Connection String is Empty!");
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

            btnCercaStudenti.Enabled = false;                                                      //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como false, o botão fica desabilitado, cinza e não clicável.
                                                                                                   //Ele desativa o botão para evitar múltiplos cliques durante o processamento do que foi
                                                                                                   //solicitado.

            try                                                                                    //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se
                                                                                                   //ocorrer uma exceção, o controle será passado para o bloco catch.
            {
                using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(txtConnectionString.Text))
                                                                                                   //O using é uma declaração que é usada em C# para garantir que os recursos não gerenciados, como conexões de
                                                                                                   //banco de dados, arquivos ou streams, sejam liberados corretamente quando o bloco de código é concluído. No
                                                                                                   //caso de classes que implementam a interface IDisposable(como a classe de contexto do Entity Framework), o
                                                                                                   //using chama o método Dispose() automaticamente quando o bloco de código é finalizado, garantindo que a
                                                                                                   //conexão com o banco de dados seja fechada corretamente e que a memória seja liberada. A ItsCorsiEsamiContext
                                                                                                   //é uma classe que provavelmente deriva de DbContext, a classe base do Entity Framework para interagir com
                                                                                                   //um banco de dados. O DbContext gerencia as consultas e transações com o banco de dados, permitindo que a
                                                                                                   //aplicação interaja com dados persistentes(armazenados). A ctx é uma variável local do tipo
                                                                                                   //ItsCorsiEsamiContext. Este objeto será usado dentro do bloco using para interagir com o banco de dados,
                                                                                                   //como realizar consultas, atualizações, inserções ou exclusões. Já o new ItsCorsiEsamiContext(txtConnectionString.Text)
                                                                                                   //está sendo usado para instanciar um novo objeto da classe ItsCorsiEsamiContext, passando um parâmetro para
                                                                                                   //o construtor.txtConnectionString. Finalmente a propriedade Text de um controle (provavelmente um TextBox
                                                                                                   //na interface gráfica) chamado txtConnectionString. Esta string de conexão contém as informações necessárias
                                                                                                   //para se conectar ao banco de dados, como o endereço do servidor e nome do banco de dados. O construtor
                                                                                                   //ItsCorsiEsamiContext espera uma string de conexão, que é passada como argumento. Esse construtor é definido
                                                                                                   //na classe que herda de DbContext para inicializar a conexão com o banco de dados.
                {
                    dgvCorsiList.AutoGenerateColumns = true;                                       //AutoGenerateColumns é uma propriedade do DataGridView que controla como as colunas da grade de dados são
                                                                                                   //geradas quando você vincula uma fonte de dados. Quando AutoGenerateColumns está definido como true, as
                                                                                                   //colunas do DataGridView são geradas automaticamente com base nas propriedades dos objetos na fonte de dados.

                    dgvCorsiList.DataSource = ctx.Corsi.ToList().Select(r => CorsoMapper.Map(r)).ToList();
                                                                                                   //O dgvCorsiList é um controle do tipo DataGridView usado para exibir dados em formato tabular. O sufixo "Corsi"
                                                                                                   //sugere que esta tabela exibirá uma lista de cursos(provavelmente instâncias de CorsoEntity). O ctx.Corsictx.Corsi
                                                                                                   //refere-se à coleção de entidades CorsoEntity armazenadas no banco de dados, que está sendo acessada através do
                                                                                                   //contexto do Entity Framework(ItsCorsiEsamiContext). Corsi é uma propriedade de DbSet<CorsoEntity> no contexto
                                                                                                   //(ctx), representando a tabela Corsi no banco de dados. Isso permite que você execute consultas diretamente na
                                                                                                   //tabela de cursos. O .ToList() converte os resultados da consulta ctx.Corsi em uma lista de objetos CorsoEntity.
                                                                                                   //Isso significa que os cursos são carregados na memória como uma lista concreta para serem manipulados
                                                                                                   //posteriormente. O .Select(r => CorsoMapper.Map(r)) é uma função LINQ usada para projetar(ou mapear) os
                                                                                                   //elementos de uma coleção de um tipo para outro. Aqui, cada curso na lista de CorsoEntity(representado por r)
                                                                                                   //é transformado em um CorsoDto utilizando o método CorsoMapper.Map(r) que  realiza o mapeamento de um objeto
                                                                                                   //CorsoEntity para um objeto CorsoDto. Ele transforma a entidade do banco de dados em um objeto DTO(Data
                                                                                                   //Transfer Object) que contém apenas os dados necessários para serem exibidos na interface.
                }
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
                btnCercaStudenti.Enabled = true;                                                   //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como true, o botão fica habilitado e clicável. Reativa o botão,
                                                                                                   //permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                   //falha na tentativa de execução do que foi pedido.
            }
        }
    }
}
