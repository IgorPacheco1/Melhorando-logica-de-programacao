class program
{
    static int SomaElementos(int[] Vetor, int QuantidadeVetor, int IndiceVetor)
    {
        if (IndiceVetor == QuantidadeVetor)
        {
            return SomaElementos;
        }
        else
        {
            return SomaElementos(Vetor, QuantidadeVetor, IndiceVetor + 1);
        }
    }

    static void Main(string[] args)
    {
        int[] VetorNumeros = new int[20];
        for (int i = 0; i < VetorNumeros.Length; i++)
        {
            Random NumAleatorio = new Random();
            int NumAleatorioAtual = NumAleatorio.Next(1, 50);
            VetorNumeros[i] = NumAleatorioAtual;
            System.Console.WriteLine(VetorNumeros[i]);
            System.Console.WriteLine(SomaElementos(VetorNumeros, 20, 0));
        }
    }
}