using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IOrderSummary
    {
        long OrderId { get; }
        string OrderName { get; }
        string Customer { get; }
        decimal Total { get; }
        string OrderDate { get; }
    }
}
