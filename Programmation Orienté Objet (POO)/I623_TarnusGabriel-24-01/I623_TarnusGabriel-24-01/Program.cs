using System;

namespace I623_TarnusGabriel_24_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Character beatrice = new Character("Baudson", "Béatrice", 120);
            Gun ar15 = new Gun(0, "AR15");

            bool left = false;

            string play;
            string action;
            int kills = 0;

            Console.WriteLine("Welcome to war " + beatrice.FirstName + "! Ready to kill bad students?? space if yes");
            play = Console.ReadLine();
            Console.Clear();

            if(play == " ")
            {
                do
                {
                    Console.WriteLine(beatrice.ViewATH(ar15, kills));

                    if (ar15.Magazine == 0 && beatrice.Ammuninitions == 0)
                    {
                        Console.WriteLine("You're out of ammos. Hurry pick some ammos, or the students will kill you!");
                    }
                    else
                    {
                        if (ar15.Magazine == 0)
                        {
                            Console.WriteLine("Magazine empty! Reload recommanded");
                        }
                    }
                     


                    Console.WriteLine("Commands : \nr : Reload \nq : Quit \na : Find ammos \nSpace : Shoot");
                    action = Console.ReadLine();

                    switch (action)
                    {
                        case "r":
                            Console.WriteLine(ar15.Reload(beatrice));
                            Console.ReadLine();
                            break;

                        case "q":
                            left = beatrice.LeftTheGame();
                            break;

                        case "a":
                            Console.WriteLine(beatrice.RefillAmmunitions());
                            Console.ReadLine();
                            break;

                        case " ":
                            Console.WriteLine(ar15.Shoot(ref kills));
                            Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("You're not going to do a lot of things if you choose nothing!");
                            break;
                    }
              
                    Console.Clear();
                } while (!left);

                Console.WriteLine("Thank you for saving the school " + beatrice.FirstName + ". Your name will be remembered. With the " + kills + " students you killed savagely, the school will be a better place");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("I see... You don't have the will to kill your students. Fine, I'll do it myself");
                Console.ReadLine();
            }
            
        }
    }
}
