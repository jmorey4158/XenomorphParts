using System;
using System.Collections.Generic;
using XenomorphParts.DTO;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Persistence.Repositories
{
    public class ShipmentRepository : IShipmentRepository
    {
        private readonly IShipmentDto _ship10010 = new ShipmentDto()
        {
            Id = 10010,
            OrderId = 1213,
            CustomerId = 8901234,
            LocationId = 2309871,
            ShipmentType = "Complete",
            ShipmentMethod = "EstrangedParticleBump",
            ShipmentStatus = "Packed",
            DateShipped = "2367.07.01",
            DateReceived = "2367.07.11"
        };

        private readonly IShipmentDto _ship23456 = new ShipmentDto()
        {
            Id = 23456,
            OrderId = 3417,
            CustomerId = 8901234,
            LocationId = 2309871,
            ShipmentType = "Complete",
            ShipmentMethod = "SubspaceTransport",
            ShipmentStatus = "Packed",
            DateShipped = "2367.06.01",
            DateReceived = "2367.07.09"
        };



        public IShipmentDto GetById(long id)
        {
            switch (id)
            {
                case 10010:
                    return _ship10010;

                case 23456:
                    return _ship23456;

                default:
                    throw new ShipmentNotFoundException($"Shipment {id} could not be found.");
            }
        }


        public IShipmentDto GetByOrderId(long orderId)
        {
            switch (orderId)
            {
                case 1213:
                    return _ship10010;

                case 3417:
                    return _ship23456;

                default:
                    throw new ShipmentNotFoundException($"Shipments for Order ID {orderId} could not be found.");
            }
        }


        public List<IShipmentDto> GetByMethod(string method)
        {
            switch (method)
            {
                case "EstrangedParticleBump":
                    {
                        return new List<IShipmentDto>()
                        {
                            _ship10010
                        };
                    }

                case "SubspaceTransport":
                    {
                        return new List<IShipmentDto>()
                        {
                            _ship10010
                        };
                    }

                default:
                    throw new ShipmentNotFoundException($"Shipments for Shipment Method {method} could not be found.");
            }
        }


        public List<IShipmentDto> GetByType(string type)
        {
            switch (type)
            {
                case "Complete":
                    {
                        return new List<IShipmentDto>()
                        {
                            _ship10010,
                            _ship23456
                        };
                    }
                default:
                    throw new ShipmentNotFoundException($"Shipments for Type {type} could not be found.");
            }
        }

        public List<IShipmentDto> GetByStatus(string status)
        {
            switch (status)
            {
                case "Packed":
                    {
                        return new List<IShipmentDto>()
                        {
                            _ship23456,
                            _ship10010
                        };
                    }
                default:
                    throw new ShipmentNotFoundException($"Shipments for Status {status} could not be found.");
            }
        }


        public List<IShipmentDto> GetByReceivedDate(DateTime receivedDate)
        {
            switch (receivedDate.ToString("yyy.MM.dd"))
            {
                case "2367.07.11":
                    {
                        return new List<IShipmentDto>() { _ship10010 };
                    }

                case "2367.07.09":
                    {
                        return new List<IShipmentDto>() { _ship23456 };
                    }

                default:
                    throw new ShipmentNotFoundException($"Shipments for Received Date {receivedDate} could not be found.");
            }
        }

        public List<IShipmentDto> GetByShippedDate(DateTime shipDate)
        {
            switch (shipDate.ToString("yyy.MM.dd"))
            {
                case "2367.06.01":
                    {
                        return new List<IShipmentDto>() { _ship23456 };
                    }

                case "2367.07.01":
                    {
                        return new List<IShipmentDto>() { _ship10010 };
                    }

                default:
                    throw new ShipmentNotFoundException($"Shipments for Received Date {shipDate} could not be found.");
            }
        }

        public List<IShipmentDto> GetByCustomerId(long customerId)
        {
            if (customerId == 8901234)
                return new List<IShipmentDto>() { _ship10010, _ship23456 };
            else
                throw new ShipmentNotFoundException($"Shipments for Customer {customerId} could not be found.");
        }

        public List<IShipmentDto> GetByCustomerIdAndShippedDate(long customer, DateTime shipDate)
        {
            if ( (customer == 8901234) && (shipDate.ToString("yyy.MM.dd") == "2367.06.01") )
                return new List<IShipmentDto>() { _ship23456 };
            else if ((customer == 8901234) && (shipDate.ToString("yyy.MM.dd") == "2367.07.01"))
                return new List<IShipmentDto>() { _ship10010 };
            else
                throw new ShipmentNotFoundException($"Shipments for Customer {customer} and Shipped Date {shipDate}could not be found.");
        }

        public List<IShipmentDto> GetByCustomerIdAndStatus(long customer, string status)
        {
            if ((customer == 8901234) && (status == "Packed"))
                return new List<IShipmentDto>() { _ship10010, _ship23456 };
            else
                throw new ShipmentNotFoundException($"Shipments for Customer {customer} and Status {status} could not be found.");
        }
    }
}
