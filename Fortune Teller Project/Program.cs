using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string favColor;
            string result = ""; ;
            string vacayHome = ""; ;
            int age;
            int birthMonth;
            int siblings;
            int yearsRetire;
            double moneySaved;

            Console.WriteLine("What's your first name?");
            firstName = Console.ReadLine().ToLower();
            Console.WriteLine("What's your last name?");
            lastName = Console.ReadLine().ToLower();
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born?");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());
            Console.WriteLine("What's your favorite ROYGBIV color?");
            favColor = Console.ReadLine().ToLower();



            switch (favColor)
            {
                case "red":
                    result = "jet plane";
                    break;
                case "orange":
                    result = "yacht";
                    break;
                case "yellow":
                    result = "land rover";
                    break;
                case "green":
                    result = "pod car";
                    break;
                case "blue":
                    result = "train";
                    break;
                case "indigo":
                    result = "helicopter";
                    break;
                case "violet":
                    result = "cable car";
                    break;
                case "help":
                    Console.WriteLine("ROYGBIV stands for red, orange, yellow, green, blue, indigo, and violet. Please choose your favorite color from one of these seven colors.");
                    favColor = Console.ReadLine();
                    switch (favColor)
                    {
                        case "red":
                            result = "jet plane";
                            break;
                        case "orange":
                            result = "yacht";
                            break;
                        case "yellow":
                            result = "land rover";
                            break;
                        case "green":
                            result = "pod car";
                            break;
                        case "blue":
                            result = "train";
                            break;
                        case "indigo":
                            result = "helicopter";
                            break;
                        case "violet":
                            result = "cable car";
                            break;
                    }
                    break;
                default:
                    break;
            }





            if ((birthMonth == 1) || (birthMonth == 2) || (birthMonth == 3) || (birthMonth == 4) || (birthMonth == 5))
            {
                moneySaved = 2;
            }

            else if ((birthMonth == 5) || (birthMonth == 6) || (birthMonth == 7) || (birthMonth == 8))
            {
                moneySaved = 1.9;
            }

            else if ((birthMonth == 9) || (birthMonth == 10) || (birthMonth == 11) || (birthMonth == 12))
            {
                moneySaved = 1.5;

            }

            else
            {
                moneySaved = 0.00;

            }


            if ((age % 2 == 0))
            {
                yearsRetire = 10;
            }

            else
            {
                yearsRetire = 15;
            }


            if ((siblings == 0))
            {
                vacayHome = "Bali";
            }

            else if ((siblings == 1))
            {
                vacayHome = "St. Tropez";
            }

            else if ((siblings == 2))
            {
                vacayHome = "Ibiza";
            }

            else if ((siblings == 3))
            {
                vacayHome = "Martha's Vineyard";
            }

            else if ((siblings > 3))
            {
                vacayHome = "Manhattan";
            }

            else 
            {
                
                vacayHome = "a one bedroom apartment in a high-rise";
            }


            Console.WriteLine("{0} {1} will retire in {2} years with {3} million dollars in the bank, a vacation home in {4}, and a {5}. ", firstName, lastName, yearsRetire, moneySaved, vacayHome, result);



        }
    }
}




   


    











 




    
 

