using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KvashninKA.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int colIndex = 2; 
            int min = array[0, colIndex];

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, colIndex] < min)
                {
                    min = array[i, colIndex];
                }
            }

            return min;
        }
    }
}
