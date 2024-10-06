using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Components.Routing;
using System.Security.Cryptography;

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models
{
    public class ErrorViewModel                  //Define uma classe pública chamada ErrorViewModel. Essa classe é um ViewModel,
                                                 //usada para passar dados da camada de controle para a camada de visão (view).
                                                 //Em uma aplicação ASP.NET Core MVC, essa classe é usada para representar
                                                 //informações relacionadas a erros que podem ser exibidas para o usuário.
    {
        public string? RequestId { get; set; }   //O public string? RequestId { get; set; }: Define uma propriedade pública
                                                 //chamada RequestId do tipo string, que pode aceitar um valor nulo (?).
                                                 //O RequestId geralmente contém o ID da solicitação(Request) atual, que
                                                 //pode ser usado para rastrear ou debugar erros em uma aplicação web.
                                                 //O get; set; permite que essa propriedade seja lida e modificada de fora
                                                 //da classe. Esse é o padrão para propriedades em C# que precisam ser
                                                 //acessíveis externamente. O operador? indica que a string pode ser nula
                                                 //(nullable), ou seja, ela pode não conter um valor, o que é comum em alguns
                                                 //cenários, como quando não há um RequestId disponível.
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
                                                 //O public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); é uma
                                                 //propriedade de leitura do tipo booleano (bool). O ShowRequestId usa uma
                                                 //expressão lambda(=>) para retornar true se o RequestId não estiver vazio
                                                 //ou nulo, caso contrário, retorna false. O propósito dessa propriedade é
                                                 //determinar se o RequestId deve ser mostrado ou não. Se houver um RequestId
                                                 //válido (ou seja, não for uma string vazia ou nula), essa propriedade
                                                 //retorna true, indicando que o RequestId pode ser exibido.Caso contrário,
                                                 //retorna false.
    }
}

//O ErrorViewModel é comumente usado em páginas de erro em uma aplicação ASP.NET Core. Quando ocorre um erro em uma aplicação web,
//um RequestId pode ser gerado para identificar a solicitação que causou o erro. Esse RequestId é então armazenado na propriedade
//RequestId.
//A propriedade calculada ShowRequestId ajuda a determinar se o RequestId deve ser mostrado na página de erro para o usuário.
//Exibir o ID da solicitação pode ser útil para fins de rastreamento e diagnóstico, especialmente quando o usuário relatar o
//problema ao suporte técnico.
//Resumindo, o RequestId armazena o ID da solicitação, útil para rastreamento de erros. O ShowRequestId retorna um valor booleano
//que indica se o RequestId deve ser exibido. Portanto esse modelo é útil em páginas de erro para ajudar a identificar problemas
//em uma aplicação ASP.NET Core, fornecendo um RequestId que pode ser usado em logs ou no suporte técnico.