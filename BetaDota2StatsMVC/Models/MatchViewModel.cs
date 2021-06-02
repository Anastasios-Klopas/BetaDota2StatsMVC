using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class MatchViewModel
    {
        public long Match_id { get; set; }
        public int Player_slot { get; set; }
        public bool Radiant_win { get; set; }
        public int Duration { get; set; }
        public int Game_mode { get; set; }
        public int Lobby_type { get; set; }
        public int Hero_id { get; set; }
        public int Start_time { get; set; }
        public int? Version { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public int? Skill { get; set; }
        public int Leaver_status { get; set; }
        public int? Party_size { get; set; }
    }
}