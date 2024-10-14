Console.Clear();
double a, b, c, contagem, x1, x2;

Console.WriteLine("Equação de Segundo Grau");
Console.Write("(a):");
a = Convert.ToDouble (Console.ReadLine());
Console.Write("(b):");
b = Convert.ToDouble (Console.ReadLine());
Console.Write("(c):");
c = Convert.ToDouble (Console.ReadLine());


if (a == 0)

{
    Console.WriteLine("Não é uma equação do segundo grau");
}
else 
{
    contagem = b * b - 4 * a * c;

    if (contagem < 0)
    {
        Console.WriteLine($"Como delta = {contagem:N2}, a equação não obtem raizes reais");
    }
    else
    {
        x1 = (-b + Math.Sqrt(contagem)) / (2 * a);
        x2 = (-b - Math.Sqrt(contagem)) / (2 * a);

        Console.WriteLine($"x1 = {x1:N2} e x2 + {x2:N2}");
    }
}