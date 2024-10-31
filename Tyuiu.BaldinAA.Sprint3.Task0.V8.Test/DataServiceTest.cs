using Tyuiu.BaldinAA.Sprint3.Task0.V8.Lib;
namespace Tyuiu.BaldinAA.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultypliesSeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1, stopValue = 10;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(0.019, res);
        }
    }
}