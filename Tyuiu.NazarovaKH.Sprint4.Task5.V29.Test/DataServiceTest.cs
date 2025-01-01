using Tyuiu.NazarovaKH.Sprint4.Task5.V29.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = { { -2, 3, 4, 5, -1 },
                              { 7, -8, -6, 2, 1 },
                              { -4, -5, 6, 1, 3 },
                              { -5, -2, 1, 5, 6 },
                              { 1, 3, 4, -8, -7 } };
            int res = ds.Calculate(matrix);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}