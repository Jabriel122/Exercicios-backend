// Entrada 
Console.WriteLine($"Olá! Digite o seu nome para nos comunicarmos");
string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo, {nome}. Para calcularmos o seu ganho e ver se está tudo bem com o seu orçamento, preciso que você fale o quanto você ganha.");
float ganho = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digita o quanto você normalmente gasta.");
float gasto = float.Parse(Console.ReadLine());

float orçamento = ganho - gasto;

if (gasto > ganho)
{
    Console.WriteLine($"Seu orçamento está estourado, seu orçamento é o seguinte {orçamento}");
}

else
{
    Console.WriteLine($"Os gastos estão dentro do orçamento, ele está assim {orçamento}");
}

