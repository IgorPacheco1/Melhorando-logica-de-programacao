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


    static double CalcularMedia(Estudante[] ListaEstudantes)
    {
        int SomaMedia = 0;

        for (int i = 0; i < ListaEstudantes.Length; i++)
        {
            SomaMedia += EstudanteId.Nota; 
            //estou com dificuldade de entender como eu vou conseguir pegar o "ID" do estutante pra ter acesso a nota dele
        }   //talvez eu esteja complicando o simples com esse ID que eu criei.
        ;
        double Media = SomaMedia / ListaEstudantes;
        return (Media);
    }

    static void Main(string[] args)
    {

        System.Console.WriteLine("---Olá vc está iniciando o nosso sistema de cadastro de alunos---\nInsira a quantidade de alunos"); //voltar aqui dps para fazer um menu com switch para ser um sistema completo de cadastro
        int QuantidadeEstudantes = int.Parse(Console.ReadLine());

        Estudante[] ListaEstudantes = new Estudante[QuantidadeEstudantes];

        //agora q eu tenho o vetor vou começar a povoar ele
        
        for (int i = 0;i < QuantidadeEstudantes; i++)
        {
            ListaEstudantes[i] =  new Estudante();
            System.Console.WriteLine($"Informe o nome do {i+1}° estudante:");
            ListaEstudantes[i].Nome = Console.ReadLine();
            System.Console.WriteLine($"Informe anota do {i+1}° estudante:");
            ListaEstudantes[i].Nota = Console.ReadLine();
        }

        System.Console.WriteLine(CalcularMedia(ListaEstudantes));
    }
}