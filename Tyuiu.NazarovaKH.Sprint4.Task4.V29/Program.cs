using Tyuiu.NazarovaKH.Sprint4.Task4.V29.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("Найти сумму четных элементов массива: ");
            Console.WriteLine(" 5, 6, 5, 6, 5 ");
            Console.WriteLine(" 5, 5, 5, 8, 4 ");
            Console.WriteLine(" 8, 5, 5, 8, 8 ");
            Console.WriteLine(" 6, 5, 4, 4, 8 ");
            Console.WriteLine(" 8, 5, 6, 8, 8 ");
            Console.WriteLine("********************************************************************************");

            int[,] array = { { 5, 6, 5, 6, 5 },
                             { 5, 5, 5, 8, 4 },
                             { 8, 5, 5, 8, 8 },
                             { 6, 5, 4, 4, 8 },
                             { 8, 5, 6, 8, 8 } };

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                    *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine($"Сумма четных элементов массива равна = {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
