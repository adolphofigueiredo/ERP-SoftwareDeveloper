using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Entities;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters;
using Microsoft.Win32;
using System.Drawing;
using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using Microsoft.SqlServer.Server;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Repositories           //Define um namespace para organizar o código. Isso ajuda a manter as classes
                                                                               //relacionadas em um único lugar, facilitando a manutenção e a navegação.
{
    public class StudentiRepository                                            //Declara a classe StudentiRepository, que é pública e pode ser acessada por
                                                                               //outras partes da aplicação. Essa classe encapsula a lógica para interagir
                                                                               //com a tabela de estudantes.
	{
        private readonly ItsCorsiEsamiContext _ctx;                            //Declara um campo privado do tipo ItsCorsiEsamiContext, que é o contexto do
                                                                               //banco de dados. O readonly garante que o valor do campo só pode ser definido
                                                                               //no construtor e não pode ser alterado depois disso. Isso é importante para
                                                                               //manter a integridade do contexto durante o ciclo de vida da classe.
		public StudentiRepository(ItsCorsiEsamiContext ctx)                    //Este é o construtor da classe que recebe uma instância de ItsCorsiEsamiContext
                                                                               //como parâmetro.
		{
            _ctx = ctx;                                                        //Atribui a instância do contexto recebida ao campo _ctx, permitindo que os
                                                                               //métodos da classe acessem o banco de dados.
		}
        public ICollection<StudenteEntity> Find(StudenteFilter filter)         //Método que busca estudantes no banco de dados com base em um filtro fornecido.
		{

            IQueryable<StudenteEntity> query = ApplyFilter(_ctx, filter);      //Chama o método ApplyFilter para construir uma consulta com base nos critérios
                                                                               //do filtro. O resultado é uma coleção de estudantes que atende a esses critérios.

			return query.ToList();                                             //Executa a consulta e retorna o resultado como uma lista, seria uma consulta
                                                                               //similar a SELECT * FROM AnagreaficheStudenti WHERE nome or cognome contains filter ...
		}
        public int Count(StudenteFilter filter)                                //Método que conta o número de estudantes que atendem aos critérios especificados no filtro.
        {
            IQueryable<StudenteEntity> query = ApplyFilter(_ctx, filter);      //Chama o método ApplyFilter para construir uma consulta com base nos critérios
                                                                               //do filtro. O resultado é uma coleção de estudantes que atende a esses critéri

            return query.Count();                                              //Executa a contagem de estudantes que atendem aos critérios do filtro e retorna o resultado.
        }
        private IQueryable<StudenteEntity> ApplyFilter(ItsCorsiEsamiContext ctx, StudenteFilter filter)
		                                                                       //Na parte IQueryable<StudenteEntity> podemos dizer que o tipo de retorno do método é IQueryable,
                                                                               //uma interface que permite construir consultas de forma eficiente e apenas executar a consulta
                                                                               //quando for necessária. Isso permite que o método aplique diferentes filtros de maneira dinâmica
                                                                               //e eficiente no banco de dados.
                                                                               //Já o ApplyFilter(ItsCorsiEsamiContext ctx, StudenteFilter filter) recebe dois parâmetros, o
                                                                               //ItsCorsiEsamiContext ctx que é o contexto do Entity Framework, que dá acesso ao banco de dados
                                                                               //e às tabelas.É uma instância do contexto do banco de dados.
                                                                               //E o StudenteFilter filter que é Um objeto que contém os critérios de filtragem. Ele pode conter
                                                                               //propriedades como Nominativo (nome do estudante), datas de nascimento (Da e A), entre outros,
                                                                               //que são usados para filtrar os estudantes.
		{
			IQueryable<StudenteEntity> query = ctx.Studenti;                   //O método começa criando uma consulta básica com todos os registros da tabela Studenti, que mapeia
                                                                               //a entidade StudenteEntity no banco de dados. Isso é feito através do contexto do banco de dados(ctx).
                                                                               //Neste ponto, a consulta ainda não foi executada, e o uso de IQueryable permite que sejam aplicados
                                                                               //filtros de forma incremental antes de a consulta ser finalizada.
			if (!string.IsNullOrEmpty(filter.Nominativo))
                query = query.Where(r => (r.Nome + " " + r.Cognome).Contains(filter.Nominativo));

            if (filter.Da.HasValue)
                query = query.Where(r => r.DataDiNascita >= filter.Da.Value);
            if (filter.A.HasValue)
                query = query.Where(r => r.DataDiNascita <= filter.A.Value);

            return query;
        }

        public StudenteEntity Get(int id)                                      //Este método é responsável por buscar um estudante específico no banco de dados,
                                                                               //com base no identificador único (ID) do estudante. Retorna um objeto do tipo
                                                                               //StudenteEntity (a entidade que representa o estudante no banco de dados). Recebe
                                                                               //um parâmetro id do tipo int, que é o identificador único do estudante.
		{
            return _ctx.Studenti.FirstOrDefault(r => r.Id == id);              //Utiliza o contexto de banco de dados (_ctx), que tem acesso à tabela Studenti
                                                                               //(coleção de objetos StudenteEntity). O método FirstOrDefault busca o primeiro
                                                                               //estudante cujo campo Id corresponde ao valor passado como argumento(id). Se o
                                                                               //estudante for encontrado, o método retorna o objeto StudenteEntity
                                                                               //correspondente. Se não for encontrado, retorna null (por isso é FirstOrDefault,
                                                                               //onde "Default" é null se nenhum registro for encontrado).
		}
        public StudenteEntity Post(StudenteEntity input)                       //Este método é responsável por adicionar um novo registro de estudante ao banco
                                                                               //de dados. O método é público e retorna um objeto do tipo StudenteEntity. Recebe
                                                                               //um parâmetro input do tipo StudenteEntity, que contém os dados do estudante a
                                                                               //serem salvos no banco de dados.
        { 
            // salvo i dati
            _ctx.Studenti.Add(input);                                          //Adiciona o objeto input (que contém os dados do novo estudante) à coleção
                                                                               //Studenti do contexto do banco de dados. Esse comando ainda não executa a
                                                                               //inserção no banco de dados; ele apenas adiciona o objeto à memória, marcando-o
                                                                               //para ser salvo.
			_ctx.SaveChanges();                                                //Este método faz a persistência real das mudanças no banco de dados. Isso
                                                                               //significa que o novo estudante será efetivamente inserido na tabela Studenti.
                                                                               //Se houver qualquer erro (por exemplo, falha de conexão ou violação de restrições
                                                                               //do banco), ele lançará uma exceção.
			return input;
        }

        public StudenteEntity Put(int id, StudenteEntity input)                //O método Put é responsável por atualizar as informações de um estudante já
                                                                               //existente no banco de dados. Ele recebe recebe dois parâmetros, o id que é
                                                                               //o identificador do estudante que será atualizado e o input que é um objeto
                                                                               //StudenteEntity que contém os novos dados do estudante.
		{
            var dbValue = _ctx.Studenti.FirstOrDefault(r => r.Id == id);       //Aqui, estamos buscando no banco de dados o estudante que corresponde ao id
                                                                               //passado como argumento. Se encontrado, o objeto dbValue conterá os dados do
                                                                               //estudante; caso contrário, será null.

			if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");
			                                                                   //Caso o estudante não seja encontrado (ou seja, dbValue == null), o método
                                                                               //lança uma exceção informando que nenhum dado foi encontrado para o ID fornecido.

			// salvo i dati
			dbValue.DataDiNascita = input.DataDiNascita;                       //Após encontrar o estudante, as propriedades DataDiNascita, Nome, Cognome e
                                                                               //CodiceFiscale do objeto dbValue são atualizadas com os valores presentes
                                                                               //no objeto input.
			dbValue.Nome = input.Nome;
            dbValue.Cognome = input.Cognome;
            dbValue.CodiceFiscale = input.CodiceFiscale;
            _ctx.SaveChanges();         
            return dbValue;
        }

        public StudenteEntity Delete(int id)                                   //O método Delete é responsável por remover um estudante do banco de dados
                                                                               //com base no identificador fornecido.
		{
			var dbValue = _ctx.Studenti.FirstOrDefault(r => r.Id == id);       //Aqui, estamos buscando no banco de dados o estudante que corresponde ao id
																			   //passado como argumento. Se encontrado, o objeto dbValue conterá os dados do
																			   //estudante; caso contrário, será null.
    		if (dbValue == null) throw new ArgumentException($"Nessun dato trovato con id:{id}");
                                                                               //Caso o estudante não seja encontrado (ou seja, dbValue == null), o método
                                                                               //lança uma exceção informando que nenhum dado foi encontrado para o ID fornecido.
			// salvo i dati
			_ctx.Studenti.Remove(dbValue);                                     //Remove o objeto dbValue (ou seja, o estudante encontrado) da coleção Studenti
                                                                               //do contexto do banco de dados. A remoção é marcada para ser realizada, mas as
                                                                               //mudanças ainda não foram persistidas.

			_ctx.SaveChanges();
            return dbValue;
        }
    }
}