using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Fistname { get; set; }

        [Required]
        [MaxLength(100)]
        public string Lastname { get; set; }
        public int Years { get; set; }

        [Required]
        [MaxLength(1)]
        public char Sex { get; set; }
    }
}
