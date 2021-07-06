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
        public string Localized_name { get; set; }
        public string Primary_attr { get; set; }
        public string Attack_type { get; set; }
        public List<String> Roles { get; set; }
        public string Img { get; set; }
        public string Icon { get; set; }
        public int Base_health { get; set; }
        public decimal? Base_health_regen { get; set; }
        public int Base_mana { get; set; }
        public decimal Base_mana_regen { get; set; }
        public decimal Base_armor { get; set; }
        public int Base_mr { get; set; }
        public int Base_attack_min { get; set; }
        public int Base_attack_max { get; set; }
        public int Base_str { get; set; }
        public int Base_agi { get; set; }
        public int Base_int { get; set; }
        public decimal Str_gain { get; set; }
        public decimal Agi_gain { get; set; }
        public decimal Int_gain { get; set; }
        public int Attack_range { get; set; }
        public int Projectile_speed { get; set; }
        public decimal Attack_rate { get; set; }
        public int Move_speed { get; set; }
        public decimal? Turn_rate { get; set; }
        public bool Cm_enabled { get; set; }
        public int Legs { get; set; }
    }
}