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
    static double CalcularMedia(int[] vetor)
    {
        //o que é preciso para calcular a media?
        // fazer ele percorrer todo o vetor e ir somando, após isso dividir pela a quantidade que tem no vetor

        int SomaMedia = 0;
        double Media = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            SomaMedia += vetor[i];
        }
        Media = (double)SomaMedia / vetor.Length;

        return (Media);

    }
    static int AcimaMedia(int[] vetor, double Media)
    {
        int ContAcimaMedia = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i] > Media)
            {
                ContAcimaMedia++;
            }
        };

        return(ContAcimaMedia);
    }

    static void ExibirTudo(double media,int AcimaMedia)
    {
        System.Console.WriteLine($"--Relatório final--\nA média total da turma foi de {media} pontos\nO total de alunos que ficaram acima da média foram de {AcimaMedia} alunos");
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Insira a quantidade de alunos possui na turma");
        int QuantidadeAlunos = int.Parse(Console.ReadLine());
        int[] Alunos = new int[QuantidadeAlunos];

        for (int i = 0; i < Alunos.Length; i++)
        {
            System.Console.WriteLine($"Informe a nota do {i + 1}° aluno");
            Alunos[i] = int.Parse(Console.ReadLine());
        }


    }

}
