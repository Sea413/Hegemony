using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hegemony.Models
{
    [Table("Outcomes")]
    public class Outcome
    {
        [Key]
        public int OutcomeId { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public int HazardId { get; set; }
        public int CVModifier { get; set; }
        public int RVModifier { get; set; }
        public int PVModifier { get; set; }
        public int HVModifier { get; set; }
        public int AVModifer { get; set; }
        public virtual Hazard Hazard {get; set; }
    }
}