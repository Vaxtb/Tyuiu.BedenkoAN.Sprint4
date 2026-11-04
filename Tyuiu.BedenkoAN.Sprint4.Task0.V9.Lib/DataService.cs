using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BedenkoAN.Sprint4.Task0.V9.Lib
{
    public class DataService : ISprint4Task0V9

    {
        public int GetSumEvenArrEl(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res += array[i];

                }
            }
            return res;


        }
    }
}
