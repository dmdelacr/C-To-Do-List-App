using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__To_Do_List_App
{
    internal class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public TaskManager()
        {
        }

        public void AddTask(string title)
        {
            if (IsDuplicate(title) || string.IsNullOrEmpty(title)) 
            {
                Console.WriteLine("Please try something else.\n");
            }
            else
            {
                tasks.Add(new Task(tasks.Count + 1, title));
            }
        }
        public bool IsDuplicate(string title)
        {
            foreach (var task in tasks)
            {
                if (task.Title == title)
                {
                    Console.WriteLine("You already have this as a task!\n");
                    return true;
                }
            }

            return false;
        }

        public void RemoveTask(int id)
        {
             tasks.RemoveAt(id - 1);
             for (int i = id - 1; i < tasks.Count; i++)   
             {
                tasks[i].Id = i + 1;    
             }      
        }

        public void MarkComplete(int id)
        {
            tasks[id - 1].MarkComplete();
        }
        public void EditTask(int id, string title)
        {
            tasks[id - 1] = new Task(id, title);
        }

        public void DisplayTasks()
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine("\nYour Tasks:");
                foreach (var task in tasks)
                {
                    Console.WriteLine(task.ToString().Trim());
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("No tasks available.\n");
            }
        }
    }
}
