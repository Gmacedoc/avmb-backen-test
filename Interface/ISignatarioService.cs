using AVMBTest.Dtos;

namespace AVMBTest.Interface
{
    public interface ISignatarioService
    {
        ResponseGeneric<ResponseSignatario> inserirSignatarioEnvelope(string idEnvelope, string email);
    }
}
