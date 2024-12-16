using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Task1 : ITaskeable
    {
        private int[] yourNums = new int[3];
        public void InicelisationChek()
        {
            for (int i = 0; i < yourNums.Length; i++)
            {
                Console.WriteLine("Input side " + (i + 1) + ":");
                while (!int.TryParse(Console.ReadLine(), out yourNums[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer:");
                }
            }
        }
        public void Check()
        {
            for (int i = 0; i < yourNums.Length; i++)
            {
                if (yourNums[i] < 26 && yourNums[i] > 1)
                {
                    Console.WriteLine(yourNums[i]);
                }
            }
        }
        public void StartTask()
        {
            Console.WriteLine("Task 1");

            InicelisationChek();
            Check();
        }
    }
}

