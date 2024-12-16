using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr1
{
    internal class Task4 : ITaskeable
    {
            // Метод для генерации массива X
        static int[] GenerateArray(int length)
        {
            Random rand = new Random();
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-100, 101); // Заполнение массива случайными числами от -100 до 100
            }
            return array;
        }
       

        // Метод для фильтрации массива Y по модулю
        static int[] FilterArray(int[] X, int M)
        {
            return Array.FindAll(X, element => Math.Abs(element) > M);
        }

        // Метод для отображения результатов
        static void DisplayResults(int[] X, int[] Y, int M)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Число M: " + M);
            Console.WriteLine("Массив X: " + string.Join(", ", X));
            Console.WriteLine("Массив Y: " + string.Join(", ", Y));
        }

        public void StartTask()
        {
            int lastDigitOfStudentId = 7; // Замените 7 на последнюю цифру вашего номера
            int lengthOfX = 10 + lastDigitOfStudentId;

            int[] X = GenerateArray(lengthOfX);

            int M;
            Console.Write("Введите число M: ");
            while (!int.TryParse(Console.ReadLine(), out M))
            {
                Console.WriteLine("Invalid input.");
            }

            int[] Y = FilterArray(X, M);

            DisplayResults(X, Y, M);
        }
    }
}

