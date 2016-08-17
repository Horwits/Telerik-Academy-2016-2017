using System;
using System.Runtime.Serialization;

namespace InversionOfControlExample
{
    [Serializable]
    public class CreateCustomerException : Exception
    {
        public CreateCustomerException()
        {
        }

        public CreateCustomerException(string message) : base(message)
        {
        }

        public CreateCustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CreateCustomerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}