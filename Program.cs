using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello there, welcome to Fortune Teller!");
            //start asking user for input

            Console.WriteLine("To move forward with your fortune, enter your first name.");
            string firstName = Console.ReadLine();       

            Console.WriteLine("Thank you " + firstName + ". Next enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine(firstName +" " + lastName + ", please enter your age.");
            int age = int.Parse(Console.ReadLine());
            string oddOReven = "";

            if (age % 2 == 0)
            {
                oddOReven = ("You will retire in 22 years");
            }
            else
            {
                oddOReven = ("You will retire in 35 years");
            }

            Console.WriteLine("Now that I know your age, please enter your birth month (digits only).");
            int birthMonth = int.Parse(Console.ReadLine());
            float money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 3.45f;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 4.6f;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 500.56f;
            }
            else
            {
                money = 0.0f;
            }

            Console.WriteLine("To contiue with your fortune reader, what is your favorite ROYGBIV color?" + "\n" + "Please enter \"help\" for description of ROYGBIV.");
            string response = Console.ReadLine();
            string responseCaps = response.ToUpper();

            string userTransport = "";

            if (responseCaps == "HELP")
            {
                Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color: ");
                response = Console.ReadLine();
            }

            switch (responseCaps)
            {
                case "RED":
                    userTransport = ("you will own a boat");
                    break;
                case "ORANGE":
                    userTransport = ("you will own a Ford SUV");
                    break;
                case "YELLOW":
                   userTransport = ("you will own a motorcycle");
                    break;
                case "GREEN":
                    userTransport = ("you will own a Rolls Royce");
                    break;
                case "BLUE":
                    userTransport = ("you will own a bike");
                    break;
                case "INDIGO":
                    userTransport = ("you will own a yacht");
                    break;
                case "VIOLET":
                    userTransport = ("you will own an airplane");
                    break;
            }


            Console.WriteLine("Enter the number of sibilings that you have.");
                int siblings = int.Parse(Console.ReadLine());
            string userVaca = "";

            if (siblings == 0)
            {
                userVaca =("You will have a beach house in Cancun");
            }

            else if (siblings == 1)
            {
                userVaca = ("You will have a vacation home in Colorado");
            }
            else if (siblings == 2)
            {
                userVaca = ("You will have a vacation home in Spain");
            }
            else if (siblings == 3)
            {
                userVaca= ("You will have a beach house in Croatia");
            }
            else if (siblings > 3)
            {
                userVaca = ("You will have a beach house in Australia");
            }
            else
            {
                userVaca = ("You will be stuck in Crappy Ohio");
            }

            // Writing out the fortune 
            Console.WriteLine(firstName +" " + lastName + " your fortune is... " + oddOReven + " with $" + money + " million in the bank. " + (userVaca) + " and " + userTransport + ".");
            Console.WriteLine("Pretty awesome life ahead of you! Thanks for playing :)");
            Console.ReadKey();
        }
    }
}
