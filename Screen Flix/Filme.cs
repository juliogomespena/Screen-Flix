/*1.Informações Básicas do Filme
//Título (original e traduções)
//Ano de lançamento
//Gênero(s) (ex.: drama, comédia, ação)
//Sinopse (descrição curta do enredo)
//Classificação indicativa (idade mínima recomendada)
//Duração (em minutos)
//Disponibilidade no plano*/

class Filme
{
    public List<string> Titulo { get; }
    public int AnoLancamento { get; }
    public List<string> Generos { get; }
    public string Sinopse { get; set; }
    public int ClassificacaoIndicativa { get; }
    public int Duracao { get; }
    public List<int> DisponivelNoPlano { get; set; }
    
    public string InformacoesFilme => $"Título: {string.Join(", ", Titulo)}\nAno de Lançamento: {AnoLancamento}\nGênero(s): {string.Join(", ", Generos)}\nSinopse: {Sinopse}\nClassificação Indicativa: {ClassificacaoIndicativa}\nDuração: {Duracao} minutos\nDisponível no(s) plano(s): {string.Join(" - ", DisponivelNoPlano)}\n\n";

    public Filme(List<string> titulo, int anoLancamento, List<string> generos, int classificacaoIndicativa, int duracao)
    {
        Titulo = titulo;
        AnoLancamento = anoLancamento;
        Generos = generos;
        ClassificacaoIndicativa = classificacaoIndicativa;
        Duracao = duracao;
        DisponivelNoPlano = new List<int>();
        Sinopse = "";
    }

    public void AdicionarSinopse(string sinopse)
    {
        Sinopse = sinopse;
    }
    public void AdicionarDisponibilidadeNoPlano(int plano)
    {
        DisponivelNoPlano.Add(plano);
    }
}