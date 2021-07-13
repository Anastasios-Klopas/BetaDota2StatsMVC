using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Match
    {
        public int Match_Id { get; set; }
        public int Barracks_Status_Dire { get; set; }
        public int Barracks_Status_Radiant { get; set; }
        public IEnumerable<Chat> Chats;
        public int Cluster { get; set; }
        public Object Cosmetics { get; set; }
        public int Dire_Score { get; set; }
        public IEnumerable<Draft_Timing> Draft_Timings { get; set; }
        public int Duration { get; set; }
        public int Engine { get; set; }
        public int First_Blood_Time { get; set; }
        public int Game_Mode { get; set; }
        public int Human_Players { get; set; }
        public int LeagueId { get; set; }
        public int Lobby_Type { get; set; }
        public int Match_Seq_Num { get; set; }
        public int Negative_Votes { get; set; }
        // "objectives": {},
        public Object Objectives { get; set; }
        //"picks_bans": {},
        public Object Picks_Bans { get; set; }
        public int Positive_Votes { get; set; }
        // "radiant_gold_adv": {},
        public Object Radiant_Gold_Adv { get; set; }
        public int Radiant_Score { get; set; }
        public bool Radiant_Win { get; set; }
        //"radiant_xp_adv": {},
        public Object Radaint_Xp_Adv { get; set; }
        public int Start_Time { get; set; }
        //"teamfights": {},
        public Object TeamFights { get; set; }
        public int Tower_Status_Dire { get; set; }
        public int Tower_Status_Radiant { get; set; }
        public int Version { get; set; }
        public int Replay_Salt { get; set; }
        public int Series_Id { get; set; }
        public int Series_Type { get; set; }
        public Object Radiant_Team { get; set; }
        public Object Dire_Team { get; set; }
        public Object League { get; set; }
        public int Skill { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public int Patch { get; set; }
        public int Region { get; set; }
        public Object All_Word_Counts { get; set; }
        public Object My_Word_Counts { get; set; }
        public int Throw { get; set; }
        public int Comeback { get; set; }
        public int Loss { get; set; }
        public int Win { get; set; }
        public bool Replay_Url { get; set; }
    }
}