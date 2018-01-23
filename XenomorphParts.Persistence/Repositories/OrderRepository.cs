using System;
using System.Collections.Generic;
using XenomorphParts.DTO;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;


namespace XenomorphParts.Persistence.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private static readonly IPartDto _partDto1001 = new PartDto()
        {
            Id = 1001,
            Name = "Andorian Plugal Snapring",
            Description = "Fastens the Andorian Plugal Ring to the Sensor Array. Order in sets of 4.",
            ManufacturerId = "8901234",
            VehicleModelId = 123456789,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 160,
            Reserved = 14,
            LocatorAvailable = 240
        };
        private static readonly IPartDto _partDto1313456 = new PartDto()
        {
            Id = 1313456,
            Name = "Andorian Anti-Matter Injector",
            Description = "Injects anti-matter into Warp Core Reactor Chamber. Also compatible with Exzedian Warp Core Chambers. Order in sets of 3.",
            ManufacturerId = "8901234",
            VehicleModelId = 123456789,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 300,
            Reserved = 33,
            LocatorAvailable = 180
        };

        private static readonly IOrderItemDto _orderItem1 = new OrderItemDto()
        {
            PartId = 1313456,
            Quantity = 4,
            ShipmentType = "Partial",
            ShipmentNotes = "Order was for 8, but we only had 4. Remained will be shipped when available."
        };
        private static readonly IOrderItemDto _orderItem2 = new OrderItemDto()
        {
            PartId = 1001,
            Quantity = 9,
            ShipmentType = "Complete",
            ShipmentNotes = "Shipped directly to store."
        };

        private static readonly List<IOrderItemDto> _orderItemsList = new List<IOrderItemDto>()
        {
            _orderItem1,
            _orderItem2
        };

        private static readonly IOrderDto _orderDto = new OrderDto()
        {
            Id = 345879,
            ReferenceOrderId = 289765,
            Name = "Laxclug'gug - 345879",
            Notes = "Andorian Warp Core Drive parts for Dominion Police vehicle. Please RUSH.",
            CustomerId = 56789013,
            Total = 45972.21M,
            OrderItems = _orderItemsList,
            OrderDate = "2336.06.11",
            ShipmentId = 435678
        };


        // METHODS

        public IOrderDto GetById(long id)
        {
            if (id == 345879)
                return _orderDto;
            else
                throw new OrderNotFoundException($"Order {id} not found.");
        }


        public List<IOrderDto> GetByCustomerId(long customerId)
        {
            if (customerId == 56789013)
                return new List<IOrderDto>() { _orderDto };
            else
                throw new OrderNotFoundException($"Order for {nameof(_orderDto.CustomerId)} {customerId} not found.");
        }

        public List<IOrderDto> GetByDateRange(DateTime start, DateTime end)
        {
            var orderDate = DateTime.Parse(_orderDto.OrderDate);
            List<IOrderDto> dtoList = new List<IOrderDto>();

            if ((orderDate >= start) && (orderDate <= end))
                dtoList.Add(_orderDto);

            if (dtoList.Count > 0)
                return dtoList;
            else
                throw new OrderNotFoundException($"Order for {nameof(IOrderDto.OrderDate)}: between {start.ToString("yyyy.MM.dd")} and {end.ToString("yyyy.MM.dd")} not found.");

        }

        public List<IOrderDto> GetByDate(DateTime date)
        {
            switch (date.ToString("yyyy.MM.dd"))
            {
                case "2336.06.11":
                    return new List<IOrderDto>() { _orderDto };

                default:
                    throw new OrderNotFoundException($"Order processed on {date.ToString("yyyy.MM.dd")} not found.");
            }
        }

        public List<IOrderDto> GetByReferenceOrderId(long refId)
        {
            switch (refId)
            {
                case 289765:
                    return new List<IOrderDto>() { _orderDto };

                default:
                    throw new OrderNotFoundException($"Order for {nameof(_orderDto.ReferenceOrderId)}: {refId} not found.");
            }
        }

        public List<IOrderDto> GetByShipmentId(long shipmentId)
        {
            switch (shipmentId)
            {
                case 435678:
                    return new List<IOrderDto>() { _orderDto };

                default:
                    throw new OrderNotFoundException($"Order for {nameof(_orderDto.ShipmentId)}: {shipmentId} not found.");
            }
        }

        public List<IOrderDto> GetByName(string name)
        {
            if(name.Contains("Laxclug"))
                return new List<IOrderDto>() { _orderDto };
            else
                throw new OrderNotFoundException($"Order for {nameof(_orderDto.Name)} {name} not found.");
        }

        public List<IOrderDto> GetByCustomerName(string name)
        {
            if (name.Contains("Dominion"))
                return new List<IOrderDto>() { _orderDto };
            else
                throw new OrderNotFoundException($"Order for Customer Name {name} not found.");
        }
    }
}
