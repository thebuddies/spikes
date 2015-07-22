using Concep.TableTennis.Domain.Model.Base;
using System.Collections.Generic;

namespace Concep.TableTennis.Domain.Model
{
    public class Game : IEntity<string>
    {
        public string Id { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}