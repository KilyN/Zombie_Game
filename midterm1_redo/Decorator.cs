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
        // private List<AbstractComp> child = new List<AbstractComp>(); // make a list of zombie

        public AbstractComp _baseZombie = null;      // keep baseZombie reference

        public Decorator(AbstractComp baseZombie)
        {
            _baseZombie = baseZombie;
        }
        //public override int getHealth()
        //{
        //    int heathStorage = 0;


        //    for (int i = 0; i < child.Count(); i++)
        //    {

        //       heathStorage += child.ElementAt(i).getHealth();
        //    }
        //    return heathStorage;



        //}



        //public override char getType()     // one type in each kind
        //{
        //    char type = '\0';


        //        type = child.ElementAt(0).getType();


        //    return type;
        //}
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

        //public override int takeDamageFront(int d)
        //{
        //    int LeftOver = d;
        //    for (int i = 0; i < child.Count()&&LeftOver > 0; i++)
        //    {

        //            LeftOver = child.ElementAt(i).takeDamageFront(LeftOver);

        //        //if (child.ElementAt(i).die())
        //        //{
        //        //    this.remove(i); // remove die child
        //        //    i--;
        //        //}

        //    }
        //    return LeftOver;
        //}
        //public override int takeDamageAbove()
        //{
        //    throw new NotImplementedException();
        //}

        // return reference _baseZombie







        //public override void add(AbstractComp z)
        //{
        //    child.Add(z);
        //}

        //public override void remove(int x)
        //{
        //    child.RemoveAt(x);
        //}

    }
}
