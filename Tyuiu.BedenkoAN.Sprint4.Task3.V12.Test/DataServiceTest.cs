
using Tyuiu.BedenkoAN.Sprint4.Task3.V12.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            int[,] myAr = new int[,] {
         { 9, 7, 4, 9, 7 },
         { 5, 2, 5, 7, 6 },
         { 8, 3, 3, 5, 7 },
         { 8, 4, 2, 4, 5 },
         { 8, 8, 9, 5, 6 }
                     };
            int wait = 2;
            DataService ds = new DataService();
            int res = ds.Calculate(myAr);
            Assert.AreEqual(wait, res);

        }
    }
}
