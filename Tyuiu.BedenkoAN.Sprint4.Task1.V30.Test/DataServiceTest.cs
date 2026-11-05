using Tyuiu.BedenkoAN.Sprint4.Task1.V30.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar = { 6, 7, 8, 7, 6, 5, 6, 9, 9, 5, 7, 9, 7, 8, 7 };
            int wait = 8 * 6 * 6 * 8*6;
            DataService ds = new DataService();
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
            
        }
    }
}
