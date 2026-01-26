using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAG_ASO_Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MAG-ASO, REXDEL C. | IT401A | DASTRU | ACTIVITY 6: Inserting Nodes to the Linked List
            LinkedList<string> Classmates = new
                LinkedList<string> ();

        InputValue:
            Console.Clear();
            // enter number of class
            Console.Write("Give me your Favorite Classmates (5-10): ");
            int numberOfClassmates = int.Parse(Console.ReadLine());

            //limiting the number of classmates to 10
            if (numberOfClassmates == 10)
            {
                Console.WriteLine("Please enter a number between 5 and 10");
                goto InputValue;
            }

            //Input Classmates names using loop
            Console.WriteLine("Enter the names of your Classmates:\n");
            for (int i = 0; i < numberOfClassmates; i++)
            {
                Console.Write("Classmates #{0}: ", i + 1);
                string ClassmatesName = Console.ReadLine();
                Classmates.AddLast(ClassmatesName);
            }

            var sortedClassmates = Classmates.OrderBy (name => name);

            Console.Clear();
            Console.WriteLine("\nYour Classmate is:");
            foreach (string classmates in Classmates)
            {
                Console.Write(classmates + " -> ");
            }
            Console.WriteLine("null");

            Console.ReadKey();
            //Environmental Exit(0);
        }
    }
}
