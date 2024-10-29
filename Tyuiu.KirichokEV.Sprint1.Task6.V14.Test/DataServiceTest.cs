using Tyuiu.KirichokEV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KirichokEV.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "машина";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(strTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

    }
}