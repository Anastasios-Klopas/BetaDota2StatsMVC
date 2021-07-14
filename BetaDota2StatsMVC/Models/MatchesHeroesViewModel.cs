using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;

namespace BetaDota2StatsMVC.Models
{
    public class MatchesHeroesViewModel
    {
        //public IEnumerable<MatchesHistory> Matches { get; set; }
        public IPagedList<MatchesHistory> Matches { get; set; }
        public Dictionary<int, Hero> Heroes { get; set; }
        public MatchesHistory Match { get; set; }
    }
}