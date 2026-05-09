using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComparison.Entites
{
    class TaskItem
    {
        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public TaskItem(string title,bool isCompleted) { Title = title;IsCompleted = isCompleted; }

        public override string ToString() => $"Missão:{Title}, {IsCompleted}";
        
            
        
    }
}
