using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            {
                Console.Write("Введите количество строк в матрицах: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов в матрицах: ");
                int col = int.Parse(Console.ReadLine());

                int[,] matrixA = new int[row, col];  // объявляем и инициализируем двумерные массивы А,Б,В
                int[,] matrixB = new int[row, col]; // с заданным пользователем количеством строк и столбцов
                int[,] matrixC = new int[row, col];

                Random r = new Random(); // инициализируем генератор рандомных чисел

                Console.WriteLine($"Матрица А: ");
                for (int i = 0; i < row; i++) // задаем вложенный цикл для строк матриц
                {

                    for (int j = 0; j < col; j++) // задаем вложенный цикл для столбцов матриц
                    {
                        matrixA[i, j] = r.Next(10); // заполняем матрицы рандомными числами

                        Console.Write($"{matrixA[i, j],2}"); // выводим матрицу А

                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Матрица Б: "); // Повторяем те же шаги для матрицы Б
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrixB[i, j] = r.Next(10);

                        Console.Write($"{matrixB[i,j],2}");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Сумма матриц А и Б (матрица В): "); // В матрицу В кладем сумму матриц А и Б
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        matrixC[i, j] = matrixA[i, j] + matrixB[i, j];

                        Console.Write($"{matrixC[i,j],2}");
                    }
                    Console.WriteLine();
                }

            }


            Console.ReadKey();
        }
    }
}