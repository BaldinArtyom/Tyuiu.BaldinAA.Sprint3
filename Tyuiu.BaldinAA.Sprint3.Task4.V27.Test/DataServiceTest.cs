using Tyuiu.BaldinAA.Sprint3.Task4.V27.Lib;
namespace Tyuiu.BaldinAA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(-44.313, res);
        }
    }
}