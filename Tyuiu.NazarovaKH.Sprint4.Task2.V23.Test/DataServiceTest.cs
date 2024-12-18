using Tyuiu.NazarovaKH.Sprint4.Task2.V23.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 3, 4, 6, 8, 4, 8 };

            int res = ds.Calculate(array);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}