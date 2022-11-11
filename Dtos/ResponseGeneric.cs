using System.Dynamic;
using System.Net;

namespace AVMBTest.Dtos
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? DadosRetorno { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}
