string name = "João";
int point = 8;
double price = 19.99;
bool stats = true;

if((name.Length > 0) && (point > 0) && (price > 0) && (stats == true)){
    Console.WriteLine("Todas as condições foram atendidas!");
}else if(name.Length == 0)
{
    Console.WriteLine("O nome está vazio!");
}
else
{
    Console.WriteLine("Uma ou mais condições não foram atendidas!");
}

if(point != 10)
{
    Console.WriteLine("A pontuação não é igual a 10.");
}else if(price == 35.44)
{
    Console.WriteLine("O preço é igual a 35.44.");
}else if(stats == false)
{
    Console.WriteLine("As estatísticas são falsas.");
}