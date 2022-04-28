using HelpQuest.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace HelpQuest.Mongo
{
    public class Crud
    {

        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
