﻿using System.ComponentModel;

namespace _20241029_GestioneMagazzinoFrontEnd.Models.Dto


{
    public class ProdottoDto
    {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public int Altezza { get; set; }
        public int Larghezza { get; set; }
        public int Profondita { get; set; }
        public int Peso { get; set; }
    }
}