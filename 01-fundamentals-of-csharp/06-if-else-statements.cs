
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Informe sua pontuação: ");
string input = Console.ReadLine() ?? "0";


if(double.TryParse(input, out double point)){
    if(point >= 7){
    
        Console.WriteLine($"Sua pontuacao {point} esta na media para ser aprovado: APROVADO!");
    }
    else
    {
        Console.WriteLine($"Sua pontuacao {point} nao esta na media para ser aprovado: REPROVADO!");
    }
}else{
    Console.WriteLine("voce digitou um valor nao aceito pelo sistema!");
}
