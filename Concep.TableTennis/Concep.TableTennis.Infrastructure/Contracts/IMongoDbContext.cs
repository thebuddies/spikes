using MongoDB.Driver;

namespace Concep.TableTennis.Infrastructure.Contracts
{
    public interface IMongoDbContext
    {
        IMongoDatabase MongoDatabase { get; set; }
    }
}