using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes");
            Console.WriteLine();

            ////variables
            //int score; // declaration
            //score = 0;
            //Console.WriteLine("Score: " + score);

            ////array
            //int[] ammo; //declaration
            //ammo = new int[5]; //instantiation
            //ammo[0] = 5;

            Player player; //declaration
            player = new Player(); //instantiation

            Enemy smallEnemy;
            smallEnemy = new Enemy();
            Enemy largeEnemy;
            largeEnemy = new Enemy();

            Enemy[] smallEnemies; //declaration
            smallEnemies = new Enemy[100];
            for (int i = 0; i < smallEnemies.Length; i++)
            {
                // ...
            }

            player.x = 0;
            player.y = 0;
            player.health = 50;

            smallEnemy.health = 25;
            smallEnemy.x = 10;
            smallEnemy.y = 10;

            largeEnemy.health = 50;
            largeEnemy.x = 11;
            largeEnemy.y = 11;

            Console.WriteLine("Player Health: " + player.health);
            player.Heal(100);
            Console.WriteLine("Player Health: " + player.health);
            Console.WriteLine("Enemy Health: " + smallEnemy.health);
            Console.WriteLine("Enemy Health: " + largeEnemy.health);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
