//Desenvolva um programa em C# que calcule a média de preços dos produtos da empresa Davi's Model's.
//O programa deve solicitar a quantidade de produtos e, em seguida, o preço de cada um.
//Por fim, deve exibir a média calculada. (Obs: Use While, Do..While e Switch)

using System.Xml.Serialization;

int qtdproduto;
double soma = 0, media = 0;
bool iniciaCalculo = true;

try
{
    while (iniciaCalculo)
    {
        do
        {
            Console.Write("Quantos produtos você vai querer cadastrar? (0 - Parar)\nApenas: ");
            qtdproduto = Convert.ToInt32(Console.ReadLine());

            if (qtdproduto == 0)
            {
                break;
            }

        } while (qtdproduto <= 0);

        int contador = 0;

        while (contador < qtdproduto)
        {
            double preco = 0;
            Console.Write($"Digite o valo do {contador + 1}° produto: ");
            preco = Convert.ToDouble(Console.ReadLine());
            soma += preco;
            contador++;
        }

        if (!(qtdproduto == 0))
        {
            media = soma / qtdproduto;
        }


        Console.WriteLine($"A média dos produtos é R$ {media:F2}");

        Console.Write("Deseja fazer um novo calculo? (s/n): ");
        char resposta = Convert.ToChar(Console.ReadLine().ToLower());

        switch (resposta)
        {
            case 's':
                do
                {
                    Console.Write("Quantos produtos você vai querer cadastrar? (0 - Parar): ");
                    qtdproduto = Convert.ToInt32(Console.ReadLine());

                    if (qtdproduto == 0)
                    {
                        break;
                    }

                } while (qtdproduto <= 0);
                break;
            case 'n':
                iniciaCalculo = false;
                break;
        }
    }
}
catch (Exception) 
{
    Console.Write("Tivemos um erro, feche o programa e tente novamente");
}