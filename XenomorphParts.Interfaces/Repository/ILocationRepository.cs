using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface ILocationRepository
    {
        ILocationDto GetById(string id);
        List<ILocationDto> GetByGalaxy(string galaxy);
        List<ILocationDto> GetBySystem(string system);
        List<ILocationDto> GetByPlanet(string planet);
        List<ILocationDto> GetByRegion(string region);
        List<ILocationDto> GetByState(string state);
        List<ILocationDto> GetByPostalCode(string postal);

    }
}
