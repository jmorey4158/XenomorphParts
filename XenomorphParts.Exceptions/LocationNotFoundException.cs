using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class LocationNotFoundException : Exception
    {
        public LocationNotFoundException() { }
        public LocationNotFoundException(string message) : base(message) { }
    }
}
