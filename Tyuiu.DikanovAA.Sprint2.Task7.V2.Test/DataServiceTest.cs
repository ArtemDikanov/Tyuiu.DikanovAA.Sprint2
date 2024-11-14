using Tyuiu.DikanovAA.Sprint2.Task7.V2.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.2;
            double y = 0.1;

            bool wait = true;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}

