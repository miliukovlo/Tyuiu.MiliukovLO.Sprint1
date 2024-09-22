using Tyuiu.MiliukovLO.Sprint1.Task7.V6.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual(-1498.783, dataService.Calculate(5, 5));
        }
    }
}