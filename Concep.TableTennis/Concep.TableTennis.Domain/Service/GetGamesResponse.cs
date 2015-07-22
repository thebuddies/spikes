using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Service.Base;
using System.Collections.Generic;

namespace Concep.TableTennis.Domain.Service
{
    public class GetGamesResponse : OperationResult
    {
        public IEnumerable<Game> Games { get; set; }
    }
}