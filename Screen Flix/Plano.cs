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
    public Plano(string nome, string descricao, int nivel, Dictionary<string, double> preco)
    {
        Nome = nome;
        Descricao = descricao;
        Nivel = nivel;
        Preco = preco;
        precoFinal = 0;
    }
    public string Nome { get; }
    public string Descricao { get; }
    public int Nivel { get; }
    private Dictionary<string, double> Preco { get; }
    public double precoFinal;

    public string InformacoesDoPlano => $"Nome do Plano: {Nome}\nDescrição: {Descricao}\nNível: {Nivel}\nPreço: {string.Join(" - ", Preco.Select(x => $"{x.Key}: R$ {x.Value.ToString("F2")}"))}\n";

    public double ObterPrecoFinal(string periodo)
    {
        if (Preco.ContainsKey(periodo))
        {
            precoFinal = Preco[periodo];
        }
        return precoFinal;
    }
}
