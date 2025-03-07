using System;
using System.Diagnostics.Tracing;
using System.Threading;


namespace HeroPerk
{
    [Flags]
    enum Perks
    {
    
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
        Perks p_Perks = 0;

        //switches roles if they are on or off
        foreach (char c in input)
            {
                switch (c)
                {
                    case 'w': p_Perks ^= Perks.WarpShift; break;
                    case 'a': p_Perks ^= Perks.Stealth; break;
                    case 's': p_Perks ^= Perks.AutoHeal; break;
                    case 'd': p_Perks ^= Perks.DoubleJump; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
       

        
            
        if (p_Perks == 0)
            {
                Console.WriteLine("!No perks at all!");
                return;
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
