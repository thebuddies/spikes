using System;
using System.Collections.Generic;
using MongoDb.DataAccess;
using MongoDb.Model;
using MongoDB.Bson;

namespace MongoDb.App
{
    public class Program
    {
        private static MongoDbContext _ctx;

        public static void Main()
        {
            _ctx = new MongoDbContext();

            InsertUsers(20);

            Console.WriteLine(GetCount());
        }

        public static void InsertUsers(int count)
        {
            List<User> users = new List<User>(count);
            for (int i = 0; i < count; i++)
            {
                var user = new User
                {
                    Username = "user_" + i,
                    FirstName = "firstName_" + i,
                    LastName = "lastName" + i,
                    Age = 10 + i,
                    Address = new List<string>() { "address_" + i }
                };

                users.Add(user);
            }

            _ctx.Users.InsertManyAsync(users);
        }

        public static long GetCount()
        {
            return _ctx.Users.CountAsync(new BsonDocument()).Result;
        }
    }
}