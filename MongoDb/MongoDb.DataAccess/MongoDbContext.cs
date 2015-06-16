using MongoDb.Model;
using MongoDB.Driver;

namespace MongoDb.DataAccess
{
    public class MongoDbContext
    {
        public MongoDbContext()
        {
            IMongoClient client = new MongoClient("mongodb://admin:admin@ds036178.mongolab.com:36178/test");
            MongoDatabase = client.GetDatabase("test");
        }

        public IMongoDatabase MongoDatabase { get; set; }

        public IMongoCollection<User> Users
        {
            get { return MongoDatabase.GetCollection<User>("users"); }
        }
    }
}