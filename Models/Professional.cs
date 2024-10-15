namespace mvc.Models
{
    public class Professional//Dados que o profissional deve ter no banco de dados
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string specialization { get; set; }
        public string localization {  get; set; }
        public List<Schudele> Schudele { get; set; }
    }
}
