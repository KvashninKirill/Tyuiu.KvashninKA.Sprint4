using Tyuiu.KvashninKA.Sprint4.Task5.V29.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task5.V29.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { -5, 2, -3, 4, -1 },
                { 6, -7, 8, -9, 1 },
                { -2, 3, -4, 5, -6 },
                { 7, -8, 9, -1, 2 },
                { -3, 4, -5, 6, -7 }
            };

            int res = ds.Calculate(mas2);
            int wait = 12;

            Assert.AreEqual(wait, res);
        }
    }
}
