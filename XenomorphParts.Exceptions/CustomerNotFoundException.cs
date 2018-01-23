using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException() { }
        public CustomerNotFoundException(string message) : base(message) { }
    }

}
