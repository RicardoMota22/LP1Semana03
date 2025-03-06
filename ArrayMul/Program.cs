using System;
using System.Globalization;


namespace ArrayMul
{
    public class Program
    
    {
        private static void Main(string[] args)
        {

            
            //ask console for 6 args
            foreach (string s in args)
            {
                if (args.Length != 6)
                {
                    Console.WriteLine("insert 6 floats ");
                    return;
                }
                

            }

            float[,] m2 = new float[2, 2]; //first 4 args
            float[] v = new float[2]; //last 2 args
            float[] result = new float[2]; // the multiplied value

            //Parse first 4 args into float
            int index = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m2[i, j] = float.Parse(args[index], CultureInfo.InvariantCulture);
                    index++;
                }
            }

            //Parse last 4 args into float
            for (int i = 0; i < 2; i++)
            {
                v[i] = float.Parse(args[index], CultureInfo.InvariantCulture);
                index++;
            }

            //Multiply x2(matriz 2x2) and v(vector 1x2)
            for (int i = 0; i < 2; i ++)
            {
                result[i]=0;
                for (int j = 0; j < 2; j++)
                {
                    result[i] += m2[i, j] * v[j];
                }
            }
            
            foreach (var value in result)
            {
                Console.WriteLine("|{0,7:F2}|", value); //Formats spaces
            }


            

            

            
        }
    }
}
