using Tyuiu.PrilukovDA.Sprint2.Task7.V9.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.3, 0.5));
        }
    }
}
