using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hegemony.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hegemony.Models
{
    [Table("Geographies")]
    public class Geography
    {
        [Key]
        public int GeographyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PositiveModifier { get; set; }
        public decimal NegativeModifier { get; set; }
        public virtual ICollection<Nation> Nations { get; set; }

    }
}