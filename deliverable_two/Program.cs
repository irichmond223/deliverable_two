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

                Console.WriteLine("0");
                Console.WriteLine("1-4");
                Console.WriteLine("5-10");
                Console.WriteLine("11+");

                //Convert from string to integer to use it to determine more or less.
                inputNum = Convert.ToInt32(Console.ReadLine());


                if (userInput == 1 && inputNum >= 11)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing and travel in an airplane! ");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }


                else if (userInput == 1 && inputNum >= 5 && inputNum <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing and tavel in a Volkswagen bus!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }


                else if (userInput == 1 && inputNum >= 1 && inputNum <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing and travel in a sedan!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 1 && inputNum == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for action, then you should go to Stock Car Racing and travel in sneakers!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 2 && inputNum == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for chill times, then you should go hiking and travel in sneakers!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 2 && inputNum >= 1 && inputNum <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for chill times, then you should go hiking and travel in a sedan!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 2 && inputNum >= 5 && inputNum <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for chill times, then you should go hiking and travel in a Volkswagen bus!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 2 && inputNum >= 11)
                {
                    Console.WriteLine("Okay if you’re in the mood for chill times, then you should go hiking and travel in an airplane!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 3 && inputNum == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in sneakers!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 3 && inputNum >= 1 && inputNum <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a sedan!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 3 && inputNum >= 5 && inputNum <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a Volkswagen bus!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 3 && inputNum >= 11)
                {
                    Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in an airplane!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 4 && inputNum == 0)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in sneakers!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 4 && inputNum >= 1 && inputNum <= 4)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a sedan!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else if (userInput == 4 && inputNum >= 5 && inputNum <= 10)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a Volkswagen bus!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }


                else if (userInput == 4 && inputNum >= 11)
                {
                    Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in an airplane!");
                    Console.WriteLine("Goodbye. ");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("The input was not understood.");
                    Console.ReadLine();
                }

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
