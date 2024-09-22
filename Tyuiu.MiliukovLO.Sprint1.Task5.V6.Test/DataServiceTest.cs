using Tyuiu.MiliukovLO.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual(35, dataService.Calculate(7));
        }
    }
}