// 📋 Novo Cenário: Sistema de Controle de Estoque (Versão POO)
// Contexto:
// Você foi contratado por uma loja de tecnologia para gerenciar o estoque de produtos. Cada produto tem um nome e um preço unitário.

// O Desafio:

// A Classe: Crie uma classe chamada Produto com os atributos: Nome e Preco.

// O Inventário: No Main, pergunte quantos produtos diferentes o usuário deseja cadastrar.

// O Cadastro: Crie um vetor de objetos para armazenar esses produtos e preencha-os via teclado.

// Relatório Final: Após cadastrar tudo, o programa deve exibir:

// A lista de todos os produtos com seus preços.

// O valor total do inventário (a soma de todos os preços).

// O nome do produto mais caro da loja.



class Produto
{
    public string Nome;
    public double Preco;
}

class program
{

    static string CalcularMaiorPreco(Produto[] lista)
    {   double Maior=0;
        string Nome="";
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i].Preco>Maior)
            {
                Maior = lista[i].Preco;
                Nome  = lista[i].Nome;
            }
        }
        return(Nome);
    }

    static void ExibirDados(Produto[] lista)
    {   
        double SomaPreco = 0;
        for (int i = 0; i < lista.Length; i++)
        {
            
            SomaPreco += lista[i].Preco;
            System.Console.WriteLine($"\nNome: {lista[i].Nome}\nPreço: {lista[i].Preco}\n");
        }
        System.Console.WriteLine($"---O Valor total do estoque---\n{SomaPreco}\n---O Produto de maior valor no estoque---\n{CalcularMaiorPreco(lista)}");
        
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine($"---BEM VINDO A SISTEMA DE CADASTRO DE PRODUTOS--\nQual a quantidade de produtos que deseja cadastrar?");
        int QuantidadeProdutos = int.Parse(Console.ReadLine());

        Produto[] ListaProdutos = new Produto[QuantidadeProdutos];

        for (int i = 0; i < ListaProdutos.Length; i++)
        {
            ListaProdutos[i] = new Produto(); //acabei esquecendo de que para armarzenar eu tenho que primeiro criar o item da minha classe
            System.Console.WriteLine($"Informe o nome do {i + 1}° produto:");
            ListaProdutos[i].Nome = Console.ReadLine();
            System.Console.WriteLine($"Informe o preço do {i + 1}° produto:");
            ListaProdutos[i].Preco = double.Parse(Console.ReadLine());

        }
            
        ExibirDados(ListaProdutos);
    }
}