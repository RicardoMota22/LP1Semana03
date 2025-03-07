using System;
using System.Diagnostics.Tracing;
using System.Threading;


namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        None = 0,
        WarpShift = 1,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8
        
    };
    public class Program
    {
        private static void Main(string[] args)
        {
            
        //Specific letters count
        string input = args[0];
        char[] letterToCount = { 'w', 'a', 's', 'd' };
        Perks p_Perks = Perks.None;


        if (letterToCount.Equals('w')== true)
        {
            p_Perks ^= Perks.WarpShift;
        }
        if (letterToCount.Equals('a')== true)
        {
            p_Perks ^= Perks.Stealth;
        }
        if (letterToCount.Equals('s')== true)
        {
            p_Perks ^= Perks.AutoHeal;
        }
        if (letterToCount.Equals("d")== true)
        {
            p_Perks ^= Perks.DoubleJump;
        }
        else      //if it includes another letter
        {
            Console.WriteLine("!Unknown perk!");
        }
       

        
            
        if (p_Perks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
            }
            else
            {
                Console.WriteLine(p_Perks);

                if ((p_Perks & Perks.Stealth) != 0 && (p_Perks & Perks.DoubleJump) != 0)
                {
                    Console.WriteLine("!Silent jumper!");
                }

                if ((p_Perks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("!Not gonna make it!");
                }

            }

        }
    }
}
