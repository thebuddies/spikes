using MongoDb.DataAccess.EntityMappings;
using MongoDb.Model;
using MongoDB.Driver;

namespace MongoDb.DataAccess
{
    public class MongoDbContext
    {
        public MongoDbContext()
        {
            //var userMap = new UserMap();
            //var entityBaseMap = new EntityBaseMap();
            var mongoDbMappings = new MongoDbMappings();
            mongoDbMappings.InitialiseMappings();

            //IMongoClient client = new MongoClient("mongodb://admin:admin@ds036178.mongolab.com:36178/test");
            IMongoClient client = new MongoClient("mongodb://localhost:27017");
            MongoDatabase = client.GetDatabase("test");
        }

        public IMongoDatabase MongoDatabase { get; set; }

        public IMongoCollection<User> Users
        {
            get { return MongoDatabase.GetCollection<User>(typeof(User).Name); }
        }
    }
}