//🎯 Nosso Primeiro Desafio de Lógica
//Imagine que precisamos criar um programa que ajude um professor a analisar as notas de uma turma. O programa deve:

//Pedir a quantidade de alunos (n).

//Ler a nota de cada um desses n alunos.

//No final, mostrar a maior nota e quantos alunos tiraram nota acima de 60.

int MaiorNota = 0;
int ContadorNotas = 0;
System.Console.WriteLine("informe a quantidade de alunos que realizaram a prova");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine($"Informe qual a nota está na {i + 1}° prova: \n\nLembrando que a estrutura de notas a ser seguida é de 0 a 100");
    int nota = int.Parse(Console.ReadLine());
    if (nota > MaiorNota)
    {
        MaiorNota = nota;
    }
    if (nota > 60)
    {
        ContadorNotas++;
    }
}
System.Console.WriteLine($"A maior nota entre os {n} alunos foi a de {MaiorNota} \n\nE o número de alunos que ficaram com a pontuação acima de 60 foram de {ContadorNotas}");