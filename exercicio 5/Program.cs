﻿// Desenvolva um programa em C# para calcular a redução do tempo de vida de um fumante.
// Pergunte a quantidade de cigarros fumados por dia e quantos anos ele já fumou. Considere que um fumante perde 10 minutos de vida
// a cada cigarro, e calcule quantos dias de vida um fumante perderá.
// Exiba o total em dias.

Console.Write("Quantos cigarros você fuma por dia:? ");
int contagemCigarros = Convert.ToInt32(Console.ReadLine());
Console.Write("Por quantos anos você fumou:? ");
double tempoFumando = Convert.ToDouble(Console.ReadLine());

// Convertendo a quntidade de cigarros fumados por dia para minutos
double minutosFumados = contagemCigarros * 10;
// Sabendo quanto tempo ele perdeu em minutos
double tempoPerdido = (minutosFumados * 365) * tempoFumando;
double diasPerdido = tempoPerdido / 1440;

Console.Write($"Voce fuma {contagemCigarros} cigarros por dia! Durante todo o tempo que você informou que fuma" +
    $"\n Você perdeu {diasPerdido:f1} dias de vida.");