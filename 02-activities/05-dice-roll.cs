//lANCAMENTO DE DADO POR JOGADORES PARA OBTER O MAIOR NUMERO
Random dice = new();

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

List<int> dicePoints = new(); //lista de pontos do dados
for (int i = 0; i < qJogadores; i++)
{
    int roll = dice.Next(1, 6);
    dicePoints.Add(roll);
    Console.WriteLine($"Jogador {i + 1}, lancou o dado: {dicePoints[i]}");
}

//ORDENA PELA MAIOR PONTUACAO, INDICANDO QUEM VENCEU

dicePoints.Sort((a, b) => b.CompareTo(a)); //ordena a lista do maior pra menor

Console.WriteLine(
@"Ranking de pontos
Pontuação"
);
foreach (int point in dicePoints)
{
    Console.WriteLine($"{point}");
}
