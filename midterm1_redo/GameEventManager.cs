using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{
    class GameEventManager
    {
        //Called when collision is detected between a Bullet b and an Enemy e
        //In a real implementation, the operation will get the damage from the //Bullet b. For instance:
        public void doDamage(int b, AbstractComp e)
        {
            // int damage = b.getDamage();
            e.takeDamage(b);
        }


        //public void applyMagnetForce(AbstractComp e)
        //{
        //    //If it's a metal accessory, we call 
        //    //a "removeMetalAccessory()" method of e.

        //    //TODO: complete this method.
        //    //Hint: a simple type-check is necessary here.
        //}

        //To separate the responsibilities, the above methods should not 
        //be called directly from your code handling user-interaction. 
        //Instead, it should be done in this “hub” operation in the control 
        //class. Since we are simulating, we pass an “int” to represent the 
        //plant. 
        public void simulateCollisionDetection(string choice, int d, GameObjectManager GOM)
        {
            //The method gets access to the “enemies” list in GameObjectManager
            //and finds the first Enemy to be the one to collide with.  
            //Then, it passes e to one of the fucntions above.
            Decorator zombie = null;
            //TODO: complete this method.
            if (choice == "w")       // waterMelonShooter
            {
                if (GOM.enemies[0].getType() == 's')
                {

                    ScreenDoor screenDoor = (ScreenDoor)GOM.enemies[0];     //screenDoor gets hit directly

                    doDamage(30, screenDoor._baseZombie);
                    GOM.enemies[0] = screenDoor;

                    if (screenDoor._baseZombie.die())
                    {
                        GOM.enemies.RemoveAt(0);
                    }
                }
                else // not screenDoor
                {

                    doDamage(30, GOM.enemies[0]);
                }
            }

            else if (choice == "p")
            {
                doDamage(d, GOM.enemies[0]);
            }
            else if (choice == "m")
            {
                if (GOM.enemies[0].isMetal())
                {
                    Decorator decoratorZombie = (Decorator)GOM.enemies[0];
                    GOM.enemies.RemoveAt(0);
                    GOM.enemies.Insert(0, decoratorZombie.Die());
                }

            }
            //not empty list
            if (GOM.enemies.Count > 0)
            {
                if (GOM.enemies[0].die()) // remove accessory if zombie is dead
                {

                    if (GOM.enemies[0].getType() != 'r')
                    {
                        zombie = (Decorator)GOM.enemies[0];
                        GOM.enemies.RemoveAt(0);
                        if (!zombie.isDead())
                        {
                            GOM.enemies.Insert(0, zombie.Die());     // replace with normalZombie
                        }

                    }
                    else
                    {
                        GOM.enemies.RemoveAt(0);
                    }

                }
            }

        }




    }
}
