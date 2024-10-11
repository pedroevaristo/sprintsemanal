namespace mvc.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsAvailable { get; set; }
        public Professional Professional { get; set; }
    }
}
