using System;
using System.Collections.Generic;
using XenomorphParts.DTO;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Persistence.Repositories
{
    public class OrderSummaryRepository : IOrderSummaryRepository
    {
        private readonly IPartDto _partDto1001 = new PartDto()
        {
            Id = 1001,
            Name = "Andorian Plugal Snapring",
            Description = "Fastens the Andorian Plugal Ring to the Sensor Array. Order in sets of 4.",
            ManufacturerId = "8901234",
            VehicleModelId = 123456798,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 160,
            Reserved = 14,
            LocatorAvailable = 240
        };
        private readonly IPartDto _partDto1313456 = new PartDto()
        {
            Id = 1313456,
            Name = "Andorian Anti-Matter Injector",
            Description = "Injects anti-matter into Warp Core Reactor Chamber. Also compatible with Exzedian Warp Core Chambers. Order in sets of 3.",
            ManufacturerId = "8901234",
            VehicleModelId = 123456798,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 300,
            Reserved = 33,
            LocatorAvailable = 180
        };

        private readonly IOrderSummaryDto _orderSummary1 = new OrderSummaryDto()
        {
            OrderId = 123456,
            OrderName = "Alexis Draft - 123456",
            OrderDate = "2336.07.14",
            Total = 345678.98M,
            ShipmentId = 1234567,
            ItemsCount = 21
        };
        private readonly IOrderSummaryDto _orderSummary2 = new OrderSummaryDto()
        {
            OrderId = 34567,
            OrderName = "Alexis Draft - 34567",
            OrderDate = "2338.07.14",
            Total = 14678.98M,
            ShipmentId = 98075643,
            ItemsCount = 117
        };


        public List<IOrderSummaryDto> GetByOrderName(string name)
        {
            switch (name)
            {
                case "Alexis Draft - 123456":
                    return new List<IOrderSummaryDto>() { _orderSummary1 };

                case "Alexis Draft - 34567":
                    return new List<IOrderSummaryDto>() { _orderSummary2 };

                default:
                    throw new OrderSummaryNotFoundException($"Order Summary for {nameof(IOrderSummaryDto.OrderName)} {name} not found.");
            }
        }

        public IOrderSummaryDto GetById(long id)
        {
            switch (id)
            {
                case 34567:
                    return _orderSummary2;

                case 123456:
                    return _orderSummary1;

                default:
                    throw new OrderSummaryNotFoundException($"Order Summary: {id} not found.");
            }
        }

        public List<IOrderSummaryDto> GetByDate(DateTime date)
        {
            switch (date.ToString("yyyy.MM.dd"))
            {
                case "2338.07.14":
                    return new List<IOrderSummaryDto>() { _orderSummary2 };

                case "2336.07.14":
                    return new List<IOrderSummaryDto>() { _orderSummary1 };

                default:
                    throw new OrderSummaryNotFoundException($"Order Summary for {nameof(IOrderSummaryDto.OrderDate)}: {date.ToString("yyyy.MM.dd")} not found.");
            }
        }

        public List<IOrderSummaryDto> GetByShipmentId(long shipment)
        {
            switch (shipment)
            {
                case 1234567:
                    return new List<IOrderSummaryDto>() { _orderSummary1 };

                case 98075643:
                    return new List<IOrderSummaryDto>() { _orderSummary2 };

                default:
                    throw new OrderSummaryNotFoundException($"Order Summary for {nameof(IOrderSummaryDto.ShipmentId)}: {shipment} not found.");
            }
        }

        public List<IOrderSummaryDto> GetByDateRange(DateTime start, DateTime end)
        {
            var orderDate1 = DateTime.Parse(_orderSummary1.OrderDate);
            var orderDate2 = DateTime.Parse(_orderSummary2.OrderDate);
            List<IOrderSummaryDto> dtoList = new List<IOrderSummaryDto>();

            if ((orderDate1 >= start) && (orderDate1 <= end))
                dtoList.Add( _orderSummary1 );

            if ((orderDate2 >= start) && (orderDate2 <= end))
                dtoList.Add(_orderSummary2);

            if (dtoList.Count > 0)
                return dtoList;
            else
                throw new OrderSummaryNotFoundException($"Order Summary for {nameof(IOrderSummaryDto.OrderDate)}: between {start.ToString("yyyy.MM.dd")} and {end.ToString("yyyy.MM.dd")} not found.");
        }
    }
}
