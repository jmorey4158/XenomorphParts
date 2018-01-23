using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;

namespace XenomorphParts.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        CustomerDto GetById(long id);
        CustomerDto GetByName(string name);
        CustomerDto GetByLocationId(long location);
    }
}
