using Tyuiu.KvashninKA.Sprint4.Task6.V22.Lib;
namespace Tyuiu.KvashninKA.Sprint4.Task6.V22.Lib

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] weather = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };
            string[] res = ds.Calculate(weather);
            string[] wait = new string[] { "Снег", "Град", "Туча" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
