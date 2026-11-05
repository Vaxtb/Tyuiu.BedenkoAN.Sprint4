using System.ComponentModel.DataAnnotations;
using Tyuiu.BedenkoAN.Sprint4.Task1.V30.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task1.V30
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                            *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный значениями                     *");
            Console.WriteLine("* с клавиатуры в диапазоне от 5 до 9 подсчитать произведение четных элементов массива.              *");
            Console.WriteLine("*С клавиатуры: 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7                *");  
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Число элементов в массиве");

            
            Console.WriteLine("Элементы массива");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsar = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Ввидите значение " + i + " элемента массива");
                numsar[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(numsar);
            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}
