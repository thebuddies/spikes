using Concep.TableTennis.Domain.Model;
using Concep.TableTennis.Domain.Service.Base;

namespace Concep.TableTennis.Domain.Service
{
    public class AddGameResponse : OperationResult
    {
        public Game Game { get; set; }
    }
}