/*3. Informações de Assinantes
//ID do assinante
//Nome do assinante
//Email do assinante
//Endereço do assinante (se for relevante)
//Método de pagamento (ex.: cartão de crédito, PayPal, boleto)
//Data de início da assinatura
//Data de renovação
//Status da assinatura (ativa, expirada, cancelada, em teste)*/

class Usuario
{
    public Usuario(string nome, string email, string endereco, string metodoPagamento, string dataInicioAssinatura, string dataRenovacao, string statusAssinatura, string tipoAssinatura, Plano planoUsuario)
    {
        Nome = nome;
        Email = email;
        Endereco = endereco;
        MetodoPagamento = metodoPagamento;
        DataInicioAssinatura = dataInicioAssinatura;
        DataRenovacao = dataRenovacao;
        StatusAssinatura = statusAssinatura;
        TipoAssinatura = tipoAssinatura;
        PlanoUsuario = planoUsuario;
    }

    private int UserID
    {
        get
        {
            Random random = new Random();
            return random.Next(0, 9999);
        }
    }
    public string Nome { get; }
    public string Email { get; }
    public string Endereco { get; set; }
    public string MetodoPagamento { get; set; }
    public string DataInicioAssinatura { get; set; }
    public string DataRenovacao { get; set; }
    public string TipoAssinatura { get; set; }
    public string StatusAssinatura { get; set; }
    public Plano PlanoUsuario { get; set; }

    public string InformacoesUsuario => $"ID do Usuário: {UserID}\nNome: {Nome}\nEmail: {Email}\nEndereço: {Endereco}\nMétodo de Pagamento: {MetodoPagamento}\nData de Início da Assinatura: {DataInicioAssinatura}\nData de Renovação: {DataRenovacao}\nStatus da Assinatura: {StatusAssinatura}\nPlano: {PlanoUsuario.Nome}\n";
}