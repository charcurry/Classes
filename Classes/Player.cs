using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        public int health;
        public int shield;
        public int score;

        public int x; //position
        public int y; //position

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
