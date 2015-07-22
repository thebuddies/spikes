using Concep.TableTennis.Domain.Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Concep.TableTennis.Infrastructure.EntityMappings
{
    public class GameMap
    {
        public GameMap()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Game)))
            {
                BsonClassMap.RegisterClassMap<Game>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIdMember(cm.GetMemberMap(x => x.Id)
                        .SetIdGenerator(StringObjectIdGenerator.Instance));
                });
            }
        }
    }
}