using Tyuiu.KvashninKA.Sprint4.Task2.V7.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task2.V7.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 36;

            Assert.AreEqual(wait, res); 
        }
    }
}