using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace mvc.Models
{
    public class Register//https://chatgpt.com/share/670ecb16-de30-800e-b159-8ad669f22cff
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Email")]
        public String Email { get; set; }
        
        [BsonElement("Password")]
        public String Password { get; set; }

        [BsonElement("passwordAdmins")]
        public String passwordAdmins { get; set; }
    }
}
