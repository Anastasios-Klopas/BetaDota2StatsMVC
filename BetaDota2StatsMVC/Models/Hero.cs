﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Hero
    {
        public int id { get; set; }
        public string name { get; set; }
        public string localized_name { get; set; }
        public string primary_attr { get; set; }
        public string attack_type { get; set; }
        public List<String> Roles { get; set; }
        public string img { get; set; }
        public string icon { get; set; }
        public int base_health { get; set; }
        public int? base_health_regen { get; set; }
        public int base_mana { get; set; }
        public int base_mana_regen { get; set; }
        public int base_armor { get; set; }
        public int base_mr { get; set; }
        public int base_attack_min { get; set; }
        public int base_attack_max { get; set; }
        public int base_str { get; set; }
        public int base_agi { get; set; }
        public int base_int { get; set; }
        public int str_gain { get; set; }
        public int agi_gain { get; set; }
        public int int_gain { get; set; }
        public int attack_range { get; set; }
        public int projectile_speed { get; set; }
        public int attack_rate { get; set; }
        public int move_speed { get; set; }
        public int? turn_rate { get; set; }
        public bool cm_enabled { get; set; }
        public int legs { get; set; }
    }
}