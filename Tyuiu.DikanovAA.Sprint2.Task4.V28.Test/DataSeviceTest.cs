using Tyuiu.DikanovAA.Sprint2.Task4.V28.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task4.V28.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            double res = ds.Calculate(x, y);
            double wait = 9;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 0.392;
            Assert.AreEqual(wait, res);
        }
    }
}