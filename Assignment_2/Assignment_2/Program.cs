using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] git_1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt");
            string[] git_1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt");
            string[] git_2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt");
            string[] git_2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt");
            string[] git_3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt");
            string[] git_3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt");

            Console.WriteLine("Which set of files would you like to compare? 1,2 or 3 ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (git_1a == git_1b)
                {
                    Console.WriteLine("They are the same");
                }
                else
                {
                    Console.WriteLine("They are not the same");
                }
            }

            if (choice == "2")
            {
                if (git_2a == git_2b)
                {
                    Console.WriteLine("They are the same");
                }
                else
                {
                    Console.WriteLine("They are not the same");
                }
            }

            if (choice == "3")
            {
                if (git_3a == git_3b)
                {
                    Console.WriteLine("They are the same");
                }
                else
                {
                    Console.WriteLine("They are not the same");
                }
            }
        }
    }
}
