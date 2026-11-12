using Tyuiu.KvashninKA.Sprint4.Task3.V12.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task3.V12.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] insArray = new int[,]
            {
                { 9, 7, 4, 9, 7 },
                { 5, 2, 5, 7, 6 },
                { 8, 3, 3, 5, 7 },
                { 8, 4, 2, 4, 5 },
                { 8, 8, 9, 5, 6 }
            };

            int res = ds.Calculate(insArray);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
