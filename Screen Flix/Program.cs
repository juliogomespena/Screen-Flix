//Lista de filmes
List <Filme> filmes = new List<Filme>();
List <Plano> planos = new List<Plano>();
List <Usuario> usuarios = new List<Usuario>();

//Instanciando 3 filmes
Filme piratasDoCaribe01 = new Filme(new List<string> { "Pirates of the Caribbean: The Curse of the Black Pearl", "Piratas do Caribe: A Maldição do Pérola Negra" }, 2003, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 143);
piratasDoCaribe01.AdicionarSinopse("O pirata Jack Sparrow tem seu navio roubado pelo capitão Barbossa e sua tripulação de piratas amaldiçoados. Ele então se une a Will Turner para resgatar a filha do governador e recuperar seu navio.");
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(1);
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(2);
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(3);
filmes.Add(piratasDoCaribe01);

Filme piratasDoCaribe02 = new Filme(new List<string> { "Pirates of the Caribbean: Dead Man's Chest", "Piratas do Caribe: O Baú da Morte" }, 2006, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 151);
piratasDoCaribe02.AdicionarSinopse("O capitão Jack Sparrow deve encontrar o coração de Davy Jones para evitar que ele se torne escravo do temível pirata. Enquanto isso, Will Turner e Elizabeth Swann são presos por ajudar Jack.");
piratasDoCaribe02.AdicionarDisponibilidadeNoPlano(2);
piratasDoCaribe02.AdicionarDisponibilidadeNoPlano(3);
filmes.Add(piratasDoCaribe02);

Filme piratasDoCaribe03 = new Filme(new List<string> { "Pirates of the Caribbean: At World's End", "Piratas do Caribe: No Fim do Mundo" }, 2007, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 169);
piratasDoCaribe03.AdicionarSinopse("O capitão Jack Sparrow, Will Turner e Elizabeth Swann se unem para enfrentar o temível Lorde Cutler Beckett e Davy Jones, o capitão do navio fantasma.");
piratasDoCaribe03.AdicionarDisponibilidadeNoPlano(3);
filmes.Add(piratasDoCaribe03);

//Instanciando 3 planos
Plano Gold = new Plano("Gold", "Plano com todos filmes incluídos", 3, new Dictionary<string, double> { { "Mensal", 29.90 }, { "Anual", 299.90 } });
planos.Add(Gold);
Plano Silver = new Plano("Silver", "Plano com filmes sujeitos a disponibilidade", 2, new Dictionary<string, double> { { "Mensal", 19.90 }, { "Anual", 199.90 } });
planos.Add(Silver);
Plano Free = new Plano("Free", "Plano com filmes sujeitos a disponibilidade", 1, new Dictionary<string, double> { { "Mensal", 0.00 }, { "Anual", 0.00 } });
planos.Add(Free);

//Instanciando 4 usuários
Usuario user01 = new Usuario("Julio Gomes Pena", "juliogomespena@gmail.com", "Rua das Árvores, nº 0 - Cidade das Árvores/MG - Brasil ", "Cartão de Crédito", "25/01/2021", "25/10/2024", "Ativa", "Mensal", Gold);
Usuario user02 = new Usuario("Jane Doe", "janedoe@gmail.com", "Rua das Palmeiras, nº 0 - Cidade das Palmeiras/RS - Brasil ", "Pix", "01/05/2023", "01/05/2025", "Ativa", "Anual", Silver);
Usuario user03 = new Usuario("Jonas Doe", "jonas@gmail.com", "Rua das Caiçaras, nº 0 - Cidade das Praias/BH - Brasil ", "", "15/10/2024", "15/11/2024", "Em teste", "Mensal", Free);
Usuario user04 = new Usuario("Jamal Johnson", "jamal@gmail.com", "Rua das Jamais, nº 0 - Cidade do Jamal/RO - Brasil ", "Cartão de Crédito", "14/03/2021", "10/10/2024", "Expirada", "Mensal", Silver);

//Instanciando 4 bibliotecas, uma para cada usuário
Biblioteca biblioteca1 = new Biblioteca(filmes, user01);
Biblioteca biblioteca2 = new Biblioteca(filmes, user02);
Biblioteca biblioteca3 = new Biblioteca(filmes, user03);
Biblioteca biblioteca4 = new Biblioteca(filmes, user04);


Console.WriteLine("Todos filmes (sujeito a disponibilidade de local e plano):\n");
foreach (Filme filme in filmes)
{
    Console.WriteLine(filme.InformacoesFilme);
}

Console.WriteLine("Todos planos disponíveis: ");
foreach (Plano plano in planos)
{
    Console.WriteLine(plano.InformacoesDoPlano);
}
Console.WriteLine("\n\n");
biblioteca1.FilmesDisponiveis();
biblioteca2.FilmesDisponiveis();
biblioteca3.FilmesDisponiveis();
biblioteca4.FilmesDisponiveis();