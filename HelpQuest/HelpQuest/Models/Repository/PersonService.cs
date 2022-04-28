using HelpQuest.Mongo;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HelpQuest.Models.Repository
{
    public class PersonService
    {
        private readonly IMongoCollection<Person> _personCollection;

        public PersonService(IOptions<Crud> crud)
        {
            var mongoClient = new MongoClient(crud.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(crud.Value.DatabaseName);
  
            // person collection
            _personCollection = mongoDatabase.GetCollection<Person>("Person");
        }

        /*
           Person Collections
        */
        public async Task CreateAsync (Person person) =>
            await _personCollection.InsertOneAsync(person);
        public async Task DeleteAsync(string email,Person person) =>
            await _personCollection.DeleteOneAsync(x => x.Email == email);
        public async Task UpadateAsync(string email, Person person) =>
            await _personCollection.ReplaceOneAsync(x => x.Email == email, person);
        public async Task<Person> GetByIdAsync(Guid id) =>
            await _personCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        public async Task<Person> GetAsync() =>
            await _personCollection.Find(c => true).FirstOrDefaultAsync();  

    }
}
