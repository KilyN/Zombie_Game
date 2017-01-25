using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{
    public class ScreenDoor : Decorator            
    {

        private int health = 25;
        private char type = 's';
        //private bool metal = true;                    // override metal to true

        public override int takeDamage(int d)
        {
            int LeftOver = d - health;
            health = health - d;
            if (health <= 0)
                this._baseZombie.takeDamage(LeftOver);
            

            return LeftOver;

        }

        public ScreenDoor(AbstractComp bZ): base(bZ)
        {
            _baseZombie = bZ;

        }

        public override bool isMetal()
        {
            return true;
        }

        //public override int takeDamageAbove(int d)  // SD become regZombie
        //{
        //    return this.health = 0;
        //}

        public override int getHealth()  // fuctioning similar to getter
        {
            return this.health+_baseZombie.getHealth();


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
