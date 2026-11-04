using Tyuiu.BedenkoAN.Sprint4.Task0.V9.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ar = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            DataService ds = new DataService();
            int res = ds.GetSumEvenArrEl(ar);
            int wait = 38;
            Assert.AreEqual(wait,res);


        }
    }
}
