using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{
    public class Busket : Decorator           
    {
        private int health = 100;
        private char type = 'b';
      

        public Busket (AbstractComp bZ): base(bZ)
        {
            _baseZombie = bZ;
                
        }

        public override int takeDamage(int d)
        {
            int LeftOver = d - health;
            health = health - d;
            if (health <= 0)
                this._baseZombie.takeDamage(LeftOver);
            return LeftOver;
        }
        

        public override bool isMetal()
        {
            return true;
        }
    

        public override int getHealth()  
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
