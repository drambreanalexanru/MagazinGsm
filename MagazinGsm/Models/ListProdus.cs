using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace MagazinGsm.Models
{
    
    
        public class ListProdus
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            [ForeignKey(typeof(CosCumparaturi))]
            public int CosCumparaturiID { get; set; }
            public int ProdusID { get; set; }
        }}
