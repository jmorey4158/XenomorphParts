using System;
using System.Collections.Generic;
using System.Text;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() { }
        public EntityNotFoundException(string message) : base(message) { }
    }
}
