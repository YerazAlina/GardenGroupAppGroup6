using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GardenGroupModel
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
      
        [BsonElement("FirstName")]
        public string FirstName { get; set; }
      
        [BsonElement("LastName")]
        public string LastName { get; set; }
       
        [BsonRepresentation(BsonType.String)]
        public TypeOfUser TypeOfUser { get; set; }
        
        [BsonElement("Email")]
        public string Email { get; set; }
      
        [BsonElement("Phone")]
        public string Phone { get; set; }
       
        [BsonRepresentation(BsonType.String)]
        public Branch Branch { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonConstructor]
        public User(ObjectId Id, string FirstName, string LastName, TypeOfUser TypeOfUser, string Email, string Phone, Branch Branch, string Password)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.TypeOfUser = TypeOfUser;
            this.Email = Email;
            this.Phone = Phone;
            this.Branch = Branch;
            this.Password = Password;
        }

        public User()
        {
        }
    }

    public enum TypeOfUser
    {
        Employee, ServiceDesk
    }

    public enum Branch
    {
        Headquarters, Haarlem, Amsterdam, Knuppeldam
    }
}