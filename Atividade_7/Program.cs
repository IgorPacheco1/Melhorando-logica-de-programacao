using System.ComponentModel;

class program
{

    /* * --------------------------------------------------------------------------
  * DESAFIO DE RECURSIVIDADE 01.5: Contagem Regressiva
  * --------------------------------------------------------------------------
  * OBJETIVO: Criar uma função recursiva 'void' (que não retorna valor, apenas 
  * escreve no ecrã) que faça uma contagem regressiva de N até 0.
  * * EXEMPLO: Se N = 3, o ecrã deve mostrar:
  * * REQUISITOS:
  * 1. Caso Base: Se N for menor que 0, para a execução.
  * 2. Ação: Escrever o valor de N atual.
  * 3. Chamada: Chamar a função para N - 1.
  * * DICA: Como é uma função 'void', não usas 'return valor'. Usas apenas 
  * 'return;' para sair da função quando chegar no caso base, como o teu professor
  * fez em alguns exemplos de impressão[cite: 22, 24].
  * --------------------------------------------------------------------------
  */

    static void ContRegressiva(int N)
    {
        if (N < 0)
        {
            return N;
        }
        else
        {
        return N + (ContRegressiva(N-1));
        }
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine("Informe até qual numero será a contagem regressiva");
        int N = int.Parse(Console.ReadLine());
        System.Console.WriteLine(ContRegressiva(N));

    }
}