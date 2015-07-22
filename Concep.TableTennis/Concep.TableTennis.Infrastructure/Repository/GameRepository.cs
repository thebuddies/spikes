using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Repository;
using Concep.TableTennis.Infrastructure.Repository.Base;

namespace Concep.TableTennis.Infrastructure.Repository
{
    public class GameRepository : GenericReposiotry<Game>, IGameRepository
    {
    }
}