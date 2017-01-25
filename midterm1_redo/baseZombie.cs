using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{
    public class baseZombie : AbstractComp
    {
        private int health = 50;
        private char type = 'r';

        public override int takeDamage(int d)
        {
            int LeftOver = d - health;
            health = health - d;
            return LeftOver;

        }
    
        public override bool isMetal()
        {
            return false;
        }
        public override int getHealth() 
        {
            return this.health;


        }
        public override char getType()
        {
            return this.type;
        }
        public override bool die()
        {
            return (health <= 0);
        }


    }
}
