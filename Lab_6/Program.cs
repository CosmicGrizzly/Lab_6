using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Promting the User.
            Console.Write("Welcome to the Grand Circus Casino! \nWhat's your name gambler? ");
            string name = (Console.ReadLine());
            string response = "y";
            while (response == "y")
            {


                Console.WriteLine($" {name} How Many Dice would you like to roll? ");
                int total = int.Parse(Console.ReadLine());
                Console.WriteLine($" {name} How many sides will the dice have? ");
                int sides = int.Parse(Console.ReadLine());
                int counter = 0;
                Random r = new Random();
                while (counter < total)
                {
                    int result = GetRoll(r, sides);
                    Console.Write($" Roll {counter + 1}:  ");
                    Console.WriteLine(result);
                    counter = counter + 1;

                }
                Console.WriteLine($" {name} Would you like to test your luck again? y/n ");
                response = (Console.ReadLine());
            }
        }
        public static int GetRoll(Random r, int max)
        {
            return r.Next(1, max + 1);
        }
    }
}
