using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCity.Entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public int Duration { get; set; }
        public string Director { get; set; }
        public DateTime ReliaseDate { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
