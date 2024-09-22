using Tyuiu.MiliukovLO.Sprint1.Task6.V18.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckNumber("122"));
        }
    }
}