using Tyuiu.KvashninKA.Sprint4.Task1.V27.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task1.V27.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5 };
            int res = ds.Calculate(numsArray);
            int wait = 256;

            Assert.AreEqual(wait, res);
        }
    }
}