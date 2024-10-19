using Tyuiu.KirichokEV.Sprint1.Task2.V13.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 7;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(11.263, res);
        }
    }
}