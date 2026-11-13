using Tyuiu.BedenkoAN.Sprint4.Task7.V26.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Беденко А.Н. | ПИНб-26-1";

            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #4                                          *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту*");
            Console.WriteLine("* Задание #7                                         *");
            Console.WriteLine("* Вариант #26                                        *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.*");
            Console.WriteLine("*                                                    *");
            Console.WriteLine("*                                                    *");
            Console.WriteLine("*                                                    *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                   *");
            Console.WriteLine("******************************************************");
            string x = "351268459614723";
            int rows = 5;
            int col = 3;
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i= 0; i < rows;i++ )
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{x[index]}\t");
                    index++;

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            DataService ds = new DataService();

            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                         *");
            Console.WriteLine("******************************************************");
            int res = ds.Calculate(rows,col,x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
