
using AtividadeProduto;

Console.WriteLine("Olá, boas-vindas!\n");

Produto bolacha = new Produto();
bolacha.nome = "Bolacha de chocolate";
bolacha.descricao = "Bolacha = biscoito + recheio + biscoito";
bolacha.quantidade = 10;
bolacha.preço = 03.40;
bolacha.status = true;

Produto biscoito = new Produto(); 
biscoito.nome = "Bisoito de polvilho";
biscoito.descricao = "Biscoito não tem recheio";
biscoito.quantidade = 8;
biscoito.preço = 07.10;
biscoito.status = true;

Produto cookie = new Produto();
cookie.nome = "Cookie com gotas de chocolate";
cookie.descricao = "Cookie tem recheio";
cookie.quantidade = 12;
cookie.preço = 04.80;
cookie.status = true;

bolacha.mostra();
biscoito.mostra();

cookie.desativa();
cookie.mostra();

Console.ReadKey();