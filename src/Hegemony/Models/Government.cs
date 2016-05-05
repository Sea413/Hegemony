using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hegemony.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hegemony.Models
{
    [Table("Governments")]
    public class Government
    {
        [Key]
        public int GovernmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Modifier { get; set; }
        public virtual ICollection<Nation> Nations { get; set; }

    }
}