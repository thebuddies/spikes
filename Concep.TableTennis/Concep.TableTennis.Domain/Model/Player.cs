using Concep.TableTennis.Domain.Model.Base;

namespace Concep.TableTennis.Domain.Model
{
    public class Player : IEntity<string>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}