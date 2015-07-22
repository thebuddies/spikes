using Concep.TableTennis.Domain.Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Concep.TableTennis.Infrastructure.EntityMappings
{
    public class PlayerMap
    {
        public PlayerMap()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Player)))
            {
                BsonClassMap.RegisterClassMap<Player>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIdMember(cm.GetMemberMap(x => x.Id)
                        .SetIdGenerator(StringObjectIdGenerator.Instance));
                });
            }
        }
    }
}