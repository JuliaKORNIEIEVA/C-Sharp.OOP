using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Task3 : ITaskeable
    {
        private int[] array = new int[10 + 11];
        
        public void Inicelisation()
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
        }
        public int Min() 
        {
            return array.Min();
        }

        public int Max() 
        {
            return array.Max();
        }
       
        public void Output_array()
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
        }

        public void StartTask()
        {
            Console.WriteLine("Task 3 Inicelisation");

            Inicelisation();
            Output_array();
            Console.WriteLine();
            Console.WriteLine(" Your Min num is: " + Min());
            Console.WriteLine(" Your Max num is: " + Max());
        } 
       
    }
}

