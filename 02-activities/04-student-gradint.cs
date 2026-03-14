//VARIABLES
var students = new List<string>();
var points = new List<double>();
string value = "";
// inicialization students name and points
Console.WriteLine("Insira o nome do aluno:");
value = Console.ReadLine() ?? ""; // null-coalescing operator to handle null input
students.Add(value);
Console.WriteLine($"Insira a nota de {students[0]}");
if(double.TryParse(Console.ReadLine(), out double nota)){
    points.Add(nota);
}else{
    nota = 0;
    Console.WriteLine("Nota inserida invalida! Atribuiremos a nota 0 ao aluno");
    points.Add(nota);
}

Console.WriteLine(
$@"Aluno: {students[0]}
nota: {points[0]}"
);
