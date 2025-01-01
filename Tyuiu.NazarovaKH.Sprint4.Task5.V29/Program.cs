using Tyuiu.NazarovaKH.Sprint4.Task5.V29.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task5.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService(); 

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными зн*");
            Console.WriteLine("*ачениями в диапазоне от -9 до 9. Найти количество положительных элементов     *");        
            Console.WriteLine("********************************************************************************");

            Random rand = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();

                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                                                                    *");
                Console.WriteLine("********************************************************************************");

                var res = ds.Calculate(matrix);
                Console.WriteLine("Кол-во положительных элементов массива: " + res);
                Console.ReadKey();
            }
        }
    }
}
