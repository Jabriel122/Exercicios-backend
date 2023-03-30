// Programa para descobri o placar do time

// Time

Console.WriteLine($"Qual é o nome do primeiro time?");
string time1 = Console.ReadLine();

Console.WriteLine($"Qual é o nome do segundo time?");
string time2 = Console.ReadLine();

Console.WriteLine($"Então é {time1} X {time2}");

Console.WriteLine($"Agora me fala o placar. Qual foi a pontuação do {time1}?");
int pontuação1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Agora, pontuação do {time2}?");
int pontuação2 = int.Parse(Console.ReadLine());

if(pontuação1 > pontuação2)
{
    Console.WriteLine($"{time1} ganhou e {time2} perdeu. O Placar foi {time1} ({pontuação1}) - {time2} ({pontuação2})");
}
else if (pontuação1 < pontuação2)
{
    Console.WriteLine($"{time1} perdeu e {time2} ganhou. O Placar foi {time1} ({pontuação1}) - {time2} ({pontuação2})");
}
else
{
    Console.WriteLine($"Ocorreu Empate. O Placar foi {time1} ({pontuação1}) - {time2} ({pontuação2})");
}





