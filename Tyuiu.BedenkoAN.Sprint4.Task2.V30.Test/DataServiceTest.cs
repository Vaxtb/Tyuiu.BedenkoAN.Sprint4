using Tyuiu.BedenkoAN.Sprint4.Task2.V30.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task2.V30.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ar = new int[] { 1, 2, 3 ,6,7};
            int res = ds.Calculate(ar);
            int wait = 21;
            Assert.AreEqual(wait, res);


        }
    }
}
