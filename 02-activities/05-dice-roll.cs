//lANCAMENTO DE DADO POR JOGADORES PARA OBTER O MAIOR NUMERO

Console.WriteLine("Informe quantos jogadores irao jogar:");
string value = Console.ReadLine() ?? "0";
if (int.TryParse(value, out int qJogadores))
{
    Console.WriteLine($"Quantidade de jogadores: {qJogadores}");
}
else
{
    Console.WriteLine($"Quantidade de jogadores nao informada: {qJogadores}");
}

