namespace HelpQuest.Models
{
    public class Person
    {
        public Guid id { get; init; }
        public string name { get; set; }
        public DateTime dateBirth { get; set; }
        public string email { get; set; }
        
    }
}
