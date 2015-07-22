using Concep.TableTennis.Domain.Model.Base;
using Concep.TableTennis.Domain.Repository.Base;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Concep.TableTennis.Infrastructure.Repository.Base
{
    public class GenericReposiotry<TEntity> : IRepository<TEntity, string>
        where TEntity : class, IEntity<string>, new()
    {
        public GenericReposiotry()
        {
            var context = new MongoDbContext();
            this.MongoCollection = context.MongoDatabase.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        protected IMongoCollection<TEntity> MongoCollection { get; set; }

        public void Add(TEntity entity)
        {
            this.MongoCollection.InsertOneAsync(entity);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return this.MongoCollection.Find(new BsonDocument()).ToListAsync().Result;
        }
    }
}