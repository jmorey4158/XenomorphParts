using System;

namespace XenomorphParts.Exceptions
{
    public class ParameterNullException : Exception
    {
        public ParameterNullException() { }
        public ParameterNullException(string message) : base(message) { }
    }
}
