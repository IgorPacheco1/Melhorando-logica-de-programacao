//🎯 Desafio: A Média e os Acima da Média
//O professor agora quer um relatório mais completo. O programa deve:

//Perguntar quantos alunos há na turma (n).

//Ler as notas de todos os n alunos e armazená-las em um vetor.

//Calcular a média aritmética da turma.

//No final, exibir a média e dizer quantos alunos ficaram acima dessa média.

int ContadorAcimaMedia = 0;
int Soma = 0;
double Media=0;
System.Console.WriteLine("Informe a quantidade de alunos na turma");
int QuantidadeAlunos = int.Parse(Console.ReadLine());

int[] Alunos = new int[QuantidadeAlunos];

for (int i = 0; i < Alunos.Length; i++)
{
    System.Console.WriteLine($"Informe a nota do {i + 1}° aluno");
    Alunos[i] = int.Parse(Console.ReadLine());
    Soma = Soma + Alunos[i];
    Media = (double) Soma / QuantidadeAlunos;
    if (Alunos[i]>Media)
    {
        ContadorAcimaMedia++;
    }
}
System.Console.WriteLine($"{Soma}");
System.Console.WriteLine($"{Media.ToString("F2")}");

System.Console.WriteLine($"O resultado final é o seguinte:\nA media da turma é de {Media}\nQuantidade de alunos que ficaram acima da media foram {ContadorAcimaMedia}");
