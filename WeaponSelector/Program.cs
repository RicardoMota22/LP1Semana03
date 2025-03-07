using System;

namespace WeaponSelector
{
    [Flags]
    enum Weapons
    {
    
        None,
        SilverBullet,
        Garlic,
        HolyWater,
        
    };

    enum EnemyType
    {
    
        Zombie,
        Vampire,
        Werewolf,
        Ghost,
        
    };
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            EnemyType enemy = Enum.Parse<EnemyType>(args[0]);
            Weapons weapon = ParseWeapons(args);
            bool dies = WeaponsKillEnemy(enemy, weapon);
            DisplayResult(enemy, dies);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the weapon.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The weapons.</returns>
        private static Weapons ParseWeapons(string[] args)
        {
            Weapons weapon = Enum.Parse<Weapons>(args[1]);
            if (weapon == 0)
                return Weapons.None;
            else 
                return weapon;


        }

        /// <summary>
        /// Is the enemy killed with any of the weapons?
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        /// <param name="weapons">The weapons used to try and kill the enemy.</param>
        /// <returns>Wether the enemy was killed or not.</returns>
        private static bool WeaponsKillEnemy(EnemyType enemy, Weapons weapons)
        {
            // ////////// //
            // CHANGE ME! //
            // ////////// //
            
            if (EnemyType.Zombie, Weapons.SilverBullet == true)

        /// <summary>
        /// Display information on wether the enemy was killed or not.
        /// </summary>
        /// <param name="enemy">The enemy we're trying to kill.</param>
        private static void DisplayResult(EnemyType enemy, bool survives)
        {
            // ////////// //
            // CHANGE ME! //
            // ////////// //
            if (survives == false)
                Console.WriteLine($"{enemy} dies");
                
            else        
            Console.WriteLine($"{enemy} survives");
            return;
                    

                }
            }

            
        }
    }
}
