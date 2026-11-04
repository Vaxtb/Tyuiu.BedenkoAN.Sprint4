using Tyuiu.BedenkoAN.Sprint4.Task0.V9.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task0.V9
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов                     *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9               *");
            Console.WriteLine("*подсчитать сумму четных элементов массива.  {4 ,6 ,2 ,8 ,4 ,5 ,6 ,9 ,8 ,7}*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] ar = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.GetSumEvenArrEl(ar);
            Console.WriteLine(res);


            
            Console.ReadKey();
        }
    }
}
