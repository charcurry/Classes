using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        //defaults to private

        public int health;
        public int shield;
        public int score;

        public int x; //position
        public int y; //position

        //constructor

        public Player()
        {
            Console.WriteLine("Player constructed");

            health = 100;
            shield = 0;
            score = 0;
            x = 0; y = 0;
        }

        public void Heal(int hp)
        {
            if (health +  hp > 100) 
            {
                health = 100;
            }
            else
            {
                health += hp;
            }
        }

    }
}
