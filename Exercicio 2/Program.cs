// Uma empresa dá um prêmio aos funcionários que cumprem ou ultrapassam determinado valor de vendas de produtos.
// Para cada funcionário, foi estabelecido um valor a ser alcançado.
// Faça um programa em C# para ler o valor fixado e o valor de vendas de um funcionário.
// Depois, imprima a mensagem "Ganhou!" (caso o funcionário tenha conseguido o prêmio) e "Não ganhou!"



Console.Write("Qual é o valor de meta esse mês? ");
double meta = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"A meta esse mês foi estabelecidade: R$ {meta}");
Console.WriteLine();

Console.Write("Qual foi o valor de vendas do seu funcionário? ");
double vendaFuncionario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Seu funcionário teve um valor de vendas de: R$ {vendaFuncionario} ");
Console.WriteLine();
string resultado = $"O total de vendas do seu funcionário foi de: R$ {vendaFuncionario}";

if (vendaFuncionario >= meta)
{
    resultado += "\nParábens, ele bateu a meta e ganhou uma comissão";
}
else
{
    resultado += "\nNão ganhou, seu funcionário não bateu a meta e não ganhou uma comissão";
}

Console.WriteLine(resultado);