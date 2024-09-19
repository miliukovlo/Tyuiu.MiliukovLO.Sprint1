using Tyuiu.MiliukovLO.Sprint1.Task3.V4.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int count = 10;
            Assert.AreEqual(32.5, ds.PurchaseAmount(priceNotebook, priceCover, count));
        }
    }
}