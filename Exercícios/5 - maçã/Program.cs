// Programa maçã 

Console.WriteLine($"Ola! Vamos começar. Quantas maçãs você comprou?");
int qmacas = int.Parse (Console.ReadLine());

if(qmacas >= 12)
{
    double valor1 = qmacas*0.25;
    Console.WriteLine($"Com {qmacas} maçãs, o preço cheio será {valor1}");
} 
else
{
    double valor2 = qmacas*0.30;
    Console.WriteLine($"Com {qmacas} maçãs, o preço cheio será {valor2}");
}


