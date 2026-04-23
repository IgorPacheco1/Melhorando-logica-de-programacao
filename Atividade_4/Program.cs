// 📋 Exercício: Sistema de Gestão de Notas (POO)

// Objetivo: Desenvolver um programa que utilize uma Classe para representar um estudante e um Vetor para gerenciar uma pequena turma.

// O enunciado:

// Crie uma classe chamada Estudante que contenha os atributos necessários para armazenar o nome e a nota de um aluno.

// No programa principal (Main), solicite ao usuário a quantidade de alunos que deseja cadastrar.

// Utilize um vetor de objetos da classe Estudante para armazenar os dados de todos os alunos informados.

// Após o preenchimento de todos os dados, o programa deve percorrer o vetor e exibir na tela:

// A listagem de todos os nomes e suas respectivas notas.

// A média geral da turma.

// O nome do aluno que obteve a maior nota da turma.
class Estudante
{
    public string Nome;
    public double Nota;

}

class program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine("---Olá vc está iniciando o nosso sistema de cadastro de alunos---\nInsira a quantidade de alunos"); //voltar aqui dps para fazer um menu com switch para ser um sistema completo de cadastro
        int QuantidadeAlunos = int.Parse(Console.ReadLine());

        Estudante [] ListaEstudantes = new Estudante[QuantidadeAlunos];
        


    }
}