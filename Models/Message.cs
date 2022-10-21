namespace webapp_travel_agency.Models
{
    public class Message
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Text { get; set; }
        public PacchettoViaggio? PacchettoViaggio { get; set; }
        public int PacchettoViaggioId { get; set; }
    }
}
