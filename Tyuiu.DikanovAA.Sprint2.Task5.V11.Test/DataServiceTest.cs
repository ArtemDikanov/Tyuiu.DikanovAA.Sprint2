using Tyuiu.DikanovAA.Sprint2.Task5.V11.Lib;
namespace Tyuiu.DikanovAA.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 11;
            int n = 14;
            string wait = "15.11.2024";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);



        }
    }
}