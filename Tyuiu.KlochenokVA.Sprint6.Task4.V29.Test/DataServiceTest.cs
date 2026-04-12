using Tyuiu.KlochenokVA.Sprint6.Task4.V29.Lib;
namespace Tyuiu.KlochenokVA.Sprint6.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-1, 1);
            double wait = -9;
            Assert.AreEqual(res[1], wait);
        }
    }
}
