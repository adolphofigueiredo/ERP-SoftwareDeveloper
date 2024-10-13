using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Dtos;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Mappers;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Runtime.Intrinsics.X86;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.PageViewModels;
using System.Security.Policy;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Controllers
{                                                          //A declaração de namespace organiza o código e evita conflitos de
                                                           //nomes de classes. Aqui, o namespace agrupa todas as classes do
                                                           //módulo de "Controllers" do projeto, como StudentiController. A
                                                           //estrutura do nome do namespace segue um padrão hierárquico que
                                                           //reflete o nome do projeto e o módulo em questão.
	public class StudentiController : Controller           //O StudentiController é um controller que lida com as ações que
                                                           //o usuário pode executar em relação aos estudantes. Ele herda
                                                           //de Controller, que é a classe base para todos os controladores
                                                           //no ASP.NET Core MVC. Esta classe fornece vários métodos e
                                                           //funcionalidades que facilitam o processamento de requisições HTTP.
    {
		private readonly StudentiRepository _studentiRepository;
                                                           //O modificador private significa que a variável _studentiRepository
                                                           //é acessível apenas dentro da classe StudentiController. O modificador
                                                           //readonly indica que essa variável pode ser atribuída apenas uma vez,
                                                           //seja na sua declaração ou no construtor, e nunca pode ser alterada depois.
                                                           //O StudentiRepository _studentiRepository é um campo privado da classe
                                                           //StudentiController, do tipo StudentiRepository.Ele armazena uma
                                                           //referência ao repositório injetado e será usado para realizar operações
                                                           //relacionadas aos estudantes, como buscar dados do banco de dados.
		public StudentiController(StudentiRepository studentiRepository)
		{                                                  //Este é o construtor da classe StudentiController. Ele é chamado toda
                                                           //vez que uma nova instância do controlador é criada. O
                                                           //StudentiController(StudentiRepository studentiRepository) tem um parâmetro
                                                           //do tipo StudentiRepository. Isso significa que, para criar um StudentiController,
                                                           //uma instância de StudentiRepository precisa ser fornecida. Em aplicações
                                                           //ASP.NET Core, o repositório StudentiRepository provavelmente está sendo
                                                           //injetado pelo framework por meio do IoC container(Inversion of Control).
                                                           //A Injeção de Dependência(DI) é uma técnica onde uma classe depende de
                                                           //outra(no caso, o controlador depende do repositório), mas essa dependência
                                                           //é fornecida externamente em vez de ser criada diretamente dentro da classe.
                                                           //Isso facilita o desacoplamento e o teste unitário.

			_studentiRepository = studentiRepository;      //Este código atribui o repositório passado ao campo privado _studentiRepository.
                                                           //Com isso, o controlador pode usar _studentiRepository para interagir com
                                                           //a camada de dados.
		}
        public IActionResult Index([FromQuery] StudenteFilter filter)
														   //O método index geralmente corresponde à rota padrão de um controller
														   //(exemplo: /Studenti/Search). O método retorna uma View(), que indica
														   //ao framework para renderizar uma View associada ao método. No caso
														   //de Search, a View provavelmente se chamará Index.cshtml e será
														   //localizada na pasta Views/Studenti.
														   //O [FromQuery] indica que o parâmetro filter será preenchido com dados
                                                           //da query string da requisição HTTP. Ou seja, quando um usuário acessar
                                                           //a URL /Studenti/Search?param=value, os valores da query string serão
                                                           //automaticamente vinculados ao objeto filter. O parâmetro StudenteFilter
                                                           //filter é do tipo StudenteFilter, que é provavelmente uma classe que
                                                           //encapsula os critérios de filtragem para buscar estudantes. Ela pode
                                                           //conter propriedades como nome, idade, curso, ou outros atributos que
                                                           //os usuários podem usar para buscar ou filtrar estudantes.
		{
            var studentiTrovati = _studentiRepository.Find(filter);
			                                               //O var studentiTrovati está declaradando uma variável studentiTrovati
                                                           //que vai armazenar os resultados da busca por estudantes. O
                                                           //_studentiRepository.Find(filter) é um método Find do repositório
                                                           //_studentiRepository chamado, passando o filter como parâmetro.
                                                           //O repositório provavelmente acessa a base de dados e retorna uma lista
                                                           //de estudantes que correspondem aos critérios definidos no filter. O
                                                           //padrão repositório desacopla a lógica de persistência(banco de dados)
                                                           //da lógica de apresentação(controlador), permitindo flexibilidade e
                                                           //facilidade de manutenção.
			List<StudenteDto> studentiDto = studentiTrovati//Aqui está sendo criada uma lista do tipo StudenteDto. Um DTO (Data
                                                           //Transfer Object) é um objeto que contém apenas os dados que você
                                                           //quer transferir entre o backend e o frontend. Ele geralmente contém
                                                           //uma versão simplificada ou filtrada de uma entidade do domínio.
				.Select(r => StudenteMapper.Map(r))        //Aqui a função Select é um método de LINQ que mapeia cada elemento
                                                           //da lista studentiTrovati para um StudenteDto. Isso é feito usando
                                                           //o método StudenteMapper.Map(r), que converte uma entidade estudante
                                                           //(r) em seu correspondente DTO (StudenteDto). O padrão de Mapper
                                                           //desacopla o modelo de domínio da forma como os dados são exibidos
                                                           //ou enviados, permitindo flexibilidade e consistência na forma como
                                                           //os dados são projetados para o frontend.
				.ToList();                                 //O .ToList(): Converte o resultado do mapeamento em uma lista.

            return View(new StudentiIndexViewModel()       //Se a View (como Index.cshtml ou Search.cshtml) estiver corretamente
            {                                              //configurada na pasta Views/Studenti/, elas serão exibidas quando
                Filter = filter,                           //as ações forem chamadas.
                ElementiTrovati = studentiDto,             //O método Index() recebe critérios de busca por meio da query string,
            });                                            //usa o repositório para encontrar estudantes que correspondem ao filtro,
                                                           //converte os estudantes em um formato DTO usando o StudenteMapper, e
                                                           //então retorna uma view que exibe os dados encontrados. Esse padrão é
                                                           //comum em buscas onde o usuário pode fornecer critérios (como nome, idade,
                                                           //curso) para filtrar os resultados. Uma nova instância de StudentiIndexViewModel
                                                           //é criada. Esta view model mantém o filtro atual, que será mantido na
                                                           //interface (os valores preenchidos pelo usuário devem aparecer nos
                                                           //campos de filtro). A lista de estudantes filtrados já mapeados para
                                                           //DTOs(ElementiTrovati), que será exibida na interface ao usuário. O método
                                                           //View() renderiza a página associada, passando a view model
                                                           //(StudentiIndexViewModel) para a View, que poderá exibir os filtros e
                                                           //os resultados encontrados.
        }
	
        public IActionResult Aggiungi()                    //Este é o cabeçalho do método. Ele define que o método é público, retornando um
                                                           //tipo IActionResult. O IActionResult é um tipo de retorno genérico que pode
                                                           //representar diferentes tipos de resultados de ação (exibir uma view, redirecionar,
                                                           //retornar um erro, etc.). O método se chama Aggiungi e será o nome da rota associada
                                                           //à view. Neste caso, uma solicitação GET para /Studenti/Aggiungi irá acionar este método.
        {
            return View();                                 //Esta linha indica que o método retornará uma view (a página que renderiza o formulário
                                                           //de adição de um novo estudante). View(): Sem argumentos, ele tentará retornar a view padrão
                                                           //associada a este método, que, por convenção, será o arquivo Aggiungi.cshtml dentro da
                                                           //pasta Views / Studenti.
        }

        [HttpPost]                                         //Este é um atributo que indica que este método responderá a solicitações HTTP POST. Isso
                                                           //significa que este método será acionado quando o formulário for submetido com o método POST,
                                                           //ou seja, quando o usuário enviar os dados.
        public IActionResult Aggiungi(StudenteDto studenteDto)
                                                           //Este é o cabeçalho do método, ele recebe um parâmetro do tipo StudenteDto. O método é acessível
                                                           //publicamente por qualquer requisição. O tipo de retorno è IActionResult, assim como no método
                                                           //anterior, permite retornar vários tipos de respostas, como uma view, redirecionamento ou
                                                           //outros tipos de resultados. O Aggiungi(StudenteDto studenteDto)recebe um parâmetro do tipo StudenteDto,
                                                           //que é um Data Transfer Object (DTO). O StudenteDto é um modelo simplificado que representa os
                                                           //dados do formulário enviados pelo usuário.
        {
            if (ModelState.IsValid != true)                //O ModelState.IsValid verifica se o estado do modelo é válido. O ModelState contém informações
                                                           //sobre a validação do modelo, baseada nas anotações de dados (como[Required], [StringLength])
                                                           //definidas no StudenteDto. Caso algum campo do formulário não atenda às regras de validação
                                                           //(por exemplo, um campo obrigatório esteja vazio), ModelState.IsValid será false.
            {
                return View(studenteDto);                  //Se o ModelState for inválido, ou seja, se os dados do formulário não passarem nas regras de
                                                           //validação, o método retorna a view novamente, mas agora passando o studenteDto como parâmetro.
            }
            _studentiRepository.Post(StudenteMapper.Map(studenteDto));
                                                           //Esta linha é executada se o estado do modelo for válido. O _corsiRepository.Post() chama o
                                                           //método Post() no repositório de cursos(_corsiRepository), que se encarrega de inserir o novo
                                                           //curso no banco de dados. Já o CorsoMapper.Map(corsoDto), antes de salvar, os dados do DTO
                                                           //são convertidos para o modelo de domínio (provavelmente uma entidade que corresponde à tabela
                                                           //do banco de dados). O CorsoMapper é um mapeador que transforma o corsoDto no formato esperado
                                                           //pelo repositório. Essa separação entre o DTO e o modelo de domínio é uma boa prática de design
                                                           //para manter a lógica desacoplada.
            return Redirect(Url.Action(nameof(Index), "studenti"));
                                                           //O Redirect(), após salvar o novo estudante com sucesso, o usuário é redirecionado para a página
                                                           //principal de listagem de estudantes. O Url.Action(nameof(Index), "Studenti") constrói uma URL
                                                           //para o método Index no controlador Studenti. O método Index é responsável por exibir a lista de
                                                           //estudantes. O redirecionamento após um POST evita que o formulário seja reenviado se o usuário
                                                           //atualizar a página(padrão PRG - Post / Redirect / Get).
        }
    }
}