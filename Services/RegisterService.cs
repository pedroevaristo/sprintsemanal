using MongoDB.Driver;
using mvc.Models;

namespace mvc.Services//aqui tem objtivo de fazer a configuração do banco de dados
{
    public class RegisterService
    {
        public readonly IMongoCollection<Models.Register> _register;


        public RegisterService(IConfiguration configuration)//Conexão com o banco de dados Mas sempre de olho Como colocar entre parentees a localização da classe 
        {
            MongoClient cliente = new MongoClient(configuration.GetConnectionString("register"));
            IMongoDatabase database = cliente.GetDatabase("register");
            _register = database.GetCollection<Models.Register>("register");
        }
  
        
    }
}
