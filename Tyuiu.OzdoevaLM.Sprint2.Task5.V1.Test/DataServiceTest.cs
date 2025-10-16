using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.OzdoevaLM.Sprint2.Task5.V1.Lib;

namespace Tyuiu.OzdoevaLM.Sprint2.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();

            StringAssert.Equals("Январь", ds.FindMonthDaysCount(1));
            StringAssert.Equals("Февраль", ds.FindMonthDaysCount(2));
            StringAssert.Equals("Март", ds.FindMonthDaysCount(3));
            StringAssert.Equals("Апрель", ds.FindMonthDaysCount(4));
            StringAssert.Equals("Май", ds.FindMonthDaysCount(5));
            StringAssert.Equals("Июнь", ds.FindMonthDaysCount(6));
            StringAssert.Equals("Июль", ds.FindMonthDaysCount(7));
            StringAssert.Equals("Август", ds.FindMonthDaysCount(8));
            StringAssert.Equals("Сентябрь", ds.FindMonthDaysCount(9));
            StringAssert.Equals("Октябрь", ds.FindMonthDaysCount(10));
            StringAssert.Equals("Ноябрь", ds.FindMonthDaysCount(11));
            StringAssert.Equals("Декабрь", ds.FindMonthDaysCount(12));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(-1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindMonthDaysCount(13);
            });

        }
    }
}
