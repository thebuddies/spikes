using MongoDb.DataAccess.EntityMappings.Base;
using MongoDb.Model;
using MongoDB.Bson.Serialization;

namespace MongoDb.DataAccess.EntityMappings
{
    public class UserMap : MongoDbClassMapperBase<User>
    {
        public override void Map(BsonClassMap<User> classMap)
        {
            classMap.AutoMap();
        }
    }
}