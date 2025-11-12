using Tyuiu.PrilukovDA.Sprint2.Task0.V30.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] wait = new bool[] { true, false, true, false, true, false }; 
            CollectionAssert.AreEqual(wait, ds.GetCompareOperations(95, 1735));
        }
    }
}
