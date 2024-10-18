using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Dtos;
using _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models.Entities;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Xml;
using System;

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Models
{
    public static class ClientiMapper       //Esta classe estática (não pode ser instanciada) tem como objetivo mapear
                                            //(converter) objetos entre duas classes, a Dto (um Data Transfer Object)
                                            //e a Entity (Representa uma tabela do banco de dados). Isso é útil para
                                            //separar a lógica de negócios da camada de persistência de dados e garantir
                                            //que apenas os dados necessários sejam transferidos entre o cliente e o servidor.
    {
    public static ClienteEntity From(ClienteDto dto)
                                            //Esse método estático converte um objeto DTO em um objeto Entity. Ele é chamado
                                            //quando precisamos transformar um DTO (usado geralmente na API) em uma entidade
                                            //que pode ser manipulada pelo sistema de banco de dados.
    {
        if (dto == null) return null;       //Verifica se a variável dto é nala e se for, retorna null para evitar erros de
                                            //referência ao tentar acessar seus campos.
        return new ClienteEntity()          //Caso o dto não seja nulo, cria um novo objeto Entity, copiando os valores dos
        {                                   //campos fornecidos pela variável dto extraídas do DTO.
        CodiceFiscale = dto.CodiceFiscale,
        Cognome = dto.Cognome,
        Nome = dto.Nome
        };
    }
    public static ClienteDto From(ClienteEntity dto)
                                            //Esse método estático converte um objeto Entity em um objeto DTO que será
                                            //enviado para a API ou outra camada que precise de uma versão simplificada
                                            //dos dados.
        {
            if (dto == null) return null;   //Verifica se a variável dto é nala e se for, retorna null para evitar erros de
                                            //referência ao tentar acessar seus campos.
        return new ClienteDto()             //Caso o DTO não seja nulo, cria um novo objeto DTO, copiando os valores dos
        {                                   //campos fornecidos pela variável dto extraídas da Entity.
        CodiceFiscale = dto.CodiceFiscale,
        Cognome = dto.Cognome,
        Nome = dto.Nome
    };
    }
    }
}
