using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class ManufacturerNotFoundException : Exception
    {
        public ManufacturerNotFoundException() { }
        public ManufacturerNotFoundException(string message) : base(message) { }
    }
}
