using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDataBase
{
    class Program
    {  
        static void Main(string[] args)
        {
            string[] studentNames = { "Johnny", "Miguel", "Danny", "Tory", "Sam" };

            string[] homeTowns = { "Detroit", "Los Angeles", "Boston", "Miami", "Dallas" };

            string[] favoriteFoods = { "steak", "hamburgers", "fish", "spaghetti", "tacos" };

            

            bool goAgain = true;

            while (goAgain == true)
            {
                int userInput = int.Parse(GetUserInput("Which of the five students would you like to learn about? Please enter 1-5:"));


                if (userInput <= 0 || userInput > studentNames.Length)
                {
                    Console.WriteLine("I'm sorry that is not a number corresponding to a student.");
                    Console.WriteLine("Please try a number between 1 and 5");                  
                                        
                }
                else
                {

                
                string name = studentNames[userInput - 1];
                string hometown = homeTowns[userInput - 1];
                string favfood = favoriteFoods[userInput - 1];
                

                Console.WriteLine($"What would you like to learn about {name}? Their hometown or their favorite food?");
                string userChoice = Console.ReadLine().ToLower();
                    if ("hometown" == userChoice)
                    {
                        Console.WriteLine($"{ name}'s hometown is {hometown}.");
                    }
                    else if (userChoice == "favorite food" || userChoice == "food")
                    {

                        Console.WriteLine($"{ name}'s favorite food is {favfood}");
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry we only have information on a student's hometown or favorite foods.");
                    }   
                }
                goAgain = RunAgain();
            }

         static string GetUserInput(string prompt)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                return input;
            }

         static bool RunAgain()
            {
                string answer = GetUserInput("Would you like to learn about any of the other students? Please enter y or n").ToLower();

                if (answer == "y"||answer == "yes")
                    return true;
                else if(answer =="n"||answer == "no")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that response. Please enter y or n");
                    return RunAgain();
                }

             }









        }
    }
}
