using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class PartNotFoundException : Exception
    {
        public PartNotFoundException() { }

        public PartNotFoundException(string message) : base(message) { }

    }
}
