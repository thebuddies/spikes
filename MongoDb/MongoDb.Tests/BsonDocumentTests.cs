using System;
using MongoDb.Model;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using NUnit.Framework;

namespace MongoDb.Tests
{
    [TestFixture]
    public class BsonDocumentTests : AssertionHelper
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

        [Test]
        public void Automatic()
        {
            var user = new User
            {
                FirstName = "Peter",
                LastName = "Petrov",
                Username = "pesho",
                Age = 33
            };
            user.Address.Add("My home address");
            user.Address.Add("My work address");

            Console.WriteLine(user.ToJson());
        }

        [Test]
        public void TestObjectId()
        {
            var car = new Car
            {
                Make = "BMW"
            };

            Console.WriteLine(car.ToJson());
        }
    }
}