using Tyuiu.BedenkoAN.Sprint4.Task4.V19.Lib;

namespace Tyuiu.BedenkoAN.Sprint4.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] mat = { 
                { 6, 7, 3, 5, 1 }, 
                { 6, 5, 2, 2, 7 }, 
                { 2, 6, 4, 6, 6 }, 
                { 7, 5, 5, 2, 6 }, 
                { 3, 1, 5, 7, 7 } };
            int wait = 68;
            DataService ds = new DataService();
            int res = ds.Calculate(mat);
            Assert.AreEqual(wait, res);
        }
    }
}
