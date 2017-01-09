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

            Console.WriteLine("To move forward with your fortune, enter your first name.");
            string firstName = Console.ReadLine();
            string firstNameL = firstName.ToLower();

            Console.WriteLine("Thank you " + firstName + ". Next enter your last name.");
            string lastName = Console.ReadLine();
            string lastNameL = lastName.ToLower();

            Console.WriteLine(firstName +" " + lastName + ", please enter your age.");
            int age = int.Parse(Console.ReadLine());

            //if (age % 2 == 0)
            //{
            //   Console.WriteLine("You will retire in 22 years.");
            //}
            //else
            //{
            //    Console.WriteLine("You will retire in 35 years.");
            //}



            Console.WriteLine("Now that I know your age, please enter your birth month (digits only).");
            int birthMonth = int.Parse(Console.ReadLine());
            float money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = 300f;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = 4.0f;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = 500f;
            }
            else
            {
                money = 0.0f;
            }

            Console.WriteLine("To contiue with your fortune reader, what is your favorite ROYGBIV color?" + "\n" + "Please enter \"help\" for description of ROYGBIV.");
            string response = Console.ReadLine();
            

            if (response == "help")
            {
                Console.WriteLine("ROYGBIV COLORS: \nR is for Red. \nO is for Orange. \nY is for Yellow. \nG is for Green. \nB is for Blue. \nI is for Indigo. \nV is for Violet. \nEnter a ROYGBIV color: ");
                response = Console.ReadLine();
            }

            //switch (response)
            //{
            //    case "red":
            //        Console.WriteLine("You will retire with a boat");
            //        break;
            //    case "orange":
            //        Console.WriteLine("You will retire with a Ford SUV");
            //        break;
            //    case "yellow":
            //        Console.WriteLine("You will retire with a motorcycle");
            //        break;
            //    case "green":
            //        Console.WriteLine("You will retire with a Rolls Royce");
            //        break;
            //    case "blue":
            //        Console.WriteLine("You will retire with a bike");
            //        break;
            //    case "indigo":
            //        Console.WriteLine("You will retire with a yacht");
            //        break;
            //    case "violet":
            //        Console.WriteLine("You will retire with an airplane");
            //        break;
            //}
         

            Console.WriteLine("Enter the number of sibilings that you have.");
                int siblings = int.Parse(Console.ReadLine());


            //if (siblings == 0)
            //{
            //   Console.WriteLine("You will have a beach house in Cancun");
            //}
            
            //else if (siblings == 1)
            //{
            //    Console.WriteLine("You will have a vacation home in Colorado");
            //}
            //else if (siblings == 2)
            //{
            //    Console.WriteLine("You will have a vacation home in Spain");
            //}
            //else if (siblings == 3)
            //{
            //   Console.WriteLine("You will have a beach house in Croatia");
            //}
            //else if (siblings > 3)
            //{
            //    Console.WriteLine("You will have a beach house in Australia");
            //}
            //else
            //{
            //    Console.WriteLine("You will be stuck in Crappy Ohio");
            //}
            
        }
    }
}
