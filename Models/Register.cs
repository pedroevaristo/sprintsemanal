using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Register//https://chatgpt.com/share/670ecb16-de30-800e-b159-8ad669f22cff
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Email")]
        [Display(Name = "Email Corporativo")]
        public string Email { get; set; }

        [BsonElement("Password")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [BsonElement("PasswordAdmins")]
        [Display(Name = "Senha de Administrador")]
        public string PasswordAdmins { get; set; }

        [BsonElement("CEP")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [BsonElement("PositionUser")]
        [Display(Name = "Cargo do Usuário")]
        public string PositionUser { get; set; }

        [BsonElement("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [BsonElement("IdUser")]
        [Display(Name = "Identificação do Usuário")] // aqui será no formato que estiver do email como exemplo: jose.clezio@animaeducacao.com.br || jose.clezio
        public string IdUser { get; set; }

        [BsonElement("AdmissionDate")]
        [Display(Name = "Data de Admissão")]
        public string AdmissionDate { get; set; }

        [BsonElement("DateOfBirth")]
        [Display(Name = "Data de Nascimento")]
        public string DateOfBirth { get; set; }
    } 
}
