using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IAssemblyRepository
    {
        IAssemblyDto GetById(long id);
        IEnumerable<IAssemblyDto> GetByManufacturerId(string manufacturer);
        IEnumerable<IAssemblyDto> GetByName(string name);
        IEnumerable<IAssemblyDto> GetByModelId(long model);
        IEnumerable<IAssemblyDto> GetByParent(long parent);
        IEnumerable<IAssemblyDto> GetByPartId(long part);
    }
}
