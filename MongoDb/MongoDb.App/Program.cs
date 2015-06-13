using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDb.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("mydb");
            var collection = database.GetCollection<BsonDocument>("users");
            var filter = new BsonDocument("username", new BsonDocument("$eq", "pesho"));
            var documents = collection.Find(filter).ToListAsync();
        }
    }
}