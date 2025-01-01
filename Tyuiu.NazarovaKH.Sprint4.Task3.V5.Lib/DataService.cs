using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NazarovaKH.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
           
            int sumArray = 0;
            for (int j = 0; j < rows; j++)
            {
                sumArray += array[j, 0];
            }
            return sumArray;
        }
    }
}