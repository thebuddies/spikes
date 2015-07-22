using Concep.TableTennis.Domain.Model;

namespace Concep.TableTennis.Domain.Service
{
    public interface IGameService
    {
        AddGameResponse AddGame(Game game);

        GetGamesResponse GetAllGames();
    }
}