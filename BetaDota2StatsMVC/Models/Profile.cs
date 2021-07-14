using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Profile
    {
        [Display(Name = "Account ID")]
        public int Account_id { get; set; }
        [Display(Name = "Nick Name")]
        public string Personaname { get; set; }
        public string Name { get; set; }
        [Display(Name = "Dota Plus")]
        public bool Plus { get; set; }
        public int Cheese { get; set; }
        [Display(Name = "Steam ID")]
        public string Steamid { get; set; }
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
        public string Avatarmedium { get; set; }
        public string Avatarfull { get; set; }
        [Display(Name = "Profile URL")]
        public string ProfileUrl { get; set; }
        [Display(Name="Last Login")]
        public DateTime Last_login { get; set; }
        [Display(Name = "Country Code")]
        public string LocCountryCode { get; set; }
        public bool Is_contributor { get; set; }
    }
}