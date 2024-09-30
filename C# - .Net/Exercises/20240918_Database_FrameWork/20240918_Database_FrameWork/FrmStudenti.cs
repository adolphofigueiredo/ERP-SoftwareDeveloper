using _20240918_Database_FrameWork.Models;
using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Filters;
using _20240918_Database_FrameWork.Models.Mappers;
using _20240918_Database_FrameWork.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmStudenti : Form                                                        //A classe FrmStudenti herda da classe Form, o que significa que ela é um formulário
                                                                                                   //de uma aplicação Windows Forms. A palavra-chave partial indica que a definição
                                                                                                   //dessa classe pode estar espalhada por vários arquivos, o que é típico quando
                                                                                                   //usamos o Windows Forms Designer, que gera automaticamente parte do código.
    {
        public FrmStudenti()                                                                       //Construtor do tipo publico que chama o método InitializeComponent()
        {
            InitializeComponent();                                                                 //O construtor FrmStudenti() chama o método InitializeComponent(), que é responsável
                                                                                                   //por inicializar e configurar os controles visuais do formulário (gerado
                                                                                                   //automaticamente pelo designer do Windows Forms).
        }
        private void btnCerca_Click(object sender, EventArgs e)                                    //O private void btnCerca_Click é o método que é acionado quando o botão btnCercaStudenti
                                                                                                   //é clicado. O object sender se refere ao controle que disparou o evento (neste caso, o
                                                                                                   //botão). Já o EventArgs e contém os dados do evento. Como é um clique de botão, não é
                                                                                                   //usado neste caso.
        {
            btnCercaStudenti.Enabled = false;                                                      //O btnCercaStudenti.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como false, o botão fica desabilitado, cinza e não clicável.
                                                                                                   //Ele desativa o botão para evitar múltiplos cliques durante o processamento do que foi
                                                                                                   //solicitado.

            try                                                                                    //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se
                                                                                                   //ocorrer uma exceção, o controle será passado para o bloco catch.
            {   
                StudenteRepository repository = new StudenteRepository();                          //O StudenteRepository é uma classe que implementa o padrão de repositório (Repository
                                                                                                   //Pattern). Padrão usado para mediar a comunicação entre a aplicação e o banco de dados.
                                                                                                   //O repositório encapsula as operações de acesso a dados relacionadas aos estudantes,
                                                                                                   //como buscas, inserções, atualizações e exclusões de registros. Neste caso, o
                                                                                                   //StudenteRepository será usado para interagir com os dados dos estudantes através do Entity Framework.

                var filtro = new StudenteFilter                                                    //Aqui estou criando uma instancia com o nome filtro e que terá os propriedades da classe
                                                                                                   //Studentefilter
                {
                    Nominativo = txtNominativoFilter.Text,                                         //No momento que esta instância é criada será atribuido o valor da caixa de texto aa variável
                                                                                                   //nominativo
                    Inizio = null,                                                                 //A propriedade Inizio terá o valor null atribuído.
                    Fine = null                                                                    //A propriedade Fine terá o valor null atribuído.
                };
                /*              using (ItsCorsiEsamiContext ctx = new ItsCorsiEsamiContext(Configurazioni.GetConnectionString()))
                                {                                                                                  //O using, declara um bloco de código que será utilizado e ao final do bloco, o objeto
                                                                                                                   //será automaticamente descartado (chama o método Dispose), liberando recursos de forma
                                                                                                                   //eficiente. Esta instrução garante que o objeto ctx (instância de ItsCorsiEsamiContext)
                                                                                                                   //será descartado automaticamente quando não for mais necessário, liberando recursos.
                                                                                                                   //O ItsCorsiEsamiContext é o contexto do Entity Framework que representa a conexão com
                                                                                                                   //a base de dados. É utilizado para acessar as entidades no banco. Já o
                                                                                                                   //Configurazioni.GetConnectionString() obtém a string de conexão necessária para se
                                                                                                                   //conectar ao banco de dados a partir da classe de configuração.

                                    IQueryable<StudenteEntity> query = ctx.Studenti;                               //Esta sendo criada uma consulta que irá acessar a coleção de estudantes (Studenti) na
                                                                                                                   //base de dados. O IQueryable é um tipo de interface que permite a consulta de coleções
                                                                                                                   //de dados, como um conjunto de resultados de um banco de dados, usando a linguagem de
                                                                                                                   //consulta LINQ (Language Integrated Query). O tipo genérico<StudenteEntity> especifica
                                                                                                                   //que essa consulta está lidando com uma coleção de objetos do tipo StudenteEntity. Isso
                                                                                                                   //significa que o resultado da consulta será uma coleção de estudantes, onde cada
                                                                                                                   //estudante é representado por uma instância da classe StudenteEntity. A variável query
                                                                                                                   //é inicializada com o resultado da expressão à direita. Essa variável armazenará a
                                                                                                                   //consulta que será utilizada para buscar dados na tabela Studenti da base de dados.
                                                                                                                   //A ctx é uma instância do contexto de dados(ItsCorsiEsamiContext), que é usado para
                                                                                                                   //interagir com a base de dados. Studenti é uma propriedade do contexto que representa
                                                                                                                   //a tabela de estudantes no banco de dados. Essa propriedade retorna um
                                                                                                                   //DbSet<StudenteEntity>, que é uma coleção de objetos que correspondem à tabela de
                                                                                                                   //estudantes. Resumindo a linha de código define uma consulta(query) que será usada
                                                                                                                   //para acessar a tabela de estudantes no banco de dados. A consulta em si não é
                                                                                                                   //executada neste momento; em vez disso, ela é uma representação da consulta que será
                                                                                                                   //realizada quando o método ToList()(ou um método similar) for chamado. 

                                    if (!string.IsNullOrEmpty(txtNominativoFilter.Text))                           //Esta linha verifica se o campo de texto para filtrar o nome ou sobrenome está ou
                                                                                                                   //(txtNominativoFilter) não está vazio. Se não estiver, a consulta será filtrada.
                                            query = query.Where(r => r.Nome.Contains(txtNominativoFilter.Text)     //A query é uma variável do tipo IQueryable<StudenteEntity>, representando uma
                                                                                                                   //consulta que pode ser executada contra a base de dados. Ela contém a definição
                                                                                                                   //da consulta até aquele ponto. Where é um método de extensão do LINQ(Language
                                                                                                                   //Integrated Query) que filtra uma sequência de elementos com base em uma condição
                                                                                                                   //especificada. O método Where não executa a consulta imediatamente, mas modifica
                                                                                                                   //a definição da consulta, adicionando uma condição de filtragem. A execução real
                                                                                                                   //acontece quando a consulta é materializada (por exemplo, com ToList()).
                                                                                                                   //A parte r => define uma expressão lambda que representa uma função que aceita
                                                                                                                   //um parâmetro (neste caso, um objeto StudenteEntity, representado por r) e retorna
                                                                                                                   //um valor booleano.r.Nome.Contains(txtNominativoFilter.Text), o r.Nome acessa a
                                                                                                                   //propriedade Nome do objeto StudenteEntity atual, representado por r. Contains(...),
                                                                                                                   //o método Contains verifica se a string Nome contém a substring especificada em
                                                                                                                   //txtNominativoFilter.Text. Assim Essa expressão retornará true se o nome do
                                                                                                                   //estudante contiver a string digitada pelo usuário no filtro.
                                        || r.Cognome.Contains(txtNominativoFilter.Text));*/

                if (dtpNatoDaFilter.Checked) filtro.Inizio = dtpNatoDaFilter.Value;

                /*                  if (dtpNatoDaFilter.Checked)                                                   //Verifica se o filtro de data de nascimento "a partir de" (dtpNatoDaFilter) está ativo.
                                                                                                                   //Se sim, aplicaremos mais um filtro.
                                        query = query.Where(r => r.DataDiNascita >= dtpNatoDaFilter.Value);        //A query é uma variável do tipo IQueryable<StudenteEntity>. Esse tipo permite que você
                                                                                                                   //construa consultas que serão convertidas em comandos SQL e executadas no banco de dados
                                                                                                                   //quando a consulta for materializada (por exemplo, com um.ToList()). O Where é um método
                                                                                                                   //de extensão LINQ que aplica um filtro à consulta.Ele cria uma nova consulta query com
                                                                                                                   //base no filtro fornecido. Neste caso, o filtro seleciona apenas os registros que
                                                                                                                   //atendem à condição especificada dentro do método Where. Já o
                                                                                                                   //r => r.DataDiNascita >= dtpNatoDaFilter.Value define uma função que será aplicada a
                                                                                                                   //cada elemento da coleção query. O parâmetro r representa cada instância de
                                                                                                                   //StudenteEntity da consulta. O parâmetro r.DataDiNascita se refere à propriedade
                                                                                                                   //DataDiNascita do objeto StudenteEntity e value é a propriedade que retorna a data
                                                                                                                   //selecionada pelo usuário.*/

                if (dtpNatoAFilter.Checked) filtro.Fine = dtpNatoAFilter.Value;

                /*                                  if (dtpNatoAFilter.Checked)                                                    //Verifica se o filtro de data de nascimento "até" (dtpNatoAFilter) está ativo. Se sim,
                                                                                                                                   //aplicaremos mais um filtro.

                                                        query = query.Where(r => r.DataDiNascita <= dtpNatoAFilter.Value);         //A query é uma variável do tipo IQueryable<StudenteEntity>. Esse tipo permite que você
                                                                                                                                   //construa consultas que serão convertidas em comandos SQL e executadas no banco de dados
                                                                                                                                   //quando a consulta for materializada (por exemplo, com um.ToList()). O Where é um método
                                                                                                                                   //de extensão LINQ que aplica um filtro à consulta.Ele cria uma nova consulta query com
                                                                                                                                   //base no filtro fornecido. Neste caso, o filtro seleciona apenas os registros que
                                                                                                                                   //atendem à condição especificada dentro do método Where. Já o
                                                                                                                                   //r => r.DataDiNascita <= dtpNatoAFilter.Value define uma função que será aplicada a
                                                                                                                                   //cada elemento da coleção query. O parâmetro r representa cada instância de
                                                                                                                                   //StudenteEntity da consulta. O parâmetro r.DataDiNascita se refere à propriedade
                                                                                                                                   //DataDiNascita do objeto StudenteEntity e value é a propriedade que retorna a data
                                                                                                                                   //selecionada pelo usuário.

                                                    List<StudenteEntity> studentiList = query.ToList();                             //A parte List<StudenteEntity> do código declara uma variável chamada studentList do
                                                                                                                                   //tipo List<StudenteEntity>, que é uma lista genérica em C# que armazena objetos da
                                                                                                                                   //classe StudenteEntity. Uma lista é utilizada para armazenar múltiplos itens,
                                                                                                                                   //permitindo operações como adição, remoção, e iteração. A query é uma variável do
                                                                                                                                   //tipo IQueryable<StudenteEntity>, que representa uma consulta a uma fonte de dados,
                                                                                                                                   //neste caso, provavelmente a tabela de estudantes no banco de dados. A IQueryable
                                                                                                                                   //permite a execução de consultas em uma base de dados de forma otimizada, permitindo
                                                                                                                                   //a construção de consultas que serão traduzidas em SQL quando executadas. O método
                                                                                                                                   //.ToList() é chamado na query. Este método executa a consulta e materializa os
                                                                                                                                   //resultados em uma lista. Quando ToList() é chamado, ele envia a consulta para o
                                                                                                                                   //banco de dados e recupera todos os resultados que correspondem à consulta,
                                                                                                                                   //armazenando-os em studentList como uma lista de StudenteEntity.*/
                ICollection<StudenteEntity> studentiList = repository.Find(filtro);
                List<StudenteDto> studentiDto = studentiList.Select(r => StudenteMapper.Map(r)).ToList();
                                                                                                   //Aqui, é declarada uma nova lista chamada studentiDto, do tipo List<StudenteDto>.
                                                                                                   //Essa lista vai armazenar objetos do tipo StudenteDto, que é um Data Transfer Object.
                                                                                                   //O StudenteDto é usado para transportar dados entre a camada de acesso a dados e a
                                                                                                   //camada de apresentação, geralmente contendo apenas as informações necessárias para
                                                                                                   //exibir na interface do usuário. O studentList.Select(r => StudenteMapper.Map(r)) é
                                                                                                   //um método onde o Select é uma operação de LINQ que projeta cada elemento da lista
                                                                                                   //studentList em um novo formato, o r => StudenteMapper.Map(r) é a parte da expressão
                                                                                                   //que recebe cada StudenteEntity da studentList(representado por r) e chama o método
                                                                                                   //Map da classe StudenteMapper. O método Map converte um objeto StudenteEntity em um
                                                                                                   //objeto StudenteDto, extraindo as propriedades necessárias e ignorando quaisquer que
                                                                                                   //não são necessárias para a visualização. O ToList() materializa, quando é chamado
                                                                                                   //novamente executa a projeção da consulta e cria uma lista de StudenteDto a partir
                                                                                                   //dos resultados do Select.

                    dgvRisultati.AutoGenerateColumns = true;                                       //O DataGridView automaticamente cria colunas e popula as linhas com os dados
                                                                                                   //fornecidos na coleção. Isso torna o processo de exibição de dados muito eficiente e
                                                                                                   //reduz a quantidade de código necessário para configurar o controle. O studentiDto é
                                                                                                   //uma lista ou coleção de objetos do tipo StudenteDto. O StudenteDto é um Data Transfer
                                                                                                   //Object(DTO) que representa os dados do estudante de forma simplificada e otimizada
                                                                                                   //para a transferência, frequentemente utilizado para evitar o acoplamento direto com
                                                                                                   //a camada de entidade(StudenteEntity). Esta coleção contém dados que foram filtrados
                                                                                                   //e mapeados a partir da consulta ao banco de dados, conforme a lógica definida
                                                                                                   //anteriormente.

                    dgvRisultati.DataSource = studentiDto;                                         //A DataSource é uma propriedade do DataGridView que define a origem dos dados que o
                                                                                                   //controle deve exibir. Ao definir esta propriedade, você informa ao DataGridView de
                                                                                                   //onde ele deve obter as informações que devem ser exibidas.
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
