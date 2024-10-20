using Tyuiu.KirichokEV.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = 5;
            double z = 1;
            double h = 7;
            double w = 5;
            double p = -3;
            double wait = 19;
            var res = ds.TriangleArea(x, y, z, h, w, p);
            Assert.AreEqual(wait, res);

        }
    }
}