using Concep.TableTennis.Domain.Model;
using System.Collections.Generic;

namespace Concep.TableTennis.Models
{
    public class GameViewModel
    {
        public string Id { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}