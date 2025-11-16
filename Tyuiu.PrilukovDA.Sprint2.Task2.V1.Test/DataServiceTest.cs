using Tyuiu.PrilukovDA.Sprint2.Task2.V1.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(3, 3));
        }
    }
}
