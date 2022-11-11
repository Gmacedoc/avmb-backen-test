namespace AVMBTest.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ConfigAssinatura
    {
        public string? EmailSignatario { get; set; }
        public string? NomeSignatario { get; set; }
        public object? CelularSignatario { get; set; }
        public object? OpcaoAutenticacao { get; set; }
        public int? TipoAssinatura { get; set; }
        public string? PermitirDelegar { get; set; }
        public string? ApenasCelular { get; set; }
        public string? ExigirLogin { get; set; }
        public string? ExigirCodigo { get; set; }
        public string? ExigirDadosIdentif { get; set; }
        public string? AssinaturaPresencial { get; set; }
        public object? NomeSignPresencial { get; set; }
        public object? CpfSignPresencial { get; set; }
        public string? IgnorarRecusa { get; set; }
        public object? CodigoExigido { get; set; }
        public string? IncluirImagensAutentEnvelope { get; set; }
        public string? AnalisarFaceImagem { get; set; }
        public int? PercentualPrecisaoFace { get; set; }
    }
    public class SignatarioModel
    {
        public string? Token { get; set; }
        public SignatarioEnvelope? @params { get; set; }
    }

    public class SignatarioEnvelope
    {
        public Envelope? Envelope { get; set; }
        
        public int? Ordem { get; set; }
        public object? TagAncoraCampos { get; set; }
        public ConfigAssinatura? ConfigAssinatura { get; set; }
    }


}
