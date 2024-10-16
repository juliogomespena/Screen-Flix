class Biblioteca
{
    public Biblioteca(List<Filme> filmes, Usuario usuario)
    {
        this.Filmes = filmes;
        Usuario = usuario;
    }

    private List<Filme> Filmes { get; }
    public Usuario Usuario { get; }
    public void FilmesDisponiveis()
    {
        Console.WriteLine($"Bem vindo {Usuario.Nome}!");

        if (Usuario.StatusAssinatura.ToUpper() == "EXPIRADA")
        {
            Console.WriteLine("Assinatura expirada! Adquira uma nova assinatura para continuar assistindo.\n");
        }
        else
        {
            Console.WriteLine($"Filmes disponíveis para o plano { Usuario.PlanoUsuario.Nome}:\n");
            foreach (Filme filme in Filmes)
            {
                if (filme.DisponivelNoPlano.Contains(Usuario.PlanoUsuario.Nivel))
                {
                    Console.WriteLine(filme.InformacoesFilme);
                }
            }
        }
    }
}