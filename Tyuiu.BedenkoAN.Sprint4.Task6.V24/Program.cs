using Tyuiu.BedenkoAN.Sprint4.Task6.V24.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Беденко А.Н. | ПИНб-26-1";

            Console.WriteLine("******************************************************");
            Console.WriteLine("* Спринт #4                                          *");
            Console.WriteLine("* Тема: Класс Array                                  *");
            Console.WriteLine("* Задание #6                                         *");
            Console.WriteLine("* Вариант #24                                        *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1   *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                           *");
            Console.WriteLine("* Дан строковый массив данных                        *");
            Console.WriteLine("* [\"Компьютер\", \"Телефон\", \"Планшет\", \"Принтер\",*");
            Console.WriteLine("* \"Сканер\", \"Монитор\", \"Клавиатура\"],          *");
            Console.WriteLine("* используя класс Array, выведите элементы массива,  *");
            Console.WriteLine("*  длина которых больше 7 символов.                  *");
            Console.WriteLine("******************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                   *");
            Console.WriteLine("******************************************************");
            string[] x = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            foreach (string s in x)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            DataService ds = new DataService();
            
            Console.WriteLine();
            Console.WriteLine("******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                         *");
            Console.WriteLine("******************************************************");
            string[] res = ds.Calculate(x);
            foreach (string i in res)
            {
                Console.WriteLine(i);
            }

           
        }
    }
}
