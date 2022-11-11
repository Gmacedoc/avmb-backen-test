using AVMBTest.Dtos;
using AVMBTest.Models;

namespace AVMBTest.Interface
{
    public interface IEnvelopeService
    {
        ResponseGeneric<ResponseEnvelope> insereEnvelope(EvelopeModel envelope);
    }
}
