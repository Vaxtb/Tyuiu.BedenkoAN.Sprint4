using Tyuiu.BedenkoAN.Sprint4.Task6.V24.Lib;
namespace Tyuiu.BedenkoAN.Sprint4.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] x = { "Компьютер", "dddsasdfa", "fuu" };
            string[] res = ds.Calculate(x);
            string[] wait = { "Компьютер", "dddsasdfa" };
            CollectionAssert.AreEqual(wait, res);



        }
    }
}
