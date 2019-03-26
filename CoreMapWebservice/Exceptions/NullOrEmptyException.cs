using System;
using System.Reflection;

namespace CoreMapWebservice.Exceptions
{
    public class NullOrEmptyException : Exception
    {
        private readonly string _message;

        public NullOrEmptyException(PropertyInfo property)
        {
            _message = $"Property {property.Name} of {property.GetType().FullName} should not be null or empty";
        }

        public NullOrEmptyException(string message)
        {
            _message = message;
        }



        public override string Message
        {
            get { return _message; }
        }
    }
}
