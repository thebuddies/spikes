using System;

namespace Concep.TableTennis.Domain.Service.Base
{
    public class OperationResult
    {
        public bool Success { get; set; }

        public Exception OperationException { get; set; }
    }
}