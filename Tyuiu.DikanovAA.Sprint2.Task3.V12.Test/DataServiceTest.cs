using Tyuiu.DikanovAA.Sprint2.Task3.V12.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConditional1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 11;
            double res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);

        } 
        [TestMethod]
        public void ValidConditional2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1.54;
            double res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidConditional3()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 12;
            double res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidConditional4()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95;
            double res = Math.Round(ds.Calculate(x), 3);
            Assert.AreEqual(wait, res);

        }
    }
}