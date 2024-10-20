using Tyuiu.KirichokEV.Sprint1.Task4.V8.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 8;
            double wait = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}