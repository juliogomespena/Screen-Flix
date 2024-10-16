Filme piratasDoCaribe01 = new Filme(new List<string> { "Pirates of the Caribbean: The Curse of the Black Pearl", "Piratas do Caribe: A Maldição do Pérola Negra" }, 2003, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 143);
piratasDoCaribe01.AdicionarSinopse("O pirata Jack Sparrow tem seu navio roubado pelo capitão Barbossa e sua tripulação de piratas amaldiçoados. Ele então se une a Will Turner para resgatar a filha do governador e recuperar seu navio.");
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(1);
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(2);
piratasDoCaribe01.AdicionarDisponibilidadeNoPlano(3);

Filme piratasDoCaribe02 = new Filme(new List<string> { "Pirates of the Caribbean: Dead Man's Chest", "Piratas do Caribe: O Baú da Morte" }, 2006, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 151);
piratasDoCaribe02.AdicionarSinopse("O capitão Jack Sparrow deve encontrar o coração de Davy Jones para evitar que ele se torne escravo do temível pirata. Enquanto isso, Will Turner e Elizabeth Swann são presos por ajudar Jack.");
piratasDoCaribe02.AdicionarDisponibilidadeNoPlano(2);
piratasDoCaribe02.AdicionarDisponibilidadeNoPlano(3);

Filme piratasDoCaribe03 = new Filme(new List<string> { "Pirates of the Caribbean: At World's End", "Piratas do Caribe: No Fim do Mundo" }, 2007, new List<string> { "Ação", "Aventura", "Fantasia" }, 12, 169);
piratasDoCaribe03.AdicionarSinopse("O capitão Jack Sparrow, Will Turner e Elizabeth Swann se unem para enfrentar o temível Lorde Cutler Beckett e Davy Jones, o capitão do navio fantasma.");
piratasDoCaribe03.AdicionarDisponibilidadeNoPlano(3);

Console.WriteLine(piratasDoCaribe01.InformacoesFilme);
Console.WriteLine(piratasDoCaribe02.InformacoesFilme);
Console.WriteLine(piratasDoCaribe03.InformacoesFilme);

Plano Gold = new Plano("Gold", "Plano com todos filmes incluídos", 3, new Dictionary<string, double> { { "Mensal", 29.90 }, { "Anual", 299.90 } });
Plano Silver = new Plano("Silver", "Plano com filmes sujeitos a disponibilidade", 2, new Dictionary<string, double> { { "Mensal", 19.90 }, { "Anual", 199.90 } });
Plano Free = new Plano("Free", "Plano com filmes sujeitos a disponibilidade", 1, new Dictionary<string, double> { { "Mensal", 0.00 }, { "Anual", 0.00 } });

Console.WriteLine(Gold.InformacoesDoPlano);
Console.WriteLine(Silver.InformacoesDoPlano);
Console.WriteLine(Free.InformacoesDoPlano);