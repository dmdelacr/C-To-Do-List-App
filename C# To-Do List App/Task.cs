using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__To_Do_List_App
{
    internal class Task
    {
        public int Id;
        public string Title;
        public bool IsComplete;

        public Task(int id, string title) 
        {
            Id = id;
            Title = title;
            IsComplete = false;
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }

        public override string ToString()
        {
            string result = $"{Id}. {Title}";

            if (IsComplete)
            {
                result += " (Complete).";
            }
            else
            {
                result += " (Incomplete).";
            }

            return result;
        }


    }
}
