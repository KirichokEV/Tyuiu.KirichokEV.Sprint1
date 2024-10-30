using Tyuiu.KirichokEV.Sprint1.Task7.V4.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task7.V4.Test
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
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.89, res);

        }
    }
}