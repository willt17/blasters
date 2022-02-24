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
            int userPoints = 15;
            while(userPoints > 0)
            {
                string tempPoints = CallShot();
                if(tempPoints == "1")
                {
                    userPoints += 5;
                    System.Console.WriteLine("You now have " + userPoints + " points.");
                }
                else if(tempPoints == "2")
                {
                    userPoints -= 5;
                    System.Console.WriteLine("You now have " + userPoints + " points.");
                }
                else if(tempPoints == "3")
                {
                    userPoints += 10;
                    System.Console.WriteLine("You now have " + userPoints + " points.");
                }
                else
                {
                    System.Console.WriteLine("");
                }
            }
        }
        static string CallShot()
        {
            System.Console.WriteLine("Master Yoda is testing you, would you like to attempt to dodge or deflect the shot?");
            System.Console.WriteLine("Press 1 to dodge or 2 to deflect");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                bool hit = DodgeChance();
                if(hit == true)
                {
                    // System.Console.WriteLine("hit works.");
                    string hitTrue = "2";
                    return hitTrue;
                }
                else
                {
                    // System.Console.WriteLine("miss works.");
                    string hitFalse = "1";
                    return hitFalse;
                }
            }
            else if(userInput == "2")
            {
                bool deflectHit = DeflectChance();
                if(deflectHit == true)
                {
                    string deflectTrue = "3";
                    return deflectTrue;
                }
                else if(deflectHit == false)
                {
                    string deflectFalse = "2";
                    return deflectFalse;
                }
                else
                {
                    string SecondInvalidHit = "4";
                    return SecondInvalidHit;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid choice");
                string invalidHit = "4";
                return invalidHit;
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
        static bool DeflectChance()
        {
            // System.Console.WriteLine("Deflect chance");
            // System.Console.WriteLine("Dodge chance");
            Random rnd = new Random();
            int result = rnd.Next(10);
            // System.Console.WriteLine(result);
            if(result >= 7)
            {
                System.Console.WriteLine("You deflected.");
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
    }
}
