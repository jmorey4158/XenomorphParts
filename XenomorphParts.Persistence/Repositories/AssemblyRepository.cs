using System.Collections.Generic;
using XenomorphParts.DTO;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Exceptions;


namespace XenomorphParts.Persistence.Repositories
{
    public class AssemblyRepository : IAssemblyRepository
    {
        private static readonly IPartDto _part1 = new PartDto()
        {
            Id = 8765409809,
            Name = "Andorian HyperDrive Primary Fuel Injector",
            Description = "Rule: Order in lots of 4",
            ManufacturerId = "8990174",
            VehicleModelId = 2099280280,
            WholesalePrice = 123.45M,
            RetailPrice = 313.45M,
            Available = 104,
            LocatorAvailable = 3416,
            Reserved = 44
        };
        private static readonly IPartDto _part2 = new PartDto()
        {
            Id = 8765409906,
            Name = "Andorian HyperDrive Secondary Fuel Injector",
            Description = "Rule: Order in lots of 8",
            ManufacturerId = "Andorian Dream",
            VehicleModelId = 2099280280,
            WholesalePrice = 86.45M,
            RetailPrice = 117.45M,
            Available = 160,
            LocatorAvailable = 480,
            Reserved = 24
        };
        private static readonly IPartDto _part3 = new PartDto()                                                        
        {
            Id = 8765092380,
            Name = "Andorian HyperDrive Injector Seals - Andorian Qeqlak Stone",
            Description = "Rule: Order in lots of 12",
            ManufacturerId = "Andorian Dream",
            VehicleModelId = 2099280280,
            WholesalePrice = 5.45M,
            RetailPrice = 17.45M,
            Available = 1212,
            LocatorAvailable = 480,
            Reserved = 84
        };

        private static readonly IAssemblyDto _asdto1 = new AssemblyDto()
        {
            Id = 1234567,
            Name = "Andorian HyperDrive Injection Maintenance Kit",
            Notes = "RULE: Order 1 kit per HyperDrive Unit. The kit contains: 4x Primary Fuel Injectors, 12x Secondary Fuel Injectors, and Seals.",
            ManufacturerId = "8990174",
            ModelId = 2093843098,
            Components = new List<IPartDto>() { _part1, _part2, _part3 },
            Parent = 1234576,
            SubAssemblies = new List<long>() { 2093849024, 202984092848, 20943840982098 }
        };


        public IAssemblyDto GetById(long id)
        {
            if (id == 1234567)
                return _asdto1;
            else
                throw new AssemblyNotFoundException($"Assembly not found for {nameof(IAssemblyDto.Id)}: {id}. ");
        }

        public IEnumerable<IAssemblyDto> GetByManufacturerId(string manufacturer)
        {
            if (manufacturer == "8990174")
                return new List<IAssemblyDto>() { _asdto1 };
            else
                throw new AssemblyNotFoundException($"Assembly not found for {nameof(IAssemblyDto.ManufacturerId)}: {manufacturer}. ");
        }

        public IEnumerable<IAssemblyDto> GetByModelId(long model)
        {
            if (model == 2093843098)
                return new List<IAssemblyDto>() { _asdto1 };
            else
                throw new AssemblyNotFoundException($"Assembly not found for {nameof(IAssemblyDto.ModelId)}: {model}. ");
        }

        public IEnumerable<IAssemblyDto> GetByName(string name)
        {
            if (name.Contains("Andorian HyperDrive Injection"))
                return new List<IAssemblyDto>() { _asdto1 };
            else
                throw new AssemblyNotFoundException($"Assembly not found for {nameof(IAssemblyDto.Name)}: {name}. ");
        }

        public IEnumerable<IAssemblyDto> GetByParent(long parent)
        {
            if (parent == 1234576)
                return new List<IAssemblyDto>() { _asdto1 };
            else
                throw new AssemblyNotFoundException($"Assembly not found for {nameof(IAssemblyDto.Parent)}: {parent}. ");
        }

        public IEnumerable<IAssemblyDto> GetByPartId(long part)
        {
            foreach(var p in _asdto1.Components)
            {
                if (part == p.Id)
                    return new List<IAssemblyDto>() { _asdto1 };
            } 

            throw new AssemblyNotFoundException($"Assembly not with Part: {part}. ");
        }
    }
}
