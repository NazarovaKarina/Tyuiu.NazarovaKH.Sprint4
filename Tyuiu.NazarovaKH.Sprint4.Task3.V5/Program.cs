using Tyuiu.NazarovaKH.Sprint4.Task3.V5.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("********************************************************************************");

            int[,] array = { { 3, 4, 8, 6, 3 },
                             { 9, 9, 3, 6, 9 },
                             { 5, 6, 7, 2, 3 },
                             { 3, 6, 2, 3, 8 },
                             { 5, 7, 2, 6, 4 } };

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("********************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ                                                                    *");
                Console.WriteLine("********************************************************************************");

                var result = ds.Calculate(array);
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
