using Tyuiu.NazarovaKH.Sprint4.Task0.V21.Lib;

namespace Tyuiu.NazarovaKH.Sprint4.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] sumArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int res = ds.GetSumEvenArrEl(sumArray);
            int sumWait = 36;

            Assert.AreEqual(sumWait, res);
        }
    }
}