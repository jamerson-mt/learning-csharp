
Console.Write("Hello\tWorld!"); // vai criar uma guia (um espaco como se fosse dada uma tabulacao)
Console.WriteLine("");
Console.Write("Hello\nWorld"); // Quebra a linha, e a continuidade vai pra baixo
Console.Write("\nHello \"World!\""); // permite inserir aspas duplas dentro das aspas duplas

Console.WriteLine("C:\\source\\repo"); // as barras invertidas sao reservadas para sequencias de escape

Console.WriteLine(
    @"Tudo aqui dentro sera considerado da forma      literal que for escrita // \\ \ / aceitando qualquer caractere \n "
); // esta he a forma verbatim, colocando o @ antes do ""

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // caracteres UniCode

