using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IOrderSummaryRepository
    {
        OrderSummaryDto GetById(long id);
        List<OrderSummaryDto> GetByCustomer(string customer);
        List<OrderSummaryDto> GetByDate(string date);
    }
}
