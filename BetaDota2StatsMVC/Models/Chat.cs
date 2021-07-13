using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetaDota2StatsMVC.Models
{
    public class Chat
    {
      public int Time { get; set; }
      public string Unit { get; set; }
      public string Key { get; set; }
      public int Slot { get; set; }
      public int Player_Slot { get; set; }
    }
}