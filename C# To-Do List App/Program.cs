using System.ComponentModel;
using System.Threading.Tasks;
using C__To_Do_List_App;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    public static void Main()
    {
        TaskManager taskManager = new TaskManager();
        bool isRunning = true;

        while (isRunning)
        {
            try
            {
                DisplayMenu(taskManager, ref isRunning);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }



    }

    public static void DisplayMenu(TaskManager taskManager, ref bool isRunning)
    {
        Console.WriteLine("Hi! Welcome to the To-Do List App!\n");

        

        while (isRunning)
        {
            Console.WriteLine("Select one of the options by typing their number:\n" +
                "\n" +
                "1. Add a task.\n" +
                "2. Remove a task.\n" +
                "3. Mark a task as complete.\n" +
                "4. Edit the title of a task.\n" +
                "5. Display all tasks.\n" +
                "6. End the current program.\n" +
                "\n");

            string input = "";
            int selection;

            while (true) {
                input = Console.ReadLine();
                if(input != null)
                {
                    selection = int.Parse(input);
                    break;
                }
                else
                {
                    throw new FormatException("Must input a number! Try again.\n");
                }
            }

            int taskId;
            string taskTitle = string.Empty;

            switch (selection)
            {

                case 1:
                    Console.WriteLine("\nWhat is the title of the new task?\n");
                    while (true)
                    {
                        taskTitle = Console.ReadLine();
                        if (taskTitle != null)
                        {
                            Console.WriteLine("\n");
                            taskManager.AddTask(taskTitle);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Must give a valid string! Try again.");
                        }
                    }
                        
                    break;

                case 2:
                    Console.WriteLine("\nWhich task would you like to remove? Select a number.\n");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            Console.WriteLine("\n");
                            taskId = int.Parse(input);
                            taskManager.RemoveTask(taskId);
                            break;
                        }
                        else
                        {
                            throw new FormatException("Must input a number! Try again.\n");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("\nWhich task would you like to mark completed? Select a number.\n");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            Console.WriteLine("\n");
                            taskId = int.Parse(input);
                            taskManager.MarkComplete(taskId);
                            break;
                        }
                        else
                        {
                            throw new FormatException("Must input a number! Try again.\n");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("\nWhich task would you like to edit? Select a number.\n");
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            Console.WriteLine("\n");
                            taskId = int.Parse(input);
                            break;
                        }
                        else
                        {
                            throw new FormatException("Must input a valid number! Try again.\n");
                        }
                    }
                    Console.WriteLine("\nNow, what is the new title of your task?\n");
                    while (true)
                    {
                        taskTitle = Console.ReadLine();
                        if (taskTitle != null)
                        {
                            Console.WriteLine("\n");
                            taskManager.EditTask(taskId, taskTitle);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Must give a valid string! Try again.");
                        }
                    }
                    break;
                case 5:
                    taskManager.DisplayTasks();
                    break;
                case 6:
                    Console.WriteLine("Program complete.");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a value from 1-6!");
                    break;
            }

        }






        
    }
}