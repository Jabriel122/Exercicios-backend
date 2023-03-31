// Validação de Senha

Console.WriteLine($"Escreva aqui o seu nome de usuário.");
string nusuário = Console.ReadLine();

Console.WriteLine($"Agora digite a senha");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"Senha válida, acesso Permitido.");
}

else
{
    Console.WriteLine($"Senha inválida, acesso negado");
    
}
