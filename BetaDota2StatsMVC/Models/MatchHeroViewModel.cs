﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class MatchHeroViewModel
    {
        public Match Match { get; set; }
        public Dictionary<int, Hero> Heroes { get; set; }
    }
}