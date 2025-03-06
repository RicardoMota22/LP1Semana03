using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {


            //ask console for 6 args
            foreach (string s in args)
            {
                if (s.Length == 0)
                {
                    Console.WriteLine("[EARLY STOP]");
                    return;
                }
                if (s.Length > 0)
                {
                    Console.WriteLine(s);
                }

            }

            
            // bidimensional 2x2
            float [ ,] matrix =new float[2, 2];
            //float matrixFloat = float.Parse(matrix, CultureInfo.InvariantCulture);

            

            
        }
    }
}
