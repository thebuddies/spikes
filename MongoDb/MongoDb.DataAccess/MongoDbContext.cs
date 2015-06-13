using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDb.DataAccess
{
    public class MongoDbContext
    {
        public MongoDbContext()
        {
            IMongoClient client = new MongoClient("mongodb://localhost");
            MongoDatabase = client.GetDatabase("mydb");
        }

        public IMongoDatabase MongoDatabase { get; set; }

        public IMongoCollection<BsonDocument> Users
        {
            get { return MongoDatabase.GetCollection<BsonDocument>("users"); }
        }
    }
}