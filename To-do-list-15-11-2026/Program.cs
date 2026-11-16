
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
                case "1":                                                   //adding the task to the list
                    Console.WriteLine("\nEnter the task name:");
                    string task=Console.ReadLine();
                    task_list.Add(task);
                    Console.WriteLine("Task added successfully.");
                    break;
                case "2":                                                   //remove the task fron the list
                    if (task_list.Count == 0)
                    {
                        Console.WriteLine("List is empty.No tasks are available to delete.");
                    }
                    else
                    {
                        Console.WriteLine("Enter the task number to remove:");
                        for (int i = 0; i < task_list.Count; i++)
                        {
                            Console.WriteLine((i+1) + ". "+ task_list[i]);
                        }
                        Console.WriteLine("Enter number:");
                        int number =Convert.ToInt32(Console.ReadLine());
                        if(number >=1 && number <=task_list.Count)
                        {
                            task_list.RemoveAt(number - 1);
                            Console.WriteLine("Task removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid task number.");
                        }
                    }
                    break;
                case "3":                                                   //Display the task list4
                    if (task_list.Count == 0)
                    {
                        Console.WriteLine("List is empty.Nothing to show.....!!");
                    }
                    else
                    {
                        Console.WriteLine("\nYour tasks are:");
                        int count = 1;
                        foreach( string item in task_list)
                        {
                            Console.WriteLine($"*.{item}");
                            count++;
                        }
                    }
                    break;
                case "4":
                    condition=false;
                    Console.WriteLine("Thank you! See you soon.........!!");
                    break;
                default:// check that user should only select the availble options.
                    Console.WriteLine("Invalid choice! Kindly select the valid option.");
                    Console.WriteLine("Thank you.....");
                    break;
            }
        }
    }
}