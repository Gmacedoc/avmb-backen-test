using AVMBTest.Dtos;
using AVMBTest.Interface;
using AVMBTest.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AVMBTest.Rest
{
    public class RestEnvelope : IEnvelopeService
    {
        static HttpClient client = new HttpClient();
        string token = "pa9lwgEvvSl5QypP2huHk2OOJfr1FyeQ79p1tt3JCiIoH93GbnkwxF6S60yFQoZwYCzUwZVb-Lk9KvOx1EDnvZv4imrjtttnP6kEBQUijI6cJVe+f+fECZWfOii8CKwLsXjjo9XMEqLD4sr3lcuY9anFROFIMGxC";
        public ResponseGeneric<ResponseEnvelope> insereEnvelope(EvelopeModel envelope)
        {
            envelope.token = token;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(JsonConvert.SerializeObject(envelope), Encoding.UTF8, "application/json");

            var res = client.PostAsync("https://plataforma.astenassinatura.com.br/api/inserirEnvelope", new StringContent(JsonConvert.SerializeObject(envelope), Encoding.UTF8, "application/json"));
            var response = new ResponseGeneric<ResponseEnvelope>();
            try
            {
                res.Result.EnsureSuccessStatusCode();

                var result = res.Result.Content.ReadAsStringAsync().Result;

                ResponseEnvelope? retorno = JsonConvert.DeserializeObject<ResponseEnvelope>(result);

                response.DadosRetorno = retorno;

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + res + " Error " +
                ex.ToString());
            }

            return null;
        }
    }
}
