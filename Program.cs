using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDentonFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and assign the variable userQuit, which handles leaving the application early
            string userQuit = "o";

            // Creates a loop for the application to run each step so long as userQuit 
            //Doesn't equate to the string "quit"
            do
            {
                // First ask the user their first name
                Console.WriteLine("Welcome to the my tent, my child. Please, tell me your first name.");
                // Assign their name to a string
                string userFirstName = Console.ReadLine().ToLower();
                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop
                if (userFirstName == "quit")
                {
                    userQuit = userFirstName;
                    break;
                }

                // Ask the user what their last name is
                Console.WriteLine("What is your last name?");
                // Assign their last name to a string
                string userLastName = Console.ReadLine().ToLower();
                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop
                if (userLastName == "quit")
                {
                    {
                        userQuit = userLastName;
                        break;
                    }
                }

                // Ask the user how old they are 
                Console.WriteLine("And how old are you?");
                // Assigns their age to a string
                string userAge = Console.ReadLine();
                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop

                if (userAge == "quit")
                {
                    userQuit = userAge;
                    break;
                }

                // Parse their age into an integer 
                int userAgeInt = int.Parse(userAge);
                // Declare the integer retireTime
                int retireTime;
                
                // Checks if the age is even or odd based on whether the remainder
                // Of the age input is equal or 0 or not
                // If it is 0, the number is even
                if (userAgeInt % 2 == 0)
                {
                    retireTime = 20;
                }

                else
                {
                    retireTime = 4000;
                }


                // Ask the user for the number of their birth month
                Console.WriteLine("What is the two digit number of your birth month?");
                // Assign their birth month number to a string
                string userMonth = Console.ReadLine();
                
                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop
                if (userMonth == "quit")
                {
                    userQuit = userMonth;
                    break;
                }

                // Parse the userMonth string as an integer 
                int userMonthInt = int.Parse(userMonth);
                // Declare an array of doubles for each potential result
                double[] moneyAmountArray = { 100.00, 3000.00, 2.00, 0.00 };
                // Declare an empty double moneyAmount
                double moneyAmount;
                
                // Create a switch to detect if the integer stored in userMonthInt is 
                // equivocal to one of the cases below
                // If so, then assign a corresponding element in the moneyAmountArray 
                // To the moneyAmount double 
                // If userMonthInt fulfills no case, default to the last element in the array
                switch (userMonthInt)
                {
                    case 01:
                        moneyAmount = moneyAmountArray[0];
                        break;

                    case 02:
                        moneyAmount = moneyAmountArray[0];
                        break;

                    case 03:
                        moneyAmount = moneyAmountArray[0];
                        break;

                    case 04:
                        moneyAmount = moneyAmountArray[0];
                        break;

                    case 05:
                        moneyAmount = moneyAmountArray[1];
                        break;

                    case 06:
                        moneyAmount = moneyAmountArray[1];
                        break;

                    case 07:
                        moneyAmount = moneyAmountArray[1];
                        break;

                    case 08:
                        moneyAmount = moneyAmountArray[1];
                        break;

                    case 09:
                        moneyAmount = moneyAmountArray[2];
                        break;

                    case 10:
                        moneyAmount = moneyAmountArray[2];
                        break;

                    case 11:
                        moneyAmount = moneyAmountArray[2];
                        break;

                    case 12:
                        moneyAmount = moneyAmountArray[2];
                        break;

                    default:
                        moneyAmount = moneyAmountArray[3];
                        break;
                }



                // Asks the user what their favorite color is 
                Console.WriteLine("What is your favorite ROYGBIV color? If you are unaware of ROYGBIV, feel free to ask for HELP");
                // Assign their color to a string
                string userFavColor = Console.ReadLine().ToLower();

                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop
                if (userFavColor == "quit")
                {
                    userQuit = userFavColor;
                    break;
                }

                // If they responded with help, while help is still stored in userFavColor
                // Let the user know what ROYGBIV means, allow them to respond again 
                // And loop back up to check if it is still help
                while (userFavColor == "help")
                {
                    Console.WriteLine(" ROYGBIV are the colors Red, Orange, Green, Blue, Indigo, and Violet");
                    Console.WriteLine("Now, what is your favorite color?");

                    userFavColor = Console.ReadLine().ToLower();
                }

               // Declare and intialize an array with each transportation element 
                string[] transportationArray = { " riding Nimbus", " the Merry Go", " an Apache Helicopter", " a Hover Board", " an Air Gear", " a psychic tandem war elephant" };
                // Declare the string transport and assign it a to fill the space
                string transport = "a";

                // Checks if the string stored in userFavColor matches one of the cases below
                // If it does, then assign transport to a corresponding array element
                // If not, default to the last array element
                switch (userFavColor)
                {
                    case "red":
                        transport = transportationArray[0];
                        break;

                    case "orange":
                        transport = transportationArray[1];
                        break;

                    case "yellow":
                        transport = transportationArray[2];
                        break;

                    case "green":
                        transport = transportationArray[3];
                        break;

                    case "blue":
                        transport = transportationArray[4];
                        break;

                    case "indigo":
                        transport = transportationArray[5];
                        break;

                    case "violet":
                        transport = transportationArray[6];
                        break;

                    default:
                        transport = " your bare hands and knees YOU PLEBIAN FILTH.";
                        break;
                }

                // Asks the user how many siblings they have
                Console.WriteLine("Lastly, how many siblings do you have?");
                // Assigns their response to a string
                string userSiblings = Console.ReadLine();

                // Check if that string is the "quit" string. If so, assign it to the userQuit 
                // Variable and break the loop
                if (userSiblings == "quit")
                {
                    userQuit = userSiblings;
                    break;
                }

                // Parse the string into an integer 
                int userSiblingsInt = int.Parse(userSiblings);
                // Declare and intiialze an array for each vacation home element
                string[] vacationHomeArray = { "London", "Dubai", "Melemele", "Emain Macha", "Mordor" };
                // Declare the string vacationHome and assign it a filler string
                string vacationHome = "a";
                
                // Checks if the userSiblingsInt integer equates to 0, 1, 2, or 3 or more
                // If it does then vacationHome is assigned a corresponding vacationHomeArray element
                // However, if the response is less than 0, then assign the last array element
                if (userSiblingsInt == 0)
                {
                    vacationHome = vacationHomeArray[0];
                }

                else if (userSiblingsInt == 1)
                {
                    vacationHome = vacationHomeArray[1];
                }

                else if (userSiblingsInt == 2)
                {
                    vacationHome = vacationHomeArray[2];
                }

                else if (userSiblingsInt >= 3)
                {
                    vacationHome = vacationHomeArray[3];
                }

                else if (userSiblingsInt < 0)
                {
                    vacationHome = vacationHomeArray[4];
                }

                // Print to the console the final response for the user using all of the information
                // They submitted, which was stored in each variable
                Console.WriteLine(userFirstName + " " + userLastName + " will retire in " + retireTime + " years with " + moneyAmount + " in the bank, a vacation home in " + vacationHome + " and" + transport);
                break;

            } while (userQuit != "quit");

            // If userQuit's string equates to the string "quit" then print the first line to the screen
            // If not, then print the second line to the screen 
            if (userQuit == "quit")
            {
                Console.WriteLine("No one likes a quitter...");
            }

            else
            {
                Console.WriteLine("Thank you for your time. Comea again with friends. And coin...");
            }
             

           

          



            
        }
    }
}
