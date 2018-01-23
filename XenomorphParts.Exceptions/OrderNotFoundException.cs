using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class OrderNotFoundException : Exception
    {
        public OrderNotFoundException() { }
        public OrderNotFoundException(string message) : base(message) { }
    }
}
