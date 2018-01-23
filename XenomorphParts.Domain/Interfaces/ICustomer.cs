using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface ICustomer
    {
        long CustomerId { get; }
        string Name { get; }
        long LocationId { get; }
    }
}
