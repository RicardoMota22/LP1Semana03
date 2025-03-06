using System;
using System.Diagnostics.Tracing;
using System.Threading;


namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        WarpShift ,
        Stealth,
        AutoHeal ,
        DoubleJump,
        
    };
    public class Program
    {
        private static void Main(string[] args)
        {
            
        //Specific letters count
        string input = args[0];
        char[] letterToCount = { 'w', 'a', 's', 'd' };
        Perks p_Perks = Perks.None;

        if (p_Perks = Perks.None)
        {
            Console.WriteLine();
        }

        if (letterToCount.Equals("w")== true)
        {
            p_Perks ^= Perks.WarpShift;
        }
        if (letterToCount.Equals("a")== true)
        {
            p_Perks ^= Perks.Stealth;
        }
        if (letterToCount.Equals("s")== true)
        {
            p_Perks ^= Perks.AutoHeal;
        }
        if (letterToCount.Equals("d")== true)
        {
            p_Perks ^= Perks.DoubleJump;
        }
        
        
            
       

        if ((p_Perks &Perks.WarpShift) ==Perks.WarpShift)
        Console.WriteLine("I heal you!");
           
        }
    }
}
