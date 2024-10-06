using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Entities;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.ComponentModel;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories
{
    public class CorsiRepository                                               //Classe responsável por gerenciar o CRUD (Create, Read, Update,
                                                                               //Delete) e filtragem de dados para a entidade CorsoEntity.
	{
        private readonly ItsCorsiEsamiContext _ctx;                            //O ItsCorsiEsamiContext _ctx é o campo privado que armazena o
                                                                               //contexto do banco de dados, utilizado para acessar as tabelas
                                                                               //relacionadas aos cursos. É injetado via Dependency Injection no
                                                                               //construtor.
		public CorsiRepository(ItsCorsiEsamiContext ctx)                       //É o Construtor que inicializa a classe CorsiRepository atribuindo o
                                                                               //contexto do banco de dados _ctx, que será usado para interagir com
                                                                               //as tabelas.
		{
            _ctx = ctx;

        }
        public ICollection<CorsoEntity> Find(CorsoFilter filter)               //Este método Find retorna uma coleção de entidades CorsoEntity que
																			   //atendem aos critérios especificados no filtro CorsoFilter.
		{
			IQueryable<CorsoEntity> query = ApplyFilter(_ctx, filter);         //O IQueryable é uma interface que permite a criação de consultas
                                                                               //dinâmicas que podem ser executadas posteriormente. Ela é muito útil
                                                                               //em sistemas que usam Entity Framework porque, diferentemente de
                                                                               //IEnumerable, as operações em IQueryable são processadas no servidor
                                                                               //(banco de dados) ao invés de serem todas carregadas na memória local.
                                                                               //Assim, consultas grandes podem ser mais eficientes. O CorsoEntity é
                                                                               //o tipo de entidade que será retornado, provavelmente representando
                                                                               //cursos em seu sistema. O método ApplyFilter aplica os critérios de
                                                                               //filtragem (baseados em um objeto filter) à coleção de cursos
                                                                               //armazenada no contexto _ctx. O contexto _ctx é uma instância de
                                                                               //ItsCorsiEsamiContext, que representa o banco de dados. A consulta
                                                                               //criada por ApplyFilter é aplicada à tabela de cursos (_ctx.Corsi),
                                                                               //mas não é executada imediatamente. Como IQueryable, a execução real
                                                                               //da consulta só ocorre quando você chama métodos como ToList(), Count()
                                                                               //, etc. Portanto a variável query agora contém uma consulta dinâmica
                                                                               //(não executada) que tem os filtros definidos, mas pode ainda ser
                                                                               //manipulada ou ajustada antes de ser enviada ao banco de dados para
                                                                               //execução real.

            return query.ToList();                                             //O query.ToList() Executa a consulta no banco de dados e retorna os
                                                                               //resultados como uma lista. Seria equivalente a SELECT *
                                                                               //FROM AnagreaficheStudenti WHERE  nome or cognome contains filter
		}
        public int Count(CorsoFilter filter)
        {
            IQueryable<CorsoEntity> query = ApplyFilter(_ctx, filter);

            return query.Count();                                              //O método Count Conta quantos cursos correspondem ao filtro aplicado.
                                                                               //Útil para determinar quantos registros correspondem à consulta antes
                                                                               //de paginar ou executar a busca completa.
		}
        private IQueryable<CorsoEntity> ApplyFilter(ItsCorsiEsamiContext ctx, CorsoFilter filter)
        {                                                                      //O parâmetro ctx no ItsCorsiEsamiContext é o contexto do banco de dados,
                                                                               //que contém o conjunto de dados de cursos através de ctx.Corsi. O contexto
                                                                               //é essencial para que a aplicação possa acessar e manipular os dados no
                                                                               //banco de dados.
			IQueryable <CorsoEntity> query = ctx.Corsi;                        //O IQueryable<CorsoEntity> query = ctx.Corsi inicializa a consulta para
                                                                               //a tabela Corsi, que contém todas as entidades de curso. O IQueryable
                                                                               //permite a criação de consultas dinâmicas e a execução delas somente
                                                                               //quando necessário (execução diferida).
			if (!string.IsNullOrEmpty(filter.Nome))
                query = query.Where(r => r.Nome.Contains(filter.Nome));        //Se o filtro contiver um valor no campo Nome, a consulta será filtrada
                                                                               //para retornar apenas os cursos cujo nome contenha a string especificada.
                                                                               //O Contains é uma operação de correspondência parcial que verifica se o
                                                                               //nome do curso contém a string fornecida, o que é útil para buscas flexíveis.
			if (filter.Da.HasValue && filter.A.HasValue)
            {
                query = query.Where(db => filter.A.Value >= db.DataValiditaInizio &&
                    filter.Da.Value <= db.DataValiditaFine);
            }
            else if (filter.Da.HasValue)
                query = query.Where(db => db.DataValiditaInizio <= filter.Da.Value);
            else if (filter.A.HasValue)
                query = query.Where(db => db.DataValiditaFine >= filter.A.Value);

            return query;
        }

        public CorsoEntity Get(int id)                                         //É um método público que pode ser acessado de fora da classe CorsiRepository.
                                                                               //O CorsoEntity é o tipo de retorno do método, ou seja, o método retornará uma
                                                                               //instância da entidade CorsoEntity, que representa um curso no sistema. O
                                                                               //Get(int id) é um método Get que recebe um parâmetro id (um número inteiro)
                                                                               //que será usado para buscar um curso específico.
		{
            return _ctx.Corsi.FirstOrDefault(r => r.Id == id);                 //O _ctx.Corsi é o contexto do banco de dados(instância de ItsCorsiEsamiContext),
                                                                               //e Corsi representa a tabela de cursos no banco. O FirstOrDefault() é o método
                                                                               //usado para buscar o primeiro registro da tabela Corsi que atende a uma condição.
                                                                               //A consulta é executada diretamente no banco de dados. Se houver um registro que
                                                                               //atenda à condição, ele será retornado. Se não houver nenhum registro que satisfaça
                                                                               //a condição, o método retornará null(ou seja, nenhum valor encontrado). O r => r.Id == id
                                                                               //é aa condição aplicada é r.Id == id. Isso significa que ele busca um curso(representado
                                                                               //por r) cujo ID(chave primária) seja igual ao valor passado no parâmetro id. O r representa
                                                                               //cada curso na tabela Corsi. O r.Id == id filtra os cursos que têm o mesmo Id que o
                                                                               //valor fornecido como argumento ao método.
		}
        public CorsoEntity Post(CorsoEntity input)                             //É um método público que pode ser chamado de fora da classe CorsiRepository. O método
                                                                               //retorna uma instância de CorsoEntity, que é a entidade de curso no sistema. O método
                                                                               //recebe um objeto do tipo CorsoEntity chamado input, que contém os dados do curso que
                                                                               //serão salvos no banco de dados.
		{
            // salvo i dati
            _ctx.Corsi.Add(input);
            _ctx.SaveChanges();                                                //O _ctx é o contexto do banco de dados (ItsCorsiEsamiContext), que gerencia a conexão
																			   //e a interação com o banco. O _ctx.Corsi é a tabela de cursos no banco de dados. O
																			   //Entity Framework trata a coleção Corsi como um DbSet<CorsoEntity>, que permite realizar
																			   //operações CRUD. O Add(input) é o método Add que insere o objeto input(do tipo CorsoEntity)
																			   //na tabela de cursos. Neste momento, a operação de inserção ainda não foi realizada no
																			   //banco de dados, mas o Entity Framework marca o objeto como "adicionado" no contexto de
																			   //rastreamento(ou seja, ele sabe que o curso será adicionado).
																			   //O SaveChanges() é o método que efetivamente salva as mudanças no banco de dados. Todas
                                                                               //as operações de inserção, atualização ou exclusão marcadas no contexto (_ctx) são
                                                                               //executadas neste momento.Neste caso, a adição do curso (com os dados contidos em input)
                                                                               //será persistida no banco de dados. Sem o SaveChanges(), a operação de Add(input) apenas
                                                                               //adicionaria o curso ao contexto de rastreamento, mas a transação não seria enviada ao
                                                                               //banco de dados. O método return retorna o mesmo objeto input que foi adicionado ao banco
                                                                               //de dados. Isso pode ser útil para o código que chamou o método, permitindo acessar os
                                                                               //dados do curso recém-adicionado. Se o banco de dados gerar automaticamente algum campo,
                                                                               //como um ID, o objeto input já terá esses valores preenchidos após o SaveChanges().
			return input;
        }
        public CorsoEntity Put(int id, CorsoEntity input)                      //O método público pode ser acessado externamente e retorna uma instância de CorsoEntity,
                                                                               //que é o curso atualizado no banco de dados com os parâmetros int id, identificador único
                                                                               //do curso a ser atualizado e CorsoEntity input, um objeto que contém os novos dados para
                                                                               //atualizar o curso existente.
		{
            var dbValue = _ctx.Corsi.FirstOrDefault(r => r.Id == id);          //Essa linha busca o curso no banco de dados que tenha o Id igual ao valor passado no
                                                                               //parâmetro id. O FirstOrDefault() retorna o primeiro curso que corresponde ao
                                                                               //critério(r.Id == id). Se não encontrar nenhum curso, retornará null. O_ctx.Corsi
                                                                               //refere-se ao conjunto de dados de cursos (DbSet<CorsoEntity>) do contexto do banco de dados.

			if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");
			                                                                   //Se o curso com o ID especificado não for encontrado, uma exceção do tipo ArgumentException
                                                                               //é lançada com a mensagem "Nessun dato trovato con id:{id}". Isso evita que o código tente
                                                                               //atualizar um curso inexistente.
			// salvo i dati
			dbValue.Nome = input.Nome;
            dbValue.DataValiditaFine = input.DataValiditaFine;
            dbValue.DataValiditaInizio = input.DataValiditaInizio;

            _ctx.SaveChanges();
            return dbValue;
        }

        public CorsoEntity Delete(int id)                                      //Este é um método público que pode ser chamado de fora da classe. Ele Retorna uma instância
                                                                               //da entidade CorsoEntity, que representa o curso que será deletado.
		{
            var dbValue = _ctx.Corsi.FirstOrDefault(r => r.Id == id);          //Neste caso, dbValue irá armazenar uma instância da classe CorsoEntity, que representa um curso.
																			   //O _ctx é uma instância de um contexto de banco de dados, geralmente uma classe que herda de
																			   //DbContext. É responsável por gerenciar a conexão com o banco de dados e as operações sobre as
																			   //entidades. A Corsi é uma propriedade do contexto _ctx que representa a tabela de cursos no
																			   //banco de dados. Esta propriedade é do tipo DbSet<CorsoEntity>, que permite a realização de
																			   //operações de consulta, inserção, atualização e exclusão na tabela Corsi. O r => r.Id == id
																			   //verifica se o método só retorne um curso que tenha o mesmo Id que o especificado.

			if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");
			                                                                   //Caso nenhum curso seja encontrado (ou seja, se dbValue for null), lança uma exceção do tipo
                                                                               //ArgumentException com a mensagem informando que não foi encontrado nenhum dado com o id especificado.
			// salvo i dati
			_ctx.Corsi.Remove(dbValue);                                        //Se o curso for encontrado, ele é removido da tabela de cursos. O Remove() marca o objeto
                                                                               //dbValue para ser excluído do banco de dados.
			_ctx.SaveChanges();
            return dbValue;
        }

        public ICollection<CorsoEntity> GetCorsiValidi(DateTime dt)            //O método retorna uma coleção de cursos (Corsi) que são considerados "válidos" com base na data fornecida (dt).
		{
            var q = _ctx.Corsi.Where(c =>                                      //A var q armazenará uma consulta filtrada sobre os cursos. O tipo exato será inferido pelo compilador, que neste
                                                                               //caso é um IQueryable<CorsoEntity>. O _ctx.Corsi refere-se à coleção de cursos na base de dados, como mencionado
                                                                               //anteriormente. Isso permite que você execute operações de consulta sobre a tabela Corsi. O Where é O método usado
                                                                               //para aplicar um filtro à sequência de cursos, retornando apenas aqueles que atendem a condição especificada na
                                                                               //expressão lambda.
				c.DataValiditaInizio <= dt &&
                c.DataValiditaFine == null || c.DataValiditaFine > DateTime.Now).ToList();

            return q.ToList();
        }
    }
}
