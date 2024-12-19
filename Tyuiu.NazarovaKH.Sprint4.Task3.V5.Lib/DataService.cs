using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NazarovaKH.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int sumArray = 0;
            for (int j = 0; j < cols; j++)
            {
                sumArray += array[0, j];
            }
            return sumArray;
        }
    }
}