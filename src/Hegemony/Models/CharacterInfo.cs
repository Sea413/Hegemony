using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hegemony.Models
{
    [Table("CharacterInfo")]
    public class CharacterInfo
    {
        [Key]
        public int AvatarId { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string real_name { get; set; }
        public string api_detail_url { get; set; }
        public string deck { get; set; }
        public int fame { get; set; }
    }

}