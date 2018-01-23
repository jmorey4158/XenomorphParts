using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IEntityDto
    {
        string Id { get; }
        string Name { get; }
        string Notes { get; }
        string LocationId { get; }
        string EntityType { get; }
    }
}
