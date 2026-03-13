int fahrenheit = 94;

decimal celsius = (fahrenheit - 32m) * 5m / 9m; // o m é para indicar que o numero é do tipo decimal, se não colocar o m, o numero é do tipo double e a operação não é permitida, pois estamos tentando atribuir um valor do tipo double para uma variavel do tipo decimal, o que não é permitido em C#.

Console.WriteLine($" the temperature is {celsius:F2} Celsius."); // o F2 é para formatar o numero para 2 casas decimais, caso queira mais ou menos casas decimais, basta trocar o numero 2 pelo numero desejado.
