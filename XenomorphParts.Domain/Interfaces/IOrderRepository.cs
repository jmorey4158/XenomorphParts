using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IOrderRepository
    {
        OrderDto GetById(long id);
        List<OrderDto> GetByCustomer(string customer);
        List<OrderDto> GetByDate(string date);
        List<OrderDto> GetByDateRange(string beginDate, string endDate);
        List<OrderDto> GetByVehicleMaker(string maker);
        List<OrderDto> GetByVehicleModel(string model);
        List<OrderDto> GetByModelandYear(string model, int year);
        List<OrderDto> GetByPropulsionType(string propType);
        List<OrderDto> GetByPartName(string name);
    }
}

