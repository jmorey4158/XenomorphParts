using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Domain.Services
{
    public class EntityService : IEntityRepository
    {
        private readonly IEntityRepository _entityRepo;

        public EntityService(IEntityRepository entityRepository)
        {
            _entityRepo = entityRepository;
        }




        public List<IEntityDto> GetByEntityType(EntityType entityType)
        {
            return _entityRepo.GetByEntityType(entityType);
        }

        public IEntityDto GetById(string id)
        {
            return _entityRepo.GetById(id);
        }

        public IEntityDto GetByLocationId(string location)
        {
            return _entityRepo.GetByLocationId(location);
        }

        public List<IEntityDto> GetByName(EntityType entityType, string name)
        {
            return _entityRepo.GetByName(entityType, name);
        }

        public List<IEntityDto> GetByPlanet(EntityType entityType, string planet)
        {
            return _entityRepo.GetByPlanet(entityType, planet);
        }

        public List<IEntityDto> GetByPostalCode(EntityType entityType, string postal)
        {
            return _entityRepo.GetByPostalCode(entityType, postal);
        }

        public List<IEntityDto> GetByRegion(EntityType entityType, string region)
        {
            return _entityRepo.GetByRegion(entityType, region);
        }

        public List<IEntityDto> GetByState(EntityType entityType, string state)
        {
            return _entityRepo.GetByState(entityType, state);
        }

        public List<IEntityDto> GetBySystem(EntityType entityType, string system)
        {
            return _entityRepo.GetByState(entityType, system);
        }
    }
}
