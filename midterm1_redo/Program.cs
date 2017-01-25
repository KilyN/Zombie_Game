using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm1_redo
{


    public class Program
    {

        static void Main(string[] args)
        {

            //List<AbstractComp> zombie = new List<AbstractComp>();
            factoryZombieBuilder makeEachTypeZombie = new factoryZombieBuilder();
            GameObjectManager GOM = new GameObjectManager();                           //list of enemies
            GameEventManager GEM = new GameEventManager();                             // game event

            int pDamage = 25;           // does damage on all Zombies
                                        // int wDamage = 30;           // does damage on SDZombie directly
                                        //  for mgnetDamage         // call die() on SD and busket

            string choice1 = "";
            string choice2 = "";



            while (true)
            {
                Menu1();                           // 1.create or 2.demo
                choice1 = Console.ReadLine();

                if (choice1 == "q") break;

                if (choice1 == "1")

                {
                    while (true)

                    {
                        Menu2();                     // what kind of zombie

                        choice2 = Console.ReadLine();
                        if (choice2 == "q") break;

                        AbstractComp enermy = builder(choice2, makeEachTypeZombie);

                        // after accessary are being built
                        //AbstractComp accessaryZ = makeEachTypeZombie.getResult();

                        if (enermy != null)
                        {

                            //zombie.Add(accessaryZ);
                            GOM.enemies.Add(enermy);

                        }


                        printZombieList(GOM.enemies);
                    }




                }

                else if (choice1 == "2")                        // play game
                {
                    //Console.WriteLine("");

                    Console.WriteLine("(Default damage is 25!)" + "Please enter damage:");

                    string Sdamage = Console.ReadLine();       // input new damage

                    if (Sdamage != "")
                        Int32.TryParse(Sdamage, out pDamage);



                    int count = 0;

                    while (GOM.enemies.Count() != 0)
                    {
                        Console.WriteLine("Round" + count + ": ");
                        count++;

                        printZombieList(GOM.enemies);


                        Console.WriteLine("\np:peaShooter\nw:waterMelonShooter\nm:magnetShooter");

                        string choice3 = Console.ReadLine();       // pick p,m,w

                        GEM.simulateCollisionDetection(choice3, pDamage, GOM);

                        //zombie.ElementAt(0).takeDamageFront(pDamage);    // peaShooter
                        //if (zombie.ElementAt(0).die())
                        //{
                        //    zombie.RemoveAt(0);
                        //}


                    }
                    printZombieList(GOM.enemies);
                }










            }




            // Console.ReadKey();


        }

        static AbstractComp builder(string x, factoryZombieBuilder makeZombie)
        {
            AbstractComp regZ = makeZombie.makeZombie();
            switch (x)

            {
                case "1":

                    break;
                case "2":
                    return makeZombie.makeCone(regZ);

                case "3":
                    return makeZombie.makeBusket(regZ);


                case "4":
                    return makeZombie.makeScreendoor(regZ);




            }
            return makeZombie.makeZombie();
        }

        public static void printZombieList(List<AbstractComp> zombie)
        {


            Console.Write("[ ");
            for (int i = 0; i < zombie.Count(); i++)
            {
                AbstractComp a = zombie.ElementAt(i);
                Console.Write(a.getType() + "/" + a.getHealth() + ",");
            }

            Console.Write("]");

        }





        public static void Menu1()
        {
            Console.WriteLine("\n1. Create zombies?");
            Console.WriteLine("2. Demo game play?");
            Console.WriteLine("q to exit");

        }

        public static void Menu2()
        {
            Console.WriteLine("\nWhich kind?");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Cone");
            Console.WriteLine("3. Bucket");
            Console.WriteLine("4. ScreenDoor");
            Console.WriteLine("q to Exit");

        }

    }
}
