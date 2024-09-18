using Tyuiu.MiliukovLO.Sprint1.Task2.V4.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int res = ds.CalculateSquare(x);
            Assert.AreEqual(25, res);
        }
    }
}