using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilet_Uygulamasi.Entity
{
    public class Voyage :BaseEntity
    {
        [Key] public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public DateTime Time { get; set; }
        public int Price { get; set; }
    }
}
