using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Service;
using Concep.TableTennis.Models;
using System;
using System.Web.Http;

namespace Concep.TableTennis.Controllers
{
    public class GamesController : ApiController
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            if (gameService == null) throw new ArgumentNullException("IGameService");

            _gameService = gameService;
        }

        [HttpGet]
        [Route("api/games")]
        public IHttpActionResult Get()
        {
            var response = _gameService.GetAllGames();

            if (response.Success)
            {
                return this.Ok(response.Games);
            }

            return this.InternalServerError(response.OperationException);
        }

        [HttpPost]
        [Route("api/games")]
        public IHttpActionResult Post(GameViewModel model)
        {

            var game = new Game
            {
                Players = model.Players
            };

            _gameService.AddGame(game);

            return this.Ok();
        }
    }
}