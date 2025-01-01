using Tyuiu.NazarovaKH.Sprint4.Task4.V29.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 5, 6, 5, 6, 5 }, 
                                           { 5, 5, 5, 8, 4 },
                                           { 8, 5, 5, 8, 8 },
                                           { 6, 5, 4, 4, 8 },
                                           { 8, 5, 6, 8, 8 } };
            var wait = 100;
            var res = ds.Calculate(array);
            Assert.AreEqual(res, wait);

        }
    }
}