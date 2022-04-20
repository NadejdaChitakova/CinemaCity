using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity.Entity
{
    public class Projection
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }
        public Movie Movie { get; set; }
        public Salon Salon { get; set; }
    }
}
