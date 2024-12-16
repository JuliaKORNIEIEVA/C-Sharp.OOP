using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Task2 : ITaskeable
    {
        private int[] triangle = new int[3];
        public void Inicelisation()
        {
            for (int i = 0; i < triangle.Length; i++)
            {
                Console.WriteLine("Input side " + (i + 1) + ":");
                while (!int.TryParse(Console.ReadLine(), out triangle[i]) || triangle[i] <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer:");
                }
            }
        }
        public bool Check()
        {
            return triangle[0] <= 0 || triangle[2] <= 0 || triangle[2] <= 0;
        }
        public void Typ_of_triangle()
        {
            if (triangle[0] == triangle[1] && triangle[2] == triangle[1])
            {
                Console.WriteLine("Your triangle is  Ровностороный");
            }
            else if (triangle[0] == triangle[1] && triangle[2] != triangle[1])
            {
                Console.WriteLine("Your triangle is  Ровнобедреный");
            }

            else
            {
                Console.WriteLine("your triangle is Разносоронный");
            }
        }
        public int Funktion()
        {
            return triangle[1] + triangle[2] + triangle[0];

        }
        public void Perimetr()
        {
            int P = Funktion();
            Console.WriteLine("Your Perimetr is :" + P);
        }
        public void Plosha()
        {
            int P = Funktion();
            int p = P / 2;
            int Form = p * (p - triangle[0]) * (p - triangle[1]) * (p - triangle[2]);
            double S = Math.Sqrt(Form);
            Console.WriteLine("Your Plosha is:" + S);
        }
        public void StartTask()
        {
            Console.WriteLine("Task 2 | StartTask");

            Inicelisation();
            bool checkingTriangle = Check();
            if (Check())
            {
                Typ_of_triangle();
                Perimetr();
                Plosha();
            }

        }
    }
}

