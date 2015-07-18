using MongoDB.Bson.Serialization;
using MongoDb.Model.Base;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDb.DataAccess.EntityMappings.Base;

namespace MongoDb.DataAccess.EntityMappings.Base
{
    public class EntityBaseMap : MongoDbClassMapperBase<EntityBase<string>>
    {
        public override void Map(BsonClassMap<EntityBase<string>> classMap)
        {
            classMap.AutoMap();
            classMap.SetIdMember(classMap.GetMemberMap(x => x.Id)
                  .SetIdGenerator(StringObjectIdGenerator.Instance));
        }
    }
}