using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Common.Contracts
{
    public interface IIdentifiableEntity
    {
        int EntityId { get; set; }        
    }
}
