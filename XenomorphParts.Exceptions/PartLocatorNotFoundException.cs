using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class PartLocatorNotFoundException : Exception
    {
        public PartLocatorNotFoundException() { }
        public PartLocatorNotFoundException(string messsage) : base(messsage) { }
    }
}
