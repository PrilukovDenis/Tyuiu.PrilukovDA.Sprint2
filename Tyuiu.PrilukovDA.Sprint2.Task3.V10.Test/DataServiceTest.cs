using Tyuiu.PrilukovDA.Sprint2.Task3.V10.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(6.333, ds.Calculate(1));
        }
    }
}
