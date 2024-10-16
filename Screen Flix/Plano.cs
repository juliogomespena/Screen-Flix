/*2. Informações do Plano
//Nome do plano(ex.: Básico, Premium, Família)
//Descrição do plano(detalhes sobre o que está incluído)
//Nível do plano(diferentes níveis ou camadas, ex.: gratuito, intermediário, avançado)
//Preço(valor mensal, anual, ou outro período de cobrança)
//Período de renovação(ex.: mensal, anual)*/

//Plano 01: Gold -> Desc: Plano com todos filmes incluídos -> 3 -> (R$ 29,90 -> Mensal) (R$ 299,90 -> Anual)

//Plano 02: Silver -> Desc: Plano com filmes sujeitos a disponibilidade -> 2 -> (R$ 19,90 -> Mensal) (R$ 199,90 -> Anual)

//Plano 01: Free -> Desc: Plano com filmes sujeitos a disponibilidade -> 1

class Plano
{
    public Plano(string nome, string descricao, Dictionary<string, double> preco)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        precoFinal = 0;
    }
    public string Nome { get; }
    public string Descricao { get; }
    private Dictionary<string, double> Preco { get; }
    public double precoFinal;

    public string InformacoesDoPlano => $"Nome do Plano: {Nome}\nDescrição: {Descricao}\nPreço: {string.Join(" - ", Preco.Select(x => $"{x.Key}: R$ {x.Value.ToString("F2")}"))}\n";

    public double ObterPrecoFinal(Usuario usuario)
    {
        if (Preco.ContainsKey(usuario.TipoAssinatura))
        {
            precoFinal = Preco[usuario.TipoAssinatura];
        }
        return precoFinal;
    }
}
