﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbExplorer_WinApp.Models
{
    public static class Configurazioni
    {
        private static readonly string _connectionString = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
        public static string GetConnectionString() {  return _connectionString; }
    }
}