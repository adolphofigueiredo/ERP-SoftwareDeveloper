using _20240918_Database_FrameWork.Models.Dtos;
using _20240918_Database_FrameWork.Models.Entity;

namespace _20240918_Database_FrameWork.Models.Mappers
{
    public static class StudenteMapper                                                             //É uma classe estática, o que significa que ela não pode ser instanciada.
                                                                                                   //Isso é comum para mapeadores, pois a única responsabilidade deles é
                                                                                                   //converter objetos entre diferentes representações, sem manter estado.
                                                                                                   //Esta classe serve como um mapeador de dados entre duas classes:
                                                                                                   //StudenteEntity, que representa a entidade no banco de dados, e StudenteDto,
                                                                                                   //que é um DTO(Data Transfer Object) usado para transferir os dados para a
                                                                                                   //camada de apresentação ou outras camadas da aplicação.
    {
        public static StudenteDto Map(StudenteEntity studenteEntity)                               //Este método é estático e converte um objeto StudenteEntity em um StudenteDto.
                                                                                                   //Ele recebe um parâmetro do tipo StudenteEntity e retorna um objeto do tipo
                                                                                                   //StudenteDto. O parâmetro studenteEntity é o objeto da entidade que vem do
                                                                                                   //banco de dados, e contém todos os atributos relacionados a um estudante.
    {
        if (studenteEntity == null) return null;                                                   //Antes de prosseguir com o mapeamento, o método verifica se o parâmetro
                                                                                                   //studenteEntity é nulo. Se for, o método retorna null para evitar exceções.
                                                                                                   //Essa é uma prática comum para garantir que o método não tente acessar membros
                                                                                                   //de um objeto nulo, evitando erros de referência.

            return new StudenteDto()                                                               //O mapeamento propriamente dito ocorre dentro do return new StudenteDto(),
                                                                                                   //onde um novo objeto StudenteDto é criado e as propriedades da entidade são
                                                                                                   //copiadas para o DTO. O mapeamento é direto e simples, copiando os valores
                                                                                                   //das propriedades da entidade para o DTO, sem realizar transformações
                                                                                                   //complexas nos dados.
            {
                CodiceFiscale = studenteEntity.CodiceFiscale,                                      //O campo do CodiceFiscale do StudenteDto recebe o valor do campo CodiceFiscale
                                                                                                   //da entidade StudenteEntity

                Cognome = studenteEntity.Cognome,                                                  //O campo do Cognome do StudenteDto recebe o valor do campo Cognome da
                                                                                                   //entidade StudenteEntity

                Nome = studenteEntity.Nome,                                                        //O campo do Nome do StudenteDto recebe o valor do campo nome da entidade
                                                                                                   //StudenteEntity

                CorsoId = studenteEntity.CorsoId,                                                  //O campo do CorsoId do StudenteDto recebe o valor do campo CorsoId da entidade
                                                                                                   //StudenteEntity

                DataDiNascita = studenteEntity.DataDiNascita,                                      //O campo do DataDiNascita do StudenteDto recebe o valor do campo DataDiNascita
                                                                                                   //da entidade StudenteEntity

                Id = studenteEntity.Id,                                                            //O campo do Id do StudenteDto recebe o valor do campo Id da entidade StudenteEntity
            };
        }
    }
}