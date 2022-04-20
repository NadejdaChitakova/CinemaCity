using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        [MaxLength(100)]
        public string Director { get; set; }
        [Required]
        public DateTime ReliaseDate { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
