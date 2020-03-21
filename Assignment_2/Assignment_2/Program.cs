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
            string[] git_1a = System.IO.File.ReadAllLines(@"GitRepositories_1a.txt"); //Importing the text files and putting them into a string array
            string[] git_1b = System.IO.File.ReadAllLines(@"GitRepositories_1b.txt"); //Importing the text files and putting them into a string array
            string[] git_2a = System.IO.File.ReadAllLines(@"GitRepositories_2a.txt"); //Importing the text files and putting them into a string array
            string[] git_2b = System.IO.File.ReadAllLines(@"GitRepositories_2b.txt"); //Importing the text files and putting them into a string array
            string[] git_3a = System.IO.File.ReadAllLines(@"GitRepositories_3a.txt"); //Importing the text files and putting them into a string array
            string[] git_3b = System.IO.File.ReadAllLines(@"GitRepositories_3b.txt"); //Importing the text files and putting them into a string array

            Console.WriteLine("Which set of files would you like to compare? 1,2 or 3 "); //Asking the user which set of files they would like to compare
            string choice = Console.ReadLine(); //The user's choice saved as a varible

            if (choice == "1") 
            {
                if (git_1a == git_1b) //Comparison between the two chosen files
                {
                    Console.WriteLine("They are the same"); //One of the results of the comparison
                }
                else
                {
                    Console.WriteLine("They are not the same"); //One of the results of the comparison
                }
            }

            if (choice == "2") 
            {
                if (git_2a == git_2b) //Comparison between the two chosen files
                {
                    Console.WriteLine("They are the same"); //One of the results of the comparison
                }
                else
                {
                    Console.WriteLine("They are not the same"); //One of the results of the comparison
                }
            }

            if (choice == "3") 
            {
                if (git_3a == git_3b) //Comparison between the two chosen files
                {
                    Console.WriteLine("They are the same"); //One of the results of the comparison
                }
                else
                {
                    Console.WriteLine("They are not the same"); //One of the results of the comparison
                }
            }
        }
    }
}
