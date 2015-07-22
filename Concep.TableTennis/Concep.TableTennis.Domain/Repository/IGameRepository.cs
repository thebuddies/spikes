using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Repository.Base;

namespace Concep.TableTennis.Domain.Repository
{
    public interface IGameRepository : IRepository<Game, string>
    {
    }
}