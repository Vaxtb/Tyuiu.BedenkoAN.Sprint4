using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BedenkoAN.Sprint4.Task5.V20.Lib
{
    public class DataService : ISprint4Task5V20
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int colomus = matrix.Length / 5;
            int c = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomus; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        c += matrix[i, j];
                    }
                }
            }
            return c;
        }
    }
}
