// 📝 Desafio: O Analista de Desempenho Escolar
// Contexto:
// Você foi contratado para criar um pequeno módulo de um sistema escolar. O objetivo é analisar o desempenho de uma turma de alunos em uma prova.

// O que o programa deve fazer:

// Entrada de Dados: Perguntar ao usuário quantos alunos a turma possui.

// Armazenamento: Ler a nota de cada aluno e guardá-las em um vetor (Array).

// Processamento Parte A (Média): Calcular a média aritmética simples de todas as notas da turma.

// Processamento Parte B (Destaques): Verificar, nota por nota, quais alunos conseguiram uma pontuação maior ou igual à média calculada.

// Saída: Exibir o valor da média da turma e a quantidade total de alunos que ficaram "acima ou na média".
class program
{
    static void Main(string[] args)
    {
        int [] Alunos = new int [QuantidadeAlunos];

        System.Console.WriteLine("Insira a quantidade de alunos possui na turma");
        int QuantidadeAlunos = int.Parse(Console.ReadLine());

        for (int i = 0; i < Alunos.Length; i++)
        {
            System.Console.WriteLine($"Informe a nota do {i+1}° aluno");
            Alunos [i] = int.Parse(Console.ReadLine());
        }



    }

}
