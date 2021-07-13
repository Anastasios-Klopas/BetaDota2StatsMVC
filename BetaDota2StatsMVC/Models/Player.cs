using System;
using System.Collections.Generic;

namespace BetaDota2StatsMVC.Models
{
    public class Player
    {
        public long Match_Id { get; set; }
        public int Player_Slot { get; set; }
        //public IEnumerable<int> Ability_Upgrades_Arr { get; set; }
        public IList<int> Ability_Upgrades_Arr { get; set; }
        //"ability_upgrades_arr": [
        //  0
        //],
        public Object Ability_Uses { get; set; }
        public Object Ability_Targets { get; set; }
        public Object Damage_Targets { get; set; }
        public long? Account_Id { get; set; }
        public Object Actions { get; set; }
        public Object Additional_Units { get; set; }
        public int Assists { get; set; }
        public int Backpack_0 { get; set; }
        public int Backpack_1 { get; set; }
        public int Backpack_2 { get; set; }
        public IEnumerable<Buyback_Log> Buyback_Logs { get; set; }
        public int Camps_Stacked { get; set; }
        public IEnumerable<Connection_Log> Connection_Logs { get; set; }
        //"connection_log": [
        //  {
        //    "time": 0,
        //    "event": "string",
        //    "player_slot": 0
        //  }
        //],
        public int Creeps_Stacked { get; set; }
        public Object Damage { get; set; }
        public Object Damage_Inflictor { get; set; }
        public Object Damage_Inflictor_Received { get; set; }
        public Object Damage_Taken { get; set; }
        public int Deaths { get; set; }
        public int Denies { get; set; }
        public IList<int> Dn_T { get; set; }
        //"dn_t": [
        //  0
        //],
        public int Gold { get; set; }
        public int Gold_Per_Min { get; set; }
        public Object Gold_Reasons { get; set; }
        public int Gold_Spent { get; set; }
        //"gold_t": [
        //  0
        //],
        public IList<int> Gold_T { get; set; }
        public int Hero_Damage { get; set; }
        public int Hero_Healing { get; set; }
        public Object Hero_Hits { get; set; }
        public int Hero_Id { get; set; }
        public int Item_0 { get; set; }
        public int Item_1 { get; set; }
        public int Item_2 { get; set; }
        public int Item_3 { get; set; }
        public int Item_4 { get; set; }
        public int Item_5 { get; set; }
        public Object Item_Uses { get; set; }
        public Object Kill_Streaks { get; set; }
        public Object Killed { get; set; }
        public Object Killed_By { get; set; }
        public int Kills { get; set; }
        public IEnumerable<Kills_Log> Kills_Logs { get; set; }
        //"kills_log": [
        //  {
        //    "time": 0,
        //    "key": "string"
        //  }
        //],
        public Object Lane_Pos { get; set; }
        public int Last_Hits { get; set; }
        public int Leaver_Status { get; set; }
        public int Level { get; set; }
        public IList<int> Lh_T { get; set; }
        //"lh_t": [
        //  0
        //],
        public Object Life_State { get; set; }
        public Object Max_Hero_Hit { get; set; }
        public Object Multi_Kills { get; set; }
        public Object Obs { get; set; }
        public ICollection<Object> Obs_Left_Log { get; set; }
        //"obs_left_log": [
        //  {}
        //],
        public ICollection<Object> Obs_Log { get; set; }
        //"obs_log": [
        //  {}
        //],
        public int Obs_Placed { get; set; }
        public int Party_Id { get; set; }
        public ICollection<Object> Permant_Buffs { get; set; }

        //"permanent_buffs": [
        //  {}
        //],
        public int Pings { get; set; }
        public Object Purchase { get; set; }
        public IEnumerable<Purchase_Log> Purchase_Logs { get; set; }
        //"purchase_log": [
        //  {
        //    "time": 0,
        //    "key": "string",
        //    "charges": 0
        //  }
        //],
        public int Rune_Pickups { get; set; }


        //pws na ta grapsw?????????
        //
        //
        //public ICollection<Rune> Runes { get; set; }
        public Rune Rune { get; set; }
        //"runes": {
        //        "property1": 0,
        //        "property2": 0
        //},
        public ICollection<Runes_Log> Runes_Logs { get; set; }
        //"runes_log": [
        //  {
        //    "time": 0,
        //    "key": 0
        //  }
        //],
        public Object Sen { get; set; }
        public ICollection<Object> Sen_Left_Log { get; set; }

        //"sen_left_log": [
        //  {}
        //],
        public ICollection<Object> Sen_Log { get; set; }
        //"sen_log": [
        //  {}
        //],
        public int Sen_Placed { get; set; }
        public decimal Stuns { get; set; }
        public IList<int> Times { get; set; }
        //"times": [
        //  0
        //],
        public int Tower_Damage { get; set; }
        public int Xp_Per_Min { get; set; }
        public Object Xp_Reasons { get; set; }
        public IList<int> Xp_T { get; set; }
        //"xp_t": [
        //  0
        //],
        public string Personaname { get; set; }
        public string Name { get; set; }
        public DateTime? Last_Login { get; set; }
        public bool Radiant_Win { get; set; }
        public int Start_time { get; set; }
        public int Duration { get; set; }
        public int Cluster { get; set; }
        public int Lobby_type { get; set; }
        public int Game_mode { get; set; }
        public int Patch { get; set; }
        public int Region { get; set; }
        public bool IsRadiant { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Total_Gold { get; set; }
        public int Total_Xp { get; set; }
        public decimal Kills_Per_Min { get; set; }
        public int Kda { get; set; }
        public int Abandons { get; set; }
        public int Neutral_Kills { get; set; }
        public int Tower_Kills { get; set; }
        public int Courier_Kills { get; set; }
        public int Lane_Kills { get; set; }
        public int Hero_Kills { get; set; }
        public int Observer_Kills { get; set; }
        public int Sentry_Kills { get; set; }
        public int Roshan_Kills { get; set; }
        public int Necronomicon_Kills { get; set; }
        public int Ancient_Kills { get; set; }
        public int Buyback_Count { get; set; }
        public int Observer_Uses { get; set; }
        public int Sentry_Uses { get; set; }
        public decimal Lane_Efficiency { get; set; }
        public decimal Lane_Efficiency_Pct { get; set; }
        public int Lane { get; set; }
        public int Lane_Role { get; set; }
        public bool Is_Roaming { get; set; }
        public Object Purchase_Time { get; set; }
        public Object First_Purchase_Time { get; set; }
        public Object Item_Win { get; set; }
        public Object Item_Usage { get; set; }
        public Object Purchase_Tpscroll { get; set; }
        public int Actions_Per_Min { get; set; }
        public int Life_State_Dead { get; set; }
        public int? Rank_Tier { get; set; }
        //public IList<int> Cosmetics { get; set; }//error mhpws einai string
        //public IList<string> Cosmetics { get; set; }//error mhpws einai string
        public IList<Object> Cosmetics { get; set; }//error mhpws einai string
        //"cosmetics": [
        //  0
        //],
        public Object Benchmarks { get; set; }
        //"benchmarks": { }
    }
}