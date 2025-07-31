using System;
using System.Collections.Generic;
using System.Reflection;

class TODOLIST1
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Add Task");
            Console.WriteLine("2 - Show Tasks");
            Console.WriteLine("3 - Delete Tasks");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Addlist();
                    break;
                case "2":
                    ShowList();
                    break;
                case "3":
                    DeleteList();
                    break;
                default:
                    Console.WriteLine("Error: Invalid option.");
                    break;
            }
        }
    }

    static void Addlist()
    {
        Console.WriteLine("Write new task:");
        string input1 = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input1))
        {
            tasks.Add(input1);
            Console.WriteLine("Task added successfully.");
            ShowList();
        }
        else
        {
            Console.WriteLine("Failed to add task. Input was empty.");
        }
    }

    static void ShowList()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            Console.WriteLine("Your tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void DeleteList()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("List is already empty.");
            return;
        }

        ShowList();
        Console.WriteLine("Enter the number of the task to delete:");

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            if (index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
