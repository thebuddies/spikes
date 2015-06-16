using MongoDB.Bson;

namespace MongoDb.Tests
{
    public class Car
    {
        public ObjectId Id { get; set; }
        public string Make { get; set; }
    }
}