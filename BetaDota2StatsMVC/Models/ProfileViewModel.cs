using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace BetaDota2StatsMVC.Models
{
    public class ProfileViewModel
    {
        public string TrackedUntil { get; set; }
        public string Solocompetitive { get; set; }
        public string CompetitiveRank { get; set; }
        public int RankTier { get; set; }
        public int LeaderboardRank { get; set; }
        public string MmrEstimate { get; set; }
        /* {
                "estimate": 0,
                "stdDev": 0,
                "n": 0
            },*/
        public List<String> Profile { get; set; }
        /* {
                "account_id": 0,
                "personaname": "string",
                "name": "string",
                "plus": true,
                "cheese": 0,
                "steamid": "string",
                "avatar": "string",
                "avatarmedium": "string",
                "avatarfull": "string",
                "profileurl": "string",
                "last_login": "string",
                "loccountrycode": "string",
                "is_contributor": false
            }*/

    }
}