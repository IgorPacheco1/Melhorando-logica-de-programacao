//🎯 Desafio: A Média e os Acima da Média
//O professor agora quer um relatório mais completo. O programa deve:

//Perguntar quantos alunos há na turma (n).

//Ler as notas de todos os n alunos e armazená-las em um vetor.

//Calcular a média aritmética da turma.

//No final, exibir a média e dizer quantos alunos ficaram acima dessa média.



System.Console.WriteLine("Informe a quantidade de alunos na turma");
int QuantidadeAlunos = int.Parse(Console.ReadLine());

int[] Alunos = new int[QuantidadeAlunos];

for (int i = 0; i < QuantidadeAlunos.length; i++)
{
    System.Console.WriteLine($"Informe a nota {i + 1}");
    QuantidadeAlunos[i] = int.Parse(Console.ReadLine());
}



