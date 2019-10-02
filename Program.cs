using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculator
            // double operand1, operand2;
            // char op;
            // Console.Write("Enter First Number to Calculate: ");
            // operand1 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter Second Number to Calculate: ");
            // operand2 = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Enter An Operator:");
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

            //quiz to test con
            // string name;
            String answer = "Watson";
            String response = "";
            Console.Write("Let's play a guessing game...");
            Console.WriteLine("You get three tries...");
            Console.WriteLine("What is the name of the computer on Jeopardy?");
            response = Console.ReadLine();
            if (response == answer)
            {
                Console.WriteLine("That is correct!");
            }
            else
            {
                Console.WriteLine("Sorry try again....");
                response = Console.ReadLine();
                if (response == answer)
                {
                    Console.WriteLine("You rule!!!");
                }
                else
                {
                    Console.WriteLine("Sorry try again dorkus....");
                    response = Console.ReadLine();
                    if (response == answer)
                    {
                        Console.WriteLine("you are the best go to DragonForce concert");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you cannot go back to being a winner.  You are forever a loser at the game of life....");
                    }

                }


            }

            // int x = 15;
            // // int y = 6;
            // // x %= y;

            // Console.WriteLine("Enter your name: ");

            // name = Console.ReadLine();
            // Console.WriteLine(name + x);

            // // Console.Write(y);

        }
    }
}
