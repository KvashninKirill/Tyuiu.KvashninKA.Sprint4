using Tyuiu.KvashninKA.Sprint4.Task0.V14.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task0.V14.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int res = ds.GetSumOddArrEl(numsArray);
            int wait = 30;

            Assert.AreEqual(wait, res);
        }
    }
}