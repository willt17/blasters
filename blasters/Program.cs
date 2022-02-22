using System;

namespace blasters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BlastersStart();
        }
        static void BlastersStart()
        {
            System.Console.WriteLine("Welcome to blasters.");
            System.Console.WriteLine("Prepare to play");
            CallShot();
        }
        static void CallShot()
        {
            int userPoints = 15;
            System.Console.WriteLine("Master Yodas is testing you, would you like to attempt to dodge or deflect the shot?");
            System.Console.WriteLine("Press 1 to dodge or 2 to deflect");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                bool hit = DodgeChance();
                if(hit == true)
                {
                    System.Console.WriteLine("hit works.");
                }
                else
                {
                    System.Console.WriteLine("miss works.");
                }
            }
            else if(userInput == "2")
            {
                DeflectChance();
            }
            else
            {
                System.Console.WriteLine("Invalid choice");
            }
        }
        static bool DodgeChance()
        {
            // System.Console.WriteLine("Dodge chance");
            Random rnd = new Random();
            int result = rnd.Next(10);
            // System.Console.WriteLine(result);
            if(result >= 5)
            {
                System.Console.WriteLine("You dodged.");
                bool hit = false;
                return hit;
            }
            else
            {
                System.Console.WriteLine("You're hit.");
                bool hit = true;
                return hit;
            }
        }
        static void DeflectChance()
        {
            System.Console.WriteLine("Deflect chance");
        }
    }
}
