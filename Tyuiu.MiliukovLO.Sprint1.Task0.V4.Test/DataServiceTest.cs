using Tyuiu.MiliukovLO.Sprint1.Task0.V4.Lib;

namespace Tyuiu.MiliukovLO.Sprint1.Task0.V4.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        Assert.AreEqual(6, ds.Calculate());
    }
}