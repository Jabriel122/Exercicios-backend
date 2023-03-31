// Controle de média 

Console.WriteLine($"Ola! Vamo lá. Começa escrevendo o nome do aluno");
string aluno = Console.ReadLine();

double medinota = 7.0;
double medinota1 = 3.0;
int medifreq = 75;

Console.WriteLine($"Okay, qual foi a média de notas do {aluno}?");
double nota = double.Parse(Console.ReadLine());

Console.WriteLine($"Qual foi a média de faltas do {aluno} (Não use porcentagem, coloque só o numero e tire a porcentagem)");
int frequencia = int.Parse(Console.ReadLine());

if(nota >= medinota && frequencia >= medifreq)
{
    Console.WriteLine($"{aluno} aprovado");
    
}

else if( nota < medinota && nota > medinota1 && frequencia >= medifreq)
{
    Console.WriteLine($"{aluno} terá que fazer a prova de recuperação");
}

else
{
    Console.WriteLine($"{aluno} reprovado");
}




