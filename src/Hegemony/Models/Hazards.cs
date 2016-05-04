using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hegemony.Models
{
    [Table("Hazards")]
    public class Hazard
    {
        [Key]
        public int HazardId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OutcomeId { get; set; }
        public virtual ICollection<Outcome> Outcomes { get; set; }
        
    }
}