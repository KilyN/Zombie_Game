using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{
    class GameObjectManager        // require
    {
        //Keep track of all the enemies. 
        //Accessed by GameEventManger when calculating collision.
        //The List here is filled when the user creates the Zombies.
       public List<AbstractComp> enemies = null;

        //TODO: Observer Pattern related attributes and methods. 

        public GameObjectManager()
        {
            enemies = new List<AbstractComp>();
        }

    }
}
