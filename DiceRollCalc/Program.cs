using System;
using System.Text.RegularExpressions;

namespace DiceRollCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.NewLine = "\r\n\r\n";
            Console.WriteLine("Hi, Everyone");
            Console.WriteLine();
            Console.WriteLine("Let's roll the dice and calculate sum of the points that appear.");


            DiceandRoll diceand = new DiceandRoll();
            diceand.Calcdicerolls();


            Console.ReadLine();
        }

        
    }

    public class DiceandRoll
    {
        public static int output = 0;
        public void Calcdicerolls()
        {
            Getinput();

            Console.WriteLine("Let's begin....");
            double x, sum = 0, x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0; //xn=0 initializes the number of occurrences of each point to 0
            Random ran = new Random();//Set up random number variables.

            for (int i = 0; i < output; i++)
            {
                x = ran.Next(1, 7);//Create a random number range 1-6 1<=x<7
                if (x == 1)
                {
                    x1++;
                }
                else if (x == 2)
                {
                    x2++;
                }
                else if (x == 3)
                {
                    x3++;
                }
                else if (x == 4)
                {
                    x4++;
                }
                else if (x == 5)
                {
                    x5++;
                }
                else if (x == 6)
                {
                    x6++;
                }
                sum += x;
            }

            Console.WriteLine("The sum of the points appearing on dice roll is:" + sum);
            Console.WriteLine("The number of times each number appears:");

            Console.WriteLine("The number of occurrences of point 1 is: {0} times. The probability is: {1}", x1, (x1 / output));
            Console.WriteLine("The number of occurrences of point 2 is: {0} times. The probability is: {1}", x2, (x2 / output));
            Console.WriteLine("The number of occurrences of point 3 is: {0} times. The probability is: {1}", x3, (x3 / output));
            Console.WriteLine("The number of occurrences of point 4 is: {0} times. The probability is: {1}", x4, (x4 / output));
            Console.WriteLine("The number of occurrences of point 5 is: {0} times. The probability is: {1}", x5, (x5 / output));
            Console.WriteLine("The number of occurrences of point 6 is: {0} times. The probability is: {1}", x6, (x6 / output));

            Console.WriteLine("To continue again press 'y' else press 'n' to close");

            ConsoleKeyInfo cki = Console.ReadKey();

            if (cki.Key.ToString() == "y")
            {
                DiceandRoll roll = new DiceandRoll();
                roll.Calcdicerolls();
                
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void Getinput()
        {
            
            Console.WriteLine("Enter number of dice:");
            string UserInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(UserInput))
            {
                if (Regex.IsMatch(UserInput, @"^\d+$"))
                {
                    output = Convert.ToInt32(UserInput);
                }
                else
                {
                    Console.WriteLine("Please enter a number, Given input is non-numeric!");
                    Getinput();
                }
            }
            else
            {
                Getinput();
            }
            
        }
    }
}
