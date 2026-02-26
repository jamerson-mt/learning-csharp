// operador ternario 

Console.WriteLine("Informe sua idade:");
string input = Console.ReadLine() ?? string.Empty ;
int age = int.TryParse(input, out int parsedAge) ? parsedAge : 0;

Console.WriteLine($"Você é uma pessoa: {((age >= 18) ? "Maior de idade" : "Menor de idade")}");
