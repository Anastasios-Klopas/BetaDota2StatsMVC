using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Localized_Name { get; set; }
        public string Primary_Attr { get; set; }
        public string Attack_Type { get; set; }
        public List<String> Roles { get; set; }
    }
}