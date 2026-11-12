using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KvashninKA.Sprint4.Task5.V29.Lib
{
    public class DataService : ISprint4Task5V29
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
