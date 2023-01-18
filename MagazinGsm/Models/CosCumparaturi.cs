using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace MagazinGsm.Models
{
    public class CosCumparaturi
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Denumire { get; set; }
        public DateTime Data { get; set; }

        [ForeignKey(typeof(Furnizor))]
        public int FurnizorID { get; set; }


    }
}

