using Tyuiu.PrilukovDA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Суббота", ds.FindDayName(7, 7));
        }
    }
}
