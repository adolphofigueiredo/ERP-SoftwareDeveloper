using System;

namespace _20241001_BusinessLayer.Models
{
    public static class Configurazioni
    {
        private static readonly string _connectionString = "Server=localhost\\SQLEXPRESS;Database=ITS_CORSI_ESAMI;Trusted_Connection=True;";
        public static string GetConnectionString() { return _connectionString; }
    }
}