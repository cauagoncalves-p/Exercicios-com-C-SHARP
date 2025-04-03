// Escreva um programa em C# que permita ao usuário digitar um estado do Campeonato Brasileiro de Futebol e informe quais os times desse estado.
// (Obs: Use IF e Switch)

Console.Write("Digite um estado do Campeonato Brasileiro de Futebol: ");
string estado = Console.ReadLine().ToLower();

if (estado == "são paulo" || estado == "sp" || estado == "rio de janeiro" || estado == "rj" ||
   estado == "minas gerais" || estado == "mg" || estado == "rio grande do sul" || estado == "rs")
{
    switch (estado)
    {
        case "são paulo":
        case "sp":
            Console.WriteLine("Times de São Paulo: Palmeiras, Corinthians, São Paulo, Santos, Red Bull Bragantino.");
            break;
        case "rio de janeiro":
        case "rj":
            Console.WriteLine("Times do Rio de Janeiro: Flamengo, Fluminense, Vasco, Botafogo.");
            break;
        case "minas gerais":
        case "mg":
            Console.WriteLine("Times de Minas Gerais: Atlético-MG, Cruzeiro, América-MG.");
            break;
        case "rio grande do sul":
        case "rs":
            Console.WriteLine("Times do Rio Grande do Sul: Grêmio, Internacional.");
            break;
        default:
            Console.WriteLine("Nenhum time cadastrado para esse estado.");
            break;
    }
}
else 
{
    Console.WriteLine("Estado não encontrado");
}
 