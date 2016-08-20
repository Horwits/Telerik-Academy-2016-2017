using System;
using System.Runtime.Serialization;

namespace InversionOfControlExample
{
    [Serializable]
    public class AddCustomerException : Exception
    {
        public AddCustomerException()
        {
        }

        public AddCustomerException(string message) : base(message)
        {
        }

        public AddCustomerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AddCustomerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}