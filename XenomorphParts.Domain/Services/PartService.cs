using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Domain.Services
{
    public class PartService : IPartRepository
    {
        private readonly IPartRepository _partRepository;

        public PartService(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public IPartDto GetById(long id)
        {
            return _partRepository.GetById(id);
        }

        public List<IPartDto> GetByVehicleModelId(long model)
        {
            return _partRepository.GetByVehicleModelId(model);
        }

        public List<IPartDto> GetByPartName(string name)
        {
            return _partRepository.GetByPartName(name);
        }

        public List<IPartDto> GetByManufacturerId(long maker)
        {
            return _partRepository.GetByManufacturerId(maker);
        }
        

        public List<IPartDto> GetByPartId(long partId)
        {
            return _partRepository.GetByPartId(partId);
        }
    }
}
