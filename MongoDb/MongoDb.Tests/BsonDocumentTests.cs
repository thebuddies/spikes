using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;

namespace MongoDb.Tests
{
    [TestFixture]
    public class BsonDocumentTests
    {
        public BsonDocumentTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void EmptryDocument()
        {
            var document = new BsonDocument();

            Console.WriteLine(document);
        }

        [Test]
        public void AddElements()
        {
            var user = new BsonDocument
            {
                {"username", new BsonString("ivancho")},
                {"age", new BsonInt32(33)}
            };

            user.Add("firstName", new BsonString("Ivan"));

            Console.WriteLine(user);
        }
    }
}