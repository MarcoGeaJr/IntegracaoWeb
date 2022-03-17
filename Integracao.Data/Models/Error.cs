using System.Net;

namespace Integracao.Data.Models
{
    public class Error : Entity
    {
        public Error(HttpStatusCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public HttpStatusCode StatusCode { get; private set; }
        public string Message { get; private set; }
    }
}
