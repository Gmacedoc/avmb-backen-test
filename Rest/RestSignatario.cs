using AVMBTest.Dtos;
using AVMBTest.Interface;
using AVMBTest.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AVMBTest.Rest
{
    public class RestSignatario : ISignatarioService
    {
        static HttpClient client = new HttpClient();
        string token = "pa9lwgEvvSl5QypP2huHk2OOJfr1FyeQ79p1tt3JCiIoH93GbnkwxF6S60yFQoZwYCzUwZVb-Lk9KvOx1EDnvZv4imrjtttnP6kEBQUijI6cJVe+f+fECZWfOii8CKwLsXjjo9XMEqLD4sr3lcuY9anFROFIMGxC";

        public ResponseGeneric<ResponseSignatario> inserirSignatarioEnvelope(int idEnvelope, string email)
        {
            SignatarioModel sigModel = new SignatarioModel();
            sigModel.Token = token;
            sigModel.@params.Envelope = new Envelope
            {
                Id = idEnvelope
            };
            sigModel.@params.ConfigAssinatura = new ConfigAssinatura
            {
                EmailSignatario = email
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            var res = client.PostAsync("https://plataforma.astenassinatura.com.br/api/inserirSignatarioEnvelope", new StringContent(JsonConvert.SerializeObject(sigModel), Encoding.UTF8, "application/json"));
            var response = new ResponseGeneric<ResponseSignatario>();
            try
            {
                res.Result.EnsureSuccessStatusCode();

                var result = res.Result.Content.ReadAsStringAsync().Result;

                ResponseSignatario? retorno = JsonConvert.DeserializeObject<ResponseSignatario>(result);

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
