using Tyuiu.KvashninKA.Sprint4.Task7.V27.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task7.V27.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "583197256891";

            int res = ds.Calculate(n, m, value);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
