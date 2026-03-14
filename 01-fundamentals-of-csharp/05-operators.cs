// declaração das variaveis
int ProductQuantity;
string? productName;
double ProductPrice;
bool Productstats;
string statsResponse;

// variaveis para receber os valores pois operação
string productNameFull;
double productsPriceTotal;

//variavel geral para pegar resposta do usuario
string? response;

// entrada de dados do produto
Console.WriteLine("Insert the product name, please! :");
productName = Console.ReadLine();
Console.WriteLine("Insert quantity of products:");
response = Console.ReadLine();
ProductQuantity = int.Parse(response);

Console.WriteLine("Insert price of products:");
response = Console.ReadLine();
ProductPrice = double.Parse(response);

Console.WriteLine("Please let me know if it available for sale: (S/N)");
statsResponse = Console.ReadLine();

if (statsResponse.ToUpper() == "S")
{
    Productstats = true;
}
else
{
    Productstats = false;
}

// exibição das informações do item
Console.WriteLine(
    $"Okay, Thanks for all informations, seu produto: {productName}, foi cadastrado com sucesso!"
);
Console.WriteLine("below is some information");
Console.WriteLine($"Quantity: {ProductQuantity} em estoque");
Console.WriteLine($"Price of product : {ProductPrice}$");
Console.WriteLine($"product is available: {Productstats}");

// concatenação dos nomes, o operador + quando usado com uma variavel do tipo char, concatena os valores
Console.WriteLine("Give second name for product:");
productNameFull = productName + " " + Console.ReadLine();
Console.WriteLine($"Full Name: {productNameFull}");

// Multiplicação do preço do produto pela quantidade, para informar o valor total do itens
productsPriceTotal = ProductPrice * ProductQuantity;
Console.WriteLine("below is total price of products!");
Console.WriteLine($"Total price of products: {productsPriceTotal}");
