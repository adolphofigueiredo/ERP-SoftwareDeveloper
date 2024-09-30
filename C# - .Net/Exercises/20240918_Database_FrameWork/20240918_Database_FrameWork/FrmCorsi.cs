using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;
using _20240918_Database_FrameWork.Models.Mappers;
using _20240918_Database_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using _20240918_Database_FrameWork.Repositories;
using _20240918_Database_FrameWork.Models.Filters;

namespace _20240918_Database_FrameWork
{
    public partial class FrmCorsi : Form                                                           //A classe FrmCorsi herda da classe Form, o que significa que ela é um formulário
                                                                                                   //de uma aplicação Windows Forms. A palavra-chave partial indica que a definição
                                                                                                   //dessa classe pode estar espalhada por vários arquivos, o que é típico quando
                                                                                                   //usamos o Windows Forms Designer, que gera automaticamente parte do código.
    {
        public FrmCorsi()                                                                          //Construtor do tipo publico que chama o método InitializeComponent()
        {
            InitializeComponent();                                                                 //O construtor FrmStudenti() chama o método InitializeComponent(), que é responsável
                                                                                                   //por inicializar e configurar os controles visuais do formulário (gerado
                                                                                                   //automaticamente pelo designer do Windows Forms).
        }
        private void btnCercaCorso_Click(object sender, EventArgs e)                               //O private void btnCercaCorso_Click é o método que é acionado quando o botão btnCercaCorsi
                                                                                                   //é clicado. O object sender se refere ao controle que disparou o evento (neste caso, o
                                                                                                   //botão). Já o EventArgs e contém os dados do evento. Como é um clique de botão, não é
                                                                                                   //usado neste caso.
        {
            btnCercaCorso.Enabled = false;                                                         //O btnCercaCorso.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como false, o botão fica desabilitado, cinza e não clicável.
                                                                                                   //Ele desativa o botão para evitar múltiplos cliques durante o processamento do que foi
                                                                                                   //solicitado.

            try                                                                                    //O try é um bloco de código onde serão feitas tentativas que podem gerar exceções e se
                                                                                                   //ocorrer uma exceção, o controle será passado para o bloco catch.
            {
                CorsoRepository repository = new CorsoRepository();
                var filtro = new CorsoFilter
                {


                    NominativoCorso = txtNominativoCorsoFilter.Text,
                    InizioCorsoDa = null,
                    InizioCorsoA = null,
                    FineCorsoDa = null,
                    FineCorsoA = null
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
                                                        {
                                                            IQueryable<CorsoEntity> query = ctx.Corsi;                                 //Esta sendo criada uma consulta que irá acessar a coleção de cursos (Corsi) na
                                                                                                                                       //base de dados. O IQueryable é um tipo de interface que permite a consulta de coleções
                                                                                                                                       //de dados, como um conjunto de resultados de um banco de dados, usando a linguagem de
                                                                                                                                       //consulta LINQ (Language Integrated Query). O tipo genérico<CorsoEntity> especifica
                                                                                                                                       //que essa consulta está lidando com uma coleção de objetos do tipo CorsoEntity. Isso
                                                                                                                                       //significa que o resultado da consulta será uma coleção de cursos, onde cada
                                                                                                                                       //curso é representado por uma instância da classe CorsoEntity. A variável query
                                                                                                                                       //é inicializada com o resultado da expressão à direita. Essa variável armazenará a
                                                                                                                                       //consulta que será utilizada para buscar dados na tabela Corsi da base de dados.
                                                                                                                                       //A ctx é uma instância do contexto de dados(ItsCorsiEsamiContext), que é usado para
                                                                                                                                       //interagir com a base de dados. Corsi é uma propriedade do contexto que representa
                                                                                                                                       //a tabela de cursos no banco de dados. Essa propriedade retorna um
                                                                                                                                       //DbSet<CorsoEntity>, que é uma coleção de objetos que correspondem à tabela de
                                                                                                                                       //cursos. Resumindo a linha de código define uma consulta(query) que será usada
                                                                                                                                       //para acessar a tabela de cursos no banco de dados. A consulta em si não é
                                                                                                                                       //executada neste momento; em vez disso, ela é uma representação da consulta que será
                                                                                                                                       //realizada quando o método ToList()(ou um método similar) for chamado. 

                                                            if (!string.IsNullOrEmpty(txtNominativoCorsoFilter.Text))                  //Esta linha verifica se o campo de texto para filtrar o nome do curso está ou
                                                                                                                                       //(txtNominativoFilter) não está vazio. Se não estiver, a consulta será filtrada.

                                                                query = query.Where(r => r.Nome.Contains(txtNominativoCorsoFilter.Text));
                                                                                                                                       //A query é uma variável do tipo IQueryable<CorsoEntity>, representando uma
                                                                                                                                       //consulta que pode ser executada contra a base de dados. Ela contém a definição
                                                                                                                                       //da consulta até aquele ponto. Where é um método de extensão do LINQ(Language
                                                                                                                                       //Integrated Query) que filtra uma sequência de elementos com base em uma condição
                                                                                                                                       //especificada. O método Where não executa a consulta imediatamente, mas modifica
                                                                                                                                       //a definição da consulta, adicionando uma condição de filtragem. A execução real
                                                                                                                                       //acontece quando a consulta é materializada (por exemplo, com ToList()).
                                                                                                                                       //A parte r => define uma expressão lambda que representa uma função que aceita
                                                                                                                                       //um parâmetro (neste caso, um objeto CorsoEntity, representado por r) e retorna
                                                                                                                                       //um valor booleano.r.Nome.Contains(txtNominativoFilter.Text), o r.Nome acessa a
                                                                                                                                       //propriedade Nome do objeto CorsoEntity atual, representado por r. Contains(...),
                                                                                                                                       //o método Contains verifica se a string Nome contém a substring especificada em
                                                                                                                                       //txtNominativoFilter.Text. Assim Essa expressão retornará true se o nome do
                                                                                                                                       //estudante contiver a string digitada pelo usuário no filtro.*/
               
                if (dtpInizioCorsoDaFilter.Checked) filtro.InizioCorsoDa = dtpInizioCorsoDaFilter.Value;

                if (dtpInizioCorsoAFilter.Checked) filtro.InizioCorsoA = dtpInizioCorsoAFilter.Value;
                
                if (dtpFineCorsoDaFilter.Checked) filtro.FineCorsoDa = dtpFineCorsoDaFilter.Value;
                
                if (dtpFineCorsoAFilter.Checked) filtro.FineCorsoA = dtpFineCorsoAFilter.Value;

                /*                                            if (dtpInizioCorsoFilter.Checked && dtpFineCorsoFilter.Checked)          //Verifica se o filtro de data de início (dtpInizioCorsoFilter) está ativo.
                                                                                                                                       //Se sim, aplicaremos mais um filtro.
                                                              query = query.Where(db => dtpFineCorsoFilter.Value >= db.DataValiditaInizio &&
                                                              dtpInizioCorsoFilter.Value <= db.DataValiditaFine);
                                                                }
                                                              else if(dtpInizioCorsoFilter.Checked)
                                                              query = query.Where(db => db.DataValiditaInizio >= dtpInizioCorsoFilter.Value);

                                                              else if (dtpFineCorsoFilter.Checked)
                                                              query = query.Where(db => db.DataValiditaFine >= dtpFineCorsoFilter.Value);
                                                                                                                                                       //A query é uma variável do tipo IQueryable<CorsoEntity>. Esse tipo permite que você
                                                                                                                                                       //construa consultas que serão convertidas em comandos SQL e executadas no banco de dados
                                                                                                                                                       //quando a consulta for materializada (por exemplo, com um.ToList()). O Where é um método
                                                                                                                                                       //de extensão LINQ que aplica um filtro à consulta.Ele cria uma nova consulta query com
                                                                                                                                                       //base no filtro fornecido. Neste caso, o filtro seleciona apenas os registros que
                                                                                                                                                       //atendem à condição especificada dentro do método Where. Já o
                                                                                                                                                       //dv => dv.DataValiditaInizio >= dtpInizioCorsoFilter.Value define uma função que será aplicada a
                                                                                                                                                       //cada elemento da coleção query. O parâmetro r representa cada instância de
                                                                                                                                                       //CorsoEntity da consulta. O parâmetro r.DataValiditaInizio se refere à propriedade
                                                                                                                                                       //DataValiditaInizio do objeto CorsoEntity e value é a propriedade que retorna a data
                                                                                                                                                       //selecionada pelo usuário.

                                                                            List<CorsoEntity> corsoList = query.ToList();                              //A parte List<CorsoEntity> do código declara uma variável chamada corsoList do
                                                                                                                                                       //tipo List<CorsoEntity>, que é uma lista genérica em C# que armazena objetos da
                                                                                                                                                       //classe CorsoEntity. Uma lista é utilizada para armazenar múltiplos itens,
                                                                                                                                                       //permitindo operações como adição, remoção, e iteração. A query é uma variável do
                                                                                                                                                       //tipo IQueryable<CorsoEntity>, que representa uma consulta a uma fonte de dados,
                                                                                                                                                       //neste caso, provavelmente a tabela de estudantes no banco de dados. A IQueryable
                                                                                                                                                       //permite a execução de consultas em uma base de dados de forma otimizada, permitindo
                                                                                                                                                       //a construção de consultas que serão traduzidas em SQL quando executadas. O método
                                                                                                                                                       //.ToList() é chamado na query. Este método executa a consulta e materializa os
                                                                                                                                                       //resultados em uma lista. Quando ToList() é chamado, ele envia a consulta para o
                                                                                                                                                       //banco de dados e recupera todos os resultados que correspondem à consulta,
                                                                                                                                                       //armazenando-os em corsoList como uma lista de CorsoEntity.
                                                    */
                ICollection<CorsoEntity> corsiList = repository.Find(filtro);
                List <CorsoDto> corsiDto = corsiList.Select(c => CorsoMapper.Map(c)).ToList();
                                                                                                   //Aqui, é declarada uma nova lista chamada corsiDto, do tipo List<CorsoDto>.
                                                                                                   //Essa lista vai armazenar objetos do tipo CorsoDto, que é um Data Transfer Object.
                                                                                                   //O CorsoDto é usado para transportar dados entre a camada de acesso a dados e a
                                                                                                   //camada de apresentação, geralmente contendo apenas as informações necessárias para
                                                                                                   //exibir na interface do usuário. O corsoList.Select(r => CorsoMapper.Map(r)) é
                                                                                                   //um método onde o Select é uma operação de LINQ que projeta cada elemento da lista
                                                                                                   //corsoList em um novo formato, o r => CorsoMapper.Map(r) é a parte da expressão
                                                                                                   //que recebe cada CorsoEntity da corsoList(representado por r) e chama o método
                                                                                                   //Map da classe CorsoMapper. O método Map converte um objeto CorsoEntity em um
                                                                                                   //objeto CorsoDto, extraindo as propriedades necessárias e ignorando quaisquer que
                                                                                                   //não são necessárias para a visualização. O ToList() materializa, quando é chamado
                                                                                                   //novamente executa a projeção da consulta e cria uma lista de CorsoDto a partir
                                                                                                   //dos resultados do Select.

                        dgvRisultatiCorso.AutoGenerateColumns = true;                              //O DataGridView automaticamente cria colunas e popula as linhas com os dados
                                                                                                   //fornecidos na coleção. Isso torna o processo de exibição de dados muito eficiente e
                                                                                                   //reduz a quantidade de código necessário para configurar o controle. O studentiDto é
                                                                                                   //uma lista ou coleção de objetos do tipo StudenteDto. O StudenteDto é um Data Transfer
                                                                                                   //Object(DTO) que representa os dados do estudante de forma simplificada e otimizada
                                                                                                   //para a transferência, frequentemente utilizado para evitar o acoplamento direto com
                                                                                                   //a camada de entidade(StudenteEntity). Esta coleção contém dados que foram filtrados
                                                                                                   //e mapeados a partir da consulta ao banco de dados, conforme a lógica definida
                                                                                                   //anteriormente.

                        dgvRisultatiCorso.DataSource = corsiDto;                                   //A DataSource é uma propriedade do DataGridView que define a origem dos dados que o
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
                btnCercaCorso.Enabled = true;                                                      //O btnCercaCorso.Enabled e a propriedade Enabled controlam se o botão está ativo ou
                                                                                                   //desativado. Quando está como true, o botão fica habilitado e clicável. Reativa o botão,
                                                                                                   //permitindo que ele seja clicado novamente. Isso ocorre independentemente do sucesso ou
                                                                                                   //falha na tentativa de execução do que foi pedido.
            }
        }
    }
}
