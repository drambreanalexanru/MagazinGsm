using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MagazinGsm.Models
{
    public class Produs
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Descriere { get; set; }
        public string Modele { get; set; }
        public double Pret { get; set; }
        [OneToMany]
        public List<ListProdus> ListProduse { get; set; }
    }

}
