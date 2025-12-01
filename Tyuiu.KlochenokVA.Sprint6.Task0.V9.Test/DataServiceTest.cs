using Tyuiu.KlochenokVA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.KlochenokVA.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CalcCheck()
        {
            var ds = new DataService();
            int x = 3;
            double wait = -2.556;
            Assert.AreEqual(ds.Calculate(x), wait);
        }
    }
}
