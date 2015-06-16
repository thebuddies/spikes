using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb.Model
{
    public class User
    {
        public User()
        {
            this.Address = new List<string>();
        }

        [BsonId]
        public ObjectId Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public ICollection<string> Address { get; set; }
    }
}