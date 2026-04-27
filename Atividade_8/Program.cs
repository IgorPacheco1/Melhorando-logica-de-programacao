class program
{
    // static int SomaElementos(int[] V)
    // {

    // }

    static void Main(string[] args)
    {
        int[] VetorNumeros = new int[20];
        for (int i = 0; i < VetorNumeros.Length; i++)
        {
            Random NumAleatorio = new Random();
            int NumAleatorioAtual = NumAleatorio.Next(1,50);
            VetorNumeros[i] = NumAleatorioAtual;
            System.Console.WriteLine(VetorNumeros[i]);
        }
    }
}