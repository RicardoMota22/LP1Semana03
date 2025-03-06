using System;
using System.Globalization;


namespace ArrayMul
{
    public class Program
    
    {
        private static void Main(string[] args)
        {

            
        if (args.Length != 6)
        {
            Console.WriteLine("Uso correto: dotnet run -- arg1 arg2 arg3 arg4 arg5 arg6");
            return;
        }

        float[,] A = new float[2, 2];
        float[] b = new float[2];
        float[] result = new float[2];

        // Preenchendo a matriz A e o vetor b
        A[0, 0] = float.Parse(args[0]);
        A[0, 1] = float.Parse(args[1]);
        A[1, 0] = float.Parse(args[2]);
        A[1, 1] = float.Parse(args[3]);
        b[0] = float.Parse(args[4]);
        b[1] = float.Parse(args[5]);

        // Multiplicação A * b
        for (int i = 0; i < 2; i++)
        {
            result[i] = 0;
            for (int j = 0; j < 2; j++)
            {
                result[i] += A[i, j] * b[j];
            }
        }

            

            

            
        }
    }
}
