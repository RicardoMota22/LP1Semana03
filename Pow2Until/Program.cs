using System;

namespace Pow2Until
{
    public class Program
    {
        private static void Main(string[] args)
        {
            for ( int i = 1; i <= (1 << 5); i = i << 1)
            {
            Console . WriteLine ( i );
            }
        }
    }
}
