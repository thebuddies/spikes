using System;
using System.Collections.Generic;
using System.Threading;
using MongoDb.DataAccess;
using MongoDb.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace MongoDb.App
{
    public class Program
    {
        private static MongoDbContext _ctx;

        public static void Main()
        {
            _ctx = new MongoDbContext();

            var user = new User
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Username = "tester____"
            };

            _ctx.Users.InsertOneAsync(user);

            //InsertUsers(5);

            Thread.Sleep(2000);

            Console.WriteLine(GetCount());
        }

        public static void InsertUsers(int count)
        {
            List<User> users = new List<User>(count);
            for (int i = 0; i < count; i++)
            {
                var user = new User
                {
                    //Id = ObjectId.GenerateNewId().ToString(),
                    Username = "user_" + i,
                    FirstName = "firstName_" + i,
                    LastName = "lastName" + i,
                    Age = 10 + i,
                };

                users.Add(user);
            }

            _ctx.Users.InsertManyAsync(users);
            Console.WriteLine("Inserting...");
        }

        public static long GetCount()
        {
            return _ctx.Users.CountAsync(new BsonDocument()).Result;
        }
    }
}