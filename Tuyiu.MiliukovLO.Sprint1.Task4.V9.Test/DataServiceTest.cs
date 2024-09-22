using Tyuiu.MilyukovLO.Sprint1.Task4.V9.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            var dataService = new DataService();
            Assert.AreEqual(0.798, dataService.Calculate(10, 5));

        }
    }
}