using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Mmr_Estimate
    {
        [Display(Name = "Estimated MMR")]
        public int Estimate { get; set; }
        public int StdDev { get; set; }
        public int N { get; set; }
    }
}