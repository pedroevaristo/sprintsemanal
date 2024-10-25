using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using mvc.Models;

namespace mvc.Services//aqui tem objtivo de fazer a configuração do banco de dados
{
    public class RegisterService
    {
        private readonly IMongoDatabase _database;

        public RegisterService(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
            BsonClassMap.RegisterClassMap<Register>(map => {
                map.AutoMap();
                map.MapCreator(c => new Register());
            });

        }

        public void Register(Register register)
        {
            var collection = _database.GetCollection<Register>("user");
            collection.InsertOne(register);
        }
        
    }
}
