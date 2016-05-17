using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hegemony.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int NationId { get; set; }
        public string Name { get; set; }
        public int GovernmentId { get; set; }
        public int PopulationValue { get; set; }
        public int EconomyId { get; set; }
        public int CapitalValue { get; set; }
        public int GeographyId { get; set; }
        public int ResourceValue { get; set; }
        public int TechnologyId { get; set; }
        public int TechnologyValue { get; set; }
        public int ArmyId { get; set; }
        public int ArmyValue { get; set; }
        public int HappinessValue { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}