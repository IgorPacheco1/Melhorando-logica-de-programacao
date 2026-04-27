/* * --------------------------------------------------------------------------
 * DESAFIO DE RECURSIVIDADE 01: Soma de 1 até N
 * --------------------------------------------------------------------------
 * OBJETIVO: Criar uma função recursiva que receba um número inteiro N 
 * e retorne a soma de todos os números de 1 até N.
 * * EXEMPLO: Se N = 4, o resultado deve ser 10 (1 + 2 + 3 + 4).
 * * REQUISITOS:
 * 1. A função deve chamar-se 'SomaRecursiva'.
 * 2. Identificar o Caso Base (Qual o valor de N que faz a soma parar?).
 * 3. Criar a Chamada Recursiva (Basear-se na lógica do Fatorial).
 * --------------------------------------------------------------------------
 */


using System.Runtime.InteropServices.Marshalling;

class program
{
    
    static int SomaRecursiva(int i)
    {
        if (i==1)
        {
            return(i); // no caso esse seria o caso base para ser trabalhado. Pensar sempre que o caso base vai ser o problema mais simplificado possivel.

        }
        else
        {
            return i+ SomaRecursiva(i-1); // ANALOGIA PARA CONSEGUIR ENTENDER MELHOR
            //tarefa: "Soma até 4".Como é preguiçoso (recursivo),vc diz ao Marinheiro 3: "Toma o número 4. 
            // Quando saber a soma de 1 até 3, avisa que eu somo o 4 ao seu resultado". O Marinheiro 3 diz ao Marinheiro 2: "Toma o 3.
            // Quando saber a soma de 1 até 2, avisa que eu somo o 3 ao seu resultado". Isso continua até chegar ao Marinheiro 1.
            //  Como ele é o Caso Base, ele não delega. Ele apenas responde: "A soma de 1 até 1 é 1!".


            //imagina que quero calcular a SomaRecursiva(3)

            // vai entrar no if(3==1)? Não
            // entt ele guarda o 3 {e espera o resultado de SomaRecursiva(2)}
            // agora vai repetir isso tudo de nv, até chegar no caso base, com isso vamos ter todos os resultados.
        }
        
    }

    static void Main(String[] args)
    {
        System.Console.WriteLine("Informe ate que numero deseja somar");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine(SomaRecursiva(n));


    }


}