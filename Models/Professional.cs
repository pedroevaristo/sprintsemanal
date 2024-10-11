namespace mvc.Models
{
    public class Professional
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string specialization { get; set; }
        public string localization {  get; set; }
        public List<Appointment> Appointment { get; set; }
    }
}
