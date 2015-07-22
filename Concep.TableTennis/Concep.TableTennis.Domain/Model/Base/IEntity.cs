namespace Concep.TableTennis.Domain.Model.Base
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}