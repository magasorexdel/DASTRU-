using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_MAG_ASO
{
    internal class Program
    {
        /*
         * Complete Name: YOUR COMPLETE NAME HERE
         * Problem: Store superhero names in an array and
         *          display them in ascending or descending order.
         */

        static void Main(string[] args)
        {
            // ===== VARIABLE DECLARATION =====
            int size;
            int i;
            int choice;
            int center;

            Console.WriteLine("SUPERHERO ARRAY PROGRAM");
            Console.WriteLine("=======================\n");

            // ===== INPUT ARRAY SIZE =====
            Console.Write("Enter number of superheroes (5 to 10): ");
            size = Convert.ToInt32(Console.ReadLine());

            while (size < 5 || size > 10)
            {
                Console.Write("Invalid input. Enter 5 to 10 only: ");
                size = Convert.ToInt32(Console.ReadLine());
            }

            // ===== ARRAY DECLARATION =====
            string[] heroes = new string[size];

            // ===== INPUT SUPERHERO NAMES =====
            for (i = 0; i < size; i++)
            {
                Console.Write("Enter superhero " + (i + 1) + ": ");
                heroes[i] = Console.ReadLine();

                while (heroes[i] == "")
                {
                    Console.Write("Input cannot be empty. Enter again: ");
                    heroes[i] = Console.ReadLine();
                }
            }

            // ===== MENU =====
            Console.WriteLine("\nChoose Order:");
            Console.WriteLine("1 - Ascending Order");
            Console.WriteLine("2 - Descending Order");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 1 && choice != 2)
            {
                Console.Write("Invalid choice. Enter 1 or 2: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            // ===== SORTING (BASIC, NO TEMP VARIABLE) =====
            for (i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (choice == 1) // Ascending
                    {
                        if (string.Compare(heroes[i], heroes[j]) > 0)
                        {
                            (heroes[i], heroes[j]) = (heroes[j], heroes[i]);
                        }
                    }
                    else // Descending
                    {
                        if (string.Compare(heroes[i], heroes[j]) < 0)
                        {
                            (heroes[i], heroes[j]) = (heroes[j], heroes[i]);
                        }
                    }
                }
            }

            // ===== CLEAR SCREEN =====
            Console.Clear();

            // ===== CENTER COMPUTATION =====
            center = Console.WindowWidth / 2;

            // ===== CENTERED OUTPUT =====
            Console.WriteLine(new string(' ', center - 12) + "SORTED SUPERHEROES");
            Console.WriteLine(new string(' ', center - 12) + "==================");

            for (i = 0; i < size; i++)
            {
                Console.WriteLine(new string(' ', center - heroes[i].Length / 2) + heroes[i]);
            }

            Console.ReadKey();
        }
    }
}