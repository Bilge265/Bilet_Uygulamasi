using System.ComponentModel.DataAnnotations;

namespace Bilet_API.Entity
{
    public class Voyage: BaseEntity
    {
       [Key] public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
    }
}
