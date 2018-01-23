using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IEntityRepository
    {
        IEntityDto GetById(string id);
        IEntityDto GetByLocationId(string location);

        List<IEntityDto> GetByName(EntityType entityType,string name);
        List<IEntityDto> GetBySystem(EntityType entityType, string system);
        List<IEntityDto> GetByPlanet(EntityType entityType, string planet);
        List<IEntityDto> GetByRegion(EntityType entityType, string region);
        List<IEntityDto> GetByState(EntityType entityType, string state);
        List<IEntityDto> GetByPostalCode(EntityType entityType, string postal);
        List<IEntityDto> GetByEntityType(EntityType entityType);
    }
}
