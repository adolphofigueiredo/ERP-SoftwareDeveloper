using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240918_Database_FrameWork.Models.Filters
{
    public class StudenteFilter                                                                    //StudenteFilter é uma classe pública simples utilizada para agrupar critérios
                                                                                                   //de pesquisa e filtrar estudantes no sistema. A principal função de uma classe
                                                                                                   //de filtro como essa é encapsular todos os parâmetros que serão usados em
                                                                                                   //consultas e buscas. Em vez de passar vários parâmetros soltos para uma função,
                                                                                                   //ela passará um único objeto que contém todas as informações necessárias.
    {
        public string Nominativo { get; set; }                                                     //Variável que receberá o valor digitado na caixa de texto e que deverá ser buscado.
        public DateTime? Inizio { get; set; }                                                      //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
        public DateTime? Fine { get; set; }                                                        //Variável que receberá o valor digitado na caixa de datas e que deverá ser buscado.
    }
}