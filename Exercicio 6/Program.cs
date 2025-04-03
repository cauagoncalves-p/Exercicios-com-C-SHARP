// Elabore um programa em C# para realizar o cadastro de alunos em 3 sistemas escolares
// incluindo nome, matrícula, idade e curso. O programa deve permitir o cadastro de até 30 alunos e exibir a média de
// informações após o registro, além de informar se o estudante foi aprovado ou não, levando em consideração o corte de
// notas passadas pelo sistema.

using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        int notaCorte;
        string A, B, C, nome, matricula, curso;
        int idade;
        bool cadastrar = true;
        Console.Write("Qual sistema será feito o cadastro do aluno ? Cada sistema tem sua própria nota de corte!\nSistemas : A, B, C - (Sair)\nResposta: ");
        string resposta = Console.ReadLine().ToUpper();


        while (cadastrar) 
        {
            for (int i = 0; i <= 30; i++)
            {
                Console.Write($"Informações do {i + 1} aluno");
                Console.WriteLine();
                Console.Write("Nome: "); nome = Console.ReadLine();
                Console.Write("Matricula: "); matricula = Console.ReadLine();
                Console.Write("Idade: "); Convert.ToInt32(Console.ReadLine());
                Console.Write("Curso: "); curso = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Qual sistema será feito o cadastro do aluno ? Cada sistema tem sua própria nota de corte!\nSistemas : A, B, C - (Sair)\nResposta: ");
                resposta = Console.ReadLine().ToUpper();
                i++;

                if (resposta == "Sair") ; cadastrar=false;
            }
        }

        switch (resposta)
        {
            case "A":
                notaCorte = 150;
                break;
            case "B":
                notaCorte = 180;
                break;
            case "C":
                notaCorte = 200;
                break;
        }
    }
}