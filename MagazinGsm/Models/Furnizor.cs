using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MagazinGsm.Models
{
    public class Furnizor
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nume { get; set; }
        [NotNull]
        public string Email { get; set; }
        [NotNull]
        public string Adresa { get; set; }
    }
}


