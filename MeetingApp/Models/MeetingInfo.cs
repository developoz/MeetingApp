namespace MeetingApp.Models
{
    public class MeetingInfo()
    {
        public int Id { get; set; }
        public string? location { get; set; }
        public DateTime date { get; set; }

        public int numberofpeople { get; set; }
    }
    
}