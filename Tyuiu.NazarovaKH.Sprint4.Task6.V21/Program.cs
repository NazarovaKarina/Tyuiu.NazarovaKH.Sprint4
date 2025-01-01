using Tyuiu.NazarovaKH.Sprint4.Task6.V21.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task6.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("*Дан строковой массив данных (Facebook, Twitter, Instagram, Snapchat, LinkedIn,*");
            Console.WriteLine("*Pinterest, Reddit) используя класс Array подсчитайте количество элементов, дли*");
            Console.WriteLine("*на которых меньше 8.                                                          *");
            Console.WriteLine("********************************************************************************");

            var week = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };

            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= week.Length - 1; i++)
            {
                Console.WriteLine(week[i]);
            }
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Количество элементов, длина которых меньше 8:                              *");

            int nums = ds.Calculate(week);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
