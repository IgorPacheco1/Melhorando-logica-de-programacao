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






    static void Main(string[] args)
    {
        System.Console.WriteLine($"---BEM VINDO A SISTEMA DE CADASTRO DE PRODUTOS--\nQual a quantidade de produtos que deseja cadastrar?");
        QuantidadeProdutos =  int.Parse(Console.ReadLine());

        Produto[] ListaProdutos = new Produto[QuantidadeProdutos];

        
    }
}