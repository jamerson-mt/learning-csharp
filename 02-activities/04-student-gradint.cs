//VARIABLES
var students = new List<string>();
var points = new List<double>();
string name;

// inicialization students name and points
Console.WriteLine("Quantos alunos?");
if (int.TryParse(Console.ReadLine(), out int q))
{
    while (q > 0)
    {
        //INSERTION STUDENT
        Console.WriteLine("Insira o nome do aluno:");
        name = Console.ReadLine() ?? ""; // null-coalescing operator to handle null input
        students.Add(name);
        //INSERTION STUDENT POINT
        for (int qNota = 0; qNota < 5; qNota++)
        {
            // INSERCAO DAS 5 NOTAS DO ESTUDANTE
            Console.WriteLine($"Insira a nota {qNota+1} de {students[q - q]}");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                points.Add(nota);
            }
            else
            {
                // CASO ERRO NA INSERCAO DA NOTA SERA ATRIBUIDO O VALOR 0
                nota = 0;
                Console.WriteLine("Nota inserida invalida! Atribuiremos a nota 0 ao aluno");
                points.Add(nota);
            }
        }
        Console.WriteLine($"Aluno: {students[q - q]}");
        foreach (var p in points)
        {
            Console.WriteLine($"Nota: {p}");
        }
        q--; //decremento a quantidade para quando inserir todos studantes encerrar
    }
}
