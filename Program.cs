Cliente cliente1 = new Cliente("Rafaela Oliveira", "123.456.789-00");
Veiculo veiculo1 = new Veiculo("Toyota", "YZD-1234");

Cliente cliente2 = new Cliente("Maria Silva", "987.654.321-00");
Veiculo veiculo2 = new Veiculo("Honda", "ABC-5678");

Locacao locacao1 = new Locacao(cliente1, veiculo1, new DateOnly(2024, 6, 1), 5, 100);
Locacao locacao2 = new Locacao(cliente2, veiculo2, new DateOnly(2024, 6, 2), 8, 150);

locacao1.ExibirResumo();
Console.WriteLine();
locacao2.ExibirResumo();