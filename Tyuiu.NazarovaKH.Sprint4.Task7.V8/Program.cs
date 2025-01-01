using Tyuiu.NazarovaKH.Sprint4.Task7.V8.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task7.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                              *");
            Console.WriteLine("********************************************************************************");

            string value = "264795863157";
            int rows = 3;
            int columns = 4;

            Console.WriteLine($"Строка: {value}");
            Console.WriteLine($"Размер матрицы: {rows}x{columns}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                                    *");
            Console.WriteLine("********************************************************************************");

            int res = ds.Calculate(rows, columns, value); 
            Console.WriteLine($"Сумма нечетных элементов: {res}");
            Console.ReadKey();
        }
    }
}
