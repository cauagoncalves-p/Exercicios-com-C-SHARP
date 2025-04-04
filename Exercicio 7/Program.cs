// Escreva um programa em C# que gere a série de Fibonacci até o N-ésimo termo
// (com N sendo uma entrada do algoritmo).


Console.WriteLine("Digite o número de termos da série de Fibonacci que você deseja gerar:");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, c;

while (n > 0) 
{
    c = a + b;
    a = b;
    b = c;

    Console.Write(n == 1 ? $"{c}" : $"{c},");
    n--;
}