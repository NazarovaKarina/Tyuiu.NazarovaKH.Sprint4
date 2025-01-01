using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NazarovaKH.Sprint4.Task5.V29.Lib
{
    public class DataService : ISprint4Task5V29
    {
        public int Calculate(int[,] matrix)
        {
            int positiveCount = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    positiveCount++;
                }
            }
            return positiveCount;
        }
    }
}
