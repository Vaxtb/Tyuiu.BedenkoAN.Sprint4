using Tyuiu.BedenkoAN.Sprint4.Task5.V20.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Беденко А.Н. | ПИНб-26-1";

            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #4                                          *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)        *");
            Console.WriteLine("* Задание #5                                         *");
            Console.WriteLine("* Вариант #20                                        *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5          *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -7 до 3.*");
            Console.WriteLine("* Найти сумму положительных элементов.               *");
            Console.WriteLine("*                                                    *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве:");
            int colomns = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();

            DataService ds = new DataService();
            int[,] matrix = new int[rows, colomns];




            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    matrix[i, j] = rnd.Next(-7, 3);
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                         *");
            Console.WriteLine("******************************************************");

            int result = ds.Calculate(matrix);

            Console.WriteLine($"сумму положительных элементов: {result}");

            Console.ReadLine();
        }
    }
}
