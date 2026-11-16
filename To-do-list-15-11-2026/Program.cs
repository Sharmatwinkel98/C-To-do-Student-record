
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> task_list = new List<string>();
        bool condition = true;
        while (condition)
        {
            Console.WriteLine("\n------------To-Do List Manager-----------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n1. Add a task");
            Console.WriteLine("2. Remove the task");
            Console.WriteLine("3. List all tasks");
            Console.WriteLine("4. Quit");
            Console.WriteLine("\nEnter your choice: ");
            string choice=Console.ReadLine();

            switch (choice) 
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    condition=false;
                    Console.WriteLine("Thank you! See you soon.........!!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Kindly select the valid option.");
                    Console.WriteLine("Thank you.....");
                    break;
            }
        }
    }
}