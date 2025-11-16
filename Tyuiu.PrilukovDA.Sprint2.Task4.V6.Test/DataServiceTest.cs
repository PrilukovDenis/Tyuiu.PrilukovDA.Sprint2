using Tyuiu.PrilukovDA.Sprint2.Task4.V6.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1, ds.Calculate(1, 2));
        }
    }
}
