using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace BetaDota2StatsMVC.Models
{
    public class ProfileViewModel
    {
        [Display(Name ="Tracked")]
        public string Tracked_until { get; set; }
        [Display(Name = "Old Solo/Core MMR")]
        public string Solo_competitive_rank { get; set; }
        [Display(Name = "Old Party/Support MMR")]
        public string Competitive_rank { get; set; }
        public int Rank_tier { get; set; }
        //public int Leaderboard_rank { get; set; }
        public Profile Profile { get; set; }
        public Mmr_Estimate Mmr_Estimate { get; set; }
    }
}