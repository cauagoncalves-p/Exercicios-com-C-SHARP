// Elabore um programa em C# para realizar o cadastro de alunos em 3 sistemas escolares
// incluindo nome, matrícula, idade e curso. O programa deve permitir o cadastro de até 30 alunos e exibir a média de
// informações após o registro, além de informar se o estudante foi aprovado ou não, levando em consideração o corte de
// notas passadas pelo sistema.

using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int notaCorte, idade;
        string A, B, C, nome, matricula, curso;
        double nota;



        for (int i = 0; i <= 30; i++)
        {
            Console.Write("Qual sistema será feito o cadastro do aluno ? Cada sistema tem sua própria nota de corte!\nSistemas : A, B, C - (Sair)\nResposta: ");
            string resposta = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (resposta == "SAIR" || resposta != "A" && resposta != "B" && resposta != "C") 
            {
                Console.WriteLine("Sistema inválido ou opção de sair selecionada.");
                return;
            }

            Console.Write($"Informações do {i + 1}° aluno");
            Console.WriteLine();
            Console.Write("Nome: "); nome = Console.ReadLine();
            Console.Write("Matricula: "); matricula = Console.ReadLine();
            Console.Write("Idade: "); idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Curso: "); curso = Console.ReadLine();
            Console.Write("Nota: "); nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            notaCorte = 0;
            switch (resposta)
            {
                case "A":
                    notaCorte = 10;
                    break;
                case "B":
                    notaCorte = 18;
                    break;
                case "C":
                    notaCorte = 20;
                    break;
            }

            string resultado = (nota >= notaCorte) ? "Aprovado" : "Reprovado";

            Console.WriteLine($"O aluno: {nome} foi {resultado} no sistema {resposta} com a nota {nota}.");

        }
    }
}