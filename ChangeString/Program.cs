using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //ask user for input(string)
            Console.Write("Insert String: ");
            string s = Console.ReadLine();
            

            //ask user fot input(Character)
            Console.Write("Insert Character: ");
            char Cha = Console.ReadKey().KeyChar;
            Console.WriteLine(); //stops new string being right after input char

            string s2 = s.Replace(Cha, 'x'); 


            Console.WriteLine($"New string = {s2}");


            
        }
    }
}
