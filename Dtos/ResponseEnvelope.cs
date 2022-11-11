namespace AVMBTest.Dtos
{
    
    public class Aviso
    {
        public string? Tipo { get; set; }
        public string? Mensagem { get; set; }
    }

    public class DadosSignatarioReenvio
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public object? Celular { get; set; }
        public string? LinkAcesso { get; set; }
    }

    public class Data
    {
        public string? IdEnvelope { get; set; }
        public string? HashSHA256 { get; set; }
        public ListaDadosSignatarios? ListaDadosSignatarios { get; set; }
        public ListaAvisos? ListaAvisos { get; set; }
    }

    public class ListaAvisos
    {
        public Aviso? Aviso { get; set; }
    }

    public class ListaDadosSignatarios
    {
        public List<DadosSignatarioReenvio>? DadosSignatarioReenvio { get; set; }
    }

    public class Response
    {
        public string? Mensagem { get; set; }
        public Data? Data { get; set; }
    }

    public class ResponseEnvelope
    {
        public Response? Response { get; set; }
    }


    
}
