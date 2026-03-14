//VARIABLES
var students = new List<string>();
var studentsAverage = new List<double>();

// inicialization students name and points
Console.WriteLine("Quantos alunos?");
if (int.TryParse(Console.ReadLine(), out int q))
{
    for (int i = 0; i < q; i++)
    {
        //INSERTION STUDENT
        Console.WriteLine("Insira o nome do aluno:");
        string name = Console.ReadLine() ?? ""; // null-coalescing operator to handle null input
        students.Add(name);
        //INSERTION STUDENT POINT
        double soma = 0;
        var points = new List<double>();

        for (int qNota = 0; qNota < 5; qNota++)
        {
            // INSERCAO DAS 5 NOTAS DO ESTUDANTE
            Console.WriteLine($"Insira a nota {qNota + 1} de {students[i]}");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                points.Add(nota);
                soma += nota;
            }
            else
            {
                // CASO ERRO NA INSERCAO DA NOTA SERA ATRIBUIDO O VALOR 0
                nota = 0;
                Console.WriteLine("Nota inserida invalida! Atribuiremos a nota 0 ao aluno");
                points.Add(nota);
            }
        }
        studentsAverage.Add(soma / 5);
        Console.WriteLine($"Aluno: {students[i]}");
        foreach (var p in points)
        {
            Console.WriteLine($"Nota: {p}");
        }
        Console.WriteLine($"A nota media de {students[i]}: {studentsAverage[i]}");
    }
}
