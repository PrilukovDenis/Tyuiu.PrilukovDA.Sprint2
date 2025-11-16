using Tyuiu.PrilukovDA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
                DataService ds = new DataService();
            Assert.AreEqual("18.6.2002", ds.FindDateOfPreviousDay(2002, 6, 19));
        }
    }
}
