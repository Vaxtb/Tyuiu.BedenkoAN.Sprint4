using Tyuiu.BedenkoAN.Sprint4.Task7.V26.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string z = "132321453";
            int rows = 3;

            int cols = 3;
            DataService ds = new DataService();
            int res =ds.Calculate(rows, cols,z);
            int wait = 16;
            Assert.AreEqual(wait,res);

        }
    }
}
