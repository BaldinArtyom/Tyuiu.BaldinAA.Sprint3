using Tyuiu.BaldinAA.Sprint3.Task1.V19.Lib;
namespace Tyuiu.BaldinAA.Sprint3.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 96.895;

            Assert.AreEqual(wait, res);
        }
    }
}