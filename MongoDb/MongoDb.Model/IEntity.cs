namespace MongoDb.Model
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}