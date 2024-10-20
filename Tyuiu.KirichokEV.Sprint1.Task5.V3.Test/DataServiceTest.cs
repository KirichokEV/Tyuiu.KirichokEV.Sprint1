using Tyuiu.KirichokEV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 5673982;
            DataService ds = new DataService();
            var res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int h = 9;
            Assert.AreEqual(h, result);

        }
    }
}