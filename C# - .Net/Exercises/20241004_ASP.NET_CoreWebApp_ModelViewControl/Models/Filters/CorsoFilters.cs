﻿

namespace _20241004_ASP.NET_CoreWebApp_ModelViewControl.Models.Filters
{
    public class CorsoFilter                //CorsolFilter é uma classe pública simples utilizada para agrupar critérios de
                                            //pesquisa e filtrar cursos no sistema. A principal função de uma classe de
                                            //filtro como essa é encapsular todos os parâmetros que serão usados em consultas
                                            //e buscas. Em vez de passar vários parâmetros soltos para uma função, ela passará 
                                            //um único objeto que contém todas as informações necessárias.
    {
        public string Nome { get; set; }    //Variável que receberá o valor digitado na caixa de texto e que deverá ser buscado.
        public DateTime? Da { get; set; }   //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
        public DateTime? A { get; set; }    //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
    }
}