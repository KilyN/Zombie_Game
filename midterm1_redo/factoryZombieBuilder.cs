using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{/// <summary>
/// build all Zombie with acessories
/// </summary>
    class factoryZombieBuilder
    {


        /// <summary>
        /// make regular Zombie and return
        /// </summary>
        /// <returns></returns>
        public baseZombie makeZombie()     // regularZombie
        {
            return new baseZombie();  // heath of each zomebie
        }
        /// <summary>
        /// make ConeZombie and return
        /// </summary>
        /// <param name="bZ"></param>
        /// <returns></returns>
        public Cone makeCone(AbstractComp bZ)
        {
            return new Cone(bZ);

        }
        public Busket makeBusket(AbstractComp bZ)
        {
            return new Busket(bZ);

        }
        public ScreenDoor makeScreendoor(AbstractComp bZ)
        {
            return new ScreenDoor(bZ);
        }

     

    }





}
