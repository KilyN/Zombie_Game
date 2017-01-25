using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace midterm1_redo
{
    public abstract class AbstractComp
    {
        public int health;

        public char type;
        public abstract bool isMetal();

        public abstract int getHealth();
        public abstract char getType();
        public abstract bool die();
       
        public abstract int takeDamage(int d);
   

    }
}
