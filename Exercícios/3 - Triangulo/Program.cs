// Calculando os triangulo brabo

Console.WriteLine($"Para descobrirmos os triangulos, preciso que escreva os valores das medidas dos triangulos...");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Segunda medida");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Terceira medida");
float n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"os valores são ({n1}) ({n2}) ({n3})");

if (n1 == n2 && n2 == n3)
{
    Console.WriteLine($"Triangulo equilatero");
}

else if (n1 != n2 && n1 != n3 &&  n2 != n3)
{
    Console.WriteLine($"Triangulo escaleno");
    
}

else
{
    Console.WriteLine($"triangulo isosceles");
    
}



