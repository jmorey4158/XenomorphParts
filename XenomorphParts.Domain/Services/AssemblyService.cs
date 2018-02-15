using System.Collections.Generic;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Interfaces.DTO;


namespace XenomorphParts.Domain.Services
{
    public class AssemblyService : IAssemblyRepository
    {
        private IAssemblyRepository _assemRepo;

        public AssemblyService(IAssemblyRepository assemblyRepository)
        {
            _assemRepo = assemblyRepository;
        }

        public IAssemblyDto GetById(long id)
        {
            return _assemRepo.GetById(id);
        }

        public IEnumerable<IAssemblyDto> GetByManufacturerId(string manufacturer)
        {
            return _assemRepo.GetByManufacturerId(manufacturer);
        }

        public IEnumerable<IAssemblyDto> GetByModelId(long model)
        {
            return _assemRepo.GetByModelId(model);
        }

        public IEnumerable<IAssemblyDto> GetByName(string name)
        {
            return _assemRepo.GetByName(name);
        }

        public IEnumerable<IAssemblyDto> GetByParent(long parent)
        {
            return _assemRepo.GetByParent(parent);
        }

        public IEnumerable<IAssemblyDto> GetByPartId(long part)
        {
            return _assemRepo.GetByPartId(part);
        }
    }
}
