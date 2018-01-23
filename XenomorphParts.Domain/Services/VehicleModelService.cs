using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Domain.Services
{
    public class VehicleModelService
    {
        private readonly IVehicleModelRepository _modelRepo;

        public VehicleModelService(IVehicleModelRepository vehicleModelRepository)
        {
            _modelRepo = vehicleModelRepository;
        }




        public IVehicleModelDto GetById(long id)
        {
            return _modelRepo.GetById(id);
        }

        public List<IVehicleModelDto> GetByManufacturerId(long maker)
        {
            return _modelRepo.GetByManufacturerId(maker);
        }

        public List<IVehicleModelDto> GetByName(string name)
        {
            return _modelRepo.GetByName(name);
        }

        public List<IVehicleModelDto> GetByYear(int year)
        {
            return _modelRepo.GetByYear(year);
        }
    }
}
