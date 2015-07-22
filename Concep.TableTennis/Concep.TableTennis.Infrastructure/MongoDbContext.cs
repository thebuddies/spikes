using Concep.TableTennis.Infrastructure.Contracts;
using Concep.TableTennis.Infrastructure.EntityMappings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concep.TableTennis.Infrastructure
{
    public class MongoDbContext : IMongoDbContext
    {
        public MongoDbContext()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["Drinkable.Mongolab"].ConnectionString;

            

            IMongoClient client = new MongoClient(connectionString);
            MongoDatabase = client.GetDatabase("table_tennis");
        }

        public IMongoDatabase MongoDatabase { get; set; }
    }
}
