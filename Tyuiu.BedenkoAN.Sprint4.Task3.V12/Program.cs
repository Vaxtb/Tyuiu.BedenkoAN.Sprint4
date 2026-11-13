
using Tyuiu.BedenkoAN.Sprint4.Task3.V12.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Беденко А.Н. | ПИНб-26-1";

            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #4                                          *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)         *");
            Console.WriteLine("* Задание #3                                         *");
            Console.WriteLine("* Вариант #12                                        *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5          *");
            Console.WriteLine("* элементов, заполненный статическими значениями     *");
            Console.WriteLine("* в диапазоне от 2 до 9. Найдите минимальный элемент *");
            Console.WriteLine("* в третьем столбце массива.                         *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                   *");
            Console.WriteLine("******************************************************");

            DataService ds = new DataService();
            int[,] myArray = new int[,] {
    { 9, 7, 4, 9, 7 },
    { 5, 2, 5, 7, 6 },
    { 8, 3, 3, 5, 7 },
    { 8, 4, 2, 4, 5 },
    { 8, 8, 9, 5, 6 }
};

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write($"{myArray[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                         *");
            Console.WriteLine("******************************************************");

            int result = ds.Calculate(myArray);

            Console.WriteLine($"Минимальный элемент в третьем столбце: {result}");

            Console.ReadLine();


        }
    }
}
