using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BedenkoAN.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int c = 10;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (c > array[i, 2])
                {
                    c = array[i, 2];
                }
            }
            return c;

        }
    }
}
