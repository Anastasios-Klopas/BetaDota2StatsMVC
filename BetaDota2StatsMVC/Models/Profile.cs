using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Profile
    {
        public int Account_id { get; set; }
        public string Personaname { get; set; }
        public string Name { get; set; }
        public bool Plus { get; set; }
        public int Cheese { get; set; }
        public string Steamid { get; set; }
        public string Avatar { get; set; }
        public string Avatarmedium { get; set; }
        public string Avatarfull { get; set; }
        public string ProfileUrl { get; set; }
        public string Last_login { get; set; }
        public string LocCountryCode { get; set; }
        public bool Is_contributor { get; set; }
    }
}