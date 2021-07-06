using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class MatchHeroViewModel
    {
        public IEnumerable<Match> Matches { get; set; }
        public Dictionary<int, Hero> Heroes { get; set; }
        public Match Match { get; set; }
    }
}