using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Repository;
using Concep.TableTennis.Domain.Service;
using System;
using System.Collections.Generic;

namespace Concep.TableTennis.Infrastructure.Service
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            if (gameRepository == null) throw new ArgumentNullException("Game repository!");

            _gameRepository = gameRepository;
        }

        public AddGameResponse AddGame(Game game)
        {
            var response = new AddGameResponse();
            try
            {
                _gameRepository.Add(game);
                response.Game = game;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.OperationException = ex;
            }

            return response;
        }

        public GetGamesResponse GetAllGames()
        {
            var response = new GetGamesResponse();
            try
            {
                IEnumerable<Game> games = _gameRepository.FindAll();
                response.Games = games;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.OperationException = ex;
            }

            return response;
        }
    }
}