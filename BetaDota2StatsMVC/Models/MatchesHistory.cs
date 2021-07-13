using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class MatchesHistory
    {
        [Display(Name = "Match ID")]
        public long Match_id { get; set; }
        [Display(Name = "Player Slot")]//ti einai auto?
        public int Player_slot { get; set; }
        [Display(Name = "Who Won")]
        public bool Radiant_win { get; set; }
        //[Display(Name = "Match Duration")]
        public int Duration { get; set; }
        [Display(Name = "Game Mode")]
        public int Game_mode { get; set; }
        [Display(Name = "Normal or Rank")]
        public int Lobby_type { get; set; }
        [Display(Name = "Hero Name")]
        public int Hero_id { get; set; }
        public int Start_time { get; set; }
        public int? Version { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        [Display(Name = "Skill LVL")]
        public int? Skill { get; set; }
        [Display(Name ="Game had Leaver")]
        public int Leaver_status { get; set; }
        [Display(Name ="Solo or Party")]
        public int? Party_size { get; set; }

        //public Dictionary<int, Hero> GetAllHeroes()
        //{
        //    string SourcePath = "C:\\Users\\sapol\\source\\repos\\BetaDota2StatsMVC\\BetaDota2StatsMVC\\Data_JSON\\heroes.json";
        //    using (StreamReader r = new StreamReader(SourcePath))
        //    {
        //        string json = r.ReadToEnd();
        //        Dictionary<int, Hero> allHeroes999 = JsonConvert.DeserializeObject<Dictionary<int, Hero>>(json);
        //        return allHeroes999;
        //    }
        //}
    }
}