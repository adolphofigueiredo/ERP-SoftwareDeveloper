using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Dtos;
using _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Entities;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Mappers
{
    public static class CorsoMapper                        //O public static class CorsoMapper define uma classe estática. Isso
    {                                                      //significa que todos os seus membros também são estáticos, o que
                                                           //torna o mapper reutilizável sem a necessidade de instanciá-lo.
        public static CorsoDto Map(CorsoEntity e)          //O public static CorsoDto Map(CorsoEntity e) é um método estático
                                                           //que recebe uma instância de CorsoEntity (abrev. e) e retorna um
                                                           //objeto CorsoDto. O tipo retornado é um DTO que encapsula informações
                                                           //sobre o curso. O método Map pega os valores da entidade CorsoEntity
                                                           //e os transfere para um DTO CorsoDto. A finalidade deste mapeamento
                                                           //é criar uma abstração mais simples e segura para ser utilizada nas
                                                           //camadas superiores da aplicação, como a interface do usuário ou a
                                                           //lógica de negócios. O DTO encapsula as informações relevantes do
                                                           //curso (ID, nome e datas de validade) sem expor a lógica interna do
                                                           //banco de dados.
        {
            if (e == null) return null;                    //Verifica se a entidade CorsoEntity recebida é nula. Se for, o método
                                                           //retorna null, evitando a propagação de uma exceção ao tentar acessar
                                                           //uma referência nula.

            return new CorsoDto()                          //Cria uma nova instância de CorsoDto com os valores extraídos da
            {                                              //entidade CorsoEntity abaixo.

                Id = e.Id,                                 //A propriedade Id no CorsoDto é mapeada a partir da entidade
                                                           //CorsoEntity

                Nome = e.Nome,                             //A propriedade Nome no CorsoDto é mapeada a partir da entidade
                                                           //CorsoEntity

                DataValiditaFine = e.DataValiditaFine,     //A propriedade DataValiditaFine no CorsoDto é mapeada a partir da
                                                           //entidade CorsoEntity

                DataValiditaInizio = e.DataValiditaInizio, //A propriedade ValiditaInizio no CorsoDto é mapeada a partir da
                                                           //entidade CorsoEntity
            };
        }

        public static CorsoEntity Map(CorsoDto e)          //O public static CorsoDto Map(CorsoEntity e) é um método estático
                                                           //que recebe uma instância de CorsoEntity (abrev. e) e retorna um
                                                           //objeto CorsoDto. O tipo retornado é um DTO que encapsula informações
                                                           //sobre o curso. O método Map pega os valores da entidade CorsoEntity
                                                           //e os transfere para um DTO CorsoDto. A finalidade deste mapeamento
                                                           //é criar uma abstração mais simples e segura para ser utilizada nas
                                                           //camadas superiores da aplicação, como a interface do usuário ou a
                                                           //lógica de negócios. O DTO encapsula as informações relevantes do
                                                           //curso (ID, nome e datas de validade) sem expor a lógica interna do
                                                           //banco de dados.
        {
            if (e == null) return null;                    //Verifica se a entidade CorsoEntity recebida é nula. Se for, o método
                                                           //retorna null, evitando a propagação de uma exceção ao tentar acessar
                                                           //uma referência nula.

            return new CorsoEntity()                       //Cria uma nova instância de CorsoDto com os valores extraídos da
            {                                              //entidade CorsoEntity abaixo.

                Id = e.Id,                                 //A propriedade Id no CorsoDto é mapeada a partir da entidade
                                                           //CorsoEntity

                Nome = e.Nome,                             //A propriedade Nome no CorsoDto é mapeada a partir da entidade
                                                           //CorsoEntity

                DataValiditaFine = e.DataValiditaFine,     //A propriedade DataValiditaFine no CorsoDto é mapeada a partir da
                                                           //entidade CorsoEntity

                DataValiditaInizio = e.DataValiditaInizio, //A propriedade ValiditaInizio no CorsoDto é mapeada a partir da
                                                           //entidade CorsoEntity
            };
        }

    }
}