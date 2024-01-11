using System.Runtime.Serialization;

namespace PatAPI.Infrastructure.Exceptions
{
    [Serializable]
    public class GenericException : Exception
    {
        public GenericException()
        {
        }

        public GenericException(string? message) : base(message)
        {
        }

        public GenericException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    public class GameNotFoundException : GenericException
    {
        public GameNotFoundException() : base("Game not Found")
        {
        }
    }
}