using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // double operand1, operand2;
            // char op;
            // Console.Write("Enter First Number to Calculate: ");
            // operand1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter Second Number to Calculate: ");
            // operand2 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter An Operator");
            // op = Convert.ToChar(Console.ReadLine());
            // if (op == '+')
            //     Console.WriteLine(operand1 + operand2);
            // else if (op == '-')
            //     Console.WriteLine(operand1 - operand2);
            // else if (op == '*')
            //     Console.WriteLine(operand1 * operand2);
            // else if (op == '/')
            //     Console.WriteLine(operand1 / operand2);
            // else
            //     Console.WriteLine("Try again foolio");
            // Console.ReadKey();

            // // string name;
            // String answer = "Watson";
            // String response = "";
            // Console.Write("Let's play a guessing game...");
            // Console.WriteLine("You get three tries...");
            // Console.WriteLine("What is the name of the computer on Jeopardy?");
            // response = Console.ReadLine();
            // if (response == answer)
            // {
            //     Console.WriteLine("That is correct!");
            // }
            // else
            // {
            //     Console.WriteLine("Sorry try again....");
            //     response = Console.ReadLine();
            //     if (response == answer)
            //     {
            //         Console.WriteLine("You rule!!!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Sorry try again dorkus....");
            //         response = Console.ReadLine();
            //         if (response == answer)
            //         {
            //             Console.WriteLine("you are the best go to DragonForce concert");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Sorry you cannot go back to being a winner.  You are forever a loser at the game of life....");
            //         }

            //     }


            // }

            // while loop Q and A
            //     String answer = "Watson";
            //     String response = "";
            //     Console.WriteLine("Let's play a guessing game...");
            //     Console.WriteLine("You get three tries...");
            //     int tries = 1;
            //     while (tries <= 3)
            //     {
            //         Console.WriteLine("What is the name of the computer on Jeopardy?");
            //         response = Console.ReadLine();
            //         if (response == answer)
            //         {
            //             Console.WriteLine("That is correct!");
            //             break;
            //         }
            //         else if (tries < 3)
            //             Console.WriteLine("Sorry try again....");
            //         ++tries;
            //     }
            //     if (response != answer)
            //     {
            //         Console.WriteLine("Sorry you cannot go back to being a winner.  You are forever a loser at the game of life....and the answer is Watson");
            //         Console.ReadKey();
            //     }


            // }
            // for loop Q and A
            String answer = "Watson";
            String response = "";
            Console.WriteLine("Let's play a guessing game...");
            Console.WriteLine("You get three tries...");
            for (int tries = 1; tries < 4; ++tries)
            {
                Console.WriteLine("What is the name of the computer on Jeopardy?");
                response = Console.ReadLine();
                if (response == answer)
                {
                    Console.WriteLine("That is correct!");
                    break;
                }
                else if (tries < 3)
                    Console.WriteLine("Sorry try again....");
            }
            if (response != answer)
            {
                Console.WriteLine("Sorry you cannot go back to being a winner.  You are forever a loser at the game of life....and the answer is Watson");
                Console.ReadKey();
            }


        }

    }
}
