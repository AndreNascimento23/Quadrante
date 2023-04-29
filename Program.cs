
Console.Clear();

double x, y;

Console.WriteLine("--- Quadrante Cartesiano ---\n");


Console.WriteLine("Entre com o ponto desejado.");


Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) 
{
    Console.WriteLine($"O ponto ({x}, {y}) fica na origem.");
}
if (x > 0)
{
    if (y < 0)
    {
        Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 4.");
    }
    else if (y > 0)
    {
        Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 1.");
    }
}
if (x < 0)
{
    if (y < 0)
    {
        Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 3.");
    }
    else if (y > 0)
    {
        Console.WriteLine($"O ponto ({x}, {y}) fica no quadrante 2.");
    }
}
if (x == 0 || y == 0)
{
    Console.WriteLine($"O ponto ({x}, {y}) fica no eixo das ordenadas.");
}