using MongoDB.Bson.Serialization.Attributes;

namespace HelpQuest.Models
{
    public class Person
    {
        [BsonId]
        public Guid Id { get; init; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("dateBirth")]
        public DateTime DateBirth { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        
    }
}
