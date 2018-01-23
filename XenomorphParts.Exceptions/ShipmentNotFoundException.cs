using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class ShipmentNotFoundException : Exception
    {
        public ShipmentNotFoundException() { }
        public ShipmentNotFoundException(string message) : base(message) { }
    }
}
