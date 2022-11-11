namespace AVMBTest.Models
{
    public class ConfigAuxiliar
    {
        public string? documentosComXMLs { get; set; }
        public object? urlCarimboTempo { get; set; }
    }

    public class Documento
    {
        public string? nomeArquivo { get; set; }
        public string? mimeType { get; set; }
        public string? conteudo { get; set; }
        public ListaXMLAuxiliar? listaXMLAuxiliar { get; set; }
    }

    public class Envelope
    {
        public int? Id { get; set; }
        public string? descricao { get; set; }
        public Repositorio? Repositorio { get; set; }
        public string? mensagem { get; set; }
        public string? mensagemObservadores { get; set; }
        public string? mensagemNotificacaoSMS { get; set; }
        public DateTime? dataExpiracao { get; set; }
        public int? horaExpiracao { get; set; }
        public string? usarOrdem { get; set; }
        public ConfigAuxiliar? ConfigAuxiliar { get; set; }
        public ListaDocumentos? listaDocumentos { get; set; }
        public ListaSignatariosEnvelope? listaSignatariosEnvelope { get; set; }
        public ListaObservadores? listaObservadores { get; set; }
        public ListaTags? listaTags { get; set; }
        public ListaInfoAdicional? listaInfoAdicional { get; set; }
        public string? incluirHashTodasPaginas { get; set; }
        public string? permitirDespachos { get; set; }
        public string? ignorarNotificacoes { get; set; }
        public string? ignorarNotificacoesPendentes { get; set; }
        public object? qrCodePosLeft { get; set; }
        public object? qrCodePosTop { get; set; }
        public object? dataIniContrato { get; set; }
        public object? dataFimContrato { get; set; }
        public object? objetoContrato { get; set; }
        public object? numContrato { get; set; }
        public object? valorContrato { get; set; }
        public object? descricaoContratante { get; set; }
        public object? descricaoContratado { get; set; }
    }

    public class ListaDocumentos
    {
        public List<Documento>? Documento { get; set; }
    }

    public class ListaInfoAdicional
    {
        public List<object>? InfoAdicional { get; set; }
    }

    public class ListaObservadores
    {
        public List<object>? Observador { get; set; }
    }

    public class ListaSignatariosEnvelope
    {
        public List<object>? SignatarioEnvelope { get; set; }
    }

    public class ListaTags
    {
        public List<object>? Tag { get; set; }
    }

    public class ListaXMLAuxiliar
    {
        public List<XMLAuxiliar>? XMLAuxiliar { get; set; }
    }

    public class ListaXMLSignatario
    {
        public List<XMLSignatario>? XMLSignatario { get; set; }
    }

    public class Params
    {
        public Envelope? Envelope { get; set; }
        public string? gerarTags { get; set; }
        public string? encaminharImediatamente { get; set; }
        public string? detectarCampos { get; set; }
    }

    public class Repositorio
    {
        public int id { get; set; }
    }

    public class EvelopeModel
    {
        public string? token { get; set; }
        public Params? @params { get; set; }
    }

    public class XMLAuxiliar
    {
        public object? nomeArquivo { get; set; }
        public object? conteudoXML { get; set; }
        public ListaXMLSignatario? listaXMLSignatario { get; set; }
    }

    public class XMLSignatario
    {
        public object? emailSignatario { get; set; }
        public object? idNodeAssinatura { get; set; }
        public object? restringirTiposCertificados { get; set; }
        public object? restringirPessoaFisica { get; set; }
        public object? restringirPessoaJuridica { get; set; }
    }


}
