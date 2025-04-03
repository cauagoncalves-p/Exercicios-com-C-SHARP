// Desenvolva um programa em C# que leia um valor em metros e o exiba convertido em milímetros.

Console.Write("Metros para milímetros: ");
double metro = Convert.ToDouble(Console.ReadLine());
double convercao;

if (metro >= 100)
{
    convercao = metro / 100;
    convercao *= 1000;
}
else 
{
    convercao = metro * 1000;
}

Console.WriteLine($"{metro} m, convertido para milímetros é igual: {convercao}mm");