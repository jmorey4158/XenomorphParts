using System;

namespace XenomorphParts.Exceptions
{
    public class AssemblyNotFoundException : Exception
    {
        public AssemblyNotFoundException() { }
        public AssemblyNotFoundException(string message) : base(message) { }
    }
}
