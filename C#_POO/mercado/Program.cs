using market;

Mercado shop = new Mercado();

shop.nome = "Ps5";
shop.codigoDeBarras = 12345;
shop.fabricante = "Sony";
shop.valorDeCompra = 40000.0;
shop.valorUnitario = 5000.0;
shop.estoque = 10;

Console.Write("Nome do produto: " + shop.nome);
