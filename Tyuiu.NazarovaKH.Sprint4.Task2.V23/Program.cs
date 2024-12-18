using Tyuiu.NazarovaKH.Sprint4.Task2.V23.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task2.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("********************************************************************************");

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = rnd.Next(3, 8);
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                    *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
