namespace BetaDota2StatsMVC.Models
{
    public class Draft_Timing
    {
        public int Order { get; set; }
        public bool Pick { get; set; }
        public int Active_Team { get; set; }
        public int Hero_Id { get; set; }
        public int? Player_Slot { get; set; }
        public int Extra_Time { get; set; }
        public int Total_Time_Taken { get; set; }
    }
}