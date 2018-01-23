using System;
using System.Runtime.Serialization;

namespace XenomorphParts.Exceptions
{
    [Serializable]
    public class OrderSummaryNotFoundException : Exception
    {
        public OrderSummaryNotFoundException()
        {
        }

        public OrderSummaryNotFoundException(string message) : base(message)
        {
        }

        public OrderSummaryNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderSummaryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}