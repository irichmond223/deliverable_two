using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deliverable_two
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            char playNow;
            int userInput, inputNum;


            while (playAgain == true)
            {
                Console.WriteLine("Hello user, what are you in the mood for? " + "Here are your options:");

                Console.WriteLine("1) Action");
                Console.WriteLine("2) Chill Times");
                Console.WriteLine("3) Danger");
                Console.WriteLine("4) Good Food");
                userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many people are you bringing with you?");

                //Convert from string to integer to use it to determine more or less.
                inputNum = Convert.ToInt32(Console.ReadLine());
           
                if (userInput == 1)
                {
                    Console.WriteLine("Okay if you're in the mood for action, then you should go see Stock Car Racing");

                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Okay if you're in the mood for chilling, then you should go Hiking"); 
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Okay if you're in the mood for danger, then you should go Skydiving");
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Okay if you're in the mood for good food, then you should go to Taco Bell");
                }
                else
                {
                    Console.WriteLine("I'm sorry but I do not understand your input.");
                }

                if (inputNum == 0)
                {
                    Console.WriteLine("and travel in sneakers!");

                }
                else if (inputNum >= 1 && inputNum <= 4)
                {
                    Console.WriteLine("and travel in a sedan!");

                }
                else if (inputNum <= 5 && inputNum >= 10)
                {
                    Console.WriteLine("and travel in a Volkswagen bus!");
                }

                else if (inputNum > 11)
                {
                    Console.WriteLine("and travel in an airplane!");
                }

                else
                {
                    Console.WriteLine("I'm sorry but I don't understand your input");
                }

               
                Console.WriteLine("Goodbye.");
                Console.ReadLine();

                
                Console.WriteLine("Would you like to run this program again? (Y or N)");


                playNow = Convert.ToChar(Console.ReadLine());


                if (playNow == 'y' || playNow == 'Y')
                {
                    playAgain = true;

                }

                else
                {
                    Console.WriteLine("Goodbye.");
                    playAgain = false;
                    Console.ReadLine();
                }
            }
        }
    }
}
