using Tyuiu.OzdoevaLM.Sprint2.Task4.V7.Lib;

namespace Tyuiu.OzdoevaLM.Sprint2.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.00;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 79;
            Assert.AreEqual(wait, res);
        }
    }
}
