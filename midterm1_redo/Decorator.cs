using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace midterm1_redo
{
    public abstract class Decorator : AbstractComp           // decorator class
    {
      

        public AbstractComp _baseZombie = null;      // keep baseZombie reference

        public Decorator(AbstractComp baseZombie)
        {
            _baseZombie = baseZombie;
        }
      
        public bool isDead()
        {
            if (this._baseZombie.getHealth() <= 0)
                return true;

            return false;
        }
        public AbstractComp Die()
        {
            return _baseZombie;

        }

    }
}
