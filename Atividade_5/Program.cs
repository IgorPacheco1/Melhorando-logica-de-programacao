// 🏛️ Desafio: O Gestor de Estoque ProfissionalContexto:
// A loja de tecnologia percebeu que o sistema antigo permitia erros graves, como cadastrar preços negativos ou exibir informações bagunçadas.
//  Eles precisam de uma versão "blindada" e mais inteligente do software.

//  Sua Missão:
//  A Entidade Produto:Crie uma estrutura para o Produto que impeça que o preço seja alterado para um valor negativo. Se alguém tentar inserir um valor abaixo de zero, o sistema deve automaticamente ajustar para zero (ou impedir a alteração).

//  O nome do produto deve ser acessível para leitura e escrita, mas protegido por uma lógica de acesso controlada.
//  A Inteligência do Objeto:O Produto não deve ser apenas um depósito de dados. Ele deve ser capaz de fornecer, por conta própria, uma linha de texto formatada com seus dados (Nome e Preço) pronta para ser exibida em um relatório, sem que o programador do Main precise montar a frase manualmente.

//  O Fluxo do Sistema:Solicite a entrada de $N$ produtos.

//  Após o cadastro, o sistema deve processar o inventário e exibir:A lista formatada gerada pelos próprios produtos.O valor total acumulado de todos os itens.

//  O nome do item que representa o maior investimento (maior preço) da loja.Regra de Ouro do Mentor:Tente fazer com que o seu Main seja o mais "limpo" possível.

//   O Main deve apenas coordenar, enquanto a classe Produto deve cuidar da integridade dos seus próprios dados.Dica para começar:

//   Pense no "porteiro" (get/set) que discutimos. Como você impediria que o preço fosse negativo ali dentro?Estou ansioso para ver como você vai estruturar essa "blindagem"! 



class Produto
{
    private string _Nome;
    private double _Preco;

    public string Nome
    {
        get { return _Nome; } //pelo que eu entendi dessa parte de encapsulamento, o get serve para permitir ler o valor, tanto que o return vai ser o private. 
        set { _Nome = value; }
    }

    public double Preco
    {
        get { return _Preco; }
        set
        {
            if (value >= 0)
            {
                _Preco = value;
            }
            else
            {
                _Preco = 0;
            }
        }
    }
}

class program
{

    static string CalcularMaiorPreco(Produto[] lista)
    {
        double Maior = 0;
        string Nome = "";
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i].Preco > Maior)
            {
                Maior = lista[i].Preco;
                Nome = lista[i].Nome;
            }
        }
        return (Nome);
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