/* ----Validador de Orçamento de Projetos-----
 
     Sistema de cálculo e validação de orçamento para projetos de desenvolvimento.
     Compara o custo total estimado com o orçamento disponível para determinar
     a viabilidade financeira do projeto.

    * Fluxo de Execução:
        * 1. Solicitação de Entrada:
            *    - Nome do projeto
            *    - Valor hora do desenvolvedor (ex: 50.0)
            *    - Total de horas estimadas
            *    - Orçamento máximo disponível
            * 
        * 2. Processamento:
            *    - Calcula o custo total: horas estimadas × valor/hora
            *    - Valida se o custo total está dentro do orçamento disponível
            * 
        * 3. Exibição de Saída:
            *    - Custo total calculado
                 - Resultado da validação (dentro ou acima do orçamento)
                 - Diferença entre orçamento e custo
    */


// SOLICITACAO DE ENTRADA DO USUARIO

Console.WriteLine("Sistema de cálculo e validação de orçamento para projetos de desenvolvimento.\nCompara o custo total estimado com o orçamento disponível para determinar a viabilidade financeira do projeto\n");
Console.WriteLine("Informe o nome do projeto:");
string projectName = Console.ReadLine() ?? "Projeto Sem Nome";

Console.WriteLine("Informe o valor hora do desenvolvedor (ex: 50.0):");
string input = Console.ReadLine() ?? "0";
double valuePerHour = double.TryParse(input, out double parsedValue) ? parsedValue : 0;
Console.WriteLine($"Valor hora informado: {valuePerHour} reais por hora");

Console.WriteLine("Informe o total de horas estimadas para o desenvolvimento do projeto:");
input = Console.ReadLine() ?? "0";
int totalHours = int.TryParse(input, out int parsedTotalHour) ? parsedTotalHour : 0;
Console.WriteLine($"Total de horas estimadas: {totalHours} horas");

Console.WriteLine("Informe o orçamento máximo disponível para o projeto:");
input = Console.ReadLine() ?? "0";
double budget = double.TryParse(input, out double parsedBudget) ? parsedBudget : 0;
Console.WriteLine($"Orçamento disponível: {budget} reais");

Console.WriteLine("Iremos fazer a validação de custo, se está dentro do orcamento estimado!");

// ---- CALCULO DE CUSTO COM O PROJETO, VALIDACAO E EXIBICAO -------

double projectPrice = valuePerHour * totalHours;

if (projectPrice > budget)
{
    Console.WriteLine($"O custo calculado do projeto: R${projectPrice}, excede o orcamento disponivel: R${budget}");
}else if (projectPrice == budget)
{
    Console.WriteLine($"O custo calculado do projeto: R${projectPrice}, esta exatamente equivalente ao disponivel no orcamento: R${budget}");
}
else
{
    Console.WriteLine($"O custo calculado do projeto: R${projectPrice}, esta abaixo do orcamento disponivel: R${budget}\neconomizando: R${budget-projectPrice}");
}

Console.WriteLine(" ------- Calculo e validacao completa com sucesso! -------");

