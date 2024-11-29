using Tyuiu.NazarovaKH.Sprint4.Task0.V21.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("********************************************************************************");

            int[] sumArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };


            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.WriteLine(sumArray[i]);
            }

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Результующий массив");
            int res = ds.GetSumEvenArrEl(sumArray);
            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.WriteLine(sumArray[i] + "/t");
            }

            Console.Write(res);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
