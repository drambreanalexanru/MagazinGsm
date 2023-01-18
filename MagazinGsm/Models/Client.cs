using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MagazinGsm.Models
{
    
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nume { get; set; }
        [NotNull]
        public string Prenume { get; set; }
        [NotNull]

        public string NumarTelefon { get; set; }
        public string Adresa { get; set; }
    }
}
