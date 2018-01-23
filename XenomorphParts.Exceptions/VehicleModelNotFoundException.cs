using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class VehicleModelNotFoundException : Exception
    {
        public VehicleModelNotFoundException() { }
        public VehicleModelNotFoundException(string message) : base(message) { }
    }
}
