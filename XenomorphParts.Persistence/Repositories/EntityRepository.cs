using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.DTO;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Exceptions;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {

        private static readonly IEntityDto _branchStore = new EntityDto()
        {
            Name = "Puldark Partshouse.1257",
            LocationId = "9807564",
            Id = "34567894",
            EntityType = Enum.GetName(typeof(EntityType), (int)EntityType.BranchStore),
            Notes = ""
        };
        private static readonly IEntityDto _customer = new EntityDto()
        {
            Name = "Timor Binyaq",
            LocationId = "4679402972",
            Id = "2092343092",
            EntityType = Enum.GetName(typeof(EntityType), (int)EntityType.Customer),
            Notes = ""
        };
        private static readonly IEntityDto _customer2 = new EntityDto()
        {
            Name = "Riflin Dumblogliq",
            LocationId = "4679403126",
            Id = "209234332",
            EntityType = Enum.GetName(typeof(EntityType), (int)EntityType.Customer),
            Notes = ""
        };
        private static readonly IEntityDto _manu = new EntityDto()
        {
            Name = "Andorian Dream",
            LocationId = "46745676826",
            Id = "198197563",
            EntityType = Enum.GetName(typeof(EntityType), (int)EntityType.Manufacturer),
            Notes = ""
        };



        public List<IEntityDto> GetByEntityType(EntityType entityType)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            switch (et)
            {
                case "BranchStore":
                    return new List<IEntityDto>() { _branchStore };

                case "Customer":
                    return new List<IEntityDto>() { _customer, _customer2 };

                case "Manufacturer":
                    return new List<IEntityDto>() { _manu };

                default:
                    throw new EntityNotFoundException($"No records not found for {nameof(IEntityDto.EntityType)}: {et}");
            }
        }

        public IEntityDto GetById(string id)
        {
            switch (id)
            {
                case "34567894":
                    return _branchStore;

                case "2092343092":
                    return _customer;

                case "209234332":
                    return _customer2;
                default:
                    throw new EntityNotFoundException($"No records not found for {nameof(IEntityDto.Id)}: {id}");
            }
        }

        public IEntityDto GetByLocationId(string location)
        {
            switch (location)
            {
                case "9807564":
                    return _branchStore;

                case "4679402972":
                    return _customer;

                case "4679403126":
                    return _customer2;
                default:
                    throw new EntityNotFoundException($"No records not found for {nameof(IEntityDto.LocationId)}: {location}");
            }
        }

        public List<IEntityDto> GetByName(EntityType entityType, string name)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ( (name.Contains("Puldark")) && (et == "BranchStore") )
                return new List<IEntityDto>() { _branchStore };

            else if ( (name.Contains("Binyaq")) && (et == "Customer") )
                return new List<IEntityDto>() { _customer };

            else if ((name.Contains("Dumblogliq")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for {nameof(IEntityDto.Name)}: {name} AND {nameof(IEntityDto.EntityType)}: {et}");

        }

        public List<IEntityDto> GetByPlanet(EntityType entityType, string planet)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ((planet.Contains("Puldark")) && (et == "BranchStore"))
                return new List<IEntityDto>() { _branchStore };

            else if ((planet.Contains("Puldark")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer, _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for Planet: {planet} AND {nameof(IEntityDto.EntityType)}: {et}");
        }

        public List<IEntityDto> GetByPostalCode(EntityType entityType, string postal)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ((postal.Contains("12345")) && (et == "BranchStore"))
                return new List<IEntityDto>() { _branchStore };

            else if ((postal.Contains("89076")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer, _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for Postal Code: {postal} AND {nameof(IEntityDto.EntityType)}: {et}");
        }

        public List<IEntityDto> GetByRegion(EntityType entityType, string region)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ((region.Contains("Talliga")) && (et == "BranchStore"))
                return new List<IEntityDto>() { _branchStore };

            else if ((region.Contains("Freemdo")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer, _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for Region: {region} AND {nameof(IEntityDto.EntityType)}: {et}");
        }

        public List<IEntityDto> GetByState(EntityType entityType, string state)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ((state.Contains("Regal")) && (et == "BranchStore"))
                return new List<IEntityDto>() { _branchStore };

            else if ((state.Contains("Regal")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer, _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for State: {state} AND {nameof(IEntityDto.EntityType)}: {et}");
        }

        public List<IEntityDto> GetBySystem(EntityType entityType, string system)
        {
            string et = Enum.GetName(typeof(EntityType), (int)entityType);

            if ((system.Contains("Sol")) && (et == "BranchStore"))
                return new List<IEntityDto>() { _branchStore };

            else if ((system.Contains("Sol")) && (et == "Customer"))
                return new List<IEntityDto>() { _customer, _customer2 };

            else
                throw new EntityNotFoundException($"No records not found for System: {system} AND {nameof(IEntityDto.EntityType)}: {et}");
        }
    }
}
