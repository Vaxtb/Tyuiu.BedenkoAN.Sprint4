
using Tyuiu.BedenkoAN.Sprint4.Task2.V30.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов                     *");
            Console.WriteLine("* заполненный случайными в диапазоне от 2 до 8 подсчитать произведение нечетных элементов массива. *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Число элементов в массиве");


            Console.WriteLine("Элементы массива");
            int len = 12;
            int[] numsar = new int[len];
            Random rnd = new Random();
            for (int i = 0; i < len; i++)
            {
                numsar[i] = rnd.Next(2,8 );
                
            }



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsar);
            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}
