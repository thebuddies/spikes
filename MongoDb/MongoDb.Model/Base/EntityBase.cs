namespace MongoDb.Model.Base
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }
    }
}