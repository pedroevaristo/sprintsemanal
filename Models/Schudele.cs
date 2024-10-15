namespace mvc.Models
{
    public class Schudele//Aqui é o objeto que representa a agendamento
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsAvailable { get; set; }
        public Professional Professional { get; set; }
    }
}
