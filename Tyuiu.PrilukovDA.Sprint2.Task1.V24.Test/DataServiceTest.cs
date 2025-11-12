using Tyuiu.PrilukovDA.Sprint2.Task1.V24.Lib;

namespace Tyuiu.PrilukovDA.Sprint2.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           DataService ds = new DataService();
            bool[] wait = new bool[] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(325, 325, 242, 324));
        }
    }
}
